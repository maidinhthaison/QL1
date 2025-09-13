Imports System.ComponentModel
Imports System.Security

Public Class FormKhuVuc

    Implements IKhuVucView, IBaseForm

    Private khuVucController As IKhuVucControllerImpl


    Public Sub SetController(Controller As IKhuVucControllerImpl) Implements IKhuVucView.SetController
        khuVucController = Controller
    End Sub

    Public Sub LoadData() Implements IKhuVucView.LoadData
        khuVucController.XulyLoadData()
    End Sub

    Public Sub BindingListToGridView(list As List(Of KhuVuc)) Implements IKhuVucView.BindingListToGridView
        dgvKhuVuc.DataSource = Nothing
        'dgvKhuVuc.DataSource = list

        BindingSource1.DataSource = list

        dgvKhuVuc.DataSource = BindingSource1

        ConfigureGridView()

    End Sub

    Public Sub ConfigureGridView() Implements IKhuVucView.ConfigureGridView
        dgvKhuVuc.Columns("Ma").Visible = False
        dgvKhuVuc.Columns("IsXoa").Visible = False

        ' Set custom header text for columns
        dgvKhuVuc.Columns("Ten").HeaderText = "Tên KV"
        dgvKhuVuc.Columns("Mota").HeaderText = "Mô tả"
        dgvKhuVuc.Columns("Code").HeaderText = "Code"

    End Sub

    Public Sub BindingToTextBox(khuVuc As KhuVuc) Implements IKhuVucView.BindingToTextBox
        tbMaKv.Text = khuVuc.Code
        tbTenKv.Text = khuVuc.Ten
        rtbMota.Text = khuVuc.Mota
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
            BindingSource1.Filter = "IsXoa = False"
            khuVucController.XulyXoaKhuVuc()
        End If

    End Sub

    Private Sub ThemKhuVuc()
        Dim newKhuVuc As New KhuVuc() With {
            .Ten = tbTenKv.Text,
            .Mota = rtbMota.Text,
            .Code = tbMaKv.Text,
            .IsXoa = False
        }
        khuVucController.XulyThemKhuVuc(newKhuVuc)

    End Sub

    Private Sub dgvKhuVuc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhuVuc.CellClick

        If e.RowIndex >= 0 Then
            khuVucController.Index = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvKhuVuc.Rows(e.RowIndex)
            Dim selectedKhuVuc As KhuVuc = CType(selectedRow.DataBoundItem, KhuVuc)
            If selectedKhuVuc IsNot Nothing Then
                BindingToTextBox(selectedKhuVuc)
            End If
        End If
    End Sub

    Private Sub CapNhatKhuVuc()

        If dgvKhuVuc.SelectedCells.Count > 0 Then
            khuVucController.XulyCapNhatKhuVuc(tbTenKv.Text, rtbMota.Text, tbMaKv.Text)
        End If
    End Sub

    'View
    Private Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
    End Sub

    Private Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IKhuVucView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select

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