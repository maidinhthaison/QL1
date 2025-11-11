<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNhanVienThongKe
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
        cbBoLoc = New ComboBox()
        Label1 = New Label()
        lbChiNhanh = New Label()
        Label8 = New Label()
        lbNhanVien = New Label()
        Label3 = New Label()
        dgvSanPham = New DataGridView()
        lbDt = New Label()
        lbDoanhThu = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnTraCuu = New Button()
        GroupBox1 = New GroupBox()
        bsDoanhThuSanPham = New BindingSource(components)
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(bsDoanhThuSanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbBoLoc
        ' 
        cbBoLoc.FormattingEnabled = True
        cbBoLoc.Location = New Point(61, 11)
        cbBoLoc.Name = "cbBoLoc"
        cbBoLoc.Size = New Size(105, 28)
        cbBoLoc.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(4, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 1
        Label1.Text = "Bộ lọc"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.ForeColor = Color.Blue
        lbChiNhanh.Location = New Point(88, 13)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 47
        lbChiNhanh.Text = "N/A"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(8, 13)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 46
        Label8.Text = "Chi nhánh"
        ' 
        ' lbNhanVien
        ' 
        lbNhanVien.AutoSize = True
        lbNhanVien.ForeColor = Color.Blue
        lbNhanVien.Location = New Point(340, 13)
        lbNhanVien.Name = "lbNhanVien"
        lbNhanVien.Size = New Size(36, 20)
        lbNhanVien.TabIndex = 49
        lbNhanVien.Text = "N/A"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(260, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 20)
        Label3.TabIndex = 48
        Label3.Text = "Nhân viên"
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.AllowUserToAddRows = False
        dgvSanPham.AllowUserToDeleteRows = False
        dgvSanPham.AllowUserToResizeColumns = False
        dgvSanPham.AllowUserToResizeRows = False
        dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Location = New Point(8, 27)
        dgvSanPham.Margin = New Padding(3, 4, 3, 4)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(876, 416)
        dgvSanPham.TabIndex = 50
        ' 
        ' lbDt
        ' 
        lbDt.AutoSize = True
        lbDt.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbDt.Location = New Point(340, 17)
        lbDt.Name = "lbDt"
        lbDt.Size = New Size(97, 23)
        lbDt.TabIndex = 51
        lbDt.Text = "Doanh Thu"
        ' 
        ' lbDoanhThu
        ' 
        lbDoanhThu.AutoSize = True
        lbDoanhThu.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbDoanhThu.ForeColor = Color.Red
        lbDoanhThu.Location = New Point(443, 16)
        lbDoanhThu.Name = "lbDoanhThu"
        lbDoanhThu.Size = New Size(20, 23)
        lbDoanhThu.TabIndex = 52
        lbDoanhThu.Text = "0"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(lbChiNhanh)
        Panel1.Controls.Add(lbNhanVien)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(518, 47)
        Panel1.TabIndex = 53
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnTraCuu)
        Panel2.Controls.Add(cbBoLoc)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(lbDt)
        Panel2.Controls.Add(lbDoanhThu)
        Panel2.Location = New Point(12, 69)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(624, 50)
        Panel2.TabIndex = 54
        ' 
        ' btnTraCuu
        ' 
        btnTraCuu.Location = New Point(203, 11)
        btnTraCuu.Name = "btnTraCuu"
        btnTraCuu.Size = New Size(94, 29)
        btnTraCuu.TabIndex = 53
        btnTraCuu.Text = "Tra Cứu"
        btnTraCuu.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(12, 138)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(890, 450)
        GroupBox1.TabIndex = 55
        GroupBox1.TabStop = False
        GroupBox1.Text = "Danh Sách Sản Phẩm"
        ' 
        ' FormNhanVienThongKe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(GroupBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormNhanVienThongKe"
        Text = "Nhân viên thống kê"
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        CType(bsDoanhThuSanPham, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents cbBoLoc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbNhanVien As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents lbDt As Label
    Friend WithEvents lbDoanhThu As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnTraCuu As Button
    Friend WithEvents bsDoanhThuSanPham As BindingSource
End Class
