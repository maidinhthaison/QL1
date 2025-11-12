Public Class IHoaDonControllerImpl
    Implements IHoaDonController

    Private Shared _instance As IHoaDonControllerImpl

    Private chiTietDonHangView As IChiTietDonHangView

    Private listChiTietDonHang As List(Of ChiTietDonHang)

    Private hoaDonDAO As HoaDonDAO
    Private Sub New()
        listChiTietDonHang = New List(Of ChiTietDonHang)
        hoaDonDAO = New HoaDonDAO()

    End Sub

    Public Sub Init(ByVal view As IChiTietDonHangView)
        chiTietDonHangView = view
    End Sub

    Public Sub XuLyXuatHoaDon(listCTDH As List(Of ChiTietDonHang)) Implements IHoaDonController.XuLyXuatHoaDon
        Throw New NotImplementedException()
    End Sub

    Public Shared ReadOnly Property Instance() As IHoaDonControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IHoaDonControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Property GetChiTietHoaDon() As List(Of ChiTietDonHang)
        Get
            Return listChiTietDonHang
        End Get
        Set(ByVal value As List(Of ChiTietDonHang))
            listChiTietDonHang = value
        End Set
    End Property

End Class
