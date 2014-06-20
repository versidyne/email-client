Public Class Viewer

    Public Decoder As New Decoder
    Public RawMessage As String

    Private Sub Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim TempFileName As String
        Dim TempFileLoc As String
        Dim TimeStamp As String

        'Replace Certain Values

        RawMessage = RawMessage.Replace("=09", vbCrLf)

        'Display Email Information

        FromBox.Text = Decoder.GetRegex("^From:\s(?<value>.*?)(;|\n)", RawMessage).Replace(Chr(10), "").Replace(Chr(13), "")
        ToBox.Text = Decoder.GetRegex("^To:\s(?<value>.*?)(;|\n)", RawMessage).Replace(Chr(10), "").Replace(Chr(13), "")
        SubjectBox.Text = Decoder.GetRegex("^Subject:\s(?<value>.*?)(;|\n)", RawMessage).Replace(Chr(10), "").Replace(Chr(13), "")
        BodyBox.Text = Decoder.GetBody(RawMessage)

        'Generate TimeStamp

        TimeStamp = Hour(TimeOfDay) & "-" & Minute(TimeOfDay) & "-" & Second(TimeOfDay)

        'Generate Temporary File Name

        TempFileName = "Temp" & "-" & DateString & "-" & TimeStamp

        'Set Location

        TempFileLoc = Main.TempPath & TempFileName & ".html"

        'Create HTML Files

        My.Computer.FileSystem.WriteAllText(TempFileLoc, BodyBox.Text, False)

        'HTML Stuff

        WebBrowser.Navigate(TempFileLoc)

        'Unfinished Features

        PrintToolStripMenuItem.Enabled = False

    End Sub

    Private Sub NewMessageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewMessageToolStripMenuItem.Click

        Compose.FullName = Main.FullName
        Compose.Username = Main.Username
        Compose.Password = Main.Password
        Compose.Server = Main.Server
        Compose.Domain = Main.Domain

        Compose.Show()

    End Sub

    Private Sub ReplyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReplyToolStripMenuItem.Click

        Compose.ToBox.Text = FromBox.Text
        Compose.SubjectBox.Text = "Re: " + SubjectBox.Text

        Compose.FullName = Main.FullName
        Compose.Username = Main.Username
        Compose.Password = Main.Password
        Compose.Server = Main.Server
        Compose.Domain = Main.Domain

        Compose.Show()

    End Sub

    Private Sub SourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SourceToolStripMenuItem.Click

        SourceView.Show()

        SourceView.SourceDisplay.Text = RawMessage

    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        Me.Close()

    End Sub

End Class