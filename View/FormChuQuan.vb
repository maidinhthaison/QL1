Imports System.Runtime.Intrinsics

Public Class FormChuQuan

    Dim DsForm As New List(Of Form)

    Private nhanViewController As INhanVienControllerImpl

    Private tkMa As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DsForm = New List(Of Form)()
        Dim userSession = nhanViewController.UserSession
        If userSession IsNot Nothing Then
            MessageBox.Show($"Chào mừng {userSession.Ten} đã đăng nhập hệ thống lúc {DateTime.Now.ToString()}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim taiKhoan = userSession.TaiKhoan
            If taiKhoan.IsChuQuan Then
                Me.Text = $"Chủ quán: {nhanViewController.UserSession.Ten} đã đăng nhập lúc {DateTime.Now.ToString()}"
            Else
                Me.Text = $"Nhân viên: {nhanViewController.UserSession.Ten} đã đăng nhập lúc {DateTime.Now.ToString()}"
            End If
        End If


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

    Private Sub NhapHangMenuItem_Click(sender As Object, e As EventArgs) Handles NhapHangMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormQLNhapHang))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmNhapHang As New FormQLNhapHang()
        frmNhapHang.MdiParent = Me
        frmNhapHang.WindowState = FormWindowState.Maximized
        frmNhapHang.Show()
        DsForm.Add(frmNhapHang)
    End Sub

    Private Sub ThuChiMenuItem_Click(sender As Object, e As EventArgs) Handles ThuChiMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormQLThuChi))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmThuChi As New FormQLThuChi()
        frmThuChi.MdiParent = Me
        frmThuChi.WindowState = FormWindowState.Maximized
        frmThuChi.Show()
        DsForm.Add(frmThuChi)
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

    Private Sub NhaCCMenuItem_Click(sender As Object, e As EventArgs) Handles NhaCCMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormNhaCungCap))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmNCC As New FormNhaCungCap()
        frmNCC.MdiParent = Me
        frmNCC.WindowState = FormWindowState.Maximized
        frmNCC.Show()
        DsForm.Add(frmNCC)
    End Sub

    Private Sub LoaiSpMenuItem_Click(sender As Object, e As EventArgs) Handles LoaiSpMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormLoaiSanPham))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmLoaiSp As New FormLoaiSanPham()
        frmLoaiSp.MdiParent = Me
        frmLoaiSp.WindowState = FormWindowState.Maximized
        frmLoaiSp.Show()
        DsForm.Add(frmLoaiSp)
    End Sub

    Private Sub KhuVucMenuItem_Click(sender As Object, e As EventArgs) Handles KhuVucMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormKhuVuc))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmKV As New FormKhuVuc()
        frmKV.MdiParent = Me
        frmKV.WindowState = FormWindowState.Maximized
        frmKV.Show()
        DsForm.Add(frmKV)
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

    Private Sub NhanVienMenuItem_Click(sender As Object, e As EventArgs) Handles NhanVienMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormQLNhanVien))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim frmNhanVien As New FormQLNhanVien()
        frmNhanVien.MdiParent = Me
        frmNhanVien.WindowState = FormWindowState.Maximized
        frmNhanVien.Show()
        DsForm.Add(frmNhanVien)
    End Sub

    Private Sub ThongKeMenuItem_Click(sender As Object, e As EventArgs) Handles ThongKeMenuItem.Click
        Dim frm As Form = TimForm(GetType(FormNhanVienThongKe))
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim ThongKeForm As New FormNhanVienThongKe()
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
