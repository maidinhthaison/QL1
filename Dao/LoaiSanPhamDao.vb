Imports System.Data.OleDb

Public Class LoaiSanPhamDao
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function LoadLoaiSanPham() As List(Of LoaiSanPham)
        Dim loaiSanPhamList As New List(Of LoaiSanPham)()
        Dim sql As String = "SELECT lsp_ma, lsp_ten, lsp_mo_ta, lsp_xoa, lsp_code, lsp_ncc, lsp_khu_vuc
                FROM LoaiSanPham WHERE lsp_xoa = False ORDER BY lsp_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim lsp As New LoaiSanPham() With {
                                .Ma = CInt(reader("lsp_ma")),
                                .Ten = CStr(reader("lsp_ten")),
                                .Mota = CStr(reader("lsp_mo_ta")),
                                .IsXoa = CBool(reader("lsp_xoa")),
                                .Code = CStr(reader("lsp_code")),
                                .NhaCc = CInt(reader("lsp_ncc")),
                                .Kv = CInt(reader("lsp_khu_vuc"))
                        }
                        loaiSanPhamList.Add(lsp)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return loaiSanPhamList
    End Function

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveLoaiSanPham(ByVal loaiSpToSave As List(Of LoaiSanPham)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each lsp In loaiSpToSave
                    If lsp.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertLoaiSanPham(lsp, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateLoaiSanPham(lsp, conn, transaction)
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

    Private Shared Sub InsertLoaiSanPham(ByVal lsp As LoaiSanPham, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO LoaiSanPham (lsp_ten, lsp_mo_ta, lsp_xoa, lsp_code,
                lsp_ncc, lsp_khu_vuc) VALUES (?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pTen", lsp.Ten)
            cmd.Parameters.AddWithValue("pMota", lsp.Mota)
            cmd.Parameters.AddWithValue("pXoa", lsp.IsXoa)
            cmd.Parameters.AddWithValue("pCode", lsp.Code)
            cmd.Parameters.AddWithValue("pNcc", lsp.NhaCc)
            cmd.Parameters.AddWithValue("pKv", lsp.Kv)
            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            lsp.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Shared Sub UpdateLoaiSanPham(ByVal lsp As LoaiSanPham, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE LoaiSanPham SET lsp_ten = ?, lsp_mo_ta = ?, lsp_xoa = ?, lsp_code = ?,
            lsp_ncc = ?, lsp_khu_vuc = ? WHERE lsp_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pTen", lsp.Ten)
            cmd.Parameters.AddWithValue("pMota", lsp.Mota)
            cmd.Parameters.AddWithValue("pXoa", lsp.IsXoa)
            cmd.Parameters.AddWithValue("pCode", lsp.Code)
            cmd.Parameters.AddWithValue("pNcc", lsp.NhaCc)
            cmd.Parameters.AddWithValue("pKv", lsp.Kv)
            cmd.Parameters.AddWithValue("pMa", lsp.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function GetKhuVucNccByLoaiSP() As List(Of LoaiSanPham)
        Dim loaiSanPhamList As New List(Of LoaiSanPham)()
        Dim sql As String = "SELECT lsp_ma, lsp_ten, lsp_mo_ta, lsp_xoa, lsp_code, lsp_ncc, lsp_khu_vuc,
                ncc.ncc_ma AS ncc_ma, ncc.ncc_ten AS ncc_ten, 
                kv.kv_ma AS kv_ma, kv.kv_ten AS kv_ten
                FROM (LoaiSanPham AS lsp
                INNER JOIN NhaCungCap AS ncc ON ncc.ncc_ma = lsp.lsp_ncc)
                INNER JOIN KhuVuc AS kv ON kv.kv_ma = lsp.lsp_khu_vuc
                WHERE lsp.lsp_xoa = False ORDER BY lsp.lsp_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim lsp As New LoaiSanPham() With {
                                .Ma = CInt(reader("lsp_ma")),
                                .Ten = CStr(reader("lsp_ten")),
                                .Mota = CStr(reader("lsp_mo_ta")),
                                .IsXoa = CBool(reader("lsp_xoa")),
                                .Code = CStr(reader("lsp_code")),
                                .NhaCc = CInt(reader("lsp_ncc")),
                                .Kv = CInt(reader("lsp_khu_vuc")),
                                .Ncc_Ma = CInt(reader("ncc_ma")),
                                .Kv_Ma = CInt(reader("kv_ma")),
                                .Ncc_Ten = CStr(reader("ncc_ten")),
                                .Kv_Ten = CStr(reader("kv_ten"))
                        }
                        loaiSanPhamList.Add(lsp)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return loaiSanPhamList
    End Function
End Class
