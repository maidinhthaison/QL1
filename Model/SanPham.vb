Public Class SanPham
    Private _sp_ma As Integer
    Private _sp_ten As String
    Private _sp_mota As String
    Private _sp_loai As Integer
    Private _sp_gia As Double
    Private _sp_xoa As Boolean
    Private _sp_code As String
    Private _sp_dv_ma As Integer

    ' Ref
    Private _lsp_ma As Integer
    Private _lsp_ten As String

    Private _lsp_ncc_ma As Integer
    Private _lsp_kv_ma As Integer

    Private _ncc_ma As Integer
    Private _ncc_ten As String

    Private _kv_ma As Integer
    Private _kv_ten As String

    Private _lsp_soluong As Integer
    Private _lsp_chinhanh As ChiNhanh
    Private _lsp_donvi As DonVi

    Public Property LoaiSp_Ma() As Integer
        Get
            Return _lsp_ma
        End Get
        Set(ByVal value As Integer)
            _lsp_ma = value
        End Set
    End Property

    Public Property LoaiSp_Ten() As String
        Get
            Return _lsp_ten
        End Get
        Set(ByVal value As String)
            _lsp_ten = value
        End Set
    End Property

    Public Property LoaiSp_Ncc_Ma() As Integer
        Get
            Return _lsp_ncc_ma
        End Get
        Set(ByVal value As Integer)
            _lsp_ncc_ma = value
        End Set
    End Property

    Public Property LoaiSp_Kv_Ma() As Integer
        Get
            Return _lsp_kv_ma
        End Get
        Set(ByVal value As Integer)
            _lsp_kv_ma = value
        End Set
    End Property
    ''

    Public Property NCC_Ma() As Integer
        Get
            Return _ncc_ma
        End Get
        Set(ByVal value As Integer)
            _ncc_ma = value
        End Set
    End Property

    Public Property NCC_Ten() As String
        Get
            Return _ncc_ten
        End Get
        Set(ByVal value As String)
            _ncc_ten = value
        End Set
    End Property
    ''
    Public Property Kv_Ma() As Integer
        Get
            Return _kv_ma
        End Get
        Set(ByVal value As Integer)
            _kv_ma = value
        End Set
    End Property

    Public Property Kv_Ten() As String
        Get
            Return _kv_ten
        End Get
        Set(ByVal value As String)
            _kv_ten = value
        End Set
    End Property

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

    Public Property Sp_SoLuong() As Integer
        Get
            Return _lsp_soluong
        End Get
        Set(ByVal value As Integer)
            _lsp_soluong = value
        End Set
    End Property

    Public Property LoaiSp_ChiNhanh() As ChiNhanh
        Get
            Return _lsp_chinhanh
        End Get
        Set(ByVal value As ChiNhanh)
            _lsp_chinhanh = value
        End Set
    End Property

    Public Property Sp_Dv_Ma() As Integer
        Get
            Return _sp_dv_ma
        End Get
        Set(ByVal value As Integer)
            _sp_dv_ma = value
        End Set
    End Property

    Public Property Sp_DonVi() As DonVi
        Get
            Return _lsp_donvi
        End Get
        Set(ByVal value As DonVi)
            _lsp_donvi = value
        End Set
    End Property
End Class
