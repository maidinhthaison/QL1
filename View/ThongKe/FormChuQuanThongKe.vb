Public Class FormChuQuanThongKe
    Implements IChuQuanThongKeView, IBaseForm

    Private thongKeController As IThongKeControllerImpl

    Private nhanViewController As INhanVienControllerImpl

    Private userSession As NhanVien

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnTraCuu.Click, AddressOf OnButtonClick
    End Sub

    Public Sub LoadData() Implements IChuQuanThongKeView.LoadData
        cbBoLoc.DataSource = System.Enum.GetValues(GetType(EnumFilterThongKe))
        Dim selectedFilter As EnumFilterThongKe = CType(cbBoLoc.SelectedItem, EnumFilterThongKe)

        'Mặc định theo tháng
        thongKeController.XulyThongKeDoanhThu(EnumFilterThongKe.Thang)

        lbChiNhanh.Text = userSession.ChiNhanh.Ten

    End Sub

    Public Sub BindingListDoanhThuSanPhamToGridView(list As List(Of ChiTietDonHang)) Implements IChuQuanThongKeView.BindingListDoanhThuSanPhamToGridView
        RefreshGridView(list)

        ConfigGridView()
    End Sub

    Private Sub ConfigGridView()
        dgvSanPham.Columns("Ma").Visible = False
        dgvSanPham.Columns("Pbh_Ma").Visible = False
        dgvSanPham.Columns("Sp_Ma").Visible = False
        dgvSanPham.Columns("IsXoa").Visible = False

        ' Set custom header text for columns
        With dgvSanPham.Columns("SanPhamInfo")
            .HeaderText = "SP"
            .DisplayIndex = 0
            .Width = 200
        End With

        With dgvSanPham.Columns("Gia")
            .HeaderText = "Giá bán"
            .DisplayIndex = 1
            .Width = 100
        End With

        With dgvSanPham.Columns("SoLuong")
            .HeaderText = "SL Bán"
            .DisplayIndex = 2
            .Width = 50
        End With

        With dgvSanPham.Columns("TongTien")
            .HeaderText = "Tổng tiền"
        End With

        With dgvSanPham.Columns("KhuyenMai")
            .HeaderText = "KM"
            .Width = 100
        End With

        With dgvSanPham.Columns("ThanhTien")
            .HeaderText = "Thành tiền"
        End With
    End Sub

    Private Sub RefreshGridView(list As List(Of ChiTietDonHang))
        dgvSanPham.DataSource = Nothing

        bsDoanhThuSanPham.DataSource = list

        dgvSanPham.DataSource = bsDoanhThuSanPham
    End Sub

    Public Sub SetDoanhThuLabel(fromDate As String, toDate As String, doanhThu As Double, tienVon As Double, khuyenMai As Double, loiNhuan As Double) Implements IChuQuanThongKeView.SetDoanhThuLabel
        lbDoanhThu.Text = CurrencyFormat(doanhThu)
        lbTienVon.Text = CurrencyFormat(tienVon)
        lbKhuyenMai.Text = CurrencyFormat(khuyenMai)
        lbLoiNhuan.Text = CurrencyFormat(loiNhuan)
        lbDate.Text = String.Format("Từ ngày {0} đến ngày {1}", fromDate, toDate)
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IChuQuanThongKeView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub FormChuQuanThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thongKeController = IThongKeControllerImpl.Instance
        thongKeController.InitViewChuQuan(Me)

        nhanViewController = INhanVienControllerImpl.Instance
        userSession = nhanViewController.UserSession
        InitViews()
        LoadData()
    End Sub

    Private Sub FormChuQuanThongKe_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        userSession = Nothing
        thongKeController.ListThongKeDoanhThuCuaHang.Clear()
        thongKeController.ListThongKeDoanhThuCuaHang = Nothing
        thongKeController.CTDHIndex = -1
        thongKeController = Nothing
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnTraCuu"
                TraCuuThongKe()
        End Select
    End Sub

    Private Sub TraCuuThongKe()
        Dim selectedFilter As EnumFilterThongKe = CType(cbBoLoc.SelectedItem, EnumFilterThongKe)
        thongKeController.XulyThongKeDoanhThu(selectedFilter)
    End Sub

    Private Sub dgvSanPham_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSanPham.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "SanPhamInfo" Then
            If e.Value IsNot Nothing Then
                Dim spInfo = TryCast(e.Value, SanPham)
                If spInfo IsNot Nothing Then
                    e.Value = spInfo.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "Gia" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "KhuyenMai" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "ThanhTien" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "TongTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If

        ' Highlight dòng đầu tiên (sản phẩm bán nhiều nhất)
        dgvSanPham.Rows(0).DefaultCellStyle.BackColor = Color.LightCoral

    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick

        If e.RowIndex >= 0 Then
            thongKeController.CTDHIndex = e.RowIndex
            thongKeController.XulyClickChiTietSanPham()

        End If
    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged
        Dim tukhoa = tbTuKhoa.Text.Trim.ToString()
        Dim result As List(Of ChiTietDonHang) = thongKeController.XulyTimKiemSanPham(tukhoa)
        BindingListDoanhThuSanPhamToGridView(result)
    End Sub

    Public Sub SetDoanhThuSanPhamLabel(doanhThu As Double, tienVon As Double, khuyenMai As Double, loiNhuan As Double) Implements IChuQuanThongKeView.SetDoanhThuSanPhamLabel
        lbDoanhThuSp.Text = CurrencyFormat(doanhThu)
        lbTienVonSp.Text = CurrencyFormat(tienVon)
        lbKhuyenMaiSp.Text = CurrencyFormat(khuyenMai)
        lbLoiNhuanSp.Text = CurrencyFormat(loiNhuan)
    End Sub
End Class