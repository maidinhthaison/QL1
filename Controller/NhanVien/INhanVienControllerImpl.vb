Public Class INhanVienControllerImpl
    Implements INhanVienController

    Private Shared _instance As INhanVienControllerImpl

    Private View As INhanVienView

    Private listNhanVien As List(Of NhanVien)

    Private listTaiKhoan As List(Of TaiKhoan)

    Private selectedIndex As Integer

    Private nhanVienDao As NhanVienDAO

    Private taiKhoanDao As TaiKhoanDAO

    Private Sub New()
        listNhanVien = New List(Of NhanVien)
        listTaiKhoan = New List(Of TaiKhoan)
        nhanVienDao = New NhanVienDAO()
        taiKhoanDao = New TaiKhoanDAO()
    End Sub


    Public Property Index() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property Items() As List(Of NhanVien)
        Get
            Return listNhanVien
        End Get
        Set(ByVal value As List(Of NhanVien))
            listNhanVien = value
        End Set
    End Property

    Public Property TaiKhoanItems() As List(Of TaiKhoan)
        Get
            Return listTaiKhoan
        End Get
        Set(ByVal value As List(Of TaiKhoan))
            listTaiKhoan = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As INhanVienControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New INhanVienControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal nvView As INhanVienView)
        View = nvView
        View.SetController(Me)
    End Sub


    Public Sub XulyThemNhanVien(newNhanVien As NhanVien) Implements INhanVienController.XulyThemNhanVien
        listNhanVien.Add(newNhanVien)
        View.BindingListToGridView(listNhanVien)
        Dim nvToSave As New List(Of NhanVien) From {newNhanVien}
        If nhanVienDao.SaveNhanVien(nvToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "nhân viên"))
            View.ClearFields()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "nhân viên"))
        End If

    End Sub

    Public Sub XulyLoadData() Implements INhanVienController.XulyLoadData
        listNhanVien = nhanVienDao.Get_NV_By_MaTK()
        View.BindingListToGridView(listNhanVien)
    End Sub

    Public Sub XulyThemTaiKhoan(newTaiKhoan As TaiKhoan, newNhanVien As NhanVien) Implements INhanVienController.XulyThemTaiKhoan
        listTaiKhoan.Add(newTaiKhoan)
        Dim tkToSave As New List(Of TaiKhoan) From {newTaiKhoan}
        Dim result = taiKhoanDao.SaveTaiKhoan(tkToSave)
        If result Then
            XulyThemNhanVien(newNhanVien)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "tài khoản"))
        End If
    End Sub
End Class
