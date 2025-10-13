Imports System.Data.OleDb

Public Class SanPhamDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO LOAD DATA FROM DATABASE INTO A LIST OF OBJECTS
    '========================================================================
    Public Function LoadSanPham() As List(Of SanPham)
        Dim sanPhamList As New List(Of SanPham)()
        Dim sql As String = "SELECT sp_ma, sp_ten, sp_mo_ta, sp_loai, sp_gia, sp_xoa, sp_code, sp_so_luong, sp_dv_ma,
                FROM SanPham WHERE sp_xoa = False ORDER BY sp_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim sp As New SanPham() With {
                                .Ma = CInt(reader("sp_ma")),
                                .Ten = CStr(reader("sp_ten")),
                                .Mota = CStr(reader("sp_mo_ta")),
                                .Loai = CInt(reader("sp_loai")),
                                .Gia = CDbl(reader("sp_gia")),
                                .IsXoa = CBool(reader("sp_xoa")),
                                .Code = CStr(reader("sp_code")),
                                .Sp_SoLuong = CInt(reader("sp_so_luong")),
                                .Sp_Dv_Ma = CInt(reader("sp_dv_ma"))
                        }
                        sanPhamList.Add(sp)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return sanPhamList
    End Function


    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveSanPham(ByVal spToSave As List(Of SanPham)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each sp In spToSave
                    If sp.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertSanPham(sp, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateSanPham(sp, conn, transaction)
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

    Private Shared Sub InsertSanPham(ByVal sp As SanPham, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO SanPham (sp_ten, sp_mo_ta, sp_loai, 
                sp_gia, sp_xoa, sp_code, sp_so_luong, sp_dv_ma) VALUES (?, ?, ?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pTen", sp.Ten)
            cmd.Parameters.AddWithValue("pMota", sp.Mota)
            cmd.Parameters.AddWithValue("pLoai", sp.Loai)
            cmd.Parameters.AddWithValue("pGia", sp.Gia)
            cmd.Parameters.AddWithValue("pXoa", sp.IsXoa)
            cmd.Parameters.AddWithValue("pCode", sp.Code)
            cmd.Parameters.AddWithValue("pSL", sp.Sp_SoLuong)
            cmd.Parameters.AddWithValue("pDv", sp.Sp_Dv_Ma)
            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            sp.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Shared Sub UpdateSanPham(ByVal sp As SanPham, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE SanPham SET sp_ten = ?, sp_mo_ta = ?, sp_loai = ?,
            sp_gia = ?, sp_xoa = ?, sp_so_luong = ?, WHERE sp_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pTen", sp.Ten)
            cmd.Parameters.AddWithValue("pMota", sp.Mota)
            cmd.Parameters.AddWithValue("pLoai", sp.Loai)
            cmd.Parameters.AddWithValue("pGia", sp.Gia)
            cmd.Parameters.AddWithValue("pXoa", sp.IsXoa)
            cmd.Parameters.AddWithValue("pMa", sp.Ma)
            cmd.Parameters.AddWithValue("pSL", sp.Sp_SoLuong)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function GetSP_By_LoaiSP_NhaCC_KhuVuc() As List(Of SanPham)
        Dim spList As New List(Of SanPham)()

        Dim sql As String = "SELECT lsp.lsp_ma, lsp.lsp_ten, lsp.lsp_mo_ta, lsp.lsp_xoa, lsp.lsp_code, lsp.lsp_ncc, lsp.lsp_khu_vuc, lsp.lsp_so_luong, lsp.lsp_cn_ma,
                ncc.ncc_ma AS ncc_ma, ncc.ncc_ten AS ncc_ten, 
                kv.kv_ma AS kv_ma, kv.kv_ten AS kv_ten,
                sp.sp_ma, sp.sp_ten, sp.sp_mo_ta, sp.sp_loai, sp.sp_gia, sp.sp_xoa, sp.sp_code, sp_so_luong, sp_dv_ma,
                cn.cn_ma AS cn_ma, cn.cn_ten AS cn_ten, cn.cn_dia_chi AS cn_dia_chi,
                dv.dv_ma AS dv_ma, dv.dv_ten AS dv_ten, dv.dv_mota AS dv_mota, dv.dv_xoa AS dv_xoa, dv.dv_code AS dv_code 
                FROM (
                    (
                    (
                    (SanPham As sp
                    INNER JOIN LoaiSanPham AS lsp ON sp.sp_loai = lsp.lsp_ma)
                    INNER JOIN NhaCungCap AS ncc ON lsp.lsp_ncc = ncc.ncc_ma)
                    INNER JOIN KhuVuc AS kv ON lsp.lsp_khu_vuc = kv.kv_ma)
                    INNER JOIN ChiNhanh AS cn ON lsp.lsp_cn_ma = cn.cn_ma)
                    INNER JOIN DonVi AS dv ON sp.sp_dv_ma = dv.dv_ma"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim sp As New SanPham() With {
                                .Ma = CInt(reader("sp_ma")),
                                .Ten = CStr(reader("sp_ten")),
                                .Mota = CStr(reader("sp_mo_ta")),
                                .Loai = CInt(reader("sp_loai")),
                                .Gia = CDbl(reader("sp_gia")),
                                .IsXoa = CBool(reader("sp_xoa")),
                                .Code = CStr(reader("sp_code")),
                                .Sp_Dv_Ma = CStr(reader("sp_dv_ma")),
                                .LoaiSp_Ma = CInt(reader("lsp_ma")),
                                .LoaiSp_Ten = CStr(reader("lsp_ten")),
                                .LoaiSp_Ncc_Ma = CInt(reader("lsp_ncc")),
                                .LoaiSp_Kv_Ma = CInt(reader("lsp_khu_vuc")),
                                .NCC_Ma = CInt(reader("ncc_ma")),
                                .NCC_Ten = CStr(reader("ncc_ten")),
                                .Kv_Ma = CInt(reader("kv_ma")),
                                .Kv_Ten = CStr(reader("kv_ten")),
                                .Sp_SoLuong = CInt(reader("sp_so_luong")),
                                .LoaiSp_ChiNhanh = New ChiNhanh() With {
                                    .Ma = CStr(reader("cn_ma")),
                                    .Ten = CStr(reader("cn_ten")),
                                    .DiaChi = CStr(reader("cn_dia_chi"))
                                },
                                .Sp_DonVi = New DonVi() With {
                                    .Ma = CInt(reader("dv_ma")),
                                    .Ten = CStr(reader("dv_ten")),
                                    .Mota = CStr(reader("dv_mota")),
                                    .IsXoa = CBool(reader("dv_xoa")),
                                    .Code = CStr(reader("dv_code"))
                                }
                        }
                        spList.Add(sp)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return spList
    End Function


    Public Function GetSP_By_LoaiSP_NhaCC_KhuVuc_ChiNhanh(chiNhanhMa As Integer) As List(Of SanPham)
        Dim spList As New List(Of SanPham)()

        Dim sql As String = "SELECT lsp.lsp_ma, lsp.lsp_ten, lsp.lsp_mo_ta, lsp.lsp_xoa, lsp.lsp_code, lsp.lsp_ncc, lsp.lsp_khu_vuc, lsp.lsp_so_luong, lsp.lsp_cn_ma,
                ncc.ncc_ma AS ncc_ma, ncc.ncc_ten AS ncc_ten, 
                kv.kv_ma AS kv_ma, kv.kv_ten AS kv_ten,
                sp.sp_ma, sp.sp_ten, sp.sp_mo_ta, sp.sp_loai, sp.sp_gia, sp.sp_xoa, sp.sp_code, sp_dv_ma,
                cn.cn_ma AS cn_ma, cn.cn_ten AS cn_ten, cn.cn_dia_chi AS cn_dia_chi
                FROM (
                    (
                    (SanPham As sp
                    INNER JOIN LoaiSanPham AS lsp ON sp.sp_loai = lsp.lsp_ma)
                    INNER JOIN NhaCungCap AS ncc ON lsp.lsp_ncc = ncc.ncc_ma)
                    INNER JOIN KhuVuc AS kv ON lsp.lsp_khu_vuc = kv.kv_ma)
                    INNER JOIN ChiNhanh AS cn ON lsp.lsp_cn_ma = cn.cn_ma
                    WHERE lsp.lsp_cn_ma = ?"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("pLspMa", chiNhanhMa)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim sp As New SanPham() With {
                                .Ma = CInt(reader("sp_ma")),
                                .Ten = CStr(reader("sp_ten")),
                                .Mota = CStr(reader("sp_mo_ta")),
                                .Loai = CInt(reader("sp_loai")),
                                .Gia = CDbl(reader("sp_gia")),
                                .IsXoa = CBool(reader("sp_xoa")),
                                .Code = CStr(reader("sp_code")),
                                .Sp_Dv_Ma = CStr(reader("sp_dv_ma")),
                                .LoaiSp_Ma = CInt(reader("lsp_ma")),
                                .LoaiSp_Ten = CStr(reader("lsp_ten")),
                                .LoaiSp_Ncc_Ma = CInt(reader("lsp_ncc")),
                                .LoaiSp_Kv_Ma = CInt(reader("lsp_khu_vuc")),
                                .NCC_Ma = CInt(reader("ncc_ma")),
                                .NCC_Ten = CStr(reader("ncc_ten")),
                                .Kv_Ma = CInt(reader("kv_ma")),
                                .Kv_Ten = CStr(reader("kv_ten")),
                                .Sp_SoLuong = CInt(reader("lsp_so_luong")),
                                .LoaiSp_ChiNhanh = New ChiNhanh() With {
                                    .Ma = chiNhanhMa,
                                    .Ten = CStr(reader("cn_ten")),
                                    .DiaChi = CStr(reader("cn_dia_chi"))
                                }
                        }
                        spList.Add(sp)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return spList
    End Function
End Class
