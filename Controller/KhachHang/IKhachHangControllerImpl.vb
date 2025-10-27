Imports System.Runtime.Intrinsics.X86

Public Class IKhachHangControllerImpl
    Implements IKhachHangController
    Private Shared _instance As IKhachHangControllerImpl

    Private View As IKhachHangView

    Private listKhachHang As List(Of KhachHang)

    Private khachHangDao As KhachHangDAO

    Private _selectedKh As KhachHang

    Private _selectedIndex As Integer

    Private Sub New()
        listKhachHang = New List(Of KhachHang)
        khachHangDao = New KhachHangDAO()

    End Sub

    Public Sub Init(ByVal khachHangView As IKhachHangView)
        View = khachHangView
    End Sub


    Public Shared ReadOnly Property Instance() As IKhachHangControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IKhachHangControllerImpl()
            End If
            Return _instance
        End Get
    End Property

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

    Public Property Index() As Integer
        Get
            Return _selectedIndex
        End Get
        Set(ByVal value As Integer)
            _selectedIndex = value
        End Set
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

    Public Sub XuLyGetAllKhachHang() Implements IKhachHangController.XuLyGetAllKhachHang
        listKhachHang = khachHangDao.GetAllKhachHang
        View.BindingListKhacHangToGridView(listKhachHang)
    End Sub


    Public Sub XulyThemKhachHang(addKhachHang As KhachHang) Implements IKhachHangController.XulyThemKhachHang
        listKhachHang.Add(addKhachHang)
        View.BindingListKhacHangToGridView(listKhachHang)
        Dim khachHangToSave As New List(Of KhachHang) From {addKhachHang}
        If khachHangDao.SaveKhachHang(khachHangToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "khách hàng"))
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "khách hàng"))
        End If
    End Sub

    Public Sub XulyCapNhatKhachHang(editKhachHang As KhachHang) Implements IKhachHangController.XulyCapNhatKhachHang
        Dim kh As KhachHang = listKhachHang(_selectedIndex)
        kh.Ten = editKhachHang.Ten
        kh.DienThoai = editKhachHang.DienThoai
        kh.DiaChi = editKhachHang.DiaChi
        kh.IsXoa = editKhachHang.IsXoa

        Dim khachHangToSave As New List(Of KhachHang) From {kh}
        If khachHangDao.SaveKhachHang(khachHangToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "khách hàng"))
            View.BindingListKhacHangToGridView(listKhachHang)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "khách hàng"))
        End If
    End Sub
End Class
