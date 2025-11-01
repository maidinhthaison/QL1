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
        'Throw New NotImplementedException()
    End Sub

    Public Sub Xuly_TaoPhieuNhap(phieuNhap As PhieuNhap) Implements INhapHangController.Xuly_TaoPhieuNhap

        View.GotoChiTietPhieuNhap(phieuNhap)
        'Dim newPhieuNhap As New List(Of PhieuNhap) From {phieuNhap}
        'If phieuNhapDAO.SavePhieuNhap(newPhieuNhap) Then
        '    View.GotoChiTietPhieuNhap(phieuNhap)
        'Else
        '    View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "phiếu nhập"))
        'End If
    End Sub
End Class
