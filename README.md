# OutlookPhoto
OutlookPhoto is a tool that allows you to upload your photo to Exchange Server 2010 (or later) so that it is displayed in Outlook 2010 (or later) on the header of emails for which you are the sender. It also allows you to view your currently stored photo.

**NOTE:** You do _not_ need this tool unless you are still using Outlook 2010 as the same functionality is already integrated in Outlook versions newer than Outlook 2010.

# Advanced Features
If for some reason OutlookPhoto is displaying the wrong username, you can specify a username explicitly from the command-line using the following syntax:
```
OutlookPhoto.exe /u:MyUserName
```

Also, if you own an Exchange group for which you want to set a photo, you can do so using the following command-line syntax:
```
OutlookPhoto.exe /g:MyGroupName
```

You can specify any valid LDAP expression as the search criteria using the `/e:` command-line option:
```
OutlookPhoto.exe /e:"CN=AnyName"
```

**Note**: MyGroupName can be an Active Directory DN.

# History
This is the new location of the tool now that CodePlex is retired. The original tool and its source code can be accessed from the CodePlex archive:
https://archive.codeplex.com/?p=outlookphoto

Date | Notes
--- | ---
2/17/2018 | Created this repoistory and moved the source code for the EXE only after upgrading the program to use .NET 4.6.1.
