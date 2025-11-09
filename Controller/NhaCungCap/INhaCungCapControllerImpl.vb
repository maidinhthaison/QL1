Public Class INhaCungCapControllerImpl
    Implements INhaCungCapController

    Private Shared _instance As INhaCungCapControllerImpl

    Private View As INhaCungCapView

    Private listNhaCc As List(Of NhaCungCap)

    Private selectedIndex As Integer

    Private nhaCcDAO As NhaCungCapDAO

    ''
    Private listSanPham As List(Of SanPham)
    Private sanPhamDAO As SanPhamDAO
    Private Sub New()
        listNhaCc = New List(Of NhaCungCap)
        nhaCcDAO = New NhaCungCapDAO()
        ''
        listSanPham = New List(Of SanPham)
        sanPhamDAO = New SanPhamDAO()
    End Sub


    Public Property Index() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property Items() As List(Of NhaCungCap)
        Get
            Return listNhaCc
        End Get
        Set(ByVal value As List(Of NhaCungCap))
            listNhaCc = value
        End Set
    End Property

    Public Property ListSP() As List(Of SanPham)
        Get
            Return listSanPham
        End Get
        Set(ByVal value As List(Of SanPham))
            listSanPham = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As INhaCungCapControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New INhaCungCapControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal nhaCungCapView As INhaCungCapView)
        View = nhaCungCapView
    End Sub

    Public Sub XulyThemNhaCungCap(addedNhacc As NhaCungCap) Implements INhaCungCapController.XulyThemNhaCungCap
        listNhaCc.Add(addedNhacc)
        View.BindingListToGridView(listNhaCc)
        Dim nhaCcToSave As New List(Of NhaCungCap) From {addedNhacc}
        If nhaCcDAO.SaveNhaCungCap(nhaCcToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, StringResources.MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "Nhà cung cấp"))
            View.ClearFields()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, StringResources.MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "Nhà cung cấp"))
        End If
    End Sub

    Public Sub XulyXoaNhaCungCap() Implements INhaCungCapController.XulyXoaNhaCungCap
        Dim ncc As NhaCungCap = listNhaCc(selectedIndex)
        ncc.IsXoa = True
        Dim nhaCcToSave As New List(Of NhaCungCap) From {ncc}
        If nhaCcDAO.SaveNhaCungCap(nhaCcToSave) Then
            View.BindingListToGridView(listNhaCc)
            View.ShowMessageBox(EnumMessageBox.Infomation, StringResources.MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_DELETE_SUCCESS_MESSAGE, "Nhà cung cấp"))
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, StringResources.MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_DELETE_ERROR_MESSAGE, "Nhà cung cấp"))
        End If
    End Sub

    Public Sub XulyCapNhatNhaCungCap(editedNhacc As NhaCungCap) Implements INhaCungCapController.XulyCapNhatNhaCungCap
        Dim selectedNhaCc As NhaCungCap = listNhaCc(selectedIndex)
        selectedNhaCc.Ten = editedNhacc.Ten
        selectedNhaCc.DiaChi = editedNhacc.DiaChi
        selectedNhaCc.DienThoai = editedNhacc.DienThoai
        selectedNhaCc.GhiChu = editedNhacc.GhiChu
        selectedNhaCc.Code = editedNhacc.Code
        Dim nhaCcToSave As New List(Of NhaCungCap) From {selectedNhaCc}
        If nhaCcDAO.SaveNhaCungCap(nhaCcToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, StringResources.MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "Nhà cung cấp"))
            View.BindingListToGridView(listNhaCc)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, StringResources.MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "Nhà cung cấp"))
        End If
    End Sub

    Public Sub XulyLoadData() Implements INhaCungCapController.XulyLoadData
        listNhaCc = nhaCcDAO.LoadNhaCungCap()
        View.BindingListToGridView(listNhaCc)
    End Sub

    Public Sub XuLyGetSanPhamByNhaCungCap(nhaCCMa As Integer) Implements INhaCungCapController.XuLyGetSanPhamByNhaCungCap
        listSanPham = sanPhamDAO.GetSP_With_LoaiSP_By_NhaCC(nhaCCMa)
        View.BindingListSanPhamToGridView(listSanPham)
    End Sub
End Class
