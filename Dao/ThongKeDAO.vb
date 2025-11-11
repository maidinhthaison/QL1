Imports System.Data.OleDb

Public Class ThongKeDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"
    Public Function ThongKe_DonHang_By_NvMa(nVMa As Integer, fromDate As Date, toDate As Date) As List(Of ChiTietDonHang)
        Dim ctdhList As New List(Of ChiTietDonHang)()

        Dim sql As String = "SELECT pbh_ma, pbh_ngay, pbh_khach_hang, pbh_chi_nhanh, pbh_nv_ma, pbh_tong_khuyen_mai, pbh_tong_tien, pbh_tong_thanh_tien, pbh_ghi_chu,
                nv.nv_ma, nv.nv_ten, 
                ctpbh.ctpbh_ma, ctpbh.ctpbh_pbh_ma, ctpbh.ctpbh_ma_san_pham, ctpbh.ctpbh_so_luong, ctpbh.ctpbh_gia,
                ctpbh.ctpbh_khuyen_mai, ctpbh.ctpbh_thanh_tien, ctpbh.ctpbh_tong_tien,
                sp.sp_ma, sp.sp_ten, sp.sp_gia, sp.sp_gia_nhap, sp.sp_code
                FROM(
                    (PhieuBanHang As pbh
                    INNER JOIN NhanVien AS nv ON pbh.pbh_nv_ma = nv.nv_ma)
                    INNER JOIN ChiTietPhieuBanHang AS ctpbh ON pbh.pbh_ma = ctpbh.ctpbh_pbh_ma)
                    INNER JOIN SanPham AS sp ON ctpbh.ctpbh_ma_san_pham = sp.sp_ma
                WHERE pbh_nv_ma = ? AND pbh_ngay BETWEEN ? AND ? 
                ORDER BY pbh_ngay DESC"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()
                    cmd.Parameters.AddWithValue("nvMa", nVMa)
                    cmd.Parameters.AddWithValue("startDate", fromDate)
                    cmd.Parameters.AddWithValue("endDate", toDate)
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ctdh As New ChiTietDonHang() With {
                            .Ma = CInt(reader("ctpbh_ma")),
                            .Pbh_Ma = CInt(reader("ctpbh_pbh_ma")),
                            .Sp_Ma = CInt(reader("ctpbh_ma_san_pham")),
                            .SoLuong = CInt(reader("ctpbh_so_luong")),
                            .Gia = CDbl(reader("ctpbh_gia")),
                            .KhuyenMai = CDbl(reader("ctpbh_khuyen_mai")),
                            .ThanhTien = CDbl(reader("ctpbh_thanh_tien")),
                            .TongTien = CDbl(reader("ctpbh_tong_tien")),
                            .SanPhamInfo = New SanPham() With {
                                .Ma = CInt(reader("sp_ma")),
                                .Ten = CStr(reader("sp_ten")),
                                .Code = CStr(reader("sp_code")),
                                .Gia = CDbl(reader("sp_gia")),
                                .GiaNhap = CDbl(reader("sp_gia_nhap"))
                            }
                        }
                        ctdhList.Add(ctdh)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return ctdhList
    End Function

    Public Function ThongKe_DonHang_By_ThoiGian(fromDate As Date, toDate As Date) As List(Of ChiTietDonHang)
        Dim ctdhList As New List(Of ChiTietDonHang)()

        Dim sql As String = "SELECT pbh_ma, pbh_ngay, pbh_khach_hang, pbh_chi_nhanh, pbh_nv_ma, pbh_tong_khuyen_mai, pbh_tong_tien, pbh_tong_thanh_tien, pbh_ghi_chu,
                nv.nv_ma, nv.nv_ten, 
                ctpbh.ctpbh_ma, ctpbh.ctpbh_pbh_ma, ctpbh.ctpbh_ma_san_pham, ctpbh.ctpbh_so_luong, ctpbh.ctpbh_gia,
                ctpbh.ctpbh_khuyen_mai, ctpbh.ctpbh_thanh_tien, ctpbh.ctpbh_tong_tien,
                sp.sp_ma, sp.sp_ten, sp.sp_gia, sp.sp_gia_nhap, sp.sp_code
                FROM(
                    (PhieuBanHang As pbh
                    INNER JOIN NhanVien AS nv ON pbh.pbh_nv_ma = nv.nv_ma)
                    INNER JOIN ChiTietPhieuBanHang AS ctpbh ON pbh.pbh_ma = ctpbh.ctpbh_pbh_ma)
                    INNER JOIN SanPham AS sp ON ctpbh.ctpbh_ma_san_pham = sp.sp_ma
                WHERE pbh_ngay BETWEEN ? AND ? 
                ORDER BY ctpbh_so_luong DESC"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    conn.Open()

                    cmd.Parameters.AddWithValue("startDate", fromDate)
                    cmd.Parameters.AddWithValue("endDate", toDate)
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ctdh As New ChiTietDonHang() With {
                            .Ma = CInt(reader("ctpbh_ma")),
                            .Pbh_Ma = CInt(reader("ctpbh_pbh_ma")),
                            .Sp_Ma = CInt(reader("ctpbh_ma_san_pham")),
                            .SoLuong = CInt(reader("ctpbh_so_luong")),
                            .Gia = CDbl(reader("ctpbh_gia")),
                            .KhuyenMai = CDbl(reader("ctpbh_khuyen_mai")),
                            .ThanhTien = CDbl(reader("ctpbh_thanh_tien")),
                            .TongTien = CDbl(reader("ctpbh_tong_tien")),
                            .SanPhamInfo = New SanPham() With {
                                .Ma = CInt(reader("sp_ma")),
                                .Ten = CStr(reader("sp_ten")),
                                .Code = CStr(reader("sp_code")),
                                .Gia = CDbl(reader("sp_gia")),
                                .GiaNhap = CDbl(reader("sp_gia_nhap"))
                            }
                        }
                        ctdhList.Add(ctdh)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return ctdhList
    End Function
End Class

