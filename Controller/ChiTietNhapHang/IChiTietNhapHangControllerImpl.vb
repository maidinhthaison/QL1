Public Class IChiTietNhapHangControllerImpl
    Implements IChiTietNhapHangController

    Private Shared _instance As IChiTietNhapHangControllerImpl

    Private View As IChiTietNhapHangView

    ''' <summary>
    ''' Chi Tiet Phieu Nhap
    ''' </summary>
    Private listChiTietPhieuNhap As List(Of ChiTietPhieuNhap)

    Private selectedIndex As Integer

    Private phieuNhapDAO As PhieuNhapDAO

    ''' <summary>
    ''' San pham
    ''' </summary>
    Private sanPhamDao As SanPhamDAO

    Private listSanPham As List(Of SanPham)

    Private selectedSanPhamIndex As Integer
    ''' <summary>
    ''' Chi tiet phieu nhap
    ''' </summary>
    Private chiTietPhieuNhapDAO As ChiTietPhieuNhapDAO
    Private Sub New()
        listChiTietPhieuNhap = New List(Of ChiTietPhieuNhap)
        phieuNhapDAO = New PhieuNhapDAO()

        listSanPham = New List(Of SanPham)
        sanPhamDao = New SanPhamDAO()

        chiTietPhieuNhapDAO = New ChiTietPhieuNhapDAO()
    End Sub
    ''' <summary>
    ''' Properties
    ''' </summary>
    ''' <returns></returns>

    Public Property GetSelectedIndex() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property GetListChiTietPhieuNhap() As List(Of ChiTietPhieuNhap)
        Get
            Return listChiTietPhieuNhap
        End Get
        Set(ByVal value As List(Of ChiTietPhieuNhap))
            listChiTietPhieuNhap = value
        End Set
    End Property

    Public Property GetSelectedSanPhamIndex() As Integer
        Get
            Return selectedSanPhamIndex
        End Get
        Set(ByVal value As Integer)
            selectedSanPhamIndex = value
        End Set
    End Property

    Public Property GetListSanPham() As List(Of SanPham)
        Get
            Return listSanPham
        End Get
        Set(ByVal value As List(Of SanPham))
            listSanPham = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IChiTietNhapHangControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IChiTietNhapHangControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal chiTietNhapHangView As IChiTietNhapHangView)
        View = chiTietNhapHangView
    End Sub

    ''' <summary>
    ''' Services
    ''' </summary>
    ''' <param name="chiNhanhMa"></param>
    Public Sub XuLyGetAllSanPhamByChiNhanh(chiNhanhMa As Integer) Implements IChiTietNhapHangController.XuLyGetAllSanPhamByChiNhanh
        listSanPham = sanPhamDao.GetSP_By_LoaiSP_NhaCC_KhuVuc_ChiNhanh(chiNhanhMa)
        View.BindingListSanPhamToGridView(listSanPham)
    End Sub

    Public Function XulyTimKiemSanPham(tukhoa As String) As List(Of SanPham) Implements IChiTietNhapHangController.XulyTimKiemSanPham
        If String.IsNullOrWhiteSpace(tukhoa) Then
            Return listSanPham
        Else
            Dim searchResult As List(Of SanPham) = listSanPham.Where(
                Function(sp) sp.Ten.ToLower().Contains(tukhoa.ToLower()) OrElse
                        sp.Gia.ToString().Contains(tukhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Code.ToString().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.LoaiSp_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.NCC_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.LoaiSp_ChiNhanh.Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Sp_SoLuong.ToString.Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Mota.Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Sp_DonVi.Ten.Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Kv_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase)
               ).ToList()
            Return searchResult
        End If
    End Function

    Public Sub Xuly_Them_ChiTietNhapHang(newCTPhieuNhap As ChiTietPhieuNhap, selectedSanPham As SanPham) Implements IChiTietNhapHangController.Xuly_Them_ChiTietNhapHang

        Dim currentSoluong = selectedSanPham.Sp_SoLuong
        '' Kiem tra ma san pham trong ctpn
        Dim foundCTPhieuNhap As ChiTietPhieuNhap = listChiTietPhieuNhap.FirstOrDefault(Function(p) p.MaSanPham = newCTPhieuNhap.GetSanPham.Ma)

        If foundCTPhieuNhap IsNot Nothing Then
            ' Trùng thì cập nhật số lượng
            foundCTPhieuNhap.SoLuong += newCTPhieuNhap.SoLuong
            foundCTPhieuNhap.TongTien += newCTPhieuNhap.TongTien
            foundCTPhieuNhap.KhuyenMai += newCTPhieuNhap.KhuyenMai
            foundCTPhieuNhap.TongThanhTien += newCTPhieuNhap.TongThanhTien
            Dim chiTietPN As New List(Of ChiTietPhieuNhap) From {foundCTPhieuNhap}
            If chiTietPhieuNhapDAO.SaveCTPhieuNhap(chiTietPN) Then
                View.BindingListCTPhieuNhapToGridView(listChiTietPhieuNhap)
                CapNhatTien()
                '' Cập nhật lại số lượng sản phẩm
                selectedSanPham.Sp_SoLuong = currentSoluong + newCTPhieuNhap.SoLuong
                View.BindingListSanPhamToGridView(listSanPham)

            Else
                View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE,
                                    String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "chi tiết đơn hàng"))
            End If
        Else
            ' Thêm mới
            Dim chiTietPN As New List(Of ChiTietPhieuNhap) From {newCTPhieuNhap}
            If chiTietPhieuNhapDAO.SaveCTPhieuNhap(chiTietPN) Then
                listChiTietPhieuNhap.Add(newCTPhieuNhap)
                View.BindingListCTPhieuNhapToGridView(listChiTietPhieuNhap)
                CapNhatTien()
                '' Cập nhật lại số lượng sản phẩm
                selectedSanPham.Sp_SoLuong = currentSoluong + newCTPhieuNhap.SoLuong
                View.BindingListSanPhamToGridView(listSanPham)

            Else
                View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE,
                                    String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "chi tiết đơn hàng"))
            End If
        End If

    End Sub

    Public Sub ResetData() Implements IChiTietNhapHangController.ResetData
        listSanPham.Clear()
        listChiTietPhieuNhap.Clear()
        selectedIndex = 0
        selectedSanPhamIndex = 0
    End Sub

    Public Sub Xuly_Bo_ChiTietNhapHang() Implements IChiTietNhapHangController.Xuly_Bo_ChiTietNhapHang
        If listChiTietPhieuNhap Is Nothing OrElse listChiTietPhieuNhap.Count = 0 Then
            Return
        End If
        Dim ctpn As ChiTietPhieuNhap = listChiTietPhieuNhap(selectedIndex)

        ' Cập nhật số lượng sản phẩm grid view
        Dim foundedSanPham As SanPham = listSanPham.FirstOrDefault(Function(p) p.Ma = ctpn.GetSanPham.Ma)
        ' Dim foundCTPhieuNhap As ChiTietPhieuNhap = listChiTietPhieuNhap.FirstOrDefault(Function(p) p.MaSanPham = chiTietPhieuNhap.GetSanPham.Ma)
        foundedSanPham.Sp_SoLuong = foundedSanPham.Sp_SoLuong - ctpn.SoLuong
        ctpn.GetSanPham.Sp_SoLuong = foundedSanPham.Sp_SoLuong
        View.BindingListSanPhamToGridView(listSanPham)

        listChiTietPhieuNhap.RemoveAt(selectedIndex)
        View.BindingListCTPhieuNhapToGridView(listChiTietPhieuNhap)

        CapNhatTien()
    End Sub

    Private Sub CapNhatTien()
        Dim tongKM As Integer = 0
        Dim tongTien As Integer = 0
        Dim tongThanhTien As Integer = 0
        For i As Integer = 0 To listChiTietPhieuNhap.Count - 1
            Dim item As ChiTietPhieuNhap = listChiTietPhieuNhap(i)
            tongKM += item.KhuyenMai
            tongTien += item.TongTien
            tongThanhTien += item.TongThanhTien
        Next
        View.BindingGiaTienToLabel(tongKM, tongTien, tongThanhTien)
    End Sub

    Public Sub Xuly_XacNhan_NhapHang(phieuNhap As PhieuNhap) Implements IChiTietNhapHangController.Xuly_XacNhan_NhapHang
        If listChiTietPhieuNhap IsNot Nothing Then
            Dim result0 As Boolean = chiTietPhieuNhapDAO.SaveCTPhieuNhap(listChiTietPhieuNhap)
            '' Cập nhật phiếu nhập
            Dim tongSp As Integer = 0
            Dim tongKm As Double = 0
            Dim tongTien As Double = 0
            Dim thanhTien As Double = 0
            Dim ghiChu As String = String.Empty
            For i As Integer = 0 To listChiTietPhieuNhap.Count - 1
                Dim item = listChiTietPhieuNhap(i)
                tongSp += item.SoLuong
                tongKm += item.KhuyenMai
                tongTien += item.TongTien
                thanhTien += item.TongThanhTien
                ghiChu += item.GhiChu & " "
            Next
            phieuNhap.TongSanPham = tongSp
            phieuNhap.TongKhuyenMai = tongKm
            phieuNhap.TongTien = tongTien
            phieuNhap.TongThanhTien = thanhTien
            phieuNhap.GhiChu = ghiChu
            Dim phieuNhapToSave As New List(Of PhieuNhap) From {phieuNhap}
            Dim result1 As Boolean = phieuNhapDAO.SavePhieuNhap(phieuNhapToSave)
            '' Cập nhật kho
            Dim result2 As Boolean = sanPhamDao.SaveSanPham(listSanPham)
            If result0 And result1 And result2 Then
                View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", "Nhập hàng thành công")
            Else
                View.ShowMessageBox(EnumMessageBox.Errors, "Thông báo", "Nhập hàng lỗi")
            End If
        End If


    End Sub
End Class
