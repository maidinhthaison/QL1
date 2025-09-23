Public Class FormQLBanHang
    Implements IBanHanqView, IBaseForm

    Public Sub SetController(Controller As INhanVienControllerImpl) Implements IBanHanqView.SetController
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadData() Implements IBanHanqView.LoadData
        Throw New NotImplementedException()
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IBanHanqView.ShowMessageBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements IBanHanqView.ShowConfirmMessageBox
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingListSanPhamToGridView(list As List(Of SanPham)) Implements IBanHanqView.BindingListSanPhamToGridView
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingListBanHangToGridView(list As List(Of SanPham)) Implements IBanHanqView.BindingListBanHangToGridView
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingToTextBox(taiKhoan As TaiKhoan) Implements IBanHanqView.BindingToTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingTolabelTextBox(nhanViewn As NhanVien) Implements IBanHanqView.BindingTolabelTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ConfigureGridView() Implements IBanHanqView.ConfigureGridView
        Throw New NotImplementedException()
    End Sub

    Public Sub ClearFields() Implements IBanHanqView.ClearFields
        Throw New NotImplementedException()
    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        Throw New NotImplementedException()
    End Sub
End Class