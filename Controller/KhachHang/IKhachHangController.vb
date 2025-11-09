Public Interface IKhachHangController
    Function XulySaveKhachHang(khachHang As KhachHang) As Boolean
    Sub XulyTimKiemKhachHangBySDT(sdt As String)

    Sub XuLyGetAllKhachHang()

    Sub XulyThemKhachHang(addKhachHang As KhachHang)

    Sub XulyCapNhatKhachHang(editKhachHang As KhachHang)

    Sub XulyTimKiemKhachHang(tuKhoa As String)
End Interface
