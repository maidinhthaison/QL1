Public Interface INhanVienController
    Sub XulyThemNhanVien(newNhanVien As NhanVien)

    Sub XulyThemTaiKhoan(newTaiKhoan As TaiKhoan, newNhanVien As NhanVien)
    Sub XulyLoadData()

    Function XulyTimKiemNhanVien(tukhoa As String, isXoa As Boolean) As List(Of NhanVien)

    Sub XulyCapNhatNhanVienTK(editedNhanVien As NhanVien)
End Interface
