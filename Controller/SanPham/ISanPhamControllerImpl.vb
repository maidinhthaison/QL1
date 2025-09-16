Public Class ISanPhamControllerImpl
    Implements ISanPhamController

    Private Shared _instance As ISanPhamControllerImpl

    Private View As ISanPhamView

    Private listSanPham As List(Of SanPham)

    Private listLoaiSanPham As List(Of LoaiSanPham)

    Private selectedIndex As Integer

    Private loaiSanphamDAO As LoaiSanPhamDao

    Private sanPhamDAO As SanPhamDAO

    Private Sub New()
        listSanPham = New List(Of SanPham)
        listLoaiSanPham = New List(Of LoaiSanPham)
        loaiSanphamDAO = New LoaiSanPhamDao()
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

    Public Property Items() As List(Of SanPham)
        Get
            Return listSanPham
        End Get
        Set(ByVal value As List(Of SanPham))
            listSanPham = value
        End Set
    End Property

    Public Property LoaiSPItems() As List(Of LoaiSanPham)
        Get
            Return listLoaiSanPham
        End Get
        Set(ByVal value As List(Of LoaiSanPham))
            listLoaiSanPham = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As ISanPhamControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New ISanPhamControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal loaiSpView As ISanPhamView)
        View = loaiSpView
        View.SetController(Me)
    End Sub

    Public Sub XulyThemSanPham(addedSanPham As SanPham) Implements ISanPhamController.XulyThemSanPham
        listSanPham.Add(addedSanPham)
        View.BindingListToGridView(listSanPham)
        Dim spToSave As New List(Of SanPham) From {addedSanPham}
        If sanPhamDAO.SaveSanPham(spToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "sản phẩm"))
            View.ClearFields()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "sản phẩm"))
        End If
    End Sub

    Public Sub XulyXoaSanPham() Implements ISanPhamController.XulyXoaSanPham
        Dim sp As SanPham = listSanPham(selectedIndex)
        sp.IsXoa = True
        Dim spToSave As New List(Of SanPham) From {sp}
        If sanPhamDAO.SaveSanPham(spToSave) Then
            View.BindingListToGridView(listSanPham)
            View.ClearFields()
            View.ShowMessageBox(EnumMessageBox.Infomation, StringResources.MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_DELETE_SUCCESS_MESSAGE, "sản phẩm"))
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, StringResources.MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_DELETE_ERROR_MESSAGE, "sản phẩm"))
        End If
    End Sub

    Public Sub XulyCapNhatSanPham(editedSanPham As SanPham) Implements ISanPhamController.XulyCapNhatSanPham
        Dim selectedSp As SanPham = listSanPham(selectedIndex)
        selectedSp.Ten = editedSanPham.Ten
        selectedSp.Mota = editedSanPham.Mota
        selectedSp.Loai = editedSanPham.Loai
        selectedSp.Gia = editedSanPham.Gia
        Dim spToSave As New List(Of SanPham) From {selectedSp}
        If sanPhamDAO.SaveSanPham(spToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "sản phẩm"))
            View.BindingListToGridView(listSanPham)
            View.BindingToTextBox(selectedSp)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "sản phẩm"))
        End If
    End Sub

    Public Sub XulyLoadData() Implements ISanPhamController.XulyLoadData
        listSanPham = sanPhamDAO.LoadSanPham()
        View.BindingListToGridView(listSanPham)
    End Sub

    Public Sub XulyTimKiemSanPham(tukhoa As String) Implements ISanPhamController.XulyTimKiemSanPham
        Throw New NotImplementedException()
    End Sub

    Public Sub XulyLoadLoaiSanPham() Implements ISanPhamController.XulyLoadLoaiSanPham
        Dim list As List(Of LoaiSanPham) = loaiSanphamDAO.LoadLoaiSanPham()
        View.BindingListToComBoBoxLoaiSp(list)
    End Sub

    Public Sub XulyGetLoaiSanPhamByNhaCCKhuVuc() Implements ISanPhamController.XulyGetLoaiSanPhamByNhaCCKhuVuc
        listLoaiSanPham = loaiSanphamDAO.GetKhuVucNccByLoaiSP()
    End Sub
End Class
