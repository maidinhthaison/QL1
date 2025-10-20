<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDangNhap
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
        GroupBox1 = New GroupBox()
        lbThongBao = New Label()
        btnXoa = New Button()
        btnDangNhap = New Button()
        tbMatKhau = New TextBox()
        Label2 = New Label()
        tbTenDangNhap = New TextBox()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbThongBao)
        GroupBox1.Controls.Add(btnXoa)
        GroupBox1.Controls.Add(btnDangNhap)
        GroupBox1.Controls.Add(tbMatKhau)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(tbTenDangNhap)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(395, 238)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Đăng nhập"
        ' 
        ' lbThongBao
        ' 
        lbThongBao.AutoSize = True
        lbThongBao.ForeColor = Color.Red
        lbThongBao.Location = New Point(16, 196)
        lbThongBao.Name = "lbThongBao"
        lbThongBao.Size = New Size(0, 20)
        lbThongBao.TabIndex = 6
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(132, 150)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(94, 29)
        btnXoa.TabIndex = 5
        btnXoa.Text = "Xóa"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnDangNhap
        ' 
        btnDangNhap.Location = New Point(16, 150)
        btnDangNhap.Name = "btnDangNhap"
        btnDangNhap.Size = New Size(94, 29)
        btnDangNhap.TabIndex = 4
        btnDangNhap.Text = "Đăng nhập"
        btnDangNhap.UseVisualStyleBackColor = True
        ' 
        ' tbMatKhau
        ' 
        tbMatKhau.Location = New Point(132, 90)
        tbMatKhau.Name = "tbMatKhau"
        tbMatKhau.Size = New Size(204, 27)
        tbMatKhau.TabIndex = 3
        tbMatKhau.Text = "Qwe123"
        tbMatKhau.UseSystemPasswordChar = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 20)
        Label2.TabIndex = 2
        Label2.Text = "Mật khẩu"
        ' 
        ' tbTenDangNhap
        ' 
        tbTenDangNhap.Location = New Point(132, 44)
        tbTenDangNhap.Name = "tbTenDangNhap"
        tbTenDangNhap.Size = New Size(204, 27)
        tbTenDangNhap.TabIndex = 1
        tbTenDangNhap.Text = "ADM1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(6, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tên đăng nhập"
        ' 
        ' FormDangNhap
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 262)
        Controls.Add(GroupBox1)
        Name = "FormDangNhap"
        Text = "FormDangNhap"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnDangNhap As Button
    Friend WithEvents tbMatKhau As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTenDangNhap As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbThongBao As Label
End Class
