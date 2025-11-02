Public Interface IPhieuChiController
    Sub Xuly_LoadLyDo_To_Combobox()
    Sub Xuly_TaoPhieuChi(phieuChi As PhieuChi)
    Sub Xuly_GetPhieuChi_By_ChiNhanh(chiNhanhMa As Integer)
    Sub Xuly_GetChiTietPhieuChi_By_MaPhieuChi(phieuChiMa As Integer)

    Sub Xuly_Save_CTPhieuChi(ctpc As ChiTietPhieuChi)
End Interface
