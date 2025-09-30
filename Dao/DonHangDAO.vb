Imports System.Data.OleDb

Public Class DonHangDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveDonHang(ByVal pbhToSave As List(Of DonHang)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each pbh In pbhToSave
                    If pbh.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertDonHang(pbh, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateDonHang(pbh, conn, transaction)
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

    Private Shared Sub InsertDonHang(ByVal pbh As DonHang, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO PhieuBanHang (pbh_code, pbh_ngay,  pbh_tong_san_pham, pbh_tong_khuyen_mai, 
                pbh_tong_tien, pbh_ghi_chu, pbh_khach_hang, pbh_xoa, pbh_chi_nhanh)
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pCode", pbh.Code)
            cmd.Parameters.AddWithValue("pNgay", pbh.Ngay)
            cmd.Parameters.AddWithValue("pTsp", pbh.TongSanPham)
            cmd.Parameters.AddWithValue("Tkm", pbh.TongKhuyenMai)
            cmd.Parameters.AddWithValue("pTT", pbh.TongTien)
            cmd.Parameters.AddWithValue("pGhiChu", pbh.GhiChu)
            cmd.Parameters.AddWithValue("pKHMa", pbh.BanHangKhachHang.Ma)
            cmd.Parameters.AddWithValue("pXoa", pbh.IsXoa)
            cmd.Parameters.AddWithValue("pChiNhanhMa", pbh.ChiNhanh.Ma)

            cmd.ExecuteNonQuery()

            ' Optional: Get the new ID of the inserted record
            cmd.CommandText = "SELECT @@IDENTITY;"
            pbh.Ma = CInt(cmd.ExecuteScalar())
        End Using
    End Sub

    Private Shared Sub UpdateDonHang(ByVal pbh As DonHang, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE PhieuBanHang SET pbh_ngay = ?, pbh_ghi_chu = ?,
            pbh_khach_hang = ?, pbh_xoa = ?, pbh_chi_nhanh = ? WHERE pbh_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pNgay", pbh.Ngay)
            cmd.Parameters.AddWithValue("pGhiChu", pbh.GhiChu)
            cmd.Parameters.AddWithValue("pKHMa", pbh.BanHangKhachHang.Ma)
            cmd.Parameters.AddWithValue("pXoa", pbh.IsXoa)
            cmd.Parameters.AddWithValue("pChiNhanhMa", pbh.ChiNhanh.Ma)
            cmd.Parameters.AddWithValue("pMa", pbh.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Function Get_Pbh_By_ChiNhanh_KH() As List(Of DonHang)
        Dim pbhList As New List(Of DonHang)()

        Dim sql As String = "SELECT pbh_ma, pbh_code, pbh_ngay, pbh_tong_san_pham, pbh_tong_khuyen_mai, pbh_tong_tien,
                pbh_ghi_chu, pbh_khach_hang, pbh_xoa, pbh_chi_nhanh,
                cn.cn_ma, cn.cn_ten, cn.cn_dia_chi
                kh.kh_ma, kh.kh_code, kh.kh_ten, kh.kh_dien_thoai, kh.kh_dia_chi, kh.kh_xoa
                FROM(
                    (PhieuBanHang As pbh
                    INNER JOIN ChiNhanh AS cn ON pbh.pbh_chi_nhanh = cn.cn_ma)
                    INNER JOIN KhachHang AS kh ON pbh.pbh_khach_hang = kh.kh_ma )"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim pbh As New DonHang() With {
                                .Ma = CInt(reader("pbh_ma")),
                                .Code = CStr(reader("pbh_code")),
                                .Ngay = CStr(reader("pbh_ngay")),
                                .TongSanPham = CBool(reader("pbh_tong_san_pham")),
                                .TongKhuyenMai = CBool(reader("pbh_tong_khuyen_mai")),
                                .TongTien = CStr(reader("pbh_tong_tien")),
                                .GhiChu = CStr(reader("pbh_ghi_chu")),
                                .IsXoa = CStr(reader("pbh_xoa")),
                                .BanHangKhachHang = New KhachHang() With {
                                    .Ten = CStr(reader("kh_ten")),
                                    .Code = CStr(reader("kh_code")),
                                    .DienThoai = CStr(reader("kh_dien_thoai")),
                                    .Ma = CInt(reader("kh_ma")),
                                    .DiaChi = CInt(reader("kh_dia_chi")),
                                    .IsXoa = CInt(reader("kh_xoa"))
                                },
                                .ChiNhanh = New ChiNhanh() With {
                                    .Ten = CStr(reader("cn_ten")),
                                    .DiaChi = CStr(reader("cn_dia_chi")),
                                    .Ma = CInt(reader("cn_ma"))
                                }
                        }
                        pbhList.Add(pbh)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return pbhList
    End Function
End Class
