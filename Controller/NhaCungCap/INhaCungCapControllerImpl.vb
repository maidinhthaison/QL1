Public Class INhaCungCapControllerImpl
    Implements INhaCungCapController

    Private Shared _instance As INhaCungCapControllerImpl

    Private View As INhaCungCapView

    Private listNhaCc As List(Of NhaCungCap)

    Private selectedIndex As Integer

    Private nhaCcDAO As NhaCungCapDAO

    Private Sub New()
        listNhaCc = New List(Of NhaCungCap)
        nhaCcDAO = New NhaCungCapDAO()

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
        View.SetController(Me)
    End Sub

    Public Sub XulyThemNhaCungCap(addedNhacc As NhaCungCap) Implements INhaCungCapController.XulyThemNhaCungCap
        listNhaCc.Add(addedNhacc)
        View.BindingListToGridView(listNhaCc)
        Dim nhaCcToSave As New List(Of NhaCungCap) From {addedNhacc}
        If nhaCcDAO.SaveNhaCungCap(nhaCcToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", "Thêm Nhà cung cấp thành công!")
            View.ClearFields()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Thêm Nhà cung cấp thất bại!")
        End If
    End Sub

    Public Sub XulyXoaNhaCungCap() Implements INhaCungCapController.XulyXoaNhaCungCap
        Dim ncc As NhaCungCap = listNhaCc(selectedIndex)
        ncc.IsXoa = True
        Dim nhaCcToSave As New List(Of NhaCungCap) From {ncc}
        If nhaCcDAO.SaveNhaCungCap(nhaCcToSave) Then
            View.BindingListToGridView(listNhaCc)
            View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", "Xoá nhà cung cấp thành công!")
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Xoá nhà cung cấp thất bại!")
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
            View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", "Cập nhật khu vực thành công!")
            View.BindingListToGridView(listNhaCc)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Cập nhật khu vực thất bại!")
        End If
    End Sub

    Public Sub XulyLoadData() Implements INhaCungCapController.XulyLoadData
        listNhaCc = nhaCcDAO.LoadNhaCungCap()
        View.BindingListToGridView(listNhaCc)
    End Sub


End Class
