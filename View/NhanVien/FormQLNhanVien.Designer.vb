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
        btnTatCa = New Button()
        Label1 = New Label()
        tbTuKhoa = New TextBox()
        Panel1 = New Panel()
        cbStatus = New CheckBox()
        Label6 = New Label()
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
        dgvNhanVien = New DataGridView()
        cbIsXoa = New CheckBox()
        bsNhanVien = New BindingSource(components)
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).BeginInit()
        CType(bsNhanVien, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTatCa)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvNhanVien)
        GroupBox1.Controls.Add(cbIsXoa)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản Lý Nhân Viên"
        ' 
        ' btnTatCa
        ' 
        btnTatCa.Location = New Point(434, 30)
        btnTatCa.Name = "btnTatCa"
        btnTatCa.Size = New Size(75, 23)
        btnTatCa.TabIndex = 19
        btnTatCa.Text = "Tất cả"
        btnTatCa.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 7
        Label1.Text = "Từ khoá"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(76, 30)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.Size = New Size(246, 23)
        tbTuKhoa.TabIndex = 6
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cbStatus)
        Panel1.Controls.Add(Label6)
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
        Panel1.Location = New Point(538, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(238, 398)
        Panel1.TabIndex = 5
        ' 
        ' cbStatus
        ' 
        cbStatus.AutoSize = True
        cbStatus.Location = New Point(75, 260)
        cbStatus.Name = "cbStatus"
        cbStatus.Size = New Size(15, 14)
        cbStatus.TabIndex = 30
        cbStatus.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(6, 259)
        Label6.Name = "Label6"
        Label6.Size = New Size(32, 15)
        Label6.TabIndex = 29
        Label6.Text = "Xoá?"
        ' 
        ' rbNu
        ' 
        rbNu.AutoSize = True
        rbNu.Location = New Point(132, 216)
        rbNu.Name = "rbNu"
        rbNu.Size = New Size(41, 19)
        rbNu.TabIndex = 28
        rbNu.Text = "Nữ"
        rbNu.UseVisualStyleBackColor = True
        ' 
        ' rbNam
        ' 
        rbNam.AutoSize = True
        rbNam.Checked = True
        rbNam.Location = New Point(75, 216)
        rbNam.Name = "rbNam"
        rbNam.Size = New Size(51, 19)
        rbNam.TabIndex = 27
        rbNam.TabStop = True
        rbNam.Text = "Nam"
        rbNam.UseVisualStyleBackColor = True
        ' 
        ' tbTaiKhoan
        ' 
        tbTaiKhoan.Location = New Point(75, 29)
        tbTaiKhoan.Name = "tbTaiKhoan"
        tbTaiKhoan.Size = New Size(146, 23)
        tbTaiKhoan.TabIndex = 26
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(75, 63)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.PasswordChar = "*"c
        tbMatKhau.Size = New Size(146, 23)
        tbMatKhau.TabIndex = 25
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 66)
        Label10.Name = "Label10"
        Label10.Size = New Size(57, 15)
        Label10.TabIndex = 24
        Label10.Text = "Mật khẩu"
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(6, 346)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(75, 23)
        btnXoa.TabIndex = 21
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(87, 346)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(75, 23)
        btnCapNhat.TabIndex = 20
        btnCapNhat.Text = "Cập Nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(6, 303)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(75, 23)
        btnThem.TabIndex = 19
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(75, 169)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(146, 23)
        tbDienThoai.TabIndex = 16
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(6, 177)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 15)
        Label7.TabIndex = 15
        Label7.Text = "Điện thoại"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(6, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 13
        Label5.Text = "Tài khoản"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 218)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 15)
        Label4.TabIndex = 11
        Label4.Text = "Giới tính"
        ' 
        ' tbDiaChi
        ' 
        tbDiaChi.Location = New Point(75, 136)
        tbDiaChi.Name = "tbDiaChi"
        tbDiaChi.Size = New Size(146, 23)
        tbDiaChi.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 9
        Label3.Text = "Địa chỉ"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(75, 101)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(146, 23)
        tbTen.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(25, 15)
        Label2.TabIndex = 8
        Label2.Text = "Tên"
        ' 
        ' dgvNhanVien
        ' 
        dgvNhanVien.AllowUserToAddRows = False
        dgvNhanVien.AllowUserToDeleteRows = False
        dgvNhanVien.AllowUserToResizeColumns = False
        dgvNhanVien.AllowUserToResizeRows = False
        dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNhanVien.Location = New Point(6, 59)
        dgvNhanVien.Name = "dgvNhanVien"
        dgvNhanVien.ReadOnly = True
        dgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvNhanVien.Size = New Size(520, 361)
        dgvNhanVien.TabIndex = 4
        ' 
        ' cbIsXoa
        ' 
        cbIsXoa.AutoSize = True
        cbIsXoa.Location = New Point(337, 33)
        cbIsXoa.Name = "cbIsXoa"
        cbIsXoa.Size = New Size(91, 19)
        cbIsXoa.TabIndex = 18
        cbIsXoa.Text = "Đã nghỉ việc"
        cbIsXoa.UseVisualStyleBackColor = True
        ' 
        ' FormQLNhanVien
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "FormQLNhanVien"
        Text = "Nhân viên"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvNhanVien, ComponentModel.ISupportInitialize).EndInit()
        CType(bsNhanVien, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbIsXoa As CheckBox
    Friend WithEvents btnThem As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents bsNhanVien As BindingSource
    Friend WithEvents Label10 As Label
    Friend WithEvents rbNam As RadioButton
    Friend WithEvents rbNu As RadioButton
    Friend WithEvents tbTaiKhoan As TextBox
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents btnTatCa As Button
    Friend WithEvents cbStatus As CheckBox
    Friend WithEvents Label6 As Label
End Class
