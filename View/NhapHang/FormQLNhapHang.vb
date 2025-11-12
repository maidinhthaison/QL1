Public Class FormQLNhapHang
    Implements IBaseForm, INhapHangView

    Private nhapHangController As INhapHangControllerImpl

    Private nhanvienController As INhanVienControllerImpl

    Dim userSession As NhanVien

    Private listForms As List(Of Form)

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnTaoPhieuNhap.Click, AddressOf OnButtonClick

        'Set up DateTimePicker
        dtPicker.Format = DateTimePickerFormat.Custom
        dtPicker.CustomFormat = Constant.DATETIME_FORMAT
        dtPicker.Value = DateTime.Now

        listForms = New List(Of Form)
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnTaoPhieuNhap"
                TaoPhieuNhap()
        End Select
    End Sub


    Private Sub TaoPhieuNhap()
        ' Tao 1 phieu ban hang moi
        Dim newPhieuNhapHang As New PhieuNhap() With {
                 .ChiNhanhMa = userSession.NV_ChiNhanh_Ma,
                 .Code = Gen_12Chars_UUID(),
                 .NgayNhap = dtPicker.Value,
                 .TongSanPham = 0,
                 .TongKhuyenMai = 0,
                 .TongTien = 0,
                 .TongThanhTien = 0,
                 .GhiChu = "",
                 .IsXoa = False,
                 .PhieuNhap_ChiNhanh = userSession.ChiNhanh
        }

        nhapHangController.Xuly_TaoPhieuNhap(newPhieuNhapHang)
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements INhapHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub BindingListPhieuNhapToGridView(list As List(Of PhieuNhap)) Implements INhapHangView.BindingListPhieuNhapToGridView

        RefreshNhapHangGridView(list)

        ConfigureNhapHangGridView()
    End Sub

    Public Sub ConfigureNhapHangGridView() Implements INhapHangView.ConfigureNhapHangGridView
        dgvPhieuNhap.Columns("Ma").Visible = False
        dgvPhieuNhap.Columns("GhiChu").Visible = False
        dgvPhieuNhap.Columns("IsXoa").Visible = False
        dgvPhieuNhap.Columns("ChiNhanhMa").Visible = False
        dgvPhieuNhap.Columns("PhieuNhap_ChiNhanh").Visible = False

        ' Set custom header text for columns
        dgvPhieuNhap.Columns("Code").HeaderText = "Code"
        dgvPhieuNhap.Columns("Code").DisplayIndex = 0

        dgvPhieuNhap.Columns("NgayNhap").HeaderText = "Ngày"
        dgvPhieuNhap.Columns("NgayNhap").DisplayIndex = 1

        dgvPhieuNhap.Columns("TongSanPham").HeaderText = "Tổng SP"
        dgvPhieuNhap.Columns("TongSanPham").DisplayIndex = 2
        dgvPhieuNhap.Columns("TongSanPham").Width = 50

        dgvPhieuNhap.Columns("TongTien").HeaderText = "Tổng tiền"
        dgvPhieuNhap.Columns("TongTien").DisplayIndex = 3

        dgvPhieuNhap.Columns("TongKhuyenMai").HeaderText = "Tổng KM"
        dgvPhieuNhap.Columns("TongKhuyenMai").DisplayIndex = 4


        dgvPhieuNhap.Columns("TongThanhTien").HeaderText = "Thành tiền"
        dgvPhieuNhap.Columns("TongThanhTien").DisplayIndex = 5

    End Sub

    Public Sub LoadData() Implements INhapHangView.LoadData
        nhapHangController = INhapHangControllerImpl.Instance
        nhapHangController.Init(Me)
        nhanvienController = INhanVienControllerImpl.Instance
        userSession = nhanvienController.UserSession
        nhapHangController.Xuly_GetPhieuNhap_By_ChiNhanh(userSession.NV_ChiNhanh_Ma)
    End Sub

    Public Sub GotoChiTietPhieuNhap(phieuNhap As PhieuNhap) Implements INhapHangView.GotoChiTietPhieuNhap
        Dim frm As Form = TimForm(GetType(FormChiTietNhapHang), listForms)
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim formTaoPhieuNhap As New FormChiTietNhapHang(phieuNhap) With {
            .MdiParent = Me.MdiParent,
            .WindowState = FormWindowState.Maximized
        }
        formTaoPhieuNhap.Show()
        listForms.Add(formTaoPhieuNhap)
    End Sub

    Private Sub FormQLNhapHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitViews()
        LoadData()
    End Sub

    Private Sub dgvPhieuNhap_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuNhap.CellClick
        If e.RowIndex >= 0 Then
            nhapHangController.GetSelectedIndex = e.RowIndex
            Dim selectedRow = dgvPhieuNhap.Rows(e.RowIndex)
            Dim selectedPhieuNhap = CType(selectedRow.DataBoundItem, PhieuNhap)
            If selectedPhieuNhap IsNot Nothing Then
                BindingPhieuNhapToTextBox(selectedPhieuNhap)
                ''Lấy dữ liệu chi tiết phiếu nhập theo mã phiếu nhập
                nhapHangController.Xuly_GetChiTietPhieuNhap_By_MaPhieuNhap(selectedPhieuNhap.Ma)
            End If

        End If
    End Sub

    Private Sub dgvPhieuNhap_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPhieuNhap.CellFormatting
        If e.RowIndex >= 0 AndAlso
           dgvPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "TongTien" OrElse
           dgvPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "TongKhuyenMai" OrElse
           dgvPhieuNhap.Columns(e.ColumnIndex).DataPropertyName = "TongThanhTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If


    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick

    End Sub

    Private Sub dgvSanPham_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSanPham.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "GetSanPham" Then
            If e.Value IsNot Nothing Then
                Dim sp = TryCast(e.Value, SanPham)
                If sp IsNot Nothing Then
                    e.Value = sp.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso
           dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "Gia" OrElse
           dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "TongTien" OrElse
           dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "TongThanhTien" OrElse
           dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "KhuyenMai" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If
    End Sub

    Private Sub FormQLNhapHang_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        nhapHangController.GetListPhieuNhap.Clear()
    End Sub

    Public Sub BindingPhieuNhapToTextBox(phieuNhap As PhieuNhap) Implements INhapHangView.BindingPhieuNhapToTextBox
        lbChiNhanh.Text = phieuNhap.PhieuNhap_ChiNhanh.Ten
        lbCode.Text = phieuNhap.Code
        lbNgayNhap.Text = phieuNhap.NgayNhap
        tbGhiChu.Text = phieuNhap.GhiChu
        lbNguoiLap.Text = userSession.Ten ''Chỉ chủ quán mới dc lập phiếu nhập
        lbTongKhuyenMai.Text = CurrencyFormat(phieuNhap.TongKhuyenMai)
        lbTongTien.Text = CurrencyFormat(phieuNhap.TongTien)
        lbTongThanhTien.Text = CurrencyFormat(phieuNhap.TongThanhTien)
        lbTongSp.Text = phieuNhap.TongSanPham
    End Sub

    Public Sub RefreshNhapHangGridView(list As List(Of PhieuNhap)) Implements INhapHangView.RefreshNhapHangGridView
        dgvPhieuNhap.DataSource = Nothing

        BindingSource_PhieuNhap.DataSource = list

        dgvPhieuNhap.DataSource = BindingSource_PhieuNhap
    End Sub

    Public Sub BindingListChiTietPhieuNhapToGridView(list As List(Of ChiTietPhieuNhap)) Implements INhapHangView.BindingListChiTietPhieuNhapToGridView
        RefreshChiTietPhieuNhapGridView(list)

        ConfigureChiTietPhieuNhapGridView()
    End Sub

    Public Sub ConfigureChiTietPhieuNhapGridView() Implements INhapHangView.ConfigureChiTietPhieuNhapGridView
        dgvSanPham.Columns("Ma").Visible = False
        dgvSanPham.Columns("MaSanPham").Visible = False
        dgvSanPham.Columns("GhiChu").Visible = False
        dgvSanPham.Columns("IsXoa").Visible = False
        dgvSanPham.Columns("PhieuNhapMa").Visible = False

        ' Set custom header text for columns

        dgvSanPham.Columns("GetSanPham").HeaderText = "SP"
        dgvSanPham.Columns("GetSanPham").DisplayIndex = 0
        dgvSanPham.Columns("GetSanPham").Width = 150

        dgvSanPham.Columns("Gia").HeaderText = "Giá"
        dgvSanPham.Columns("Gia").DisplayIndex = 1
        dgvSanPham.Columns("Gia").Width = 75

        dgvSanPham.Columns("SoLuong").HeaderText = "SL"
        dgvSanPham.Columns("SoLuong").DisplayIndex = 2
        dgvSanPham.Columns("SoLuong").Width = 50


        dgvSanPham.Columns("TongTien").HeaderText = "Tổng tiền"
        dgvSanPham.Columns("TongTien").DisplayIndex = 3

        dgvSanPham.Columns("KhuyenMai").HeaderText = "KM"
        dgvSanPham.Columns("KhuyenMai").DisplayIndex = 4


        dgvSanPham.Columns("TongThanhTien").HeaderText = "Thành tiền"
        dgvSanPham.Columns("TongThanhTien").DisplayIndex = 5

    End Sub

    Public Sub RefreshChiTietPhieuNhapGridView(list As List(Of ChiTietPhieuNhap)) Implements INhapHangView.RefreshChiTietPhieuNhapGridView
        dgvSanPham.DataSource = Nothing

        BindingSource_SanPham.DataSource = list

        dgvSanPham.DataSource = BindingSource_SanPham
    End Sub
End Class