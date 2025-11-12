Imports System.IO
Imports MigraDoc.DocumentObjectModel
Imports MigraDoc.DocumentObjectModel.Tables
Imports MigraDoc.Rendering

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
    Private selectedDonHangIndex As Integer
    ''' <summary>
    ''' DAO DonHang
    ''' </summary>
    Private donHangDao As DonHangDAO

    Private pdfHoaDonPath As String
    Private Sub New()
        listSanPham = New List(Of SanPham)
        listChiTietPBH = New List(Of ChiTietDonHang)

        sanPhamDao = New SanPhamDAO()
        chiTietPhieuBanHangDao = New ChiTietDonHangDAO()
        donHangDao = New DonHangDAO()

    End Sub

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

    '' Properties
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

    Public Property CurrentDonHangIndex() As Integer
        Get
            Return selectedDonHangIndex
        End Get
        Set(ByVal value As Integer)
            selectedDonHangIndex = value
        End Set
    End Property

    Public Property GetHoaDonFilePath() As String
        Get
            Return pdfHoaDonPath
        End Get
        Set(ByVal value As String)
            pdfHoaDonPath = value
        End Set
    End Property
    '' <summary>
    ''' Methods
    ''</summary>

    Public Sub XuLySaveChiTietDonHang(listChiTietDonHang As List(Of ChiTietDonHang), addedDonHang As DonHang, khachHang As KhachHang) Implements IChiTietDHController.XuLySaveChiTietDonHang
        ' Them chi tiet don hang
        Dim tongSoLuong As Integer = 0
        Dim tongKhuyenMai As Double = 0
        Dim tongTien As Double = 0
        Dim thanhTien As Double = 0
        For i As Integer = 0 To listChiTietDonHang.Count - 1
            Dim ctDH As ChiTietDonHang = listChiTietDonHang(i)
            ctDH.Pbh_Ma = addedDonHang.Ma
            tongSoLuong += ctDH.SoLuong
            tongKhuyenMai += ctDH.KhuyenMai
            tongTien += Double.Parse(ctDH.Gia) * Double.Parse(ctDH.SoLuong)
            thanhTien += ctDH.ThanhTien
        Next

        addedDonHang.TongSanPham = tongSoLuong
        addedDonHang.TongKhuyenMai = tongKhuyenMai
        addedDonHang.TongTien = tongTien
        addedDonHang.ThanhTien = thanhTien

        If khachHang IsNot Nothing Then
            addedDonHang.KhachHangMa = khachHang.Ma
            addedDonHang.BanHangKhachHang.Ma = khachHang.Ma
        End If
        MessageBox.Show($"{addedDonHang.ToString}", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
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
        listSanPham = sanPhamDao.GetSP_By_LoaiSP_NhaCC_KhuVuc_ChiNhanh(chiNhanhMa)
        View.BindingListSanPhamToGridView(listSanPham)
    End Sub

    Public Function XulyTimKiemSanPham(tukhoa As String) As List(Of SanPham) Implements IChiTietDHController.XulyTimKiemSanPham
        If String.IsNullOrWhiteSpace(tukhoa) Then
            Return listSanPham
        Else
            Dim searchResult As List(Of SanPham) = listSanPham.Where(
                Function(sp) sp.Ten.ToLower().Contains(tukhoa.ToLower()) OrElse
                        sp.Gia.ToString().Contains(tukhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.GiaNhap.ToString().Contains(tukhoa, StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Code.ToString().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.LoaiSp_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.NCC_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.LoaiSp_ChiNhanh.Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Sp_SoLuong.ToString.Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Mota.Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Sp_DonVi.Ten.Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase) OrElse
                        sp.Kv_Ten.ToLower().Contains(tukhoa.ToLower(), StringComparison.CurrentCultureIgnoreCase)
               ).ToList()
            Return searchResult
        End If
    End Function


    Public Sub InHoaDon(pdfPath As String)
        Try
            'Send the PDF to the default printer
            Dim psi As New ProcessStartInfo
            psi.FileName = pdfPath
            psi.Verb = "Print" ' This is the command to print
            psi.UseShellExecute = True
            Process.Start(psi)

        Catch ex As Exception
            View.ShowMessageBox(EnumMessageBox.Errors, MSG_BOX_ERROR_TITLE,
                                "Cần cài đặt trình đọc PDF mặc định (như Adobe Reader hoặc Edge)." & ex.Message)

        End Try
    End Sub

    Public Function XuLyXuatHoaDon(items As List(Of ChiTietDonHang), donHang As DonHang, khachHang As KhachHang) As String Implements IChiTietDHController.XuLyXuatHoaDon
        ' 1. Create a new PDF document
        Dim document As New Document()
        document.Info.Title = "Hóa Đơn"
        Dim section As Section = document.AddSection()

        ' 2. Add Header
        section.AddParagraph("HÓA ĐƠN MUA HÀNG", "Heading5")
        section.AddParagraph("Khách Hàng: " & khachHang.Ten, "Heading3")
        section.AddParagraph("Điện thoại: " & khachHang.DienThoai, "Heading3")
        section.AddParagraph("Ngày mua: " & donHang.Ngay.ToString(Constant.DATETIME_FORMAT))
        section.AddParagraph() ' Blank line

        ' 3. Create the table for the items
        Dim table As New Table()
        table.Borders.Width = 0.75
        table.AddColumn(Unit.FromCentimeter(5))
        table.AddColumn(Unit.FromCentimeter(1))
        table.AddColumn(Unit.FromCentimeter(2))
        table.AddColumn(Unit.FromCentimeter(3))
        table.AddColumn(Unit.FromCentimeter(3))
        table.AddColumn(Unit.FromCentimeter(3))

        ' 4. Add Table Header
        Dim headerRow As Row = table.AddRow()
        headerRow.Cells(0).AddParagraph("Sản phẩm")
        headerRow.Cells(1).AddParagraph("SL")
        headerRow.Cells(2).AddParagraph("Đơn giá")
        headerRow.Cells(3).AddParagraph("Tổng tiền")
        headerRow.Cells(4).AddParagraph("Khuyến mãi")
        headerRow.Cells(5).AddParagraph("Thành tiền")
        headerRow.Format.Font.Bold = True

        ' 5. Add items from the List Object
        Dim totalAmount As Decimal = 0
        For Each item In items
            Dim dataRow As Row = table.AddRow()
            dataRow.Cells(0).AddParagraph(item.SanPhamInfo.Ten)
            dataRow.Cells(1).AddParagraph(item.SoLuong)
            dataRow.Cells(2).AddParagraph(CurrencyFormat(item.Gia))
            dataRow.Cells(3).AddParagraph(CurrencyFormat(item.TongTien))
            dataRow.Cells(4).AddParagraph(CurrencyFormat(item.KhuyenMai))
            dataRow.Cells(5).AddParagraph(CurrencyFormat(item.ThanhTien))
            totalAmount += item.ThanhTien
        Next

        section.Add(table)
        section.AddParagraph()

        ' 6. Add Totals
        section.AddParagraph("Tổng hóa đơn: " & CurrencyFormat(totalAmount), "Heading3")

        ' 7. Save the PDF
        Dim renderer As New PdfDocumentRenderer(True)
        renderer.Document = document
        renderer.RenderDocument()

        Dim desktop As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim pdfFilePath As String = Path.Combine(desktop, $"HoaDon-{donHang.Code}.pdf")

        'Dim pdfFilePath As String = Path.Combine(Path.GetTempPath(), $"HoaDon-{donHang.Code}.pdf")
        renderer.PdfDocument.Save(pdfFilePath)

        ' 8. Show the PDF file
        Dim psi As New ProcessStartInfo
        psi.FileName = pdfFilePath
        psi.UseShellExecute = True
        Process.Start(psi)

        If pdfFilePath IsNot Nothing Then
            GetHoaDonFilePath = pdfFilePath
        End If

        ' 9. Return the path
        Return pdfFilePath
    End Function
End Class
