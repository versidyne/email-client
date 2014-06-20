Public Class Webmail

    Public Username As String
    Public Password As String

    Private Sub Webmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Address As String

        Address = "http://email.shadowaretech.net/"

        ' + "?" + "_action=login" + "&_user=" + Username + "&_pass=" + Password

        Browser.Navigate(Address)

    End Sub
End Class