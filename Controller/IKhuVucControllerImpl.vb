Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.Intrinsics.X86

Public Class IKhuVucControllerImpl
    Implements IKhuVucController

    Private Shared _instance As IKhuVucControllerImpl

    Private View As IKhuVucView

    Private dataTable As DataTable

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

    Public Property DTable() As DataTable
        Get
            Return dataTable
        End Get
        Set(ByVal value As DataTable)
            dataTable = value
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


    Public Sub ProcessLoadData() Implements IKhuVucController.ProcessLoadData
        Dim sql As String = "SELECT * FROM KhuVuc WHERE kv_xoa = false"
        dataTable = XL_DuLieu.DocDuLieu(sql)
        listKhuVuc = DataMapper.MapDataTableToList(dataTable)
        View.BindingToGridView(listKhuVuc)
        'View.BindingToGridView(dataTable)
    End Sub


    Public Sub ProcessCapNhatKhuVuc(Index As Integer, Code As String,
                             Ten As String, Mota As String) Implements IKhuVucController.ProcessCapNhatKhuVuc
        Dim row As DataRow = dataTable.Rows(2)
        MessageBox.Show($"{row("kv_mo_ta").ToString()}- {dataTable.Rows.Count}", "asd")
        XL_DuLieu.GhiDuLieu("KhuVuc", dataTable)
        Dim updatedItem = Items(Index)
        updatedItem.Code = Code
        updatedItem.Ten = Ten
        updatedItem.Mota = Mota
        View.BindingToGridView(Items)
        'View.BindingToGridView(dataTable)
        View.ShowMessageBox("Thông báo", "Cập nhật thành công")
    End Sub

    Public Sub ProcessThemKhuVuc() Implements IKhuVucController.ProcessThemKhuVuc
        XL_DuLieu.GhiDuLieu("KhuVuc", dataTable)
        View.ShowMessageBox("Thông báo", "Thêm Khu vực mới thành công")
    End Sub

    Public Sub ProcessXoaKhuVuc() Implements IKhuVucController.ProcessXoaKhuVuc
        XL_DuLieu.GhiDuLieu("KhuVuc", dataTable)
        View.ShowMessageBox("Thông báo", "Xoá khu vực thành công")
    End Sub

    Public Sub ProcessClickOnCellGridView(index As Integer) Implements IKhuVucController.ProcessClickOnCellGridView
        Dim kv = Items(index)
        View.BindingToTextBox(kv)
    End Sub
End Class
