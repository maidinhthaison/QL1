Public Class IChiTietDHControllerImpl
    Implements IChiTietDHController
    Private Shared _instance As IChiTietDHControllerImpl

    Private View As IChiTietDonHangView

    Private listSanPham As List(Of SanPham)

    Private listChiTietPBH As List(Of ChiTietDonHang)

    Private selectedSanPhamIndex As Integer

    Private sanPhamDao As SanPhamDAO

    Private chiTietPhieuBanHangDao As ChiTietDonHangDAO

    Private Sub New()
        listSanPham = New List(Of SanPham)
        listChiTietPBH = New List(Of ChiTietDonHang)
        sanPhamDao = New SanPhamDAO()
        chiTietPhieuBanHangDao = New ChiTietDonHangDAO()
    End Sub


    Public Property Index() As Integer
        Get
            Return selectedSanPhamIndex
        End Get
        Set(ByVal value As Integer)
            selectedSanPhamIndex = value
        End Set
    End Property

    Public Property ListSp() As List(Of SanPham)
        Get
            Return listSanPham
        End Get
        Set(ByVal value As List(Of SanPham))
            listSanPham = value
        End Set
    End Property

    Public Property GetChiTietPbh() As List(Of ChiTietDonHang)
        Get
            Return listChiTietPBH
        End Get
        Set(ByVal value As List(Of ChiTietDonHang))
            listChiTietPBH = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IChiTietDHControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IChiTietDHControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal donHangView As IChiTietDonHangView)
        View = donHangView
        View.SetController(Me)
    End Sub

    Public Sub XuLyGetAllSanPham() Implements IChiTietDHController.XuLyGetAllSanPham
        listSanPham = sanPhamDao.GetSP_By_LoaiSP_NhaCC_KhuVuc()
        View.BindingListSanPhamToGridView(listSanPham)
    End Sub

    Public Sub XuLySaveChiTietDonHang(listChiTietDonHang As List(Of ChiTietDonHang)) Implements IChiTietDHController.XuLySaveChiTietDonHang
        Throw New NotImplementedException()
    End Sub
End Class
