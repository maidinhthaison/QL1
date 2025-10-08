Imports System.Runtime.Intrinsics.X86

Public Class IKhachHangControllerImpl
    Implements IKhachHangController
    Private Shared _instance As IKhachHangControllerImpl

    Private listKhachHang As List(Of KhachHang)

    Private khachHangDao As KhachHangDAO

    Private _selectedKh As KhachHang

    Private Sub New()
        listKhachHang = New List(Of KhachHang)
        khachHangDao = New KhachHangDAO()

    End Sub


    Public Property GetSelectedKH() As KhachHang
        Get
            Return _selectedKh
        End Get
        Set(ByVal value As KhachHang)
            _selectedKh = value
        End Set
    End Property

    Public Property ListKh() As List(Of KhachHang)
        Get
            Return listKhachHang
        End Get
        Set(ByVal value As List(Of KhachHang))
            listKhachHang = value
        End Set
    End Property
    Public Shared ReadOnly Property Instance() As IKhachHangControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IKhachHangControllerImpl()
            End If
            Return _instance
        End Get
    End Property


    Public Sub XulyTimKiemKhachHangBySDT(sdt As String) Implements IKhachHangController.XulyTimKiemKhachHangBySDT
        Dim result = khachHangDao.TimKiemKHBySDT(sdt)
        listKhachHang.Clear()
        listKhachHang.AddRange(result.ToArray)
    End Sub

    Public Function XulySaveKhachHang(khachHang As KhachHang) As Boolean Implements IKhachHangController.XulySaveKhachHang
        Dim updatedKhachHang As New List(Of KhachHang) From {khachHang}
        Return khachHangDao.SaveKhachHang(updatedKhachHang)
    End Function
End Class
