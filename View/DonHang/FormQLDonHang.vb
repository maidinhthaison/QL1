Imports System.Runtime.Serialization

Public Class FormQLDonHang
    Implements IBaseForm, IDonHangView

    Private donHangController As IDonHangControllerImpl

    Private nhanvienController As INhanVienControllerImpl

    Dim userSession As NhanVien

    Private listForms As List(Of Form)

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnTaoDon.Click, AddressOf OnButtonClick

        'Set up DateTimePicker
        dtPicker.Format = DateTimePickerFormat.Custom
        dtPicker.CustomFormat = Constant.DATETIME_FORMAT
        dtPicker.Value = DateTime.Now

        listForms = New List(Of Form)

        ' Set default ghi chú
        tbGhiChu.Text = $"Đơn hàng {DateTime.Now.ToString(Constant.CURRENT_DATETIME_FORMAT)}"
    End Sub

    Public Sub LoadData() Implements IDonHangView.LoadData
        userSession = nhanvienController.UserSession
        lbChiNhanh.Text = userSession.ChiNhanh.Ten

        donHangController.Xuly_GetAll_DonHang_With_KH_NhanVien_ChiNhanh_By_ChiNhanh(userSession.ChiNhanh.Ma)

    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IDonHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements IDonHangView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"

            End Select

        End If
    End Sub

    Public Sub BindingListDonHangToGridView(list As List(Of DonHang)) Implements IDonHangView.BindingListDonHangToGridView
        dgvDonHang.DataSource = Nothing

        bsPhieuBanHang.DataSource = list

        dgvDonHang.DataSource = bsPhieuBanHang

        ConfigureGridView()


    End Sub

    Public Sub BindingTolabelTextBox(list As List(Of DonHang)) Implements IDonHangView.BindingTolabelTextBox
        Dim phieuBh As DonHang = list(0)
        lbTenKh.Text = phieuBh.BanHangKhachHang.Ten
        lbDienThoai.Text = phieuBh.BanHangKhachHang.DienThoai
        lbDiaChi.Text = phieuBh.BanHangKhachHang.DiaChi
        tbGhiChu.Text = phieuBh.GhiChu
        lbTongTien.Text = CurrencyFormat(phieuBh.TongTien)
        lbKhuyenMai.Text = CurrencyFormat(phieuBh.TongKhuyenMai)
        lbNguoiLap.Text = phieuBh.DonHang_NhanVien.Ten
        lbThanhTien.Text = CurrencyFormat(phieuBh.ThanhTien)
        Dim resultChiTiet As New List(Of ChiTietDonHang)
        list.ForEach(Sub(dh)
                         resultChiTiet.AddRange(dh.ListChiTietDonhang)

                     End Sub)

        dgvSanPham.DataSource = Nothing
        BindingSource_CTDonHang.DataSource = resultChiTiet
        dgvSanPham.DataSource = BindingSource_CTDonHang
        ConfigureGridViewChiTietDonHang()

    End Sub

    Public Sub ConfigureGridView() Implements IDonHangView.ConfigureGridView
        dgvDonHang.Columns("Ma").Visible = False
        dgvDonHang.Columns("GhiChu").Visible = False
        dgvDonHang.Columns("IsXoa").Visible = False
        dgvDonHang.Columns("ChiNhanh").Visible = False
        dgvDonHang.Columns("ChiNhanhMa").Visible = False
        dgvDonHang.Columns("NhanVienMa").Visible = False
        dgvDonHang.Columns("KhachHangMa").Visible = False

        ' Set custom header text for columns
        dgvDonHang.Columns("Code").HeaderText = "Code"
        dgvDonHang.Columns("Code").DisplayIndex = 0

        dgvDonHang.Columns("Ngay").HeaderText = "Ngày"
        dgvDonHang.Columns("Ngay").DisplayIndex = 1


        dgvDonHang.Columns("TongSanPham").HeaderText = "Tổng SP"
        dgvDonHang.Columns("TongSanPham").DisplayIndex = 2
        dgvDonHang.Columns("TongSanPham").Width = 50

        dgvDonHang.Columns("TongTien").HeaderText = "Tổng tiền"
        dgvDonHang.Columns("TongTien").DisplayIndex = 3

        dgvDonHang.Columns("TongKhuyenMai").HeaderText = "Tổng KM"
        dgvDonHang.Columns("TongKhuyenMai").DisplayIndex = 4

        dgvDonHang.Columns("ThanhTien").HeaderText = "Thành tiền"
        dgvDonHang.Columns("ThanhTien").DisplayIndex = 5

        dgvDonHang.Columns("BanHangKhachHang").HeaderText = "Khách hàng"
        dgvDonHang.Columns("BanHangKhachHang").DisplayIndex = 6

        dgvDonHang.Columns("DonHang_NhanVien").HeaderText = "Người lập"
        dgvDonHang.Columns("DonHang_NhanVien").DisplayIndex = 7

    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
            Case "btnCapNhat"
            Case "btnTaoDon"
                TaoDon()
            Case "btnXoa"
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Sub TaoDon()

        ' Tao 1 phieu ban hang moi
        Dim newPhieuBanHang As New DonHang() With {
                 .Code = Gen_12Chars_UUID(),
                 .Ngay = dtPicker.Value,
                 .TongSanPham = 0,
                 .TongKhuyenMai = 0,
                 .TongTien = 0,
                 .ThanhTien = 0,
                 .GhiChu = "",
                 .IsXoa = False,
                 .BanHangKhachHang = New KhachHang() With {
                      .Code = Gen_6Chars_UUID(),
                      .Ten = "",
                      .DienThoai = "",
                      .DiaChi = "",
                      .IsXoa = False
                 },
                 .ChiNhanh = userSession.ChiNhanh,
                 .DonHang_NhanVien = userSession
        }
        donHangController.XulyTaoDonHang(newPhieuBanHang)
        GotoChiTietDonHangForm(newPhieuBanHang)
    End Sub

    Private Sub FormQLBanHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nhanvienController = INhanVienControllerImpl.Instance

        donHangController = IDonHangControllerImpl.Instance
        donHangController.Init(Me)

        InitViews()
        LoadData()

    End Sub

    Public Sub GotoChiTietDonHangForm(tempDonHang As DonHang) Implements IDonHangView.GotoChiTietDonHangForm
        Dim frm As Form = TimForm(GetType(FormChiTietDonHang), listForms)
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim formTaoDonHang As New FormChiTietDonHang(tempDonHang)

        formTaoDonHang.MdiParent = Me.MdiParent
        formTaoDonHang.WindowState = FormWindowState.Maximized
        formTaoDonHang.Show()
        listForms.Add(formTaoDonHang)
    End Sub

    Private Sub dgvDonHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDonHang.CellClick
        If e.RowIndex >= 0 Then
            donHangController.Index = e.RowIndex
            Dim selectedRow = dgvDonHang.Rows(e.RowIndex)
            Dim selectedDonHang = CType(selectedRow.DataBoundItem, DonHang)
            If selectedDonHang IsNot Nothing Then
                donHangController.Xuly_Get_ChiTiet_DonHang_With_KH_NV_By_ChiNhanh(selectedDonHang.Ma)
            End If

        End If
    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged
        Dim tukhoa = tbTuKhoa.Text.Trim.ToString()
        Dim result As List(Of DonHang) = donHangController.Xuly_TimKiem_DonHang_By_ChiNhanh(tukhoa)
        BindingListDonHangToGridView(result)
    End Sub

    Private Sub dgvDonHang_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDonHang.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "BanHangKhachHang" Then
            If e.Value IsNot Nothing Then
                Dim khachHang = TryCast(e.Value, KhachHang)
                If khachHang IsNot Nothing Then
                    e.Value = khachHang.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "DonHang_NhanVien" Then
            If e.Value IsNot Nothing Then
                Dim nhanVien = TryCast(e.Value, NhanVien)
                If nhanVien IsNot Nothing Then
                    e.Value = nhanVien.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "TongKhuyenMai" OrElse
            dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "TongTien" OrElse
            dgvDonHang.Columns(e.ColumnIndex).DataPropertyName = "ThanhTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If


    End Sub

    Public Sub ConfigureGridViewChiTietDonHang() Implements IDonHangView.ConfigureGridViewChiTietDonHang
        dgvSanPham.Columns("Ma").Visible = False
        dgvSanPham.Columns("Pbh_Ma").Visible = False
        dgvSanPham.Columns("Sp_Ma").Visible = False
        dgvSanPham.Columns("IsXoa").Visible = False

        dgvSanPham.Columns("SanPhamInfo").HeaderText = "SP"
        dgvSanPham.Columns("SanPhamInfo").DisplayIndex = 0
        dgvSanPham.Columns("SanPhamInfo").Width = 150

        dgvSanPham.Columns("Gia").HeaderText = "Đơn giá"
        dgvSanPham.Columns("Gia").DisplayIndex = 1
        dgvSanPham.Columns("Gia").Width = 100

        dgvSanPham.Columns("SoLuong").HeaderText = "SL"
        dgvSanPham.Columns("SoLuong").DisplayIndex = 2
        dgvSanPham.Columns("SoLuong").Width = 25

        dgvSanPham.Columns("TongTien").HeaderText = "Tổng"
        dgvSanPham.Columns("TongTien").DisplayIndex = 3
        dgvSanPham.Columns("TongTien").Width = 75

        dgvSanPham.Columns("KhuyenMai").HeaderText = "KM"
        dgvSanPham.Columns("KhuyenMai").DisplayIndex = 4
        dgvSanPham.Columns("KhuyenMai").Width = 75

        dgvSanPham.Columns("ThanhTien").HeaderText = "Thành tiền"
        dgvSanPham.Columns("ThanhTien").DisplayIndex = 5
        dgvSanPham.Columns("ThanhTien").Width = 100
    End Sub

    Private Sub dgvSanPham_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSanPham.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "SanPhamInfo" Then
            If e.Value IsNot Nothing Then
                Dim sanPham = TryCast(e.Value, SanPham)
                If sanPham IsNot Nothing Then
                    e.Value = sanPham.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "Gia" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "KhuyenMai" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "TongTien" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "ThanhTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If

    End Sub
End Class
