Imports System.Data.OleDb

Public Class PhieuNhapDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SavePhieuNhap(ByVal phieuNhapToSave As List(Of PhieuNhap)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each pn In phieuNhapToSave
                    If pn.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertPhieuNhap(pn, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdatePhieuNhap(pn, conn, transaction)
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

    Private Shared Sub InsertPhieuNhap(ByVal pn As PhieuNhap, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO PhieuNhap (pn_cn_ma, pn_code, pn_ngay, pn_tong_san_pham, pn_tong_khuyen_mai, pn_tong_tien,
                            pn_tong_thanh_tien, pn_ghi_chu, pn_xoa)
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pCN", pn.ChiNhanhMa)
            cmd.Parameters.AddWithValue("pCode", pn.Code)
            cmd.Parameters.AddWithValue("pNgay", pn.NgayNhap.ToString(DATETIME_FORMAT))
            cmd.Parameters.AddWithValue("pTSP", pn.TongSanPham)
            cmd.Parameters.AddWithValue("Tkm", pn.TongKhuyenMai)
            cmd.Parameters.AddWithValue("pTT", pn.TongTien)
            cmd.Parameters.AddWithValue("pThanhTien", pn.TongThanhTien)
            cmd.Parameters.AddWithValue("pGhiChu", pn.GhiChu)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY;"
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            pn.Ma = newId

        End Using
    End Sub

    Private Shared Sub UpdatePhieuNhap(ByVal pn As PhieuNhap, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE PhieuNhap SET pn_ngay = ?,  pn_tong_san_pham = ?,
            pn_tong_khuyen_mai = ?, pn_tong_tien = ?, pn_tong_thanh_tien = ?,  pn_ghi_chu = ?, pn_xoa = ? WHERE pn_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pNgay", pn.NgayNhap.ToString(DATETIME_FORMAT))
            cmd.Parameters.AddWithValue("pTongSp", pn.TongSanPham)
            cmd.Parameters.AddWithValue("pTongKm", pn.TongKhuyenMai)
            cmd.Parameters.AddWithValue("pTongTien", pn.TongTien)
            cmd.Parameters.AddWithValue("pThanhTien", pn.TongThanhTien)
            cmd.Parameters.AddWithValue("pGhiChu", pn.GhiChu)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.Parameters.AddWithValue("pMa", pn.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Public Function GetAll_PhieuNhap_By_ChiNhanh(chiNhanhMa As Integer) As List(Of PhieuNhap)
        Dim phieuNhapList As New List(Of PhieuNhap)()

        Dim sql As String = "SELECT pn_ma, pn_cn_ma, pn_code, pn_ngay, pn_tong_san_pham, pn_tong_khuyen_mai, pn_tong_tien,
                            pn_tong_thanh_tien, pn_ghi_chu, pn_xoa,
                            cn.cn_ma, cn.cn_ten, cn.cn_dia_chi
                            FROM
                            PhieuNhap AS pn
                            INNER JOIN ChiNhanh AS cn ON pn.pn_cn_ma = cn.cn_ma
                            WHERE pn_cn_ma = ?  ORDER BY pn_ma DESC"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    cmd.Parameters.AddWithValue("pCN", chiNhanhMa)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim pn As New PhieuNhap() With {
                                .Ma = CInt(reader("pn_ma")),
                                .Code = CStr(reader("pn_code")),
                                .NgayNhap = CDate(reader("pn_ngay")),
                                .ChiNhanhMa = CInt(reader("pn_cn_ma")),
                                .TongSanPham = CInt(reader("pn_tong_san_pham")),
                                .TongKhuyenMai = CDbl(reader("pn_tong_khuyen_mai")),
                                .TongTien = CDbl(reader("pn_tong_tien")),
                                .TongThanhTien = CDbl(reader("pn_tong_thanh_tien")),
                                .GhiChu = CStr(reader("pn_ghi_chu")),
                                .IsXoa = CBool(reader("pn_xoa")),
                                .PhieuNhap_ChiNhanh = New ChiNhanh() With {
                                    .Ten = CStr(reader("cn_ten")),
                                    .DiaChi = CStr(reader("cn_dia_chi")),
                                    .Ma = CInt(reader("cn_ma"))
                                }
                        }
                        phieuNhapList.Add(pn)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return phieuNhapList
    End Function

    Public Function Get_ChiTietPhieuNhap_By_PhieuNhapMa(phieuNhapMa As Integer) As List(Of ChiTietPhieuNhap)
        Dim ctPhieuNhapList As New List(Of ChiTietPhieuNhap)()

        Dim sql As String = "SELECT ctpn_ma, ctpn_pn_ma, ctpn_ma_san_pham, ctpn_so_luong, ctpn_gia, ctpn_khuyen_mai, ctpn_tong_tien,
                            ctpn_thanh_tien, ctpn_xoa, ctpn_ghi_chu,
                            sp.sp_ma, sp.sp_ten, sp.sp_gia, sp.sp_so_luong
                            FROM
                            ChiTietPhieuNhap AS ctpn
                            INNER JOIN SanPham AS sp ON sp.sp_ma = ctpn.ctpn_ma_san_pham
                            WHERE ctpn_pn_ma = ? ORDER BY ctpn_ma DESC"

        ' Use 'Using' blocks to ensure database objects are closed and disposed of properly
        Using conn As New OleDbConnection(ConnectionString)
            Using cmd As New OleDbCommand(sql, conn)
                Try
                    cmd.Parameters.AddWithValue("pCN", phieuNhapMa)
                    conn.Open()
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim ctpn As New ChiTietPhieuNhap() With {
                                .Ma = CInt(reader("ctpn_ma")),
                                .MaSanPham = CInt(reader("ctpn_ma_san_pham")),
                                .SoLuong = CInt(reader("ctpn_so_luong")),
                                .Gia = CDbl(reader("ctpn_gia")),
                                .KhuyenMai = CDbl(reader("ctpn_khuyen_mai")),
                                .TongTien = CDbl(reader("ctpn_tong_tien")),
                                .TongThanhTien = CDbl(reader("ctpn_thanh_tien")),
                                .GhiChu = CStr(reader("ctpn_ghi_chu")),
                                .IsXoa = CBool(reader("ctpn_xoa")),
                                .GetSanPham = New SanPham() With {
                                    .Ma = CInt(reader("sp_ma")),
                                    .Ten = CStr(reader("sp_ten")),
                                    .Gia = CDbl(reader("sp_gia")),
                                    .Sp_SoLuong = CInt(reader("sp_so_luong"))
                                }
                        }
                        ctPhieuNhapList.Add(ctpn)
                    End While

                Catch ex As Exception
                    Console.WriteLine("Error loading data: " & ex.Message)
                End Try
            End Using
        End Using

        Return ctPhieuNhapList
    End Function


End Class
