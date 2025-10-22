Public Interface IChiTietDHController

    Sub XuLyGetAllSanPhamByChiNhanh(chiNhanhMa As Integer)

    Sub XuLySaveChiTietDonHang(listChiTietDonHang As List(Of ChiTietDonHang), donHang As DonHang, khachHang As KhachHang)

    Function XulyTimKiemSanPham(tukhoa As String) As List(Of SanPham)
End Interface
