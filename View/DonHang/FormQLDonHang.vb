Public Class FormQLDonHang
    Implements IBaseForm, IDonHangView

    Private donHangController As IDonHangControllerImpl

    Private listForms As List(Of Form)


    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnTaoDon.Click, AddressOf OnButtonClick

        'Set up DateTimePicker
        dtPicker.Format = DateTimePickerFormat.Custom
        dtPicker.CustomFormat = DATETIME_FORMAT
        dtPicker.Value = DateTime.Now

        listForms = New List(Of Form)
    End Sub

    Public Sub SetController(Controller As IDonHangControllerImpl) Implements IDonHangView.SetController
        donHangController = Controller
    End Sub

    Public Sub LoadData() Implements IDonHangView.LoadData
        donHangController.XulyLoadData()
        donHangController.XulyGetAllChiNhanh()
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IDonHangView.ShowMessageBox
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

    Public Sub BindingListPbhToGridView(list As List(Of DonHang)) Implements IDonHangView.BindingListDonHangToGridView
        dgvDonHang.DataSource = Nothing

        dgvDonHang.DataSource = list

        dgvDonHang.DataSource = bsPhieuBanHang

        ConfigureGridView()
    End Sub

    Public Sub BindingTolabelTextBox(phieuBh As DonHang) Implements IDonHangView.BindingTolabelTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ConfigureGridView() Implements IDonHangView.ConfigureGridView

    End Sub


    Public Sub BindingListChiNhanhToCombobox(list As List(Of ChiNhanh)) Implements IDonHangView.BindingListChiNhanhToCombobox
        cbChiNhanh.DataSource = Nothing
        cbChiNhanh.DataSource = list
        cbChiNhanh.DisplayMember = "Ten"
        cbChiNhanh.ValueMember = "Ma"
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
            Case "btnCapNhat"
            Case "btnTaoDon"
                TaoDon()
            Case "btnXoa"
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Sub TaoDon()
        ' Tao 1 phieu ban hang moi
        Dim newPhieuBanHang As New DonHang() With {
                 .Code = Gen_12Chars_UUID(),
                 .Ngay = dtPicker.Value.ToString(DATETIME_FORMAT),
                 .TongSanPham = 0,
                 .TongKhuyenMai = 0,
                 .TongTien = 0,
                 .GhiChu = "",
                 .IsXoa = False,
                 .BanHangKhachHang = New KhachHang() With {
                      .Code = Gen_6Chars_UUID(),
                      .Ten = "",
                      .DienThoai = "",
                      .DiaChi = "",
                      .IsXoa = False
                 },
                 .ChiNhanh = New ChiNhanh() With {
                      .Ma = Convert.ToInt32(cbChiNhanh.SelectedValue),
                      .Ten = cbChiNhanh.SelectedItem.Ten
                 }
        }
        MessageBox.Show(newPhieuBanHang.ToString())
        donHangController.XulyTaoDonHang(newPhieuBanHang)

    End Sub

    Private Sub FormQLBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donHangController = IDonHangControllerImpl.Instance
        donHangController.Init(Me)
        InitViews()
        LoadData()

    End Sub

    Public Sub GotoChiTietDonHangForm(tempDonHang As DonHang) Implements IDonHangView.GotoChiTietDonHangForm
        Dim frm As Form = TimForm(GetType(FormChiTietDonHang), listForms)
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim formTaoDonHang As New FormChiTietDonHang(tempDonHang)

        formTaoDonHang.MdiParent = Me.MdiParent
        formTaoDonHang.WindowState = FormWindowState.Maximized
        formTaoDonHang.Show()
        listForms.Add(formTaoDonHang)
    End Sub

    Private Sub dgvDonHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDonHang.CellClick

    End Sub
End Class