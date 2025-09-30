Public Interface IChiTietDonHangView
    Sub SetController(Controller As IChiTietDHControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub BindingTolabelTextBox(phieuBh As DonHang)

    Sub BindingListSanPhamToGridView(list As List(Of SanPham))

    Sub ConfigureGridView()

    Sub ClearFields()
End Interface
