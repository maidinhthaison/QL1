Public Class KhachHang
    Private _ma As Integer
    Private _code As String
    Private _ten As String
    Private _dien_thoai As String
    Private _dia_chi As String
    Private _isXoa As Boolean

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

    Public Property Ten() As String
        Get
            Return _ten
        End Get
        Set(ByVal value As String)
            _ten = value
        End Set
    End Property

    Public Property DienThoai() As String
        Get
            Return _dien_thoai
        End Get
        Set(ByVal value As String)
            _dien_thoai = value
        End Set
    End Property

    Public Property DiaChi() As String
        Get
            Return _dia_chi
        End Get
        Set(ByVal value As String)
            _dia_chi = value
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
    Public Overrides Function ToString() As String
        Dim result As String = "Mã  " & Me.Ma & Environment.NewLine &
                               "Code: " & Me.Code & Environment.NewLine &
                               "Ten: " & Me.Ten & Environment.NewLine &
                               "Dia chi: " & Me.DiaChi & Environment.NewLine &
                               "Dien Thoai: " & Me.DienThoai

        Return result
    End Function
End Class
