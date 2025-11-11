Public Interface INhanVienThongKeView
    Sub LoadData()

    Sub BindingListDoanhThuSanPhamOfNhanVienToGridView(list As List(Of ChiTietDonHang))

    Sub SetDoanhThuLabel(doanhThu As Double)


    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

End Interface
