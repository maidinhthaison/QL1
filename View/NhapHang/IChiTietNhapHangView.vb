Public Interface IChiTietNhapHangView
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)
    Sub ClearFields()

    Sub BindingListSanPhamToGridView(listSp As List(Of SanPham))
    Sub RefreshSanPhamGridView(listSp As List(Of SanPham))
    Sub ConfigureSanPhamGridView()

    Sub BindingSanPhamToTextBox(sanPham As SanPham)

    Sub BindingListCTPhieuNhapToGridView(list As List(Of ChiTietPhieuNhap))
    Sub BindingGiaTienToLabel(tongKhuyenMai As Double, tongTien As Double, tongThanhTien As Double)
End Interface
