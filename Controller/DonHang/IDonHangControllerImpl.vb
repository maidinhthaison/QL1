Public Class IDonHangControllerImpl
    Implements IDonHangController

    Private Shared _instance As IDonHangControllerImpl

    Private View As IDonHangView

    Private listDonhang As List(Of DonHang)

    Private listChiNhanh As List(Of ChiNhanh)

    Private selectedIndex As Integer

    Private donHangDao As DonHangDAO

    Private chiNhanhDao As ChiNhanhDAO

    Private Sub New()
        listDonhang = New List(Of DonHang)
        listChiNhanh = New List(Of ChiNhanh)
        donHangDao = New DonHangDAO()
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

    Public Property Items() As List(Of DonHang)
        Get
            Return listDonhang
        End Get
        Set(ByVal value As List(Of DonHang))
            listDonhang = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IDonHangControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IDonHangControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal nvView As IDonHangView)
        View = nvView
        View.SetController(Me)
    End Sub

    Public Sub XulyLoadData() Implements IDonHangController.XulyLoadData
        listDonhang = donHangDao.Get_Pbh_By_ChiNhanh_KH()
        View.BindingListDonHangToGridView(listDonhang)
    End Sub



    Public Sub XulyGetAllChiNhanh() Implements IDonHangController.XulyGetAllChiNhanh
        listChiNhanh = chiNhanhDao.GetAllChiNhanh()
        View.BindingListChiNhanhToCombobox(listChiNhanh)
    End Sub



    Public Sub XulyThemPhieuBanHang(addedDonHang As DonHang) Implements IDonHangController.XulyThemPhieuBanHang
        Dim newDonHang As New List(Of DonHang) From {addedDonHang}
        If donHangDao.SaveDonHang(newDonHang) Then
            listDonhang.Add(addedDonHang)
            View.BindingListDonHangToGridView(listDonhang)

            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "đơn hàng"))

            View.ClearFields()
            View.GotoChiTietDonHangForm()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "đơn hàng"))
        End If
    End Sub


End Class
