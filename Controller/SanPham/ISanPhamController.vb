Public Interface ISanPhamController
    Sub XulyThemSanPham(addedSanPham As SanPham)
    Sub XulyXoaSanPham()
    Sub XulyCapNhatSanPham(editedSanPham As SanPham)
    Sub XulyLoadData()
    Function XulyTimKiemSanPham(tukhoa As String) As List(Of SanPham)
    Sub XulyLoadLoaiSanPham()

    Function Xuly_Get_KhuVucNCC_By_LoaiSP_Ma(loaiSp As Integer) As List(Of LoaiSanPham)


End Interface
