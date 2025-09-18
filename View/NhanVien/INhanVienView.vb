Public Interface INhanVienView
    Sub SetController(Controller As INhanVienControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListToGridView(list As List(Of NhanVien))

    Sub BindingToTextBox(taiKhoan As TaiKhoan)

    Sub ConfigureGridView()

    Sub ClearFields()

End Interface
