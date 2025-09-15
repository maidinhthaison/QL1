Public Interface ISanPhamView
    Sub SetController(Controller As ISanPhamControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListToGridView(list As List(Of SanPham))

    Sub BindingToTextBox(loaiSp As SanPham)

    Sub ConfigureGridView()

    Sub ClearFields()

    Sub BindingListToComBoBoxLoaiSp(list As List(Of LoaiSanPham))

End Interface
