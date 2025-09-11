Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.Intrinsics.X86

Public Class IKhuVucControllerImpl
    Implements IKhuVucController

    Private Shared _instance As IKhuVucControllerImpl

    Private View As IKhuVucView

    'Private dataTable As DataTable

    Private listKhuVuc As BindingList(Of KhuVuc)
    Private Sub New()
        listKhuVuc = New BindingList(Of KhuVuc)
    End Sub

    Public Property Items() As BindingList(Of KhuVuc)
        Get
            Return listKhuVuc
        End Get
        Set(ByVal value As BindingList(Of KhuVuc))
            listKhuVuc = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IKhuVucControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IKhuVucControllerImpl()
            End If
            Return _instance
        End Get
    End Property



    Public Sub Init(ByVal khuVucView As IKhuVucView)
        View = khuVucView
        View.SetController(Me)
    End Sub

    Public Function ProcessLoadData() As DataTable Implements IKhuVucController.ProcessLoadData
        Dim sql As String = "SELECT * FROM KhuVuc WHERE kv_xoa = false"
        Dim dataTable As DataTable = XL_DuLieu.DocDuLieu(sql)
        View.BindingToGridView(dataTable)
        Return dataTable
    End Function

    Public Sub ProcessCapNhatKhuVuc(dataTable As DataTable) Implements IKhuVucController.ProcessCapNhatKhuVuc
        XL_DuLieu.GhiDuLieu("KhuVuc", dataTable)
        View.ShowMessageBox("Thông báo", "Cập nhật khu vực thành công!")
    End Sub

    Public Sub ProcessThemKhuVuc(dataTable As DataTable) Implements IKhuVucController.ProcessThemKhuVuc
        XL_DuLieu.GhiDuLieu("KhuVuc", dataTable)
        View.ShowMessageBox("Thông báo", "Thêm Khu vực thành công!")
        View.ClearFields()
    End Sub

    Public Sub ProcessXoaKhuVuc(dataTable As DataTable) Implements IKhuVucController.ProcessXoaKhuVuc
        XL_DuLieu.GhiDuLieu("KhuVuc", dataTable)
        View.ShowMessageBox("Thông báo", "Xoá thành công!")
        View.ClearFields()
    End Sub
End Class
