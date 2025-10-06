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
        GroupBox2 = New GroupBox()
        GroupBox4 = New GroupBox()
        tbDiaChi = New TextBox()
        tbTenKh = New TextBox()
        Label9 = New Label()
        Label4 = New Label()
        tbDienthoaiKh = New TextBox()
        Label3 = New Label()
        GroupBox3 = New GroupBox()
        lbChiNhanh = New Label()
        Label7 = New Label()
        tbSoluong = New TextBox()
        Label5 = New Label()
        Label8 = New Label()
        tbKhuyenMai = New TextBox()
        Label6 = New Label()
        btnHuy = New Button()
        tbGhiChu = New TextBox()
        btnXacNhan = New Button()
        lbTongtien = New Label()
        dgvDonHang = New DataGridView()
        lbDateTime = New Label()
        SP_BindingSource = New BindingSource(components)
        CTDH_BindingSource = New BindingSource(components)
        lbNgayThang = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        CType(SP_BindingSource, ComponentModel.ISupportInitialize).BeginInit()
        CType(CTDH_BindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(12, 52)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(499, 499)
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
        dgvSanPham.Location = New Point(6, 22)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(487, 471)
        dgvSanPham.TabIndex = 7
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(73, 15)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.Size = New Size(220, 23)
        tbTuKhoa.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(299, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 2
        Label1.Text = "Ngày tháng"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(49, 15)
        Label2.TabIndex = 4
        Label2.Text = "Từ khoá"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(517, 198)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(87, 23)
        btnThem.TabIndex = 5
        btnThem.Text = "Thêm vào >"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(517, 238)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(87, 23)
        btnXoa.TabIndex = 6
        btnXoa.Text = "< Bỏ ra"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(GroupBox4)
        GroupBox2.Controls.Add(GroupBox3)
        GroupBox2.Controls.Add(dgvDonHang)
        GroupBox2.Location = New Point(619, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(540, 539)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Đơn hàng"
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(tbDiaChi)
        GroupBox4.Controls.Add(tbTenKh)
        GroupBox4.Controls.Add(Label9)
        GroupBox4.Controls.Add(Label4)
        GroupBox4.Controls.Add(tbDienthoaiKh)
        GroupBox4.Controls.Add(Label3)
        GroupBox4.Location = New Point(6, 22)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(521, 88)
        GroupBox4.TabIndex = 13
        GroupBox4.TabStop = False
        GroupBox4.Text = "Thông tin khách hàng"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(111, 59)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(240, 23)
        tbDiaChi.TabIndex = 51
        ' 
        ' tbTenKh
        ' 
        tbTenKh.Location = New Point(111, 27)
        tbTenKh.Name = "tbTenKh"
        tbTenKh.Size = New Size(150, 23)
        tbTenKh.TabIndex = 47
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(14, 62)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 15)
        Label9.TabIndex = 50
        Label9.Text = "Địa chỉ"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(14, 30)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 46
        Label4.Text = "Tên Khách hàng"
        ' 
        ' tbDienthoaiKh
        ' 
        tbDienthoaiKh.Location = New Point(335, 27)
        tbDienthoaiKh.Name = "tbDienthoaiKh"
        tbDienthoaiKh.Size = New Size(151, 23)
        tbDienthoaiKh.TabIndex = 49
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(268, 30)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 48
        Label3.Text = "Điện thoại"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lbChiNhanh)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Controls.Add(tbSoluong)
        GroupBox3.Controls.Add(Label5)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(tbKhuyenMai)
        GroupBox3.Controls.Add(Label6)
        GroupBox3.Controls.Add(btnHuy)
        GroupBox3.Controls.Add(tbGhiChu)
        GroupBox3.Controls.Add(btnXacNhan)
        GroupBox3.Controls.Add(lbTongtien)
        GroupBox3.Location = New Point(6, 116)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(528, 98)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Chi tiết ĐH"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.ForeColor = Color.Red
        lbChiNhanh.Location = New Point(79, 27)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(29, 15)
        lbChiNhanh.TabIndex = 45
        lbChiNhanh.Text = "N/A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(234, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 15)
        Label7.TabIndex = 17
        Label7.Text = "Số lượng"
        ' 
        ' tbSoluong
        ' 
        tbSoluong.Location = New Point(291, 24)
        tbSoluong.Name = "tbSoluong"
        tbSoluong.Size = New Size(60, 23)
        tbSoluong.TabIndex = 18
        tbSoluong.Text = "1"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 15)
        Label5.TabIndex = 44
        Label5.Text = "Chi nhánh"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(357, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 15)
        Label8.TabIndex = 19
        Label8.Text = "Khuyến mãi (%)"
        ' 
        ' tbKhuyenMai
        ' 
        tbKhuyenMai.Location = New Point(454, 24)
        tbKhuyenMai.Name = "tbKhuyenMai"
        tbKhuyenMai.Size = New Size(43, 23)
        tbKhuyenMai.TabIndex = 20
        tbKhuyenMai.Text = "1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(11, 66)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 15)
        Label6.TabIndex = 21
        Label6.Text = "Ghi chú"
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(422, 62)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(75, 23)
        btnHuy.TabIndex = 15
        btnHuy.Text = "Huỷ"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(79, 62)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(186, 23)
        tbGhiChu.TabIndex = 22
        tbGhiChu.Text = "abc"
        ' 
        ' btnXacNhan
        ' 
        btnXacNhan.Location = New Point(335, 61)
        btnXacNhan.Name = "btnXacNhan"
        btnXacNhan.Size = New Size(75, 23)
        btnXacNhan.TabIndex = 14
        btnXacNhan.Text = "Xác nhận"
        btnXacNhan.UseVisualStyleBackColor = True
        ' 
        ' lbTongtien
        ' 
        lbTongtien.AutoSize = True
        lbTongtien.ForeColor = Color.Red
        lbTongtien.Location = New Point(272, 66)
        lbTongtien.Name = "lbTongtien"
        lbTongtien.Size = New Size(13, 15)
        lbTongtien.TabIndex = 16
        lbTongtien.Text = "0"
        ' 
        ' dgvDonHang
        ' 
        dgvDonHang.AllowUserToAddRows = False
        dgvDonHang.AllowUserToDeleteRows = False
        dgvDonHang.AllowUserToResizeColumns = False
        dgvDonHang.AllowUserToResizeRows = False
        dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDonHang.Location = New Point(6, 225)
        dgvDonHang.Name = "dgvDonHang"
        dgvDonHang.ReadOnly = True
        dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDonHang.Size = New Size(528, 308)
        dgvDonHang.TabIndex = 7
        ' 
        ' lbDateTime
        ' 
        lbDateTime.AutoSize = True
        lbDateTime.ForeColor = Color.Red
        lbDateTime.Location = New Point(374, 23)
        lbDateTime.Name = "lbDateTime"
        lbDateTime.Size = New Size(0, 15)
        lbDateTime.TabIndex = 9
        ' 
        ' lbNgayThang
        ' 
        lbNgayThang.AutoSize = True
        lbNgayThang.ForeColor = Color.Red
        lbNgayThang.Location = New Point(380, 23)
        lbNgayThang.Name = "lbNgayThang"
        lbNgayThang.Size = New Size(29, 15)
        lbNgayThang.TabIndex = 10
        lbNgayThang.Text = "N/A"
        ' 
        ' FormChiTietDonHang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1171, 563)
        Controls.Add(lbNgayThang)
        Controls.Add(lbDateTime)
        Controls.Add(GroupBox2)
        Controls.Add(btnXoa)
        Controls.Add(btnThem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbTuKhoa)
        Controls.Add(GroupBox1)
        Name = "FormChiTietDonHang"
        Text = "FormTaoDonHang"
        GroupBox1.ResumeLayout(False)
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        CType(SP_BindingSource, ComponentModel.ISupportInitialize).EndInit()
        CType(CTDH_BindingSource, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvDonHang As DataGridView
    Friend WithEvents lbTongtien As Label
    Friend WithEvents btnHuy As Button
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
End Class
