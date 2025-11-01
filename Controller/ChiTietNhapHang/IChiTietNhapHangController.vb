Public Interface IChiTietNhapHangController
    Sub XuLyGetAllSanPhamByChiNhanh(chiNhanhMa As Integer)

    Function XulyTimKiemSanPham(tukhoa As String) As List(Of SanPham)

    Sub Xuly_Them_ChiTietNhapHang(chiTietPhieuNhap As ChiTietPhieuNhap, selectedSanPham As SanPham)

    Sub Xuly_Bo_ChiTietNhapHang()

    Sub ResetData()

    Sub Xuly_XacNhan_NhapHang(phieuNhap As PhieuNhap)

End Interface
