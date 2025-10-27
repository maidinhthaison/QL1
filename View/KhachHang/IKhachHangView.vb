Public Interface IKhachHangView
    Sub GetAllKhachHang()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub BindingListKhacHangToGridView(list As List(Of KhachHang))

    Sub BindingKhachHangToTextBox(khachHang As KhachHang)

    Sub ConfigureKhachHangGridView()
End Interface
