Public Interface IBanHangView
    Sub SetController(Controller As IBanHangControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListPbhToGridView(list As List(Of PhieuBanHang))

    Sub BindingTolabelTextBox(phieuBh As PhieuBanHang)

    Sub BindingListChiNhanhToCombobox(list As List(Of ChiNhanh))

    Sub ConfigureGridView()

    Sub ClearFields()
End Interface
