

Public Class FormQLNhanVien
    Implements INhanVienView, IBaseForm

    Private nhanVienController As INhanVienControllerImpl


    Public Sub LoadData() Implements INhanVienView.LoadData
        nhanVienController.XulyLoadData()
        nhanVienController.XulyGetAllChiNhanh()
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements INhanVienView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub XoaNhanVien()
        If dgvNhanVien.SelectedCells.Count > 0 Then
            nhanVienController.XulyXoaNhanVien()
            bsNhanVien.RemoveAt(nhanVienController.Index)

        End If
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemNhanVien()
            Case "btnCapNhat"
                CapNhatNhanVien()
        End Select
    End Sub

    Private Sub CapNhatNhanVien()
        If dgvNhanVien.SelectedCells.Count > 0 Then
            Dim selectedChiNhanh As ChiNhanh = TryCast(cbChiNhanh.SelectedItem, ChiNhanh)
            Dim nvParam As New NhanVien() With {
                .Ten = tbTen.Text,
                .DiaChi = tbDiaChi.Text,
                .DienThoai = tbDienThoai.Text,
                .IsXoa = cbStatus.Checked,
                .TaiKhoan = New TaiKhoan() With {
                      .Ma = 0,
                      .TaiKhoan = tbTaiKhoan.Text,
                      .MatKhau = HashPwd(tbMatKhau.Text),
                      .IsXoa = cbStatus.Checked
                 },
                 .ChiNhanh = New ChiNhanh() With {
                      .Ma = selectedChiNhanh.Ma,
                      .Ten = selectedChiNhanh.Ten,
                      .DiaChi = selectedChiNhanh.DiaChi
                 },
                 .NV_ChiNhanh_Ma = selectedChiNhanh.Ma,
                 .NV_TaiKhoan_Ma = 0
            }

            nhanVienController.XulyCapNhatNhanVienTK(nvParam)
        End If
    End Sub

    Private Sub ThemNhanVien()
        Dim selectedChiNhanh As ChiNhanh = TryCast(cbChiNhanh.SelectedItem, ChiNhanh)
        Dim newTk As New TaiKhoan() With {
            .TaiKhoan = tbTaiKhoan.Text,
            .MatKhau = HashPwd(tbMatKhau.Text),
            .IsXoa = False,
            .SoLanDangNhapSai = 0,
            .IsChuQuan = False
        }
        Dim isMan As Boolean = rbNam.Checked = True

        Dim newNv As New NhanVien() With {
            .Ten = tbTen.Text,
            .DiaChi = tbDiaChi.Text,
            .GioiTinh = isMan,
            .DienThoai = tbDienThoai.Text,
            .IsXoa = False,
            .TaiKhoan = newTk,
            .ChiNhanh = TryCast(cbChiNhanh.SelectedItem, ChiNhanh),
            .NV_TaiKhoan_Ma = newTk.Ma,
            .NV_ChiNhanh_Ma = selectedChiNhanh.Ma
        }
        nhanVienController.XulyThemTaiKhoan(newTk, newNv)
    End Sub

    Public Sub BindingListToGridView(list As List(Of NhanVien)) Implements INhanVienView.BindingListToGridView

        dgvNhanVien.DataSource = Nothing

        bsNhanVien.DataSource = list

        dgvNhanVien.DataSource = bsNhanVien

        ConfigureGridView()

    End Sub

    Public Sub ConfigureGridView() Implements INhanVienView.ConfigureGridView

        dgvNhanVien.Columns("Ma").Visible = False
        dgvNhanVien.Columns("GioiTinh").Visible = False
        dgvNhanVien.Columns("NV_ChiNhanh_Ma").Visible = False
        dgvNhanVien.Columns("NV_TaiKhoan_Ma").Visible = False

        ' Set custom header text for columns

        dgvNhanVien.Columns("Ten").HeaderText = "Tên"
        dgvNhanVien.Columns("Ten").DisplayIndex = 0

        dgvNhanVien.Columns("TaiKhoan").HeaderText = "Tài khoản"
        dgvNhanVien.Columns("TaiKhoan").DisplayIndex = 1

        dgvNhanVien.Columns("ChiNhanh").HeaderText = "Chi nhánh"
        dgvNhanVien.Columns("ChiNhanh").DisplayIndex = 2


        dgvNhanVien.Columns("DienThoai").HeaderText = "Điện thoại"
        'dgvNhanVien.Columns("DienThoai").DisplayIndex = 3

        dgvNhanVien.Columns("DiaChi").HeaderText = "Địa chỉ"
        'dgvNhanVien.Columns("DiaChi").DisplayIndex = 4


        dgvNhanVien.Columns("IsXoa").HeaderText = "Đã nghỉ"
        'dgvNhanVien.Columns("IsXoa").DisplayIndex = 5


    End Sub

    Public Sub ClearFields() Implements INhanVienView.ClearFields
        tbTaiKhoan.Text = ""
        tbMatKhau.Text = ""
        tbTen.Text = ""
        tbDiaChi.Text = ""
        tbDienThoai.Text = ""
        rbNam.Checked = True
        rbNu.Checked = False
    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick

    End Sub

    Private Sub FormNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nhanVienController = INhanVienControllerImpl.Instance
        nhanVienController.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged
        Dim tukhoa = tbTuKhoa.Text.Trim.ToString()
        Dim result As List(Of NhanVien) = nhanVienController.XulyTimKiemNhanVien(tukhoa)
        BindingListToGridView(result)
    End Sub

    Private Sub cbIsXoa_CheckedChanged(sender As Object, e As EventArgs)
        Dim tukhoa = tbTuKhoa.Text.Trim.ToString
        Dim result = nhanVienController.XulyTimKiemNhanVien(tukhoa)
        BindingListToGridView(result)
    End Sub

    Private Sub dgvNhanVien_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNhanVien.CellClick
        If e.RowIndex >= 0 Then
            nhanVienController.Index = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvNhanVien.Rows(e.RowIndex)
            Dim selectedNv As NhanVien = CType(selectedRow.DataBoundItem, NhanVien)
            If selectedNv IsNot Nothing Then
                BindingTolabelTextBox(selectedNv)
            End If
        End If
    End Sub

    Public Sub BindingTolabelTextBox(nhanVien As NhanVien) Implements INhanVienView.BindingTolabelTextBox
        tbTaiKhoan.Text = nhanVien.TaiKhoan.TaiKhoan
        tbMatKhau.Text = nhanVien.TaiKhoan.MatKhau
        tbTen.Text = nhanVien.Ten
        tbDienThoai.Text = nhanVien.DienThoai
        tbDiaChi.Text = nhanVien.DiaChi
        cbStatus.Checked = nhanVien.IsXoa
        If nhanVien.GioiTinh Then
            rbNam.Checked = True
        Else
            rbNu.Checked = True
        End If
        cbChiNhanh.SelectedValue = nhanVien.ChiNhanh.Ma
    End Sub

    Public Sub BindingChiNhanhCombobox(list As List(Of ChiNhanh)) Implements INhanVienView.BindingChiNhanhCombobox
        cbChiNhanh.DataSource = Nothing
        cbChiNhanh.DataSource = list
        cbChiNhanh.DisplayMember = "Ten"
        cbChiNhanh.ValueMember = "Ma"
    End Sub

    Private Sub dgvNhanVien_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvNhanVien.CellFormatting
        If e.RowIndex >= 0 AndAlso dgvNhanVien.Columns(e.ColumnIndex).DataPropertyName = "TaiKhoan" Then
            If e.Value IsNot Nothing Then
                Dim tk = TryCast(e.Value, TaiKhoan)
                If tk IsNot Nothing Then
                    e.Value = tk.TaiKhoan
                    e.FormattingApplied = True
                End If
            End If
        End If

        If e.RowIndex >= 0 AndAlso dgvNhanVien.Columns(e.ColumnIndex).DataPropertyName = "ChiNhanh" Then
            If e.Value IsNot Nothing Then
                Dim cn = TryCast(e.Value, ChiNhanh)
                If cn IsNot Nothing Then
                    e.Value = cn.Ten
                    e.FormattingApplied = True
                End If
            End If
        End If

    End Sub
End Class