<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormChuQuanThongKe
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
        Panel1 = New Panel()
        lbDate = New Label()
        Label8 = New Label()
        btnTraCuu = New Button()
        cbBoLoc = New ComboBox()
        lbChiNhanh = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        lbLoiNhuan = New Label()
        Label5 = New Label()
        lbKhuyenMai = New Label()
        Label4 = New Label()
        lbTienVon = New Label()
        Label2 = New Label()
        lbDt = New Label()
        lbDoanhThu = New Label()
        GroupBox1 = New GroupBox()
        tbTuKhoa = New TextBox()
        Label15 = New Label()
        Panel3 = New Panel()
        lbLoiNhuanSp = New Label()
        Label6 = New Label()
        lbKhuyenMaiSp = New Label()
        Label9 = New Label()
        lbTienVonSp = New Label()
        Label11 = New Label()
        Label12 = New Label()
        lbDoanhThuSp = New Label()
        dgvSanPham = New DataGridView()
        bsDoanhThuSanPham = New BindingSource(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        GroupBox1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsDoanhThuSanPham, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbDate)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(btnTraCuu)
        Panel1.Controls.Add(cbBoLoc)
        Panel1.Controls.Add(lbChiNhanh)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(884, 47)
        Panel1.TabIndex = 54
        ' 
        ' lbDate
        ' 
        lbDate.AutoSize = True
        lbDate.ForeColor = Color.Blue
        lbDate.Location = New Point(461, 13)
        lbDate.Name = "lbDate"
        lbDate.Size = New Size(36, 20)
        lbDate.TabIndex = 54
        lbDate.Text = "N/A"
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
        ' btnTraCuu
        ' 
        btnTraCuu.Location = New Point(774, 9)
        btnTraCuu.Name = "btnTraCuu"
        btnTraCuu.Size = New Size(94, 29)
        btnTraCuu.TabIndex = 53
        btnTraCuu.Text = "Tra Cứu"
        btnTraCuu.UseVisualStyleBackColor = True
        ' 
        ' cbBoLoc
        ' 
        cbBoLoc.FormattingEnabled = True
        cbBoLoc.Location = New Point(313, 9)
        cbBoLoc.Name = "cbBoLoc"
        cbBoLoc.Size = New Size(122, 28)
        cbBoLoc.TabIndex = 0
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(238, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 1
        Label1.Text = "Bộ lọc"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbLoiNhuan)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(lbKhuyenMai)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(lbTienVon)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(lbDt)
        Panel2.Controls.Add(lbDoanhThu)
        Panel2.Location = New Point(12, 65)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(884, 50)
        Panel2.TabIndex = 55
        ' 
        ' lbLoiNhuan
        ' 
        lbLoiNhuan.AutoSize = True
        lbLoiNhuan.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbLoiNhuan.ForeColor = Color.Red
        lbLoiNhuan.Location = New Point(692, 16)
        lbLoiNhuan.Name = "lbLoiNhuan"
        lbLoiNhuan.Size = New Size(18, 20)
        lbLoiNhuan.TabIndex = 59
        lbLoiNhuan.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(608, 16)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 20)
        Label5.TabIndex = 58
        Label5.Text = "Lợi nhuận"
        ' 
        ' lbKhuyenMai
        ' 
        lbKhuyenMai.AutoSize = True
        lbKhuyenMai.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbKhuyenMai.ForeColor = Color.Red
        lbKhuyenMai.Location = New Point(522, 17)
        lbKhuyenMai.Name = "lbKhuyenMai"
        lbKhuyenMai.Size = New Size(18, 20)
        lbKhuyenMai.TabIndex = 57
        lbKhuyenMai.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(424, 16)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 20)
        Label4.TabIndex = 56
        Label4.Text = "Khuyến Mãi"
        ' 
        ' lbTienVon
        ' 
        lbTienVon.AutoSize = True
        lbTienVon.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTienVon.ForeColor = Color.Red
        lbTienVon.Location = New Point(313, 16)
        lbTienVon.Name = "lbTienVon"
        lbTienVon.Size = New Size(18, 20)
        lbTienVon.TabIndex = 55
        lbTienVon.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(238, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 54
        Label2.Text = "Tiền vốn"
        ' 
        ' lbDt
        ' 
        lbDt.AutoSize = True
        lbDt.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbDt.Location = New Point(8, 17)
        lbDt.Name = "lbDt"
        lbDt.Size = New Size(86, 20)
        lbDt.TabIndex = 51
        lbDt.Text = "Doanh Thu"
        ' 
        ' lbDoanhThu
        ' 
        lbDoanhThu.AutoSize = True
        lbDoanhThu.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbDoanhThu.ForeColor = Color.Red
        lbDoanhThu.Location = New Point(100, 16)
        lbDoanhThu.Name = "lbDoanhThu"
        lbDoanhThu.Size = New Size(18, 20)
        lbDoanhThu.TabIndex = 52
        lbDoanhThu.Text = "0"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(Label15)
        GroupBox1.Controls.Add(Panel3)
        GroupBox1.Controls.Add(dgvSanPham)
        GroupBox1.Location = New Point(12, 138)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(890, 552)
        GroupBox1.TabIndex = 56
        GroupBox1.TabStop = False
        GroupBox1.Text = "Danh Sách Sản Phẩm"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(76, 38)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.PlaceholderText = "Sản phẩm, Giá..."
        tbTuKhoa.Size = New Size(213, 27)
        tbTuKhoa.TabIndex = 62
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(8, 41)
        Label15.Name = "Label15"
        Label15.Size = New Size(62, 20)
        Label15.TabIndex = 61
        Label15.Text = "Từ khóa"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lbLoiNhuanSp)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(lbKhuyenMaiSp)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(lbTienVonSp)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(lbDoanhThuSp)
        Panel3.Location = New Point(8, 82)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(876, 50)
        Panel3.TabIndex = 60
        ' 
        ' lbLoiNhuanSp
        ' 
        lbLoiNhuanSp.AutoSize = True
        lbLoiNhuanSp.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lbLoiNhuanSp.ForeColor = Color.Blue
        lbLoiNhuanSp.Location = New Point(692, 16)
        lbLoiNhuanSp.Name = "lbLoiNhuanSp"
        lbLoiNhuanSp.Size = New Size(17, 19)
        lbLoiNhuanSp.TabIndex = 59
        lbLoiNhuanSp.Text = "0"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label6.Location = New Point(608, 16)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 19)
        Label6.TabIndex = 58
        Label6.Text = "Lợi nhuận"
        ' 
        ' lbKhuyenMaiSp
        ' 
        lbKhuyenMaiSp.AutoSize = True
        lbKhuyenMaiSp.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lbKhuyenMaiSp.ForeColor = Color.Blue
        lbKhuyenMaiSp.Location = New Point(522, 17)
        lbKhuyenMaiSp.Name = "lbKhuyenMaiSp"
        lbKhuyenMaiSp.Size = New Size(17, 19)
        lbKhuyenMaiSp.TabIndex = 57
        lbKhuyenMaiSp.Text = "0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label9.Location = New Point(424, 16)
        Label9.Name = "Label9"
        Label9.Size = New Size(87, 19)
        Label9.TabIndex = 56
        Label9.Text = "Khuyến Mãi"
        ' 
        ' lbTienVonSp
        ' 
        lbTienVonSp.AutoSize = True
        lbTienVonSp.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lbTienVonSp.ForeColor = Color.Blue
        lbTienVonSp.Location = New Point(313, 16)
        lbTienVonSp.Name = "lbTienVonSp"
        lbTienVonSp.Size = New Size(17, 19)
        lbTienVonSp.TabIndex = 55
        lbTienVonSp.Text = "0"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(238, 16)
        Label11.Name = "Label11"
        Label11.Size = New Size(66, 19)
        Label11.TabIndex = 54
        Label11.Text = "Tiền vốn"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        Label12.Location = New Point(8, 17)
        Label12.Name = "Label12"
        Label12.Size = New Size(80, 19)
        Label12.TabIndex = 51
        Label12.Text = "Doanh Thu"
        ' 
        ' lbDoanhThuSp
        ' 
        lbDoanhThuSp.AutoSize = True
        lbDoanhThuSp.Font = New Font("Segoe UI", 8F, FontStyle.Bold)
        lbDoanhThuSp.ForeColor = Color.Blue
        lbDoanhThuSp.Location = New Point(100, 16)
        lbDoanhThuSp.Name = "lbDoanhThuSp"
        lbDoanhThuSp.Size = New Size(17, 19)
        lbDoanhThuSp.TabIndex = 52
        lbDoanhThuSp.Text = "0"
        ' 
        ' dgvSanPham
        ' 
        dgvSanPham.AllowUserToAddRows = False
        dgvSanPham.AllowUserToDeleteRows = False
        dgvSanPham.AllowUserToResizeColumns = False
        dgvSanPham.AllowUserToResizeRows = False
        dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSanPham.Location = New Point(8, 139)
        dgvSanPham.Margin = New Padding(3, 4, 3, 4)
        dgvSanPham.Name = "dgvSanPham"
        dgvSanPham.ReadOnly = True
        dgvSanPham.RowHeadersWidth = 51
        dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvSanPham.Size = New Size(876, 406)
        dgvSanPham.TabIndex = 50
        ' 
        ' FormChuQuanThongKe
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 702)
        Controls.Add(GroupBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormChuQuanThongKe"
        Text = "Chủ quán thống kê"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvSanPham, ComponentModel.ISupportInitialize).EndInit()
        CType(bsDoanhThuSanPham, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTraCuu As Button
    Friend WithEvents cbBoLoc As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbDt As Label
    Friend WithEvents lbDoanhThu As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvSanPham As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbLoiNhuan As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbKhuyenMai As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTienVon As Label
    Friend WithEvents bsDoanhThuSanPham As BindingSource
    Friend WithEvents lbDate As Label
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbLoiNhuanSp As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbKhuyenMaiSp As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbTienVonSp As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lbDoanhThuSp As Label
End Class
