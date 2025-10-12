Public Interface IChiTietDHController

    Sub XuLyGetAllSanPham()

    Sub XuLyGetAllSanPhamByChiNhanh(chiNhanhMa As Integer)

    Sub XuLySaveChiTietDonHang(listChiTietDonHang As List(Of ChiTietDonHang), donHang As DonHang, khachHang As KhachHang)


End Interface
