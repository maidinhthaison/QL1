Public Interface INhapHangView

    Sub LoadData()

    Sub GotoChiTietPhieuNhap(phieuNhap As PhieuNhap)
    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)
    Sub BindingListPhieuNhapToGridView(list As List(Of PhieuNhap))

    Sub BindingPhieuNhapToTextBox(phieuNhap As PhieuNhap)

    Sub ConfigureNhapHangGridView()

    Sub RefreshNhapHangGridView(list As List(Of PhieuNhap))

    Sub BindingListChiTietPhieuNhapToGridView(list As List(Of ChiTietPhieuNhap))
    Sub ConfigureChiTietPhieuNhapGridView()

    Sub RefreshChiTietPhieuNhapGridView(list As List(Of ChiTietPhieuNhap))
End Interface
