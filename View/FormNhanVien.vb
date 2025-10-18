Public Class FormNhanVien
    Dim DsForm As New List(Of Form)

    Private nhanViewController As INhanVienControllerImpl

    Private tkMa As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsForm = New List(Of Form)()

    End Sub
    Public Sub New(tkMa As Integer)
        InitializeComponent()
        Me.tkMa = tkMa

        nhanViewController = INhanVienControllerImpl.Instance
        nhanViewController.XulyGetThongTinUser(Me.tkMa)

    End Sub
    Function TimForm(type As Type)
        For Each frm As Form In DsForm
            If frm.GetType() Is type Then
                If frm.IsDisposed Then
                    DsForm.Remove(frm)
                    frm = Nothing

                End If
                Return frm
            End If
        Next
        Return Nothing
    End Function
    Private Sub BanHangMenuItem_Click(sender As Object, e As EventArgs) Handles BanHangMenuItem.Click

        Dim frm As Form = TimForm(GetType(FormQLDonHang))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmBanHang As New FormQLDonHang()
        frmBanHang.MdiParent = Me
        frmBanHang.WindowState = FormWindowState.Maximized
        frmBanHang.Show()
        DsForm.Add(frmBanHang)
    End Sub


    Private Sub DSSanPhamMenuItem_Click(sender As Object, e As EventArgs) Handles DSSanPhamMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormQLSanPham))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmSanPham As New FormQLSanPham()
        frmSanPham.MdiParent = Me
        frmSanPham.WindowState = FormWindowState.Maximized
        frmSanPham.Show()
        DsForm.Add(frmSanPham)
    End Sub


    Private Sub KhachHangMenuItem_Click(sender As Object, e As EventArgs) Handles KhachHangMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormQLKhachHang))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmKhachHang As New FormQLKhachHang()
        frmKhachHang.MdiParent = Me
        frmKhachHang.WindowState = FormWindowState.Maximized
        frmKhachHang.Show()
        DsForm.Add(frmKhachHang)
    End Sub


    Private Sub ThongKeMenuItem_Click(sender As Object, e As EventArgs) Handles ThongKeMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormThongKe))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim ThongKeForm As New FormThongKe()
        ThongKeForm.MdiParent = Me
        ThongKeForm.WindowState = FormWindowState.Maximized
        ThongKeForm.Show()
        DsForm.Add(ThongKeForm)
    End Sub

    Private Sub ThongTinMenuItem_Click(sender As Object, e As EventArgs) Handles ThongTinMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormThongTin))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim ThongTinForm As New FormThongTin()
        ThongTinForm.MdiParent = Me
        ThongTinForm.WindowState = FormWindowState.Maximized
        ThongTinForm.Show()
        DsForm.Add(ThongTinForm)
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class