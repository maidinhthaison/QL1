Public Class IThongKeControllerImpl
    Implements IThongKeController

    Private Shared _instance As IThongKeControllerImpl

    Private NvThongKeView As INhanVienThongKeView

    Private chuQuanThongKeView As IChuQuanThongKeView

    Private thongKeDao As ThongKeDAO

    Private listThongKeDoanhThuNhanVien As List(Of ChiTietDonHang)

    Private listThongKeDoanhThu As List(Of ChiTietDonHang)

    Private selectedCTDHIndex As Integer
    Private Sub New()
        thongKeDao = New ThongKeDAO()
        listThongKeDoanhThuNhanVien = New List(Of ChiTietDonHang)
        listThongKeDoanhThu = New List(Of ChiTietDonHang)
    End Sub

    Public Shared ReadOnly Property Instance() As IThongKeControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IThongKeControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub InitViewNhanVien(ByVal nvView As INhanVienThongKeView)
        NvThongKeView = nvView
    End Sub

    Public Sub InitViewChuQuan(ByVal chuQuanView As IChuQuanThongKeView)
        chuQuanThongKeView = chuQuanView
    End Sub

    Public Property ListThongKeBanHang() As List(Of ChiTietDonHang)
        Get
            Return listThongKeDoanhThuNhanVien
        End Get
        Set(ByVal value As List(Of ChiTietDonHang))
            listThongKeDoanhThuNhanVien = value
        End Set
    End Property

    Public Property ListThongKeDoanhThuCuaHang() As List(Of ChiTietDonHang)
        Get
            Return listThongKeDoanhThu
        End Get
        Set(ByVal value As List(Of ChiTietDonHang))
            listThongKeDoanhThu = value
        End Set
    End Property


    Public Property CTDHIndex() As Integer
        Get
            Return selectedCTDHIndex
        End Get
        Set(ByVal value As Integer)
            selectedCTDHIndex = value
        End Set
    End Property

    Public Sub XulyThongKeNhanVienBanHang(thoigian As EnumFilterThongKe, nvMa As Integer) Implements IThongKeController.XulyThongKeNhanVienBanHang
        Dim period As EnumFilterThongKe = CheckPeriod(thoigian)

        Dim fromDate As Date = Date.Today.AddDays(period)
        Dim toDate As Date = Date.Today

        listThongKeDoanhThuNhanVien = thongKeDao.ThongKe_DonHang_By_NvMa(nvMa, fromDate, toDate)
        NvThongKeView.BindingListDoanhThuSanPhamOfNhanVienToGridView(listThongKeDoanhThuNhanVien)
        NvThongKeView.SetDoanhThuLabel(CalculateDoanhThu(listThongKeDoanhThuNhanVien))
    End Sub

    Private Function CalculateDoanhThu(list As List(Of ChiTietDonHang)) As Double
        Dim total As Double = 0
        For Each item As ChiTietDonHang In list
            total += item.TongTien
        Next
        Return total
    End Function

    Private Function CalculateTienVon(list As List(Of ChiTietDonHang)) As Double
        Dim total As Double = 0
        For Each item As ChiTietDonHang In list
            total += item.SanPhamInfo.GiaNhap * item.SoLuong
        Next
        Return total
    End Function

    Private Function CalculateKhuyenMai(list As List(Of ChiTietDonHang)) As Double
        Dim total As Double = 0
        For Each item As ChiTietDonHang In list
            total += item.KhuyenMai
        Next
        Return total
    End Function

    Private Function CalculateLoiNhuan(list As List(Of ChiTietDonHang)) As Double
        Return CalculateDoanhThu(list) - CalculateTienVon(list) - CalculateKhuyenMai(list)
    End Function

    Private Function CheckPeriod(period As EnumFilterThongKe) As Integer
        If period = EnumFilterThongKe.Thang Then
            Return -30
        ElseIf period = EnumFilterThongKe.Quy Then
            Return -90
        Else
            Return -365
        End If
    End Function

    Public Sub XulyThongKeDoanhThu(thoigian As EnumFilterThongKe) Implements IThongKeController.XulyThongKeDoanhThu
        Dim period As EnumFilterThongKe = CheckPeriod(thoigian)

        Dim fromDate As Date = Date.Today.AddDays(period)
        Dim toDate As Date = Date.Today

        listThongKeDoanhThu = thongKeDao.ThongKe_DonHang_By_ThoiGian(fromDate, toDate)
        chuQuanThongKeView.BindingListDoanhThuSanPhamToGridView(listThongKeDoanhThu)
        chuQuanThongKeView.SetDoanhThuLabel(fromDate.ToString(DATETIME_FORMAT), toDate.ToString(DATETIME_FORMAT),
                        CalculateDoanhThu(listThongKeDoanhThu), CalculateTienVon(listThongKeDoanhThu),
                        CalculateKhuyenMai(listThongKeDoanhThu), CalculateLoiNhuan(listThongKeDoanhThu))
    End Sub

    Public Function XulyTimKiemSanPham(tukhoa As String) As List(Of ChiTietDonHang) Implements IThongKeController.XulyTimKiemSanPham
        If String.IsNullOrWhiteSpace(tukhoa) Then
            Return listThongKeDoanhThu
        Else
            Dim searchResult As List(Of ChiTietDonHang) = listThongKeDoanhThu.Where(
                Function(ctdh) ctdh.SanPhamInfo.Ten.ToLower().Contains(tukhoa.ToLower()) OrElse
                        ctdh.Gia.ToString().Contains(tukhoa.ToLower()) OrElse
                        ctdh.SoLuong.ToString().Contains(tukhoa.ToLower()) OrElse
                        ctdh.TongTien.ToString().Contains(tukhoa.ToLower()) OrElse
                        ctdh.KhuyenMai.ToString().Contains(tukhoa.ToLower()) OrElse
                        ctdh.ThanhTien.ToString().Contains(tukhoa.ToLower()) OrElse
                        ctdh.SanPhamInfo.LoaiSp_Ten.ToString().Contains(tukhoa.ToLower()) OrElse
                        ctdh.SanPhamInfo.NCC_Ten.ToString().Contains(tukhoa.ToLower())
               ).ToList()
            Return searchResult
        End If
    End Function

    Public Sub XulyClickChiTietSanPham() Implements IThongKeController.XulyClickChiTietSanPham

        Dim selectedCTDH As ChiTietDonHang = listThongKeDoanhThu(selectedCTDHIndex)
        If selectedCTDH IsNot Nothing Then
            Dim list As New List(Of ChiTietDonHang) From {selectedCTDH}
            chuQuanThongKeView.SetDoanhThuSanPhamLabel(
                        CalculateDoanhThu(list), CalculateTienVon(list),
                        CalculateKhuyenMai(list), CalculateLoiNhuan(list))
        End If
    End Sub
End Class
