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

    End Sub

    Public Sub BindingToTextBox(khuVuc As KhuVuc) Implements IKhuVucView.BindingToTextBox
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
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Sub XoaKhuVuc()
        If dgvKhuVuc.SelectedCells.Count > 0 Then

            khuVucController.XulyXoaKhuVuc()
            BindingSource1.RemoveAt(khuVucController.Index)

        End If

    End Sub

    Private Sub ThemKhuVuc()
        Dim newKhuVuc As New KhuVuc() With {
            .Ten = tbTenKv.Text,
            .Mota = rtbMota.Text,
            .Code = Gen_6Chars_UUID(),
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
            Dim edittedKhuVuc As New KhuVuc() With {
                .Ten = tbTenKv.Text,
                .Mota = rtbMota.Text
            }
            khuVucController.XulyCapNhatKhuVuc(edittedKhuVuc)
        End If
    End Sub

    'View
    Private Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
    End Sub

    Private Sub ClearFields() Implements IKhuVucView.ClearFields

        tbTenKv.Text = ""
        rtbMota.Text = ""
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IKhuVucView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements IKhuVucView.ShowConfirmMessageBox
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