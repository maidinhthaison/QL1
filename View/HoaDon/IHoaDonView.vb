Public Interface IHoaDonView
    Sub LoadData()

    Sub BindingListHoaDonToGridView(list As List(Of DonHang))

    Sub ConfigureHoaDonGridView()

    Sub RefreshHoaDonGridView(list As List(Of DonHang))

    Sub BindingHoaDonToLabel(donhang As DonHang)

    Sub BindingChitietDonHangToListView(listChiTietDonhang As List(Of ChiTietDonHang))

    Sub ResetModel()
End Interface
