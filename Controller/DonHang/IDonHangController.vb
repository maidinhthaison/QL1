Public Interface IDonHangController

    Sub Xuly_ChuQuan_Get_ChiTiet_DonHang_With_KH_NV_By_ChiNhanh(pbhMa As Integer)

    Sub Xuly_ChuQuan_GetAll_DonHang_With_KH_NhanVien_ChiNhanh_By_ChiNhanh(chiNhanhMa As Integer)

    Function Xuly_TimKiem_DonHang_By_ChiNhanh(tuKhoa As String) As List(Of DonHang)

    Sub Xuly_GetAll_DonHang_With_KH()

    Sub XulyTaoDonHang(tempDonHang As DonHang)
End Interface
