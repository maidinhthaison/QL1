Imports System.ComponentModel
Imports System.Security

Public Class FormKhuVuc

    Implements IKhuVucView, IBaseForm

    Private khuVucController As IKhuVucControllerImpl

    Private dsKhuVuc As DataTable

    Public Sub SetController(Controller As IKhuVucControllerImpl) Implements IKhuVucView.SetController
        khuVucController = Controller
    End Sub



    Public Sub LoadData() Implements IKhuVucView.LoadData
        dsKhuVuc = khuVucController.ProcessLoadData()
    End Sub

    Public Sub BindingToGridView(dataTable As DataTable) Implements IKhuVucView.BindingToGridView
        dgvKhuVuc.DataSource = dataTable

        dgvKhuVuc.Columns("kv_ma").Visible = False
        dgvKhuVuc.Columns("kv_xoa").Visible = False

        dgvKhuVuc.Columns("kv_code").HeaderText = "Mã KV"
        dgvKhuVuc.Columns("kv_ten").HeaderText = "Tên KV"
        dgvKhuVuc.Columns("kv_mo_ta").HeaderText = "Mô tả"
    End Sub

    Private Sub frmKhuVuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khuVucController = IKhuVucControllerImpl.Instance
        khuVucController.Init(Me)
        InitViews()
        LoadData()
    End Sub


    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemKhuVuc()
            Case "btnCapNhat"
                CapNhatKhuVuc()
            Case "btnXoa"
                ShowConfirmMessageBox("Xác nhận", "Bạn có muốn xoá", "btnXoa")
        End Select
    End Sub

    Private Sub XoaKhuVuc()
        If dgvKhuVuc.SelectedCells.Count > 0 Then

            Dim selectedRowIndex As Integer = dgvKhuVuc.SelectedCells(0).RowIndex
            Dim selectedRow As DataRowView = dgvKhuVuc.Rows(selectedRowIndex).DataBoundItem
            Dim khuVuc As DataRow = selectedRow.Row

            khuVuc("kv_xoa") = True

            khuVucController.ProcessXoaKhuVuc(dsKhuVuc)

            dsKhuVuc.Rows.Remove(khuVuc)

        End If
    End Sub

    Private Sub ThemKhuVuc()
        Dim KV As DataRow = dsKhuVuc.NewRow()
        KV("kv_ten") = tbTenKv.Text
        KV("kv_code") = tbMaKv.Text
        KV("kv_mo_ta") = rtbMota.Text
        KV("kv_xoa") = False

        dsKhuVuc.Rows.Add(KV)

        khuVucController.ProcessThemKhuVuc(dsKhuVuc)

    End Sub

    Private Sub dgvKhuVuc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhuVuc.CellClick
        If dgvKhuVuc.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvKhuVuc.SelectedCells(0).RowIndex
            Dim selectedRow As DataRowView = dgvKhuVuc.Rows(selectedRowIndex).DataBoundItem
            Dim khuVuc As DataRow = selectedRow.Row
            tbMaKv.Text = khuVuc("kv_code").ToString()
            rtbMota.Text = khuVuc("kv_mo_ta").ToString()
            tbTenKv.Text = khuVuc("kv_ten").ToString()
        End If
    End Sub

    Private Sub CapNhatKhuVuc()

        If dgvKhuVuc.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvKhuVuc.SelectedCells(0).RowIndex
            Dim selectedRow As DataRowView = dgvKhuVuc.Rows(selectedRowIndex).DataBoundItem
            Dim khuVuc As DataRow = selectedRow.Row

            khuVuc("kv_code") = tbMaKv.Text
            khuVuc("kv_ten") = tbTenKv.Text
            khuVuc("kv_mo_ta") = rtbMota.Text

            khuVucController.ProcessCapNhatKhuVuc(dsKhuVuc)

        End If
    End Sub

    'View
    Private Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
    End Sub

    Private Sub ShowMessageBox(Title As String, Message As String) Implements IKhuVucView.ShowMessageBox
        MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements IKhuVucView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"
                    XoaKhuVuc()
            End Select

        End If
    End Sub

    Private Sub ClearFields() Implements IKhuVucView.ClearFields
        tbMaKv.Text = ""
        tbTenKv.Text = ""
        rtbMota.Text = ""
    End Sub
End Class