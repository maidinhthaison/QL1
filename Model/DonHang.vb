Public Class DonHang
    Private _ma As Integer
    Private _code As String
    Private _ngay As DateTime
    Private _tong_san_pham As Integer
    Private _tong_khuyen_mai As Double
    Private _tong_tien As Double
    Private _tong_thanh_tien As Double
    Private _ghi_chu As String
    Private _khach_hang_ma As Integer
    Private _isXoa As Boolean
    Private _chi_nhanh_ma As Integer
    Private _nhan_vien_ma As Integer

    'Ref
    Private _khach_hang As KhachHang
    Private _chi_nhanh As ChiNhanh
    Private _nhan_vien As NhanVien
    Private _chi_tiet_don_hang As List(Of ChiTietDonHang)

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

    Public Property Ngay() As DateTime
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

    Public Property ThanhTien() As Double
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

    Public Property BanHangKhachHang() As KhachHang
        Get
            Return _khach_hang
        End Get
        Set(ByVal value As KhachHang)
            _khach_hang = value
        End Set
    End Property


    Public Property ChiNhanh() As ChiNhanh
        Get
            Return _chi_nhanh
        End Get
        Set(ByVal value As ChiNhanh)
            _chi_nhanh = value
        End Set
    End Property

    Public Property DonHang_NhanVien() As NhanVien
        Get
            Return _nhan_vien
        End Get
        Set(ByVal value As NhanVien)
            _nhan_vien = value
        End Set
    End Property

    Public Property KhachHangMa() As Integer
        Get
            Return _khach_hang_ma
        End Get
        Set(ByVal value As Integer)
            _khach_hang_ma = value
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

    Public Property NhanVienMa() As Integer
        Get
            Return _nhan_vien_ma
        End Get
        Set(ByVal value As Integer)
            _nhan_vien_ma = value
        End Set
    End Property

    Public Property ListChiTietDonhang() As List(Of ChiTietDonHang)
        Get
            Return _chi_tiet_don_hang
        End Get
        Set(ByVal value As List(Of ChiTietDonHang))
            _chi_tiet_don_hang = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Dim result As String = "Mã đơn hàng: " & Me.Code & Environment.NewLine &
                               "Ngày: " & Me.Ngay & Environment.NewLine &
                               "Tổng số sản phẩm: " & Me.TongSanPham & Environment.NewLine &
                               "Tổng khuyến mãi: " & Me.TongKhuyenMai.ToString("C2") & Environment.NewLine &
                               "Tổng tiền: " & Me.TongTien.ToString("C2") & Environment.NewLine &
                               "Thành tiền: " & Me.ThanhTien.ToString("C2") & Environment.NewLine &
                               "Ghi chú: " & Me.GhiChu & Environment.NewLine &
                               "Khách hàng Ma : " & Me.BanHangKhachHang.Ma & Environment.NewLine &
                               "Khách hàng Tên : " & Me.BanHangKhachHang.Ten & Environment.NewLine &
                               "Chi nhánh Mã " & Me.ChiNhanh.Ma & Environment.NewLine &
                               "Chi nhánh Tên: " & Me.ChiNhanh.Ten & Environment.NewLine &
                               "Nhân viên Mã: " & Me.DonHang_NhanVien.Ma & Environment.NewLine

        Return result
    End Function
End Class
