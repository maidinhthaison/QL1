Public Interface ILoaiSanPhamView
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListToGridView(list As List(Of LoaiSanPham))

    Sub BindingToTextBox(loaiSp As LoaiSanPham)

    Sub ConfigureGridView()

    Sub ClearFields()

    Sub BindingListToComBoBoxKhuVuc(list As List(Of KhuVuc))

    Sub BindingListToComBoBoxNhaCungCap(list As List(Of NhaCungCap))

    Sub BindingListToComBoBoxChiNhanh(list As List(Of ChiNhanh))
End Interface
