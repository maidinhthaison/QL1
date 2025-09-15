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
        Panel1 = New Panel()
        cbKhuVuc = New ComboBox()
        cbNhaCc = New ComboBox()
        btnXoa = New Button()
        btnCapNhat = New Button()
        btnThem = New Button()
        rtbMota = New RichTextBox()
        Label5 = New Label()
        tbCode = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        tbTen = New TextBox()
        Label1 = New Label()
        dgvLoaiSp = New DataGridView()
        CType(bsLoaiSp, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvLoaiSp, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvLoaiSp)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Loại sản phẩm"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cbKhuVuc)
        Panel1.Controls.Add(cbNhaCc)
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(rtbMota)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(tbCode)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(422, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(354, 398)
        Panel1.TabIndex = 4
        ' 
        ' cbKhuVuc
        ' 
        cbKhuVuc.FormattingEnabled = True
        cbKhuVuc.Location = New Point(122, 104)
        cbKhuVuc.Name = "cbKhuVuc"
        cbKhuVuc.Size = New Size(164, 23)
        cbKhuVuc.TabIndex = 14
        ' 
        ' cbNhaCc
        ' 
        cbNhaCc.FormattingEnabled = True
        cbNhaCc.Location = New Point(122, 55)
        cbNhaCc.Name = "cbNhaCc"
        cbNhaCc.Size = New Size(164, 23)
        cbNhaCc.TabIndex = 13
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(226, 309)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(75, 23)
        btnXoa.TabIndex = 12
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(122, 309)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(75, 23)
        btnCapNhat.TabIndex = 11
        btnCapNhat.Text = "Cập Nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(18, 309)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(75, 23)
        btnThem.TabIndex = 10
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' rtbMota
        ' 
        rtbMota.Location = New Point(122, 200)
        rtbMota.Name = "rtbMota"
        rtbMota.Size = New Size(226, 77)
        rtbMota.TabIndex = 9
        rtbMota.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 15)
        Label5.TabIndex = 8
        Label5.Text = "Mô tả"
        ' 
        ' tbCode
        ' 
        tbCode.Location = New Point(122, 147)
        tbCode.Name = "tbCode"
        tbCode.Size = New Size(164, 23)
        tbCode.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 155)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 6
        Label4.Text = "Code"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 4
        Label3.Text = "Khu vực"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nhà cung cấp"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(122, 7)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(164, 23)
        tbTen.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 0
        Label1.Text = "Loại sản phẩm"
        ' 
        ' dgvLoaiSp
        ' 
        dgvLoaiSp.AllowUserToAddRows = False
        dgvLoaiSp.AllowUserToDeleteRows = False
        dgvLoaiSp.AllowUserToResizeColumns = False
        dgvLoaiSp.AllowUserToResizeRows = False
        dgvLoaiSp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLoaiSp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLoaiSp.Location = New Point(6, 22)
        dgvLoaiSp.Name = "dgvLoaiSp"
        dgvLoaiSp.ReadOnly = True
        dgvLoaiSp.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLoaiSp.Size = New Size(404, 398)
        dgvLoaiSp.TabIndex = 2
        ' 
        ' FormLoaiSanPham
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "FormLoaiSanPham"
        Text = "Loại Sản Phẩm"
        CType(bsLoaiSp, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvLoaiSp, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents tbCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbKhuVuc As ComboBox
    Friend WithEvents cbNhaCc As ComboBox
End Class
