Public Interface ITaoDonHangView
    Sub SetController(Controller As IDonHangControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub BindingTolabelTextBox(phieuBh As PhieuBanHang)

    Sub BindingListSanPhamToGridView(list As List(Of SanPham))

    Sub ConfigureGridView()

    Sub ClearFields()
End Interface
