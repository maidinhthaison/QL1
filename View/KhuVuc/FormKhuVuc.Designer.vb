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
        cbIsXoa = New CheckBox()
        Label2 = New Label()
        btnCapNhat = New Button()
        rtbMota = New RichTextBox()
        Label3 = New Label()
        tbTenKv = New TextBox()
        btnThem = New Button()
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
        GroupBox1.Location = New Point(14, 16)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(887, 568)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Quản lý khu vực"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cbIsXoa)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(rtbMota)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbTenKv)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(475, 29)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(405, 531)
        Panel1.TabIndex = 2
        ' 
        ' cbIsXoa
        ' 
        cbIsXoa.AutoSize = True
        cbIsXoa.Location = New Point(122, 228)
        cbIsXoa.Name = "cbIsXoa"
        cbIsXoa.Size = New Size(18, 17)
        cbIsXoa.TabIndex = 10
        cbIsXoa.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 20)
        Label2.TabIndex = 9
        Label2.Text = "Xóa?"
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(122, 279)
        btnCapNhat.Margin = New Padding(3, 4, 3, 4)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(86, 31)
        btnCapNhat.TabIndex = 7
        btnCapNhat.Text = "Cập nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' rtbMota
        ' 
        rtbMota.Location = New Point(122, 76)
        rtbMota.Margin = New Padding(3, 4, 3, 4)
        rtbMota.Name = "rtbMota"
        rtbMota.Size = New Size(251, 127)
        rtbMota.TabIndex = 6
        rtbMota.Text = ""
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 20)
        Label3.TabIndex = 5
        Label3.Text = "Mô tả"
        ' 
        ' tbTenKv
        ' 
        tbTenKv.Location = New Point(122, 12)
        tbTenKv.Margin = New Padding(3, 4, 3, 4)
        tbTenKv.Name = "tbTenKv"
        tbTenKv.Size = New Size(251, 27)
        tbTenKv.TabIndex = 4
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(16, 279)
        btnThem.Margin = New Padding(3, 4, 3, 4)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(86, 31)
        btnThem.TabIndex = 2
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 20)
        Label1.TabIndex = 0
        Label1.Text = "Tên Khu Vực"
        ' 
        ' dgvKhuVuc
        ' 
        dgvKhuVuc.AllowUserToAddRows = False
        dgvKhuVuc.AllowUserToDeleteRows = False
        dgvKhuVuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKhuVuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvKhuVuc.Location = New Point(7, 29)
        dgvKhuVuc.Margin = New Padding(3, 4, 3, 4)
        dgvKhuVuc.Name = "dgvKhuVuc"
        dgvKhuVuc.ReadOnly = True
        dgvKhuVuc.RowHeadersWidth = 51
        dgvKhuVuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKhuVuc.Size = New Size(462, 531)
        dgvKhuVuc.TabIndex = 1
        ' 
        ' FormKhuVuc
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormKhuVuc"
        Text = "Quản lý khu vực"
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
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents rtbMota As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTenKv As TextBox
    Friend WithEvents btnThem As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents cbIsXoa As CheckBox
End Class
