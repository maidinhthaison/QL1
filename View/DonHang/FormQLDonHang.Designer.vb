<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLDonHang
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
        Label13 = New Label()
        dtPicker = New DateTimePicker()
        Label1 = New Label()
        tbTuKhoa = New TextBox()
        dgvDonHang = New DataGridView()
        btnTaoDon = New Button()
        Panel1 = New Panel()
        GroupBox2 = New GroupBox()
        Button1 = New Button()
        btnCapNhat = New Button()
        lbNguoiLap = New Label()
        Label7 = New Label()
        tbGhiChu = New RichTextBox()
        Label5 = New Label()
        dgvSanPham = New DataGridView()
        lbDiaChi = New Label()
        Label3 = New Label()
        lbDienThoai = New Label()
        Label10 = New Label()
        lbTenKh = New Label()
        lbTongTien = New Label()
        lbChiNhanh = New Label()
        lbKhuyenMai = New Label()
        Label2 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        Label4 = New Label()
        bsPhieuBanHang = New BindingSource(components)
        BindingSource_CTDonHang = New BindingSource(components)
        GroupBox1.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsPhieuBanHang, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_CTDonHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(dtPicker)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(dgvDonHang)
        GroupBox1.Controls.Add(btnTaoDon)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1098, 972)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Danh Sách Đơn Hàng"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(386, 40)
        Label13.Name = "Label13"
        Label13.Size = New Size(86, 20)
        Label13.TabIndex = 48
        Label13.Text = "Ngày tháng"
        ' 
        ' dtPicker
        ' 
        dtPicker.Location = New Point(478, 35)
        dtPicker.Margin = New Padding(3, 4, 3, 4)
        dtPicker.Name = "dtPicker"
        dtPicker.Size = New Size(251, 27)
        dtPicker.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 7
        Label1.Text = "Từ khoá"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(70, 33)
        tbTuKhoa.Margin = New Padding(3, 4, 3, 4)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.PlaceholderText = "Khách Hàng, người lập, sản phẩm, số tiền..."
        tbTuKhoa.Size = New Size(294, 27)
        tbTuKhoa.TabIndex = 6
        ' 
        ' dgvDonHang
        ' 
        dgvDonHang.AllowUserToAddRows = False
        dgvDonHang.AllowUserToDeleteRows = False
        dgvDonHang.AllowUserToResizeColumns = False
        dgvDonHang.AllowUserToResizeRows = False
        dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDonHang.Location = New Point(7, 79)
        dgvDonHang.Margin = New Padding(3, 4, 3, 4)
        dgvDonHang.Name = "dgvDonHang"
        dgvDonHang.ReadOnly = True
        dgvDonHang.RowHeadersWidth = 51
        dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDonHang.Size = New Size(1085, 885)
        dgvDonHang.TabIndex = 4
        ' 
        ' btnTaoDon
        ' 
        btnTaoDon.Location = New Point(793, 33)
        btnTaoDon.Margin = New Padding(3, 4, 3, 4)
        btnTaoDon.Name = "btnTaoDon"
        btnTaoDon.Size = New Size(86, 31)
        btnTaoDon.TabIndex = 9
        btnTaoDon.Text = "Tạo Đơn"
        btnTaoDon.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(GroupBox2)
        Panel1.Location = New Point(1118, 13)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(627, 975)
        Panel1.TabIndex = 5
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Button1)
        GroupBox2.Controls.Add(btnCapNhat)
        GroupBox2.Controls.Add(lbNguoiLap)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(tbGhiChu)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(dgvSanPham)
        GroupBox2.Controls.Add(lbDiaChi)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(lbDienThoai)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(lbTenKh)
        GroupBox2.Controls.Add(lbTongTien)
        GroupBox2.Controls.Add(lbChiNhanh)
        GroupBox2.Controls.Add(lbKhuyenMai)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(9, 4)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(607, 963)
        GroupBox2.TabIndex = 44
        GroupBox2.TabStop = False
        GroupBox2.Text = "Thông tin đơn hàng"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(124, 917)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(86, 31)
        Button1.TabIndex = 54
        Button1.Text = "Xóa Đơn"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(10, 917)
        btnCapNhat.Margin = New Padding(3, 4, 3, 4)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(86, 31)
        btnCapNhat.TabIndex = 49
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' lbNguoiLap
        ' 
        lbNguoiLap.AutoSize = True
        lbNguoiLap.ForeColor = Color.Blue
        lbNguoiLap.Location = New Point(124, 78)
        lbNguoiLap.Name = "lbNguoiLap"
        lbNguoiLap.Size = New Size(36, 20)
        lbNguoiLap.TabIndex = 53
        lbNguoiLap.Text = "N/A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(10, 78)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 52
        Label7.Text = "Người lập"
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(9, 374)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(424, 102)
        tbGhiChu.TabIndex = 51
        tbGhiChu.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 20)
        Label5.TabIndex = 50
        Label5.Text = "Ghi chú"
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.AllowUserToAddRows = False
        dgvSanPham.AllowUserToDeleteRows = False
        dgvSanPham.AllowUserToResizeColumns = False
        dgvSanPham.AllowUserToResizeRows = False
        dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Location = New Point(9, 539)
        dgvSanPham.Margin = New Padding(3, 4, 3, 4)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(586, 350)
        dgvSanPham.TabIndex = 49
        ' 
        ' lbDiaChi
        ' 
        lbDiaChi.AutoSize = True
        lbDiaChi.Location = New Point(127, 231)
        lbDiaChi.Name = "lbDiaChi"
        lbDiaChi.Size = New Size(36, 20)
        lbDiaChi.TabIndex = 48
        lbDiaChi.Text = "N/A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 496)
        Label3.Name = "Label3"
        Label3.Size = New Size(182, 20)
        Label3.TabIndex = 9
        Label3.Text = "Sản phẩm trong đơn hàng"
        ' 
        ' lbDienThoai
        ' 
        lbDienThoai.AutoSize = True
        lbDienThoai.Location = New Point(127, 177)
        lbDienThoai.Name = "lbDienThoai"
        lbDienThoai.Size = New Size(36, 20)
        lbDienThoai.TabIndex = 47
        lbDienThoai.Text = "N/A"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(14, 288)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 20)
        Label10.TabIndex = 24
        Label10.Text = "Tổng tiền"
        ' 
        ' lbTenKh
        ' 
        lbTenKh.AutoSize = True
        lbTenKh.Location = New Point(127, 123)
        lbTenKh.Name = "lbTenKh"
        lbTenKh.Size = New Size(36, 20)
        lbTenKh.TabIndex = 46
        lbTenKh.Text = "N/A"
        ' 
        ' lbTongTien
        ' 
        lbTongTien.AutoSize = True
        lbTongTien.Font = New Font("Segoe UI", 10F)
        lbTongTien.ForeColor = Color.Red
        lbTongTien.Location = New Point(100, 285)
        lbTongTien.Name = "lbTongTien"
        lbTongTien.Size = New Size(19, 23)
        lbTongTien.TabIndex = 36
        lbTongTien.Text = "0"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.ForeColor = Color.Blue
        lbChiNhanh.Location = New Point(124, 39)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 45
        lbChiNhanh.Text = "N/A"
        ' 
        ' lbKhuyenMai
        ' 
        lbKhuyenMai.AutoSize = True
        lbKhuyenMai.Font = New Font("Segoe UI", 10F)
        lbKhuyenMai.ForeColor = Color.Blue
        lbKhuyenMai.Location = New Point(285, 285)
        lbKhuyenMai.Name = "lbKhuyenMai"
        lbKhuyenMai.Size = New Size(19, 23)
        lbKhuyenMai.TabIndex = 37
        lbKhuyenMai.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(193, 288)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 8
        Label2.Text = "Khuyến mãi"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(10, 231)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 20)
        Label9.TabIndex = 42
        Label9.Text = "Địa chỉ"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 177)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 20)
        Label6.TabIndex = 40
        Label6.Text = "Điện thoại"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 39)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 31
        Label8.Text = "Chi nhánh"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 123)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 34
        Label4.Text = "Tên Khách hàng"
        ' 
        ' FormQLDonHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1758, 1001)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLDonHang"
        Text = "FormQLBanHang"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        CType(bsPhieuBanHang, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_CTDonHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDonHang As DataGridView
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTongTien As Label
    Friend WithEvents lbKhuyenMai As Label
    Friend WithEvents btnTaoDon As Button
    Friend WithEvents bsPhieuBanHang As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents lbTenKh As Label
    Friend WithEvents lbDienThoai As Label
    Friend WithEvents lbDiaChi As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents tbGhiChu As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbNguoiLap As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents BindingSource_CTDonHang As BindingSource
End Class
