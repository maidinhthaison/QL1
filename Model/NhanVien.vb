Public Class NhanVien
    Private _ma As Integer
    Private _ten As String
    Private _diachi As String
    Private _gioitinh As Boolean
    Private _xoa As Boolean
    Private _dienthoai As String
    Private _nv_tk_ma As Integer
    Private _nv_chi_nhanh_ma As Integer

    'Ref
    Private _taiKhoan As TaiKhoan

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

    Public Property NV_TaiKhoan_Ma() As Integer
        Get
            Return _nv_tk_ma
        End Get
        Set(ByVal value As Integer)
            _nv_tk_ma = value
        End Set
    End Property

    Public Property NV_ChiNhanh_Ma() As Integer
        Get
            Return _nv_chi_nhanh_ma
        End Get
        Set(ByVal value As Integer)
            _nv_chi_nhanh_ma = value
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

    Public Property ChiNhanh() As ChiNhanh
        Get
            Return _chiNhanh
        End Get
        Set(ByVal value As ChiNhanh)
            _chiNhanh = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Dim result As String = "Chi nhánh Mã: " & Me.NV_ChiNhanh_Ma & Environment.NewLine &
                               "Chi nhánh Tên: " & Me.ChiNhanh.Ten & Environment.NewLine &
                               "Tài khoản mã: " & Me.NV_TaiKhoan_Ma & Environment.NewLine

        Return result
    End Function

End Class
