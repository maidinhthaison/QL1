Public Class IDangNhapControllerImpl
    Implements IDangNhapController

    Private Shared _instance As IDangNhapControllerImpl

    Private View As IDangNhapView

    Private taiKhoanDao As TaiKhoanDAO

    Private Sub New()

        taiKhoanDao = New TaiKhoanDAO()

    End Sub


    Public Shared ReadOnly Property Instance() As IDangNhapControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IDangNhapControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal dangNhapView As IDangNhapView)
        View = dangNhapView
        View.SetController(Me)
    End Sub

    Public Sub XuLyDangNhap(tenDangNhap As String, plainTextPassword As String) Implements IDangNhapController.XuLyDangNhap

        Dim taiKhoan As List(Of TaiKhoan) = taiKhoanDao.DangNhap(tenDangNhap)
        If taiKhoan.Count = 0 Then
            View.ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Tài khoản không tồn tại! - Liên hệ chủ quán để mở lại")

            Return
        ElseIf taiKhoan.Count = 1 Then
            Dim tk As TaiKhoan = taiKhoan(0)
            Dim hashedPwd As String = tk.MatKhau
            If VerifyPassword(plainTextPassword, hashedPwd) Then
                ' Login successful
                View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", "Đăng nhập thành công!")
                View.GotoMainScreen(tk.Ma)
            Else
                ' Invalid password
                Dim dangNhapSai As Integer = tk.SoLanDangNhapSai
                dangNhapSai += 1
                If dangNhapSai < 5 Then

                    tk.SoLanDangNhapSai = dangNhapSai
                    Dim tkToSave As New List(Of TaiKhoan) From {tk}
                    taiKhoanDao.SaveTaiKhoan(tkToSave)
                    View.ShowMessageBox(EnumMessageBox.Errors, "Thông báo", $"Sai mật khẩu! Bạn còn {5 - dangNhapSai} lần thử")

                Else
                    tk.SoLanDangNhapSai = dangNhapSai
                    tk.IsXoa = True
                    Dim tkToSave As New List(Of TaiKhoan) From {tk}
                    taiKhoanDao.SaveTaiKhoan(tkToSave)
                    View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", $"Bạn bị khóa tài khoản vì nhập sai {dangNhapSai} lần. Liên hệ chủ quán để mở lại")
                End If
            End If
        End If
    End Sub
End Class
