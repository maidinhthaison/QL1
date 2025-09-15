Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Runtime.Intrinsics.X86

Public Class IKhuVucControllerImpl
    Implements IKhuVucController

    Private Shared _instance As IKhuVucControllerImpl

    Private View As IKhuVucView

    Private listKhuVuc As List(Of KhuVuc)

    Private selectedIndex As Integer

    Private khuVucDao As KhuVucDao

    Private Sub New()
        listKhuVuc = New List(Of KhuVuc)
        khuVucDao = New KhuVucDao()

    End Sub


    Public Property Index() As Integer
        Get
            Return selectedIndex
        End Get
        Set(ByVal value As Integer)
            selectedIndex = value
        End Set
    End Property

    Public Property Items() As List(Of KhuVuc)
        Get
            Return listKhuVuc
        End Get
        Set(ByVal value As List(Of KhuVuc))
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

    Public Sub XulyThemKhuVuc(addedKhuVuc As KhuVuc) Implements IKhuVucController.XulyThemKhuVuc
        listKhuVuc.Add(addedKhuVuc)
        View.BindingListToGridView(listKhuVuc)
        Dim khuVucToSave As New List(Of KhuVuc) From {addedKhuVuc}
        If khuVucDao.SaveKhuVuc(khuVucToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "khu vực"))
            View.ClearFields()
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "khu vực"))
        End If
    End Sub


    Public Sub XulyLoadData() Implements IKhuVucController.XulyLoadData
        listKhuVuc = khuVucDao.LoadKhuVuc()
        View.BindingListToGridView(listKhuVuc)
    End Sub

    Public Sub XulyCapNhatKhuVuc(ten As String, mota As String, code As String) Implements IKhuVucController.XulyCapNhatKhuVuc
        Dim kv As KhuVuc = listKhuVuc(selectedIndex)
        kv.Ten = ten
        kv.Mota = mota
        kv.Code = code
        Dim khuVucToSave As New List(Of KhuVuc) From {kv}
        If khuVucDao.SaveKhuVuc(khuVucToSave) Then
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "khu vực"))
            View.ClearFields()
            View.BindingListToGridView(listKhuVuc)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE,
                                String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "khu vực"))
        End If
    End Sub

    Public Sub XulyXoaKhuVuc() Implements IKhuVucController.XulyXoaKhuVuc
        Dim kv As KhuVuc = listKhuVuc(selectedIndex)
        kv.IsXoa = True
        Dim khuVucToSave As New List(Of KhuVuc) From {kv}
        If khuVucDao.SaveKhuVuc(khuVucToSave) Then
            View.BindingListToGridView(listKhuVuc)
            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_DELETE_SUCCESS_MESSAGE, "khu vực"))
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_INFO_TITLE,
                                String.Format(MSG_BOX_DELETE_ERROR_MESSAGE, "khu vực"))
        End If
    End Sub
End Class
