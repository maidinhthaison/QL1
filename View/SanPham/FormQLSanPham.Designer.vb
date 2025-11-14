<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLSanPham
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
        lbChiNhanh = New Label()
        Label11 = New Label()
        Label1 = New Label()
        tbTukhoa = New TextBox()
        Panel1 = New Panel()
        tbGiaNhap = New TextBox()
        Label12 = New Label()
        cbDonVi = New ComboBox()
        Label10 = New Label()
        tbSoLuong = New TextBox()
        Label9 = New Label()
        lbKhuVuc = New Label()
        Label8 = New Label()
        lbNhacc = New Label()
        Label7 = New Label()
        btnThem = New Button()
        btnCapNhat = New Button()
        btnXoa = New Button()
        Label6 = New Label()
        tbGia = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        rtbMota = New RichTextBox()
        lbCode = New Label()
        cbLoaiSp = New ComboBox()
        Label3 = New Label()
        tbSanpham = New TextBox()
        Label2 = New Label()
        dgvSanPham = New DataGridView()
        bsSanPham = New BindingSource(components)
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsSanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbChiNhanh)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTukhoa)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1361, 780)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý sản phẩm"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.ForeColor = Color.Blue
        lbChiNhanh.Location = New Point(600, 40)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 46
        lbChiNhanh.Text = "N/A"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(504, 40)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 20)
        Label11.TabIndex = 29
        Label11.Text = "Chi nhánh"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 6
        Label1.Text = "Từ khoá"
        ' 
        ' tbTukhoa
        ' 
        tbTukhoa.Location = New Point(88, 33)
        tbTukhoa.Margin = New Padding(3, 4, 3, 4)
        tbTukhoa.Name = "tbTukhoa"
        tbTukhoa.PlaceholderText = "Tên, Loại, Giá, Số lượng,Nhà cung cấp, chi nhánh, khu vực ..."
        tbTukhoa.Size = New Size(410, 27)
        tbTukhoa.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(tbGiaNhap)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(cbDonVi)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(tbSoLuong)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(lbKhuVuc)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(lbNhacc)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(tbGia)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(rtbMota)
        Panel1.Controls.Add(lbCode)
        Panel1.Controls.Add(cbLoaiSp)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbSanpham)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(967, 29)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(388, 743)
        Panel1.TabIndex = 4
        ' 
        ' tbGiaNhap
        ' 
        tbGiaNhap.Location = New Point(123, 263)
        tbGiaNhap.Margin = New Padding(3, 4, 3, 4)
        tbGiaNhap.Name = "tbGiaNhap"
        tbGiaNhap.Size = New Size(103, 27)
        tbGiaNhap.TabIndex = 30
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(15, 266)
        Label12.Name = "Label12"
        Label12.Size = New Size(68, 20)
        Label12.TabIndex = 29
        Label12.Text = "Giá nhập"
        ' 
        ' cbDonVi
        ' 
        cbDonVi.FormattingEnabled = True
        cbDonVi.Location = New Point(123, 421)
        cbDonVi.Margin = New Padding(3, 4, 3, 4)
        cbDonVi.Name = "cbDonVi"
        cbDonVi.Size = New Size(143, 28)
        cbDonVi.TabIndex = 28
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(11, 429)
        Label10.Name = "Label10"
        Label10.Size = New Size(52, 20)
        Label10.TabIndex = 27
        Label10.Text = "Đơn vị"
        ' 
        ' tbSoLuong
        ' 
        tbSoLuong.Location = New Point(123, 371)
        tbSoLuong.Margin = New Padding(3, 4, 3, 4)
        tbSoLuong.Name = "tbSoLuong"
        tbSoLuong.Size = New Size(103, 27)
        tbSoLuong.TabIndex = 26
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(11, 374)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 20)
        Label9.TabIndex = 25
        Label9.Text = "Số lượng"
        ' 
        ' lbKhuVuc
        ' 
        lbKhuVuc.AutoSize = True
        lbKhuVuc.Location = New Point(123, 165)
        lbKhuVuc.Name = "lbKhuVuc"
        lbKhuVuc.Size = New Size(36, 20)
        lbKhuVuc.TabIndex = 24
        lbKhuVuc.Text = "N/A"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 165)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 20)
        Label8.TabIndex = 23
        Label8.Text = "Khu vực"
        ' 
        ' lbNhacc
        ' 
        lbNhacc.AutoSize = True
        lbNhacc.Location = New Point(123, 108)
        lbNhacc.Name = "lbNhacc"
        lbNhacc.Size = New Size(36, 20)
        lbNhacc.TabIndex = 22
        lbNhacc.Text = "N/A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 108)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 21
        Label7.Text = "Nhà cung cấp"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(9, 600)
        btnThem.Margin = New Padding(3, 4, 3, 4)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(86, 31)
        btnThem.TabIndex = 20
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(117, 600)
        btnCapNhat.Margin = New Padding(3, 4, 3, 4)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(86, 31)
        btnCapNhat.TabIndex = 19
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(210, 600)
        btnXoa.Margin = New Padding(3, 4, 3, 4)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(86, 31)
        btnXoa.TabIndex = 18
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 474)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 20)
        Label6.TabIndex = 17
        Label6.Text = "Mô tả"
        ' 
        ' tbGia
        ' 
        tbGia.Location = New Point(123, 309)
        tbGia.Margin = New Padding(3, 4, 3, 4)
        tbGia.Name = "tbGia"
        tbGia.Size = New Size(103, 27)
        tbGia.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 316)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 20)
        Label4.TabIndex = 15
        Label4.Text = "Giá bán"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 13
        Label5.Text = "Code"
        ' 
        ' rtbMota
        ' 
        rtbMota.Location = New Point(123, 474)
        rtbMota.Margin = New Padding(3, 4, 3, 4)
        rtbMota.Name = "rtbMota"
        rtbMota.Size = New Size(246, 88)
        rtbMota.TabIndex = 12
        rtbMota.Text = ""
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Location = New Point(123, 11)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(36, 20)
        lbCode.TabIndex = 11
        lbCode.Text = "N/A"
        ' 
        ' cbLoaiSp
        ' 
        cbLoaiSp.FormattingEnabled = True
        cbLoaiSp.Location = New Point(123, 48)
        cbLoaiSp.Margin = New Padding(3, 4, 3, 4)
        cbLoaiSp.Name = "cbLoaiSp"
        cbLoaiSp.Size = New Size(246, 28)
        cbLoaiSp.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 51)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 9
        Label3.Text = "Loại sản phẩm"
        ' 
        ' tbSanpham
        ' 
        tbSanpham.Location = New Point(123, 208)
        tbSanpham.Margin = New Padding(3, 4, 3, 4)
        tbSanpham.Name = "tbSanpham"
        tbSanpham.Size = New Size(246, 27)
        tbSanpham.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 211)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 9
        Label2.Text = "Sản phẩm"
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.AllowUserToAddRows = False
        dgvSanPham.AllowUserToDeleteRows = False
        dgvSanPham.AllowUserToResizeColumns = False
        dgvSanPham.AllowUserToResizeRows = False
        dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Location = New Point(7, 77)
        dgvSanPham.Margin = New Padding(3, 4, 3, 4)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(953, 695)
        dgvSanPham.TabIndex = 3
        ' 
        ' FormQLSanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1387, 809)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLSanPham"
        Text = "Quản lý sản phẩm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        CType(bsSanPham, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents bsSanPham As BindingSource
    Friend WithEvents tbTukhoa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSanpham As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbLoaiSp As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rtbMota As RichTextBox
    Friend WithEvents lbCode As Label
    Friend WithEvents tbGia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents lbKhuVuc As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbNhacc As Label
    Friend WithEvents tbSoLuong As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDonVi As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents tbGiaNhap As TextBox
    Friend WithEvents Label12 As Label
End Class
