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
        tbSoLuong.Text = sp.LoaiSp_SoLuong
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
        dgvSanPham.Columns("Code").Visible = False

        ' Set custom header text for columns

        dgvSanPham.Columns("Ten").HeaderText = "Tên"
        dgvSanPham.Columns("Ten").DisplayIndex = 0

        dgvSanPham.Columns("LoaiSp_Ten").HeaderText = "Loại"
        dgvSanPham.Columns("LoaiSp_Ten").DisplayIndex = 1

        dgvSanPham.Columns("Gia").HeaderText = "Giá"
        dgvSanPham.Columns("Gia").DisplayIndex = 2

        dgvSanPham.Columns("LoaiSp_SoLuong").HeaderText = "Số lượng"
        dgvSanPham.Columns("LoaiSp_SoLuong").DisplayIndex = 3

        dgvSanPham.Columns("NCC_Ten").HeaderText = "NCC"
        dgvSanPham.Columns("NCC_Ten").DisplayIndex = 4

        dgvSanPham.Columns("LoaiSp_ChiNhanh").HeaderText = "Chi nhánh"
        dgvSanPham.Columns("LoaiSp_ChiNhanh").DisplayIndex = 5

        dgvSanPham.Columns("Kv_Ten").HeaderText = "Khu vực"
        dgvSanPham.Columns("Kv_Ten").DisplayIndex = 6

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
        Dim list As List(Of LoaiSanPham) = sanPhamController.Xuly_Get_KhuVucNCC_By_LoaiSP_Ma(selectedLoaiSp.Ma)
        Dim loaiSP As LoaiSanPham = list(0)
        'MessageBox.Show($"{loaiSP.Ma} - {loaiSP.Ten} - {loaiSP.Lsp_Ncc.Ma} - {loaiSP.Lsp_Kv.Ma} -
        '    {loaiSP.Lsp_Ncc.Ma} - {loaiSP.Lsp_Ncc.Ten} - {loaiSP.Lsp_Kv.Ma} - {loaiSP.Lsp_Kv.Ten}")
        Dim newSp As New SanPham() With {
            .Ten = tbSanpham.Text,
            .Mota = rtbMota.Text,
            .Loai = selectedLoaiSp.Ma,
            .Gia = tbGia.Text,
            .IsXoa = False,
            .Code = Gen_12Chars_UUID(),
            .LoaiSp_Ma = loaiSP.Ma,
            .LoaiSp_Ten = loaiSP.Ten,
            .LoaiSp_Ncc_Ma = loaiSP.Lsp_Ncc.Ma,
            .LoaiSp_Kv_Ma = loaiSP.Lsp_Kv.Ma,
            .NCC_Ma = loaiSP.Lsp_Ncc_Ma,
            .NCC_Ten = loaiSP.Lsp_Ncc.Ten,
            .Kv_Ma = loaiSP.Lsp_Kv.Ma,
            .Kv_Ten = loaiSP.Lsp_Kv.Ten
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

    Private Sub dgvSanPham_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSanPham.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "LoaiSp_ChiNhanh" Then
            If e.Value IsNot Nothing Then
                Dim chiNhanh = TryCast(e.Value, ChiNhanh)
                If chiNhanh IsNot Nothing Then
                    e.Value = chiNhanh.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "NCC" Then
            If e.Value IsNot Nothing Then
                Dim ncc = TryCast(e.Value, NhaCungCap)
                If ncc IsNot Nothing Then
                    e.Value = ncc.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub
End Class