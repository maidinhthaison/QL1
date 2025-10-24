<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChiTietDonHang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        dgvSanPham = New DataGridView()
        tbTuKhoa = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnThem = New Button()
        btnXoa = New Button()
        GroupBox4 = New GroupBox()
        btnCapNhatKH = New Button()
        btnTimKH = New Button()
        dgvKhachHang = New DataGridView()
        cbTichDiem = New CheckBox()
        tbDienthoaiKh = New TextBox()
        Label3 = New Label()
        tbTenKh = New TextBox()
        Label4 = New Label()
        Label9 = New Label()
        tbDiaChi = New TextBox()
        GroupBox3 = New GroupBox()
        Label11 = New Label()
        lbChiNhanh = New Label()
        dgvDonHang = New DataGridView()
        Label7 = New Label()
        tbSoluong = New TextBox()
        Label5 = New Label()
        Label8 = New Label()
        tbKhuyenMai = New TextBox()
        Label6 = New Label()
        btnClearDH = New Button()
        btnXacNhan = New Button()
        tbGhiChu = New TextBox()
        lbTongtien = New Label()
        lbDateTime = New Label()
        SP_BindingSource = New BindingSource(components)
        CTDH_BindingSource = New BindingSource(components)
        lbNgayThang = New Label()
        Bs_KhachHang = New BindingSource(components)
        GroupBox1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        CType(SP_BindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(CTDH_BindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(Bs_KhachHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(14, 69)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(930, 870)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sản phẩm"
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.AllowUserToAddRows = False
        dgvSanPham.AllowUserToDeleteRows = False
        dgvSanPham.AllowUserToResizeColumns = False
        dgvSanPham.AllowUserToResizeRows = False
        dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Location = New Point(6, 28)
        dgvSanPham.Margin = New Padding(3, 4, 3, 4)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(918, 834)
        dgvSanPham.TabIndex = 7
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(101, 28)
        tbTuKhoa.Margin = New Padding(3, 4, 3, 4)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.Size = New Size(251, 27)
        tbTuKhoa.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(371, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 2
        Label1.Text = "Ngày tháng"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 4
        Label2.Text = "Từ khoá"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(605, 28)
        btnThem.Margin = New Padding(3, 4, 3, 4)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(99, 41)
        btnThem.TabIndex = 5
        btnThem.Text = "Thêm vào >"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(16, 122)
        btnXoa.Margin = New Padding(3, 4, 3, 4)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(109, 42)
        btnXoa.TabIndex = 6
        btnXoa.Text = "< Bỏ ra"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnCapNhatKH)
        GroupBox4.Controls.Add(btnTimKH)
        GroupBox4.Controls.Add(dgvKhachHang)
        GroupBox4.Controls.Add(cbTichDiem)
        GroupBox4.Controls.Add(tbDienthoaiKh)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Controls.Add(tbTenKh)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(tbDiaChi)
        GroupBox4.Location = New Point(16, 619)
        GroupBox4.Margin = New Padding(3, 4, 3, 4)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 4, 3, 4)
        GroupBox4.Size = New Size(699, 299)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        GroupBox4.Text = "Thông tin khách hàng"
        ' 
        ' btnCapNhatKH
        ' 
        btnCapNhatKH.Location = New Point(110, 173)
        btnCapNhatKH.Margin = New Padding(3, 4, 3, 4)
        btnCapNhatKH.Name = "btnCapNhatKH"
        btnCapNhatKH.Size = New Size(106, 31)
        btnCapNhatKH.TabIndex = 54
        btnCapNhatKH.Text = "Cập nhật"
        btnCapNhatKH.UseVisualStyleBackColor = True
        ' 
        ' btnTimKH
        ' 
        btnTimKH.Location = New Point(9, 173)
        btnTimKH.Margin = New Padding(3, 4, 3, 4)
        btnTimKH.Name = "btnTimKH"
        btnTimKH.Size = New Size(86, 31)
        btnTimKH.TabIndex = 53
        btnTimKH.Text = "Tìm KH"
        btnTimKH.UseVisualStyleBackColor = True
        ' 
        ' dgvKhachHang
        ' 
        dgvKhachHang.AllowUserToAddRows = False
        dgvKhachHang.AllowUserToDeleteRows = False
        dgvKhachHang.AllowUserToResizeColumns = False
        dgvKhachHang.AllowUserToResizeRows = False
        dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhachHang.Location = New Point(315, 17)
        dgvKhachHang.Margin = New Padding(3, 4, 3, 4)
        dgvKhachHang.Name = "dgvKhachHang"
        dgvKhachHang.ReadOnly = True
        dgvKhachHang.RowHeadersWidth = 51
        dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKhachHang.Size = New Size(378, 274)
        dgvKhachHang.TabIndex = 14
        ' 
        ' cbTichDiem
        ' 
        cbTichDiem.AutoSize = True
        cbTichDiem.Location = New Point(13, 231)
        cbTichDiem.Name = "cbTichDiem"
        cbTichDiem.Size = New Size(96, 24)
        cbTichDiem.TabIndex = 52
        cbTichDiem.Text = "Tích điểm"
        cbTichDiem.UseVisualStyleBackColor = True
        ' 
        ' tbDienthoaiKh
        ' 
        tbDienthoaiKh.Location = New Point(100, 37)
        tbDienthoaiKh.Margin = New Padding(3, 4, 3, 4)
        tbDienthoaiKh.Name = "tbDienthoaiKh"
        tbDienthoaiKh.Size = New Size(206, 27)
        tbDienthoaiKh.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 40)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 48
        Label3.Text = "Điện thoại"
        ' 
        ' tbTenKh
        ' 
        tbTenKh.Location = New Point(100, 75)
        tbTenKh.Margin = New Padding(3, 4, 3, 4)
        tbTenKh.Name = "tbTenKh"
        tbTenKh.Size = New Size(206, 27)
        tbTenKh.TabIndex = 47
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 81)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 20)
        Label4.TabIndex = 46
        Label4.Text = "Tên KH"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(6, 129)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 20)
        Label9.TabIndex = 50
        Label9.Text = "Địa chỉ"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(100, 122)
        tbDiaChi.Margin = New Padding(3, 4, 3, 4)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(206, 27)
        tbDiaChi.TabIndex = 51
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(GroupBox4)
        GroupBox3.Controls.Add(Label11)
        GroupBox3.Controls.Add(btnXoa)
        GroupBox3.Controls.Add(lbChiNhanh)
        GroupBox3.Controls.Add(dgvDonHang)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(tbSoluong)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(tbKhuyenMai)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(btnClearDH)
        GroupBox3.Controls.Add(btnXacNhan)
        GroupBox3.Controls.Add(tbGhiChu)
        GroupBox3.Controls.Add(lbTongtien)
        GroupBox3.Location = New Point(950, 13)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(721, 926)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Chi tiết ĐH"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(315, 36)
        Label11.Name = "Label11"
        Label11.Size = New Size(72, 20)
        Label11.TabIndex = 47
        Label11.Text = "Tổng tiền"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.Font = New Font("Segoe UI", 9F)
        lbChiNhanh.ForeColor = Color.Red
        lbChiNhanh.Location = New Point(110, 36)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 45
        lbChiNhanh.Text = "N/A"
        ' 
        ' dgvDonHang
        ' 
        dgvDonHang.AllowUserToAddRows = False
        dgvDonHang.AllowUserToDeleteRows = False
        dgvDonHang.AllowUserToResizeColumns = False
        dgvDonHang.AllowUserToResizeRows = False
        dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDonHang.Location = New Point(16, 182)
        dgvDonHang.Margin = New Padding(3, 4, 3, 4)
        dgvDonHang.Name = "dgvDonHang"
        dgvDonHang.ReadOnly = True
        dgvDonHang.RowHeadersWidth = 51
        dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDonHang.Size = New Size(699, 429)
        dgvDonHang.TabIndex = 7
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(16, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 20)
        Label7.TabIndex = 17
        Label7.Text = "Số lượng"
        ' 
        ' tbSoluong
        ' 
        tbSoluong.Location = New Point(110, 80)
        tbSoluong.Margin = New Padding(3, 4, 3, 4)
        tbSoluong.Name = "tbSoluong"
        tbSoluong.Size = New Size(68, 27)
        tbSoluong.TabIndex = 18
        tbSoluong.Text = "1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 44
        Label5.Text = "Chi nhánh"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(197, 83)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 20)
        Label8.TabIndex = 19
        Label8.Text = "Khuyến mãi (%)"
        ' 
        ' tbKhuyenMai
        ' 
        tbKhuyenMai.Location = New Point(315, 80)
        tbKhuyenMai.Margin = New Padding(3, 4, 3, 4)
        tbKhuyenMai.Name = "tbKhuyenMai"
        tbKhuyenMai.Size = New Size(69, 27)
        tbKhuyenMai.TabIndex = 20
        tbKhuyenMai.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(197, 135)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 20)
        Label6.TabIndex = 21
        Label6.Text = "Ghi chú"
        ' 
        ' btnClearDH
        ' 
        btnClearDH.Location = New Point(623, 25)
        btnClearDH.Margin = New Padding(3, 4, 3, 4)
        btnClearDH.Name = "btnClearDH"
        btnClearDH.Size = New Size(86, 31)
        btnClearDH.TabIndex = 15
        btnClearDH.Text = "Huỷ"
        btnClearDH.UseVisualStyleBackColor = True
        ' 
        ' btnXacNhan
        ' 
        btnXacNhan.Location = New Point(443, 58)
        btnXacNhan.Margin = New Padding(3, 4, 3, 4)
        btnXacNhan.Name = "btnXacNhan"
        btnXacNhan.Size = New Size(119, 49)
        btnXacNhan.TabIndex = 14
        btnXacNhan.Text = "Xác nhận"
        btnXacNhan.UseVisualStyleBackColor = True
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(315, 130)
        tbGhiChu.Margin = New Padding(3, 4, 3, 4)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(394, 27)
        tbGhiChu.TabIndex = 22
        tbGhiChu.Text = "abc"
        ' 
        ' lbTongtien
        ' 
        lbTongtien.AutoSize = True
        lbTongtien.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTongtien.ForeColor = Color.Red
        lbTongtien.Location = New Point(393, 36)
        lbTongtien.Name = "lbTongtien"
        lbTongtien.Size = New Size(18, 20)
        lbTongtien.TabIndex = 16
        lbTongtien.Text = "0"
        ' 
        ' lbDateTime
        ' 
        lbDateTime.AutoSize = True
        lbDateTime.ForeColor = Color.Red
        lbDateTime.Location = New Point(427, 31)
        lbDateTime.Name = "lbDateTime"
        lbDateTime.Size = New Size(0, 20)
        lbDateTime.TabIndex = 9
        ' 
        ' lbNgayThang
        ' 
        lbNgayThang.AutoSize = True
        lbNgayThang.Font = New Font("Segoe UI", 9F)
        lbNgayThang.ForeColor = Color.Red
        lbNgayThang.Location = New Point(463, 31)
        lbNgayThang.Name = "lbNgayThang"
        lbNgayThang.Size = New Size(36, 20)
        lbNgayThang.TabIndex = 10
        lbNgayThang.Text = "N/A"
        ' 
        ' FormChiTietDonHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1683, 952)
        Controls.Add(lbNgayThang)
        Controls.Add(lbDateTime)
        Controls.Add(GroupBox3)
        Controls.Add(btnThem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbTuKhoa)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormChiTietDonHang"
        Text = "FormTaoDonHang"
        GroupBox1.ResumeLayout(False)
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        CType(SP_BindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(CTDH_BindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(Bs_KhachHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents dgvDonHang As DataGridView
    Friend WithEvents lbTongtien As Label
    Friend WithEvents btnClearDH As Button
    Friend WithEvents btnXacNhan As Button
    Friend WithEvents tbKhuyenMai As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSoluong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbDateTime As Label
    Friend WithEvents SP_BindingSource As BindingSource
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CTDH_BindingSource As BindingSource
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbDienthoaiKh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTenKh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbNgayThang As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbTichDiem As CheckBox
    Friend WithEvents Bs_KhachHang As BindingSource
    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents btnTimKH As Button
    Friend WithEvents btnCapNhatKH As Button
End Class
