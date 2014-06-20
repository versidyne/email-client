Public Class Contact

    Private StrFirstName As String
    Private StrLastName As String
    Private StrTitle As String
    Private StrAddress As String
    Private StrCity As String
    Private StrState As String
    Private StrCountry As String
    Private StrZipCode As String
    Private StrPhone As String
    Private StrEmail As String
    Private StrWebsite As String


#Region "Property Interfaces"

    Public Property FirstName() As String

        Get
            Return (StrFirstName)
        End Get

        Set(ByVal Value As String)
            StrFirstName = Value
        End Set

    End Property

    Public Property LastName() As String

        Get
            Return (StrLastName)
        End Get

        Set(ByVal Value As String)
            StrLastName = Value
        End Set

    End Property

    Public Property Title() As String

        Get
            Return (StrTitle)
        End Get

        Set(ByVal Value As String)
            StrTitle = Value
        End Set

    End Property

    Public Property Address() As String

        Get
            Return (StrAddress)
        End Get

        Set(ByVal Value As String)
            StrAddress = Value
        End Set

    End Property

    Public Property City() As String

        Get
            Return (StrCity)
        End Get

        Set(ByVal Value As String)
            StrCity = Value
        End Set

    End Property

    Public Property State() As String

        Get
            Return (StrState)
        End Get

        Set(ByVal Value As String)
            StrState = Value
        End Set

    End Property

    Public Property Country() As String

        Get
            Return (StrCountry)
        End Get

        Set(ByVal Value As String)
            StrCountry = Value
        End Set

    End Property

    Public Property ZipCode() As String

        Get
            Return (StrZipCode)
        End Get

        Set(ByVal Value As String)
            StrZipCode = Value
        End Set

    End Property

    Public Property Phone() As String

        Get
            Return (StrPhone)
        End Get

        Set(ByVal Value As String)
            StrPhone = Value
        End Set

    End Property

    Public Property Email() As String

        Get
            Return (StrEmail)
        End Get

        Set(ByVal Value As String)
            StrEmail = Value
        End Set

    End Property

    Public Property Website() As String

        Get
            Return (StrWebsite)
        End Get

        Set(ByVal Value As String)
            StrWebsite = Value
        End Set

    End Property

#End Region

    Public Sub New()
    End Sub

    Public Sub New(ByVal iFirstName As String, ByVal iLastName As String, ByVal iTitle As String, ByVal iAddress As String, ByVal iCity As String, ByVal iState As String, ByVal iCountry As String, ByVal iZipCode As String, ByVal iPhone As String, ByVal iEmail As String, ByVal iWebsite As String)

        FirstName = iFirstName
        LastName = iLastName
        Title = iTitle
        Address = iAddress
        City = iCity
        State = iState
        Country = iCountry
        ZipCode = iZipCode
        Phone = iPhone
        Email = iEmail
        Website = iWebsite

    End Sub

End Class
