Public Class SanPham
    Private _sp_ma As Integer
    Private _sp_ten As String
    Private _sp_mota As String
    Private _sp_loai As Integer
    Private _sp_gia As Double
    Private _sp_xoa As Boolean
    Private _sp_code As String

    Public Sub New()
        Me.Ma = 0
    End Sub

    Public Property Ma() As Integer
        Get
            Return _sp_ma
        End Get
        Set(ByVal value As Integer)
            _sp_ma = value
        End Set
    End Property

    Public Property Ten() As String
        Get
            Return _sp_ten
        End Get
        Set(ByVal value As String)
            _sp_ten = value
        End Set
    End Property

    Public Property Mota() As String
        Get
            Return _sp_mota
        End Get
        Set(ByVal value As String)
            _sp_mota = value
        End Set
    End Property

    Public Property Loai() As Integer
        Get
            Return _sp_loai
        End Get
        Set(ByVal value As Integer)
            _sp_loai = value
        End Set
    End Property

    Public Property Gia() As Double
        Get
            Return _sp_gia
        End Get
        Set(ByVal value As Double)
            _sp_gia = value
        End Set
    End Property

    Public Property IsXoa() As Boolean
        Get
            Return _sp_xoa
        End Get
        Set(ByVal value As Boolean)
            _sp_xoa = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _sp_code
        End Get
        Set(ByVal value As String)
            _sp_code = value
        End Set
    End Property

End Class
