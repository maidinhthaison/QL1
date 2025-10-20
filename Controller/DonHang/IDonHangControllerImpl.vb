Public Class IDonHangControllerImpl
    Implements IDonHangController

    Private Shared _instance As IDonHangControllerImpl

    Private View As IDonHangView

    Private listDonhang As List(Of DonHang)

    Private chiTietDonHang As DonHang

    Private selectedIndex As Integer

    Private donHangDao As DonHangDAO

    Private Sub New()
        listDonhang = New List(Of DonHang)
        donHangDao = New DonHangDAO()

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


    Public Sub XulyTaoDonHang(tempDonHang As DonHang) Implements IDonHangController.XulyTaoDonHang
        Dim newDonHang As New List(Of DonHang) From {tempDonHang}
        If donHangDao.SaveDonHang(newDonHang) Then
            View.GotoChiTietDonHangForm(tempDonHang)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "đơn hàng"))
        End If

    End Sub

    Public Sub Xuly_ChuQuan_GetAll_DonHang_With_KH_NhanVien_ChiNhanh_By_ChiNhanh(chiNhanhMa As Integer) Implements IDonHangController.Xuly_ChuQuan_GetAll_DonHang_With_KH_NhanVien_ChiNhanh_By_ChiNhanh

        listDonhang = donHangDao.ChuQuan_GetAll_DonHang_By_ChiNhanh(chiNhanhMa)
        View.BindingListDonHangToGridView(listDonhang)
    End Sub

    Public Sub Xuly_GetAll_DonHang_With_KH() Implements IDonHangController.Xuly_GetAll_DonHang_With_KH
        listDonhang = donHangDao.GetAll_DonHang_With_ChiNhanh_KH()
        View.BindingListDonHangToGridView(listDonhang)
    End Sub

    Public Function Xuly_TimKiem_DonHang_By_ChiNhanh(tuKhoa As String) As List(Of DonHang) Implements IDonHangController.Xuly_TimKiem_DonHang_By_ChiNhanh
        If String.IsNullOrWhiteSpace(tuKhoa) Then
            Return listDonhang
        Else
            Dim searchResult As List(Of DonHang) = listDonhang.Where(
                Function(donhang) donhang.Code.ToLower().Contains(tuKhoa.ToLower()) OrElse
                        donhang.Ngay.ToString().Contains(tuKhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        donhang.TongSanPham.ToString().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        donhang.TongKhuyenMai.ToString().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        donhang.TongTien.ToString().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        donhang.GhiChu.ToLower().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        donhang.DonHang_NhanVien.Ten.ToString.ToLower().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        donhang.BanHangKhachHang.Ten.ToLower().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        donhang.BanHangKhachHang.DienThoai.ToLower().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase)
                        ).ToList()
            Return searchResult
        End If
    End Function

    Public Sub Xuly_ChuQuan_Get_ChiTiet_DonHang_With_KH_NV_By_ChiNhanh(pbhMa As Integer) Implements IDonHangController.Xuly_ChuQuan_Get_ChiTiet_DonHang_With_KH_NV_By_ChiNhanh
        Dim list = donHangDao.ChuQuan_Get_ChiTiet_DonHang_With_KH_NV_By_ChiNhanh(pbhMa)
        If list IsNot Nothing AndAlso list.Count > 0 Then
            View.BindingTolabelTextBox(list)
        End If
    End Sub

End Class
