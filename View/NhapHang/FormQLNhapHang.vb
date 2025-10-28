Public Class FormQLNhapHang
    Implements IBaseForm, INhapHangView

    Private nhapHangController As IDonHangControllerImpl

    Private nhanvienController As INhanVienControllerImpl

    Dim userSession As NhanVien

    Private listForms As List(Of Form)

    Public Sub InitViews() Implements IBaseForm.InitViews
        'AddHandler btnTaoDon.Click, AddressOf OnButtonClick

        ''Set up DateTimePicker
        'dtPicker.Format = DateTimePickerFormat.Custom
        'dtPicker.CustomFormat = DATETIME_FORMAT
        'dtPicker.Value = DateTime.Now

        'listForms = New List(Of Form)
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements INhapHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements IDonHangView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"

            End Select

        End If
    End Sub


    Public Sub BindingListPhieuNhapToGridView(list As List(Of PhieuNhap)) Implements INhapHangView.BindingListPhieuNhapToGridView
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingPhieuNhapToTextBox(khuVuc As KhuVuc) Implements INhapHangView.BindingPhieuNhapToTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ConfigureNhapHangGridView() Implements INhapHangView.ConfigureNhapHangGridView
        Throw New NotImplementedException()
    End Sub
End Class