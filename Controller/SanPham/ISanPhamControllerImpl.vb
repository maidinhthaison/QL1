Imports System.Text.RegularExpressions

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

        Dim spToSave As New List(Of SanPham) From {addedSanPham}
        If sanPhamDAO.SaveSanPham(spToSave) Then
            listSanPham.Add(addedSanPham)
            View.BindingListToGridView(listSanPham)

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
            View.BindingTolabelTextBox(selectedSp)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "sản phẩm"))
        End If
    End Sub

    Public Sub XulyLoadData() Implements ISanPhamController.XulyLoadData
        listSanPham = sanPhamDAO.GetSP_By_LoaiSP_NhaCC_KhuVuc()
        View.BindingListToGridView(listSanPham)
    End Sub

    Public Function XulyTimKiemSanPham(tukhoa As String) As List(Of SanPham) Implements ISanPhamController.XulyTimKiemSanPham
        If String.IsNullOrWhiteSpace(tukhoa) Then
            Return listSanPham
        Else
            Dim searchResult As List(Of SanPham) = listSanPham.Where(
                Function(sp) sp.Ten.ToLower().Contains(tukhoa.ToLower()) OrElse
                        sp.Gia.ToString().Contains(tukhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Code.ToString().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.LoaiSp_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.NCC_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.LoaiSp_ChiNhanh.Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Sp_SoLuong.ToString.Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Kv_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase)
               ).ToList()
            Return searchResult
        End If
    End Function

    Public Sub XulyLoadLoaiSanPham() Implements ISanPhamController.XulyLoadLoaiSanPham
        Dim list As List(Of LoaiSanPham) = loaiSanphamDAO.LoadLoaiSanPham()
        View.BindingListToComBoBoxLoaiSp(list)
    End Sub

    Public Function Xuly_Get_KhuVucNCC_By_LoaiSP_Ma(loaiSp As Integer) As List(Of LoaiSanPham) Implements ISanPhamController.Xuly_Get_KhuVucNCC_By_LoaiSP_Ma
        Dim khuVuc_Ncc As List(Of LoaiSanPham) = loaiSanphamDAO.Get_KhuVucNCC_By_LoaiSP_Ma(loaiSp)
        Return khuVuc_Ncc
    End Function
End Class
