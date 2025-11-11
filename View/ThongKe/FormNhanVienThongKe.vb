
Public Class FormNhanVienThongKe
    Implements INhanVienThongKeView, IBaseForm

    Private thongKeController As IThongKeControllerImpl

    Private nhanViewController As INhanVienControllerImpl

    Private userSession As NhanVien

    Public Sub LoadData() Implements INhanVienThongKeView.LoadData
        cbBoLoc.DataSource = System.Enum.GetValues(GetType(EnumFilterThongKe))
        Dim selectedFilter As EnumFilterThongKe = CType(cbBoLoc.SelectedItem, EnumFilterThongKe)

        'Mặc định theo tháng
        thongKeController.XulyThongKeNhanVienBanHang(EnumFilterThongKe.Thang, userSession.Ma)

        lbChiNhanh.Text = userSession.ChiNhanh.Ten
        lbNhanVien.Text = userSession.Ten

    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnTraCuu.Click, AddressOf OnButtonClick
    End Sub

    Public Sub BindingListDoanhThuSanPhamOfNhanVienToGridView(list As List(Of ChiTietDonHang)) Implements INhanVienThongKeView.BindingListDoanhThuSanPhamOfNhanVienToGridView
        RefreshGridView(list)

        ConfigGridView()
    End Sub

    Private Sub RefreshGridView(list As List(Of ChiTietDonHang))
        dgvSanPham.DataSource = Nothing

        bsDoanhThuSanPham.DataSource = list

        dgvSanPham.DataSource = bsDoanhThuSanPham
    End Sub


    Public Sub ConfigGridView()
        dgvSanPham.Columns("Ma").Visible = False
        dgvSanPham.Columns("Pbh_Ma").Visible = False
        dgvSanPham.Columns("Sp_Ma").Visible = False
        dgvSanPham.Columns("IsXoa").Visible = False
        dgvSanPham.Columns("GiaNhap").Visible = False

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
            .HeaderText = "SL"
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

    Private Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements INhanVienThongKeView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub FormNhanVienThongKe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thongKeController = IThongKeControllerImpl.Instance
        thongKeController.InitViewNhanVien(Me)

        nhanViewController = INhanVienControllerImpl.Instance
        userSession = nhanViewController.UserSession
        InitViews()
        LoadData()
    End Sub

    Private Sub FormNhanVienThongKe_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        userSession = Nothing
        thongKeController.ListThongKeBanHang.Clear()
        thongKeController.ListThongKeBanHang = Nothing
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
        thongKeController.XulyThongKeNhanVienBanHang(selectedFilter, userSession.Ma)
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
                dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "GiaNhap" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "KhuyenMai" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "ThanhTien" OrElse
            dgvSanPham.Columns(e.ColumnIndex).DataPropertyName = "TongTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If
    End Sub

    Public Sub SetDoanhThuLabel(doanhThu As Double) Implements INhanVienThongKeView.SetDoanhThuLabel
        lbDoanhThu.Text = CurrencyFormat(doanhThu)
    End Sub
End Class