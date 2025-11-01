Public Class INhapHangControllerImpl
    Implements INhapHangController

    Private Shared _instance As INhapHangControllerImpl

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

    Public Shared ReadOnly Property Instance() As INhapHangControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New INhapHangControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal nhapHangView As INhapHangView)
        View = nhapHangView
    End Sub

    ''Functions

    Public Sub Xuly_GetPhieuNhap_By_ChiNhanh(chiNhanhMa As Integer) Implements INhapHangController.Xuly_GetPhieuNhap_By_ChiNhanh
        listPhieuNhap = phieuNhapDAO.GetAll_PhieuNhap_By_ChiNhanh(chiNhanhMa)
        View.BindingListPhieuNhapToGridView(listPhieuNhap)
    End Sub

    Public Sub Xuly_TaoPhieuNhap(phieuNhap As PhieuNhap) Implements INhapHangController.Xuly_TaoPhieuNhap

        Dim newPhieuNhap As New List(Of PhieuNhap) From {phieuNhap}
        If phieuNhapDAO.SavePhieuNhap(newPhieuNhap) Then
            View.GotoChiTietPhieuNhap(phieuNhap)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "phiếu nhập"))
        End If
    End Sub

    Public Sub Xuly_GetChiTietPhieuNhap_By_MaPhieuNhap(phieuNhapMa As Integer) Implements INhapHangController.Xuly_GetChiTietPhieuNhap_By_MaPhieuNhap
        Dim list As List(Of ChiTietPhieuNhap) = phieuNhapDAO.Get_ChiTietPhieuNhap_By_PhieuNhapMa(phieuNhapMa)
        View.BindingListChiTietPhieuNhapToGridView(list)
    End Sub
End Class
