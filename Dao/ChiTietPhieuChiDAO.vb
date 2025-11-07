Imports System.Data.OleDb

Public Class ChiTietPhieuChiDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveChiTietPhieuChi(ByVal ctpc As List(Of ChiTietPhieuChi)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each pn In ctpc
                    If pn.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertCTPhieuChi(pn, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateChiTietPhieuChi(pn, conn, transaction)
                    End If
                Next

                ' If all commands succeeded, commit the transaction
                transaction.Commit()
                Return True

            Catch ex As Exception
                ' An error occurred. Roll back all changes in the transaction.
                Console.WriteLine("Error saving data: " & ex.Message)
                Try
                    transaction?.Rollback()
                Catch rollbackEx As Exception
                    Console.WriteLine("Error during rollback: " & rollbackEx.Message)
                End Try
                Return False
            End Try
        End Using
    End Function

    ' --- Helper methods for Insert and Update ---

    Private Shared Sub InsertCTPhieuChi(ByVal pn As ChiTietPhieuChi, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO ChiTietPhieuChi (ctpc_so_tien, ctpc_xoa, ctpc_pc_ma, ctpc_lydo_ma, ctpc_ghi_chu)
                            VALUES (?, ? , ?, ? ,?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pSotien", pn.SoTien)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.Parameters.AddWithValue("ppcMa", pn.PhieuChiMa)
            cmd.Parameters.AddWithValue("pLydoMa", pn.LyDoMa)
            cmd.Parameters.AddWithValue("pGhichu", pn.GhiChu)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY;"
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            pn.Ma = newId

        End Using
    End Sub

    Private Shared Sub UpdateChiTietPhieuChi(ByVal pn As ChiTietPhieuChi, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE ChiTietPhieuChi SET ctpc_so_tien = ?, ctpc_xoa = ?, ctpc_lydo_ma = ?, ctpc_ghi_chu = ?  WHERE ctpc_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pSt", pn.SoTien)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.Parameters.AddWithValue("pLydo", pn.LyDoMa)
            cmd.Parameters.AddWithValue("pGhichu", pn.GhiChu)
            cmd.Parameters.AddWithValue("pMa", pn.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function GetAll_ChiTietPhieuChi() As List(Of ChiTietPhieuChi)
        Dim listCTPC As New List(Of ChiTietPhieuChi)()

        Dim sql As String = "SELECT ctpc_ma, ctpc_so_tien, ctpc_xoa, ctpc_pc_ma, ctpc_lydo_ma,
                            ctpc_ghi_chu 
                            FROM ChiTietPhieuChi AS ctpc
                            INNER JOIN PhieuChiLyDo AS pcld ON pcld.lydo_ma = ctpc.ctpc_lydo_ma
                            ORDER BY ctpc_ma DESC"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ctpc As New ChiTietPhieuChi() With {
                                .Ma = CInt(reader("ctpc_ma")),
                                .SoTien = CDbl(reader("ctpc_so_tien")),
                                .PhieuChiMa = CStr(reader("ctpc_pc_ma")),
                                .IsXoa = CStr(reader("ctpc_xoa")),
                                .LyDoMa = CStr(reader("ctpc_lydo_ma")),
                                .GhiChu = CStr(reader("ctpc_ghi_chu")),
                                .GetPhieuChiLyDo = New PhieuChiLyDo() With {
                                    .Code = CStr(reader("ctpc_xoa")),
                                    .Mota = CStr(reader("ctpc_xoa")),
                                    .Ma = CStr(reader("ctpc_xoa"))
                                }
                        }
                        listCTPC.Add(ctpc)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return listCTPC
    End Function
End Class
