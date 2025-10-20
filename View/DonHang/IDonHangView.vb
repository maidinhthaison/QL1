Public Interface IDonHangView
    Sub SetController(Controller As IDonHangControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListDonHangToGridView(list As List(Of DonHang))

    Sub BindingTolabelTextBox(list As List(Of DonHang))

    Sub ConfigureGridView()

    Sub ConfigureGridViewChiTietDonHang()

    Sub GotoChiTietDonHangForm(tempDonHang As DonHang)
End Interface
