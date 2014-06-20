Public Class Settings

    'Variable Callouts
    Public RegPath As String

    'Account
    Public FullName As String

    'Credentials
    Public Username As String
    Public Password As String
    Public Server As String
    Public Domain As String
    Public Protocol As String
    Public Notifier As String

    'End of Variable Callouts

    Private Sub Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        'Add Data to Form

        FullNameTextBox.Text = FullName

        UsernameTextBox.Text = Username
        PasswordTextBox.Text = Password
        ServerComboBox.Text = Server
        DomainComboBox.Text = Domain
        ProtocolComboBox.Text = Protocol

        NotifierCheckBox.Checked = Notifier

    End Sub

    Private Sub OptionsOkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsOkButton.Click

        OptionsApplyButton.PerformClick()

        Me.Close()

    End Sub

    Private Sub OptionsCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsCancelButton.Click

        'Close Form

        Me.Close()

    End Sub

    Private Sub OptionsApplyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsApplyButton.Click

        'Callout Form Variables

        Dim FullNameInput As Object

        Dim UsernameInput As Object
        Dim PasswordInput As Object
        Dim ServerInput As Object
        Dim DomainInput As Object
        Dim ProtocolInput As Object

        Dim NotifierInput As Object

        'Set Variables

        FullNameInput = FullNameTextBox.Text

        UsernameInput = UsernameTextBox.Text
        PasswordInput = PasswordTextBox.Text
        ServerInput = ServerComboBox.Text
        DomainInput = DomainComboBox.Text
        ProtocolInput = ProtocolComboBox.Text

        If NotifierCheckBox.Checked = True Then

            NotifierInput = "True"

        ElseIf NotifierCheckBox.Checked = False Then

            NotifierInput = "False"

        Else

            NotifierInput = "False"

        End If

        'Save Registry Data & Main Values Respectively

        If SaveCheckBox.Checked = True Then

            'Callout Temporary Variables

            Dim RegistryKey As Microsoft.Win32.RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey(RegPath, True)

            'Set Registry Values

            RegistryKey.SetValue("Full Name", FullNameInput, Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)

            RegistryKey.SetValue("Username", UsernameInput, Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
            RegistryKey.SetValue("Password", PasswordInput, Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
            RegistryKey.SetValue("Server", ServerInput, Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
            RegistryKey.SetValue("Domain", DomainInput, Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)
            RegistryKey.SetValue("Protocol", ProtocolInput, Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)

            RegistryKey.SetValue("Notifier", NotifierInput, Microsoft.Win32.RegistryValueOptions.DoNotExpandEnvironmentNames)

            'Set Main Values

            Main.FullName = FullNameInput

            Main.Username = UsernameInput
            Main.Password = PasswordInput
            Main.Server = ServerInput
            Main.Domain = DomainInput
            Main.Protocol = ProtocolInput

            Main.Address = UsernameInput + "@" + DomainInput

            Main.NewMailNotifierToolStripMenuItem.Checked = NotifierInput

        ElseIf SaveCheckBox.Checked = False Then

            'Set Main Values

            Main.FullName = FullNameInput

            Main.Username = UsernameInput
            Main.Password = PasswordInput
            Main.Server = ServerInput
            Main.Domain = DomainInput
            Main.Protocol = ProtocolInput

            Main.Address = UsernameInput + "@" + DomainInput

            Main.NewMailNotifierToolStripMenuItem.Checked = NotifierInput

        End If

    End Sub

End Class