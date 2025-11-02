Public Class PhieuChi
    Private _ma As Integer
    Private _ngay As DateTime
    Private _tongtien As Double
    Private _xoa As Boolean
    Private _code As String
    Private _ghichu As String
    Private _chinhanh_ma As Integer

    'Ref
    Private _list_ctpc As List(Of ChiTietPhieuChi)

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
    Public Property NgayChi() As DateTime
        Get
            Return _ngay
        End Get
        Set(ByVal value As DateTime)
            _ngay = value
        End Set
    End Property
    Public Property TongTien() As Double
        Get
            Return _tongtien
        End Get
        Set(ByVal value As Double)
            _tongtien = value
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

    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
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

    Public Property GetListChiTietPhieuChi() As List(Of ChiTietPhieuChi)
        Get
            Return _list_ctpc
        End Get
        Set(ByVal value As List(Of ChiTietPhieuChi))
            _list_ctpc = value
        End Set
    End Property

    Public Property ChiNhanhMa() As Integer
        Get
            Return _chinhanh_ma
        End Get
        Set(ByVal value As Integer)
            _chinhanh_ma = value
        End Set
    End Property

    Public Property PhieuChi_ChiNhanh() As ChiNhanh
        Get
            Return _chi_nhanh
        End Get
        Set(ByVal value As ChiNhanh)
            _chi_nhanh = value
        End Set
    End Property
End Class
