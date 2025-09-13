<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKhuVuc
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        btnXoa = New Button()
        btnCapNhat = New Button()
        rtbMota = New RichTextBox()
        Label3 = New Label()
        tbTenKv = New TextBox()
        Label2 = New Label()
        btnThem = New Button()
        tbMaKv = New TextBox()
        Label1 = New Label()
        dgvKhuVuc = New DataGridView()
        BindingSource1 = New BindingSource(components)
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvKhuVuc, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvKhuVuc)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý khu vực"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(rtbMota)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbTenKv)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(tbMaKv)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(416, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(354, 398)
        Panel1.TabIndex = 2
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(208, 221)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(75, 23)
        btnXoa.TabIndex = 8
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(115, 221)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(75, 23)
        btnCapNhat.TabIndex = 7
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' rtbMota
        ' 
        rtbMota.Location = New Point(100, 103)
        rtbMota.Name = "rtbMota"
        rtbMota.Size = New Size(235, 96)
        rtbMota.TabIndex = 6
        rtbMota.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 5
        Label3.Text = "Mô tả"
        ' 
        ' tbTenKv
        ' 
        tbTenKv.Location = New Point(100, 55)
        tbTenKv.Name = "tbTenKv"
        tbTenKv.Size = New Size(100, 23)
        tbTenKv.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 17)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 3
        Label2.Text = "Mã Khu Vực"
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(22, 221)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(75, 23)
        btnThem.TabIndex = 2
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' tbMaKv
        ' 
        tbMaKv.Location = New Point(100, 14)
        tbMaKv.Name = "tbMaKv"
        tbMaKv.Size = New Size(100, 23)
        tbMaKv.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 0
        Label1.Text = "Tên Khu Vực"
        ' 
        ' dgvKhuVuc
        ' 
        dgvKhuVuc.AllowUserToAddRows = False
        dgvKhuVuc.AllowUserToDeleteRows = False
        dgvKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhuVuc.Location = New Point(6, 22)
        dgvKhuVuc.Name = "dgvKhuVuc"
        dgvKhuVuc.ReadOnly = True
        dgvKhuVuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKhuVuc.Size = New Size(404, 398)
        dgvKhuVuc.TabIndex = 1
        ' 
        ' FormKhuVuc
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "FormKhuVuc"
        Text = "Khu Vực"
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvKhuVuc, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvKhuVuc As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents rtbMota As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTenKv As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnThem As Button
    Friend WithEvents tbMaKv As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
