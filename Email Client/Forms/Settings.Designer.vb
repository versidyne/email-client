<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.OptionsApplyButton = New System.Windows.Forms.Button
        Me.OptionsCancelButton = New System.Windows.Forms.Button
        Me.OptionsOkButton = New System.Windows.Forms.Button
        Me.SaveCheckBox = New System.Windows.Forms.CheckBox
        Me.SplitContainer = New System.Windows.Forms.SplitContainer
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.AccountTab = New System.Windows.Forms.TabPage
        Me.FullNameTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.CredentialsTab = New System.Windows.Forms.TabPage
        Me.ProtocolComboBox = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.UsernameTextBox = New System.Windows.Forms.TextBox
        Me.DomainComboBox = New System.Windows.Forms.ComboBox
        Me.ServerComboBox = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GeneralTab = New System.Windows.Forms.TabPage
        Me.NotifierCheckBox = New System.Windows.Forms.CheckBox
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.AccountTab.SuspendLayout()
        Me.CredentialsTab.SuspendLayout()
        Me.GeneralTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'OptionsApplyButton
        '
        Me.OptionsApplyButton.Location = New System.Drawing.Point(186, 251)
        Me.OptionsApplyButton.Name = "OptionsApplyButton"
        Me.OptionsApplyButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionsApplyButton.TabIndex = 10
        Me.OptionsApplyButton.Text = "Apply"
        Me.OptionsApplyButton.UseVisualStyleBackColor = True
        '
        'OptionsCancelButton
        '
        Me.OptionsCancelButton.Location = New System.Drawing.Point(102, 251)
        Me.OptionsCancelButton.Name = "OptionsCancelButton"
        Me.OptionsCancelButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionsCancelButton.TabIndex = 9
        Me.OptionsCancelButton.Text = "Cancel"
        Me.OptionsCancelButton.UseVisualStyleBackColor = True
        '
        'OptionsOkButton
        '
        Me.OptionsOkButton.Location = New System.Drawing.Point(13, 251)
        Me.OptionsOkButton.Name = "OptionsOkButton"
        Me.OptionsOkButton.Size = New System.Drawing.Size(75, 23)
        Me.OptionsOkButton.TabIndex = 8
        Me.OptionsOkButton.Text = "OK"
        Me.OptionsOkButton.UseVisualStyleBackColor = True
        '
        'SaveCheckBox
        '
        Me.SaveCheckBox.AutoSize = True
        Me.SaveCheckBox.Checked = True
        Me.SaveCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SaveCheckBox.Location = New System.Drawing.Point(22, 222)
        Me.SaveCheckBox.Name = "SaveCheckBox"
        Me.SaveCheckBox.Size = New System.Drawing.Size(105, 17)
        Me.SaveCheckBox.TabIndex = 7
        Me.SaveCheckBox.Text = "Save information"
        Me.SaveCheckBox.UseVisualStyleBackColor = True
        '
        'SplitContainer
        '
        Me.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.SplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.TabControl)
        Me.SplitContainer.Size = New System.Drawing.Size(277, 288)
        Me.SplitContainer.SplitterDistance = 209
        Me.SplitContainer.TabIndex = 18
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.AccountTab)
        Me.TabControl.Controls.Add(Me.CredentialsTab)
        Me.TabControl.Controls.Add(Me.GeneralTab)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.HotTrack = True
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(277, 209)
        Me.TabControl.TabIndex = 17
        '
        'AccountTab
        '
        Me.AccountTab.Controls.Add(Me.FullNameTextBox)
        Me.AccountTab.Controls.Add(Me.Label5)
        Me.AccountTab.Location = New System.Drawing.Point(4, 22)
        Me.AccountTab.Name = "AccountTab"
        Me.AccountTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AccountTab.Size = New System.Drawing.Size(286, 183)
        Me.AccountTab.TabIndex = 0
        Me.AccountTab.Text = "Account"
        Me.AccountTab.UseVisualStyleBackColor = True
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(108, 20)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(126, 20)
        Me.FullNameTextBox.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Full Name:"
        '
        'CredentialsTab
        '
        Me.CredentialsTab.Controls.Add(Me.ProtocolComboBox)
        Me.CredentialsTab.Controls.Add(Me.Label6)
        Me.CredentialsTab.Controls.Add(Me.PasswordTextBox)
        Me.CredentialsTab.Controls.Add(Me.UsernameTextBox)
        Me.CredentialsTab.Controls.Add(Me.DomainComboBox)
        Me.CredentialsTab.Controls.Add(Me.ServerComboBox)
        Me.CredentialsTab.Controls.Add(Me.Label4)
        Me.CredentialsTab.Controls.Add(Me.Label3)
        Me.CredentialsTab.Controls.Add(Me.Label2)
        Me.CredentialsTab.Controls.Add(Me.Label1)
        Me.CredentialsTab.Location = New System.Drawing.Point(4, 22)
        Me.CredentialsTab.Name = "CredentialsTab"
        Me.CredentialsTab.Padding = New System.Windows.Forms.Padding(3)
        Me.CredentialsTab.Size = New System.Drawing.Size(286, 183)
        Me.CredentialsTab.TabIndex = 1
        Me.CredentialsTab.Text = "Credentials"
        Me.CredentialsTab.UseVisualStyleBackColor = True
        '
        'ProtocolComboBox
        '
        Me.ProtocolComboBox.FormattingEnabled = True
        Me.ProtocolComboBox.Items.AddRange(New Object() {"POP3"})
        Me.ProtocolComboBox.Location = New System.Drawing.Point(100, 140)
        Me.ProtocolComboBox.Name = "ProtocolComboBox"
        Me.ProtocolComboBox.Size = New System.Drawing.Size(144, 21)
        Me.ProtocolComboBox.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Protocol:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(108, 49)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(126, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(108, 20)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(126, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'DomainComboBox
        '
        Me.DomainComboBox.FormattingEnabled = True
        Me.DomainComboBox.Items.AddRange(New Object() {"shadowaretech.net"})
        Me.DomainComboBox.Location = New System.Drawing.Point(100, 109)
        Me.DomainComboBox.Name = "DomainComboBox"
        Me.DomainComboBox.Size = New System.Drawing.Size(144, 21)
        Me.DomainComboBox.TabIndex = 5
        '
        'ServerComboBox
        '
        Me.ServerComboBox.FormattingEnabled = True
        Me.ServerComboBox.Items.AddRange(New Object() {"mail.shadowaretech.net"})
        Me.ServerComboBox.Location = New System.Drawing.Point(100, 78)
        Me.ServerComboBox.Name = "ServerComboBox"
        Me.ServerComboBox.Size = New System.Drawing.Size(144, 21)
        Me.ServerComboBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Domain:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Server:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Username:"
        '
        'GeneralTab
        '
        Me.GeneralTab.Controls.Add(Me.NotifierCheckBox)
        Me.GeneralTab.Location = New System.Drawing.Point(4, 22)
        Me.GeneralTab.Name = "GeneralTab"
        Me.GeneralTab.Padding = New System.Windows.Forms.Padding(3)
        Me.GeneralTab.Size = New System.Drawing.Size(269, 183)
        Me.GeneralTab.TabIndex = 2
        Me.GeneralTab.Text = "General"
        Me.GeneralTab.UseVisualStyleBackColor = True
        '
        'NotifierCheckBox
        '
        Me.NotifierCheckBox.AutoSize = True
        Me.NotifierCheckBox.Location = New System.Drawing.Point(18, 19)
        Me.NotifierCheckBox.Name = "NotifierCheckBox"
        Me.NotifierCheckBox.Size = New System.Drawing.Size(178, 17)
        Me.NotifierCheckBox.TabIndex = 0
        Me.NotifierCheckBox.Text = "Always notify on new messages."
        Me.NotifierCheckBox.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 288)
        Me.Controls.Add(Me.SaveCheckBox)
        Me.Controls.Add(Me.OptionsOkButton)
        Me.Controls.Add(Me.OptionsCancelButton)
        Me.Controls.Add(Me.OptionsApplyButton)
        Me.Controls.Add(Me.SplitContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.AccountTab.ResumeLayout(False)
        Me.AccountTab.PerformLayout()
        Me.CredentialsTab.ResumeLayout(False)
        Me.CredentialsTab.PerformLayout()
        Me.GeneralTab.ResumeLayout(False)
        Me.GeneralTab.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OptionsApplyButton As System.Windows.Forms.Button
    Friend WithEvents OptionsCancelButton As System.Windows.Forms.Button
    Friend WithEvents OptionsOkButton As System.Windows.Forms.Button
    Friend WithEvents SaveCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer As System.Windows.Forms.SplitContainer
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents AccountTab As System.Windows.Forms.TabPage
    Friend WithEvents FullNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CredentialsTab As System.Windows.Forms.TabPage
    Friend WithEvents ProtocolComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DomainComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ServerComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GeneralTab As System.Windows.Forms.TabPage
    Friend WithEvents NotifierCheckBox As System.Windows.Forms.CheckBox
End Class
