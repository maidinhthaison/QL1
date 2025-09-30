Public Interface IDonHangView
    Sub SetController(Controller As IDonHangControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListDonHangToGridView(list As List(Of DonHang))

    Sub BindingTolabelTextBox(phieuBh As DonHang)

    Sub BindingListChiNhanhToCombobox(list As List(Of ChiNhanh))

    Sub ConfigureGridView()

    Sub ClearFields()

    Sub GotoChiTietDonHangForm()
End Interface
