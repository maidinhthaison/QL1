<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChiTietNhapHang
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
        Panel1 = New Panel()
        lbNgayThang = New Label()
        Label2 = New Label()
        tbTuKhoa = New TextBox()
        Label1 = New Label()
        lbChiNhanh = New Label()
        Label5 = New Label()
        dgvSanPham = New DataGridView()
        GroupBox1 = New GroupBox()
        tbGhiChu = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        tbSoluong = New TextBox()
        tbKhuyenMai = New TextBox()
        Label7 = New Label()
        GroupBox3 = New GroupBox()
        Panel3 = New Panel()
        btnBora = New Button()
        btnThem = New Button()
        Label14 = New Label()
        btnXacNhan = New Button()
        btnHuy = New Button()
        Label11 = New Label()
        lbTongKM = New Label()
        Label3 = New Label()
        lbTongThanhTien = New Label()
        lbTongtien = New Label()
        Panel2 = New Panel()
        lbDonVi = New Label()
        Label13 = New Label()
        lbDonGia = New Label()
        Label12 = New Label()
        lbSanPham = New Label()
        Label10 = New Label()
        lbLoaiSP = New Label()
        Label9 = New Label()
        lbNhaCC = New Label()
        Label4 = New Label()
        dgvCTPhieuNhap = New DataGridView()
        BindingSource_SanPham = New BindingSource(components)
        BindingSource_CTPhieuNhap = New BindingSource(components)
        Panel1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvCTPhieuNhap, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_SanPham, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_CTPhieuNhap, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbNgayThang)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(tbTuKhoa)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lbChiNhanh)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(946, 66)
        Panel1.TabIndex = 0
        ' 
        ' lbNgayThang
        ' 
        lbNgayThang.AutoSize = True
        lbNgayThang.Font = New Font("Segoe UI", 9F)
        lbNgayThang.ForeColor = Color.Red
        lbNgayThang.Location = New Point(592, 19)
        lbNgayThang.Name = "lbNgayThang"
        lbNgayThang.Size = New Size(36, 20)
        lbNgayThang.TabIndex = 15
        lbNgayThang.Text = "N/A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 20)
        Label2.TabIndex = 13
        Label2.Text = "Từ khoá"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(71, 16)
        tbTuKhoa.Margin = New Padding(3, 4, 3, 4)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.PlaceholderText = "Loại sản phẩm, nhà cung cấp, giá, khu vực, code, đơn vị..."
        tbTuKhoa.Size = New Size(403, 27)
        tbTuKhoa.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(500, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 12
        Label1.Text = "Ngày tháng"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.Font = New Font("Segoe UI", 9F)
        lbChiNhanh.ForeColor = Color.Red
        lbChiNhanh.Location = New Point(829, 19)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 45
        lbChiNhanh.Text = "N/A"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(749, 19)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 20)
        Label5.TabIndex = 44
        Label5.Text = "Chi nhánh"
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
        dgvSanPham.Size = New Size(937, 509)
        dgvSanPham.TabIndex = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(15, 84)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(956, 549)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Sản Phẩm"
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(449, 79)
        tbGhiChu.Margin = New Padding(3, 4, 3, 4)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(227, 27)
        tbGhiChu.TabIndex = 22
        tbGhiChu.Text = "abc"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(385, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 20)
        Label6.TabIndex = 21
        Label6.Text = "Ghi chú"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(188, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(112, 20)
        Label8.TabIndex = 19
        Label8.Text = "Khuyến mãi (%)"
        ' 
        ' tbSoluong
        ' 
        tbSoluong.Location = New Point(82, 78)
        tbSoluong.Margin = New Padding(3, 4, 3, 4)
        tbSoluong.Name = "tbSoluong"
        tbSoluong.Size = New Size(66, 27)
        tbSoluong.TabIndex = 18
        tbSoluong.Text = "1"
        ' 
        ' tbKhuyenMai
        ' 
        tbKhuyenMai.Location = New Point(306, 78)
        tbKhuyenMai.Margin = New Padding(3, 4, 3, 4)
        tbKhuyenMai.Name = "tbKhuyenMai"
        tbKhuyenMai.Size = New Size(63, 27)
        tbKhuyenMai.TabIndex = 20
        tbKhuyenMai.Text = "1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(7, 82)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 20)
        Label7.TabIndex = 17
        Label7.Text = "Số lượng"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Panel3)
        GroupBox3.Controls.Add(Panel2)
        GroupBox3.Controls.Add(dgvCTPhieuNhap)
        GroupBox3.Location = New Point(977, 12)
        GroupBox3.Margin = New Padding(3, 4, 3, 4)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 4, 3, 4)
        GroupBox3.Size = New Size(721, 621)
        GroupBox3.TabIndex = 13
        GroupBox3.TabStop = False
        GroupBox3.Text = "Chi tiết phiếu nhập"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnBora)
        Panel3.Controls.Add(btnThem)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(btnXacNhan)
        Panel3.Controls.Add(btnHuy)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(lbTongKM)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(lbTongThanhTien)
        Panel3.Controls.Add(lbTongtien)
        Panel3.Location = New Point(16, 160)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(693, 104)
        Panel3.TabIndex = 61
        ' 
        ' btnBora
        ' 
        btnBora.Location = New Point(149, 9)
        btnBora.Margin = New Padding(3, 4, 3, 4)
        btnBora.Name = "btnBora"
        btnBora.Size = New Size(109, 42)
        btnBora.TabIndex = 61
        btnBora.Text = "Bỏ ra"
        btnBora.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(9, 9)
        btnThem.Margin = New Padding(3, 4, 3, 4)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(109, 42)
        btnThem.TabIndex = 6
        btnThem.Text = "Thêm vào"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(218, 66)
        Label14.Name = "Label14"
        Label14.Size = New Size(69, 20)
        Label14.TabIndex = 60
        Label14.Text = "Tổng KM"
        ' 
        ' btnXacNhan
        ' 
        btnXacNhan.Location = New Point(449, 8)
        btnXacNhan.Margin = New Padding(3, 4, 3, 4)
        btnXacNhan.Name = "btnXacNhan"
        btnXacNhan.Size = New Size(105, 42)
        btnXacNhan.TabIndex = 14
        btnXacNhan.Text = "Xác nhận"
        btnXacNhan.UseVisualStyleBackColor = True
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(604, 9)
        btnHuy.Margin = New Padding(3, 4, 3, 4)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(86, 41)
        btnHuy.TabIndex = 15
        btnHuy.Text = "Huỷ"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(365, 66)
        Label11.Name = "Label11"
        Label11.Size = New Size(78, 20)
        Label11.TabIndex = 47
        Label11.Text = "Thành tiền"
        ' 
        ' lbTongKM
        ' 
        lbTongKM.AutoSize = True
        lbTongKM.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTongKM.ForeColor = Color.Red
        lbTongKM.Location = New Point(297, 66)
        lbTongKM.Name = "lbTongKM"
        lbTongKM.Size = New Size(18, 20)
        lbTongKM.TabIndex = 59
        lbTongKM.Text = "0"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 48
        Label3.Text = "Tổng tiền"
        ' 
        ' lbTongThanhTien
        ' 
        lbTongThanhTien.AutoSize = True
        lbTongThanhTien.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTongThanhTien.ForeColor = Color.Red
        lbTongThanhTien.Location = New Point(459, 66)
        lbTongThanhTien.Name = "lbTongThanhTien"
        lbTongThanhTien.Size = New Size(18, 20)
        lbTongThanhTien.TabIndex = 58
        lbTongThanhTien.Text = "0"
        ' 
        ' lbTongtien
        ' 
        lbTongtien.AutoSize = True
        lbTongtien.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTongtien.ForeColor = Color.Red
        lbTongtien.Location = New Point(88, 66)
        lbTongtien.Name = "lbTongtien"
        lbTongtien.Size = New Size(18, 20)
        lbTongtien.TabIndex = 16
        lbTongtien.Text = "0"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbDonVi)
        Panel2.Controls.Add(tbGhiChu)
        Panel2.Controls.Add(Label13)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(lbDonGia)
        Panel2.Controls.Add(tbSoluong)
        Panel2.Controls.Add(Label12)
        Panel2.Controls.Add(tbKhuyenMai)
        Panel2.Controls.Add(lbSanPham)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(lbLoaiSP)
        Panel2.Controls.Add(Label9)
        Panel2.Controls.Add(lbNhaCC)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(16, 27)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(693, 125)
        Panel2.TabIndex = 48
        ' 
        ' lbDonVi
        ' 
        lbDonVi.AutoSize = True
        lbDonVi.Font = New Font("Segoe UI", 9F)
        lbDonVi.ForeColor = Color.Blue
        lbDonVi.Location = New Point(615, 40)
        lbDonVi.Name = "lbDonVi"
        lbDonVi.Size = New Size(36, 20)
        lbDonVi.TabIndex = 57
        lbDonVi.Text = "N/A"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(557, 40)
        Label13.Name = "Label13"
        Label13.Size = New Size(52, 20)
        Label13.TabIndex = 56
        Label13.Text = "Đơn vị"
        ' 
        ' lbDonGia
        ' 
        lbDonGia.AutoSize = True
        lbDonGia.Font = New Font("Segoe UI", 9F)
        lbDonGia.ForeColor = Color.Blue
        lbDonGia.Location = New Point(464, 40)
        lbDonGia.Name = "lbDonGia"
        lbDonGia.Size = New Size(36, 20)
        lbDonGia.TabIndex = 55
        lbDonGia.Text = "N/A"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(396, 41)
        Label12.Name = "Label12"
        Label12.Size = New Size(62, 20)
        Label12.TabIndex = 54
        Label12.Text = "Đơn giá"
        ' 
        ' lbSanPham
        ' 
        lbSanPham.AutoSize = True
        lbSanPham.Font = New Font("Segoe UI", 9F)
        lbSanPham.ForeColor = Color.Blue
        lbSanPham.Location = New Point(112, 45)
        lbSanPham.Name = "lbSanPham"
        lbSanPham.Size = New Size(36, 20)
        lbSanPham.TabIndex = 53
        lbSanPham.Text = "N/A"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 45)
        Label10.Name = "Label10"
        Label10.Size = New Size(75, 20)
        Label10.TabIndex = 52
        Label10.Text = "Sản phẩm"
        ' 
        ' lbLoaiSP
        ' 
        lbLoaiSP.AutoSize = True
        lbLoaiSP.Font = New Font("Segoe UI", 9F)
        lbLoaiSP.ForeColor = Color.Blue
        lbLoaiSP.Location = New Point(345, 14)
        lbLoaiSP.Name = "lbLoaiSP"
        lbLoaiSP.Size = New Size(36, 20)
        lbLoaiSP.TabIndex = 51
        lbLoaiSP.Text = "N/A"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(232, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(107, 20)
        Label9.TabIndex = 50
        Label9.Text = "Loại Sản phẩm"
        ' 
        ' lbNhaCC
        ' 
        lbNhaCC.AutoSize = True
        lbNhaCC.Font = New Font("Segoe UI", 9F)
        lbNhaCC.ForeColor = Color.Blue
        lbNhaCC.Location = New Point(112, 14)
        lbNhaCC.Name = "lbNhaCC"
        lbNhaCC.Size = New Size(36, 20)
        lbNhaCC.TabIndex = 46
        lbNhaCC.Text = "N/A"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 20)
        Label4.TabIndex = 49
        Label4.Text = "Nhà cung cấp"
        ' 
        ' dgvCTPhieuNhap
        ' 
        dgvCTPhieuNhap.AllowUserToAddRows = False
        dgvCTPhieuNhap.AllowUserToDeleteRows = False
        dgvCTPhieuNhap.AllowUserToResizeColumns = False
        dgvCTPhieuNhap.AllowUserToResizeRows = False
        dgvCTPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCTPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCTPhieuNhap.Location = New Point(16, 271)
        dgvCTPhieuNhap.Margin = New Padding(3, 4, 3, 4)
        dgvCTPhieuNhap.Name = "dgvCTPhieuNhap"
        dgvCTPhieuNhap.ReadOnly = True
        dgvCTPhieuNhap.RowHeadersWidth = 51
        dgvCTPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCTPhieuNhap.Size = New Size(699, 340)
        dgvCTPhieuNhap.TabIndex = 7
        ' 
        ' FormChiTietNhapHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1709, 648)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "FormChiTietNhapHang"
        Text = "Chi tiết nhập hàng"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(dgvCTPhieuNhap, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_SanPham, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_CTPhieuNhap, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbNgayThang As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents dgvCTPhieuNhap As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents tbSoluong As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbKhuyenMai As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnXacNhan As Button
    Friend WithEvents tbGhiChu As TextBox
    Friend WithEvents lbTongtien As Label
    Friend WithEvents BindingSource_SanPham As BindingSource
    Friend WithEvents BindingSource_CTPhieuNhap As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbNhaCC As Label
    Friend WithEvents lbLoaiSP As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbDonGia As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbSanPham As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbDonVi As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lbTongKM As Label
    Friend WithEvents lbTongThanhTien As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnBora As Button
End Class
