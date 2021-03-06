﻿namespace OutlookPhoto
{
    partial class OutlookPhotoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutlookPhotoForm));
            this.HelloLabel = new System.Windows.Forms.Label();
            this.CurrentPhotoLabel = new System.Windows.Forms.Label();
            this.CurrentPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.UploadNewPhotoLabel = new System.Windows.Forms.Label();
            this.OpenPhotFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.GetPhotoButton = new System.Windows.Forms.Button();
            this.NewPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.NewPhotoLabel = new System.Windows.Forms.Label();
            this.SavePhotoButton = new System.Windows.Forms.Button();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.InfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DeletePhotoButton = new System.Windows.Forms.Button();
            this.IgnorePhotoRestrictionsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(19, 20);
            this.HelloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(129, 20);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "Hello, <noname>";
            // 
            // CurrentPhotoLabel
            // 
            this.CurrentPhotoLabel.AutoSize = true;
            this.CurrentPhotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPhotoLabel.Location = new System.Drawing.Point(19, 62);
            this.CurrentPhotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CurrentPhotoLabel.Name = "CurrentPhotoLabel";
            this.CurrentPhotoLabel.Size = new System.Drawing.Size(126, 20);
            this.CurrentPhotoLabel.TabIndex = 1;
            this.CurrentPhotoLabel.Text = "Current Photo:";
            // 
            // CurrentPhotoPictureBox
            // 
            this.CurrentPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurrentPhotoPictureBox.Location = new System.Drawing.Point(180, 62);
            this.CurrentPhotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentPhotoPictureBox.Name = "CurrentPhotoPictureBox";
            this.CurrentPhotoPictureBox.Size = new System.Drawing.Size(143, 147);
            this.CurrentPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CurrentPhotoPictureBox.TabIndex = 2;
            this.CurrentPhotoPictureBox.TabStop = false;
            // 
            // UploadNewPhotoLabel
            // 
            this.UploadNewPhotoLabel.AutoSize = true;
            this.UploadNewPhotoLabel.Location = new System.Drawing.Point(19, 232);
            this.UploadNewPhotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UploadNewPhotoLabel.Name = "UploadNewPhotoLabel";
            this.UploadNewPhotoLabel.Size = new System.Drawing.Size(257, 20);
            this.UploadNewPhotoLabel.TabIndex = 3;
            this.UploadNewPhotoLabel.Text = "Click button to upload a new photo:";
            // 
            // GetPhotoButton
            // 
            this.GetPhotoButton.Enabled = false;
            this.GetPhotoButton.Location = new System.Drawing.Point(294, 225);
            this.GetPhotoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GetPhotoButton.Name = "GetPhotoButton";
            this.GetPhotoButton.Size = new System.Drawing.Size(159, 35);
            this.GetPhotoButton.TabIndex = 4;
            this.GetPhotoButton.Text = "Get Photo...";
            this.InfoToolTip.SetToolTip(this.GetPhotoButton, "Click to get a new photo to replace the existing photo.");
            this.GetPhotoButton.UseVisualStyleBackColor = true;
            this.GetPhotoButton.Click += new System.EventHandler(this.GetPhotoButton_Click);
            // 
            // NewPhotoPictureBox
            // 
            this.NewPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewPhotoPictureBox.Location = new System.Drawing.Point(180, 380);
            this.NewPhotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewPhotoPictureBox.Name = "NewPhotoPictureBox";
            this.NewPhotoPictureBox.Size = new System.Drawing.Size(143, 147);
            this.NewPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.NewPhotoPictureBox.TabIndex = 6;
            this.NewPhotoPictureBox.TabStop = false;
            // 
            // NewPhotoLabel
            // 
            this.NewPhotoLabel.AutoSize = true;
            this.NewPhotoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPhotoLabel.Location = new System.Drawing.Point(19, 380);
            this.NewPhotoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NewPhotoLabel.Name = "NewPhotoLabel";
            this.NewPhotoLabel.Size = new System.Drawing.Size(100, 20);
            this.NewPhotoLabel.TabIndex = 5;
            this.NewPhotoLabel.Text = "New Photo:";
            // 
            // SavePhotoButton
            // 
            this.SavePhotoButton.Enabled = false;
            this.SavePhotoButton.Location = new System.Drawing.Point(180, 541);
            this.SavePhotoButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SavePhotoButton.Name = "SavePhotoButton";
            this.SavePhotoButton.Size = new System.Drawing.Size(143, 35);
            this.SavePhotoButton.TabIndex = 7;
            this.SavePhotoButton.Text = "Save New Photo";
            this.InfoToolTip.SetToolTip(this.SavePhotoButton, "Click to save new photo to Exchange server.");
            this.SavePhotoButton.UseVisualStyleBackColor = true;
            this.SavePhotoButton.Click += new System.EventHandler(this.SavePhotoButton_Click);
            // 
            // NotesLabel
            // 
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(19, 265);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(433, 75);
            this.NotesLabel.TabIndex = 8;
            this.NotesLabel.Text = "Note: Photo must be 96x96 and less than 10K in size.\r\nCheck the box below to igno" +
    "re this restriction and upload photos of any size.";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(19, 585);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(170, 20);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to log issues";
            this.InfoToolTip.SetToolTip(this.linkLabel1, "Click on this link if you run into issues.");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DeletePhotoButton
            // 
            this.DeletePhotoButton.Location = new System.Drawing.Point(335, 541);
            this.DeletePhotoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeletePhotoButton.Name = "DeletePhotoButton";
            this.DeletePhotoButton.Size = new System.Drawing.Size(117, 35);
            this.DeletePhotoButton.TabIndex = 11;
            this.DeletePhotoButton.Text = "Delete Photo";
            this.InfoToolTip.SetToolTip(this.DeletePhotoButton, "Click to delete the current photo from Exchange Server.");
            this.DeletePhotoButton.UseVisualStyleBackColor = true;
            this.DeletePhotoButton.Visible = false;
            this.DeletePhotoButton.Click += new System.EventHandler(this.DeletePhotoButton_Click);
            // 
            // IgnorePhotoRestrictionsCheckBox
            // 
            this.IgnorePhotoRestrictionsCheckBox.AutoSize = true;
            this.IgnorePhotoRestrictionsCheckBox.Location = new System.Drawing.Point(22, 344);
            this.IgnorePhotoRestrictionsCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IgnorePhotoRestrictionsCheckBox.Name = "IgnorePhotoRestrictionsCheckBox";
            this.IgnorePhotoRestrictionsCheckBox.Size = new System.Drawing.Size(207, 24);
            this.IgnorePhotoRestrictionsCheckBox.TabIndex = 10;
            this.IgnorePhotoRestrictionsCheckBox.Text = "Ignore photo restrictions";
            this.IgnorePhotoRestrictionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OutlookPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 611);
            this.Controls.Add(this.DeletePhotoButton);
            this.Controls.Add(this.IgnorePhotoRestrictionsCheckBox);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.SavePhotoButton);
            this.Controls.Add(this.NewPhotoPictureBox);
            this.Controls.Add(this.NewPhotoLabel);
            this.Controls.Add(this.GetPhotoButton);
            this.Controls.Add(this.UploadNewPhotoLabel);
            this.Controls.Add(this.CurrentPhotoPictureBox);
            this.Controls.Add(this.CurrentPhotoLabel);
            this.Controls.Add(this.HelloLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(484, 667);
            this.MinimumSize = new System.Drawing.Size(484, 667);
            this.Name = "OutlookPhotoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Outlook Photo";
            this.Load += new System.EventHandler(this.OutlookPhotoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CurrentPhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.Label CurrentPhotoLabel;
        private System.Windows.Forms.PictureBox CurrentPhotoPictureBox;
        private System.Windows.Forms.Label UploadNewPhotoLabel;
        private System.Windows.Forms.OpenFileDialog OpenPhotFileDialog;
        private System.Windows.Forms.Button GetPhotoButton;
        private System.Windows.Forms.PictureBox NewPhotoPictureBox;
        private System.Windows.Forms.Label NewPhotoLabel;
        private System.Windows.Forms.Button SavePhotoButton;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.ToolTip InfoToolTip;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox IgnorePhotoRestrictionsCheckBox;
        private System.Windows.Forms.Button DeletePhotoButton;
    }
}

