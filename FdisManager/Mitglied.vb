Public Class Mitglied

    Private _Id As Integer
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(ByVal value As Integer)
            _Id = value
        End Set
    End Property

    Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    Private _SecondName As String
    Public Property SecondName() As String
        Get
            Return _SecondName
        End Get
        Set(ByVal value As String)
            _SecondName = value
        End Set
    End Property

    Private _BirthDate As Date
    Public Property BirthDate() As Date
        Get
            Return _BirthDate
        End Get
        Set(ByVal value As Date)
            _BirthDate = value
        End Set
    End Property

    Private _Rank As String
    Public Property Rank() As String
        Get
            Return _Rank
        End Get
        Set(ByVal value As String)
            _Rank = value
        End Set
    End Property

    Private _Status As String
    Public Property Status() As String
        Get
            Return _Status
        End Get
        Set(ByVal value As String)
            _Status = value
        End Set
    End Property

    Private newPropertyValue As String
    Public Property NewProperty() As String
        Get
            Return newPropertyValue
        End Get
        Set(ByVal value As String)
            newPropertyValue = value
        End Set
    End Property

End Class
