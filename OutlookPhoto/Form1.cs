using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Security.Principal;
using System.DirectoryServices;
using System.Diagnostics;

namespace OutlookPhoto
{
    public partial class OutlookPhotoForm : Form
    {
        #region Constants

        private const long MAX_FILE_SIZE_IN_BYTES = 10 * 1024;
        private const int MAX_IMAGE_HEIGHT_IN_PIXELS = 96;
        private const int MAX_IMAGE_WIDTH_IN_PIXELS = 96;
        private const string USER_SEARCH_TEMPLATE = "(&(objectCategory=user)(objectClass=user)(userPrincipalName={0}*))";
        private const string GROUP_SEARCH_TEMPLATE = "(&(objectCategory=group)(objectClass=group)({0}*))";
        private const string EXPRESSION_SEARCH_TEMPLATE = "{0}";

        #endregion

        #region Private Fields

        private SearchResult _cachedResult;
        private string _username;
        private bool _isGroup;
        private bool _isExpression;

        #endregion

        #region Constructor

        public OutlookPhotoForm(string[] args)
        {
            processCommandLine(args);

            InitializeComponent();
        }

        #endregion

        #region Event Handlers

        private void OutlookPhotoForm_Load(object sender, EventArgs e)
        {
            loadUserProfile();
        }

        private void GetPhotoButton_Click(object sender, EventArgs e)
        {
            getPhotoFromDisk();
        }

        private void SavePhotoButton_Click(object sender, EventArgs e)
        {
            savePhoto();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/mjalloul/OutlookPhoto/issues");
        }

        private void DeletePhotoButton_Click(object sender, EventArgs e)
        {
            // TODO: Enable this feature.
        }

        #endregion

        #region Private Methods

        private void getPhotoFromDisk()
        {
            DialogResult result = OpenPhotFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = OpenPhotFileDialog.FileName;

                // Validate size
                FileInfo fileInfo = new FileInfo(filename);
                if (fileInfo.Length > MAX_FILE_SIZE_IN_BYTES && !this.IgnorePhotoRestrictionsCheckBox.Checked)
                {
                    MessageBox.Show(string.Format("The photo size cannot be greater than {0} bytes.\r\n" +
                        "Current photo size: {1} bytes.\r\n\r\n" +
                        "NOTE: Check the 'Ignore photo restrictions' checkbox " +
                        "to ignore this restriction and upload photos of any size.", MAX_FILE_SIZE_IN_BYTES, fileInfo.Length),
                        "Invalid Photo Size",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Image image = Image.FromFile(OpenPhotFileDialog.FileName);

                if (image.Height > MAX_IMAGE_HEIGHT_IN_PIXELS && !this.IgnorePhotoRestrictionsCheckBox.Checked)
                {
                    MessageBox.Show(string.Format("The photo height cannot be greater than {0} pixels.\r\n" +
                        "Current photo height: {1} pixels.\r\n\r\n" +
                        "NOTE: Check the 'Ignore photo restrictions' checkbox " +
                        "to ignore this restriction and upload photos of any size.", MAX_IMAGE_HEIGHT_IN_PIXELS, image.Height),
                        "Invalid Photo Height",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                if (image.Width > MAX_IMAGE_WIDTH_IN_PIXELS && !this.IgnorePhotoRestrictionsCheckBox.Checked)
                {
                    MessageBox.Show(string.Format("The photo width cannot be greater than {0} pixels.\r\n" +
                        "Current photo width: {1} pixels.\r\n\r\n" +
                        "NOTE: Check the 'Ignore photo restrictions' checkbox " +
                        "to ignore this restriction and upload photos of any size.", MAX_IMAGE_WIDTH_IN_PIXELS, image.Width),
                        "Invalid Photo Width",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                NewPhotoPictureBox.Image = image;

                SavePhotoButton.Enabled = true;
            }
        }

        private void loadUserProfile()
        {
            // Get user profile from AD:
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            string usernameWithDomain = identity.Name.ToString();
            string username = _username ??
                usernameWithDomain.Substring(usernameWithDomain.LastIndexOf('\\') + 1);

            HelloLabel.Text = string.Format("Hello, {0} [{1}]", username, usernameWithDomain);

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Could not get current user name.",
                    "Unknown user",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            using (DirectoryEntry root = new DirectoryEntry())
            {
                string adQuery = string.Format(_isGroup ? GROUP_SEARCH_TEMPLATE : (_isExpression ? EXPRESSION_SEARCH_TEMPLATE : USER_SEARCH_TEMPLATE),
                    username.Replace(" ", "\\20"));

                using (DirectorySearcher searcher = new DirectorySearcher(root, adQuery, new string[] { "userPrincipalName" }))
                {
                    searcher.Asynchronous = false;
                    searcher.SearchScope = SearchScope.Subtree;
                    SearchResult result = searcher.FindOne();

                    if (result == null || string.IsNullOrEmpty(result.Path))
                    {
                        MessageBox.Show(string.Format("Could not get user profile for '{0}'.",
                            username),
                            "User not found",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                        using (DirectoryEntry user = result.GetDirectoryEntry())
                        {
                            _cachedResult = result;

                            byte[] thumbnailPhoto = user.Properties["thumbnailPhoto"].Value as byte[];

                            if (thumbnailPhoto != null)
                            {
                                using (MemoryStream stream = new MemoryStream(thumbnailPhoto))
                                {
                                    CurrentPhotoPictureBox.Image = Image.FromStream(stream); // can fail if the binary stream is not a valid photo
                                }
                            }
                        }
                    }
                    finally
                    {
                        GetPhotoButton.Enabled = true;
                    }
                }
            }
        }

        private void savePhoto()
        {
            using (DirectoryEntry user = _cachedResult.GetDirectoryEntry())
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    if (NewPhotoPictureBox.Image != null)
                    {
                        NewPhotoPictureBox.Image.Save(stream, NewPhotoPictureBox.Image.RawFormat);
                        byte[] thumbnailPhoto = new byte[stream.Length];
                        stream.Position = 0;
                        int bytesRead = stream.Read(thumbnailPhoto, 0, (int)stream.Length);

                        if (bytesRead != (int)stream.Length)
                        {
                            MessageBox.Show("Failed to save the photo.",
                                "Photo Save Failure",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            return;
                        }

                        user.Properties["thumbnailPhoto"].Value = thumbnailPhoto;
                        user.CommitChanges();
                    }
                    else
                    {
                        if (MessageBox.Show("This action will clear the current photo.\r\n" +
                            "Do you wish to continue?", "Delete Photo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            user.Properties["thumbnailPhoto"].Value = null;
                            user.CommitChanges();
                        }
                    }
                }
            }

            // Reload user profile to reflect new image:
            loadUserProfile();

            MessageBox.Show("New photo was successfully saved.",
                "Photo Saved Successfully",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void processCommandLine(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                if (args[0].StartsWith("/u:")) // user
                {
                    _username = args[0].Substring(args[0].IndexOf("/u:") + 3);
                }
                else if (args[0].StartsWith("/g:")) // group
                {
                    _username = args[0].Substring(args[0].IndexOf("/g:") + 3);
                    _isGroup = true;
                }
                else if (args[0].StartsWith("/e:")) // any valid ldap expression
                {
                    _username = args[0].Substring(args[0].IndexOf("/e:") + 3);
                    _isExpression = true;
                }
            }
        }

        #endregion
    }
}
