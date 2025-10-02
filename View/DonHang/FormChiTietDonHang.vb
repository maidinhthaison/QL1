Imports System.ComponentModel
Imports System.Runtime

Public Class FormChiTietDonHang
    Implements IBaseForm, IChiTietDonHangView

    Private pBHId As Integer

    Private donHangControllerImpl As IChiTietDHControllerImpl

    Public Sub New(ByVal message As String)
        InitializeComponent()
        Me.pBHId = Convert.ToInt32(message)
        MessageBox.Show(Me.pBHId)
    End Sub


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
                TaoDonHang()
            Case "btnXoa"
            Case "btnXacNhan"
                XacNhanDonHang()
            Case "btnXoa"
                ClearFields()
        End Select
    End Sub

    Private Sub XacNhanDonHang()
        Dim listChiTietPbh As List(Of ChiTietDonHang) = donHangControllerImpl.GetChiTietPbh
        If listChiTietPbh Is Nothing OrElse listChiTietPbh.Count = 0 Then
            ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Chưa có sản phẩm trong đơn hàng")
            Return
        Else
            donHangControllerImpl.XuLySaveChiTietDonHang(listChiTietPbh)
        End If
    End Sub

    Private Sub TaoDonHang()
        Dim index As Integer = donHangControllerImpl.Index
        Dim selectedSp As SanPham = donHangControllerImpl.ListSp(index)
        Dim foundProduct As ChiTietDonHang = donHangControllerImpl.GetChiTietPbh.FirstOrDefault(Function(p) p.Sp_Ma = selectedSp.Ma)

        If foundProduct IsNot Nothing Then
            'Cập nhật số lượng
            'foundProduct.SoLuong += 1
            foundProduct.SoLuong += Integer.Parse(tbSoluong.Text)
            Dim thanhtien As Double = Double.Parse(foundProduct.Gia) * Double.Parse(foundProduct.SoLuong)
            Dim khuyenmai As Double = thanhtien * Double.Parse(tbKhuyenMai.Text) / 100
            foundProduct.ThanhTien = thanhtien - khuyenmai
            foundProduct.KhuyenMai = khuyenmai
            RefreshDonHangGridView(donHangControllerImpl.GetChiTietPbh)
            ConfigureDonHangGridView()
        Else
            'Thêm mới
            Dim pbhCode As String = Gen_12Chars_UUID()
            Dim thanhtien As Double = Double.Parse(selectedSp.Gia) * Integer.Parse(tbSoluong.Text)
            Dim khuyenmai As Double = thanhtien * Double.Parse(tbKhuyenMai.Text) / 100

            Dim newChiTietDonHang As New ChiTietDonHang() With {
                 .Pbh_Ma = Me.pBHId,
                 .Sp_Ma = selectedSp.Ma,
                 .SoLuong = Integer.Parse(tbSoluong.Text),
                 .Gia = selectedSp.Gia,
                 .ThanhTien = thanhtien - khuyenmai,
                 .KhuyenMai = khuyenmai,
                 .IsXoa = False,
                 .GhiChu = tbGhiChu.Text,
                 .SanPhamInfo = selectedSp
             }

            donHangControllerImpl.GetChiTietPbh.Add(newChiTietDonHang)

            RefreshDonHangGridView(donHangControllerImpl.GetChiTietPbh)

            ConfigureDonHangGridView()
        End If

    End Sub

    Private Sub RefreshDonHangGridView(list As List(Of ChiTietDonHang))
        dgvDonHang.DataSource = Nothing
        CTDH_BindingSource.DataSource = list
        dgvDonHang.DataSource = CTDH_BindingSource

    End Sub

    Private Sub ConfigureDonHangGridView()
        dgvDonHang.Columns("Ma").Visible = False
        dgvDonHang.Columns("Pbh_Ma").Visible = False
        dgvDonHang.Columns("Sp_Ma").Visible = False
        dgvDonHang.Columns("GhiChu").Visible = False
        dgvDonHang.Columns("IsXoa").Visible = False

        ' Set custom header text for columns
        dgvDonHang.Columns("SanPhamInfo").HeaderText = "Sản Phẩm"
        dgvDonHang.Columns("SanPhamInfo").DisplayIndex = 0
        dgvDonHang.Columns("SanPhamInfo").Width = 200

        dgvDonHang.Columns("SoLuong").HeaderText = "SL"
        dgvDonHang.Columns("SoLuong").DisplayIndex = 1
        dgvDonHang.Columns("SoLuong").Width = 50

        dgvDonHang.Columns("Gia").HeaderText = "Đơn Giá"
        dgvDonHang.Columns("Gia").DisplayIndex = 2
        dgvDonHang.Columns("Gia").Width = 100

        dgvDonHang.Columns("KhuyenMai").HeaderText = "KM"
        dgvDonHang.Columns("KhuyenMai").DisplayIndex = 3
        dgvDonHang.Columns("KhuyenMai").Width = 100

        dgvDonHang.Columns("ThanhTien").HeaderText = "Thành Tiền"
        dgvDonHang.Columns("ThanhTien").DisplayIndex = 4
        dgvDonHang.Columns("ThanhTien").Width = 100

    End Sub

    Public Sub LoadData() Implements IChiTietDonHangView.LoadData
        donHangControllerImpl.XuLyGetAllSanPham()
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IChiTietDonHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub BindingTolabelTextBox(phieuBh As DonHang) Implements IChiTietDonHangView.BindingTolabelTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub BindingListSanPhamToGridView(list As List(Of SanPham)) Implements IChiTietDonHangView.BindingListSanPhamToGridView
        dgvSanPham.DataSource = Nothing

        SP_BindingSource.DataSource = list

        dgvSanPham.DataSource = SP_BindingSource

        ConfigureGridView()
    End Sub

    Public Sub ConfigureGridView() Implements IChiTietDonHangView.ConfigureGridView
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

    Public Sub ClearFields() Implements IChiTietDonHangView.ClearFields
        tbSoluong.Text = ""
        tbKhuyenMai.Text = ""
    End Sub

    Private Sub FormTaoDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donHangControllerImpl = IChiTietDHControllerImpl.Instance
        donHangControllerImpl.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Public Sub SetController(Controller As IChiTietDHControllerImpl) Implements IChiTietDonHangView.SetController
        donHangControllerImpl = Controller
    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If e.RowIndex >= 0 Then
            donHangControllerImpl.Index = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvSanPham.Rows(e.RowIndex)
            Dim selectedSp As SanPham = CType(selectedRow.DataBoundItem, SanPham)
            If selectedSp IsNot Nothing Then
                'BindingToTextBox(selectedLoaiSp)
            End If
        End If
    End Sub

    Private Sub BindingToTextBox(selectedLoaiSp As Object)
        Throw New NotImplementedException()
    End Sub

    Private Sub dgvDonHang_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDonHang.CellFormatting
        ' Check if we are in the correct column and not in the header row
        If e.RowIndex >= 0 AndAlso dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "SanPhamInfo" Then

            ' e.Value contains the whole ProductInfo object
            If e.Value IsNot Nothing Then
                Dim product As SanPham = TryCast(e.Value, SanPham)
                If product IsNot Nothing Then
                    ' Set the display value to the property you want
                    e.Value = product.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub
End Class