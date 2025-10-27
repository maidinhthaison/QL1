<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLKhachHang
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
        dgvKhachHang = New DataGridView()
        GroupBox2 = New GroupBox()
        btnCapNhat = New Button()
        btnThem = New Button()
        cbXoa = New CheckBox()
        rtbDiaChi = New RichTextBox()
        Label3 = New Label()
        tbDienThoai = New TextBox()
        Label2 = New Label()
        lbCode = New Label()
        Label4 = New Label()
        tbTenKH = New TextBox()
        Label1 = New Label()
        bindingSourceKhachHang = New BindingSource(components)
        GroupBox1.SuspendLayout()
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(bindingSourceKhachHang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvKhachHang)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(558, 576)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Danh Sách Khách Hàng"
        ' 
        ' dgvKhachHang
        ' 
        dgvKhachHang.AllowUserToAddRows = False
        dgvKhachHang.AllowUserToDeleteRows = False
        dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhachHang.Location = New Point(6, 27)
        dgvKhachHang.Margin = New Padding(3, 4, 3, 4)
        dgvKhachHang.Name = "dgvKhachHang"
        dgvKhachHang.ReadOnly = True
        dgvKhachHang.RowHeadersWidth = 51
        dgvKhachHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKhachHang.Size = New Size(546, 540)
        dgvKhachHang.TabIndex = 2
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(btnCapNhat)
        GroupBox2.Controls.Add(btnThem)
        GroupBox2.Controls.Add(cbXoa)
        GroupBox2.Controls.Add(rtbDiaChi)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(tbDienThoai)
        GroupBox2.Controls.Add(Label2)
        GroupBox2.Controls.Add(lbCode)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Controls.Add(tbTenKH)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(576, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(326, 567)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Chi Tiết Khách Hàng"
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(143, 426)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(94, 29)
        btnCapNhat.TabIndex = 28
        btnCapNhat.Text = "Cập Nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(6, 426)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(94, 29)
        btnThem.TabIndex = 27
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' cbXoa
        ' 
        cbXoa.AutoSize = True
        cbXoa.Location = New Point(13, 360)
        cbXoa.Name = "cbXoa"
        cbXoa.Size = New Size(68, 24)
        cbXoa.TabIndex = 26
        cbXoa.Text = "Xóa ?"
        cbXoa.UseVisualStyleBackColor = True
        ' 
        ' rtbDiaChi
        ' 
        rtbDiaChi.Location = New Point(103, 213)
        rtbDiaChi.Name = "rtbDiaChi"
        rtbDiaChi.Size = New Size(217, 120)
        rtbDiaChi.TabIndex = 25
        rtbDiaChi.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(6, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 24
        Label3.Text = "Địa chỉ"
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(103, 147)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(217, 27)
        tbDienThoai.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 150)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 22
        Label2.Text = "Điện thoại"
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbCode.Location = New Point(103, 40)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(39, 20)
        lbCode.TabIndex = 21
        lbCode.Text = "N/A"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(6, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 20
        Label4.Text = "Code"
        ' 
        ' tbTenKH
        ' 
        tbTenKH.Location = New Point(103, 87)
        tbTenKH.Name = "tbTenKH"
        tbTenKH.Size = New Size(217, 27)
        tbTenKH.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 90)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tên KH"
        ' 
        ' FormQLKhachHang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLKhachHang"
        Text = "Khách Hàng"
        GroupBox1.ResumeLayout(False)
        CType(dgvKhachHang, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(bindingSourceKhachHang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvKhachHang As DataGridView
    Friend WithEvents tbTenKH As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents rtbDiaChi As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCode As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbXoa As CheckBox
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents bindingSourceKhachHang As BindingSource
End Class
