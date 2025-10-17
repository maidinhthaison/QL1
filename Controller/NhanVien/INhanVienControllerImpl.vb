Public Class INhanVienControllerImpl
    Implements INhanVienController

    Private Shared _instance As INhanVienControllerImpl

    Private View As INhanVienView

    Private listNhanVien As List(Of NhanVien)

    Private listTaiKhoan As List(Of TaiKhoan)

    Private listChiNhanh As List(Of ChiNhanh)

    Private selectedIndex As Integer

    Private nhanVienDao As NhanVienDAO

    Private taiKhoanDao As TaiKhoanDAO

    Private chiNhanhDao As ChiNhanhDAO

    Private Sub New()
        listNhanVien = New List(Of NhanVien)
        listTaiKhoan = New List(Of TaiKhoan)
        listChiNhanh = New List(Of ChiNhanh)
        nhanVienDao = New NhanVienDAO()
        taiKhoanDao = New TaiKhoanDAO()
        chiNhanhDao = New ChiNhanhDAO()
    End Sub

    Private nhanVienSession As NhanVien

    Public Property UserSession() As NhanVien
        Get
            Return nhanVienSession
        End Get
        Set(ByVal value As NhanVien)
            nhanVienSession = value
        End Set
    End Property


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
        listNhanVien = nhanVienDao.Get_NV_By_MaTK_ChiNhanh()
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

    Public Function XulyTimKiemNhanVien(tukhoa As String) As List(Of NhanVien) Implements INhanVienController.XulyTimKiemNhanVien
        If String.IsNullOrWhiteSpace(tukhoa) Then
            Return listNhanVien
        Else
            Dim searchResult As List(Of NhanVien) = listNhanVien.Where(
                Function(nv) (
                        nv.Ten.Contains(tukhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        nv.TaiKhoan.TaiKhoan.ToString().Contains(tukhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        nv.DiaChi.ToString().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        nv.ChiNhanh.Ten.ToString().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        nv.DienThoai.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase))
               ).ToList()

            Return searchResult

        End If
    End Function

    Public Sub XulyCapNhatNhanVienTK(nvParam As NhanVien) Implements INhanVienController.XulyCapNhatNhanVienTK
        Dim selectedNv As NhanVien = listNhanVien(selectedIndex)
        ' Update TaiKhoan info
        Dim tk As TaiKhoan = selectedNv.TaiKhoan
        tk.Ma = selectedNv.TaiKhoan.Ma
        tk.TaiKhoan = nvParam.TaiKhoan.TaiKhoan
        tk.MatKhau = nvParam.TaiKhoan.MatKhau
        tk.IsXoa = nvParam.IsXoa

        Dim cn As ChiNhanh = selectedNv.ChiNhanh
        cn.Ma = nvParam.ChiNhanh.Ma
        cn.Ten = nvParam.ChiNhanh.Ten
        cn.DiaChi = nvParam.ChiNhanh.DiaChi

        selectedNv.Ten = nvParam.Ten
        selectedNv.DiaChi = nvParam.DiaChi
        selectedNv.IsXoa = nvParam.IsXoa
        selectedNv.DienThoai = nvParam.DienThoai
        selectedNv.TaiKhoan = tk
        selectedNv.ChiNhanh = cn

        Dim nvToSave As New List(Of NhanVien) From {selectedNv}
        If nhanVienDao.SaveNhanVien(nvToSave) Then
            Dim tkToSave As New List(Of TaiKhoan) From {tk}
            If taiKhoanDao.SaveTaiKhoan(tkToSave) Then
                View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "tài khoản"))
                View.BindingListToGridView(listNhanVien)
                View.BindingTolabelTextBox(nvParam)
            Else
                View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "tài khoản"))
            End If
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "nhân viên"))
        End If
    End Sub

    Public Sub XulyXoaNhanVien() Implements INhanVienController.XulyXoaNhanVien
        Dim nv As NhanVien = listNhanVien(selectedIndex)
        nv.IsXoa = True
        Dim nvToSave As New List(Of NhanVien) From {nv}
        If nhanVienDao.SaveNhanVien(nvToSave) Then
            Dim tk As TaiKhoan = nv.TaiKhoan
            tk.IsXoa = True
            Dim tkToSave As New List(Of TaiKhoan) From {tk}
            If taiKhoanDao.SaveTaiKhoan(tkToSave) Then
                View.BindingListToGridView(listNhanVien)
                View.ClearFields()
                View.ShowMessageBox(EnumMessageBox.Infomation, StringResources.MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_DELETE_SUCCESS_MESSAGE, "tài khoản"))
            Else
                View.ShowMessageBox(EnumMessageBox.Errors, StringResources.MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_DELETE_ERROR_MESSAGE, "tài khoản"))
            End If
        End If

    End Sub

    Public Sub XulyGetAllChiNhanh() Implements INhanVienController.XulyGetAllChiNhanh
        listChiNhanh = chiNhanhDao.GetAllChiNhanh()
        View.BindingChiNhanhCombobox(listChiNhanh)
    End Sub

    Public Function XulyGetThongTinUser(tkMa As Integer) As NhanVien Implements INhanVienController.XulyGetThongTinUser
        Dim listNv As List(Of NhanVien) = nhanVienDao.Get_NhanVien_ChiNhanh_TaiKhoan_By_MaTaiKhoan(tkMa)
        If listNv Is Nothing OrElse listNv.Count = 0 Then
            Return Nothing
        End If
        nhanVienSession = listNv(0)
        Return nhanVienSession

    End Function
End Class
