Public Class IChiTietDHControllerImpl
    Implements IChiTietDHController
    Private Shared _instance As IChiTietDHControllerImpl

    Private View As IChiTietDonHangView

    Private listSanPham As List(Of SanPham)

    Private listChiTietPBH As List(Of ChiTietDonHang)

    Private selectedSanPhamIndex As Integer

    Private sanPhamDao As SanPhamDAO

    Private chiTietPhieuBanHangDao As ChiTietDonHangDAO

    Private donHangDao As DonHangDAO

    Private khachHangDao As KhachHangDAO
    Private Sub New()
        listSanPham = New List(Of SanPham)
        listChiTietPBH = New List(Of ChiTietDonHang)

        sanPhamDao = New SanPhamDAO()
        chiTietPhieuBanHangDao = New ChiTietDonHangDAO()
        donHangDao = New DonHangDAO()
        khachHangDao = New KhachHangDAO()
    End Sub


    Public Property Index() As Integer
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

    Public Sub XuLySaveChiTietDonHang(listChiTietDonHang As List(Of ChiTietDonHang), addedDonHang As DonHang) Implements IChiTietDHController.XuLySaveChiTietDonHang
        ' Them chi tiet don hang
        Dim tongSoLuong As Integer = 0
        Dim tongKhuyenMai As Double = 0
        Dim tongThanhTien As Double = 0

        For i As Integer = 0 To listChiTietDonHang.Count - 1
            Dim ctDH As ChiTietDonHang = listChiTietDonHang(i)
            ctDH.Pbh_Ma = addedDonHang.Ma
            tongSoLuong += ctDH.SoLuong
            tongKhuyenMai += ctDH.KhuyenMai
            tongThanhTien += ctDH.ThanhTien
        Next
        ' Cap nhat tong tien, tong khuyen mai, tong so luong vao don hang
        addedDonHang.TongSanPham = tongSoLuong
        addedDonHang.TongKhuyenMai = tongKhuyenMai
        addedDonHang.TongTien = tongThanhTien
        Dim khachHang = New List(Of KhachHang) From {addedDonHang.BanHangKhachHang}

        If chiTietPhieuBanHangDao.SaveChiTietDonHang(listChiTietDonHang) Then
            'Them khach hang
            If khachHangDao.SaveKhachHang(khachHang) Then
                MessageBox.Show($"{khachHang(0).Ma.ToString()} - {addedDonHang.BanHangKhachHang.Ma}")
                addedDonHang.BanHangKhachHang.Ma = khachHang(0).Ma
                Dim updatedDonHang = New List(Of DonHang) From {addedDonHang}
                If donHangDao.SaveDonHang(updatedDonHang) Then
                    View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "đơn hàng"))
                Else
                    View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "đơn hàng"))
                End If
            End If
        Else
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "đơn hàng"))
        End If

        'If chiTietPhieuBanHangDao.SaveChiTietDonHang(listChiTietDonHang) Then
        '    'Them khach hang
        '    addedDonHang.BanHangKhachHang.Ma = khachHang(0).Ma

        '    If khachHang(0).Ma = 0 Then
        '        khachHang(0).Ma = khachHangDao.GetNewMaKhachHang()
        '    End If
        '    If khachHangDao.SaveKhachHang(khachHang) Then
        '        'addedDonHang.BanHangKhachHang.Ma = khachHang(0).Ma
        '        Dim updatedDonHang = New List(Of DonHang) From {addedDonHang}
        '        If donHangDao.SaveDonHang(updatedDonHang) Then
        '            View.ShowMessageBox(EnumMessageBox.Infomation, MSG_BOX_INFO_TITLE, String.Format(MSG_BOX_INSERT_SUCCESS_MESSAGE, "đơn hàng"))
        '        Else
        '            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "đơn hàng"))
        '        End If
        '    End If

        'Else
        '    View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE, String.Format(MSG_BOX_INSERT_ERROR_MESSAGE, "đơn hàng"))
        'End If

    End Sub


End Class
