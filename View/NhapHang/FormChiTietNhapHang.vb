Imports System.DirectoryServices
Imports System.Dynamic

Public Class FormChiTietNhapHang
    Implements IBaseForm, IChiTietNhapHangView

    Private tempPhieuNhap As PhieuNhap

    Private chiTietPhieuNhapControllerImpl As IChiTietNhapHangControllerImpl

    Private sanPhamControllerImpl As ISanPhamControllerImpl

    Private nhanvienController As INhanVienControllerImpl
    Public Sub New(phieuNhap As PhieuNhap)
        InitializeComponent()
        Me.tempPhieuNhap = phieuNhap
    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnXacNhan.Click, AddressOf OnButtonClick
        AddHandler btnHuy.Click, AddressOf OnButtonClick
        AddHandler btnBora.Click, AddressOf OnButtonClick

        'MessageBox.Show($"{tempDonHang.Ngay.ToString(DATETIME_FORMAT)} - {tempDonHang.Ngay}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbNgayThang.Text = tempPhieuNhap.NgayNhap.ToString(DATETIME_FORMAT)
        lbChiNhanh.Text = tempPhieuNhap.PhieuNhap_ChiNhanh.Ten
    End Sub

    Public Sub ClearFields() Implements IChiTietNhapHangView.ClearFields
        tbSoluong.Text = ""
        tbKhuyenMai.Text = ""
        tbGhiChu.Text = ""
    End Sub

    Public Sub BindingListSanPhamToGridView(listSp As List(Of SanPham)) Implements IChiTietNhapHangView.BindingListSanPhamToGridView
        RefreshSanPhamGridView(listSp)

        ConfigureSanPhamGridView()
    End Sub

    Public Sub ConfigureSanPhamGridView() Implements IChiTietNhapHangView.ConfigureSanPhamGridView
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
        dgvSanPham.Columns("LoaiSp_ChiNhanh").Visible = False

        dgvSanPham.Columns("Sp_Dv_Ma").Visible = False
        ' Set custom header text for columns

        dgvSanPham.Columns("Code").DisplayIndex = 0
        dgvSanPham.Columns("Code").Width = 100

        dgvSanPham.Columns("NCC_Ten").DisplayIndex = 1
        dgvSanPham.Columns("NCC_Ten").Width = 100
        dgvSanPham.Columns("NCC_Ten").HeaderText = "NCC"

        dgvSanPham.Columns("Ten").DisplayIndex = 2
        dgvSanPham.Columns("Ten").HeaderText = "SP"
        dgvSanPham.Columns("Ten").Width = 200

        dgvSanPham.Columns("Gia").Width = 75
        dgvSanPham.Columns("Gia").HeaderText = "Giá"
        dgvSanPham.Columns("Gia").DisplayIndex = 3


        dgvSanPham.Columns("Sp_SoLuong").Width = 50
        dgvSanPham.Columns("Sp_SoLuong").HeaderText = "Kho hàng"

        dgvSanPham.Columns("Sp_DonVi").HeaderText = "Đơn vị"

        dgvSanPham.Columns("Kv_Ten").HeaderText = "Khu Vực"
    End Sub

    Public Sub BindingSanPhamToTextBox(sanPham As SanPham) Implements IChiTietNhapHangView.BindingSanPhamToTextBox
        lbNhaCC.Text = sanPham.NCC_Ten
        lbLoaiSP.Text = sanPham.LoaiSp_Ten
        lbSanPham.Text = sanPham.Ten
        lbDonGia.Text = CurrencyFormat(sanPham.Gia)
        lbDonVi.Text = sanPham.Sp_DonVi.Ten
        tbSoluong.Text = sanPham.Sp_SoLuong

    End Sub

    Private Sub LoadData() Implements IChiTietNhapHangView.LoadData
        chiTietPhieuNhapControllerImpl.XuLyGetAllSanPhamByChiNhanh(tempPhieuNhap.ChiNhanhMa)
    End Sub

    Private Sub RefreshSanPhamGridView(listSp As List(Of SanPham)) Implements IChiTietNhapHangView.RefreshSanPhamGridView
        dgvSanPham.DataSource = Nothing

        BindingSource_SanPham.DataSource = listSp

        dgvSanPham.DataSource = BindingSource_SanPham
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemChiTietNhapHang()
            Case "btnHuy"
                ClearFields()
            Case "btnBora"
                BoChiTietDonHang()
            Case "btnXacNhan"
                XacNhanNhapHang()

        End Select
    End Sub

    Private Sub XacNhanNhapHang()
        Dim listCTPhieuNhap As List(Of ChiTietPhieuNhap) = chiTietPhieuNhapControllerImpl.GetListChiTietPhieuNhap
        If tempPhieuNhap IsNot Nothing Then
            chiTietPhieuNhapControllerImpl.Xuly_XacNhan_NhapHang(tempPhieuNhap)
        End If
    End Sub

    Private Sub BoChiTietDonHang()
        chiTietPhieuNhapControllerImpl.Xuly_Bo_ChiTietNhapHang()
    End Sub

    Private Sub ThemChiTietNhapHang()
        If tbSoluong.Text.Trim.ToString = "" OrElse
            tbKhuyenMai.Text.Trim.ToString = "" Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Số lượng, khuyến mãi không được trống")
            Return
        End If
        Dim selectedSpIndex As Integer = chiTietPhieuNhapControllerImpl.GetSelectedSanPhamIndex
        Dim selectedSanPham As SanPham = chiTietPhieuNhapControllerImpl.GetListSanPham(selectedSpIndex)
        If selectedSanPham IsNot Nothing Then
            Dim newCTPhieuNhap As New ChiTietPhieuNhap() With {
                .PhieuNhapMa = tempPhieuNhap.Ma,
                .MaSanPham = selectedSanPham.Ma,
                .Gia = selectedSanPham.Gia,
                .SoLuong = Integer.Parse(tbSoluong.Text),
                .IsXoa = selectedSanPham.IsXoa,
                .GhiChu = tbGhiChu.Text.Trim.ToString,
                .GetSanPham = selectedSanPham
            }
            Dim tongTien As Double = Double.Parse(newCTPhieuNhap.Gia) * Double.Parse(newCTPhieuNhap.SoLuong)
            Dim khuyenMai As Double = tongTien * Double.Parse(tbKhuyenMai.Text) / 100
            Dim thanhTien = tongTien - khuyenMai
            newCTPhieuNhap.TongTien = tongTien
            newCTPhieuNhap.KhuyenMai = khuyenMai
            newCTPhieuNhap.TongThanhTien = thanhTien
            chiTietPhieuNhapControllerImpl.Xuly_Them_ChiTietNhapHang(newCTPhieuNhap, selectedSanPham)
        End If

    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If e.RowIndex >= 0 Then
            chiTietPhieuNhapControllerImpl.GetSelectedSanPhamIndex = e.RowIndex
            Dim selectedRow = dgvSanPham.Rows(e.RowIndex)
            Dim selectedSanPham = CType(selectedRow.DataBoundItem, SanPham)
            If selectedSanPham IsNot Nothing Then
                BindingSanPhamToTextBox(selectedSanPham)
            End If

        End If
    End Sub

    Private Sub dgvSanPham_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSanPham.CellFormatting

        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "Sp_DonVi" Then
            If e.Value IsNot Nothing Then
                Dim donVi = TryCast(e.Value, DonVi)
                If donVi IsNot Nothing Then
                    e.Value = donVi.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If
        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "Gia" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If

        ''Hightlight ô số lượng khi gần hết hàng (< Constant.SL_TOI_THIEU)
        If e.RowIndex < 0 OrElse e.RowIndex >= dgvSanPham.Rows.Count Then
            Return
        End If

        Dim row As DataGridViewRow = dgvSanPham.Rows(e.RowIndex)

        Dim soluong = row.Cells("Sp_SoLuong").Value

        If soluong < Constant.SL_TOI_THIEU Then
            row.DefaultCellStyle.BackColor = Color.LightCoral
        Else
            row.DefaultCellStyle.BackColor = Color.White
        End If
    End Sub


    Private Sub FormChiTietNhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chiTietPhieuNhapControllerImpl = IChiTietNhapHangControllerImpl.Instance
        chiTietPhieuNhapControllerImpl.Init(Me)

        sanPhamControllerImpl = ISanPhamControllerImpl.Instance
        nhanvienController = INhanVienControllerImpl.Instance

        InitViews()
        LoadData()
    End Sub


    Private Sub dgvCTPhieuNhap_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCTPhieuNhap.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvCTPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "GetSanPham" Then
            If e.Value IsNot Nothing Then
                Dim sanPham = TryCast(e.Value, SanPham)
                If sanPham IsNot Nothing Then
                    e.Value = sanPham.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvCTPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "Gia" OrElse
           dgvCTPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "TongTien" OrElse
           dgvCTPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "KM" OrElse
           dgvCTPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "TongThanhTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If
    End Sub

    Private Sub dgvCTPhieuNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTPhieuNhap.CellClick
        If e.RowIndex < 0 Then
            Return
        Else
            chiTietPhieuNhapControllerImpl.GetSelectedIndex = e.RowIndex
        End If

    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IChiTietNhapHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub BindingListCTPhieuNhapToGridView(list As List(Of ChiTietPhieuNhap)) Implements IChiTietNhapHangView.BindingListCTPhieuNhapToGridView
        RefreshCTPhieuNhapGridView(list)

        ConfigureCTPhieuNhapGridView()
    End Sub

    Private Sub RefreshCTPhieuNhapGridView(list As List(Of ChiTietPhieuNhap))
        dgvCTPhieuNhap.DataSource = Nothing

        BindingSource_CTPhieuNhap.DataSource = list

        dgvCTPhieuNhap.DataSource = BindingSource_CTPhieuNhap
    End Sub

    Private Sub ConfigureCTPhieuNhapGridView()
        dgvCTPhieuNhap.Columns("Ma").Visible = False
        dgvCTPhieuNhap.Columns("PhieuNhapMa").Visible = False
        dgvCTPhieuNhap.Columns("IsXoa").Visible = False
        dgvCTPhieuNhap.Columns("GhiChu").Visible = False
        dgvCTPhieuNhap.Columns("MaSanPham").Visible = False

        dgvCTPhieuNhap.Columns("GetSanPham").DisplayIndex = 0
        dgvCTPhieuNhap.Columns("GetSanPham").Width = 150
        dgvCTPhieuNhap.Columns("GetSanPham").HeaderText = "SP"

        dgvCTPhieuNhap.Columns("Gia").DisplayIndex = 1
        dgvCTPhieuNhap.Columns("Gia").Width = 75
        dgvCTPhieuNhap.Columns("Gia").HeaderText = "Giá"

        dgvCTPhieuNhap.Columns("SoLuong").DisplayIndex = 2
        dgvCTPhieuNhap.Columns("SoLuong").HeaderText = "SL"
        dgvCTPhieuNhap.Columns("SoLuong").Width = 50

        dgvCTPhieuNhap.Columns("TongTien").HeaderText = "Tổng tiền"
        dgvCTPhieuNhap.Columns("TongTien").DisplayIndex = 3

        dgvCTPhieuNhap.Columns("KhuyenMai").Width = 50
        dgvCTPhieuNhap.Columns("KhuyenMai").HeaderText = "KM"
        dgvCTPhieuNhap.Columns("KhuyenMai").DisplayIndex = 4

        dgvCTPhieuNhap.Columns("TongThanhTien").HeaderText = "Thành tiền"

    End Sub

    Public Sub BindingGiaTienToLabel(tongKhuyenMai As Double, tongTien As Double, tongThanhTien As Double) Implements IChiTietNhapHangView.BindingGiaTienToLabel
        lbTongKM.Text = CurrencyFormat(tongKhuyenMai)
        lbTongtien.Text = CurrencyFormat(tongTien)
        lbTongThanhTien.Text = CurrencyFormat(tongThanhTien)
    End Sub

    Private Sub FormChiTietNhapHang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        chiTietPhieuNhapControllerImpl.ResetData()
    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged
        Dim tukhoa = tbTuKhoa.Text.Trim.ToString()
        Dim result As List(Of SanPham) = chiTietPhieuNhapControllerImpl.XulyTimKiemSanPham(tukhoa)
        BindingListSanPhamToGridView(result)
    End Sub
End Class