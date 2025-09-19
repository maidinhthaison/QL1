Imports System.Data.OleDb

Public Class NhanVienDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function GetAllNhatVien() As List(Of NhanVien)
        Dim nhanVienList As New List(Of NhanVien)()
        Dim sql As String = "SELECT nv_ma, nv_ten, nv_diachi, nv_gioi_tinh, nv_xoa, nv_dien_thoai
                FROM NhanVien ORDER BY nv_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim nv As New NhanVien() With {
                                .Ma = CInt(reader("nv_ma")),
                                .Ten = CStr(reader("nv_ten")),
                                .DiaChi = CStr(reader("nv_diachi")),
                                .GioiTinh = CBool(reader("nv_gioi_tinh")),
                                .IsXoa = CBool(reader("nv_xoa")),
                                .DienThoai = CStr(reader("nv_dien_thoai"))
                        }
                        nhanVienList.Add(nv)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return nhanVienList
    End Function


    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveNhanVien(ByVal nvToSave As List(Of NhanVien)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each nv In nvToSave
                    If nv.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertNhanVien(nv, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateNhanVien(nv, conn, transaction)
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

    Private Shared Sub InsertNhanVien(ByVal nv As NhanVien, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO NhanVien (nv_ten, nv_diachi, nv_xoa, nv_dien_thoai, nv_tk_ma)
                            VALUES (?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pTen", nv.Ten)
            cmd.Parameters.AddWithValue("pDc", nv.DiaChi)
            cmd.Parameters.AddWithValue("pXoa", nv.IsXoa)
            cmd.Parameters.AddWithValue("pDT", nv.DienThoai)
            cmd.Parameters.AddWithValue("pTkMa", nv.TaiKhoan.Ma)
            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            nv.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Shared Sub UpdateNhanVien(ByVal nv As NhanVien, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE NhanVien SET nv_ten = ?, nv_diachi = ?,
            nv_dien_thoai = ?, nv_xoa = ? WHERE nv_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pTen", nv.Ten)
            cmd.Parameters.AddWithValue("pDc", nv.DiaChi)
            cmd.Parameters.AddWithValue("pDT", nv.DienThoai)
            cmd.Parameters.AddWithValue("pXoa", nv.IsXoa)
            cmd.Parameters.AddWithValue("pMa", nv.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function Get_NV_By_MaTK() As List(Of NhanVien)
        Dim nvList As New List(Of NhanVien)()

        Dim sql As String = "SELECT nv.nv_ma, nv.nv_ten, nv.nv_diachi, nv.nv_gioi_tinh, nv.nv_xoa, 
                nv.nv_dien_thoai, nv.nv_tk_ma,
                tk.tk_tai_khoan AS tk_tai_khoan, tk.tk_mat_khau AS tk_mat_khau , tk.tk_xoa AS tk_xoa, tk.tk_ma AS tk_ma
                FROM
                    (NhanVien As nv
                    INNER JOIN TaiKhoan AS tk ON nv.nv_tk_ma = tk.tk_ma)"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim nv As New NhanVien() With {
                                .Ma = CInt(reader("nv_ma")),
                                .Ten = CStr(reader("nv_ten")),
                                .DiaChi = CStr(reader("nv_diachi")),
                                .GioiTinh = CBool(reader("nv_gioi_tinh")),
                                .IsXoa = CBool(reader("nv_xoa")),
                                .DienThoai = CStr(reader("nv_dien_thoai")),
                                .TaiKhoanTen = CStr(reader("tk_tai_khoan")),
                                .TaiKhoan = New TaiKhoan() With {
                                    .TaiKhoan = CStr(reader("tk_tai_khoan")),
                                    .MatKhau = CStr(reader("tk_mat_khau")),
                                    .IsXoa = CStr(reader("tk_xoa")),
                                    .Ma = CInt(reader("nv_tk_ma"))
                                }
                        }
                        nvList.Add(nv)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return nvList
    End Function

End Class
