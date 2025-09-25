Public Class FormTaoDonHang
    Implements IBaseForm, ITaoDonHangView

    Private donHangControllerImpl As IDonHangControllerImpl

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
        AddHandler btnXacNhan.Click, AddressOf OnButtonClick
        AddHandler btnHuy.Click, AddressOf OnButtonClick


        lbDateTime.Text = DateTime.Now.ToString(DATETIME_FORMAT)
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
            Case "btnXoa"
            Case "btnXacNhan"

            Case "btnXoa"
                ClearFields()
        End Select
    End Sub

    Public Sub LoadData() Implements ITaoDonHangView.LoadData
        donHangControllerImpl.XuLyGetAllSanPham()
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements ITaoDonHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub BindingTolabelTextBox(phieuBh As PhieuBanHang) Implements ITaoDonHangView.BindingTolabelTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingListSanPhamToGridView(list As List(Of SanPham)) Implements ITaoDonHangView.BindingListSanPhamToGridView
        dgvSanPham.DataSource = Nothing

        SP_BindingSource.DataSource = list

        dgvSanPham.DataSource = SP_BindingSource

        ConfigureGridView()
    End Sub

    Public Sub ConfigureGridView() Implements ITaoDonHangView.ConfigureGridView
        dgvSanPham.Columns("Ma").Visible = False
        dgvSanPham.Columns("IsXoa").Visible = False
        dgvSanPham.Columns("Mota").Visible = False

        dgvSanPham.Columns("Loai").Visible = False
        dgvSanPham.Columns("LoaiSp_Ma").Visible = False
        dgvSanPham.Columns("LoaiSp_Ncc_Ma").Visible = False
        dgvSanPham.Columns("LoaiSp_Kv_Ma").Visible = False
        dgvSanPham.Columns("NCC_Ma").Visible = False
        dgvSanPham.Columns("Kv_Ma").Visible = False

        dgvSanPham.Columns("LoaiSp_Ten").Visible = False
        dgvSanPham.Columns("Kv_Ten").Visible = False

        ' Set custom header text for columns

        dgvSanPham.Columns("Code").HeaderText = "Code"
        dgvSanPham.Columns("Code").DisplayIndex = 0

        dgvSanPham.Columns("NCC_Ten").HeaderText = "NCC"
        dgvSanPham.Columns("NCC_Ten").DisplayIndex = 1

        dgvSanPham.Columns("Ten").HeaderText = "SP"
        dgvSanPham.Columns("Ten").DisplayIndex = 2

        dgvSanPham.Columns("Gia").HeaderText = "Giá"
        dgvSanPham.Columns("Gia").DisplayIndex = 3

    End Sub

    Public Sub ClearFields() Implements ITaoDonHangView.ClearFields
        tbTenKh.Text = ""
        tbDienThoaiKh.Text = ""
        tbDiachiKh.Text = ""
        tbSoluong.Text = ""
        tbKhuyenMai.Text = ""
    End Sub

    Private Sub FormTaoDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donHangControllerImpl = IDonHangControllerImpl.Instance
        donHangControllerImpl.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Public Sub SetController(Controller As IDonHangControllerImpl) Implements ITaoDonHangView.SetController
        donHangControllerImpl = Controller
    End Sub
End Class