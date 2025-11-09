Public Interface INhaCungCapView
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListToGridView(list As List(Of NhaCungCap))

    Sub BindingToTextBox(khuVuc As NhaCungCap)

    Sub ConfigureGridView()

    Sub ClearFields()

    ''
    Sub ConfigureGridViewSanPham()
    Sub BindingListSanPhamToGridView(list As List(Of SanPham))

End Interface
