Public Class IPhieuChiControllerImpl
    Implements IPhieuChiController

    Private Shared _instance As IPhieuChiControllerImpl

    Private View As IQuanLyPhieuChiView

    Private listPhieuChi As List(Of PhieuChi)

    Private selectedPhieuChiIndex As Integer

    Private phieuChiDao As PhieuChiDAO
    ''' <summary>
    ''' 
    ''' </summary>

    Private phieuChiLyDoDao As PhieuChiLyDoDAO

    Private listPhieuChiLyDo As List(Of PhieuChiLyDo)

    ''' <summary>
    ''' 
    ''' </summary>
    ''' 
    Private chiTietPhieuChiDao As ChiTietPhieuChiDAO

    Private listChiTietPhieuChi As List(Of ChiTietPhieuChi)

    Private selectedChiTietPhieuChiIndex As Integer

    Private Sub New()
        listPhieuChi = New List(Of PhieuChi)
        phieuChiDao = New PhieuChiDAO()

        listPhieuChiLyDo = New List(Of PhieuChiLyDo)
        phieuChiLyDoDao = New PhieuChiLyDoDAO()

        listChiTietPhieuChi = New List(Of ChiTietPhieuChi)
        chiTietPhieuChiDao = New ChiTietPhieuChiDAO()
    End Sub


    Public Property GetSelectedPhieuChiIndex() As Integer
        Get
            Return selectedPhieuChiIndex
        End Get
        Set(ByVal value As Integer)
            selectedPhieuChiIndex = value
        End Set
    End Property

    Public Property GetListPhieuChi() As List(Of PhieuChi)
        Get
            Return listPhieuChi
        End Get
        Set(ByVal value As List(Of PhieuChi))
            listPhieuChi = value
        End Set
    End Property

    Public Property GetListPhieuChiLyDo() As List(Of PhieuChiLyDo)
        Get
            Return listPhieuChiLyDo
        End Get
        Set(ByVal value As List(Of PhieuChiLyDo))
            listPhieuChiLyDo = value
        End Set
    End Property

    Public Property GetSelectedChiTietPhieuChiIndex() As Integer
        Get
            Return selectedChiTietPhieuChiIndex
        End Get
        Set(ByVal value As Integer)
            selectedChiTietPhieuChiIndex = value
        End Set
    End Property

    Public Property GetListChiTietPhieuChi() As List(Of ChiTietPhieuChi)
        Get
            Return listChiTietPhieuChi
        End Get
        Set(ByVal value As List(Of ChiTietPhieuChi))
            listChiTietPhieuChi = value
        End Set
    End Property

    Public Shared ReadOnly Property Instance() As IPhieuChiControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IPhieuChiControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal phieuChiView As IQuanLyPhieuChiView)
        View = phieuChiView
    End Sub

    Public Sub Xuly_TaoPhieuChi(phieuChi As PhieuChi) Implements IPhieuChiController.Xuly_TaoPhieuChi
        Dim newPhieuChi As New List(Of PhieuChi) From {phieuChi}
        If phieuChiDao.SavePhieuChi(newPhieuChi) = False Then
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "phiếu chi"))
        Else
            listPhieuChi.AddRange(newPhieuChi)
            View.BindingListPhieuChiToGridView(listPhieuChi)
        End If
    End Sub

    Public Sub Xuly_GetPhieuChi_By_ChiNhanh(chiNhanhMa As Integer) Implements IPhieuChiController.Xuly_GetPhieuChi_By_ChiNhanh
        listPhieuChi = phieuChiDao.GetAll_PhieuChi_By_ChiNhanh(chiNhanhMa)
        View.BindingListPhieuChiToGridView(listPhieuChi)
    End Sub

    Public Sub Xuly_GetChiTietPhieuChi_By_MaPhieuChi(phieuChiMa As Integer) Implements IPhieuChiController.Xuly_GetChiTietPhieuChi_By_MaPhieuChi
        Throw New NotImplementedException()
    End Sub

    Public Sub Xuly_LoadLyDo_To_Combobox() Implements IPhieuChiController.Xuly_LoadLyDo_To_Combobox
        listPhieuChiLyDo = phieuChiLyDoDao.GetAll_PhieuChiLyDo()
        View.BindingPhieuChiLyDoToCombobox(listPhieuChiLyDo)
    End Sub

    Public Sub Xuly_Save_CTPhieuChi(ctpc As ChiTietPhieuChi) Implements IPhieuChiController.Xuly_Save_CTPhieuChi
        Dim ctpcToSave As New List(Of ChiTietPhieuChi) From {ctpc}
        listChiTietPhieuChi.Add(ctpc)
        If chiTietPhieuChiDao.SaveChiTietPhieuChi(ctpcToSave) Then
            View.BindingListChiTietPhieuChiToGridView(listChiTietPhieuChi)
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "chi tiết phiếu chi"))
        End If
    End Sub
End Class
