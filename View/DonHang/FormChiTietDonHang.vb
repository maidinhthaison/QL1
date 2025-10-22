Imports System.ComponentModel
Imports System.Runtime

Public Class FormChiTietDonHang
    Implements IBaseForm, IChiTietDonHangView

    Private tempDonHang As DonHang

    Private donHangControllerImpl As IChiTietDHControllerImpl

    Private khachHangControllerImpl As IKhachHangControllerImpl

    Private sanPhamControllerImpl As ISanPhamControllerImpl
    Public Sub New(donHang As DonHang)
        InitializeComponent()
        Me.tempDonHang = donHang
    End Sub


    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
        AddHandler btnXacNhan.Click, AddressOf OnButtonClick
        AddHandler btnClearDH.Click, AddressOf OnButtonClick
        AddHandler btnTimKH.Click, AddressOf OnButtonClick
        AddHandler btnCapNhatKH.Click, AddressOf OnButtonClick

        'MessageBox.Show($"{tempDonHang.Ngay.ToString(DATETIME_FORMAT)} - {tempDonHang.Ngay}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbNgayThang.Text = tempDonHang.Ngay.ToString(DATETIME_FORMAT)
        lbChiNhanh.Text = tempDonHang.ChiNhanh.Ten
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemSPGioHang()
            Case "btnXoa"
                XoaSPGioHang()
            Case "btnXacNhan"
                XacNhanDonHang()
            Case "btnClearDH"
                ClearFields()
            Case "btnTimKH"
                TimKiemKhachHang()
            Case "btnCapNhatKH"
                CapNhatKH()

        End Select
    End Sub



    Private Sub CapNhatKH()
        If khachHangControllerImpl.ListKh.Count > 0 Then

            Dim selectedKhachHang = khachHangControllerImpl.GetSelectedKH
            ' Cap nhat khach hang vao don hang
            If khachHangControllerImpl.XulySaveKhachHang(selectedKhachHang) Then
                ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "khách hàng"))
            Else
                ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "khách hàng"))
            End If
        Else
            ' Tao moi khach hang
            Dim newKhachHang As New KhachHang() With {
                 .Code = Gen_6Chars_UUID(),
                 .Ten = tbTenKh.Text,
                 .DienThoai = tbDienthoaiKh.Text,
                 .DiaChi = tbDiaChi.Text,
                 .IsXoa = False
             }
            If khachHangControllerImpl.XulySaveKhachHang(newKhachHang) Then
                khachHangControllerImpl.GetSelectedKH = newKhachHang
                khachHangControllerImpl.GetSelectedKH.Ma = newKhachHang.Ma
                ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "khách hàng"))
            Else
                ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "khách hàng"))
            End If

        End If

    End Sub


    Private Sub TimKiemKhachHang()
        Dim tukhoa = tbDienthoaiKh.Text.Trim.ToString()
        If String.IsNullOrWhiteSpace(tukhoa) Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Vui lòng nhập tên khách hàng để tìm kiếm.")
            Return
        End If

        khachHangControllerImpl.XulyTimKiemKhachHangBySDT(tukhoa)

        Dim result = khachHangControllerImpl.ListKh
        If result Is Nothing OrElse result.Count = 0 Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Không tìm thấy khách hàng nào với số điện thoại đã nhập.")
            Return
        End If

        BindingListKhachHangToGridView(result)
    End Sub

    Private Sub XacNhanDonHang()
        Dim listChiTietPbh As List(Of ChiTietDonHang) = donHangControllerImpl.GetDSChiTietPbh
        If listChiTietPbh Is Nothing OrElse listChiTietPbh.Count = 0 Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Chưa có sản phẩm trong đơn hàng")
            Return
        Else

            Dim updatedDonHang As New DonHang() With {
                 .Ma = tempDonHang.Ma,
                 .Code = Gen_12Chars_UUID(),
                 .Ngay = tempDonHang.Ngay,
                 .TongSanPham = 0,
                 .TongKhuyenMai = 0,
                 .TongTien = 0,
                 .GhiChu = tbGhiChu.Text,
                 .IsXoa = False,
                 .BanHangKhachHang = New KhachHang() With {
                      .Ma = tempDonHang.BanHangKhachHang.Ma,
                      .Code = Gen_6Chars_UUID(),
                      .Ten = tbTenKh.Text,
                      .DienThoai = tbDienthoaiKh.Text,
                      .DiaChi = tbDiaChi.Text,
                      .IsXoa = False
                 },
                 .ChiNhanh = New ChiNhanh() With {
                      .Ma = tempDonHang.ChiNhanh.Ma,
                      .Ten = tempDonHang.ChiNhanh.Ten
                 }
            }
            'Dim result As String = updatedDonHang.ToString
            'MessageBox.Show(result, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            donHangControllerImpl.XuLySaveChiTietDonHang(listChiTietPbh, updatedDonHang, khachHangControllerImpl.GetSelectedKH)
        End If
    End Sub

    Private Sub ThemSPGioHang()
        Dim index As Integer = donHangControllerImpl.CurrentSPIndex
        Dim selectedSp As SanPham = donHangControllerImpl.ListSp(index)
        Dim foundProduct As ChiTietDonHang = donHangControllerImpl.GetDSChiTietPbh.FirstOrDefault(Function(p) p.Sp_Ma = selectedSp.Ma)

        If foundProduct IsNot Nothing Then
            'Cập nhật số lượng
            'foundProduct.SoLuong += 1
            foundProduct.SoLuong += Integer.Parse(tbSoluong.Text)
            Dim thanhtien As Double = Double.Parse(foundProduct.Gia) * Double.Parse(foundProduct.SoLuong)
            Dim khuyenmai As Double = thanhtien * Double.Parse(tbKhuyenMai.Text) / 100
            foundProduct.ThanhTien = thanhtien - khuyenmai
            foundProduct.KhuyenMai = khuyenmai
            TinhTongTien()
            RefreshDonHangGridView(donHangControllerImpl.GetDSChiTietPbh)
            ConfigureDonHangGridView()
        Else
            'Thêm mới
            Dim pbhCode As String = Gen_12Chars_UUID()
            Dim thanhtien As Double = Double.Parse(selectedSp.Gia) * Integer.Parse(tbSoluong.Text)
            Dim khuyenmai As Double = thanhtien * Double.Parse(tbKhuyenMai.Text) / 100

            Dim newChiTietDonHang As New ChiTietDonHang() With {
                 .Sp_Ma = selectedSp.Ma,
                 .SoLuong = Integer.Parse(tbSoluong.Text),
                 .Gia = selectedSp.Gia,
                 .ThanhTien = thanhtien - khuyenmai,
                 .KhuyenMai = khuyenmai,
                 .IsXoa = False,
                 .SanPhamInfo = selectedSp
             }

            donHangControllerImpl.GetDSChiTietPbh.Add(newChiTietDonHang)

            TinhTongTien()

            RefreshDonHangGridView(donHangControllerImpl.GetDSChiTietPbh)

            ConfigureDonHangGridView()
        End If

    End Sub

    Private Sub XoaSPGioHang()

    End Sub
    Private Sub TinhTongTien()
        Dim listChiTietPbh As List(Of ChiTietDonHang) = donHangControllerImpl.GetDSChiTietPbh
        If listChiTietPbh IsNot Nothing AndAlso listChiTietPbh.Count > 0 Then
            Dim tongTien As Double = listChiTietPbh.Sum(Function(ct) ct.ThanhTien)
            Dim tongKhuyenMai As Double = listChiTietPbh.Sum(Function(ct) ct.KhuyenMai)
            Dim tongSoLuong As Integer = listChiTietPbh.Sum(Function(ct) ct.SoLuong)
            lbTongtien.Text = CurrencyFormat(tongTien)
        Else
            lbTongtien.Text = "0"
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
        'donHangControllerImpl.XuLyGetAllSanPham()
        donHangControllerImpl.XuLyGetAllSanPhamByChiNhanh(tempDonHang.ChiNhanh.Ma)
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
        dgvSanPham.Columns("LoaiSp_ChiNhanh").Visible = False

        dgvSanPham.Columns("Sp_Dv_Ma").Visible = False
        ' Set custom header text for columns

        dgvSanPham.Columns("Code").DisplayIndex = 0
        dgvSanPham.Columns("Code").Width = 75

        dgvSanPham.Columns("NCC_Ten").DisplayIndex = 1
        dgvSanPham.Columns("NCC_Ten").Width = 50
        dgvSanPham.Columns("NCC_Ten").HeaderText = "NCC"

        dgvSanPham.Columns("Ten").DisplayIndex = 2
        dgvSanPham.Columns("Ten").HeaderText = "SP"

        dgvSanPham.Columns("Gia").DisplayIndex = 3
        dgvSanPham.Columns("Gia").Width = 50
        dgvSanPham.Columns("Gia").HeaderText = "Giá"

        dgvSanPham.Columns("Sp_DonVi").DisplayIndex = 4
        dgvSanPham.Columns("Sp_DonVi").Width = 50
        dgvSanPham.Columns("Sp_DonVi").HeaderText = "Đơn vị"

        dgvSanPham.Columns("Sp_SoLuong").DisplayIndex = 5
        dgvSanPham.Columns("Sp_SoLuong").Width = 50
        dgvSanPham.Columns("Sp_SoLuong").HeaderText = "Kho hàng"

        dgvSanPham.Columns("Kv_Ten").DisplayIndex = 6
        dgvSanPham.Columns("Kv_Ten").Width = 75
        dgvSanPham.Columns("Kv_Ten").HeaderText = "Khu Vực"



    End Sub

    Public Sub ClearFields() Implements IChiTietDonHangView.ClearFields
        tbSoluong.Text = ""
        tbKhuyenMai.Text = ""
        tbGhiChu.Text = ""
    End Sub

    Private Sub FormTaoDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        donHangControllerImpl = IChiTietDHControllerImpl.Instance
        donHangControllerImpl.Init(Me)

        khachHangControllerImpl = IKhachHangControllerImpl.Instance
        sanPhamControllerImpl = ISanPhamControllerImpl.Instance

        InitViews()
        LoadData()
    End Sub

    Public Sub SetController(Controller As IChiTietDHControllerImpl) Implements IChiTietDonHangView.SetController
        donHangControllerImpl = Controller
    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If e.RowIndex >= 0 Then
            donHangControllerImpl.CurrentSPIndex = e.RowIndex
        End If
    End Sub

    Private Sub BindingToTextBoxKhachHang(selectedKH As Object)
        tbTenKh.Text = CType(selectedKH, KhachHang).Ten
        tbDienthoaiKh.Text = CType(selectedKH, KhachHang).DienThoai
        tbDiaChi.Text = CType(selectedKH, KhachHang).DiaChi
    End Sub

    Private Sub dgvDonHang_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDonHang.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "SanPhamInfo" Then
            If e.Value IsNot Nothing Then
                Dim product = TryCast(e.Value, SanPham)
                If product IsNot Nothing Then
                    e.Value = product.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

    End Sub

    Private Sub FormChiTietDonHang_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        tempDonHang = Nothing
    End Sub

    Private Sub FormChiTietDonHang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        tempDonHang = Nothing
    End Sub

    Public Sub BindingListKhachHangToGridView(list As List(Of KhachHang)) Implements IChiTietDonHangView.BindingListKhachHangToGridView
        dgvKhachHang.DataSource = Nothing

        Bs_KhachHang.DataSource = list

        dgvKhachHang.DataSource = Bs_KhachHang

        ConfigureListBox()
    End Sub

    Private Sub ConfigureListBox()
        dgvKhachHang.Columns("Ma").Visible = False
        dgvKhachHang.Columns("Code").Visible = False
        dgvKhachHang.Columns("DiaChi").Visible = False
        dgvKhachHang.Columns("IsXoa").Visible = False
        dgvKhachHang.Columns("DienThoai").Visible = False

        dgvKhachHang.Columns("Ten").HeaderText = "Khách Hàng"
    End Sub

    Private Sub dgvKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellClick
        If e.RowIndex >= 0 Then
            khachHangControllerImpl.GetSelectedKH = khachHangControllerImpl.ListKh(e.RowIndex)
            Dim selectedRow As DataGridViewRow = dgvKhachHang.Rows(e.RowIndex)
            Dim selectedKh As KhachHang = CType(selectedRow.DataBoundItem, KhachHang)
            If selectedKh IsNot Nothing Then
                BindingToTextBoxKhachHang(selectedKh)
            End If
        End If
    End Sub

    Private Sub dgvDonHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDonHang.CellClick
        If e.RowIndex >= 0 Then
            donHangControllerImpl.CurrentSPIndex = e.RowIndex
        End If
    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged
        Dim tukhoa = tbTuKhoa.Text.Trim.ToString()
        Dim result As List(Of SanPham) = sanPhamControllerImpl.XulyTimKiemSanPham(tukhoa)
        BindingListSanPhamToGridView(result)
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
        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "Gia" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "Gia" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If

    End Sub
End Class