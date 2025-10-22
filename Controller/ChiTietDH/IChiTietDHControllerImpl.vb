Public Class IChiTietDHControllerImpl
    Implements IChiTietDHController
    Private Shared _instance As IChiTietDHControllerImpl

    Private View As IChiTietDonHangView

    ''' <summary>
    ''' 
    ''' </summary>
    Private sanPhamDao As SanPhamDAO
    Private listSanPham As List(Of SanPham)
    Private selectedSanPhamIndex As Integer
    ''' <summary>
    ''' DAO ChiTietPhieuBanHang
    ''' </summary>
    Private chiTietPhieuBanHangDao As ChiTietDonHangDAO
    Private listChiTietPBH As List(Of ChiTietDonHang)
    ''' <summary>
    ''' DAO DonHang
    ''' </summary>
    Private donHangDao As DonHangDAO

    Private Sub New()
        listSanPham = New List(Of SanPham)
        listChiTietPBH = New List(Of ChiTietDonHang)


        sanPhamDao = New SanPhamDAO()
        chiTietPhieuBanHangDao = New ChiTietDonHangDAO()
        donHangDao = New DonHangDAO()

    End Sub


    Public Property CurrentSPIndex() As Integer
        Get
            Return selectedSanPhamIndex
        End Get
        Set(ByVal value As Integer)
            selectedSanPhamIndex = value
        End Set
    End Property

    Public Property ListSp() As List(Of SanPham)
        Get
            Return listSanPham
        End Get
        Set(ByVal value As List(Of SanPham))
            listSanPham = value
        End Set
    End Property

    Public Property GetDSChiTietPbh() As List(Of ChiTietDonHang)
        Get
            Return listChiTietPBH
        End Get
        Set(ByVal value As List(Of ChiTietDonHang))
            listChiTietPBH = value
        End Set
    End Property


    Public Shared ReadOnly Property Instance() As IChiTietDHControllerImpl
        Get
            If _instance Is Nothing Then
                _instance = New IChiTietDHControllerImpl()
            End If
            Return _instance
        End Get
    End Property

    Public Sub Init(ByVal donHangView As IChiTietDonHangView)
        View = donHangView
        View.SetController(Me)
    End Sub

    Public Sub XuLyGetAllSanPham() Implements IChiTietDHController.XuLyGetAllSanPham
        listSanPham = sanPhamDao.GetSP_By_LoaiSP_NhaCC_KhuVuc()
        View.BindingListSanPhamToGridView(listSanPham)
    End Sub

    Public Sub XuLySaveChiTietDonHang(listChiTietDonHang As List(Of ChiTietDonHang), addedDonHang As DonHang, khachHang As KhachHang) Implements IChiTietDHController.XuLySaveChiTietDonHang
        ' Them chi tiet don hang
        Dim tongSoLuong As Integer = 0
        Dim tongKhuyenMai As Double = 0
        Dim tongTien As Double = 0
        Dim tongThanhTien As Double = 0

        For i As Integer = 0 To listChiTietDonHang.Count - 1
            Dim ctDH As ChiTietDonHang = listChiTietDonHang(i)
            ctDH.Pbh_Ma = addedDonHang.Ma
            tongSoLuong += ctDH.SoLuong
            tongKhuyenMai += ctDH.KhuyenMai
            tongTien += ctDH.Gia * ctDH.SoLuong
            tongThanhTien = tongTien - tongKhuyenMai
        Next

        addedDonHang.TongSanPham = tongSoLuong
        addedDonHang.TongKhuyenMai = tongKhuyenMai
        addedDonHang.TongTien = tongThanhTien

        If khachHang IsNot Nothing Then
            addedDonHang.BanHangKhachHang.Ma = khachHang.Ma
        End If
        ' Save chi tiet don hang
        If chiTietPhieuBanHangDao.SaveChiTietDonHang(listChiTietDonHang) Then
            Dim updatedDonHang = New List(Of DonHang) From {addedDonHang}
            ' Cap nhat lai don hang
            If donHangDao.SaveDonHang(updatedDonHang) Then
                View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_UPDATE_SUCCESS_MESSAGE, "đơn hàng"))
            Else
                View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_UPDATE_ERROR_MESSAGE, "đơn hàng"))
            End If
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "đơn hàng"))
        End If


    End Sub

    Public Sub XuLyGetAllSanPhamByChiNhanh(chiNhanhMa As Integer) Implements IChiTietDHController.XuLyGetAllSanPhamByChiNhanh
        MessageBox.Show(chiNhanhMa)
        listSanPham = sanPhamDao.GetSP_By_LoaiSP_NhaCC_KhuVuc_ChiNhanh(chiNhanhMa)
        View.BindingListSanPhamToGridView(listSanPham)
    End Sub

End Class
