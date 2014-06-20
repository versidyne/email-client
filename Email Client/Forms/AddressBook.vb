Imports System.IO
Imports System.Xml
Imports System.Xml.XPath

Public Class AddressBook

    Inherits System.Windows.Forms.Form

    Private AddressBookPath As String
    Private Contacts As New Collection()
    Friend WithEvents ContactListGroupBox As System.Windows.Forms.GroupBox
    Private CurrentContact As Integer

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
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblPNum As System.Windows.Forms.Label
    Friend WithEvents PreviousButton As System.Windows.Forms.Button
    Friend WithEvents NextButton As System.Windows.Forms.Button
    Friend WithEvents lblContactNum As System.Windows.Forms.Label
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents lblSite As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblMail As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblCode As System.Windows.Forms.Label
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtCountry As System.Windows.Forms.TextBox
    Friend WithEvents lblCountry As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents txtPnum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCode As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ContactList As System.Windows.Forms.ListBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.txtState = New System.Windows.Forms.TextBox
        Me.lblFName = New System.Windows.Forms.Label
        Me.lblLName = New System.Windows.Forms.Label
        Me.lblPNum = New System.Windows.Forms.Label
        Me.PreviousButton = New System.Windows.Forms.Button
        Me.NextButton = New System.Windows.Forms.Button
        Me.lblContactNum = New System.Windows.Forms.Label
        Me.RemoveButton = New System.Windows.Forms.Button
        Me.AddButton = New System.Windows.Forms.Button
        Me.SaveButton = New System.Windows.Forms.Button
        Me.txtSite = New System.Windows.Forms.TextBox
        Me.lblSite = New System.Windows.Forms.Label
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.lblMail = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.lblCode = New System.Windows.Forms.Label
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.lblCity = New System.Windows.Forms.Label
        Me.txtCountry = New System.Windows.Forms.TextBox
        Me.lblCountry = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.lblState = New System.Windows.Forms.Label
        Me.txtPnum = New System.Windows.Forms.MaskedTextBox
        Me.txtCode = New System.Windows.Forms.MaskedTextBox
        Me.ContactList = New System.Windows.Forms.ListBox
        Me.ContactListGroupBox = New System.Windows.Forms.GroupBox
        Me.ContactListGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Location = New System.Drawing.Point(88, 42)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(248, 20)
        Me.txtFname.TabIndex = 1
        '
        'txtLname
        '
        Me.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLname.Location = New System.Drawing.Point(88, 68)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(248, 20)
        Me.txtLname.TabIndex = 2
        '
        'txtState
        '
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Location = New System.Drawing.Point(88, 172)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(248, 20)
        Me.txtState.TabIndex = 6
        '
        'lblFName
        '
        Me.lblFName.Location = New System.Drawing.Point(8, 44)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(72, 16)
        Me.lblFName.TabIndex = 3
        Me.lblFName.Text = "First Name:"
        '
        'lblLName
        '
        Me.lblLName.Location = New System.Drawing.Point(8, 70)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(72, 16)
        Me.lblLName.TabIndex = 4
        Me.lblLName.Text = "Last Name:"
        '
        'lblPNum
        '
        Me.lblPNum.Location = New System.Drawing.Point(8, 253)
        Me.lblPNum.Name = "lblPNum"
        Me.lblPNum.Size = New System.Drawing.Size(72, 16)
        Me.lblPNum.TabIndex = 5
        Me.lblPNum.Text = "Phone:"
        '
        'PreviousButton
        '
        Me.PreviousButton.Enabled = False
        Me.PreviousButton.Location = New System.Drawing.Point(176, 342)
        Me.PreviousButton.Name = "PreviousButton"
        Me.PreviousButton.Size = New System.Drawing.Size(72, 24)
        Me.PreviousButton.TabIndex = 12
        Me.PreviousButton.Text = "< Previous"
        '
        'NextButton
        '
        Me.NextButton.Enabled = False
        Me.NextButton.Location = New System.Drawing.Point(264, 342)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(72, 24)
        Me.NextButton.TabIndex = 13
        Me.NextButton.Text = "Next >"
        '
        'lblContactNum
        '
        Me.lblContactNum.AutoSize = True
        Me.lblContactNum.Location = New System.Drawing.Point(8, 15)
        Me.lblContactNum.Name = "lblContactNum"
        Me.lblContactNum.Size = New System.Drawing.Size(47, 13)
        Me.lblContactNum.TabIndex = 9
        Me.lblContactNum.Text = "Contact:"
        '
        'RemoveButton
        '
        Me.RemoveButton.Location = New System.Drawing.Point(19, 374)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(100, 24)
        Me.RemoveButton.TabIndex = 15
        Me.RemoveButton.Text = "Remove Contact"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(19, 342)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(100, 24)
        Me.AddButton.TabIndex = 14
        Me.AddButton.Text = "Add Contact"
        '
        'SaveButton
        '
        Me.SaveButton.Enabled = False
        Me.SaveButton.Location = New System.Drawing.Point(201, 374)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(95, 24)
        Me.SaveButton.TabIndex = 16
        Me.SaveButton.Text = "Save Changes"
        '
        'txtSite
        '
        Me.txtSite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSite.Location = New System.Drawing.Point(88, 302)
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(248, 20)
        Me.txtSite.TabIndex = 11
        '
        'lblSite
        '
        Me.lblSite.Location = New System.Drawing.Point(8, 304)
        Me.lblSite.Name = "lblSite"
        Me.lblSite.Size = New System.Drawing.Size(56, 16)
        Me.lblSite.TabIndex = 48
        Me.lblSite.Text = "Website:"
        '
        'txtMail
        '
        Me.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMail.Location = New System.Drawing.Point(88, 276)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(248, 20)
        Me.txtMail.TabIndex = 10
        '
        'lblMail
        '
        Me.lblMail.Location = New System.Drawing.Point(8, 278)
        Me.lblMail.Name = "lblMail"
        Me.lblMail.Size = New System.Drawing.Size(48, 16)
        Me.lblMail.TabIndex = 46
        Me.lblMail.Text = "E-mail:"
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Location = New System.Drawing.Point(88, 120)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(248, 20)
        Me.txtAddress.TabIndex = 4
        '
        'lblAddress
        '
        Me.lblAddress.Location = New System.Drawing.Point(8, 122)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(56, 16)
        Me.lblAddress.TabIndex = 42
        Me.lblAddress.Text = "Address:"
        '
        'lblCode
        '
        Me.lblCode.Location = New System.Drawing.Point(8, 227)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(56, 16)
        Me.lblCode.TabIndex = 40
        Me.lblCode.Text = "Zip Code:"
        '
        'txtCity
        '
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Location = New System.Drawing.Point(88, 146)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(248, 20)
        Me.txtCity.TabIndex = 5
        '
        'lblCity
        '
        Me.lblCity.Location = New System.Drawing.Point(8, 148)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(32, 16)
        Me.lblCity.TabIndex = 38
        Me.lblCity.Text = "City:"
        '
        'txtCountry
        '
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Location = New System.Drawing.Point(88, 198)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(248, 20)
        Me.txtCountry.TabIndex = 7
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(8, 200)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(56, 16)
        Me.lblCountry.TabIndex = 36
        Me.lblCountry.Text = "Country:"
        '
        'lblTitle
        '
        Me.lblTitle.Location = New System.Drawing.Point(8, 96)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(48, 16)
        Me.lblTitle.TabIndex = 35
        Me.lblTitle.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Location = New System.Drawing.Point(88, 94)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(248, 20)
        Me.txtTitle.TabIndex = 3
        '
        'lblState
        '
        Me.lblState.Location = New System.Drawing.Point(8, 174)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(32, 16)
        Me.lblState.TabIndex = 50
        Me.lblState.Text = "State:"
        '
        'txtPnum
        '
        Me.txtPnum.Location = New System.Drawing.Point(88, 250)
        Me.txtPnum.Mask = "(999) 000-0000"
        Me.txtPnum.Name = "txtPnum"
        Me.txtPnum.Size = New System.Drawing.Size(100, 20)
        Me.txtPnum.TabIndex = 9
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(88, 224)
        Me.txtCode.Mask = "00000-9999"
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 8
        '
        'ContactList
        '
        Me.ContactList.FormattingEnabled = True
        Me.ContactList.Location = New System.Drawing.Point(12, 19)
        Me.ContactList.Name = "ContactList"
        Me.ContactList.Size = New System.Drawing.Size(144, 251)
        Me.ContactList.TabIndex = 51
        '
        'ContactListGroupBox
        '
        Me.ContactListGroupBox.Controls.Add(Me.ContactList)
        Me.ContactListGroupBox.Location = New System.Drawing.Point(364, 42)
        Me.ContactListGroupBox.Name = "ContactListGroupBox"
        Me.ContactListGroupBox.Size = New System.Drawing.Size(169, 280)
        Me.ContactListGroupBox.TabIndex = 52
        Me.ContactListGroupBox.TabStop = False
        Me.ContactListGroupBox.Text = "Contact List"
        '
        'AddressBook
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(559, 412)
        Me.Controls.Add(Me.ContactListGroupBox)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.txtPnum)
        Me.Controls.Add(Me.lblState)
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
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PreviousButton)
        Me.Controls.Add(Me.lblPNum)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.lblContactNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AddressBook"
        Me.Text = "Address Book"
        Me.ContactListGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Helper functions"

    Private Sub DisplayCurrentContact(ByVal iReset As Boolean)

        'GO BACK TO THE FIRST CONTACT IF RESET IS TRUE
        If (iReset) Then CurrentContact = 1

        'DISPLAY THE CONTACT INFORMATION IF THERE ARE ANY CONTACTS
        If (Contacts.Count > 0) Then

            With Contacts(CurrentContact)

                txtFname.Text = .FirstName
                txtLname.Text = .LastName
                txtTitle.Text = .Title
                txtAddress.Text = .Address
                txtCity.Text = .City
                txtState.Text = .State
                txtCountry.Text = .Country
                txtCode.Text = .ZipCode
                txtPnum.Text = .Phone
                txtMail.Text = .Email
                txtSite.Text = .Website


            End With

            'DISPLAY THE CONTACT NUMBER
            lblContactNum.Text = String.Format("Contact: {0}", CurrentContact.ToString)

        Else

            'THERE ARE NO CONTACTS, CLEAR THE INFORMATION
            txtFname.Text = ""
            txtLname.Text = ""
            txtState.Text = ""
            txtPnum.Text = ""
            txtTitle.Text = ""
            txtCountry.Text = ""
            txtCity.Text = ""
            txtCode.Text = ""
            txtState.Text = ""
            txtAddress.Text = ""
            txtSite.Text = ""
            txtMail.Text = ""

            'CLEAR THE CONTACT NUMBER
            lblContactNum.Text = "Contact:"

            'DISABLE THE SAVE, PREV AND NEXT BUTTONS
            SaveButton.Enabled = False
            PreviousButton.Enabled = False
            NextButton.Enabled = False

        End If

    End Sub

    Private Function LoadPhoneBook(ByVal iFileName As String) As Boolean

        Dim pXldDocument As New XmlDocument()
        Dim pXpnNavigator As XPathNavigator
        Dim pXniIterator As XPathNodeIterator

        Contacts = New Collection()

        txtFname.Text = ""
        txtLname.Text = ""
        txtState.Text = ""
        txtPnum.Text = ""
        txtTitle.Text = ""
        txtCountry.Text = ""
        txtCity.Text = ""
        txtCode.Text = ""
        txtState.Text = ""
        txtAddress.Text = ""
        txtSite.Text = ""
        txtMail.Text = ""

        Try

            pXldDocument.Load(iFileName)
            pXpnNavigator = pXldDocument.CreateNavigator

            pXniIterator = pXpnNavigator.Select("phonebook/contact")
            While pXniIterator.MoveNext()

                Dim pStrFirstName As String
                Dim pStrLastName As String
                Dim pStrTitle As String
                Dim pStrAddress As String
                Dim pStrCity As String
                Dim pStrState As String
                Dim pStrCountry As String
                Dim pStrZipCode As String
                Dim pStrPhone As String
                Dim pStrEmail As String
                Dim pStrWebsite As String

                pXniIterator.Current.MoveToFirstAttribute()

                Do

                    pXniIterator.Current.MoveToFirstChild()

                    Do

                        Select Case pXniIterator.Current.Name
                            Case "firstname"
                                pStrFirstName = pXniIterator.Current.Value
                            Case "lastname"
                                pStrLastName = pXniIterator.Current.Value
                            Case "title"
                                pStrTitle = pXniIterator.Current.Value
                            Case "address"
                                pStrAddress = pXniIterator.Current.Value
                            Case "city"
                                pStrCity = pXniIterator.Current.Value
                            Case "state"
                                pStrState = pXniIterator.Current.Value
                            Case "country"
                                pStrCountry = pXniIterator.Current.Value
                            Case "zipCode"
                                pStrZipCode = pXniIterator.Current.Value
                            Case "phone"
                                pStrPhone = pXniIterator.Current.Value
                            Case "email"
                                pStrEmail = pXniIterator.Current.Value
                            Case "website"
                                pStrWebsite = pXniIterator.Current.Value
                        End Select

                    Loop Until (Not pXniIterator.Current.MoveToNext)
                    Contacts.Add(New Contact(pStrFirstName, pStrLastName, pStrTitle, pStrAddress, pStrCity, pStrState, pStrCountry, pStrZipCode, pStrPhone, pStrEmail, pStrWebsite))

                Loop Until (Not pXniIterator.Current.MoveToNextAttribute())

            End While

            Return (True)

        Catch ex As Exception

            Return (False)

        End Try

    End Function

    Private Function SavePhoneBook(ByVal iFileName As String) As Boolean

        Dim Writer As XmlTextWriter = Nothing
        Dim pIntCurContact As Integer

        Try

            Writer = New XmlTextWriter(iFileName, System.Text.Encoding.Default)

            With Writer

                .Formatting = Formatting.Indented
                .Indentation = 4

                .WriteRaw("<?xml version=""1.0""?>")
                .WriteStartElement("phonebook")

                For pIntCurContact = 1 To Contacts.Count

                    .WriteStartElement("contact")

                    .WriteStartElement("firstname")
                    .WriteString(Contacts.Item(pIntCurContact).FirstName)
                    .WriteEndElement()

                    .WriteStartElement("lastname")
                    .WriteString(Contacts.Item(pIntCurContact).LastName)
                    .WriteEndElement()

                    .WriteStartElement("title")
                    .WriteString(Contacts.Item(pIntCurContact).Title)
                    .WriteEndElement()

                    .WriteStartElement("address")
                    .WriteString(Contacts.Item(pIntCurContact).Address)
                    .WriteEndElement()

                    .WriteStartElement("city")
                    .WriteString(Contacts.Item(pIntCurContact).City)
                    .WriteEndElement()

                    .WriteStartElement("state")
                    .WriteString(Contacts.Item(pIntCurContact).State)
                    .WriteEndElement()

                    .WriteStartElement("country")
                    .WriteString(Contacts.Item(pIntCurContact).Country)
                    .WriteEndElement()

                    .WriteStartElement("zipcode")
                    .WriteString(Contacts.Item(pIntCurContact).ZipCode)
                    .WriteEndElement()

                    .WriteStartElement("phone")
                    .WriteString(Contacts.Item(pIntCurContact).Phone)
                    .WriteEndElement()

                    .WriteStartElement("email")
                    .WriteString(Contacts.Item(pIntCurContact).Email)
                    .WriteEndElement()

                    .WriteStartElement("website")
                    .WriteString(Contacts.Item(pIntCurContact).Website)
                    .WriteEndElement()

                    .WriteEndElement()

                Next

                .WriteEndElement()

            End With

            Return (True)

        Catch

            Return (False)

        Finally

            Writer.Close()

        End Try

    End Function

