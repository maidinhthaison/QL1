Public Class FormQLThuChi
    Implements IBaseForm, IQuanLyPhieuChiView

    Private phieuChiController As IPhieuChiControllerImpl

    Private nhanvienController As INhanVienControllerImpl

    Dim userSession As NhanVien

    Private listForms As List(Of Form)

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnTaoPhieuChi.Click, AddressOf OnButtonClick
        AddHandler btnCapNhatCTPC.Click, AddressOf OnButtonClick
        AddHandler btnThemCTPC.Click, AddressOf OnButtonClick

        'Set up DateTimePicker
        dtPicker.Format = DateTimePickerFormat.Custom
        dtPicker.CustomFormat = DATETIME_FORMAT
        dtPicker.Value = DateTime.Now

        listForms = New List(Of Form)
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnTaoPhieuChi"
                TaoPhieuChi()
            Case "btnCapNhatCTPC"
                CapNhatCTPC()
            Case "btnThemCTPC"
                ThemCTPC()
        End Select
    End Sub

    Private Sub ThemCTPC()
        Dim index As Integer = phieuChiController.GetSelectedPhieuChiIndex
        Dim selectedPhieuChi As PhieuChi = phieuChiController.GetListPhieuChi(index)
        If selectedPhieuChi Is Nothing Then
            Return
        End If
        ' Thêm mới
        Dim selectedLyDo As PhieuChiLyDo = TryCast(cbLyDo.SelectedItem, PhieuChiLyDo)
        Dim newCTPhieuChi As New ChiTietPhieuChi() With {
            .Ma = 0,
            .SoTien = Double.Parse(tbSoTien.Text.Trim.ToString),
            .PhieuChiMa = selectedPhieuChi.Ma,
            .LyDoMa = selectedLyDo.Ma,
            .GhiChu = tbCTPC_GhiChu.Text.Trim.ToString,
            .GetPhieuChiLyDo = New PhieuChiLyDo() With {
                  .Code = selectedLyDo.Code,
                  .Ma = selectedLyDo.Ma,
                  .Mota = selectedLyDo.Mota
             }
        }
        phieuChiController.Xuly_Them_CTPhieuChi(newCTPhieuChi)
    End Sub

    Private Sub CapNhatCTPC()
        Dim index As Integer = phieuChiController.GetSelectedPhieuChiIndex
        Dim selectedPhieuChi As PhieuChi = phieuChiController.GetListPhieuChi(index)
        If selectedPhieuChi Is Nothing Then
            Return
        End If
        Dim selectedCTPCIndex As Integer = phieuChiController.GetSelectedChiTietPhieuChiIndex
        Dim selectedCTPC As ChiTietPhieuChi = phieuChiController.GetListChiTietPhieuChi(selectedCTPCIndex)
        If selectedCTPC Is Nothing Then
            Return
        End If
        Dim selectedLyDo As PhieuChiLyDo = TryCast(cbLyDo.SelectedItem, PhieuChiLyDo)
        Dim newCTPhieuChi As New ChiTietPhieuChi() With {
                .Ma = selectedCTPC.Ma,
                .SoTien = Double.Parse(tbSoTien.Text.Trim.ToString),
                .PhieuChiMa = selectedPhieuChi.Ma,
                .LyDoMa = selectedLyDo.Ma,
                .GhiChu = tbCTPC_GhiChu.Text.Trim.ToString,
                .GetPhieuChiLyDo = New PhieuChiLyDo() With {
                      .Code = selectedLyDo.Code,
                      .Ma = selectedLyDo.Ma,
                      .Mota = selectedLyDo.Mota
                 }
            }
        phieuChiController.Xuly_CapNhat_CTPhieuChi(newCTPhieuChi, selectedPhieuChi)

    End Sub

    Private Sub TaoPhieuChi()

        ' Tao 1 phieu chi mới
        Dim newPhieuChi As New PhieuChi() With {
            .NgayChi = dtPicker.Value,
            .TongTien = 0,
            .IsXoa = False,
            .Code = Gen_12Chars_UUID(),
            .GhiChu = tbGhiChu.Text.Trim.ToString,
            .ChiNhanhMa = userSession.NV_ChiNhanh_Ma,
            .PhieuChi_ChiNhanh = userSession.ChiNhanh
        }

        phieuChiController.Xuly_TaoPhieuChi(newPhieuChi)
    End Sub

    Public Sub LoadData() Implements IQuanLyPhieuChiView.LoadData
        phieuChiController = IPhieuChiControllerImpl.Instance
        phieuChiController.Init(Me)
        nhanvienController = INhanVienControllerImpl.Instance
        userSession = nhanvienController.UserSession
        phieuChiController.Xuly_GetPhieuChi_By_ChiNhanh(userSession.NV_ChiNhanh_Ma)
        phieuChiController.Xuly_LoadLyDo_To_Combobox()

        lbChiNhanh.Text = userSession.ChiNhanh.Ten
        lbNguoiLap.Text = userSession.Ten
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IQuanLyPhieuChiView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub BindingListPhieuChiToGridView(list As List(Of PhieuChi)) Implements IQuanLyPhieuChiView.BindingListPhieuChiToGridView
        RefreshPhieuChiGridView(list)

        ConfigurePhieuChiGridView()
    End Sub

    Public Sub BindingPhieuChiToTextBox(phieuChi As PhieuChi) Implements IQuanLyPhieuChiView.BindingPhieuChiToTextBox
        dtPicker.Value = phieuChi.NgayChi.ToString(DATETIME_FORMAT)
        lbCode.Text = phieuChi.Code
        tbGhiChu.Text = phieuChi.GhiChu
        lbTongTien.Text = CurrencyFormat(phieuChi.TongTien)
    End Sub

    Public Sub ConfigurePhieuChiGridView() Implements IQuanLyPhieuChiView.ConfigurePhieuChiGridView
        dgvPhieuChi.Columns("Ma").Visible = False
        dgvPhieuChi.Columns("GhiChu").Visible = False
        dgvPhieuChi.Columns("ChiNhanhMa").Visible = False
        dgvPhieuChi.Columns("PhieuChi_ChiNhanh").Visible = False

        ' Set custom header text for columns
        dgvPhieuChi.Columns("Code").HeaderText = "Code"
        dgvPhieuChi.Columns("Code").DisplayIndex = 0

        dgvPhieuChi.Columns("NgayChi").HeaderText = "Ngày"
        dgvPhieuChi.Columns("NgayChi").DisplayIndex = 1

        dgvPhieuChi.Columns("TongTien").HeaderText = "Tổng tiền"
        dgvPhieuChi.Columns("TongTien").DisplayIndex = 2

        dgvPhieuChi.Columns("IsXoa").HeaderText = "Xóa ?"
        dgvPhieuChi.Columns("IsXoa").DisplayIndex = 3
        dgvPhieuChi.Columns("IsXoa").Width = 50

    End Sub

    Public Sub RefreshPhieuChiGridView(list As List(Of PhieuChi)) Implements IQuanLyPhieuChiView.RefreshPhieuChiGridView
        dgvPhieuChi.DataSource = Nothing

        BindingSource_PhieuChi.DataSource = list

        dgvPhieuChi.DataSource = BindingSource_PhieuChi
    End Sub

    Public Sub BindingListChiTietPhieuChiToGridView(list As List(Of ChiTietPhieuChi)) Implements IQuanLyPhieuChiView.BindingListChiTietPhieuChiToGridView
        RefreshChiTietPhieuChiGridView(list)

        ConfigureChiTietPhieuChiGridView()
    End Sub

    Public Sub ConfigureChiTietPhieuChiGridView() Implements IQuanLyPhieuChiView.ConfigureChiTietPhieuChiGridView
        dgvCTPC.Columns("Ma").Visible = False
        dgvCTPC.Columns("GhiChu").Visible = False
        dgvCTPC.Columns("PhieuChiMa").Visible = False
        dgvCTPC.Columns("LyDoMa").Visible = False
        ' Set custom header text for columns
        dgvCTPC.Columns("GetPhieuChiLyDo").HeaderText = "Lý do"
        dgvCTPC.Columns("GetPhieuChiLyDo").DisplayIndex = 0
        dgvCTPC.Columns("GetPhieuChiLyDo").Width = 200

        dgvCTPC.Columns("SoTien").HeaderText = "Số tiền"
        dgvCTPC.Columns("SoTien").DisplayIndex = 1
        dgvCTPC.Columns("SoTien").Width = 100

        dgvCTPC.Columns("IsXoa").HeaderText = "Xóa ?"
        dgvCTPC.Columns("IsXoa").DisplayIndex = 3

    End Sub

    Public Sub RefreshChiTietPhieuChiGridView(list As List(Of ChiTietPhieuChi)) Implements IQuanLyPhieuChiView.RefreshChiTietPhieuChiGridView
        dgvCTPC.DataSource = Nothing

        BindingSource_CTPhieuChi.DataSource = list

        dgvCTPC.DataSource = BindingSource_CTPhieuChi
    End Sub

    Private Sub FormQLThuChi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitViews()
        LoadData()
    End Sub

    Private Sub dgvCTPC_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCTPC.CellClick
        If e.RowIndex >= 0 Then
            phieuChiController.GetSelectedChiTietPhieuChiIndex = e.RowIndex
            Dim selectedRow = dgvCTPC.Rows(e.RowIndex)
            Dim selectedCTPhieuChi = CType(selectedRow.DataBoundItem, ChiTietPhieuChi)
            If selectedCTPhieuChi IsNot Nothing Then
                BindingCTPhieuChiToTextBox(selectedCTPhieuChi)
                ''Lấy dữ liệu chi tiết phiếu chi theo mã phiếu chi
                'phieuChiController.Xuly_GetChiTietPhieuChi_By_MaPhieuChi(selectedPhieuChi.Ma)
            End If

        End If
    End Sub

    Private Sub dgvCTPC_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCTPC.CellFormatting
        If e.RowIndex >= 0 AndAlso
           dgvCTPC.Columns(e.ColumnIndex).DataPropertyName = "SoTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvCTPC.Columns(e.ColumnIndex).DataPropertyName = "GetPhieuChiLyDo" Then
            If e.Value IsNot Nothing Then
                Dim pcld = TryCast(e.Value, PhieuChiLyDo)
                If pcld IsNot Nothing Then
                    e.Value = pcld.Mota
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub

    Private Sub dgvPhieuChi_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPhieuChi.CellClick
        If e.RowIndex >= 0 Then
            phieuChiController.GetSelectedPhieuChiIndex = e.RowIndex
            Dim selectedRow = dgvPhieuChi.Rows(e.RowIndex)
            Dim selectedPhieuChi = CType(selectedRow.DataBoundItem, PhieuChi)
            If selectedPhieuChi IsNot Nothing Then
                BindingPhieuChiToTextBox(selectedPhieuChi)
                ''Lấy dữ liệu chi tiết phiếu chi theo mã phiếu chi
                phieuChiController.Xuly_GetChiTietPhieuChi_By_MaPhieuChi(selectedPhieuChi.Ma)
            End If

        End If
    End Sub

    Private Sub dgvPhieuChi_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPhieuChi.CellFormatting
        If e.RowIndex >= 0 AndAlso
           dgvPhieuChi.Columns(e.ColumnIndex).DataPropertyName = "TongTien" Then
            If e.Value IsNot Nothing Then
                Dim value As Double = Convert.ToDouble(e.Value)
                e.Value = CurrencyFormat(value)
            End If
        End If

    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged

    End Sub


    Private Sub FormQLThuChi_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        phieuChiController.GetListPhieuChi.Clear()
        phieuChiController.GetSelectedPhieuChiIndex = 0
        phieuChiController.GetListPhieuChiLyDo.Clear()
        phieuChiController.GetListChiTietPhieuChi.Clear()
    End Sub

    Public Sub BindingPhieuChiLyDoToCombobox(list As List(Of PhieuChiLyDo)) Implements IQuanLyPhieuChiView.BindingPhieuChiLyDoToCombobox
        cbLyDo.DataSource = Nothing
        cbLyDo.DataSource = list
        cbLyDo.DisplayMember = "Mota"
        cbLyDo.ValueMember = "Ma"

    End Sub

    Public Sub BindingCTPhieuChiToTextBox(ctpc As ChiTietPhieuChi) Implements IQuanLyPhieuChiView.BindingCTPhieuChiToTextBox
        cbLyDo.SelectedValue = ctpc.GetPhieuChiLyDo.Ma
        tbSoTien.Text = ctpc.SoTien
        tbCTPC_GhiChu.Text = ctpc.GhiChu
        cbXoaCTPC.Checked = ctpc.IsXoa
    End Sub
End Class