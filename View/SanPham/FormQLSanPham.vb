Public Class FormQLSanPham
    Implements ISanPhamView, IBaseForm

    Private sanPhamController As ISanPhamControllerImpl


    Public Sub SetController(Controller As ISanPhamControllerImpl) Implements ISanPhamView.SetController
        sanPhamController = Controller
    End Sub

    Public Sub LoadData() Implements ISanPhamView.LoadData
        sanPhamController.XulyLoadLoaiSanPham()
        sanPhamController.XulyLoadData()
    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements ISanPhamView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements ISanPhamView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"
                    XoaSanPham()
            End Select

        End If
    End Sub

    Private Sub XoaSanPham()
        If dgvSanPham.SelectedCells.Count > 0 Then
            sanPhamController.XulyXoaSanPham()
            bsSanPham.RemoveAt(sanPhamController.Index)

        End If
    End Sub

    Public Sub BindingListToGridView(list As List(Of SanPham)) Implements ISanPhamView.BindingListToGridView
        dgvSanPham.DataSource = Nothing

        bsSanPham.DataSource = list

        dgvSanPham.DataSource = bsSanPham

        ConfigureGridView()
    End Sub

    Public Sub BindingTolabelTextBox(sp As SanPham) Implements ISanPhamView.BindingTolabelTextBox
        tbSanpham.Text = sp.Ten
        tbGia.Text = sp.Gia
        rtbMota.Text = sp.Mota
        lbCode.Text = sp.Code
        cbLoaiSp.SelectedValue = sp.Loai

        lbKhuVuc.Text = sp.Kv_Ten
        lbNhacc.Text = sp.NCC_Ten

    End Sub

    Public Sub ConfigureGridView() Implements ISanPhamView.ConfigureGridView
        dgvSanPham.Columns("Ma").Visible = False
        dgvSanPham.Columns("IsXoa").Visible = False
        dgvSanPham.Columns("Mota").Visible = False

        dgvSanPham.Columns("Loai").Visible = False
        dgvSanPham.Columns("LoaiSp_Ma").Visible = False
        dgvSanPham.Columns("LoaiSp_Ncc_Ma").Visible = False
        dgvSanPham.Columns("LoaiSp_Kv_Ma").Visible = False
        dgvSanPham.Columns("NCC_Ma").Visible = False
        dgvSanPham.Columns("Kv_Ma").Visible = False


        ' Set custom header text for columns
        dgvSanPham.Columns("Ten").HeaderText = "SP"
        dgvSanPham.Columns("LoaiSp_Ten").HeaderText = "Loại"
        dgvSanPham.Columns("Gia").HeaderText = "Giá"
        dgvSanPham.Columns("Code").HeaderText = "Code"
        dgvSanPham.Columns("NCC_Ten").HeaderText = "NCC"
        dgvSanPham.Columns("Kv_Ten").HeaderText = "Kv_Ten"
    End Sub

    Public Sub ClearFields() Implements ISanPhamView.ClearFields
        tbSanpham.Text = ""
        tbGia.Text = ""
        tbTukhoa.Text = ""
        rtbMota.Text = ""
        lbCode.Text = ""
        lbNhacc.Text = ""
        lbKhuVuc.Text = ""
    End Sub

    Public Sub BindingListToComBoBoxLoaiSp(list As List(Of LoaiSanPham)) Implements ISanPhamView.BindingListToComBoBoxLoaiSp
        cbLoaiSp.DataSource = Nothing
        cbLoaiSp.DataSource = list
        cbLoaiSp.DisplayMember = "Ten"
        cbLoaiSp.ValueMember = "Ma"
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemSanPham()
            Case "btnCapNhat"
                CapNhatSanPham()
            Case "btnXoa"
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Function TaoCodeSp() As String
        Return GetRandomString(6)
    End Function

    Private Sub CapNhatSanPham()
        If dgvSanPham.SelectedCells.Count > 0 Then
            Dim selectedLoaiSp As LoaiSanPham = TryCast(cbLoaiSp.SelectedItem, LoaiSanPham)
            Dim editedSp As New SanPham() With {
                .Ten = tbSanpham.Text,
                .Mota = rtbMota.Text,
                .Gia = tbGia.Text,
                .Loai = selectedLoaiSp.Ma
            }
            sanPhamController.XulyCapNhatSanPham(editedSp)
        End If
    End Sub

    Private Sub ThemSanPham()
        Dim selectedLoaiSp As LoaiSanPham = TryCast(cbLoaiSp.SelectedItem, LoaiSanPham)
        MessageBox.Show(selectedLoaiSp.Ma)
        Dim newSp As New SanPham() With {
            .Ten = tbSanpham.Text,
            .Mota = rtbMota.Text,
            .Loai = selectedLoaiSp.Ma,
            .Gia = tbGia.Text,
            .IsXoa = False,
            .Code = $"{selectedLoaiSp.Code} - {TaoCodeSp()}"
        }
        sanPhamController.XulyThemSanPham(newSp)
    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If e.RowIndex >= 0 Then
            sanPhamController.Index = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvSanPham.Rows(e.RowIndex)
            Dim selectedSp As SanPham = CType(selectedRow.DataBoundItem, SanPham)
            If selectedSp IsNot Nothing Then
                BindingTolabelTextBox(selectedSp)
            End If
        End If
    End Sub

    Private Sub FormQLSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sanPhamController = ISanPhamControllerImpl.Instance
        sanPhamController.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Private Sub tbTukhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTukhoa.TextChanged
        Dim tukhoa = tbTukhoa.Text.Trim.ToString()
        Dim result As List(Of SanPham) = sanPhamController.XulyTimKiemSanPham(tukhoa)
        BindingListToGridView(result)
    End Sub
End Class