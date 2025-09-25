Public Class IDonHangControllerImpl
    Implements IDonHangController
    Private Shared _instance As IDonHangControllerImpl

    Private View As ITaoDonHangView

    Private listSanPham As List(Of SanPham)

    Private selectedSanPhamIndex As Integer

    Private sanPhamDao As SanPhamDAO

    Private Sub New()
        listSanPham = New List(Of SanPham)
        sanPhamDao = New SanPhamDAO()
    End Sub


    Public Property Index() As Integer
        Get
            Return selectedSanPhamIndex
        End Get
        Set(ByVal value As Integer)
            selectedSanPhamIndex = value
        End Set
    End Property


    Public Shared ReadOnly Property Instance() As IDonHangControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IDonHangControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal donHangView As ITaoDonHangView)
        View = donHangView
        View.SetController(Me)
    End Sub

    Public Sub XuLyGetAllSanPham() Implements IDonHangController.XuLyGetAllSanPham
        listSanPham = sanPhamDao.GetSP_By_LoaiSP_NhaCC_KhuVuc()
        View.BindingListSanPhamToGridView(listSanPham)
    End Sub
End Class
