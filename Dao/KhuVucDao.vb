Imports System.Data.OleDb

Public Class KhuVucDao
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function LoadKhuVuc() As List(Of KhuVuc)
        Dim khuVucList As New List(Of KhuVuc)()
        Dim sql As String = "SELECT kv_ma, kv_ten, kv_code, kv_mo_ta, kv_xoa FROM KhuVuc WHERE kv_xoa = False ORDER BY kv_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim kv As New KhuVuc() With {
                                .Ma = CInt(reader("kv_ma")),
                                .Ten = CStr(reader("kv_ten")),
                                .Mota = CStr(reader("kv_mo_ta")),
                                .Code = CStr(reader("kv_code")),
                                .IsXoa = CBool(reader("kv_xoa"))
                        }
                        khuVucList.Add(kv)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return khuVucList
    End Function


    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveKhuVuc(ByVal khuVucToSave As List(Of KhuVuc)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each kv In khuVucToSave
                    If kv.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertKhuVuc(kv, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateKhuVuc(kv, conn, transaction)
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

    Private Sub InsertKhuVuc(ByVal kv As KhuVuc, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO KhuVuc (kv_ten, kv_mo_ta, kv_xoa, kv_code) VALUES (?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pTen", kv.Ten)
            cmd.Parameters.AddWithValue("pMota", kv.Mota)
            cmd.Parameters.AddWithValue("pIsXoa", kv.IsXoa)
            cmd.Parameters.AddWithValue("pCode", kv.Code)
            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            kv.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Sub UpdateKhuVuc(ByVal KV As KhuVuc, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE KhuVuc SET kv_ten = ?, kv_code = ?, kv_mo_ta = ?, kv_xoa = ? WHERE kv_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pTen", KV.Ten)
            cmd.Parameters.AddWithValue("pCode", KV.Code)
            cmd.Parameters.AddWithValue("pMota", KV.Mota)
            cmd.Parameters.AddWithValue("pXoa", KV.IsXoa)
            cmd.Parameters.AddWithValue("pMa", KV.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
