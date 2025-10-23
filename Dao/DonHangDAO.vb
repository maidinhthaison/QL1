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
                pbh_tong_tien, pbh_tong_thanh_tien, pbh_ghi_chu, pbh_khach_hang, pbh_xoa, pbh_chi_nhanh, pbh_nv_ma)
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pCode", pbh.Code)
            cmd.Parameters.AddWithValue("pNgay", pbh.Ngay.ToString(DATETIME_FORMAT))
            cmd.Parameters.AddWithValue("pTsp", pbh.TongSanPham)
            cmd.Parameters.AddWithValue("Tkm", pbh.TongKhuyenMai)
            cmd.Parameters.AddWithValue("pTT", pbh.TongTien)
            cmd.Parameters.AddWithValue("pThanhTien", pbh.ThanhTien)
            cmd.Parameters.AddWithValue("pGhiChu", pbh.GhiChu)
            cmd.Parameters.AddWithValue("pKHMa", pbh.BanHangKhachHang.Ma)
            cmd.Parameters.AddWithValue("pXoa", pbh.IsXoa)
            cmd.Parameters.AddWithValue("pChiNhanhMa", pbh.ChiNhanh.Ma)
            cmd.Parameters.AddWithValue("pNvMa", pbh.DonHang_NhanVien.Ma)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY;"
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            pbh.Ma = newId

        End Using
    End Sub

    Private Shared Sub UpdateDonHang(ByVal pbh As DonHang, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE PhieuBanHang SET pbh_ngay = ?, pbh_tong_san_pham = ?,
            pbh_tong_khuyen_mai = ?, pbh_tong_tien = ?, pbh_tong_thanh_tien = ?,  pbh_ghi_chu = ?,
            pbh_khach_hang = ?, pbh_xoa = ?, pbh_chi_nhanh = ?, pbh_nv_ma = ? WHERE pbh_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pNgay", pbh.Ngay.ToString(DATETIME_FORMAT))
            cmd.Parameters.AddWithValue("pTongSp", pbh.TongSanPham)
            cmd.Parameters.AddWithValue("pTongKm", pbh.TongKhuyenMai)
            cmd.Parameters.AddWithValue("pTongTien", pbh.TongTien)
            cmd.Parameters.AddWithValue("pThanhTien", pbh.ThanhTien)
            cmd.Parameters.AddWithValue("pGhiChu", pbh.GhiChu)
            cmd.Parameters.AddWithValue("pKHMa", pbh.BanHangKhachHang.Ma)
            cmd.Parameters.AddWithValue("pXoa", pbh.IsXoa)
            cmd.Parameters.AddWithValue("pChiNhanhMa", pbh.ChiNhanh.Ma)
            cmd.Parameters.AddWithValue("pNvMa", pbh.DonHang_NhanVien.Ma)
            cmd.Parameters.AddWithValue("pMa", pbh.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Function GetAll_DonHang_With_ChiNhanh_KH() As List(Of DonHang)
        Dim pbhList As New List(Of DonHang)()

        Dim sql As String = "SELECT pbh_ma, pbh_code, pbh_ngay, pbh_tong_san_pham, pbh_tong_khuyen_mai, pbh_tong_tien,
                pbh_tong_thanh_tien, pbh_ghi_chu, pbh_khach_hang, pbh_xoa, pbh_chi_nhanh, pbh_nv_ma,
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
                                .TongSanPham = CInt(reader("pbh_tong_san_pham")),
                                .TongKhuyenMai = CDbl(reader("pbh_tong_khuyen_mai")),
                                .TongTien = CDbl(reader("pbh_tong_tien")),
                                .ThanhTien = CDbl(reader("pbh_tong_thanh_tien")),
                                .GhiChu = CStr(reader("pbh_ghi_chu")),
                                .IsXoa = CBool(reader("pbh_xoa")),
                                .BanHangKhachHang = New KhachHang() With {
                                    .Ten = CStr(reader("kh_ten")),
                                    .Code = CStr(reader("kh_code")),
                                    .DienThoai = CStr(reader("kh_dien_thoai")),
                                    .Ma = CInt(reader("kh_ma")),
                                    .DiaChi = CStr(reader("kh_dia_chi")),
                                    .IsXoa = CBool(reader("kh_xoa"))
                                },
                                .ChiNhanh = New ChiNhanh() With {
                                    .Ten = CStr(reader("cn_ten")),
                                    .DiaChi = CStr(reader("cn_dia_chi")),
                                    .Ma = CInt(reader("cn_ma"))
                                },
                                .NhanVienMa = CInt(reader("pbh_nv_ma")),
                                .KhachHangMa = CInt(reader("pbh_khach_hang")),
                                .ChiNhanhMa = CInt(reader("pbh_chi_nhanh"))
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

    Public Function ChuQuan_GetAll_DonHang_By_ChiNhanh(chiNhanhMa As Integer) As List(Of DonHang)
        Dim pbhList As New List(Of DonHang)()

        Dim sql As String = "SELECT pbh.pbh_ma, pbh.pbh_code, pbh.pbh_ngay, pbh.pbh_tong_san_pham,
                pbh.pbh_tong_khuyen_mai, pbh.pbh_tong_tien, pbh.pbh_tong_thanh_tien, pbh_nv_ma,
                pbh.pbh_ghi_chu, pbh.pbh_khach_hang, pbh.pbh_xoa, pbh.pbh_chi_nhanh,
                kh.kh_ma, kh.kh_code, kh.kh_ten, kh.kh_dien_thoai, kh.kh_dia_chi,
                nv.nv_ma, nv.nv_ten, nv.nv_dien_thoai, nv.nv_diachi
                FROM(
                    PhieuBanHang As pbh
                    INNER JOIN KhachHang AS kh ON pbh.pbh_khach_hang = kh.kh_ma)
                    INNER JOIN NhanVien AS nv ON pbh.pbh_nv_ma = nv.nv_ma
                WHERE pbh.pbh_chi_nhanh = ?"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    cmd.Parameters.AddWithValue("pChiNhanhMa", chiNhanhMa)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim pbh As New DonHang() With {
                                .Ma = CInt(reader("pbh_ma")),
                                .Code = CStr(reader("pbh_code")),
                                .Ngay = CStr(reader("pbh_ngay")),
                                .TongSanPham = CInt(reader("pbh_tong_san_pham")),
                                .TongKhuyenMai = CDbl(reader("pbh_tong_khuyen_mai")),
                                .TongTien = CDbl(reader("pbh_tong_tien")),
                                .ThanhTien = CDbl(reader("pbh_tong_thanh_tien")),
                                .GhiChu = CStr(reader("pbh_ghi_chu")),
                                .IsXoa = CBool(reader("pbh_xoa")),
                                .KhachHangMa = CInt(reader("pbh_khach_hang")),
                                .ChiNhanhMa = CInt(reader("pbh_chi_nhanh")),
                                .NhanVienMa = CInt(reader("pbh_nv_ma")),
                                .BanHangKhachHang = New KhachHang() With {
                                    .Ten = CStr(reader("kh_ten")),
                                    .Code = CStr(reader("kh_code")),
                                    .DienThoai = CStr(reader("kh_dien_thoai")),
                                    .Ma = CInt(reader("kh_ma")),
                                    .DiaChi = CStr(reader("kh_dia_chi"))
                                },
                                .DonHang_NhanVien = New NhanVien() With {
                                    .Ma = CInt(reader("nv_ma")),
                                    .Ten = CStr(reader("nv_ten")),
                                    .DienThoai = CStr(reader("nv_dien_thoai")),
                                    .DiaChi = CStr(reader("nv_diachi"))
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

    Public Function ChuQuan_Get_ChiTiet_DonHang_With_KH_NV_By_ChiNhanh(pbh_ma As Integer) As List(Of DonHang)
        Dim pbhList As New List(Of DonHang)()

        Dim sql As String = "SELECT pbh_ma, pbh_khach_hang, pbh_chi_nhanh, pbh_nv_ma, pbh_tong_khuyen_mai, pbh_tong_tien, pbh_tong_thanh_tien, pbh_ghi_chu,
                nv.nv_ma, nv.nv_ten, 
                kh.kh_ma, kh.kh_code, kh.kh_ten, kh.kh_dien_thoai, kh.kh_dia_chi,
                ctpbh.ctpbh_ma, ctpbh.ctpbh_pbh_ma, ctpbh.ctpbh_ma_san_pham, ctpbh.ctpbh_so_luong, ctpbh.ctpbh_gia,
                ctpbh.ctpbh_khuyen_mai, ctpbh.ctpbh_thanh_tien, ctpbh.ctpbh_tong_tien,
                sp.sp_ma, sp.sp_ten, sp.sp_code
                FROM(
                    (
                    (PhieuBanHang As pbh
                    INNER JOIN NhanVien AS nv ON pbh.pbh_nv_ma = nv.nv_ma)
                    INNER JOIN KhachHang AS kh ON pbh.pbh_khach_hang = kh.kh_ma)
                    INNER JOIN ChiTietPhieuBanHang AS ctpbh ON pbh.pbh_ma = ctpbh.ctpbh_pbh_ma)
                    INNER JOIN SanPham AS sp ON ctpbh.ctpbh_ma_san_pham = sp.sp_ma
                WHERE pbh_ma = ?"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    cmd.Parameters.AddWithValue("pbh_ma", pbh_ma)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim pbh As New DonHang() With {
                                .KhachHangMa = CInt(reader("pbh_khach_hang")),
                                .ChiNhanhMa = CInt(reader("pbh_chi_nhanh")),
                                .NhanVienMa = CInt(reader("pbh_nv_ma")),
                                .TongKhuyenMai = CDbl(reader("pbh_tong_khuyen_mai")),
                                .TongTien = CDbl(reader("pbh_tong_tien")),
                                .ThanhTien = CDbl(reader("pbh_tong_thanh_tien")),
                                .GhiChu = CStr(reader("pbh_ghi_chu")),
                                .BanHangKhachHang = New KhachHang() With {
                                    .Ten = CStr(reader("kh_ten")),
                                    .Code = CStr(reader("kh_code")),
                                    .DienThoai = CStr(reader("kh_dien_thoai")),
                                    .Ma = CInt(reader("kh_ma")),
                                    .DiaChi = CStr(reader("kh_dia_chi"))
                                },
                                .DonHang_NhanVien = New NhanVien() With {
                                    .Ma = CInt(reader("nv_ma")),
                                    .Ten = CStr(reader("nv_ten"))
                                },
                                .ListChiTietDonhang = New List(Of ChiTietDonHang) From {
                                    New ChiTietDonHang() With {
                                        .Ma = CInt(reader("ctpbh_ma")),
                                        .Pbh_Ma = CInt(reader("ctpbh_pbh_ma")),
                                        .Sp_Ma = CInt(reader("ctpbh_ma_san_pham")),
                                        .SoLuong = CInt(reader("ctpbh_so_luong")),
                                        .Gia = CDbl(reader("ctpbh_gia")),
                                        .TongTien = CDbl(reader("ctpbh_tong_tien")),
                                        .KhuyenMai = CDbl(reader("ctpbh_khuyen_mai")),
                                        .ThanhTien = CDbl(reader("ctpbh_thanh_tien")),
                                        .SanPhamInfo = New SanPham() With {
                                            .Ma = CInt(reader("sp_ma")),
                                            .Ten = CStr(reader("sp_ten")),
                                            .Code = CStr(reader("sp_code"))
                                        }
                                    }
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
