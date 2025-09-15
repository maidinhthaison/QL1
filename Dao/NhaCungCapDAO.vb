Imports System.Data.OleDb

Public Class NhaCungCapDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function LoadNhaCungCap() As List(Of NhaCungCap)
        Dim nhaCungCapList As New List(Of NhaCungCap)()
        Dim sql As String = "SELECT ncc_ma, ncc_ten, ncc_diachi, ncc_dien_thoai, ncc_ghi_chu, ncc_xoa, ncc_code
                FROM NhaCungCap WHERE ncc_xoa = False ORDER BY ncc_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ncc As New NhaCungCap() With {
                                .Ma = CInt(reader("ncc_ma")),
                                .Ten = CStr(reader("ncc_ten")),
                                .DiaChi = CStr(reader("ncc_diachi")),
                                .DienThoai = CStr(reader("ncc_dien_thoai")),
                                .GhiChu = CStr(reader("ncc_ghi_chu")),
                                .IsXoa = CBool(reader("ncc_xoa")),
                                .Code = CStr(reader("ncc_code"))
                        }
                        nhaCungCapList.Add(ncc)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return nhaCungCapList
    End Function


    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveNhaCungCap(ByVal nhaCungCapToSave As List(Of NhaCungCap)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each ncc In nhaCungCapToSave
                    If ncc.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertNhaCungCap(ncc, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateNhaCungCap(ncc, conn, transaction)
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

    Private Sub InsertNhaCungCap(ByVal ncc As NhaCungCap, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO NhaCungCap (ncc_ten, ncc_diachi, ncc_dien_thoai,
                    ncc_ghi_chu, ncc_xoa, ncc_code) VALUES (?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pTen", ncc.Ten)
            cmd.Parameters.AddWithValue("pDiaChi", ncc.DiaChi)
            cmd.Parameters.AddWithValue("pDienThoai", ncc.DienThoai)
            cmd.Parameters.AddWithValue("pGhiChu", ncc.GhiChu)
            cmd.Parameters.AddWithValue("pXoa", ncc.IsXoa)
            cmd.Parameters.AddWithValue("pCode", ncc.Code)
            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            ncc.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Sub UpdateNhaCungCap(ByVal ncc As NhaCungCap, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE NhaCungCap SET ncc_ten = ?, ncc_diachi = ?, ncc_dien_thoai = ?, ncc_ghi_chu = ?,
            ncc_xoa = ?, ncc_code = ? WHERE ncc_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pTen", ncc.Ten)
            cmd.Parameters.AddWithValue("pDiaChi", ncc.DiaChi)
            cmd.Parameters.AddWithValue("pDienThoai", ncc.DienThoai)
            cmd.Parameters.AddWithValue("pGhiChu", ncc.GhiChu)
            cmd.Parameters.AddWithValue("pXoa", ncc.IsXoa)
            cmd.Parameters.AddWithValue("pCode", ncc.Code)
            cmd.Parameters.AddWithValue("pMa", ncc.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class
