Public Class NhanVien
    Private _ma As Integer
    Private _ten As String
    Private _diachi As String
    Private _gioitinh As Boolean
    Private _xoa As Boolean
    Private _dienthoai As String

    'Ref
    Private _taiKhoan As TaiKhoan
    Private _taiKhoanTen As String

    Private _chiNhanh As ChiNhanh

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

    Public Property IsXoa() As Boolean
        Get
            Return _xoa
        End Get
        Set(ByVal value As Boolean)
            _xoa = value
        End Set
    End Property

    Public Property GioiTinh() As Boolean
        Get
            Return _gioitinh
        End Get
        Set(ByVal value As Boolean)
            _gioitinh = value
        End Set
    End Property

    Public Property TaiKhoan() As TaiKhoan
        Get
            Return _taiKhoan
        End Get
        Set(ByVal value As TaiKhoan)
            _taiKhoan = value
        End Set
    End Property

    Public Property TaiKhoanTen() As String
        Get
            Return _taiKhoanTen
        End Get
        Set(ByVal value As String)
            _taiKhoanTen = value
        End Set
    End Property

    Public Property ChiNhanh() As ChiNhanh
        Get
            Return _chiNhanh
        End Get
        Set(ByVal value As ChiNhanh)
            _chiNhanh = value
        End Set
    End Property
End Class
