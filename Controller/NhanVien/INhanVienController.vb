Public Interface INhanVienController
    Sub XulyThemNhanVien(newNhanVien As NhanVien)

    Sub XulyThemTaiKhoan(newTaiKhoan As TaiKhoan, newNhanVien As NhanVien)
    Sub XulyLoadData()

    Function XulyTimKiemNhanVien(tukhoa As String) As List(Of NhanVien)

    Sub XulyCapNhatNhanVienTK(editedNhanVien As NhanVien)

    Sub XulyGetAllChiNhanh()

    Sub XulyXoaNhanVien()

    Sub XulyDangNhap(taiKhoan As TaiKhoan)

End Interface
