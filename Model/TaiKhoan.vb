Public Class TaiKhoan
    Private _ma As Integer
    Private _taikhoan As String
    Private _matkhau As String
    Private _xoa As Boolean
    Private _dang_nhap_sai As Integer
    Private _chu_quan As Boolean

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

    Public Property TaiKhoan() As String
        Get
            Return _taikhoan
        End Get
        Set(ByVal value As String)
            _taikhoan = value
        End Set
    End Property

    Public Property MatKhau() As String
        Get
            Return _matkhau
        End Get
        Set(ByVal value As String)
            _matkhau = value
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

    Public Property SoLanDangNhapSai() As Integer
        Get
            Return _dang_nhap_sai
        End Get
        Set(ByVal value As Integer)
            _dang_nhap_sai = value
        End Set
    End Property

    Public Property IsChuQuan() As Boolean
        Get
            Return _chu_quan
        End Get
        Set(ByVal value As Boolean)
            _chu_quan = value
        End Set
    End Property

End Class
