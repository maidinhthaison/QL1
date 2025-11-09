Public Interface INhaCungCapController
    Sub XulyThemNhaCungCap(addedNhacc As NhaCungCap)
    Sub XulyXoaNhaCungCap()
    Sub XulyCapNhatNhaCungCap(editedNhacc As NhaCungCap)
    Sub XulyLoadData()

    ''
    Sub XuLyGetSanPhamByNhaCungCap(nhaCCMa As Integer)
End Interface
