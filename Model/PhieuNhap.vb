Public Class PhieuNhap
    Private _ma As Integer
    Private _chi_nhanh_ma As Integer
    Private _code As String
    Private _ngay As DateTime
    Private _tong_san_pham As Integer
    Private _tong_khuyen_mai As Double
    Private _tong_tien As Double
    Private _tong_thanh_tien As Double
    Private _ghi_chu As String
    Private _isXoa As Boolean
    'Ref

    Private _chi_nhanh As ChiNhanh

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

    Public Property ChiNhanhMa() As Integer
        Get
            Return _chi_nhanh_ma
        End Get
        Set(ByVal value As Integer)
            _chi_nhanh_ma = value
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

    Public Property NgayNhap() As DateTime
        Get
            Return _ngay
        End Get
        Set(ByVal value As DateTime)
            _ngay = value
        End Set
    End Property

    Public Property TongSanPham() As Integer
        Get
            Return _tong_san_pham
        End Get
        Set(ByVal value As Integer)
            _tong_san_pham = value
        End Set
    End Property

    Public Property TongKhuyenMai() As Double
        Get
            Return _tong_khuyen_mai
        End Get
        Set(ByVal value As Double)
            _tong_khuyen_mai = value
        End Set
    End Property

    Public Property TongTien() As Double
        Get
            Return _tong_tien
        End Get
        Set(ByVal value As Double)
            _tong_tien = value
        End Set
    End Property

    Public Property TongThanhTien() As Double
        Get
            Return _tong_thanh_tien
        End Get
        Set(ByVal value As Double)
            _tong_thanh_tien = value
        End Set
    End Property

    Public Property GhiChu() As String
        Get
            Return _ghi_chu
        End Get
        Set(ByVal value As String)
            _ghi_chu = value
        End Set
    End Property

    Public Property IsXoa() As Boolean
        Get
            Return _isXoa
        End Get
        Set(ByVal value As Boolean)
            _isXoa = value
        End Set
    End Property

    Public Property PhieuNhap_ChiNhanh() As ChiNhanh
        Get
            Return _chi_nhanh
        End Get
        Set(ByVal value As ChiNhanh)
            _chi_nhanh = value
        End Set
    End Property

End Class
