Public Class AddContact

    Inherits System.Windows.Forms.Form

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
    Friend WithEvents lblPNum As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblSite As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPnum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblPNum = New System.Windows.Forms.Label
        Me.lblLName = New System.Windows.Forms.Label
        Me.lblFName = New System.Windows.Forms.Label
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.Cancel = New System.Windows.Forms.Button
        Me.OK = New System.Windows.Forms.Button
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.lblTitle = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.lblCity = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.lblCode = New System.Windows.Forms.Label
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblMail = New System.Windows.Forms.Label
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.lblSite = New System.Windows.Forms.Label
        Me.txtSite = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.lblState = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.MaskedTextBox
        Me.txtPnum = New System.Windows.Forms.MaskedTextBox
        Me.SuspendLayout()
        '
        'lblPNum
        '
        Me.lblPNum.Location = New System.Drawing.Point(10, 256)
        Me.lblPNum.Name = "lblPNum"
        Me.lblPNum.Size = New System.Drawing.Size(86, 19)
        Me.lblPNum.TabIndex = 11
        Me.lblPNum.Text = "Phone:"
        '
        'lblLName
        '
        Me.lblLName.Location = New System.Drawing.Point(10, 45)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(86, 18)
        Me.lblLName.TabIndex = 10
        Me.lblLName.Text = "Last Name:"
        '
        'lblFName
        '
        Me.lblFName.Location = New System.Drawing.Point(10, 15)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(86, 18)
        Me.lblFName.TabIndex = 9
        Me.lblFName.Text = "First Name:"
        '
        'txtLname
        '
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLname.Location = New System.Drawing.Point(106, 43)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(297, 22)
        Me.txtLname.TabIndex = 2
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Location = New System.Drawing.Point(106, 13)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(297, 22)
        Me.txtFname.TabIndex = 1
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(317, 353)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(86, 28)
        Me.Cancel.TabIndex = 13
        Me.Cancel.Text = "Cancel"
        '
        'OK
        '
        Me.OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK.Location = New System.Drawing.Point(223, 353)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(87, 28)
        Me.OK.TabIndex = 12
        Me.OK.Text = "OK"
        '
        'txtTitle
        '
        Me.txtTitle.AcceptsTab = True
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Location = New System.Drawing.Point(106, 73)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(297, 22)
        Me.txtTitle.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(10, 75)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(57, 18)
        Me.lblTitle.TabIndex = 17
        Me.lblTitle.Text = "Title:"
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(10, 195)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(67, 18)
        Me.lblCountry.TabIndex = 18
        Me.lblCountry.Text = "Country:"
        '
        'txtCountry
        '
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Location = New System.Drawing.Point(106, 193)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(297, 22)
        Me.txtCountry.TabIndex = 7
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(10, 135)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(38, 18)
        Me.lblCity.TabIndex = 20
        Me.lblCity.Text = "City:"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(106, 133)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(297, 22)
        Me.txtCity.TabIndex = 5
        '
        'lblCode
        '
        Me.lblCode.Location = New System.Drawing.Point(10, 226)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(67, 19)
        Me.lblCode.TabIndex = 22
        Me.lblCode.Text = "Zip Code:"
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(10, 105)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(67, 18)
        Me.lblAddress.TabIndex = 24
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(106, 103)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(297, 22)
        Me.txtAddress.TabIndex = 4
        '
        'lblMail
        '
        Me.lblMail.Location = New System.Drawing.Point(10, 285)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(57, 18)
        Me.lblMail.TabIndex = 28
        Me.lblMail.Text = "E-mail:"
        '
        'txtMail
        '
        Me.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMail.Location = New System.Drawing.Point(106, 283)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(297, 22)
        Me.txtMail.TabIndex = 10
        '
        'lblSite
        '
        Me.lblSite.Location = New System.Drawing.Point(10, 315)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(67, 18)
        Me.lblSite.TabIndex = 30
        Me.lblSite.Text = "Website:"
        '
        'txtSite
        '
        Me.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSite.Location = New System.Drawing.Point(106, 313)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(297, 22)
        Me.txtSite.TabIndex = 11
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Location = New System.Drawing.Point(106, 163)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(297, 22)
        Me.txtState.TabIndex = 6
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(10, 165)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(38, 18)
        Me.lblState.TabIndex = 32
        Me.lblState.Text = "State:"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(106, 223)
        Me.txtCode.Mask = "00000-9999"
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(120, 22)
        Me.txtCode.TabIndex = 8
        '
        'txtPnum
        '
        Me.txtPnum.Location = New System.Drawing.Point(106, 253)
        Me.txtPnum.Mask = "(999) 000-0000"
        Me.txtPnum.Name = "txtPnum"
        Me.txtPnum.Size = New System.Drawing.Size(120, 22)
        Me.txtPnum.TabIndex = 9
        '
        'AddContact
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(418, 400)
        Me.Controls.Add(Me.txtPnum)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.lblState)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtSite)
        Me.Controls.Add(Me.lblSite)
        Me.Controls.Add(Me.txtMail)
        Me.Controls.Add(Me.lblMail)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblCode)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.lblCity)
        Me.Controls.Add(Me.txtCountry)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.lblPNum)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddContact"
        Me.Text = "Add Contact"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private NewContact As New Contact()

    Public ReadOnly Property contact() As Contact

        Get

            Return (NewContact)

        End Get

    End Property

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        With NewContact

            .FirstName = txtFname.Text
            .LastName = txtLname.Text
            .Phone = txtPnum.Text
            .Title = txtTitle.Text
            .Country = txtCountry.Text
            .City = txtCity.Text
            .ZipCode = txtCode.Text
            .State = txtState.Text
            .Address = txtAddress.Text
            .Email = txtMail.Text
            .Website = txtSite.Text

        End With

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Me.Close()

    End Sub

End Class
