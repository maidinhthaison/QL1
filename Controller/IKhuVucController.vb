Public Interface IKhuVucController
    Sub ProcessLoadData()

    Sub ProcessCapNhatKhuVuc(Index As Integer, Code As String,
                             Ten As String, Mota As String)

    Sub ProcessThemKhuVuc()

    Sub ProcessXoaKhuVuc()

    Sub ProcessClickOnCellGridView(index As Integer)
End Interface
