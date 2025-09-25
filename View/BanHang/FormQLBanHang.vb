Public Class FormQLBanHang
    Implements IBaseForm, IBanHangView

    Private phieuBanHangController As IBanHangControllerImpl

    Private listForms As List(Of Form)

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
        AddHandler btnTaoDon.Click, AddressOf OnButtonClick

        'Set up DateTimePicker
        dtPicker.Format = DateTimePickerFormat.Custom
        dtPicker.CustomFormat = DATETIME_FORMAT
        dtPicker.Value = DateTime.Now

        listForms = New List(Of Form)
    End Sub

    Public Sub SetController(Controller As IBanHangControllerImpl) Implements IBanHangView.SetController
        phieuBanHangController = Controller
    End Sub

    Public Sub LoadData() Implements IBanHangView.LoadData
        phieuBanHangController.XulyLoadData()
        phieuBanHangController.XulyGetAllChiNhanh()
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IBanHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements IBanHangView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"

            End Select

        End If
    End Sub

    Public Sub BindingListPbhToGridView(list As List(Of PhieuBanHang)) Implements IBanHangView.BindingListPbhToGridView
        dgvDonHang.DataSource = Nothing

        dgvDonHang.DataSource = list

        dgvDonHang.DataSource = bsPhieuBanHang

        ConfigureGridView()
    End Sub

    Public Sub BindingTolabelTextBox(phieuBh As PhieuBanHang) Implements IBanHangView.BindingTolabelTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ConfigureGridView() Implements IBanHangView.ConfigureGridView

    End Sub

    Public Sub ClearFields() Implements IBanHangView.ClearFields
        rtbGhiChu.Text = String.Empty
    End Sub

    Public Sub BindingListChiNhanhToCombobox(list As List(Of ChiNhanh)) Implements IBanHangView.BindingListChiNhanhToCombobox
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
        Dim frm As Form = TimForm(GetType(FormTaoDonHang), listForms)
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim formTaoDonHang As New FormTaoDonHang()

        formTaoDonHang.MdiParent = Me.MdiParent
        formTaoDonHang.WindowState = FormWindowState.Maximized
        formTaoDonHang.Show()
        listForms.Add(formTaoDonHang)

        'Dim selectedDateTime As DateTime = dtPicker.Value

        'Dim formattedDate As String = selectedDateTime.ToString(DATETIME_FORMAT)

        'MessageBox.Show($"Ngày đã chọn: {formattedDate}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FormQLBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        phieuBanHangController = IBanHangControllerImpl.Instance
        phieuBanHangController.Init(Me)
        InitViews()
        LoadData()

    End Sub
End Class