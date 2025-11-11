Public Interface IThongKeController

    Sub XulyThongKeNhanVienBanHang(thoigian As EnumFilterThongKe, nVMa As Integer)

    Sub XulyThongKeDoanhThu(thoigian As EnumFilterThongKe)

    Function XulyTimKiemSanPham(tukhoa As String) As List(Of ChiTietDonHang)

    Sub XulyClickChiTietSanPham()
End Interface
