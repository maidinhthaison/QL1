<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTaoDonHang
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
        Panel1 = New Panel()
        tbKhuyenMai = New TextBox()
        Label8 = New Label()
        tbSoluong = New TextBox()
        Label7 = New Label()
        lbTongtien = New Label()
        lbtt = New Label()
        btnHuy = New Button()
        btnXacNhan = New Button()
        tbDiachiKh = New TextBox()
        Label5 = New Label()
        tbDienThoaiKh = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        tbTenKh = New TextBox()
        dgvDonHang = New DataGridView()
        lbDateTime = New Label()
        SP_BindingSource = New BindingSource(components)
        GroupBox1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        CType(SP_BindingSource, ComponentModel.ISupportInitialize).BeginInit()
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
        dgvSanPham.Location = New Point(6, 34)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(487, 459)
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
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Controls.Add(dgvDonHang)
        GroupBox2.Location = New Point(619, 52)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(540, 499)
        GroupBox2.TabIndex = 8
        GroupBox2.TabStop = False
        GroupBox2.Text = "Đơn hàng"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(tbKhuyenMai)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(tbSoluong)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lbTongtien)
        Panel1.Controls.Add(lbtt)
        Panel1.Controls.Add(btnHuy)
        Panel1.Controls.Add(btnXacNhan)
        Panel1.Controls.Add(tbDiachiKh)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(tbDienThoaiKh)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbTenKh)
        Panel1.Location = New Point(6, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(528, 128)
        Panel1.TabIndex = 11
        ' 
        ' tbKhuyenMai
        ' 
        tbKhuyenMai.Location = New Point(461, 54)
        tbKhuyenMai.Name = "tbKhuyenMai"
        tbKhuyenMai.Size = New Size(61, 23)
        tbKhuyenMai.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(364, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(91, 15)
        Label8.TabIndex = 19
        Label8.Text = "Khuyến mãi (%)"
        ' 
        ' tbSoluong
        ' 
        tbSoluong.Location = New Point(295, 54)
        tbSoluong.Name = "tbSoluong"
        tbSoluong.Size = New Size(63, 23)
        tbSoluong.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(228, 59)
        Label7.Name = "Label7"
        Label7.Size = New Size(54, 15)
        Label7.TabIndex = 17
        Label7.Text = "Số lượng"
        ' 
        ' lbTongtien
        ' 
        lbTongtien.AutoSize = True
        lbTongtien.ForeColor = Color.Red
        lbTongtien.Location = New Point(70, 98)
        lbTongtien.Name = "lbTongtien"
        lbTongtien.Size = New Size(57, 15)
        lbTongtien.TabIndex = 16
        lbTongtien.Text = "Tổng tiền"
        ' 
        ' lbtt
        ' 
        lbtt.AutoSize = True
        lbtt.Location = New Point(7, 98)
        lbtt.Name = "lbtt"
        lbtt.Size = New Size(57, 15)
        lbtt.TabIndex = 9
        lbtt.Text = "Tổng tiền"
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(255, 94)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(75, 23)
        btnHuy.TabIndex = 15
        btnHuy.Text = "Huỷ"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' btnXacNhan
        ' 
        btnXacNhan.Location = New Point(157, 94)
        btnXacNhan.Name = "btnXacNhan"
        btnXacNhan.Size = New Size(75, 23)
        btnXacNhan.TabIndex = 14
        btnXacNhan.Text = "Xác nhận"
        btnXacNhan.UseVisualStyleBackColor = True
        ' 
        ' tbDiachiKh
        ' 
        tbDiachiKh.Location = New Point(53, 51)
        tbDiachiKh.Name = "tbDiachiKh"
        tbDiachiKh.Size = New Size(169, 23)
        tbDiachiKh.TabIndex = 13
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(4, 54)
        Label5.Name = "Label5"
        Label5.Size = New Size(43, 15)
        Label5.TabIndex = 12
        Label5.Text = "Địa chỉ"
        ' 
        ' tbDienThoaiKh
        ' 
        tbDienThoaiKh.Location = New Point(295, 13)
        tbDienThoaiKh.Name = "tbDienThoaiKh"
        tbDienThoaiKh.Size = New Size(169, 23)
        tbDienThoaiKh.TabIndex = 11
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(228, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 15)
        Label4.TabIndex = 10
        Label4.Text = "Điện thoại"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 16)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 15)
        Label3.TabIndex = 8
        Label3.Text = "Tên KH"
        ' 
        ' tbTenKh
        ' 
        tbTenKh.Location = New Point(53, 12)
        tbTenKh.Name = "tbTenKh"
        tbTenKh.Size = New Size(169, 23)
        tbTenKh.TabIndex = 9
        ' 
        ' dgvDonHang
        ' 
        dgvDonHang.AllowUserToAddRows = False
        dgvDonHang.AllowUserToDeleteRows = False
        dgvDonHang.AllowUserToResizeColumns = False
        dgvDonHang.AllowUserToResizeRows = False
        dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDonHang.Location = New Point(6, 156)
        dgvDonHang.Name = "dgvDonHang"
        dgvDonHang.ReadOnly = True
        dgvDonHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvDonHang.Size = New Size(528, 337)
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
        ' FormTaoDonHang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1171, 563)
        Controls.Add(lbDateTime)
        Controls.Add(GroupBox2)
        Controls.Add(btnXoa)
        Controls.Add(btnThem)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbTuKhoa)
        Controls.Add(GroupBox1)
        Name = "FormTaoDonHang"
        Text = "FormTaoDonHang"
        GroupBox1.ResumeLayout(False)
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        CType(SP_BindingSource, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbtt As Label
    Friend WithEvents tbTenKh As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbDiachiKh As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDienThoaiKh As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTongtien As Label
    Friend WithEvents btnHuy As Button
    Friend WithEvents btnXacNhan As Button
    Friend WithEvents tbKhuyenMai As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSoluong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lbDateTime As Label
    Friend WithEvents SP_BindingSource As BindingSource
End Class
