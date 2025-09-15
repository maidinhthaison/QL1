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
        AddHandler btnTaoCode.Click, AddressOf OnButtonClick
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
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingListToGridView(list As List(Of SanPham)) Implements ISanPhamView.BindingListToGridView
        dgvSanPham.DataSource = Nothing

        bsSanPham.DataSource = list

        dgvSanPham.DataSource = bsSanPham

        ConfigureGridView()
    End Sub

    Public Sub BindingToTextBox(loaiSp As SanPham) Implements ISanPhamView.BindingToTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ConfigureGridView() Implements ISanPhamView.ConfigureGridView
        dgvSanPham.Columns("Ma").Visible = False
        dgvSanPham.Columns("IsXoa").Visible = False
        dgvSanPham.Columns("Mota").Visible = False

        ' Set custom header text for columns
        dgvSanPham.Columns("Ten").HeaderText = "Tên SP"
        dgvSanPham.Columns("Loai").HeaderText = "Loại SP"
        dgvSanPham.Columns("Gia").HeaderText = "Giá SP"
        dgvSanPham.Columns("Code").HeaderText = "Code Sp"
    End Sub

    Public Sub ClearFields() Implements ISanPhamView.ClearFields
        tbSanpham.Text = ""
        tbGia.Text = ""
        tbTukhoa.Text = ""
        rtbMota.Text = ""
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
            Case "btnTaoCode"
                TaoCodeSp()
            Case "btnXoa"
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Sub TaoCodeSp()
        Dim selectedLoaiSp As LoaiSanPham = TryCast(cbLoaiSp.SelectedItem, LoaiSanPham)
        Dim str1 As String = GetRandomString(6)
        lbCode.Text = $"{selectedLoaiSp.Code}-{str1}"

    End Sub

    Private Sub CapNhatSanPham()
        Throw New NotImplementedException()
    End Sub

    Private Sub ThemSanPham()
        Throw New NotImplementedException()
    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick

    End Sub

    Private Sub FormQLSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sanPhamController = ISanPhamControllerImpl.Instance
        sanPhamController.Init(Me)
        InitViews()
        LoadData()
    End Sub

End Class