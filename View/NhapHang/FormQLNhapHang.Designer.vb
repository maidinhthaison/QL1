<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLNhapHang
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
        dgvPhieuNhap = New DataGridView()
        btnTaoPhieuNhap = New Button()
        GroupBox2 = New GroupBox()
        Panel3 = New Panel()
        Label12 = New Label()
        lbTongTien = New Label()
        Label10 = New Label()
        lbTongThanhTien = New Label()
        Panel2 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        lbTongKhuyenMai = New Label()
        Label11 = New Label()
        lbTongSp = New Label()
        Panel1 = New Panel()
        Label8 = New Label()
        Label4 = New Label()
        Label6 = New Label()
        lbChiNhanh = New Label()
        lbCode = New Label()
        tbGhiChu = New RichTextBox()
        lbNguoiLap = New Label()
        Label5 = New Label()
        lbNgayNhap = New Label()
        Label7 = New Label()
        dgvSanPham = New DataGridView()
        BindingSource_PhieuNhap = New BindingSource(components)
        BindingSource_SanPham = New BindingSource(components)
        GroupBox1.SuspendLayout()
        CType(dgvPhieuNhap, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_PhieuNhap, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_SanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(dtPicker)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(dgvPhieuNhap)
        GroupBox1.Controls.Add(btnTaoPhieuNhap)
        GroupBox1.Location = New Point(12, 13)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(999, 972)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Danh Sách Phiếu Nhập"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(386, 41)
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
        Label1.Location = New Point(7, 38)
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
        tbTuKhoa.PlaceholderText = "Người lập, sản phẩm, số tiền..."
        tbTuKhoa.Size = New Size(294, 27)
        tbTuKhoa.TabIndex = 6
        ' 
        ' dgvPhieuNhap
        ' 
        dgvPhieuNhap.AllowUserToAddRows = False
        dgvPhieuNhap.AllowUserToDeleteRows = False
        dgvPhieuNhap.AllowUserToResizeColumns = False
        dgvPhieuNhap.AllowUserToResizeRows = False
        dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPhieuNhap.Location = New Point(7, 79)
        dgvPhieuNhap.Margin = New Padding(3, 4, 3, 4)
        dgvPhieuNhap.Name = "dgvPhieuNhap"
        dgvPhieuNhap.ReadOnly = True
        dgvPhieuNhap.RowHeadersWidth = 51
        dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPhieuNhap.Size = New Size(986, 885)
        dgvPhieuNhap.TabIndex = 4
        ' 
        ' btnTaoPhieuNhap
        ' 
        btnTaoPhieuNhap.Location = New Point(751, 33)
        btnTaoPhieuNhap.Margin = New Padding(3, 4, 3, 4)
        btnTaoPhieuNhap.Name = "btnTaoPhieuNhap"
        btnTaoPhieuNhap.Size = New Size(86, 31)
        btnTaoPhieuNhap.TabIndex = 9
        btnTaoPhieuNhap.Text = "Tạo Phiếu"
        btnTaoPhieuNhap.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Panel3)
        GroupBox2.Controls.Add(Panel2)
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(dgvSanPham)
        GroupBox2.Location = New Point(1017, 22)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(714, 963)
        GroupBox2.TabIndex = 49
        GroupBox2.TabStop = False
        GroupBox2.Text = "Thông tin phiếu nhập"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(lbTongTien)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(lbTongThanhTien)
        Panel3.Location = New Point(6, 731)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(695, 51)
        Panel3.TabIndex = 61
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label12.Location = New Point(237, 14)
        Label12.Name = "Label12"
        Label12.Size = New Size(138, 23)
        Label12.TabIndex = 57
        Label12.Text = "Tổng thành tiền"
        ' 
        ' lbTongTien
        ' 
        lbTongTien.AutoSize = True
        lbTongTien.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbTongTien.ForeColor = Color.Red
        lbTongTien.Location = New Point(103, 14)
        lbTongTien.Name = "lbTongTien"
        lbTongTien.Size = New Size(20, 23)
        lbTongTien.TabIndex = 36
        lbTongTien.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label10.Location = New Point(10, 14)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 23)
        Label10.TabIndex = 24
        Label10.Text = "Tổng tiền"
        ' 
        ' lbTongThanhTien
        ' 
        lbTongThanhTien.AutoSize = True
        lbTongThanhTien.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbTongThanhTien.ForeColor = Color.Red
        lbTongThanhTien.Location = New Point(386, 14)
        lbTongThanhTien.Name = "lbTongThanhTien"
        lbTongThanhTien.Size = New Size(20, 23)
        lbTongThanhTien.TabIndex = 58
        lbTongThanhTien.Text = "0"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lbTongKhuyenMai)
        Panel2.Controls.Add(Label11)
        Panel2.Controls.Add(lbTongSp)
        Panel2.Location = New Point(10, 222)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(695, 63)
        Panel2.TabIndex = 60
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(193, 20)
        Label3.TabIndex = 9
        Label3.Text = "Sản phẩm trong phiếu nhập"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label2.Location = New Point(404, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 23)
        Label2.TabIndex = 8
        Label2.Text = "Tổng Khuyến mãi"
        ' 
        ' lbTongKhuyenMai
        ' 
        lbTongKhuyenMai.AutoSize = True
        lbTongKhuyenMai.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbTongKhuyenMai.ForeColor = Color.Blue
        lbTongKhuyenMai.Location = New Point(560, 21)
        lbTongKhuyenMai.Name = "lbTongKhuyenMai"
        lbTongKhuyenMai.Size = New Size(20, 23)
        lbTongKhuyenMai.TabIndex = 37
        lbTongKhuyenMai.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label11.Location = New Point(215, 21)
        Label11.Name = "Label11"
        Label11.Size = New Size(133, 23)
        Label11.TabIndex = 55
        Label11.Text = "Tổng sản phẩm"
        ' 
        ' lbTongSp
        ' 
        lbTongSp.AutoSize = True
        lbTongSp.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbTongSp.ForeColor = Color.Blue
        lbTongSp.Location = New Point(355, 21)
        lbTongSp.Name = "lbTongSp"
        lbTongSp.Size = New Size(20, 23)
        lbTongSp.TabIndex = 56
        lbTongSp.Text = "0"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(lbChiNhanh)
        Panel1.Controls.Add(lbCode)
        Panel1.Controls.Add(tbGhiChu)
        Panel1.Controls.Add(lbNguoiLap)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(lbNgayNhap)
        Panel1.Controls.Add(Label7)
        Panel1.Location = New Point(10, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(695, 187)
        Panel1.TabIndex = 59
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(9, 11)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 31
        Label8.Text = "Chi nhánh"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 59)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 34
        Label4.Text = "Code"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(81, 20)
        Label6.TabIndex = 40
        Label6.Text = "Ngày nhập"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.ForeColor = Color.Blue
        lbChiNhanh.Location = New Point(133, 11)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 45
        lbChiNhanh.Text = "N/A"
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Location = New Point(133, 59)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(36, 20)
        lbCode.TabIndex = 46
        lbCode.Text = "N/A"
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(372, 59)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(306, 102)
        tbGhiChu.TabIndex = 51
        tbGhiChu.Text = ""
        ' 
        ' lbNguoiLap
        ' 
        lbNguoiLap.AutoSize = True
        lbNguoiLap.ForeColor = Color.Blue
        lbNguoiLap.Location = New Point(372, 13)
        lbNguoiLap.Name = "lbNguoiLap"
        lbNguoiLap.Size = New Size(36, 20)
        lbNguoiLap.TabIndex = 53
        lbNguoiLap.Text = "N/A"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(276, 62)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 20)
        Label5.TabIndex = 50
        Label5.Text = "Ghi chú"
        ' 
        ' lbNgayNhap
        ' 
        lbNgayNhap.AutoSize = True
        lbNgayNhap.ForeColor = Color.Blue
        lbNgayNhap.Location = New Point(133, 113)
        lbNgayNhap.Name = "lbNgayNhap"
        lbNgayNhap.Size = New Size(36, 20)
        lbNgayNhap.TabIndex = 54
        lbNgayNhap.Text = "N/A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(276, 13)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 52
        Label7.Text = "Người lập"
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.AllowUserToAddRows = False
        dgvSanPham.AllowUserToDeleteRows = False
        dgvSanPham.AllowUserToResizeColumns = False
        dgvSanPham.AllowUserToResizeRows = False
        dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Location = New Point(6, 294)
        dgvSanPham.Margin = New Padding(3, 4, 3, 4)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(699, 416)
        dgvSanPham.TabIndex = 49
        ' 
        ' FormQLNhapHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1742, 991)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLNhapHang"
        Text = "Nhập Hàng"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvPhieuNhap, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_PhieuNhap, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_SanPham, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents dgvPhieuNhap As DataGridView
    Friend WithEvents btnTaoPhieuNhap As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbNguoiLap As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbGhiChu As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lbCode As Label
    Friend WithEvents lbTongTien As Label
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents lbTongKhuyenMai As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTongSp As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbNgayNhap As Label
    Friend WithEvents lbTongThanhTien As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BindingSource_PhieuNhap As BindingSource
    Friend WithEvents BindingSource_SanPham As BindingSource
End Class
