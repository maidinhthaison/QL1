Imports System.Data.OleDb

Public Class KhachHangDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function GetAllKhachHang() As List(Of KhachHang)
        Dim khachHangList As New List(Of KhachHang)()
        Dim sql As String = "SELECT * FROM KhachHang WHERE kh_xoa = False ORDER BY kh_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim kh As New KhachHang() With {
                                .Ma = CInt(reader("kh_ma")),
                                .Code = CStr(reader("kh_code")),
                                .Ten = CStr(reader("kh_ten")),
                                .DienThoai = CStr(reader("kh_dien_thoai")),
                                .DiaChi = CStr(reader("kh_dia_chi")),
                                .IsXoa = CBool(reader("kh_xoa"))
                        }
                        khachHangList.Add(kh)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return khachHangList
    End Function


    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveKhachHang(ByVal khachHangToSave As List(Of KhachHang)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each kh In khachHangToSave
                    If kh.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertKhachHang(kh, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateKhachHang(kh, conn, transaction)
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

    Private Sub InsertKhachHang(ByVal kh As KhachHang, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO KhachHang (kh_code, kh_ten, kh_dien_thoai, kh_dia_chi, kh_xoa) VALUES (?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pCode", kh.Code)
            cmd.Parameters.AddWithValue("pTen", kh.Ten)
            cmd.Parameters.AddWithValue("pDt", kh.DienThoai)
            cmd.Parameters.AddWithValue("pDc", kh.DiaChi)
            cmd.Parameters.AddWithValue("pXoa", kh.IsXoa)

            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY;"
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            kh.Ma = newId
        End Using
    End Sub

    Private Sub UpdateKhachHang(ByVal Kh As KhachHang, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE KhachHang SET kh_ten = ?, kh_dien_thoai = ?, kh_dia_chi = ?, kh_xoa = ? WHERE kh_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pTen", Kh.Ten)
            cmd.Parameters.AddWithValue("pDt", Kh.DienThoai)
            cmd.Parameters.AddWithValue("pDc", Kh.DiaChi)
            cmd.Parameters.AddWithValue("pXoa", Kh.IsXoa)
            cmd.Parameters.AddWithValue("pMa", Kh.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function TimKiemKHBySDT(sdt As String) As List(Of KhachHang)
        Dim khachHangList As New List(Of KhachHang)()
        Dim sql As String = "SELECT kh_ma, kh_ten, kh_dia_chi, kh_dien_thoai, kh_xoa, kh_code 
            FROM KhachHang 
            WHERE kh_dien_thoai = ? AND kh_xoa = ?"
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    cmd.Parameters.AddWithValue("pDt", sdt)
                    cmd.Parameters.AddWithValue("pXoa", False)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim kh As New KhachHang() With {
                                .Ma = CInt(reader("kh_ma")),
                                .Code = CStr(reader("kh_code")),
                                .Ten = CStr(reader("kh_ten")),
                                .DienThoai = CStr(reader("kh_dien_thoai")),
                                .DiaChi = CStr(reader("kh_dia_chi")),
                                .IsXoa = CBool(reader("kh_xoa"))
                        }
                        khachHangList.Add(kh)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return khachHangList
    End Function

    Public Function TimKiemKH(tukhoa As String) As List(Of KhachHang)
        Dim khachHangList As New List(Of KhachHang)()
        Dim sql As String = "SELECT * FROM KhachHang WHERE kh_code LIKE ? OR kh_ten LIKE ? OR kh_dia_chi LIKE ? OR kh_dien_thoai LIKE ? "
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    Dim searchTerm As String = "*" & tukhoa & "*"
                    cmd.Parameters.AddWithValue("p1", searchTerm)
                    cmd.Parameters.AddWithValue("p2", searchTerm)
                    cmd.Parameters.AddWithValue("p3", searchTerm)
                    cmd.Parameters.AddWithValue("p4", searchTerm)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim kh As New KhachHang() With {
                                .Ma = CInt(reader("kh_ma")),
                                .Code = CStr(reader("kh_code")),
                                .Ten = CStr(reader("kh_ten")),
                                .DienThoai = CStr(reader("kh_dien_thoai")),
                                .DiaChi = CStr(reader("kh_dia_chi")),
                                .IsXoa = CBool(reader("kh_xoa"))
                        }
                        khachHangList.Add(kh)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return khachHangList
    End Function

End Class
