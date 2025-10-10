Public Interface ILoaiSanPhamController
    Sub XulyThemLoaiSanPham(addedLoaiSp As LoaiSanPham)
    Sub XulyXoaLoaiSanPham()
    Sub XulyCapNhatLoaiSanPham(editedLoaiSp As LoaiSanPham)
    Sub XulyLoadData()

    Sub XulyComboboxKhuVuc()

    Sub XulyComboboxNhaCungCap()

    Sub XulyComboboxChiNhanh()

    Function XulyTimKiemLoaiSanPham(tuKhoa As String) As List(Of LoaiSanPham)

End Interface
