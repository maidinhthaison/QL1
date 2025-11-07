Public Class PhieuChiLyDo
    Private _ma As Integer
    Private _code As String
    Private _mota As String

    Public Sub New()
        Me.Ma = 0
    End Sub

    Public Property Ma() As Integer
        Get
            Return _ma
        End Get
        Set(ByVal value As Integer)
            _ma = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Public Property Mota() As String
        Get
            Return _mota
        End Get
        Set(ByVal value As String)
            _mota = value
        End Set
    End Property
End Class
