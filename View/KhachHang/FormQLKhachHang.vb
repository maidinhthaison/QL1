Public Class FormQLKhachHang
    Implements IKhachHangView, IBaseForm

    Private khachHangController As IKhachHangControllerImpl

    Public Sub LoadData() Implements IKhachHangView.GetAllKhachHang
        khachHangController.XuLyGetAllKhachHang()
    End Sub

    Public Sub BindingListKhacHangToGridView(list As List(Of KhachHang)) Implements IKhachHangView.BindingListKhacHangToGridView
        dgvKhachHang.DataSource = Nothing

        bindingSourceKhachHang.DataSource = list

        dgvKhachHang.DataSource = bindingSourceKhachHang

        ConfigureKhachHangGridView()

    End Sub

    Public Sub ConfigureKhachHangGridView() Implements IKhachHangView.ConfigureKhachHangGridView
        dgvKhachHang.Columns("Ma").Visible = False
        ' Set custom header text for columns
        dgvKhachHang.Columns("Ten").HeaderText = "Tên KH"
        dgvKhachHang.Columns("DienThoai").HeaderText = "Số ĐT"
        dgvKhachHang.Columns("DiaChi").HeaderText = "Địa chỉ"
        dgvKhachHang.Columns("IsXoa").HeaderText = "Xóa?"

    End Sub


    Public Sub BindingKhachHangToTextBox(khachHang As KhachHang) Implements IKhachHangView.BindingKhachHangToTextBox
        tbTenKH.Text = khachHang.Ten
        lbCode.Text = khachHang.Code
        tbDienThoai.Text = khachHang.DienThoai
        rtbDiaChi.Text = khachHang.DiaChi
        cbXoa.Checked = khachHang.IsXoa
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnThem"
                ThemKhachHang()
            Case "btnCapNhat"
                CapNhatKhachHang()
        End Select
    End Sub


    Private Sub ThemKhachHang()
        Dim newKhuVuc As New KhachHang() With {
            .Code = Gen_12Chars_UUID(),
            .Ten = tbTenKH.Text.Trim.ToString,
            .DiaChi = rtbDiaChi.Text.Trim.ToString,
            .DienThoai = tbDienThoai.Text.Trim.ToString,
            .IsXoa = False
        }
        khachHangController.XulyThemKhachHang(newKhuVuc)

    End Sub


    Private Sub CapNhatKhachHang()

        If dgvKhachHang.SelectedCells.Count > 0 Then
            Dim edittedKhachHang As New KhachHang() With {
                .Ten = tbTenKH.Text.Trim.ToString,
                .DienThoai = tbDienThoai.Text.Trim.ToString,
                .DiaChi = rtbDiaChi.Text.Trim.ToString,
                .IsXoa = cbXoa.Checked
            }
            khachHangController.XulyCapNhatKhachHang(edittedKhachHang)
        End If
    End Sub

    'View
    Private Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnThem.Click, AddressOf OnButtonClick
        AddHandler btnCapNhat.Click, AddressOf OnButtonClick

    End Sub


    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IKhachHangView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

    Private Sub FormQLKhachHang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        khachHangController = IKhachHangControllerImpl.Instance
        khachHangController.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Private Sub dgvKhachHang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKhachHang.CellClick
        If e.RowIndex >= 0 Then
            khachHangController.Index = e.RowIndex
            Dim selectedRow As DataGridViewRow = dgvKhachHang.Rows(e.RowIndex)
            Dim selectedKhachHang As KhachHang = CType(selectedRow.DataBoundItem, KhachHang)
            If selectedKhachHang IsNot Nothing Then
                BindingKhachHangToTextBox(selectedKhachHang)
            End If
        End If
    End Sub
End Class