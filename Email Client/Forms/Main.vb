Imports System.IO

Public Class Main

    Inherits System.Windows.Forms.Form

    'Variables

#Region "Variables"

    'Call Out File Path Variables

    Public AppPath As String
    Public TempPath As String

    'Call Out Setting Variables

    Public RegPath As String

    Public FullName As String
    Public Username As String
    Public Password As String
    Public Server As String
    Public Domain As String
    Public Protocol As String

    Public Notifier As String

    Public Address As String
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GetButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ViewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MessageList As System.Windows.Forms.ListBox
    Friend WithEvents MailSoundTimer As System.Windows.Forms.Timer
    Friend WithEvents WindowsMediaPlayer As AxWMPLib.AxWindowsMediaPlayer

    'Call Out Email Protocol Variables

    Private POP3Connection As Pop3 = Nothing

#End Region

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents NewMailNotifierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents AddressBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopicsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebmailAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrayIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrayMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComposeEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HideToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MessageCountLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusLabel As System.Windows.Forms.ToolStripStatusLabel

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddressBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComposeEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewMailNotifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebmailAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Label1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MessageCountLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CheckTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GetButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.MessageList = New System.Windows.Forms.ListBox()
        Me.MailSoundTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WindowsMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MenuStrip.SuspendLayout()
        Me.TrayMenu.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.WindowsMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(553, 24)
        Me.MenuStrip.TabIndex = 18
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HideToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(96, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddressBookToolStripMenuItem, Me.ComposeEmailToolStripMenuItem, Me.NewMailNotifierToolStripMenuItem, Me.WebmailAccessToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AddressBookToolStripMenuItem
        '
        Me.AddressBookToolStripMenuItem.Image = CType(resources.GetObject("AddressBookToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddressBookToolStripMenuItem.Name = "AddressBookToolStripMenuItem"
        Me.AddressBookToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.AddressBookToolStripMenuItem.Text = "Address Book"
        '
        'ComposeEmailToolStripMenuItem
        '
        Me.ComposeEmailToolStripMenuItem.Image = CType(resources.GetObject("ComposeEmailToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ComposeEmailToolStripMenuItem.Name = "ComposeEmailToolStripMenuItem"
        Me.ComposeEmailToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ComposeEmailToolStripMenuItem.Text = "Compose Email"
        '
        'NewMailNotifierToolStripMenuItem
        '
        Me.NewMailNotifierToolStripMenuItem.Name = "NewMailNotifierToolStripMenuItem"
        Me.NewMailNotifierToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.NewMailNotifierToolStripMenuItem.Text = "New Mail Notifier"
        '
        'WebmailAccessToolStripMenuItem
        '
        Me.WebmailAccessToolStripMenuItem.Image = CType(resources.GetObject("WebmailAccessToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WebmailAccessToolStripMenuItem.Name = "WebmailAccessToolStripMenuItem"
        Me.WebmailAccessToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.WebmailAccessToolStripMenuItem.Text = "Webmail Access"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TopicsToolStripMenuItem, Me.ToolStripSeparator1, Me.SupportToolStripMenuItem, Me.ToolStripSeparator2, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'TopicsToolStripMenuItem
        '
        Me.TopicsToolStripMenuItem.Image = CType(resources.GetObject("TopicsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TopicsToolStripMenuItem.Name = "TopicsToolStripMenuItem"
        Me.TopicsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.TopicsToolStripMenuItem.Text = "Topics"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(113, 6)
        '
        'SupportToolStripMenuItem
        '
        Me.SupportToolStripMenuItem.Image = CType(resources.GetObject("SupportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupportToolStripMenuItem.Name = "SupportToolStripMenuItem"
        Me.SupportToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SupportToolStripMenuItem.Text = "Support"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(113, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Email Client"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ToolStripSeparator5, Me.HideToolStripMenuItem2, Me.ToolStripSeparator4, Me.ExitToolStripMenuItem1})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.TrayMenu.Size = New System.Drawing.Size(104, 82)
        Me.TrayMenu.Text = "Email Client"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ShowToolStripMenuItem.Text = "Show"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(100, 6)
        '
        'HideToolStripMenuItem2
        '
        Me.HideToolStripMenuItem2.Name = "HideToolStripMenuItem2"
        Me.HideToolStripMenuItem2.Size = New System.Drawing.Size(103, 22)
        Me.HideToolStripMenuItem2.Text = "Hide"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(100, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Label1, Me.MessageCountLabel, Me.Label2, Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 313)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip.Size = New System.Drawing.Size(553, 22)
        Me.StatusStrip.TabIndex = 22
        Me.StatusStrip.Text = "StatusStrip"
        '
        'Label1
        '
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 17)
        Me.Label1.Text = "Message Count:"
        '
        'MessageCountLabel
        '
        Me.MessageCountLabel.Name = "MessageCountLabel"
        Me.MessageCountLabel.Size = New System.Drawing.Size(13, 17)
        Me.MessageCountLabel.Text = "0"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.Text = "Current Status:"
        '
        'StatusLabel
        '
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(58, 17)
        Me.StatusLabel.Text = "Unknown"
        '
        'CheckTimer
        '
        Me.CheckTimer.Interval = 180000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetButton, Me.ToolStripSeparator6, Me.ViewButton, Me.ToolStripSeparator7, Me.DeleteButton, Me.ToolStripSeparator9})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(553, 25)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GetButton
        '
        Me.GetButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GetButton.Image = CType(resources.GetObject("GetButton.Image"), System.Drawing.Image)
        Me.GetButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GetButton.Name = "GetButton"
        Me.GetButton.Size = New System.Drawing.Size(23, 22)
        Me.GetButton.Text = "ToolStripButton1"
        Me.GetButton.ToolTipText = "Get Messages"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'ViewButton
        '
        Me.ViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ViewButton.Image = CType(resources.GetObject("ViewButton.Image"), System.Drawing.Image)
        Me.ViewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(23, 22)
        Me.ViewButton.Text = "ToolStripButton2"
        Me.ViewButton.ToolTipText = "View Message"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'DeleteButton
        '
        Me.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteButton.Text = "ToolStripButton1"
        Me.DeleteButton.ToolTipText = "Delete Message"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'MessageList
        '
        Me.MessageList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessageList.FormattingEnabled = True
        Me.MessageList.Location = New System.Drawing.Point(0, 49)
        Me.MessageList.Name = "MessageList"
        Me.MessageList.Size = New System.Drawing.Size(553, 264)
        Me.MessageList.TabIndex = 19
        '
        'MailSoundTimer
        '
        '
        'WindowsMediaPlayer
        '
        Me.WindowsMediaPlayer.Enabled = True
        Me.WindowsMediaPlayer.Location = New System.Drawing.Point(128, 238)
        Me.WindowsMediaPlayer.Name = "WindowsMediaPlayer"
        Me.WindowsMediaPlayer.OcxState = CType(resources.GetObject("WindowsMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WindowsMediaPlayer.Size = New System.Drawing.Size(261, 46)
        Me.WindowsMediaPlayer.TabIndex = 27
        Me.WindowsMediaPlayer.Visible = False
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(553, 335)
        Me.Controls.Add(Me.WindowsMediaPlayer)
        Me.Controls.Add(Me.MessageList)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email Client"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.TrayMenu.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.WindowsMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Functions

#Region "Helper Functions"

    Private Sub EmptyFolder(ByVal SourceDirectory As String)

        Dim TmpFile As String
        Dim tmpDir As String

        Try

            If Directory.Exists(SourceDirectory) Then

                If Not SourceDirectory.EndsWith("\") Then SourceDirectory &= "\"

                For Each tmpDir In Directory.GetDirectories(SourceDirectory)

                    EmptyFolder(tmpDir)

                Next

                For Each TmpFile In System.IO.Directory.GetFiles(SourceDirectory)

                    File.SetAttributes(TmpFile, FileAttributes.Normal)
                    File.Delete(TmpFile)

                Next

            End If

        Catch ex As Exception

            Throw New Exception(ex.Message, ex)

        End Try

    End Sub

#End Region

    'Events

#Region "Form Events"

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Set Registry Information

        RegPath = "Software\Versidyne\Email Client\Settings"

        'Callout Temporary Variables

        Dim RegistryKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey(RegPath, False)

        'Retreive Data from the Registry and Set Variables Accordingly

        FullName = RegistryKey.GetValue("Full Name", "", Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
        Username = RegistryKey.GetValue("Username", "", Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
        Password = RegistryKey.GetValue("Password", "", Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
        Server = RegistryKey.GetValue("Server", "", Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
        Domain = RegistryKey.GetValue("Domain", "", Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
        Protocol = RegistryKey.GetValue("Protocol", "", Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
        Notifier = RegistryKey.GetValue("Notifier", "", Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)

        'Set Application Directory

        AppPath = Application.StartupPath
        TempPath = AppPath + "\Temp\"

        'Create Email Address with known information

        Address = Username + "@" + Domain

        'Set Notifier

        If Notifier = "True" Then

            NewMailNotifierToolStripMenuItem.PerformClick()

        End If

        'Disable Show Button

        ShowToolStripMenuItem.Enabled = False

        'Center the Form

        CenterToScreen()

        'Check if Settings have been Altered.

        If (Username = "newuser") Then

            MsgBox("You have not fully entered your credentials.", MsgBoxStyle.Information, "Settings Validation")

            MsgBox("Please go to Edit -> Settings and enter the correct information.", MsgBoxStyle.Information, "Settings Validation")

        Else

            If (Password = "password") Then

                MsgBox("You have not fully entered your credentials.", MsgBoxStyle.Information, "Settings Validation")

                MsgBox("Please go to Edit -> Settings and enter the correct information.", MsgBoxStyle.Information, "Settings Validation")

            Else

                If (FullName = "New User") Then

                    MsgBox("You have not fully entered your settings.", MsgBoxStyle.Information, "Settings Validation")

                    MsgBox("Please go to Edit -> Settings and enter the correct information.", MsgBoxStyle.Information, "Settings Validation")

                End If

            End If

        End If

        GetButton.PerformClick()

        'Create Status

        StatusLabel.Text = "Idle"

    End Sub

    Private Sub Main_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        If Me.WindowState = FormWindowState.Minimized Then

            HideToolStripMenuItem2.PerformClick()

        End If

    End Sub

    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        StatusLabel.Text = "Disconnecting"

        'Disconnect before leaving.

        On Error Resume Next

        If (POP3Connection IsNot Nothing) Then

            POP3Connection.Disconnect()
            POP3Connection = Nothing

        End If

        'Erase all Temporary Files for Enhanced Security

        StatusLabel.Text = "Erasing Temporary Files"

        EmptyFolder(TempPath)

        StatusLabel.Text = "Closing"

    End Sub

#End Region

#Region "Form Buttons"

    Private Sub GetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetButton.Click

        StatusLabel.Text = "Initiating Connection"

        'Initiate a POP3 connection.

        Dim Counter As Integer

        'First, disconnect any previous connection.

        If (POP3Connection IsNot Nothing) Then

            Try

                POP3Connection.Disconnect()

            Catch ex As Exception

                'Ignore.

            End Try

        End If

        POP3Connection = Nothing

        'Clear any previous messages.

        MessageList.Items.Clear()

        'Try the new connection.

        StatusLabel.Text = "Connecting"

        Try

            POP3Connection = New Pop3
            POP3Connection.Connect(Server, Address, Password)

            StatusLabel.Text = "Connected"

        Catch ex As Exception

            MsgBox("Connection failure: " & ex.Message, MsgBoxStyle.Critical, "Application Message")
            POP3Connection = Nothing
            Return

        End Try

        'How many messages?

        StatusLabel.Text = "Retreiving Messages"

        If (POP3Connection.Messages = 0) Then

            StatusLabel.Text = "Messages Received"
            MsgBox("There are not any messages available in your current inbox.", MsgBoxStyle.Information, "Application Message")
            POP3Connection.Disconnect()
            POP3Connection = Nothing
            MessageCountLabel.Text = 0
            Return

        End If

        MessageCountLabel.Text = POP3Connection.Messages

        'Show each message.

        Dim Decoder As New Decoder

        Dim MessageTitle As String
        Dim MessageSender As String
        Dim RawMessage As String

        For Counter = 1 To POP3Connection.Messages

            RawMessage = POP3Connection.GetMessage(Counter)

            MessageTitle = Decoder.GetRegex("^Subject:\s(?<value>.*?)(;|\n)", RawMessage).Replace(Chr(10), "").Replace(Chr(13), "")

            MessageSender = Decoder.GetRegex("^From:\s(?<value>.*?)(;|\n)", RawMessage).Replace(Chr(10), "").Replace(Chr(13), "")

            MessageList.Items.Add(Counter & ") " & "From: " & MessageSender & " | Title: " & MessageTitle)

        Next Counter

        StatusLabel.Text = "Messages Received"

    End Sub

    Private Sub ViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewButton.Click

        Dim WhichMessage As Integer
        Dim Parts As String()

        'Which message? Each item has the format: Message in which parts are validated by the space.

        StatusLabel.Text = "Retreiving Message"

        If (MessageList.SelectedIndex = -1) Then Return
        Parts = Split(CStr(MessageList.SelectedItem), " ")
        WhichMessage = CInt(Val(Parts(0)))

        'Get and show the content.

        Viewer.RawMessage = POP3Connection.GetMessage(WhichMessage)
        Viewer.Show()

        StatusLabel.Text = "Message Received"

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        StatusLabel.Text = "Deleting Message"

        If Username = "newuser" Then

            StatusLabel.Text = "Message Not Deleted"

            MsgBox("This option can not be performed on this email account." & vbCrLf & "Please choose another.", MsgBoxStyle.Information, "Application Message")

        Else

            Dim WhichMessage As Integer
            Dim Parts As String()

            'Which message? Each item has the format: Message in which parts are validated by the space.

            If (MessageList.SelectedIndex = -1) Then Return
            Parts = Split(CStr(MessageList.SelectedItem), " ")
            WhichMessage = CInt(Val(Parts(0)))

            'Delete the selected email message.

            POP3Connection.DeleteMessage(WhichMessage)

            StatusLabel.Text = "Message Deleted Successfully"

            GetButton.PerformClick()

        End If

    End Sub

    Private Sub MessageList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles MessageList.DoubleClick

        ViewButton.PerformClick()

    End Sub

#End Region

#Region "Form Sounds"

    Private Sub MailSoundTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MailSoundTimer.Tick

        'Play New Mail Sound

        WindowsMediaPlayer.URL = AppPath + "\Sounds\New Mail.wav"

        'Stop Timer

        MailSoundTimer.Enabled = False

    End Sub

#End Region

#Region "Notifier Events"

    Private Sub CheckTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckTimer.Tick

        'Declare Variables

        Dim NotifyConnection As Pop3 = Nothing

        'Set Status

        StatusLabel.Text = "Checking for New Messages"

        'Initiate a Pop3 Connection

        'First, disconnect any previous connection.

        If (NotifyConnection IsNot Nothing) Then

            Try

                NotifyConnection.Disconnect()

            Catch ex As Exception

                'Ignore.

            End Try

        End If

        NotifyConnection = Nothing

        'Clear any previous messages.

        'Try the new connection.

        Try

            NotifyConnection = New Pop3
            NotifyConnection.Connect(Server, Address, Password)

        Catch ex As Exception

            MsgBox("Connection failure: " & ex.Message, MsgBoxStyle.Critical, "Application Message")
            NotifyConnection = Nothing
            Return

        End Try

        'How many messages?

        If (NotifyConnection.Messages = 0) Then

            StatusLabel.Text = "Idle"

            NotifyConnection.Disconnect()
            NotifyConnection = Nothing
            Return

        ElseIf (NotifyConnection.Messages < MessageCountLabel.Text) Then

            GetButton.PerformClick()

        ElseIf (NotifyConnection.Messages > MessageCountLabel.Text) Then

            MessageCountLabel.Text = NotifyConnection.Messages

            'MailSoundTimer.Enabled = True

            MsgBox("You've got mail!", MsgBoxStyle.Information, "Email Client")

            ShowToolStripMenuItem.PerformClick()

            GetButton.PerformClick()

        Else

            StatusLabel.Text = "Idle"

        End If

    End Sub

#End Region

#Region "Menu Strip Events"

    Private Sub WebmailAccessToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebmailAccessToolStripMenuItem.Click

        If Username = "newuser" Then

            MsgBox("This option can not be performed on this email account." & vbCrLf & "Please choose another.", MsgBoxStyle.Information, "Application Message")

        Else

            Webmail.Username = Username
            Webmail.Password = Password

            Webmail.Show()

        End If

    End Sub

    Private Sub ComposeEmailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComposeEmailToolStripMenuItem.Click

        If Username = "newuser" Then

            MsgBox("This option can not be performed on this email account." & vbCrLf & "Please choose another.", MsgBoxStyle.Information, "Application Message")

        Else

            'Set Variables before displaying email composition form.

            Compose.FullName = FullName
            Compose.Username = Username
            Compose.Password = Password
            Compose.Server = Server
            Compose.Domain = Domain

            'Display email composition form.

            Compose.Show()

        End If

    End Sub

    Private Sub AddressBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddressBookToolStripMenuItem.Click

        AddressBook.Show()

    End Sub

    Private Sub NewMailNotifierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMailNotifierToolStripMenuItem.Click

        If Username = "newuser" Then

            MsgBox("This option can not be performed on this email account." & vbCrLf & "Please choose another.", MsgBoxStyle.Information, "Application Message")

        Else

            If NewMailNotifierToolStripMenuItem.CheckState = CheckState.Checked Then

                NewMailNotifierToolStripMenuItem.Checked = False

                CheckTimer.Stop()

            ElseIf NewMailNotifierToolStripMenuItem.CheckState = CheckState.Unchecked Then

                NewMailNotifierToolStripMenuItem.Checked = True

                CheckTimer.Start()

            End If

        End If

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click

        Settings.Show()

    End Sub

    Private Sub SupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupportToolStripMenuItem.Click

        Support.Show()

    End Sub

    Private Sub TopicsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopicsToolStripMenuItem.Click

        Help.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        About.Show()

    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click

        HideToolStripMenuItem2.PerformClick()

    End Sub

    Private Sub TrayIcon_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrayIcon.DoubleClick

        ShowToolStripMenuItem.PerformClick()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        ExitToolStripMenuItem1.PerformClick()

    End Sub

#End Region

#Region "Tray Icon Menu Events"

    Private Sub TrayIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TrayIcon.MouseDoubleClick

        If Me.WindowState = FormWindowState.Minimized Then

            ShowToolStripMenuItem.PerformClick()

        End If

    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click

        Me.Show()

        If Me.WindowState = FormWindowState.Minimized Then

            Me.WindowState = FormWindowState.Normal

        End If

        ShowToolStripMenuItem.Enabled = False
        HideToolStripMenuItem2.Enabled = True

    End Sub

    Private Sub HideToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem2.Click

        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Minimized

        End If

        Me.Hide()

        ShowToolStripMenuItem.Enabled = True
        HideToolStripMenuItem2.Enabled = False

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click

        HideToolStripMenuItem2.PerformClick()

        Me.Close()

    End Sub

#End Region

End Class
