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
        cbChiNhanh = New ComboBox()
        Label12 = New Label()
        dtPicker = New DateTimePicker()
        Label1 = New Label()
        tbTuKhoa = New TextBox()
        dgvDonHang = New DataGridView()
        btnTaoDon = New Button()
        Panel1 = New Panel()
        Label11 = New Label()
        lbDienThoai = New Label()
        lbTenKh = New Label()
        lbChiNhanh = New Label()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label10 = New Label()
        lvSanPham = New ListView()
        lbTongTien = New Label()
        Label5 = New Label()
        Label2 = New Label()
        Label9 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label8 = New Label()
        bsPhieuBanHang = New BindingSource(components)
        GroupBox1.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(bsPhieuBanHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label13)
        GroupBox1.Controls.Add(cbChiNhanh)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Controls.Add(dtPicker)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(dgvDonHang)
        GroupBox1.Controls.Add(btnTaoDon)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(906, 596)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý Đơn Hàng"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(347, 40)
        Label13.Name = "Label13"
        Label13.Size = New Size(86, 20)
        Label13.TabIndex = 48
        Label13.Text = "Ngày tháng"
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(630, 33)
        cbChiNhanh.Margin = New Padding(3, 4, 3, 4)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(170, 28)
        cbChiNhanh.TabIndex = 47
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(552, 40)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 20)
        Label12.TabIndex = 46
        Label12.Text = "Chi nhánh"
        ' 
        ' dtPicker
        ' 
        dtPicker.Location = New Point(433, 33)
        dtPicker.Margin = New Padding(3, 4, 3, 4)
        dtPicker.Name = "dtPicker"
        dtPicker.Size = New Size(111, 27)
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
        tbTuKhoa.PlaceholderText = "Khách Hàng, sản phẩm, chi nhánh, số tiền"
        tbTuKhoa.Size = New Size(270, 27)
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
        dgvDonHang.Size = New Size(893, 509)
        dgvDonHang.TabIndex = 4
        ' 
        ' btnTaoDon
        ' 
        btnTaoDon.Location = New Point(814, 35)
        btnTaoDon.Margin = New Padding(3, 4, 3, 4)
        btnTaoDon.Name = "btnTaoDon"
        btnTaoDon.Size = New Size(86, 31)
        btnTaoDon.TabIndex = 9
        btnTaoDon.Text = "Tạo Đơn"
        btnTaoDon.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label11)
        Panel1.Controls.Add(lbDienThoai)
        Panel1.Controls.Add(lbTenKh)
        Panel1.Controls.Add(lbChiNhanh)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(927, 16)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(387, 596)
        Panel1.TabIndex = 5
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(126, 177)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 20)
        Label11.TabIndex = 48
        Label11.Text = "N/A"
        ' 
        ' lbDienThoai
        ' 
        lbDienThoai.AutoSize = True
        lbDienThoai.Location = New Point(126, 123)
        lbDienThoai.Name = "lbDienThoai"
        lbDienThoai.Size = New Size(36, 20)
        lbDienThoai.TabIndex = 47
        lbDienThoai.Text = "N/A"
        ' 
        ' lbTenKh
        ' 
        lbTenKh.AutoSize = True
        lbTenKh.Location = New Point(126, 69)
        lbTenKh.Name = "lbTenKh"
        lbTenKh.Size = New Size(36, 20)
        lbTenKh.TabIndex = 46
        lbTenKh.Text = "N/A"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.Location = New Point(126, 21)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 45
        lbChiNhanh.Text = "N/A"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(lvSanPham)
        GroupBox2.Controls.Add(lbTongTien)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(9, 223)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(375, 365)
        GroupBox2.TabIndex = 44
        GroupBox2.TabStop = False
        GroupBox2.Text = "Thông tin đơn hàng"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 9
        Label3.Text = "Sản phẩm"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(7, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(72, 20)
        Label10.TabIndex = 24
        Label10.Text = "Tổng tiền"
        ' 
        ' lvSanPham
        ' 
        lvSanPham.Location = New Point(102, 81)
        lvSanPham.Margin = New Padding(3, 4, 3, 4)
        lvSanPham.Name = "lvSanPham"
        lvSanPham.Size = New Size(266, 276)
        lvSanPham.TabIndex = 38
        lvSanPham.UseCompatibleStateImageBehavior = False
        ' 
        ' lbTongTien
        ' 
        lbTongTien.AutoSize = True
        lbTongTien.ForeColor = Color.Red
        lbTongTien.Location = New Point(103, 41)
        lbTongTien.Name = "lbTongTien"
        lbTongTien.Size = New Size(17, 20)
        lbTongTien.TabIndex = 36
        lbTongTien.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(259, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(17, 20)
        Label5.TabIndex = 37
        Label5.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(173, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 8
        Label2.Text = "Khuyến mãi"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(9, 177)
        Label9.Name = "Label9"
        Label9.Size = New Size(55, 20)
        Label9.TabIndex = 42
        Label9.Text = "Địa chỉ"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(9, 123)
        Label6.Name = "Label6"
        Label6.Size = New Size(78, 20)
        Label6.TabIndex = 40
        Label6.Text = "Điện thoại"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 69)
        Label4.Name = "Label4"
        Label4.Size = New Size(113, 20)
        Label4.TabIndex = 34
        Label4.Text = "Tên Khách hàng"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(8, 21)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 31
        Label8.Text = "Chi nhánh"
        ' 
        ' FormQLDonHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1328, 628)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLDonHang"
        Text = "FormQLBanHang"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(bsPhieuBanHang, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lvSanPham As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTaoDon As Button
    Friend WithEvents bsPhieuBanHang As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents lbTenKh As Label
    Friend WithEvents lbDienThoai As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents Label12 As Label
End Class
