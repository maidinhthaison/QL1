Public Class ILoaiSanPhamControllerImpl
    Implements ILoaiSanPhamController

    Private Shared _instance As ILoaiSanPhamControllerImpl

    Private View As ILoaiSanPhamView

    Private listLoaiSp As List(Of LoaiSanPham)

    Private selectedIndex As Integer

    Private loaiSanphamDAO As LoaiSanPhamDao

    Private khuVucDao As KhuVucDao

    Private nhaCungCapDao As NhaCungCapDAO

    Private chiNhanhDao As ChiNhanhDAO

    Private Sub New()
        listLoaiSp = New List(Of LoaiSanPham)
        loaiSanphamDAO = New LoaiSanPhamDao()
        khuVucDao = New KhuVucDao()
        nhaCungCapDao = New NhaCungCapDAO()
        chiNhanhDao = New ChiNhanhDAO()
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
        Dim lsp As LoaiSanPham = listLoaiSp(selectedIndex)
        lsp.IsXoa = True
        Dim loaiSpToSave As New List(Of LoaiSanPham) From {lsp}
        If loaiSanphamDAO.SaveLoaiSanPham(loaiSpToSave) Then
            View.BindingListToGridView(listLoaiSp)
            View.ClearFields()
            View.ShowMessageBox(EnumMessageBox.Infomation, StringResources.MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_DELETE_SUCCESS_MESSAGE, "loại sản phẩm"))
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, StringResources.MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_DELETE_ERROR_MESSAGE, "loại sản phẩm"))
        End If
    End Sub



    Public Sub XulyLoadData() Implements ILoaiSanPhamController.XulyLoadData
        listLoaiSp = loaiSanphamDAO.Get_LSP_BY_KhuVuc_ChiNhanh_NCC()
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
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "loại sản phẩm"))
            View.ClearFields()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "loại sản phẩm"))
        End If
    End Sub

    Public Sub XulyCapNhatLoaiSanPham(editedLoaiSp As LoaiSanPham) Implements ILoaiSanPhamController.XulyCapNhatLoaiSanPham
        Dim selectedLoaiSp As LoaiSanPham = listLoaiSp(selectedIndex)
        selectedLoaiSp.Ten = editedLoaiSp.Ten
        selectedLoaiSp.Mota = editedLoaiSp.Mota
        selectedLoaiSp.Lsp_Kv = editedLoaiSp.Lsp_Kv
        selectedLoaiSp.Lsp_Ncc = editedLoaiSp.Lsp_Ncc
        selectedLoaiSp.Lsp_Kv_Ma = editedLoaiSp.Lsp_Kv_Ma
        selectedLoaiSp.Lsp_Ncc_Ma = editedLoaiSp.Lsp_Ncc_Ma
        selectedLoaiSp.Lsp_So_Luong = editedLoaiSp.Lsp_So_Luong
        selectedLoaiSp.Lsp_Chi_Nhanh_Ma = editedLoaiSp.Lsp_Chi_Nhanh_Ma
        Dim loaiSpToSave As New List(Of LoaiSanPham) From {selectedLoaiSp}
        If loaiSanphamDAO.SaveLoaiSanPham(loaiSpToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "loại sản phẩm"))
            View.BindingListToGridView(listLoaiSp)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "loại sản phẩm"))
        End If
    End Sub

    Public Sub XulyComboboxChiNhanh() Implements ILoaiSanPhamController.XulyComboboxChiNhanh
        Dim list As List(Of ChiNhanh) = chiNhanhDao.GetAllChiNhanh()
        View.BindingListToComBoBoxChiNhanh(list)
    End Sub

    Public Function XulyTimKiemLoaiSanPham(tuKhoa As String) As List(Of LoaiSanPham) Implements ILoaiSanPhamController.XulyTimKiemLoaiSanPham
        If String.IsNullOrWhiteSpace(tuKhoa) Then
            Return listLoaiSp
        Else
            Dim searchResult As List(Of LoaiSanPham) = listLoaiSp.Where(
                Function(lsp) lsp.Ten.ToLower().Contains(tuKhoa.ToLower()) OrElse
                        lsp.Mota.ToString().Contains(tuKhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        lsp.Code.ToString().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        lsp.Lsp_ChiNhanh.Ten.ToLower().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        lsp.Lsp_Ncc.Ten.ToLower().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        lsp.Lsp_So_Luong.ToString().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        lsp.Lsp_Kv.Ten.ToLower().Contains(tuKhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase)
               ).ToList()
            Return searchResult
        End If
    End Function
End Class
