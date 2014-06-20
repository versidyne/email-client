Imports System.Net.Mail

Public Class Compose

    Inherits System.Windows.Forms.Form

    'Variables for email connection

    Public FullName As String
    Public Username As String
    Public Password As String
    Public Server As String
    Public Domain As String

    'Variables for other features

    Public CarbonCopy As String
    Public BlindCarbonCopy As String

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
    Friend WithEvents CcCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents BccCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AttachmentCheckbox As System.Windows.Forms.CheckBox
    Friend WithEvents SendEmail As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubjectBox As System.Windows.Forms.TextBox
    Friend WithEvents ToBox As System.Windows.Forms.TextBox
    Friend WithEvents CarbonCopyBox As System.Windows.Forms.TextBox
    Friend WithEvents BlindCarbonCopyBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents AttachmentFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BodyBox As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Compose))
        Me.SendEmail = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SubjectBox = New System.Windows.Forms.TextBox
        Me.ToBox = New System.Windows.Forms.TextBox
        Me.CarbonCopyBox = New System.Windows.Forms.TextBox
        Me.BlindCarbonCopyBox = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.AttachmentFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.BodyBox = New System.Windows.Forms.RichTextBox
        Me.AttachmentCheckbox = New System.Windows.Forms.CheckBox
        Me.CcCheckBox = New System.Windows.Forms.CheckBox
        Me.BccCheckBox = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'SendEmail
        '
        Me.SendEmail.Location = New System.Drawing.Point(274, 343)
        Me.SendEmail.Name = "SendEmail"
        Me.SendEmail.Size = New System.Drawing.Size(75, 23)
        Me.SendEmail.TabIndex = 6
        Me.SendEmail.Text = "Send Email"
        Me.SendEmail.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(6, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Body:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(6, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Title:"
        '
        'SubjectBox
        '
        Me.SubjectBox.Location = New System.Drawing.Point(52, 107)
        Me.SubjectBox.Name = "SubjectBox"
        Me.SubjectBox.Size = New System.Drawing.Size(297, 20)
        Me.SubjectBox.TabIndex = 4
        '
        'ToBox
        '
        Me.ToBox.Location = New System.Drawing.Point(52, 23)
        Me.ToBox.Name = "ToBox"
        Me.ToBox.Size = New System.Drawing.Size(154, 20)
        Me.ToBox.TabIndex = 1
        '
        'CarbonCopyBox
        '
        Me.CarbonCopyBox.Location = New System.Drawing.Point(52, 49)
        Me.CarbonCopyBox.Name = "CarbonCopyBox"
        Me.CarbonCopyBox.Size = New System.Drawing.Size(154, 20)
        Me.CarbonCopyBox.TabIndex = 2
        '
        'BlindCarbonCopyBox
        '
        Me.BlindCarbonCopyBox.Location = New System.Drawing.Point(52, 75)
        Me.BlindCarbonCopyBox.Name = "BlindCarbonCopyBox"
        Me.BlindCarbonCopyBox.Size = New System.Drawing.Size(154, 20)
        Me.BlindCarbonCopyBox.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(6, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "To:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(6, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "CC:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(6, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "BCC:"
        '
        'BodyBox
        '
        Me.BodyBox.Location = New System.Drawing.Point(52, 141)
        Me.BodyBox.Name = "BodyBox"
        Me.BodyBox.Size = New System.Drawing.Size(297, 190)
        Me.BodyBox.TabIndex = 5
        Me.BodyBox.Text = ""
        '
        'AttachmentCheckbox
        '
        Me.AttachmentCheckbox.AutoSize = True
        Me.AttachmentCheckbox.Location = New System.Drawing.Point(233, 26)
        Me.AttachmentCheckbox.Name = "AttachmentCheckbox"
        Me.AttachmentCheckbox.Size = New System.Drawing.Size(102, 17)
        Me.AttachmentCheckbox.TabIndex = 42
        Me.AttachmentCheckbox.Text = "Add Attachment"
        Me.AttachmentCheckbox.UseVisualStyleBackColor = True
        '
        'CcCheckBox
        '
        Me.CcCheckBox.AutoSize = True
        Me.CcCheckBox.Location = New System.Drawing.Point(233, 52)
        Me.CcCheckBox.Name = "CcCheckBox"
        Me.CcCheckBox.Size = New System.Drawing.Size(87, 17)
        Me.CcCheckBox.TabIndex = 43
        Me.CcCheckBox.Text = "Carbon Copy"
        Me.CcCheckBox.UseVisualStyleBackColor = True
        '
        'BccCheckBox
        '
        Me.BccCheckBox.AutoSize = True
        Me.BccCheckBox.Location = New System.Drawing.Point(233, 78)
        Me.BccCheckBox.Name = "BccCheckBox"
        Me.BccCheckBox.Size = New System.Drawing.Size(113, 17)
        Me.BccCheckBox.TabIndex = 44
        Me.BccCheckBox.Text = "Blind Carbon Copy"
        Me.BccCheckBox.UseVisualStyleBackColor = True
        '
        'Compose
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(379, 385)
        Me.Controls.Add(Me.BccCheckBox)
        Me.Controls.Add(Me.CcCheckBox)
        Me.Controls.Add(Me.AttachmentCheckbox)
        Me.Controls.Add(Me.BodyBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BlindCarbonCopyBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CarbonCopyBox)
        Me.Controls.Add(Me.ToBox)
        Me.Controls.Add(Me.SubjectBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SendEmail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Compose"
        Me.Text = "Compose Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Compose_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CarbonCopyBox.Enabled = False
        BlindCarbonCopyBox.Enabled = False

        'Disable incomplete features.

        CcCheckBox.Enabled = False
        CcCheckBox.Visible = False
        BccCheckBox.Enabled = False
        BccCheckBox.Visible = False

    End Sub

    Private Sub SendEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendEmail.Click

        'Email Message Variables (Creates a New, Blank Message)

        Dim EmailMessage As MailMessage = New MailMessage
        Dim Attachment As Attachment

        Dim EmailAddress As String

        EmailAddress = Username + "@" + Domain

        EmailMessage.From = New MailAddress(EmailAddress, FullName)
        EmailMessage.To.Add(ToBox.Text)

        'If CcCheckBox.Checked = True Then

        'EmailMessage.CC.Add(CarbonCopyBox.Text)

        'Else

        'End If

        'If BccCheckBox.Checked = True Then

        'EmailMessage.Bcc.Add(BlindCarbonCopyBox.Text)

        'Else

        'End If

        EmailMessage.Subject = (SubjectBox.Text)
        EmailMessage.Body = BodyBox.Text
        EmailMessage.Priority = MailPriority.High
        EmailMessage.IsBodyHtml = False

        If AttachmentCheckbox.Checked = True Then

            AttachmentFileDialog.ShowDialog()
            Attachment = New Attachment(AttachmentFileDialog.FileName)
            EmailMessage.Attachments.Add(Attachment)

        End If

        'Authenticate email to be sent to the outside world.

        Dim smtp As New SmtpClient(Server)
        Dim basicAuthenticationInfo As New System.Net.NetworkCredential(Username, Password)

        smtp.Credentials = basicAuthenticationInfo
        smtp.Send(EmailMessage)

        'Email sent successfully.

        MsgBox("Email Sent Successfully.", MsgBoxStyle.Information, "Application Event")

        'Close email composition form.

        Me.Close()

    End Sub

    Private Sub CCCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CcCheckBox.CheckedChanged

        If CcCheckBox.Checked = True Then

            CarbonCopyBox.Enabled = True

        ElseIf CcCheckBox.Checked = False Then

            CarbonCopyBox.Enabled = False

        End If

    End Sub

    Private Sub BCCCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BccCheckBox.CheckedChanged

        If BccCheckBox.Checked = True Then

            BlindCarbonCopyBox.Enabled = True

        ElseIf BccCheckBox.Checked = False Then

            BlindCarbonCopyBox.Enabled = False

        End If

    End Sub

End Class
