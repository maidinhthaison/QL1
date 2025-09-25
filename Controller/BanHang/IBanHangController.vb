Public Interface IBanHangController

    Sub XulyLoadData()

    Function XulyTimKiemDonHang(tukhoa As String) As List(Of PhieuBanHang)

    Sub XulyCapNhatPhieuBanHang(pbhParam As PhieuBanHang)

    Sub XulyGetAllChiNhanh()
End Interface
