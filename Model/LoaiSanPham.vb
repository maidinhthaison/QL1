Public Class LoaiSanPham
    Private _lsp_ma As Integer
    Private _lsp_ten As String
    Private _lsp_mota As String
    Private _lsp_xoa As Boolean
    Private _lsp_code As String
    Private _lsp_ncc As Integer
    Private _lsp_khu_vuc As Integer

    Public Sub New()
        Me.Ma = 0
    End Sub

    Public Property Ma() As Integer
        Get
            Return _lsp_ma
        End Get
        Set(ByVal value As Integer)
            _lsp_ma = value
        End Set
    End Property

    Public Property Ten() As String
        Get
            Return _lsp_ten
        End Get
        Set(ByVal value As String)
            _lsp_ten = value
        End Set
    End Property

    Public Property Mota() As String
        Get
            Return _lsp_mota
        End Get
        Set(ByVal value As String)
            _lsp_mota = value
        End Set
    End Property

    Public Property Code() As String
        Get
            Return _lsp_code
        End Get
        Set(ByVal value As String)
            _lsp_code = value
        End Set
    End Property

    Public Property IsXoa() As Boolean
        Get
            Return _lsp_xoa
        End Get
        Set(ByVal value As Boolean)
            _lsp_xoa = value
        End Set
    End Property

    Public Property NhaCc() As Integer
        Get
            Return _lsp_ncc
        End Get
        Set(ByVal value As Integer)
            _lsp_ncc = value
        End Set
    End Property

    Public Property Kv() As Integer
        Get
            Return _lsp_khu_vuc
        End Get
        Set(ByVal value As Integer)
            _lsp_khu_vuc = value
        End Set
    End Property
End Class
