Imports System.Text.RegularExpressions
Imports System.Text

Public Class Decoder

    Public Function GetRegex(ByVal StringRegex As String, ByVal RawMessage As String) As String

        Dim RegRegex As New Regex(StringRegex, RegexOptions.IgnoreCase + RegexOptions.Multiline)
        Dim MchMatch As Match = RegRegex.Match(RawMessage)

        If MchMatch.Success Then

            Return MchMatch.Groups("value").Value

        End If

        Return ""

    End Function

    Public Function GetContentType(ByVal Content As String) As String

        Dim ContentType As String = ""

        If Not Content Is Nothing Then

            ContentType = GetRegex("^Content-Type:\s(?<value>.*?)(;|\n|\s)", Content).Trim.ToLower

        End If

        Return ContentType

    End Function

    Public Function GetContentName(ByVal vstrContent As String) As String

        If Not vstrContent Is Nothing Then

            Return GetRegex("Name=\""(?<value>.*?)\""", vstrContent)

        Else

            Return ""

        End If

    End Function

    Public Function GetEncodingType(ByVal Content As String) As String

        Return GetRegex("Content-Transfer-Encoding\:\s(?<value>.*?)($|\s|;)", Content).Trim

    End Function

    Public Function GetMIMEBoundry(ByVal Content As String) As String

        Return GetRegex("boundary=(?<value>.*?)(\n|$|\s)", Content).Replace("""", "").Trim.Replace(";", "") '.Replace("-", "")

    End Function

    Public Function GetCleanMessage(ByVal RawMessage As String) As String

        Dim strMessage As String = ""

        If RawMessage.EndsWith(vbCrLf & "." & vbCrLf) Then

            strMessage = RawMessage.Remove(RawMessage.Length - 5, 5).Trim()

        Else

            strMessage = RawMessage.Trim

        End If

        If strMessage.EndsWith(vbCrLf & "--") Then

            strMessage = strMessage.Remove(strMessage.Length - 3, 3).Trim

        End If

        Return strMessage.Replace("=" & vbCrLf, "").Replace("=3D", "=").Replace("=20" & vbCrLf, "")

    End Function

    Public Function GetBase64EncodedString(ByVal Value As String) As Byte()

        Return System.Convert.FromBase64String(Value)

    End Function

    Public Function GetBody(ByVal RawMessage As String) As String

        Dim Array As String()
        Dim CleanMessage As String
        Dim BodyText As String

        CleanMessage = GetCleanMessage(RawMessage)

        Array = Split(CStr(CleanMessage), vbCrLf & vbCrLf, 2)

        BodyText = Array(1)

        Return BodyText

    End Function

End Class
