Imports System.ComponentModel
Imports System.Runtime

Public Class FormChiTietDonHang
    Implements IBaseForm, IChiTietDonHangView

    Private tempDonHang As DonHang

    Private chiTietDonHangControllerImpl As IChiTietDHControllerImpl

    Private khachHangControllerImpl As IKhachHangControllerImpl

    Private sanPhamControllerImpl As ISanPhamControllerImpl

    Private nhanvienController As INhanVienControllerImpl
    Public Sub New(donHang As DonHang)
        InitializeComponent()
        Me.tempDonHang = donHang
    End Sub


    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
        AddHandler btnXacNhan.Click, AddressOf OnButtonClick
        AddHandler btnTimKH.Click, AddressOf OnButtonClick
        AddHandler btnCapNhatKH.Click, AddressOf OnButtonClick
        AddHandler btnXuatHoaDon.Click, AddressOf OnButtonClick

        'MessageBox.Show($"{tempDonHang.Ngay.ToString(DATETIME_FORMAT)} - {tempDonHang.Ngay}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbNgayThang.Text = tempDonHang.Ngay.ToString(Constant.DATETIME_FORMAT)
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
            Case "btnTimKH"
                TimKiemKhachHang()
            Case "btnCapNhatKH"
                CapNhatKH()
            Case "btnXuatHoaDon"
                XuatHoaDon()

        End Select
    End Sub

    Private Sub XuatHoaDon()
        If chiTietDonHangControllerImpl.GetDSChiTietPbh Is Nothing OrElse chiTietDonHangControllerImpl.GetDSChiTietPbh.Count = 0 Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Chưa có sản phẩm trong đơn hàng")
            Return
        End If
        If tempDonHang Is Nothing Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Chưa có đơn hàng")
            Return
        End If
        If khachHangControllerImpl.GetSelectedKH Is Nothing Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Chưa có khách hàng")
            Return
        End If
        Dim pdfPath As String = chiTietDonHangControllerImpl.XuLyXuatHoaDon(chiTietDonHangControllerImpl.GetDSChiTietPbh, tempDonHang, khachHangControllerImpl.GetSelectedKH)
        If pdfPath IsNot Nothing Then
            ShowConfirmMessageBox("Xuất hóa đơn", "Xuất hóa đơn thành công. Bạn có muốn in hóa đơn không?", "InHoaDon")
        Else
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Xuất hóa đơn thất bại.")
        End If
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
            ' Nếu khách hàng không tồn tại thì tạo mới khach hang
            Dim newKhachHang As New KhachHang() With {
                 .Code = Gen_6Chars_UUID(),
                 .Ten = tbTenKh.Text,
                 .DienThoai = tbDienthoaiKh.Text,
                 .DiaChi = tbDiaChiKh.Text,
                 .IsXoa = False
             }
            If khachHangControllerImpl.XulySaveKhachHang(newKhachHang) Then
                khachHangControllerImpl.GetSelectedKH = newKhachHang
                khachHangControllerImpl.GetSelectedKH.Ma = newKhachHang.Ma
                ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "khách hàng"))
            Else
                ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "khách hàng"))
            End If

        End If

    End Sub


    Private Sub TimKiemKhachHang()
        Dim tukhoa = tbDienthoaiKh.Text.Trim.ToString()
        If String.IsNullOrWhiteSpace(tukhoa) Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Vui lòng nhập số điện thoại để tìm kiếm.")
            Return
        End If

        khachHangControllerImpl.XulyTimKiemKhachHangBySDT(tukhoa)

        Dim result = khachHangControllerImpl.ListKh
        If result Is Nothing OrElse result.Count = 0 Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Không có khách hàng trong hệ thống")
            Return
        End If

        If result IsNot Nothing Then
            BindingListKhachHangToGridView(result)
            If result.Count > 0 Then
                BindingKhachHangToTextBox(result(0))
            End If

        End If

        BindingListKhachHangToGridView(result)

    End Sub

    Private Sub XacNhanDonHang()
        Dim listChiTietPbh As List(Of ChiTietDonHang) = chiTietDonHangControllerImpl.GetDSChiTietPbh
        If listChiTietPbh Is Nothing OrElse listChiTietPbh.Count = 0 Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Chưa có sản phẩm trong đơn hàng")
            Return
        Else
            'MessageBox.Show($"{tempDonHang.Ngay}", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim khachHang As KhachHang = khachHangControllerImpl.GetSelectedKH
            Dim nhanVien As NhanVien = nhanvienController.UserSession
            Dim updatedDonHang As New DonHang() With {
                 .Ma = tempDonHang.Ma,
                 .Code = tempDonHang.Code,
                 .Ngay = tempDonHang.Ngay,
                 .TongSanPham = 0,
                 .TongKhuyenMai = 0,
                 .TongTien = 0,
                 .ThanhTien = 0,
                 .GhiChu = tbGhiChu.Text,
                 .IsXoa = False,
                 .NhanVienMa = tempDonHang.NhanVienMa,
                 .KhachHangMa = khachHang.Ma,
                 .ChiNhanhMa = tempDonHang.ChiNhanhMa,
                 .BanHangKhachHang = New KhachHang() With {
                      .Ma = tempDonHang.BanHangKhachHang.Ma,
                      .Code = Gen_6Chars_UUID(),
                      .Ten = tbTenKh.Text,
                      .DienThoai = tbDienthoaiKh.Text,
                      .DiaChi = tbDiaChiKh.Text,
                      .IsXoa = False
                 },
                 .ChiNhanh = New ChiNhanh() With {
                      .Ma = tempDonHang.ChiNhanh.Ma,
                      .Ten = tempDonHang.ChiNhanh.Ten,
                      .DiaChi = tempDonHang.ChiNhanh.DiaChi
                 },
                 .DonHang_NhanVien = New NhanVien() With {
                      .Ma = nhanVien.Ma,
                      .Ten = nhanVien.Ten,
                      .DienThoai = nhanVien.DienThoai,
                      .DiaChi = nhanVien.DiaChi
                 },
                 .ListChiTietDonhang = listChiTietPbh
            }

            chiTietDonHangControllerImpl.XuLySaveChiTietDonHang(listChiTietPbh, updatedDonHang, khachHang)
        End If
    End Sub

    Private Sub ThemSPGioHang()
        Dim index As Integer = chiTietDonHangControllerImpl.CurrentSPIndex
        Dim selectedSp As SanPham = chiTietDonHangControllerImpl.ListSp(index)
        If selectedSp.Sp_SoLuong = 0 OrElse Integer.Parse(selectedSp.Sp_SoLuong) < Integer.Parse(tbSoluong.Text) Then
            ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, "Không đủ hàng")
            Return
        Else
            Dim foundProduct As ChiTietDonHang = chiTietDonHangControllerImpl.GetDSChiTietPbh.FirstOrDefault(Function(p) p.Sp_Ma = selectedSp.Ma)

            If foundProduct IsNot Nothing Then
                'Cập nhật số lượng
                foundProduct.SoLuong += Integer.Parse(tbSoluong.Text)
                Dim tongtien As Double = Double.Parse(selectedSp.Gia) * Double.Parse(foundProduct.SoLuong)
                Dim khuyenmai As Double = tongtien * Double.Parse(tbKhuyenMai.Text) / 100
                foundProduct.TongTien = tongtien
                foundProduct.ThanhTien = tongtien - khuyenmai
                foundProduct.KhuyenMai = khuyenmai
                TinhTongTien()

                RefreshDonHangGridView(chiTietDonHangControllerImpl.GetDSChiTietPbh)
                ConfigureDonHangGridView()

                'Cập nhật kho
                selectedSp.Sp_SoLuong -= Integer.Parse(tbSoluong.Text)
                RefreshSanPhamGridView(chiTietDonHangControllerImpl.ListSp)
                ConfigureGridView()

            Else
                'Thêm mới
                Dim pbhCode As String = Gen_12Chars_UUID()
                Dim tongTien As Double = Double.Parse(selectedSp.Gia) * Integer.Parse(tbSoluong.Text)
                Dim khuyenmai As Double = tongTien * Double.Parse(tbKhuyenMai.Text) / 100
                Dim thanhtien As Double = tongTien - khuyenmai

                Dim newChiTietDonHang As New ChiTietDonHang() With {
                     .Sp_Ma = selectedSp.Ma,
                     .SoLuong = Integer.Parse(tbSoluong.Text),
                     .Gia = selectedSp.Gia,
                     .TongTien = tongTien,
                     .ThanhTien = tongTien - khuyenmai,
                     .KhuyenMai = khuyenmai,
                     .IsXoa = False,
                     .SanPhamInfo = selectedSp
                 }

                chiTietDonHangControllerImpl.GetDSChiTietPbh.Add(newChiTietDonHang)

                TinhTongTien()

                RefreshDonHangGridView(chiTietDonHangControllerImpl.GetDSChiTietPbh)
                ConfigureDonHangGridView()

                'Cập nhật kho
                selectedSp.Sp_SoLuong -= Integer.Parse(tbSoluong.Text)
                RefreshSanPhamGridView(chiTietDonHangControllerImpl.ListSp)
                ConfigureGridView()
            End If
        End If


    End Sub

    Private Sub XoaSPGioHang()
        Dim dsCTDonHang As List(Of ChiTietDonHang) = chiTietDonHangControllerImpl.GetDSChiTietPbh
        If dsCTDonHang.Count = 0 Then
            Return
        End If
        Dim selectedCTDonHangIndex As Integer = chiTietDonHangControllerImpl.CurrentDonHangIndex
        Dim selectedCTDonHang As ChiTietDonHang = dsCTDonHang(selectedCTDonHangIndex)
        Dim foundCTDH As ChiTietDonHang = chiTietDonHangControllerImpl.GetDSChiTietPbh.FirstOrDefault(Function(p) p.Sp_Ma = selectedCTDonHang.SanPhamInfo.Ma)
        If selectedCTDonHang.SoLuong <= Integer.Parse(tbSoluong.Text) Then
            ' Xóa đơn hàng ra khỏi danh sách
            dsCTDonHang.RemoveAt(selectedCTDonHangIndex)
            RefreshDonHangGridView(chiTietDonHangControllerImpl.GetDSChiTietPbh)
            ConfigureDonHangGridView()

            ' Cập nhật lại kho hàng
            foundCTDH.SanPhamInfo.Sp_SoLuong += foundCTDH.SoLuong
            RefreshSanPhamGridView(chiTietDonHangControllerImpl.ListSp)
            ConfigureGridView()
        Else
            If foundCTDH IsNot Nothing Then
                'Cập nhật số lượng
                foundCTDH.SoLuong -= Integer.Parse(tbSoluong.Text)
                Dim tongtien As Double = Double.Parse(selectedCTDonHang.Gia) * Double.Parse(foundCTDH.SoLuong)
                Dim khuyenmai As Double = tongtien * Double.Parse(tbKhuyenMai.Text) / 100
                foundCTDH.TongTien = tongtien
                foundCTDH.ThanhTien = tongtien - khuyenmai
                foundCTDH.KhuyenMai = khuyenmai
                TinhTongTien()

                RefreshDonHangGridView(chiTietDonHangControllerImpl.GetDSChiTietPbh)
                ConfigureDonHangGridView()

                ' Cập nhật kho
                foundCTDH.SanPhamInfo.Sp_SoLuong += Integer.Parse(tbSoluong.Text)
                RefreshSanPhamGridView(chiTietDonHangControllerImpl.ListSp)
                ConfigureGridView()
            End If
        End If

    End Sub

    Private Sub CapNhatKho()
        Dim listChiTietPbh As List(Of ChiTietDonHang) = chiTietDonHangControllerImpl.GetDSChiTietPbh
        If listChiTietPbh IsNot Nothing AndAlso listChiTietPbh.Count > 0 Then
            Dim tongTien As Double = listChiTietPbh.Sum(Function(ct) ct.TongTien)
            Dim thanhTien As Double = listChiTietPbh.Sum(Function(ct) ct.ThanhTien)
            Dim tongKhuyenMai As Double = listChiTietPbh.Sum(Function(ct) ct.KhuyenMai)
            Dim tongSoLuong As Integer = listChiTietPbh.Sum(Function(ct) ct.SoLuong)
            lbTongtien.Text = CurrencyFormat(thanhTien)
        Else
            lbTongtien.Text = "0"
        End If
    End Sub
    Private Sub TinhTongTien()
        Dim listChiTietPbh As List(Of ChiTietDonHang) = chiTietDonHangControllerImpl.GetDSChiTietPbh
        If listChiTietPbh IsNot Nothing AndAlso listChiTietPbh.Count > 0 Then
            Dim tongTien As Double = listChiTietPbh.Sum(Function(ct) ct.TongTien)
            Dim thanhTien As Double = listChiTietPbh.Sum(Function(ct) ct.ThanhTien)
            Dim tongKhuyenMai As Double = listChiTietPbh.Sum(Function(ct) ct.KhuyenMai)
            Dim tongSoLuong As Integer = listChiTietPbh.Sum(Function(ct) ct.SoLuong)
            lbTongtien.Text = CurrencyFormat(thanhTien)
        Else
            lbTongtien.Text = "0"
        End If
    End Sub

    Private Sub RefreshDonHangGridView(list As List(Of ChiTietDonHang))
        dgvDonHang.DataSource = Nothing
        CTDH_BindingSource.DataSource = list
        dgvDonHang.DataSource = CTDH_BindingSource

    End Sub

    Private Sub RefreshSanPhamGridView(list As List(Of SanPham))
        dgvSanPham.DataSource = Nothing

        SP_BindingSource.DataSource = list

        dgvSanPham.DataSource = SP_BindingSource

    End Sub

    Private Sub ConfigureDonHangGridView()
        dgvDonHang.Columns("Ma").Visible = False
        dgvDonHang.Columns("Pbh_Ma").Visible = False
        dgvDonHang.Columns("Sp_Ma").Visible = False
        dgvDonHang.Columns("IsXoa").Visible = False

        ' Set custom header text for columns

        dgvDonHang.Columns("SanPhamInfo").HeaderText = "SP"
        dgvDonHang.Columns("SanPhamInfo").DisplayIndex = 0


        dgvDonHang.Columns("SoLuong").HeaderText = "SL"
        dgvDonHang.Columns("SoLuong").DisplayIndex = 1
        dgvDonHang.Columns("SoLuong").Width = 50

        dgvDonHang.Columns("Gia").HeaderText = "Đơn Giá Bán"
        dgvDonHang.Columns("Gia").DisplayIndex = 2

        dgvDonHang.Columns("KhuyenMai").HeaderText = "KM"
        dgvDonHang.Columns("KhuyenMai").DisplayIndex = 3
        dgvDonHang.Columns("KhuyenMai").Width = 100

        dgvDonHang.Columns("TongTien").HeaderText = "Tổng Tiền"
        dgvDonHang.Columns("TongTien").DisplayIndex = 4

        dgvDonHang.Columns("ThanhTien").HeaderText = "Thành Tiền"
        dgvDonHang.Columns("ThanhTien").DisplayIndex = 5


    End Sub

    Public Sub LoadData() Implements IChiTietDonHangView.LoadData
        chiTietDonHangControllerImpl.XuLyGetAllSanPhamByChiNhanh(tempDonHang.ChiNhanh.Ma)
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IChiTietDonHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub


    Public Sub BindingListSanPhamToGridView(list As List(Of SanPham)) Implements IChiTietDonHangView.BindingListSanPhamToGridView
        RefreshSanPhamGridView(list)

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
        dgvSanPham.Columns("Code").Width = 100

        dgvSanPham.Columns("NCC_Ten").DisplayIndex = 1
        dgvSanPham.Columns("NCC_Ten").Width = 100
        dgvSanPham.Columns("NCC_Ten").HeaderText = "NCC"

        dgvSanPham.Columns("Ten").DisplayIndex = 2
        dgvSanPham.Columns("Ten").HeaderText = "SP"
        dgvSanPham.Columns("Ten").Width = 200

        dgvSanPham.Columns("Gia").Width = 75
        dgvSanPham.Columns("Gia").HeaderText = "Đơn Giá bán"
        dgvSanPham.Columns("Gia").DisplayIndex = 3

        dgvSanPham.Columns("GiaNhap").HeaderText = "Đơn Giá nhập"

        dgvSanPham.Columns("Sp_SoLuong").Width = 50
        dgvSanPham.Columns("Sp_SoLuong").HeaderText = "Kho hàng"

        dgvSanPham.Columns("Sp_DonVi").HeaderText = "Đơn vị"

        dgvSanPham.Columns("Kv_Ten").HeaderText = "Khu Vực"


    End Sub

    Private Sub FormTaoDonHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        chiTietDonHangControllerImpl = IChiTietDHControllerImpl.Instance
        chiTietDonHangControllerImpl.Init(Me)

        khachHangControllerImpl = IKhachHangControllerImpl.Instance
        sanPhamControllerImpl = ISanPhamControllerImpl.Instance
        nhanvienController = INhanVienControllerImpl.Instance

        System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)

        InitViews()
        LoadData()
    End Sub

    Public Sub SetController(Controller As IChiTietDHControllerImpl) Implements IChiTietDonHangView.SetController
        chiTietDonHangControllerImpl = Controller
    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick
        If e.RowIndex >= 0 Then
            chiTietDonHangControllerImpl.CurrentSPIndex = e.RowIndex
        End If
    End Sub

    Private Sub BindingToTextBoxKhachHang(selectedKH As Object)
        tbTenKh.Text = CType(selectedKH, KhachHang).Ten
        tbDienthoaiKh.Text = CType(selectedKH, KhachHang).DienThoai
        tbDiaChiKh.Text = CType(selectedKH, KhachHang).DiaChi
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

        If e.RowIndex >= 0 AndAlso dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "Gia" OrElse
           dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "GiaNhap" OrElse
           dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "KhuyenMai" OrElse
           dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "TongTien" OrElse
           dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "ThanhTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If
    End Sub

    Private Sub FormChiTietDonHang_Deactivate(sender As Object, e As EventArgs) Handles MyBase.Deactivate
        tempDonHang = Nothing
    End Sub

    Private Sub FormChiTietDonHang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        tempDonHang = Nothing
        chiTietDonHangControllerImpl.CurrentSPIndex = -1
        chiTietDonHangControllerImpl.CurrentDonHangIndex = -1
        chiTietDonHangControllerImpl.GetDSChiTietPbh.Clear()
        chiTietDonHangControllerImpl.GetDSChiTietPbh = Nothing
        chiTietDonHangControllerImpl.ListSp.Clear()
        chiTietDonHangControllerImpl.ListSp = Nothing
        chiTietDonHangControllerImpl.GetHoaDonFilePath = Nothing
        khachHangControllerImpl.GetSelectedKH = Nothing
    End Sub

    Public Sub BindingListKhachHangToGridView(list As List(Of KhachHang)) Implements IChiTietDonHangView.BindingListKhachHangToGridView
        dgvKhachHang.DataSource = Nothing

        Bs_KhachHang.DataSource = list

        dgvKhachHang.DataSource = Bs_KhachHang

        ConfigureKhachHangDataGridView()
    End Sub

    Private Sub ConfigureKhachHangDataGridView()
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
            chiTietDonHangControllerImpl.CurrentDonHangIndex = e.RowIndex
        End If
    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged
        Dim tukhoa = tbTuKhoa.Text.Trim.ToString()
        Dim result As List(Of SanPham) = chiTietDonHangControllerImpl.XulyTimKiemSanPham(tukhoa)
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
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "GiaNhap" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If

    End Sub

    Public Sub BindingKhachHangToTextBox(khachHang As KhachHang) Implements IChiTietDonHangView.BindingKhachHangToTextBox
        tbTenKh.Text = khachHang.Ten
        tbDiaChiKh.Text = khachHang.DiaChi
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements IChiTietDonHangView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "InHoaDon"
                    InHoaDon(chiTietDonHangControllerImpl.GetHoaDonFilePath)
            End Select

        End If
    End Sub

    Private Sub InHoaDon(pdfFilePath As String)
        chiTietDonHangControllerImpl.InHoaDon(pdfFilePath)
    End Sub
End Class