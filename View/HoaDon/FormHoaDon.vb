Imports System.Globalization

Public Class FormHoaDon
    Implements IBaseForm, IHoaDonView

    Private hoaDonController As IHoaDonControllerImpl

    Private nhanVienController As INhanVienControllerImpl

    Private userSession As NhanVien

    Public Sub LoadData() Implements IHoaDonView.LoadData
        lbChiNhanh.Text = $"Chi nhánh: {userSession.ChiNhanh.Ten}"
        'Load hóa đơn hôm nay
        Dim formatDate As String = Date.Today.ToString(Constant.DATETIME_FORMAT)
        Dim parsedDate As Date
        If DateTime.TryParseExact(formatDate, Constant.DATETIME_FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, parsedDate) Then
            MessageBox.Show($"{userSession.ChiNhanh.Ma} - {parsedDate}")
            hoaDonController.XuLy_GetDanhSachHoaDon_By_NgayThangh_ChiNhanh(userSession.ChiNhanh.Ma, parsedDate)
        End If

    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnTimKiem.Click, AddressOf OnButtonClick
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnTimKiem"
                TimKiemDonHang()
        End Select
    End Sub

    Private Sub TimKiemDonHang()

        hoaDonController.XuLy_GetDanhSachHoaDon_By_NgayThangh_ChiNhanh(userSession.ChiNhanh.Ma, dtPicker.Value)
    End Sub

    Public Sub ResetModel() Implements IHoaDonView.ResetModel
        hoaDonController.GetDanhSachHoaDon.Clear()
        hoaDonController.GetDanhSachHoaDon = Nothing
        hoaDonController.GetSelectedDonHangIndex = -1
        hoaDonController = Nothing
        nhanVienController.UserSession = Nothing
        nhanVienController = Nothing
    End Sub

    Public Sub BindingListHoaDonToGridView(list As List(Of DonHang)) Implements IHoaDonView.BindingListHoaDonToGridView
        RefreshHoaDonGridView(list)
        ConfigureHoaDonGridView()
    End Sub

    Private Sub FormHoaDon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hoaDonController = IHoaDonControllerImpl.Instance
        hoaDonController.Init(Me)
        nhanVienController = INhanVienControllerImpl.Instance
        userSession = nhanVienController.UserSession
        InitViews()
        LoadData()
    End Sub

    Private Sub FormHoaDon_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        ResetModel()
    End Sub

    Private Sub dgvHoaDon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHoaDon.CellClick
        If e.RowIndex >= 0 Then
            hoaDonController.GetSelectedDonHangIndex = e.RowIndex
            Dim selectedRow = dgvHoaDon.Rows(e.RowIndex)
            Dim selectedDonHang = CType(selectedRow.DataBoundItem, DonHang)
            If selectedDonHang IsNot Nothing Then
                BindingHoaDonToLabel(selectedDonHang)
                BindingChitietDonHangToListView(selectedDonHang.ListChiTietDonhang)
            End If

        End If
    End Sub

    Private Sub dgvHoaDon_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvHoaDon.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvHoaDon.Columns(e.ColumnIndex).DataPropertyName = "BanHangKhachHang" Then
            If e.Value IsNot Nothing Then
                Dim khachHang = TryCast(e.Value, KhachHang)
                If khachHang IsNot Nothing Then
                    e.Value = khachHang.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If
        If e.RowIndex >= 0 AndAlso dgvHoaDon.Columns(e.ColumnIndex).DataPropertyName = "DonHang_NhanVien" Then
            If e.Value IsNot Nothing Then
                Dim nhanVien = TryCast(e.Value, NhanVien)
                If nhanVien IsNot Nothing Then
                    e.Value = nhanVien.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso
           dgvHoaDon.Columns(e.ColumnIndex).DataPropertyName = "TongKhuyenMai" OrElse
           dgvHoaDon.Columns(e.ColumnIndex).DataPropertyName = "TongTien" OrElse
           dgvHoaDon.Columns(e.ColumnIndex).DataPropertyName = "ThanhTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If
    End Sub

    Public Sub ConfigureHoaDonGridView() Implements IHoaDonView.ConfigureHoaDonGridView
        dgvHoaDon.Columns("Ma").Visible = False
        dgvHoaDon.Columns("GhiChu").Visible = False
        dgvHoaDon.Columns("IsXoa").Visible = False
        dgvHoaDon.Columns("ChiNhanh").Visible = False
        dgvHoaDon.Columns("ChiNhanhMa").Visible = False
        dgvHoaDon.Columns("NhanVienMa").Visible = False
        dgvHoaDon.Columns("KhachHangMa").Visible = False
        dgvHoaDon.Columns("Code").Visible = False
        dgvHoaDon.Columns("Ngay").Visible = False

        dgvHoaDon.Columns("BanHangKhachHang").HeaderText = "Khách hàng"
        dgvHoaDon.Columns("BanHangKhachHang").DisplayIndex = 0

        dgvHoaDon.Columns("DonHang_NhanVien").HeaderText = "Người lập"
        dgvHoaDon.Columns("DonHang_NhanVien").DisplayIndex = 1

        dgvHoaDon.Columns("TongSanPham").HeaderText = "Tổng SP"
        dgvHoaDon.Columns("TongSanPham").DisplayIndex = 2
        dgvHoaDon.Columns("TongSanPham").Width = 50

        dgvHoaDon.Columns("TongTien").HeaderText = "Tổng tiền"
        dgvHoaDon.Columns("TongTien").DisplayIndex = 3

        dgvHoaDon.Columns("TongKhuyenMai").HeaderText = "Tổng KM"
        dgvHoaDon.Columns("TongKhuyenMai").DisplayIndex = 4

        dgvHoaDon.Columns("ThanhTien").HeaderText = "Thành tiền"
        dgvHoaDon.Columns("ThanhTien").DisplayIndex = 5

    End Sub

    Public Sub RefreshHoaDonGridView(list As List(Of DonHang)) Implements IHoaDonView.RefreshHoaDonGridView
        dgvHoaDon.DataSource = Nothing

        BindingSource_donhang.DataSource = list

        dgvHoaDon.DataSource = BindingSource_donhang
    End Sub

    Public Sub BindingHoaDonToLabel(donhang As DonHang) Implements IHoaDonView.BindingHoaDonToLabel
        lbNgayXuatHoaDon.Text = $"Ngày xuất hóa đơn: {donhang.Ngay.ToString(Constant.DATETIME_FORMAT)}"
        lbNguoiXuatHoaDon.Text = $"Người lập hóa đơn: {donhang.DonHang_NhanVien.Ten}"
        lbKhachHang.Text = $"Khách hàng: {donhang.BanHangKhachHang.Ten}"
        lbDienThoai.Text = $"Điện thoại: {donhang.BanHangKhachHang.DienThoai}"
        lbTongHoaDon.Text = $"Tổng hóa đơn: {CurrencyFormat(donhang.ThanhTien)}"
    End Sub

    Public Sub BindingChitietDonHangToListView(listChiTietDonhang As List(Of ChiTietDonHang)) Implements IHoaDonView.BindingChitietDonHangToListView
        lvSanPham.Items.Clear()

        For Each chitietdonhang As ChiTietDonHang In listChiTietDonhang

            Dim item As New ListViewItem(chitietdonhang.SanPhamInfo.Ten)

            item.SubItems.Add(chitietdonhang.SoLuong)
            item.SubItems.Add(CurrencyFormat(chitietdonhang.Gia))
            item.SubItems.Add(CurrencyFormat(chitietdonhang.TongTien))
            item.SubItems.Add(CurrencyFormat(chitietdonhang.KhuyenMai))
            item.SubItems.Add(CurrencyFormat(chitietdonhang.ThanhTien))

            item.Tag = chitietdonhang

            lvSanPham.Items.Add(item)
        Next
    End Sub

End Class