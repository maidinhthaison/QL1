Public Class FormLoaiSanPham
    Implements ILoaiSanPhamView, IBaseForm

    Private loaiSanPhamController As ILoaiSanPhamControllerImpl


    Public Sub SetController(Controller As ILoaiSanPhamControllerImpl) Implements ILoaiSanPhamView.SetController
        loaiSanPhamController = Controller
    End Sub

    Public Sub LoadData() Implements ILoaiSanPhamView.LoadData
        loaiSanPhamController.XulyComboboxKhuVuc()
        loaiSanPhamController.XulyComboboxNhaCungCap()
        loaiSanPhamController.XulyLoadData()
    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
        AddHandler btnHuy.Click, AddressOf OnButtonClick
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemLoaiSanPham()
            Case "btnCapNhat"
                CapNhatLoaiSanPham()
            Case "btnHuy"
                ClearFields()
            Case "btnXoa"
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Sub CapNhatLoaiSanPham()
        If dgvLoaiSp.SelectedCells.Count > 0 Then
            Dim selectedKhuVuc As KhuVuc = TryCast(cbKhuVuc.SelectedItem, KhuVuc)
            Dim selectedNhaCc As NhaCungCap = TryCast(cbNhaCc.SelectedItem, NhaCungCap)
            Dim editedLoaiSp As New LoaiSanPham() With {
                .Ten = tbTen.Text,
                .Mota = rtbMota.Text,
                .Lsp_Ncc = selectedNhaCc,
                .Lsp_Kv = selectedKhuVuc,
                .Lsp_Ncc_Ma = If(selectedNhaCc IsNot Nothing, selectedNhaCc.Ma, 0),
                .Lsp_Kv_Ma = If(selectedKhuVuc IsNot Nothing, selectedKhuVuc.Ma, 0)
            }
            loaiSanPhamController.XulyCapNhatLoaiSanPham(editedLoaiSp)
        End If
    End Sub

    Private Sub ThemLoaiSanPham()
        Dim selectedKhuVuc As KhuVuc = TryCast(cbKhuVuc.SelectedItem, KhuVuc)
        Dim selectedNhaCc As NhaCungCap = TryCast(cbNhaCc.SelectedItem, NhaCungCap)
        Dim newLoaiSp As New LoaiSanPham() With {
            .Ten = tbTen.Text,
            .Mota = rtbMota.Text,
            .IsXoa = False,
            .Code = Gen_6Chars_UUID(),
            .Lsp_Ncc = selectedNhaCc,
            .Lsp_Kv = selectedKhuVuc,
            .Lsp_Kv_Ma = If(selectedKhuVuc IsNot Nothing, selectedKhuVuc.Ma, 0),
            .Lsp_Ncc_Ma = If(selectedNhaCc IsNot Nothing, selectedNhaCc.Ma, 0)
        }
        loaiSanPhamController.XulyThemLoaiSanPham(newLoaiSp)
    End Sub



    Private Sub XoaLoaiSanPham()
        If dgvLoaiSp.SelectedCells.Count > 0 Then

            loaiSanPhamController.XulyXoaLoaiSanPham()
            bsLoaiSp.RemoveAt(loaiSanPhamController.Index)

        End If
    End Sub

    Private Sub FormLoaiSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaiSanPhamController = ILoaiSanPhamControllerImpl.Instance
        loaiSanPhamController.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Private Sub dgvLoaiSp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLoaiSp.CellClick
        If e.RowIndex >= 0 Then
            loaiSanPhamController.Index = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvLoaiSp.Rows(e.RowIndex)
            Dim selectedLoaiSp As LoaiSanPham = CType(selectedRow.DataBoundItem, LoaiSanPham)
            If selectedLoaiSp IsNot Nothing Then
                BindingToTextBox(selectedLoaiSp)
            End If
        End If
    End Sub

    'View
    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements ILoaiSanPhamView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements ILoaiSanPhamView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"
                    XoaLoaiSanPham()
            End Select

        End If
    End Sub
    Public Sub BindingListToGridView(list As List(Of LoaiSanPham)) Implements ILoaiSanPhamView.BindingListToGridView
        dgvLoaiSp.DataSource = Nothing

        bsLoaiSp.DataSource = list

        dgvLoaiSp.DataSource = bsLoaiSp

        ConfigureGridView()
    End Sub

    Public Sub BindingToTextBox(loaiSp As LoaiSanPham) Implements ILoaiSanPhamView.BindingToTextBox
        tbTen.Text = loaiSp.Ten
        lbCode.Text = loaiSp.Code
        rtbMota.Text = loaiSp.Mota

        cbNhaCc.SelectedValue = loaiSp.Lsp_Ncc_Ma
        cbKhuVuc.SelectedValue = loaiSp.Lsp_Kv_Ma
    End Sub

    Public Sub ConfigureGridView() Implements ILoaiSanPhamView.ConfigureGridView
        dgvLoaiSp.Columns("Ma").Visible = False
        dgvLoaiSp.Columns("IsXoa").Visible = False
        dgvLoaiSp.Columns("Mota").Visible = False
        dgvLoaiSp.Columns("Lsp_Ncc").Visible = False
        dgvLoaiSp.Columns("Lsp_Kv").Visible = False

        ' Set custom header text for columns
        dgvLoaiSp.Columns("Ten").HeaderText = "Loại SP"
        dgvLoaiSp.Columns("Code").HeaderText = "Code"
        dgvLoaiSp.Columns("Lsp_Ncc_Ma").HeaderText = "Nhà CC"
        dgvLoaiSp.Columns("Lsp_Kv_Ma").HeaderText = "Khu vực"

    End Sub

    Public Sub ClearFields() Implements ILoaiSanPhamView.ClearFields
        tbTen.Text = ""
        rtbMota.Text = ""
        lbCode.Text = ""
    End Sub


    Public Sub BindingListToComBoBoxKhuVuc(list As List(Of KhuVuc)) Implements ILoaiSanPhamView.BindingListToComBoBoxKhuVuc
        cbKhuVuc.DataSource = Nothing
        cbKhuVuc.DataSource = list
        cbKhuVuc.DisplayMember = "Ten"
        cbKhuVuc.ValueMember = "Ma"
    End Sub

    Public Sub BindingListToComBoBoxNhaCungCap(list As List(Of NhaCungCap)) Implements ILoaiSanPhamView.BindingListToComBoBoxNhaCungCap
        cbNhaCc.DataSource = Nothing
        cbNhaCc.DataSource = list
        cbNhaCc.DisplayMember = "Ten"
        cbNhaCc.ValueMember = "Ma"
    End Sub

End Class