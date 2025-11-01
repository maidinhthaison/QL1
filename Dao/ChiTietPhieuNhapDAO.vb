Imports System.Data.OleDb

Public Class ChiTietPhieuNhapDAO
    ' --- DATABASE CONNECTION STRING ---
    Private ReadOnly ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=20810229_taphoa_db.accdb"

    '========================================================================
    '   FUNCTION TO SAVE A LIST OF OBJECTS TO THE DATABASE
    '========================================================================
    Public Function SaveCTPhieuNhap(ByVal chiTietPhieuNhapToSave As List(Of ChiTietPhieuNhap)) As Boolean
        ' Use a transaction to ensure that all records are saved successfully,
        ' or none are. This prevents partial data updates.
        Dim transaction As OleDbTransaction = Nothing

        Using conn As New OleDbConnection(ConnectionString)
            Try
                conn.Open()
                transaction = conn.BeginTransaction()

                For Each pn In chiTietPhieuNhapToSave
                    If pn.Ma = 0 Then
                        ' This is a new record, perform an INSERT
                        InsertCTPhieuNhap(pn, conn, transaction)
                    Else
                        ' This is an existing record, perform an UPDATE
                        UpdateCTPhieuNhap(pn, conn, transaction)
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

    Private Shared Sub InsertCTPhieuNhap(ByVal pn As ChiTietPhieuNhap, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        ' Note: We don't insert the ID because it's an AutoNumber field.
        Dim sql As String = "INSERT INTO ChiTietPhieuNhap (ctpn_pn_ma, ctpn_ma_san_pham, ctpn_so_luong, ctpn_gia, ctpn_khuyen_mai, ctpn_tong_tien,
                            ctpn_thanh_tien, ctpn_xoa, ctpn_ghi_chu)
                            VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            ' OLEDB uses positional '?' placeholders. The order you add parameters matters.
            cmd.Parameters.AddWithValue("pMa", pn.PhieuNhapMa)
            cmd.Parameters.AddWithValue("pSP", pn.MaSanPham)
            cmd.Parameters.AddWithValue("pSL", pn.SoLuong)
            cmd.Parameters.AddWithValue("pGia", pn.Gia)
            cmd.Parameters.AddWithValue("Tkm", pn.KhuyenMai)
            cmd.Parameters.AddWithValue("pTT", pn.TongTien)
            cmd.Parameters.AddWithValue("pThanhTien", pn.TongThanhTien)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.Parameters.AddWithValue("pGhiChu", pn.GhiChu)
            cmd.ExecuteNonQuery()
            cmd.CommandText = "SELECT @@IDENTITY;"
            Dim newId As Integer = CInt(cmd.ExecuteScalar())
            pn.Ma = newId

        End Using
    End Sub

    Private Shared Sub UpdateCTPhieuNhap(ByVal pn As ChiTietPhieuNhap, ByVal conn As OleDbConnection, ByVal transaction As OleDbTransaction)
        Dim sql As String = "UPDATE ChiTietPhieuNhap SET ctpn_so_luong = ?, ctpn_gia = ?,
            ctpn_khuyen_mai = ?, ctpn_tong_tien = ?, ctpn_thanh_tien = ?,  ctpn_xoa = ?, ctpn_ghi_chu = ? WHERE ctpn_ma = ?"

        Using cmd As New OleDbCommand(sql, conn, transaction)
            cmd.Parameters.AddWithValue("pSL", pn.SoLuong)
            cmd.Parameters.AddWithValue("pGia", pn.Gia)
            cmd.Parameters.AddWithValue("pTongKm", pn.KhuyenMai)
            cmd.Parameters.AddWithValue("pTongTien", pn.TongTien)
            cmd.Parameters.AddWithValue("pThanhTien", pn.TongThanhTien)
            cmd.Parameters.AddWithValue("pXoa", pn.IsXoa)
            cmd.Parameters.AddWithValue("pGhiChu", pn.GhiChu)
            cmd.Parameters.AddWithValue("pMa", pn.Ma)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class
