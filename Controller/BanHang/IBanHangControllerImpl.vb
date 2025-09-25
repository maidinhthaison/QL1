Public Class IBanHangControllerImpl
    Implements IBanHangController

    Private Shared _instance As IBanHangControllerImpl

    Private View As IBanHangView

    Private listPhieuBanHang As List(Of PhieuBanHang)

    Private listChiNhanh As List(Of ChiNhanh)

    Private selectedIndex As Integer

    Private phieuBanHangDao As PhieuBanHangDAO

    Private chiNhanhDao As ChiNhanhDAO

    Private Sub New()
        listPhieuBanHang = New List(Of PhieuBanHang)
        listChiNhanh = New List(Of ChiNhanh)
        phieuBanHangDao = New PhieuBanHangDAO()
        chiNhanhDao = New ChiNhanhDAO()
    End Sub


    Public Property Index() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property Items() As List(Of PhieuBanHang)
        Get
            Return listPhieuBanHang
        End Get
        Set(ByVal value As List(Of PhieuBanHang))
            listPhieuBanHang = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IBanHangControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IBanHangControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal nvView As IBanHangView)
        View = nvView
        View.SetController(Me)
    End Sub

    Public Sub XulyLoadData() Implements IBanHangController.XulyLoadData
        listPhieuBanHang = phieuBanHangDao.Get_Pbh_By_ChiNhanh_KH()
        View.BindingListPbhToGridView(listPhieuBanHang)
    End Sub

    Public Sub XulyCapNhatPhieuBanHang(pbhParam As PhieuBanHang) Implements IBanHangController.XulyCapNhatPhieuBanHang
        Throw New NotImplementedException()
    End Sub

    Public Sub XulyGetAllChiNhanh() Implements IBanHangController.XulyGetAllChiNhanh
        listChiNhanh = chiNhanhDao.GetAllChiNhanh()
        View.BindingListChiNhanhToCombobox(listChiNhanh)
    End Sub

    Public Function XulyTimKiemDonHang(tukhoa As String) As List(Of PhieuBanHang) Implements IBanHangController.XulyTimKiemDonHang
        Throw New NotImplementedException()
    End Function
End Class
