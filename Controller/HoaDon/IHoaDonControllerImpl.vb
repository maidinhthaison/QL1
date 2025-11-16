Public Class IHoaDonControllerImpl
    Implements IHoaDonController

    Private Shared _instance As IHoaDonControllerImpl

    Private hoaDonView As IHoaDonView

    Private listPhieuBanHang As List(Of DonHang)

    Private donHangIndex As Integer

    Private donHangDAO As DonHangDAO
    Private Sub New()
        listPhieuBanHang = New List(Of DonHang)
        donHangDAO = New DonHangDAO()

    End Sub

    Public Sub Init(ByVal view As IHoaDonView)
        hoaDonView = view
    End Sub

    Public Sub XuLy_GetDanhSachHoaDon_By_NgayThangh_ChiNhanh(chiNhanhMa As Integer, ngayThang As Date) Implements IHoaDonController.XuLy_GetDanhSachHoaDon_By_NgayThangh_ChiNhanh
        listPhieuBanHang = donHangDAO.Get_ChiTiet_DonHang_With_KH_NV_By_NgayThang_ChiNhanh(ngayThang, chiNhanhMa)
        MessageBox.Show(listPhieuBanHang.Count)
        If listPhieuBanHang IsNot Nothing Then

            hoaDonView.BindingListHoaDonToGridView(listPhieuBanHang)
        End If

    End Sub

    Public Shared ReadOnly Property Instance() As IHoaDonControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IHoaDonControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Property GetDanhSachHoaDon() As List(Of DonHang)
        Get
            Return listPhieuBanHang
        End Get
        Set(ByVal value As List(Of DonHang))
            listPhieuBanHang = value
        End Set
    End Property

    Public Property GetSelectedDonHangIndex() As Integer
        Get
            Return donHangIndex
        End Get
        Set(ByVal value As Integer)
            donHangIndex = value
        End Set
    End Property

End Class
