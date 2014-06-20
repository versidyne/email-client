Public Class Pop3

    ' The default TCP/IP port number for POP3 is 110.
    Public Port As Integer = 110
    Public SPort As Integer = 995
    Public Messages As Integer = 0

    Private Const CommandFailure As String = "-ERR"

    ' Add SSL
    Private Pop3Server As Net.Sockets.TcpClient
    Private CommandSender As Net.Sockets.NetworkStream
    Private ContentReceiver As IO.StreamReader

    Public Sub Connect(ByVal serverName As String, _
    ByVal userName As String, ByVal password As String)
        ' Initiate the connection to a POP3 server.
        Dim commandData As String
        Dim contentBuffer() As Byte
        Dim responseString As String
        Dim parts() As String

        ' Connect to the POP3 server.
        Try
            Pop3Server = New Net.Sockets.TcpClient(serverName, Port)
            CommandSender = Pop3Server.GetStream()
            ContentReceiver = New IO.StreamReader(CommandSender)
        Catch
            Throw
        End Try

        If (userName <> "") Then
            ' Authenticate with the user ID.
            commandData = "USER " & userName & vbCrLf
            contentBuffer = _
               System.Text.Encoding.ASCII.GetBytes( _
               commandData.ToCharArray())
            CommandSender.Write(contentBuffer, 0, _
               contentBuffer.Length)
            responseString = ContentReceiver.ReadLine()
            If (Left(responseString, Len(CommandFailure)) = _
                  CommandFailure) Then
                Throw New Exception("Invalid user name.")
            End If

            ' Send the authenticating password.
            commandData = "PASS " & password & vbCrLf
            contentBuffer = _
               System.Text.Encoding.ASCII.GetBytes( _
               commandData.ToCharArray())
            CommandSender.Write(contentBuffer, 0, _
               contentBuffer.Length)
            responseString = ContentReceiver.ReadLine()
            If (Left(responseString, Len(CommandFailure)) = _
                  CommandFailure) Then
                Throw New Exception("Invalid password.")
            End If
        End If

        ' Logged in. On some servers, the PASS command
        ' is not enough to push the server into a
        ' transaction state. Send a STAT command twice.
        commandData = "STAT" + vbCrLf
        contentBuffer = System.Text.Encoding.ASCII.GetBytes( _
           commandData.ToCharArray())
        CommandSender.Write(contentBuffer, 0, _
           contentBuffer.Length)
        responseString = ContentReceiver.ReadLine()

        ' Get a count of the messages.
        commandData = "STAT" + vbCrLf
        contentBuffer = System.Text.Encoding.ASCII.GetBytes( _
           commandData.ToCharArray())
        CommandSender.Write(contentBuffer, 0, _
           contentBuffer.Length)
        responseString = ContentReceiver.ReadLine()
        If (Left(responseString, Len(CommandFailure)) = _
              CommandFailure) Then
            Throw New Exception( _
               "Could not retrieve message count.")
        End If

        ' The response includes two integers: a count
        ' and a size, separated by a space. Skip over
        ' the "+OK" part also.
        parts = Split(responseString, " ")
        Messages = Val(parts(1))
    End Sub

    Public Sub Disconnect()
        ' Disconnect from the POP3 server.
        Dim commandData As String
        Dim contentBuffer() As Byte
        Dim responseString As String

        ' Tell the server we're through.
        commandData = "QUIT" & vbCrLf
        contentBuffer = System.Text.Encoding.ASCII.GetBytes( _
           commandData.ToCharArray())
        CommandSender.Write(contentBuffer, 0, _
           contentBuffer.Length)
        responseString = ContentReceiver.ReadLine()

        ' End the connection.
        ContentReceiver.Close()
        CommandSender.Close()

        Pop3Server.Close()
    End Sub

    Function GetMessage(ByVal whichMessage As Integer) As String

        'Retrieve a single email message.

        Dim CommandData As String
        Dim ContentBuffer() As Byte
        Dim ResponseString As String
        Dim TheMessage As New System.Text.StringBuilder
        Dim OneLine As String

        'Check for an invalid message.

        If (whichMessage < 1) Or (whichMessage > Messages) Then
            Throw New ArgumentOutOfRangeException(whichMessage, "Messages are numbered from 1 to the number " & "identified by the Messages property.")
        End If

        Try

            'Request the message.

            CommandData = "RETR " & whichMessage & vbCrLf
            ContentBuffer = System.Text.Encoding.ASCII.GetBytes(CommandData.ToCharArray())
            CommandSender.Write(ContentBuffer, 0, ContentBuffer.Length)
            ResponseString = ContentReceiver.ReadLine()

            If (Left(ResponseString, Len(CommandFailure)) = CommandFailure) Then
                Throw New Exception("Message retrieval failed.")
            End If

            'The message is all data until a line with a single dot (.) appears.

            Do While (ContentReceiver.EndOfStream = False)
                OneLine = ContentReceiver.ReadLine()
                If (OneLine = ".") Then Exit Do
                TheMessage.AppendLine(OneLine)
            Loop

        Catch ex As InvalidOperationException
            MsgBox("Message retrieval failed: " & ex.Message)
        End Try

        'Return the constructed message.

        Return TheMessage.ToString()

    End Function

    Public Sub DeleteMessage(ByVal WhichMessage As Integer)

        Dim CommandData As String
        Dim ContentBuffer() As Byte
        Dim ResponseString As String

        If (WhichMessage < 1) Or (WhichMessage > Messages) Then
            Throw New ArgumentOutOfRangeException(WhichMessage, "Messages are numbered from 1 to the number " & "identified by the Messages property.")
        End If

        Try

            CommandData = "DELE " & WhichMessage & vbCrLf
            ContentBuffer = System.Text.Encoding.ASCII.GetBytes(CommandData.ToCharArray())
            CommandSender.Write(ContentBuffer, 0, ContentBuffer.Length)
            ResponseString = ContentReceiver.ReadLine()

            If (Left(ResponseString, Len(CommandFailure)) = CommandFailure) Then
                Throw New Exception("Message delete failed.")
            End If

        Catch ex As InvalidOperationException

            MsgBox("Message delete failed: " & ex.Message)

        End Try

    End Sub

End Class
