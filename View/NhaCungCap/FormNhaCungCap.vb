Public Class FormNhaCungCap
    Implements INhaCungCapView, IBaseForm

    Private nhaCungCapController As INhaCungCapControllerImpl


    Public Sub SetController(Controller As INhaCungCapControllerImpl) Implements INhaCungCapView.SetController
        nhaCungCapController = Controller
    End Sub

    Public Sub LoadData() Implements INhaCungCapView.LoadData
        nhaCungCapController.XulyLoadData()
    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
        AddHandler btnHuy.Click, AddressOf OnButtonClick
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements INhaCungCapView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements INhaCungCapView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"
                    XoaNhaCungCap()
            End Select

        End If
    End Sub

    Private Sub XoaNhaCungCap()
        If dgvNhaCc.SelectedCells.Count > 0 Then

            nhaCungCapController.XulyXoaNhaCungCap()
            bsNhaCc.RemoveAt(nhaCungCapController.Index)

        End If
    End Sub

    Public Sub BindingListToGridView(list As List(Of NhaCungCap)) Implements INhaCungCapView.BindingListToGridView
        dgvNhaCc.DataSource = Nothing

        bsNhaCc.DataSource = list

        dgvNhaCc.DataSource = bsNhaCc

        ConfigureGridView()
    End Sub

    Public Sub BindingToTextBox(nhaCc As NhaCungCap) Implements INhaCungCapView.BindingToTextBox
        tbTen.Text = nhaCc.Ten
        tbDiachi.Text = nhaCc.DiaChi
        tbDienThoai.Text = nhaCc.DienThoai
        rtbGhichu.Text = nhaCc.GhiChu
        lbCode.Text = nhaCc.Code
    End Sub

    Public Sub ConfigureGridView() Implements INhaCungCapView.ConfigureGridView
        dgvNhaCc.Columns("Ma").Visible = False
        dgvNhaCc.Columns("IsXoa").Visible = False
        dgvNhaCc.Columns("GhiChu").Visible = False

        ' Set custom header text for columns
        dgvNhaCc.Columns("Ten").HeaderText = "Nhà CC"
        dgvNhaCc.Columns("DiaChi").HeaderText = "Địa chỉ"
        dgvNhaCc.Columns("DienThoai").HeaderText = "Điện thoại"
        dgvNhaCc.Columns("Code").HeaderText = "Code"

    End Sub

    Public Sub ClearFields() Implements INhaCungCapView.ClearFields
        tbTen.Text = ""
        tbDiachi.Text = ""
        tbDienThoai.Text = ""
        rtbGhichu.Text = ""
        lbCode.Text = ""
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemNhaCungCap()
            Case "btnCapNhat"
                CapNhatNhaCungCap()
            Case "btnHuy"
                ClearFields()
            Case "btnXoa"
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Sub CapNhatNhaCungCap()
        If dgvNhaCc.SelectedCells.Count > 0 Then
            Dim editedNhaCc As New NhaCungCap() With {
                .Ten = tbTen.Text,
                .DiaChi = tbDiachi.Text,
                .DienThoai = tbDienThoai.Text,
                .GhiChu = rtbGhichu.Text,
                .Code = lbCode.Text
            }
            nhaCungCapController.XulyCapNhatNhaCungCap(editedNhaCc)
        End If
    End Sub

    Private Sub ThemNhaCungCap()
        Dim newNhaCc As New NhaCungCap() With {
            .Ten = tbTen.Text,
            .DiaChi = tbDiachi.Text,
            .DienThoai = tbDienThoai.Text,
            .GhiChu = rtbGhichu.Text,
            .Code = Gen_6Chars_UUID(),
            .IsXoa = False
        }
        nhaCungCapController.XulyThemNhaCungCap(newNhaCc)
    End Sub



    Private Sub FormNhaCungCap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nhaCungCapController = INhaCungCapControllerImpl.Instance
        nhaCungCapController.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Private Sub dgvNhaCc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhaCc.CellClick
        If e.RowIndex >= 0 Then
            nhaCungCapController.Index = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvNhaCc.Rows(e.RowIndex)
            Dim selectedNhaCc As NhaCungCap = CType(selectedRow.DataBoundItem, NhaCungCap)
            If selectedNhaCc IsNot Nothing Then
                BindingToTextBox(selectedNhaCc)
            End If
        End If
    End Sub
End Class