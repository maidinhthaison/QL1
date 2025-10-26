<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLNhanVien
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
        tbTuKhoa = New TextBox()
        dgvNhanVien = New DataGridView()
        Panel1 = New Panel()
        cbStatus = New CheckBox()
        Lb = New Label()
        cbChiNhanh = New ComboBox()
        Label8 = New Label()
        rbNu = New RadioButton()
        rbNam = New RadioButton()
        tbTaiKhoan = New TextBox()
        tbMatKhau = New TextBox()
        Label10 = New Label()
        btnXoa = New Button()
        btnCapNhat = New Button()
        btnThem = New Button()
        tbDienThoai = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        tbDiaChi = New TextBox()
        Label3 = New Label()
        tbTen = New TextBox()
        Label2 = New Label()
        bsNhanVien = New BindingSource(components)
        GroupBox2 = New GroupBox()
        GroupBox1.SuspendLayout()
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(bsNhanVien, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(dgvNhanVien)
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(887, 568)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản Lý Nhân Viên"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 7
        Label1.Text = "Từ khoá"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(87, 40)
        tbTuKhoa.Margin = New Padding(3, 4, 3, 4)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.PlaceholderText = "Tên, Địa chỉ, Sdt, Chi nhánh..."
        tbTuKhoa.Size = New Size(281, 27)
        tbTuKhoa.TabIndex = 6
        ' 
        ' dgvNhanVien
        ' 
        dgvNhanVien.AllowUserToAddRows = False
        dgvNhanVien.AllowUserToDeleteRows = False
        dgvNhanVien.AllowUserToResizeColumns = False
        dgvNhanVien.AllowUserToResizeRows = False
        dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNhanVien.Location = New Point(7, 79)
        dgvNhanVien.Margin = New Padding(3, 4, 3, 4)
        dgvNhanVien.Name = "dgvNhanVien"
        dgvNhanVien.ReadOnly = True
        dgvNhanVien.RowHeadersWidth = 51
        dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvNhanVien.Size = New Size(874, 481)
        dgvNhanVien.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cbStatus)
        Panel1.Controls.Add(Lb)
        Panel1.Controls.Add(cbChiNhanh)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(rbNu)
        Panel1.Controls.Add(rbNam)
        Panel1.Controls.Add(tbTaiKhoan)
        Panel1.Controls.Add(tbMatKhau)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(tbDienThoai)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(tbDiaChi)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(6, 27)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(314, 531)
        Panel1.TabIndex = 5
        ' 
        ' cbStatus
        ' 
        cbStatus.AutoSize = True
        cbStatus.Location = New Point(88, 371)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(18, 17)
        cbStatus.TabIndex = 34
        cbStatus.UseVisualStyleBackColor = True
        ' 
        ' Lb
        ' 
        Lb.AutoSize = True
        Lb.Location = New Point(9, 372)
        Lb.Name = "Lb"
        Lb.Size = New Size(42, 20)
        Lb.TabIndex = 33
        Lb.Text = "Xóa?"
        ' 
        ' cbChiNhanh
        ' 
        cbChiNhanh.FormattingEnabled = True
        cbChiNhanh.Location = New Point(88, 17)
        cbChiNhanh.Margin = New Padding(3, 4, 3, 4)
        cbChiNhanh.Name = "cbChiNhanh"
        cbChiNhanh.Size = New Size(166, 28)
        cbChiNhanh.TabIndex = 32
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(8, 21)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 31
        Label8.Text = "Chi nhánh"
        ' 
        ' rbNu
        ' 
        rbNu.AutoSize = True
        rbNu.Location = New Point(153, 321)
        rbNu.Margin = New Padding(3, 4, 3, 4)
        rbNu.Name = "rbNu"
        rbNu.Size = New Size(50, 24)
        rbNu.TabIndex = 28
        rbNu.Text = "Nữ"
        rbNu.UseVisualStyleBackColor = True
        ' 
        ' rbNam
        ' 
        rbNam.AutoSize = True
        rbNam.Checked = True
        rbNam.Location = New Point(88, 321)
        rbNam.Margin = New Padding(3, 4, 3, 4)
        rbNam.Name = "rbNam"
        rbNam.Size = New Size(62, 24)
        rbNam.TabIndex = 27
        rbNam.TabStop = True
        rbNam.Text = "Nam"
        rbNam.UseVisualStyleBackColor = True
        ' 
        ' tbTaiKhoan
        ' 
        tbTaiKhoan.Location = New Point(88, 72)
        tbTaiKhoan.Margin = New Padding(3, 4, 3, 4)
        tbTaiKhoan.Name = "tbTaiKhoan"
        tbTaiKhoan.Size = New Size(166, 27)
        tbTaiKhoan.TabIndex = 26
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(88, 117)
        tbMatKhau.Margin = New Padding(3, 4, 3, 4)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(166, 27)
        tbMatKhau.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(9, 121)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 20)
        Label10.TabIndex = 24
        Label10.Text = "Mật khẩu"
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(110, 418)
        btnXoa.Margin = New Padding(3, 4, 3, 4)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(61, 31)
        btnXoa.TabIndex = 21
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(180, 418)
        btnCapNhat.Margin = New Padding(3, 4, 3, 4)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(86, 31)
        btnCapNhat.TabIndex = 20
        btnCapNhat.Text = "Cập Nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(6, 418)
        btnThem.Margin = New Padding(3, 4, 3, 4)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(86, 31)
        btnThem.TabIndex = 19
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(88, 259)
        tbDienThoai.Margin = New Padding(3, 4, 3, 4)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(166, 27)
        tbDienThoai.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(9, 269)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 20)
        Label7.TabIndex = 15
        Label7.Text = "Điện thoại"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(9, 76)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 20)
        Label5.TabIndex = 13
        Label5.Text = "Tài khoản"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(9, 324)
        Label4.Name = "Label4"
        Label4.Size = New Size(65, 20)
        Label4.TabIndex = 11
        Label4.Text = "Giới tính"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(88, 215)
        tbDiaChi.Margin = New Padding(3, 4, 3, 4)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(166, 27)
        tbDiaChi.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(9, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 9
        Label3.Text = "Địa chỉ"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(88, 168)
        tbTen.Margin = New Padding(3, 4, 3, 4)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(166, 27)
        tbTen.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 172)
        Label2.Name = "Label2"
        Label2.Size = New Size(32, 20)
        Label2.TabIndex = 8
        Label2.Text = "Tên"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Location = New Point(907, 19)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(326, 565)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Thông tin Nhân viên"
        ' 
        ' FormQLNhanVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1242, 600)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLNhanVien"
        Text = "Nhân viên"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(bsNhanVien, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvNhanVien As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbDiaChi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents bsNhanVien As BindingSource
    Friend WithEvents Label10 As Label
    Friend WithEvents rbNam As RadioButton
    Friend WithEvents rbNu As RadioButton
    Friend WithEvents tbTaiKhoan As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents cbChiNhanh As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Lb As Label
    Friend WithEvents cbStatus As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
