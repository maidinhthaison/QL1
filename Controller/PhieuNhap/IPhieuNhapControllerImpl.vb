Public Class IPhieuNhapControllerImpl
    Implements IPhieuNhapController

    Private Shared _instance As IPhieuNhapControllerImpl

    Private View As INhapHangView

    Private listPhieuNhap As List(Of PhieuNhap)

    Private selectedIndex As Integer

    Private phieuNhapDAO As PhieuNhapDAO

    Private Sub New()
        listPhieuNhap = New List(Of PhieuNhap)
        phieuNhapDAO = New PhieuNhapDAO()

    End Sub


    Public Property GetSelectedIndex() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property GetListPhieuNhap() As List(Of PhieuNhap)
        Get
            Return listPhieuNhap
        End Get
        Set(ByVal value As List(Of PhieuNhap))
            listPhieuNhap = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IPhieuNhapControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IPhieuNhapControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal nhapHangView As INhapHangView)
        View = nhapHangView
    End Sub

    ''Functions

    Public Sub Xuly_GetPhieuNhap_By_ChiNhanh(chiNhanhMa As Integer) Implements IPhieuNhapController.Xuly_GetPhieuNhap_By_ChiNhanh
        Throw New NotImplementedException()
    End Sub
End Class
