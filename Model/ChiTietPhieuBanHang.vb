Public Class ChiTietPhieuBanHang
    Private _ma As Integer
    Private _so_luong As Integer
    Private _gia As Double
    Private _khuyen_mai As Double
    Private _thanh_tien As Double
    Private _isXoa As Boolean
    Private _ghichu As String

    'Ref
    Private _sanPham As SanPham

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

    Public Property SoLuong() As Integer
        Get
            Return _so_luong
        End Get
        Set(ByVal value As Integer)
            _so_luong = value
        End Set
    End Property

    Public Property Gia() As Double
        Get
            Return _gia
        End Get
        Set(ByVal value As Double)
            _gia = value
        End Set
    End Property

    Public Property KhuyenMai() As Double
        Get
            Return _khuyen_mai
        End Get
        Set(ByVal value As Double)
            _khuyen_mai = value
        End Set
    End Property

    Public Property ThanhTien() As Double
        Get
            Return _thanh_tien
        End Get
        Set(ByVal value As Double)
            _thanh_tien = value
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

    Public Property IsXoa() As Boolean
        Get
            Return _isXoa
        End Get
        Set(ByVal value As Boolean)
            _isXoa = value
        End Set
    End Property

    Public Property SanPham() As SanPham
        Get
            Return _sanPham
        End Get
        Set(ByVal value As SanPham)
            _sanPham = value
        End Set
    End Property
End Class
