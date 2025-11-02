Public Interface IQuanLyPhieuChiView
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)
    Sub BindingListPhieuChiToGridView(list As List(Of PhieuChi))

    Sub BindingPhieuChiToTextBox(phieuChi As PhieuChi)

    Sub ConfigurePhieuChiGridView()

    Sub RefreshPhieuChiGridView(list As List(Of PhieuChi))

    Sub BindingListChiTietPhieuChiToGridView(list As List(Of ChiTietPhieuChi))
    Sub ConfigureChiTietPhieuChiGridView()

    Sub RefreshChiTietPhieuChiGridView(list As List(Of ChiTietPhieuChi))

    Sub BindingPhieuChiLyDoToCombobox(list As List(Of PhieuChiLyDo))
End Interface
