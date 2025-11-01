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
        dtPicker.CustomFormat = DATETIME_FORMAT
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
        dgvPhieuNhap.DataSource = Nothing

        BindingSource_PhieuNhap.DataSource = list

        dgvPhieuNhap.DataSource = BindingSource_PhieuNhap

        ConfigureNhapHangGridView()
    End Sub

    Public Sub BindingPhieuNhapToTextBox(khuVuc As KhuVuc) Implements INhapHangView.BindingPhieuNhapToTextBox
        Throw New NotImplementedException()
    End Sub

    Public Sub ConfigureNhapHangGridView() Implements INhapHangView.ConfigureNhapHangGridView
        Throw New NotImplementedException()
    End Sub

    Public Sub LoadData() Implements INhapHangView.LoadData
        nhapHangController = INhapHangControllerImpl.Instance
        nhapHangController.Init(Me)
        nhanvienController = INhanVienControllerImpl.Instance
        userSession = nhanvienController.UserSession
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

    End Sub

    Private Sub dgvPhieuNhap_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvPhieuNhap.CellFormatting

    End Sub

    Private Sub dgvSanPham_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSanPham.CellClick

    End Sub

    Private Sub dgvSanPham_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvSanPham.CellFormatting

    End Sub

End Class