Public Class ISanPhamControllerImpl
    Implements ISanPhamController

    Private Shared _instance As ISanPhamControllerImpl

    Private View As ISanPhamView

    Private listSanPham As List(Of SanPham)

    Private selectedIndex As Integer

    Private loaiSanphamDAO As LoaiSanPhamDao

    Private sanPhamDAO As SanPhamDAO

    Private Sub New()
        listSanPham = New List(Of SanPham)
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
        Throw New NotImplementedException()
    End Sub

    Public Sub XulyXoaSanPham() Implements ISanPhamController.XulyXoaSanPham
        Throw New NotImplementedException()
    End Sub

    Public Sub XulyCapNhatSanPham(editedSanPham As SanPham) Implements ISanPhamController.XulyCapNhatSanPham
        Throw New NotImplementedException()
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
End Class
