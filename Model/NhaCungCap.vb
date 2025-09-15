Public Class NhaCungCap
    Private _ma As Integer
    Private _ten As String
    Private _diachi As String
    Private _dienthoai As String
    Private _ghichu As String
    Private _xoa As Boolean
    Private _code As String

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

    Public Property Ten() As String
        Get
            Return _ten
        End Get
        Set(ByVal value As String)
            _ten = value
        End Set
    End Property

    Public Property DiaChi() As String
        Get
            Return _diachi
        End Get
        Set(ByVal value As String)
            _diachi = value
        End Set
    End Property

    Public Property DienThoai() As String
        Get
            Return _dienthoai
        End Get
        Set(ByVal value As String)
            _dienthoai = value
        End Set
    End Property

    Public Property GhiChu() As String
        Get
            Return _ghichu
        End Get
        Set(ByVal value As String)
            _ghichu = value
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

    Public Property IsXoa() As Boolean
        Get
            Return _xoa
        End Get
        Set(ByVal value As Boolean)
            _xoa = value
        End Set
    End Property
End Class
