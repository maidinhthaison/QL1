Public Interface IChuQuanThongKeView
    Sub LoadData()

    Sub BindingListDoanhThuSanPhamToGridView(list As List(Of ChiTietDonHang))

    Sub SetDoanhThuLabel(fromDate As String, toDate As String, doanhThu As Double, tienVon As Double, khuyenMai As Double, loiNhuan As Double)


    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub SetDoanhThuSanPhamLabel(doanhThu As Double, tienVon As Double, khuyenMai As Double, loiNhuan As Double)
End Interface
