Imports System.ComponentModel
Imports System.Security

Public Class FormKhuVuc

    Implements IKhuVucView, IBaseForm

    Private khuVucController As IKhuVucControllerImpl

    Public Sub SetController(Controller As IKhuVucControllerImpl) Implements IKhuVucView.SetController
        khuVucController = Controller
    End Sub



    Public Sub LoadData() Implements IKhuVucView.LoadData
        khuVucController.ProcessLoadData()

    End Sub

    Public Sub BindingToTextBox(Kv As KhuVuc) Implements IKhuVucView.BindingToTextBox
        If Kv IsNot Nothing Then
            tbMaKv.Text = Kv.Code.ToString()
            tbTenKv.Text = Kv.Ten.ToString()
            rtbMota.Text = Kv.Mota.ToString()
        End If
    End Sub

    Public Sub BindingToGridView(list As BindingList(Of KhuVuc)) Implements IKhuVucView.BindingToGridView
        dgvKhuVuc.DataSource = list

        dgvKhuVuc.Columns("Ma").Visible = False
        dgvKhuVuc.Columns("IsXoa").Visible = False

        dgvKhuVuc.Columns("Code").HeaderText = "Mã KV"
        dgvKhuVuc.Columns("Ten").HeaderText = "Tên KV"
        dgvKhuVuc.Columns("Mota").HeaderText = "Mô tả"

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

            'Dim selectedRowIndex As Integer = dgvKhuVuc.SelectedCells(0).RowIndex
            'Dim selectedRow As DataRowView = dgvKhuVuc.Rows(selectedRowIndex).DataBoundItem
            'Dim khuVuc As DataRow = selectedRow.Row

            'khuVuc("kv_xoa") = True
            ''XL_DuLieu.GhiDuLieu("KhuVuc", dsKhuVuc)
            'khuVucController.ProcessXoaKhuVuc()
            'dsKhuVuc.Rows.Remove(khuVuc)
            'ClearFields()
        End If
    End Sub

    Private Sub ThemKhuVuc()
        'Dim KV As DataRow = dsKhuVuc.NewRow()
        'KV("kv_ten") = tbTenKv.Text
        'KV("kv_code") = tbMaKv.Text
        'KV("kv_mo_ta") = rtbMota.Text
        'KV("kv_xoa") = False

        'dsKhuVuc.Rows.Add(KV)
        ''XL_DuLieu.GhiDuLieu("KhuVuc", dsKhuVuc)
        'khuVucController.ProcessThemKhuVuc()
        'ClearFields()

    End Sub

    Private Sub dgvKhuVuc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhuVuc.CellClick
        If e.RowIndex < 0 Then
            Return
        Else
            khuVucController.ProcessClickOnCellGridView(e.RowIndex)
            'Dim row As DataGridViewRow = dgvKhuVuc.Rows(e.RowIndex)
            'Dim selectedKv As KhuVuc = TryCast(row.DataBoundItem, KhuVuc)
            'If selectedKv IsNot Nothing Then
            '    tbMaKv.Text = selectedKv.Ma.ToString()
            '    tbTenKv.Text = selectedKv.Ten.ToString()
            '    rtbMota.Text = selectedKv.Mota.ToString()
            'End If
        End If
    End Sub

    Private Sub CapNhatKhuVuc()
        If dgvKhuVuc.SelectedCells.Count > 0 Then
            'Dim selectedRowIndex As Integer = dgvKhuVuc.SelectedCells(0).RowIndex
            'Dim selectedRow As DataRowView = dgvKhuVuc.Rows(selectedRowIndex).DataBoundItem
            'Dim khuVuc As DataRow = selectedRow.Row

            'khuVuc("kv_code") = tbMaKv.Text
            'khuVuc("kv_ten") = tbTenKv.Text
            'khuVuc("kv_mo_ta") = rtbMota.Text


            Dim selectedRowIndex As Integer = dgvKhuVuc.SelectedCells(0).RowIndex
            khuVucController.ProcessCapNhatKhuVuc(selectedRowIndex, tbMaKv.Text,
                             tbTenKv.Text, rtbMota.Text)

        End If
    End Sub

    'View
    Private Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
    End Sub

    Private Sub ClearFields() Implements IBaseForm.ClearFields
        tbMaKv.Text = ""
        tbTenKv.Text = ""
        rtbMota.Text = ""
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
End Class