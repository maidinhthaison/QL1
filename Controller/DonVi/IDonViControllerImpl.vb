Public Class IDonViControllerImpl
    Implements IDonViController

    Private Shared _instance As IDonViControllerImpl

    Private listDonVi As List(Of DonVi)

    Private selectedIndex As Integer

    Private donViDao As DonViDAO

    Private Sub New()
        listDonVi = New List(Of DonVi)
        donViDao = New DonViDAO()

    End Sub

    Public Shared ReadOnly Property Instance() As IDonViControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IDonViControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Property GetSelectedIndex() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property GetListDonVi() As List(Of DonVi)
        Get
            Return listDonVi
        End Get
        Set(ByVal value As List(Of DonVi))
            listDonVi = value
        End Set
    End Property

    Public Sub XuLyGetAllDonVi() Implements IDonViController.XuLyGetAllDonVi
        listDonVi = donViDao.GetAllDonVi()
    End Sub
End Class
