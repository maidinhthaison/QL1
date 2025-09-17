Public Interface ISanPhamController
    Sub XulyThemSanPham(addedSanPham As SanPham)
    Sub XulyXoaSanPham()
    Sub XulyCapNhatSanPham(editedSanPham As SanPham)
    Sub XulyLoadData()
    Function XulyTimKiemSanPham(tukhoa As String) As List(Of SanPham)

    Sub XulyLoadLoaiSanPham()

End Interface
