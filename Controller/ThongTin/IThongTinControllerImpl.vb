Public Class IThongTinControllerImpl
    Implements IThongTinController

    Private Shared _instance As IThongTinControllerImpl

    Private View As IThongTinView

    Private listChiNhanh As List(Of ChiNhanh)

    Private chiNhanhDao As ChiNhanhDAO

    Private Sub New()
        listChiNhanh = New List(Of ChiNhanh)
        chiNhanhDao = New ChiNhanhDAO()

    End Sub

    Public Property Items() As List(Of ChiNhanh)
        Get
            Return listChiNhanh
        End Get
        Set(ByVal value As List(Of ChiNhanh))
            listChiNhanh = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IThongTinControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IThongTinControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal thongTinView As IThongTinView)
        View = thongTinView
    End Sub

    Public Sub XulyLoadChiNhanh() Implements IThongTinController.XulyLoadChiNhanh
        listChiNhanh = chiNhanhDao.GetAllChiNhanh()
        View.BindingChiNhanhToListView(listChiNhanh)
    End Sub
End Class
