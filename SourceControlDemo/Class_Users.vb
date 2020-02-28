Public Class clsUsers
    Private _Firstname As String
    Private _Lastname As String
    Private _Username As String

    Public Property Firstname As String
        Get
            Firstname = _Firstname
        End Get
        Set(value As String)
            _Firstname = value
        End Set
    End Property

    Public Property Lastname As String
        Get
            Lastname = _Lastname
        End Get
        Set(value As String)
            _Lastname = value
        End Set
    End Property

    Public Property Username As String
        Get
            Username = _Username
        End Get
        Set(value As String)
            _Username = value
        End Set
    End Property

End Class
