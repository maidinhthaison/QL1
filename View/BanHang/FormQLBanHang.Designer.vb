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
        GroupBox1 = New GroupBox()
        dgvSanPham = New DataGridView()
        tbTuKhoa = New TextBox()
        Label1 = New Label()
        cbChiNhanh = New ComboBox()
        Label2 = New Label()
        btnThem = New Button()
        Button1 = New Button()
        GroupBox2 = New GroupBox()
        dgvDonHang = New DataGridView()
        lbTongTien = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Panel1 = New Panel()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        btnXacNhan = New Button()
        Button2 = New Button()
        Label6 = New Label()
        Label7 = New Label()
        TextBox4 = New TextBox()
        Label8 = New Label()
        TextBox5 = New TextBox()
        GroupBox1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
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
        tbTuKhoa.Location = New Point(291, 18)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.Size = New Size(220, 23)
        tbTuKhoa.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 2
        Label1.Text = "Chi nhánh"
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(80, 18)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(137, 23)
        cbChiNhanh.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(223, 21)
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
        ' Button1
        ' 
        Button1.Location = New Point(517, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(87, 23)
        Button1.TabIndex = 6
        Button1.Text = "< Bỏ ra"
        Button1.UseVisualStyleBackColor = True
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
        ' lbTongTien
        ' 
        lbTongTien.AutoSize = True
        lbTongTien.Location = New Point(7, 98)
        lbTongTien.Name = "lbTongTien"
        lbTongTien.Size = New Size(57, 15)
        lbTongTien.TabIndex = 9
        lbTongTien.Text = "Tổng tiền"
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
        ' TextBox1
        ' 
        TextBox1.Location = New Point(53, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(169, 23)
        TextBox1.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox5)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(lbTongTien)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(btnXacNhan)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(6, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(528, 128)
        Panel1.TabIndex = 11
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
        ' TextBox2
        ' 
        TextBox2.Location = New Point(295, 13)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(169, 23)
        TextBox2.TabIndex = 11
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
        ' TextBox3
        ' 
        TextBox3.Location = New Point(53, 51)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(169, 23)
        TextBox3.TabIndex = 13
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
        ' Button2
        ' 
        Button2.Location = New Point(255, 94)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 15
        Button2.Text = "Xoá"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(70, 98)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 16
        Label6.Text = "Tổng tiền"
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
        ' TextBox4
        ' 
        TextBox4.Location = New Point(295, 54)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(63, 23)
        TextBox4.TabIndex = 18
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
        ' TextBox5
        ' 
        TextBox5.Location = New Point(461, 54)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(61, 23)
        TextBox5.TabIndex = 20
        ' 
        ' FormQLBanHang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1171, 563)
        Controls.Add(GroupBox2)
        Controls.Add(Button1)
        Controls.Add(btnThem)
        Controls.Add(Label2)
        Controls.Add(cbChiNhanh)
        Controls.Add(Label1)
        Controls.Add(tbTuKhoa)
        Controls.Add(GroupBox1)
        Name = "FormQLBanHang"
        Text = "FormQLBanHang"
        GroupBox1.ResumeLayout(False)
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvDonHang As DataGridView
    Friend WithEvents lbTongTien As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents btnXacNhan As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
End Class
