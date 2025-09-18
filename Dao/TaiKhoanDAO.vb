Imports System.Data.OleDb

Public Class TaiKhoanDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveTaiKhoan(ByVal tkToSave As List(Of TaiKhoan)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each tk In tkToSave
                    If tk.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertTaiKhoan(tk, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateTaiKhoan(tk, conn, transaction)
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

    Private Shared Sub InsertTaiKhoan(ByVal tk As TaiKhoan, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO TaiKhoan (tk_tai_khoan, tk_mat_khau, tk_xoa)
                            VALUES (?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pTk", tk.TaiKhoan)
            cmd.Parameters.AddWithValue("pMk", tk.MatKhau)
            cmd.Parameters.AddWithValue("pXoa", tk.IsXoa)
            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            tk.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Shared Sub UpdateTaiKhoan(ByVal tk As TaiKhoan, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE TaiKhoan SET tk_mat_khau = ?, tk_xoa = ? WHERE nv_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pMk", tk.MatKhau)
            cmd.Parameters.AddWithValue("pXoa", tk.IsXoa)
            cmd.Parameters.AddWithValue("pMa", tk.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
