Imports System.Data.OleDb

Public Class PhieuChiLyDoDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SavePhieuChi_LyDo(ByVal phieuChiLyDoToSave As List(Of PhieuChiLyDo)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each pn In phieuChiLyDoToSave
                    If pn.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertPhieuChiLyDo(pn, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdatePhieuChiLyDo(pn, conn, transaction)
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

    Private Shared Sub InsertPhieuChiLyDo(ByVal pn As PhieuChiLyDo, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO PhieuChi_LyDo (ly_code, lydo_mota)
                            VALUES (?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pCode", pn.Code)
            cmd.Parameters.AddWithValue("pMota", pn.Mota)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY;"
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            pn.Ma = newId

        End Using
    End Sub

    Private Shared Sub UpdatePhieuChiLyDo(ByVal pn As PhieuChiLyDo, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE PhieuChi SET lydo_mota = ? WHERE lydo_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pMota", pn.Mota)
            cmd.Parameters.AddWithValue("pMa", pn.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function GetAll_PhieuChiLyDo() As List(Of PhieuChiLyDo)
        Dim phieuChiLyDo As New List(Of PhieuChiLyDo)()

        Dim sql As String = "SELECT * FROM PhieuChi_LyDo"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim pn As New PhieuChiLyDo() With {
                                .Ma = CInt(reader("lydo_ma")),
                                .Code = CStr(reader("lydo_code")),
                                .Mota = CStr(reader("lydo_mota"))
                        }
                        phieuChiLyDo.Add(pn)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return phieuChiLyDo
    End Function
End Class