#End Region

    Private Sub AddressBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddressBookPath = "Data\Contacts.sab"

        If (LoadPhoneBook(AddressBookPath)) Then

            If (Contacts.Count > 0) Then

                Call DisplayCurrentContact(True)

                SaveButton.Enabled = True
                PreviousButton.Enabled = True
                NextButton.Enabled = True

            Else

                SaveButton.Enabled = False
                PreviousButton.Enabled = False
                NextButton.Enabled = False

            End If

        Else

            MsgBox("An error occured while trying to read the phone book.", MsgBoxStyle.Information, "Application Message")

        End If

        'Contact List Script

        Dim Counter As Integer

        For Counter = 1 To Contacts.Count

            ContactList.Items.Add(Counter & ". " & Contacts(Counter).FirstName)

        Next Counter

    End Sub

    Private Sub PreviousButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreviousButton.Click

        If (CurrentContact > 1) Then

            CurrentContact -= 1
            Call DisplayCurrentContact(False)

        End If

    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click

        If (CurrentContact < Contacts.Count) Then

            CurrentContact += 1
            Call DisplayCurrentContact(False)

        End If

    End Sub

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click

        Dim pFrmAddContact As New AddContact()

        If (pFrmAddContact.ShowDialog = Windows.Forms.DialogResult.OK) Then
            Call Contacts.Add(pFrmAddContact.contact)

            CurrentContact = Contacts.Count
            Call DisplayCurrentContact(False)

            SaveButton.Enabled = True
            PreviousButton.Enabled = True
            NextButton.Enabled = True

        End If

    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click

        If (Contacts.Count > 0) Then

            If (MsgBox("Are you sure you want to remove the current contact?", MsgBoxStyle.YesNo, "Application Message") = Windows.Forms.DialogResult.Yes) Then

                Call Contacts.Remove(CurrentContact)

                If (CurrentContact > Contacts.Count) Then

                    CurrentContact -= 1

                End If

                Call DisplayCurrentContact(False)

            End If

        End If

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click

        If (SavePhoneBook(AddressBookPath)) Then

            MsgBox("The phonebook was saved successfully.", MsgBoxStyle.Information, "Application Message")

        Else

            MsgBox("An error occurred while trying to save the Address Book.", MsgBoxStyle.Critical, "Application Message")

        End If

    End Sub

End Class
