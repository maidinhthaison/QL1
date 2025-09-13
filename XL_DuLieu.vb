Imports System.Data.OleDb

Module XL_DuLieu

    Dim Chuoi_Ket_Noi = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    Public Function DocDuLieu(ByVal sql As String) As DataTable
        Dim kq As DataTable = New DataTable()
        Dim KetNoi As OleDbConnection = New OleDbConnection(Chuoi_Ket_Noi)
        Dim CauTruyVan As OleDbCommand = New OleDbCommand(sql, KetNoi)
        Dim DongBo As OleDbDataAdapter = New OleDbDataAdapter(CauTruyVan)
        DongBo.Fill(kq)
        Return kq
    End Function

    Public Function GhiDuLieu(ByVal TenBang As String, ByVal dt As DataTable) As Integer
        Dim kq As DataTable = New DataTable()
        Dim KetNoi As OleDbConnection = New OleDbConnection(Chuoi_Ket_Noi)
        Dim CauTruyVan As OleDbCommand = New OleDbCommand("Select * from " + TenBang, KetNoi)
        Dim DongBo As OleDbDataAdapter = New OleDbDataAdapter(CauTruyVan)
        Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(DongBo)

        AddHandler DongBo.RowUpdated, AddressOf CapNhatMaSo

        Return DongBo.Update(dt) 'Insert, Update, Delete
    End Function

    Private Sub CapNhatMaSo(ByVal sender As Object, ByVal e As OleDbRowUpdatedEventArgs)
        If e.StatementType = StatementType.Insert Then
            Dim KetNoi As OleDbConnection = e.Command.Connection
            Dim CauTruyVan As OleDbCommand = New OleDbCommand("Select @@IDENTITY", KetNoi)
            Dim MaSo As Integer = Integer.Parse(CauTruyVan.ExecuteScalar())
            e.Row(0) = MaSo
        End If
    End Sub

End Module
