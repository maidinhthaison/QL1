Public Interface IKhuVucController
    Function ProcessLoadData() As DataTable

    'Sub ProcessCapNhatKhuVuc(Index As Integer, Code As String,
    '                         Ten As String, Mota As String)

    Sub ProcessCapNhatKhuVuc(dataTable As DataTable)

    Sub ProcessThemKhuVuc(dataTable As DataTable)

    Sub ProcessXoaKhuVuc(dataTable As DataTable)

    'Sub ProcessClickOnCellGridView(index As Integer)
End Interface
