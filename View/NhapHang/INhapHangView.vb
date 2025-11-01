Public Interface INhapHangView

    Sub LoadData()

    Sub GotoChiTietPhieuNhap(phieuNhap As PhieuNhap)
    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)
    Sub BindingListPhieuNhapToGridView(list As List(Of PhieuNhap))

    Sub BindingPhieuNhapToTextBox(khuVuc As KhuVuc)

    Sub ConfigureNhapHangGridView()
End Interface
