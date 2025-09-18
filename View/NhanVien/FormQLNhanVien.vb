

Public Class FormQLNhanVien
    Implements INhanVienView, IBaseForm

    Private nhanVienController As INhanVienControllerImpl

    Public Sub SetController(Controller As INhanVienControllerImpl) Implements INhanVienView.SetController
        nhanVienController = Controller
    End Sub

    Public Sub LoadData() Implements INhanVienView.LoadData
        nhanVienController.XulyLoadData()
    End Sub

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements INhanVienView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Public Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String) Implements INhanVienView.ShowConfirmMessageBox
        Dim result As DialogResult
        result = MessageBox.Show(Message, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Select Case Action
                Case "btnXoa"
                    XoaSanPham()
            End Select

        End If
    End Sub

    Private Sub XoaSanPham()
        Throw New NotImplementedException()
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemNhanVien()
            Case "btnCapNhat"
                CapNhatNhanVien()
            Case "btnXoa"
                ShowConfirmMessageBox(MSG_BOX_CONFIRM_TITLE, MSG_BOX_CONFIRM_MESSAGE, "btnXoa")
        End Select
    End Sub

    Private Sub CapNhatNhanVien()
        Throw New NotImplementedException()
    End Sub

    Private Sub ThemNhanVien()
        Dim newTk As New TaiKhoan() With {
            .TaiKhoan = tbTaiKhoan.Text,
            .MatKhau = HashPwd(tbMatKhau.Text),
            .IsXoa = False
        }
        Dim isMan As Boolean = rbNam.Checked = True

        Dim newNv As New NhanVien() With {
            .Ten = tbTen.Text,
            .DiaChi = tbDiaChi.Text,
            .GioiTinh = isMan,
            .DienThoai = tbDienThoai.Text,
            .IsXoa = False,
            .TaiKhoan = newTk
        }
        nhanVienController.XulyThemTaiKhoan(newTk, newNv)
    End Sub

    Public Sub BindingListToGridView(list As List(Of NhanVien)) Implements INhanVienView.BindingListToGridView
        dgvNhanVien.DataSource = Nothing

        bsNhanVien.DataSource = list

        dgvNhanVien.DataSource = bsNhanVien

        ConfigureGridView()
    End Sub

    Public Sub BindingToTextBox(taikhoan As TaiKhoan) Implements INhanVienView.BindingToTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ConfigureGridView() Implements INhanVienView.ConfigureGridView
        dgvNhanVien.Columns("Ma").Visible = False
        dgvNhanVien.Columns("DiaChi").Visible = False


        ' Set custom header text for columns
        dgvNhanVien.Columns("TaiKhoan").HeaderText = "Tài khoản"
        dgvNhanVien.Columns("Ten").HeaderText = "Tên"
        dgvNhanVien.Columns("DienThoai").HeaderText = "Điện thoại"
        dgvNhanVien.Columns("GioiTinh").HeaderText = "Là nam"
        dgvNhanVien.Columns("IsXoa").HeaderText = "Đã nghỉ"
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
        AddHandler btnXoa.Click, AddressOf OnButtonClick
    End Sub

    Private Sub FormNhanVien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nhanVienController = INhanVienControllerImpl.Instance
        nhanVienController.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Private Sub tbTuKhoa_TextChanged(sender As Object, e As EventArgs) Handles tbTuKhoa.TextChanged

    End Sub

    Private Sub cbIsXoa_CheckedChanged(sender As Object, e As EventArgs) Handles cbIsXoa.CheckedChanged

    End Sub
End Class