Public Interface INhanVienView
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListToGridView(list As List(Of NhanVien))

    Sub BindingTolabelTextBox(nhanView As NhanVien)

    Sub BindingChiNhanhCombobox(list As List(Of ChiNhanh))

    Sub ConfigureGridView()

    Sub ClearFields()

End Interface
