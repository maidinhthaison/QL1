Public Class ChiTietPhieuChi
    Private _ma As Integer
    Private _sotien As Double
    Private _pc_ma As Integer
    Private _xoa As Boolean
    Private _lydo_ma As Integer
    Private _ghi_chu As String

    'Ref
    Private _pc_lydo As PhieuChiLyDo
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

    Public Property SoTien() As Double
        Get
            Return _sotien
        End Get
        Set(ByVal value As Double)
            _sotien = value
        End Set
    End Property

    Public Property PhieuChiMa() As Integer
        Get
            Return _pc_ma
        End Get
        Set(ByVal value As Integer)
            _pc_ma = value
        End Set
    End Property

    Public Property LyDoMa() As Integer
        Get
            Return _lydo_ma
        End Get
        Set(ByVal value As Integer)
            _lydo_ma = value
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

    Public Property GhiChu() As String
        Get
            Return _ghi_chu
        End Get
        Set(ByVal value As String)
            _ghi_chu = value
        End Set
    End Property

    Public Property GetPhieuChiLyDo() As PhieuChiLyDo
        Get
            Return _pc_lydo
        End Get
        Set(ByVal value As PhieuChiLyDo)
            _pc_lydo = value
        End Set
    End Property
End Class
