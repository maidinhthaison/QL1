Public Interface IBanHanqView
    Sub SetController(Controller As INhanVienControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListSanPhamToGridView(list As List(Of SanPham))

    Sub BindingListBanHangToGridView(list As List(Of SanPham))

    Sub BindingToTextBox(taiKhoan As TaiKhoan)

    Sub BindingTolabelTextBox(nhanViewn As NhanVien)

    Sub ConfigureGridView()

    Sub ClearFields()
End Interface
