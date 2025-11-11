Public Class IThongKeControllerImpl
    Implements IThongKeController

    Private Shared _instance As IThongKeControllerImpl

    Private NvThongKeView As INhanVienThongKeView

    Private thongKeDao As ThongKeDAO

    Private listThongKeDoanhThuNhanVien As List(Of ChiTietDonHang)
    Private Sub New()
        thongKeDao = New ThongKeDAO()
        listThongKeDoanhThuNhanVien = New List(Of ChiTietDonHang)
    End Sub

    Public Shared ReadOnly Property Instance() As IThongKeControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IThongKeControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal nvView As INhanVienThongKeView)
        NvThongKeView = nvView
    End Sub

    Public Property ListThongKeBanHang() As List(Of ChiTietDonHang)
        Get
            Return listThongKeDoanhThuNhanVien
        End Get
        Set(ByVal value As List(Of ChiTietDonHang))
            listThongKeDoanhThuNhanVien = value
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

    Private Function CheckPeriod(period As EnumFilterThongKe) As Integer
        If period = EnumFilterThongKe.Thang Then
            Return -30
        ElseIf period = EnumFilterThongKe.Quy Then
            Return -90
        Else
            Return -365
        End If
    End Function
End Class
