Public Class ILoaiSanPhamControllerImpl
    Implements ILoaiSanPhamController

    Private Shared _instance As ILoaiSanPhamControllerImpl

    Private View As ILoaiSanPhamView

    Private listLoaiSp As List(Of LoaiSanPham)

    Private selectedIndex As Integer

    Private loaiSanphamDAO As LoaiSanPhamDao

    Private khuVucDao As KhuVucDao

    Private nhaCungCapDao As NhaCungCapDAO

    Private Sub New()
        listLoaiSp = New List(Of LoaiSanPham)
        loaiSanphamDAO = New LoaiSanPhamDao()
        khuVucDao = New KhuVucDao()
        nhaCungCapDao = New NhaCungCapDAO()
    End Sub


    Public Property Index() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property Items() As List(Of LoaiSanPham)
        Get
            Return listLoaiSp
        End Get
        Set(ByVal value As List(Of LoaiSanPham))
            listLoaiSp = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As ILoaiSanPhamControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New ILoaiSanPhamControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal loaiSpView As ILoaiSanPhamView)
        View = loaiSpView
        View.SetController(Me)
    End Sub


    Public Sub XulyXoaLoaiSanPham() Implements ILoaiSanPhamController.XulyXoaLoaiSanPham
        Throw New NotImplementedException()
    End Sub



    Public Sub XulyLoadData() Implements ILoaiSanPhamController.XulyLoadData
        listLoaiSp = loaiSanphamDAO.LoadLoaiSanPham()
        View.BindingListToGridView(listLoaiSp)
    End Sub

    Public Sub XulyComboboxKhuVuc() Implements ILoaiSanPhamController.XulyComboboxKhuVuc
        Dim list As List(Of KhuVuc) = khuVucDao.LoadKhuVuc()
        View.BindingListToComBoBoxKhuVuc(list)
    End Sub

    Public Sub XulyComboboxNhaCungCap() Implements ILoaiSanPhamController.XulyComboboxNhaCungCap
        Dim list As List(Of NhaCungCap) = nhaCungCapDao.LoadNhaCungCap()
        View.BindingListToComBoBoxNhaCungCap(list)
    End Sub

    Public Sub XulyThemLoaiSanPham(addedLoaiSp As LoaiSanPham) Implements ILoaiSanPhamController.XulyThemLoaiSanPham
        listLoaiSp.Add(addedLoaiSp)
        View.BindingListToGridView(listLoaiSp)
        Dim loaiSpToSave As New List(Of LoaiSanPham) From {addedLoaiSp}
        If loaiSanphamDAO.SaveLoaiSanPham(loaiSpToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", "Thêm Loại sản phẩm thành công!")
            View.ClearFields()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Thêm Loại sản phẩm thất bại!")
        End If
    End Sub

    Public Sub XulyCapNhatLoaiSanPham(editedLoaiSp As LoaiSanPham) Implements ILoaiSanPhamController.XulyCapNhatLoaiSanPham
        Dim selectedLoaiSp As LoaiSanPham = listLoaiSp(selectedIndex)
        selectedLoaiSp.Ten = editedLoaiSp.Ten
        selectedLoaiSp.Mota = editedLoaiSp.Mota
        selectedLoaiSp.Code = editedLoaiSp.Code
        selectedLoaiSp.NhaCc = editedLoaiSp.NhaCc
        selectedLoaiSp.Kv = editedLoaiSp.Kv
        Dim loaiSpToSave As New List(Of LoaiSanPham) From {selectedLoaiSp}
        If loaiSanphamDAO.SaveLoaiSanPham(loaiSpToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, "Thông báo", "Cập nhật loại sản phẩm thành công!")
            View.BindingListToGridView(listLoaiSp)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Cập nhật loại sản phẩm thất bại!")
        End If
    End Sub
End Class
