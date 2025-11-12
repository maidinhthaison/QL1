Public Interface IChiTietDonHangView
    Sub SetController(Controller As IChiTietDHControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingKhachHangToTextBox(khachHang As KhachHang)

    Sub BindingListSanPhamToGridView(list As List(Of SanPham))

    Sub BindingListKhachHangToGridView(list As List(Of KhachHang))

    Sub ConfigureGridView()

    Sub ClearFields()
End Interface
