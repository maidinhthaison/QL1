﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNhaCungCap
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
        bsNhaCc = New BindingSource(components)
        GroupBox1 = New GroupBox()
        Panel1 = New Panel()
        lbCode = New Label()
        Label4 = New Label()
        btnXoa = New Button()
        btnCapNhat = New Button()
        btnThem = New Button()
        rtbGhichu = New RichTextBox()
        Label5 = New Label()
        tbDienThoai = New TextBox()
        Label3 = New Label()
        tbDiachi = New TextBox()
        Label2 = New Label()
        tbTen = New TextBox()
        Label1 = New Label()
        dgvNhaCc = New DataGridView()
        btnHuy = New Button()
        CType(bsNhaCc, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvNhaCc, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvNhaCc)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(776, 426)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Nhà Cung Cấp"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnHuy)
        Panel1.Controls.Add(lbCode)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(btnXoa)
        Panel1.Controls.Add(btnCapNhat)
        Panel1.Controls.Add(btnThem)
        Panel1.Controls.Add(rtbGhichu)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(tbDienThoai)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tbDiachi)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(tbTen)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(416, 22)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(354, 398)
        Panel1.TabIndex = 3
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Location = New Point(122, 15)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(0, 15)
        lbCode.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 15)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 13
        Label4.Text = "Code"
        ' 
        ' btnXoa
        ' 
        btnXoa.Location = New Point(265, 310)
        btnXoa.Name = "btnXoa"
        btnXoa.Size = New Size(75, 23)
        btnXoa.TabIndex = 12
        btnXoa.Text = "Xoá"
        btnXoa.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhat
        ' 
        btnCapNhat.Location = New Point(143, 310)
        btnCapNhat.Name = "btnCapNhat"
        btnCapNhat.Size = New Size(75, 23)
        btnCapNhat.TabIndex = 11
        btnCapNhat.Text = "Cập Nhật"
        btnCapNhat.UseVisualStyleBackColor = True
        ' 
        ' btnThem
        ' 
        btnThem.Location = New Point(13, 310)
        btnThem.Name = "btnThem"
        btnThem.Size = New Size(75, 23)
        btnThem.TabIndex = 10
        btnThem.Text = "Thêm"
        btnThem.UseVisualStyleBackColor = True
        ' 
        ' rtbGhichu
        ' 
        rtbGhichu.Location = New Point(122, 200)
        rtbGhichu.Name = "rtbGhichu"
        rtbGhichu.Size = New Size(162, 77)
        rtbGhichu.TabIndex = 9
        rtbGhichu.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 203)
        Label5.Name = "Label5"
        Label5.Size = New Size(48, 15)
        Label5.TabIndex = 8
        Label5.Text = "Ghi chú"
        ' 
        ' tbDienThoai
        ' 
        tbDienThoai.Location = New Point(122, 146)
        tbDienThoai.Name = "tbDienThoai"
        tbDienThoai.Size = New Size(164, 23)
        tbDienThoai.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 154)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 4
        Label3.Text = "Điện thoại"
        ' 
        ' tbDiachi
        ' 
        tbDiachi.Location = New Point(122, 97)
        tbDiachi.Name = "tbDiachi"
        tbDiachi.Size = New Size(164, 23)
        tbDiachi.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 15)
        Label2.TabIndex = 2
        Label2.Text = "Địa chỉ"
        ' 
        ' tbTen
        ' 
        tbTen.Location = New Point(122, 54)
        tbTen.Name = "tbTen"
        tbTen.Size = New Size(164, 23)
        tbTen.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nhà Cung Cấp"
        ' 
        ' dgvNhaCc
        ' 
        dgvNhaCc.AllowUserToAddRows = False
        dgvNhaCc.AllowUserToDeleteRows = False
        dgvNhaCc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvNhaCc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvNhaCc.Location = New Point(6, 22)
        dgvNhaCc.Name = "dgvNhaCc"
        dgvNhaCc.ReadOnly = True
        dgvNhaCc.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvNhaCc.Size = New Size(404, 398)
        dgvNhaCc.TabIndex = 2
        ' 
        ' btnHuy
        ' 
        btnHuy.Location = New Point(13, 358)
        btnHuy.Name = "btnHuy"
        btnHuy.Size = New Size(75, 23)
        btnHuy.TabIndex = 15
        btnHuy.Text = "Huỷ"
        btnHuy.UseVisualStyleBackColor = True
        ' 
        ' FormNhaCungCap
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GroupBox1)
        Name = "FormNhaCungCap"
        Text = "Nhà cung cấp"
        CType(bsNhaCc, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvNhaCc, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents bsNhaCc As BindingSource
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvNhaCc As DataGridView
    Friend WithEvents rtbGhichu As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbDienThoai As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDiachi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnXoa As Button
    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnThem As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbCode As Label
    Friend WithEvents btnHuy As Button
End Class
