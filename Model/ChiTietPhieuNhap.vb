Public Class ChiTietPhieuNhap
    Private _ctpn_ma As Integer
    Private _ctpn_pn_ma As Integer
    Private _ctpn_ma_sp As Integer
    Private _ctpn_gia As Double
    Private _ctpn_so_luong As Integer
    Private _ctpn_khuyen_mai As Double
    Private _ctpn_tong_tien As Double
    Private _ctpn_thanh_tien As Double
    Private _ctpn_xoa As Boolean
    'Ref

    Private _san_pham As SanPham

    Public Sub New()
        Me.Ma = 0
    End Sub

    Public Property Ma() As Integer
        Get
            Return _ctpn_ma
        End Get
        Set(ByVal value As Integer)
            _ctpn_ma = value
        End Set
    End Property

    Public Property PhieuNhapMa() As Integer
        Get
            Return _ctpn_pn_ma
        End Get
        Set(ByVal value As Integer)
            _ctpn_pn_ma = value
        End Set
    End Property

    Public Property MaSanPham() As Integer
        Get
            Return _ctpn_ma_sp
        End Get
        Set(ByVal value As Integer)
            _ctpn_ma_sp = value
        End Set
    End Property

    Public Property Gia() As Double
        Get
            Return _ctpn_gia
        End Get
        Set(ByVal value As Double)
            _ctpn_gia = value
        End Set
    End Property

    Public Property SoLuong() As Integer
        Get
            Return _ctpn_so_luong
        End Get
        Set(ByVal value As Integer)
            _ctpn_so_luong = value
        End Set
    End Property

    Public Property KhuyenMai() As Double
        Get
            Return _ctpn_khuyen_mai
        End Get
        Set(ByVal value As Double)
            _ctpn_khuyen_mai = value
        End Set
    End Property

    Public Property TongTien() As Double
        Get
            Return _ctpn_tong_tien
        End Get
        Set(ByVal value As Double)
            _ctpn_tong_tien = value
        End Set
    End Property

    Public Property TongThanhTien() As Double
        Get
            Return _ctpn_thanh_tien
        End Get
        Set(ByVal value As Double)
            _ctpn_thanh_tien = value
        End Set
    End Property

    Public Property IsXoa() As Boolean
        Get
            Return _ctpn_xoa
        End Get
        Set(ByVal value As Boolean)
            _ctpn_xoa = value
        End Set
    End Property

    Public Property GetSanPham() As SanPham
        Get
            Return _san_pham
        End Get
        Set(ByVal value As SanPham)
            _san_pham = value
        End Set
    End Property

End Class
