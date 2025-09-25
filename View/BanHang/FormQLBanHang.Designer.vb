<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLBanHang
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
        btnTaoDon = New Button()
        dtPicker = New DateTimePicker()
        Label1 = New Label()
        tbTuKhoa = New TextBox()
        Panel1 = New Panel()
        lvSanPham = New ListView()
        Label5 = New Label()
        lbTongTien = New Label()
        lbKhachHang = New Label()
        Label4 = New Label()
        rtbGhiChu = New RichTextBox()
        cbChiNhanh = New ComboBox()
        Label8 = New Label()
        Label10 = New Label()
        btnXoa = New Button()
        btnCapNhat = New Button()
        btnThem = New Button()
        Label7 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dgvDonHang = New DataGridView()
        bsPhieuBanHang = New BindingSource(components)
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsPhieuBanHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTaoDon)
        GroupBox1.Controls.Add(dtPicker)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvDonHang)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 426)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý Đơn Hàng"
        ' 
        ' btnTaoDon
        ' 
        btnTaoDon.Location = New Point(451, 30)
        btnTaoDon.Name = "btnTaoDon"
        btnTaoDon.Size = New Size(75, 23)
        btnTaoDon.TabIndex = 9
        btnTaoDon.Text = "Tạo Đơn"
        btnTaoDon.UseVisualStyleBackColor = True
        ' 
        ' dtPicker
        ' 
        dtPicker.Location = New Point(347, 30)
        dtPicker.Name = "dtPicker"
        dtPicker.Size = New Size(98, 23)
        dtPicker.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 7
        Label1.Text = "Từ khoá"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(61, 30)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.PlaceholderText = "Khách Hàng, sản phẩm, chi nhánh, số tiền"
        tbTuKhoa.Size = New Size(280, 23)
        tbTuKhoa.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lvSanPham)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(lbTongTien)
        Panel1.Controls.Add(lbKhachHang)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(rtbGhiChu)
        Panel1.Controls.Add(cbChiNhanh)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(538, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(238, 398)
        Panel1.TabIndex = 5
        ' 
        ' lvSanPham
        ' 
        lvSanPham.Location = New Point(77, 158)
        lvSanPham.Name = "lvSanPham"
        lvSanPham.Size = New Size(155, 125)
        lvSanPham.TabIndex = 38
        lvSanPham.UseCompatibleStateImageBehavior = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(99, 129)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 15)
        Label5.TabIndex = 37
        Label5.Text = "5,000"
        ' 
        ' lbTongTien
        ' 
        lbTongTien.AutoSize = True
        lbTongTien.Location = New Point(99, 91)
        lbTongTien.Name = "lbTongTien"
        lbTongTien.Size = New Size(40, 15)
        lbTongTien.TabIndex = 36
        lbTongTien.Text = "50,000"
        ' 
        ' lbKhachHang
        ' 
        lbKhachHang.AutoSize = True
        lbKhachHang.Location = New Point(99, 52)
        lbKhachHang.Name = "lbKhachHang"
        lbKhachHang.Size = New Size(52, 15)
        lbKhachHang.TabIndex = 35
        lbKhachHang.Text = "Thai Son"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 15)
        Label4.TabIndex = 34
        Label4.Text = "Khách hàng"
        ' 
        ' rtbGhiChu
        ' 
        rtbGhiChu.Location = New Point(77, 289)
        rtbGhiChu.Name = "rtbGhiChu"
        rtbGhiChu.Size = New Size(155, 68)
        rtbGhiChu.TabIndex = 33
        rtbGhiChu.Text = ""
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(99, 13)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(124, 23)
        cbChiNhanh.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 16)
        Label8.Name = "Label8"
        Label8.Size = New Size(62, 15)
        Label8.TabIndex = 31
        Label8.Text = "Chi nhánh"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(8, 91)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 15)
        Label10.TabIndex = 24
        Label10.Text = "Tổng tiền"
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(99, 363)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(53, 23)
        btnXoa.TabIndex = 21
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(160, 363)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(75, 23)
        btnCapNhat.TabIndex = 20
        btnCapNhat.Text = "Cập Nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(8, 363)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(75, 23)
        btnThem.TabIndex = 19
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(8, 302)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 15)
        Label7.TabIndex = 15
        Label7.Text = "Ghi chú"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 9
        Label3.Text = "Sản phẩm"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(8, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 8
        Label2.Text = "Khuyến mãi"
        ' 
        ' dgvDonHang
        ' 
        dgvDonHang.AllowUserToAddRows = False
        dgvDonHang.AllowUserToDeleteRows = False
        dgvDonHang.AllowUserToResizeColumns = False
        dgvDonHang.AllowUserToResizeRows = False
        dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDonHang.Location = New Point(6, 59)
        dgvDonHang.Name = "dgvDonHang"
        dgvDonHang.ReadOnly = True
        dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDonHang.Size = New Size(520, 361)
        dgvDonHang.TabIndex = 4
        ' 
        ' FormQLBanHang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "FormQLBanHang"
        Text = "FormQLBanHang"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        CType(bsPhieuBanHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDonHang As DataGridView
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents rtbGhiChu As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTongTien As Label
    Friend WithEvents lbKhachHang As Label
    Friend WithEvents lvSanPham As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTaoDon As Button
    Friend WithEvents bsPhieuBanHang As BindingSource
End Class
