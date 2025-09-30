<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLDonHang
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
        dgvDonHang = New DataGridView()
        Panel1 = New Panel()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label7 = New Label()
        Label10 = New Label()
        rtbGhiChu = New RichTextBox()
        lvSanPham = New ListView()
        lbTongTien = New Label()
        Label5 = New Label()
        Label2 = New Label()
        tbDiaChi = New TextBox()
        Label9 = New Label()
        tbDienthoaiKh = New TextBox()
        Label6 = New Label()
        tbTenKh = New TextBox()
        Label4 = New Label()
        cbChiNhanh = New ComboBox()
        Label8 = New Label()
        bsPhieuBanHang = New BindingSource(components)
        GroupBox1.SuspendLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(bsPhieuBanHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dtPicker)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(dgvDonHang)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(793, 447)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý Đơn Hàng"
        ' 
        ' btnTaoDon
        ' 
        btnTaoDon.Location = New Point(8, 162)
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
        dgvDonHang.Size = New Size(781, 382)
        dgvDonHang.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnTaoDon)
        Panel1.Controls.Add(GroupBox2)
        Panel1.Controls.Add(tbDiaChi)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(tbDienthoaiKh)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(tbTenKh)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(cbChiNhanh)
        Panel1.Controls.Add(Label8)
        Panel1.Location = New Point(811, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(339, 441)
        Panel1.TabIndex = 5
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(rtbGhiChu)
        GroupBox2.Controls.Add(lvSanPham)
        GroupBox2.Controls.Add(lbTongTien)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Location = New Point(8, 200)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(328, 238)
        GroupBox2.TabIndex = 44
        GroupBox2.TabStop = False
        GroupBox2.Text = "Thông tin đơn hàng"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(8, 61)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 15)
        Label3.TabIndex = 9
        Label3.Text = "Sản phẩm"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(48, 15)
        Label7.TabIndex = 15
        Label7.Text = "Ghi chú"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 31)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 15)
        Label10.TabIndex = 24
        Label10.Text = "Tổng tiền"
        ' 
        ' rtbGhiChu
        ' 
        rtbGhiChu.Location = New Point(89, 162)
        rtbGhiChu.Name = "rtbGhiChu"
        rtbGhiChu.Size = New Size(233, 60)
        rtbGhiChu.TabIndex = 33
        rtbGhiChu.Text = ""
        ' 
        ' lvSanPham
        ' 
        lvSanPham.Location = New Point(89, 61)
        lvSanPham.Name = "lvSanPham"
        lvSanPham.Size = New Size(233, 95)
        lvSanPham.TabIndex = 38
        lvSanPham.UseCompatibleStateImageBehavior = False
        ' 
        ' lbTongTien
        ' 
        lbTongTien.AutoSize = True
        lbTongTien.ForeColor = Color.Red
        lbTongTien.Location = New Point(90, 31)
        lbTongTien.Name = "lbTongTien"
        lbTongTien.Size = New Size(13, 15)
        lbTongTien.TabIndex = 36
        lbTongTien.Text = "0"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Blue
        Label5.Location = New Point(227, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(13, 15)
        Label5.TabIndex = 37
        Label5.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(151, 31)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 8
        Label2.Text = "Khuyến mãi"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(105, 130)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(221, 23)
        tbDiaChi.TabIndex = 43
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(8, 133)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 15)
        Label9.TabIndex = 42
        Label9.Text = "Địa chỉ"
        ' 
        ' tbDienthoaiKh
        ' 
        tbDienthoaiKh.Location = New Point(105, 89)
        tbDienthoaiKh.Name = "tbDienthoaiKh"
        tbDienthoaiKh.Size = New Size(221, 23)
        tbDienthoaiKh.TabIndex = 41
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(8, 92)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 40
        Label6.Text = "Điện thoại"
        ' 
        ' tbTenKh
        ' 
        tbTenKh.Location = New Point(105, 49)
        tbTenKh.Name = "tbTenKh"
        tbTenKh.Size = New Size(221, 23)
        tbTenKh.TabIndex = 39
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(8, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 15)
        Label4.TabIndex = 34
        Label4.Text = "Tên Khách hàng"
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(105, 13)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(151, 23)
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
        ' FormQLBanHang
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1162, 471)
        Controls.Add(GroupBox1)
        Controls.Add(Panel1)
        Name = "FormQLBanHang"
        Text = "FormQLBanHang"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvDonHang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
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
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDonHang As DataGridView
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents rtbGhiChu As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTongTien As Label
    Friend WithEvents lvSanPham As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTaoDon As Button
    Friend WithEvents bsPhieuBanHang As BindingSource
    Friend WithEvents tbTenKh As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbDienthoaiKh As TextBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
