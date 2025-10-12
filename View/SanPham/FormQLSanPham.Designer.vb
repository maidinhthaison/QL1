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
        Label1 = New Label()
        tbTukhoa = New TextBox()
        Panel1 = New Panel()
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
        Label9 = New Label()
        tbSoLuong = New TextBox()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsSanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTukhoa)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1278, 597)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý sản phẩm"
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
        Panel1.Size = New Size(304, 560)
        Panel1.TabIndex = 4
        ' 
        ' lbKhuVuc
        ' 
        lbKhuVuc.AutoSize = True
        lbKhuVuc.Location = New Point(123, 132)
        lbKhuVuc.Name = "lbKhuVuc"
        lbKhuVuc.Size = New Size(36, 20)
        lbKhuVuc.TabIndex = 24
        lbKhuVuc.Text = "N/A"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(11, 132)
        Label8.Name = "Label8"
        Label8.Size = New Size(61, 20)
        Label8.TabIndex = 23
        Label8.Text = "Khu vực"
        ' 
        ' lbNhacc
        ' 
        lbNhacc.AutoSize = True
        lbNhacc.Location = New Point(123, 93)
        lbNhacc.Name = "lbNhacc"
        lbNhacc.Size = New Size(36, 20)
        lbNhacc.TabIndex = 22
        lbNhacc.Text = "N/A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(11, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(100, 20)
        Label7.TabIndex = 21
        Label7.Text = "Nhà cung cấp"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(6, 525)
        btnThem.Margin = New Padding(3, 4, 3, 4)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(86, 31)
        btnThem.TabIndex = 20
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(114, 525)
        btnCapNhat.Margin = New Padding(3, 4, 3, 4)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(86, 31)
        btnCapNhat.TabIndex = 19
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(207, 525)
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
        Label6.Location = New Point(12, 385)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 20)
        Label6.TabIndex = 17
        Label6.Text = "Mô tả"
        ' 
        ' tbGia
        ' 
        tbGia.Location = New Point(123, 281)
        tbGia.Margin = New Padding(3, 4, 3, 4)
        tbGia.Name = "tbGia"
        tbGia.Size = New Size(103, 27)
        tbGia.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 288)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 20)
        Label4.TabIndex = 15
        Label4.Text = "Giá"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 48)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 13
        Label5.Text = "Code"
        ' 
        ' rtbMota
        ' 
        rtbMota.Location = New Point(115, 381)
        rtbMota.Margin = New Padding(3, 4, 3, 4)
        rtbMota.Name = "rtbMota"
        rtbMota.Size = New Size(173, 127)
        rtbMota.TabIndex = 12
        rtbMota.Text = ""
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Location = New Point(123, 48)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(36, 20)
        lbCode.TabIndex = 11
        lbCode.Text = "N/A"
        ' 
        ' cbLoaiSp
        ' 
        cbLoaiSp.FormattingEnabled = True
        cbLoaiSp.Location = New Point(123, 183)
        cbLoaiSp.Margin = New Padding(3, 4, 3, 4)
        cbLoaiSp.Name = "cbLoaiSp"
        cbLoaiSp.Size = New Size(173, 28)
        cbLoaiSp.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 9
        Label3.Text = "Loại sản phẩm"
        ' 
        ' tbSanpham
        ' 
        tbSanpham.Location = New Point(123, 237)
        tbSanpham.Margin = New Padding(3, 4, 3, 4)
        tbSanpham.Name = "tbSanpham"
        tbSanpham.Size = New Size(173, 27)
        tbSanpham.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 240)
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
        dgvSanPham.Size = New Size(953, 512)
        dgvSanPham.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(11, 334)
        Label9.Name = "Label9"
        Label9.Size = New Size(69, 20)
        Label9.TabIndex = 25
        Label9.Text = "Số lượng"
        ' 
        ' tbSoLuong
        ' 
        tbSoLuong.Location = New Point(123, 331)
        tbSoLuong.Margin = New Padding(3, 4, 3, 4)
        tbSoLuong.Name = "tbSoLuong"
        tbSoLuong.Size = New Size(103, 27)
        tbSoLuong.TabIndex = 26
        ' 
        ' FormQLSanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1305, 629)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLSanPham"
        Text = "Sản Phẩm"
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
End Class
