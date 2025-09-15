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
        btnTimKiem = New Button()
        Label1 = New Label()
        tbTukhoa = New TextBox()
        Panel1 = New Panel()
        btnThem = New Button()
        btnCapNhat = New Button()
        btnXoa = New Button()
        Label6 = New Label()
        tbGia = New TextBox()
        Label4 = New Label()
        btnTaoCode = New Button()
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
        GroupBox1.Controls.Add(btnTimKiem)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTukhoa)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý sản phẩm"
        ' 
        ' btnTimKiem
        ' 
        btnTimKiem.Location = New Point(261, 25)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(75, 23)
        btnTimKiem.TabIndex = 8
        btnTimKiem.Text = "Tìm"
        btnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(9, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 6
        Label1.Text = "Từ khoá"
        ' 
        ' tbTukhoa
        ' 
        tbTukhoa.Location = New Point(77, 25)
        tbTukhoa.Name = "tbTukhoa"
        tbTukhoa.Size = New Size(162, 23)
        tbTukhoa.TabIndex = 5
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(tbGia)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnTaoCode)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(rtbMota)
        Panel1.Controls.Add(lbCode)
        Panel1.Controls.Add(cbLoaiSp)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbSanpham)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(504, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(266, 398)
        Panel1.TabIndex = 4
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(3, 307)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(75, 23)
        btnThem.TabIndex = 20
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(92, 307)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(75, 23)
        btnCapNhat.TabIndex = 19
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(179, 307)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(75, 23)
        btnXoa.TabIndex = 18
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(3, 186)
        Label6.Name = "Label6"
        Label6.Size = New Size(38, 15)
        Label6.TabIndex = 17
        Label6.Text = "Mô tả"
        ' 
        ' tbGia
        ' 
        tbGia.Location = New Point(92, 140)
        tbGia.Name = "tbGia"
        tbGia.Size = New Size(162, 23)
        tbGia.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(3, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 15)
        Label4.TabIndex = 15
        Label4.Text = "Giá"
        ' 
        ' btnTaoCode
        ' 
        btnTaoCode.Location = New Point(179, 90)
        btnTaoCode.Name = "btnTaoCode"
        btnTaoCode.Size = New Size(75, 23)
        btnTaoCode.TabIndex = 14
        btnTaoCode.Text = "Tạo code"
        btnTaoCode.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 94)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 13
        Label5.Text = "Code"
        ' 
        ' rtbMota
        ' 
        rtbMota.Location = New Point(92, 186)
        rtbMota.Name = "rtbMota"
        rtbMota.Size = New Size(162, 96)
        rtbMota.TabIndex = 12
        rtbMota.Text = ""
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Location = New Point(92, 94)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(44, 15)
        lbCode.TabIndex = 11
        lbCode.Text = "abc123"
        ' 
        ' cbLoaiSp
        ' 
        cbLoaiSp.FormattingEnabled = True
        cbLoaiSp.Location = New Point(92, 49)
        cbLoaiSp.Name = "cbLoaiSp"
        cbLoaiSp.Size = New Size(121, 23)
        cbLoaiSp.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(3, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 15)
        Label3.TabIndex = 9
        Label3.Text = "Loại sản phẩm"
        ' 
        ' tbSanpham
        ' 
        tbSanpham.Location = New Point(92, 8)
        tbSanpham.Name = "tbSanpham"
        tbSanpham.Size = New Size(162, 23)
        tbSanpham.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
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
        dgvSanPham.Location = New Point(6, 58)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(492, 362)
        dgvSanPham.TabIndex = 3
        ' 
        ' FormQLSanPham
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
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
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents tbSanpham As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbLoaiSp As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents rtbMota As RichTextBox
    Friend WithEvents lbCode As Label
    Friend WithEvents btnTaoCode As Button
    Friend WithEvents tbGia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
End Class
