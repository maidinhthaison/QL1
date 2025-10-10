<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLoaiSanPham
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
        bsLoaiSp = New BindingSource(components)
        GroupBox1 = New GroupBox()
        tbTuKhoa = New TextBox()
        Label8 = New Label()
        dgvLoaiSp = New DataGridView()
        Label6 = New Label()
        cbChiNhanh = New ComboBox()
        Panel1 = New Panel()
        btnHuy = New Button()
        tbSoLuong = New TextBox()
        Label7 = New Label()
        lbCode = New Label()
        cbKhuVuc = New ComboBox()
        cbNhaCc = New ComboBox()
        btnXoa = New Button()
        btnCapNhat = New Button()
        btnThem = New Button()
        rtbMota = New RichTextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        tbTen = New TextBox()
        Label1 = New Label()
        CType(bsLoaiSp, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(dgvLoaiSp, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(dgvLoaiSp)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(964, 600)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Loại sản phẩm"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(83, 30)
        tbTuKhoa.Margin = New Padding(3, 4, 3, 4)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.PlaceholderText = "Loại, nhà cung cấp, khu vực, địa chỉ..."
        tbTuKhoa.Size = New Size(317, 27)
        tbTuKhoa.TabIndex = 22
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(7, 33)
        Label8.Name = "Label8"
        Label8.Size = New Size(70, 20)
        Label8.TabIndex = 22
        Label8.Text = "Tìm kiếm"
        ' 
        ' dgvLoaiSp
        ' 
        dgvLoaiSp.AllowUserToAddRows = False
        dgvLoaiSp.AllowUserToDeleteRows = False
        dgvLoaiSp.AllowUserToResizeColumns = False
        dgvLoaiSp.AllowUserToResizeRows = False
        dgvLoaiSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLoaiSp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLoaiSp.Location = New Point(7, 70)
        dgvLoaiSp.Margin = New Padding(3, 4, 3, 4)
        dgvLoaiSp.Name = "dgvLoaiSp"
        dgvLoaiSp.ReadOnly = True
        dgvLoaiSp.RowHeadersWidth = 51
        dgvLoaiSp.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoaiSp.Size = New Size(951, 522)
        dgvLoaiSp.TabIndex = 2
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 20)
        Label6.TabIndex = 17
        Label6.Text = "Chi nhánh"
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(121, 15)
        cbChiNhanh.Margin = New Padding(3, 4, 3, 4)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(187, 28)
        cbChiNhanh.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnHuy)
        Panel1.Controls.Add(tbSoLuong)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(cbChiNhanh)
        Panel1.Controls.Add(lbCode)
        Panel1.Controls.Add(cbKhuVuc)
        Panel1.Controls.Add(cbNhaCc)
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(rtbMota)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(984, 26)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(326, 590)
        Panel1.TabIndex = 4
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(15, 482)
        btnHuy.Margin = New Padding(3, 4, 3, 4)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(86, 31)
        btnHuy.TabIndex = 22
        btnHuy.Text = "Hủy"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' tbSoLuong
        ' 
        tbSoLuong.Location = New Point(121, 205)
        tbSoLuong.Margin = New Padding(3, 4, 3, 4)
        tbSoLuong.Name = "tbSoLuong"
        tbSoLuong.Size = New Size(87, 27)
        tbSoLuong.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(18, 205)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 20)
        Label7.TabIndex = 20
        Label7.Text = "Số lượng"
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbCode.Location = New Point(75, 249)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(39, 20)
        lbCode.TabIndex = 19
        lbCode.Text = "N/A"
        ' 
        ' cbKhuVuc
        ' 
        cbKhuVuc.FormattingEnabled = True
        cbKhuVuc.Location = New Point(121, 159)
        cbKhuVuc.Margin = New Padding(3, 4, 3, 4)
        cbKhuVuc.Name = "cbKhuVuc"
        cbKhuVuc.Size = New Size(187, 28)
        cbKhuVuc.TabIndex = 14
        ' 
        ' cbNhaCc
        ' 
        cbNhaCc.FormattingEnabled = True
        cbNhaCc.Location = New Point(121, 110)
        cbNhaCc.Margin = New Padding(3, 4, 3, 4)
        cbNhaCc.Name = "cbNhaCc"
        cbNhaCc.Size = New Size(187, 28)
        cbNhaCc.TabIndex = 13
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(222, 411)
        btnXoa.Margin = New Padding(3, 4, 3, 4)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(86, 31)
        btnXoa.TabIndex = 12
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(119, 411)
        btnCapNhat.Margin = New Padding(3, 4, 3, 4)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(86, 31)
        btnCapNhat.TabIndex = 11
        btnCapNhat.Text = "Cập Nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(12, 411)
        btnThem.Margin = New Padding(3, 4, 3, 4)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(86, 31)
        btnThem.TabIndex = 10
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' rtbMota
        ' 
        rtbMota.Location = New Point(72, 298)
        rtbMota.Margin = New Padding(3, 4, 3, 4)
        rtbMota.Name = "rtbMota"
        rtbMota.Size = New Size(236, 88)
        rtbMota.TabIndex = 9
        rtbMota.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 302)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 20)
        Label5.TabIndex = 8
        Label5.Text = "Mô tả"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 6
        Label4.Text = "Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 4
        Label3.Text = "Khu vực"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nhà cung cấp"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(121, 60)
        tbTen.Margin = New Padding(3, 4, 3, 4)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(187, 27)
        tbTen.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(15, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 20)
        Label1.TabIndex = 0
        Label1.Text = "Loại sản phẩm"
        ' 
        ' FormLoaiSanPham
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1323, 632)
        Controls.Add(Panel1)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormLoaiSanPham"
        Text = "Loại Sản Phẩm"
        CType(bsLoaiSp, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvLoaiSp, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bsLoaiSp As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvLoaiSp As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents rtbMota As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbKhuVuc As ComboBox
    Friend WithEvents cbNhaCc As ComboBox
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbCode As Label
    Friend WithEvents tbSoLuong As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents btnHuy As Button
End Class
