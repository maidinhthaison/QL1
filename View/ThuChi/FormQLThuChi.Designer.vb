<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQLThuChi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Label8 = New Label()
        Label1 = New Label()
        lbChiNhanh = New Label()
        tbTuKhoa = New TextBox()
        dgvPhieuChi = New DataGridView()
        lbNguoiLap = New Label()
        Label7 = New Label()
        Label13 = New Label()
        dtPicker = New DateTimePicker()
        btnTaoPhieuChi = New Button()
        GroupBox2 = New GroupBox()
        Panel1 = New Panel()
        Label4 = New Label()
        lbCode = New Label()
        tbGhiChu = New RichTextBox()
        Label5 = New Label()
        Panel3 = New Panel()
        cbLyDo = New ComboBox()
        btnXoaCTPC = New Button()
        btnCapNhatCTPC = New Button()
        cbXoaCTPC = New CheckBox()
        tbCTPC_GhiChu = New TextBox()
        Label9 = New Label()
        tbSoTien = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        lbTongTien = New Label()
        Label10 = New Label()
        dgvCTPC = New DataGridView()
        BindingSource_PhieuChi = New BindingSource(components)
        BindingSource_CTPhieuChi = New BindingSource(components)
        GroupBox3 = New GroupBox()
        GroupBox1.SuspendLayout()
        CType(dgvPhieuChi, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(dgvCTPC, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_PhieuChi, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_CTPhieuChi, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lbChiNhanh)
        GroupBox1.Controls.Add(tbTuKhoa)
        GroupBox1.Controls.Add(dgvPhieuChi)
        GroupBox1.Controls.Add(lbNguoiLap)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Location = New Point(12, 13)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(821, 972)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Danh Sách Phiếu Chi"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(388, 24)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 31
        Label8.Text = "Chi nhánh"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(13, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 20)
        Label1.TabIndex = 7
        Label1.Text = "Từ khoá"
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.ForeColor = Color.Blue
        lbChiNhanh.Location = New Point(501, 24)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(36, 20)
        lbChiNhanh.TabIndex = 45
        lbChiNhanh.Text = "N/A"
        ' 
        ' tbTuKhoa
        ' 
        tbTuKhoa.Location = New Point(76, 44)
        tbTuKhoa.Margin = New Padding(3, 4, 3, 4)
        tbTuKhoa.Name = "tbTuKhoa"
        tbTuKhoa.PlaceholderText = "Người lập, sản phẩm, số tiền..."
        tbTuKhoa.Size = New Size(294, 27)
        tbTuKhoa.TabIndex = 6
        ' 
        ' dgvPhieuChi
        ' 
        dgvPhieuChi.AllowUserToAddRows = False
        dgvPhieuChi.AllowUserToDeleteRows = False
        dgvPhieuChi.AllowUserToResizeColumns = False
        dgvPhieuChi.AllowUserToResizeRows = False
        dgvPhieuChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPhieuChi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPhieuChi.Location = New Point(7, 109)
        dgvPhieuChi.Margin = New Padding(3, 4, 3, 4)
        dgvPhieuChi.Name = "dgvPhieuChi"
        dgvPhieuChi.ReadOnly = True
        dgvPhieuChi.RowHeadersWidth = 51
        dgvPhieuChi.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPhieuChi.Size = New Size(801, 855)
        dgvPhieuChi.TabIndex = 4
        ' 
        ' lbNguoiLap
        ' 
        lbNguoiLap.AutoSize = True
        lbNguoiLap.ForeColor = Color.Blue
        lbNguoiLap.Location = New Point(501, 70)
        lbNguoiLap.Name = "lbNguoiLap"
        lbNguoiLap.Size = New Size(36, 20)
        lbNguoiLap.TabIndex = 53
        lbNguoiLap.Text = "N/A"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(388, 70)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 20)
        Label7.TabIndex = 52
        Label7.Text = "Người lập"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(9, 9)
        Label13.Name = "Label13"
        Label13.Size = New Size(69, 20)
        Label13.TabIndex = 48
        Label13.Text = "Ngày lập"
        ' 
        ' dtPicker
        ' 
        dtPicker.Location = New Point(107, 9)
        dtPicker.Margin = New Padding(3, 4, 3, 4)
        dtPicker.Name = "dtPicker"
        dtPicker.Size = New Size(251, 27)
        dtPicker.TabIndex = 8
        ' 
        ' btnTaoPhieuChi
        ' 
        btnTaoPhieuChi.Location = New Point(14, 113)
        btnTaoPhieuChi.Margin = New Padding(3, 4, 3, 4)
        btnTaoPhieuChi.Name = "btnTaoPhieuChi"
        btnTaoPhieuChi.Size = New Size(120, 47)
        btnTaoPhieuChi.TabIndex = 9
        btnTaoPhieuChi.Text = "Tạo Phiếu Chi"
        btnTaoPhieuChi.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Panel1)
        GroupBox2.Location = New Point(839, 22)
        GroupBox2.Margin = New Padding(3, 4, 3, 4)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 4, 3, 4)
        GroupBox2.Size = New Size(578, 211)
        GroupBox2.TabIndex = 49
        GroupBox2.TabStop = False
        GroupBox2.Text = "Thông tin phiếu chi"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(dtPicker)
        Panel1.Controls.Add(lbCode)
        Panel1.Controls.Add(btnTaoPhieuChi)
        Panel1.Controls.Add(tbGhiChu)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(10, 29)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(560, 175)
        Panel1.TabIndex = 59
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(372, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 34
        Label4.Text = "Code"
        ' 
        ' lbCode
        ' 
        lbCode.AutoSize = True
        lbCode.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbCode.Location = New Point(426, 14)
        lbCode.Name = "lbCode"
        lbCode.Size = New Size(39, 20)
        lbCode.TabIndex = 46
        lbCode.Text = "N/A"
        ' 
        ' tbGhiChu
        ' 
        tbGhiChu.Location = New Point(107, 59)
        tbGhiChu.Name = "tbGhiChu"
        tbGhiChu.Size = New Size(306, 32)
        tbGhiChu.TabIndex = 51
        tbGhiChu.Text = ""
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(14, 71)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 20)
        Label5.TabIndex = 50
        Label5.Text = "Ghi chú"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(cbLyDo)
        Panel3.Controls.Add(btnXoaCTPC)
        Panel3.Controls.Add(btnCapNhatCTPC)
        Panel3.Controls.Add(cbXoaCTPC)
        Panel3.Controls.Add(tbCTPC_GhiChu)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(tbSoTien)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(lbTongTien)
        Panel3.Controls.Add(Label10)
        Panel3.Location = New Point(10, 560)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(568, 177)
        Panel3.TabIndex = 61
        ' 
        ' cbLyDo
        ' 
        cbLyDo.FormattingEnabled = True
        cbLyDo.Location = New Point(78, 15)
        cbLyDo.Name = "cbLyDo"
        cbLyDo.Size = New Size(243, 28)
        cbLyDo.TabIndex = 64
        ' 
        ' btnXoaCTPC
        ' 
        btnXoaCTPC.Location = New Point(426, 115)
        btnXoaCTPC.Name = "btnXoaCTPC"
        btnXoaCTPC.Size = New Size(133, 45)
        btnXoaCTPC.TabIndex = 63
        btnXoaCTPC.Text = "Xóa CTPC"
        btnXoaCTPC.UseVisualStyleBackColor = True
        ' 
        ' btnCapNhatCTPC
        ' 
        btnCapNhatCTPC.Location = New Point(249, 115)
        btnCapNhatCTPC.Name = "btnCapNhatCTPC"
        btnCapNhatCTPC.Size = New Size(133, 45)
        btnCapNhatCTPC.TabIndex = 62
        btnCapNhatCTPC.Text = "Cập nhật"
        btnCapNhatCTPC.UseVisualStyleBackColor = True
        ' 
        ' cbXoaCTPC
        ' 
        cbXoaCTPC.AutoSize = True
        cbXoaCTPC.Location = New Point(327, 69)
        cbXoaCTPC.Name = "cbXoaCTPC"
        cbXoaCTPC.Size = New Size(95, 24)
        cbXoaCTPC.TabIndex = 61
        cbXoaCTPC.Text = "Xóa CTPC"
        cbXoaCTPC.UseVisualStyleBackColor = True
        ' 
        ' tbCTPC_GhiChu
        ' 
        tbCTPC_GhiChu.Location = New Point(78, 67)
        tbCTPC_GhiChu.Name = "tbCTPC_GhiChu"
        tbCTPC_GhiChu.Size = New Size(243, 27)
        tbCTPC_GhiChu.TabIndex = 60
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(14, 74)
        Label9.Name = "Label9"
        Label9.Size = New Size(58, 20)
        Label9.TabIndex = 59
        Label9.Text = "Ghi chú"
        ' 
        ' tbSoTien
        ' 
        tbSoTien.Location = New Point(388, 12)
        tbSoTien.Name = "tbSoTien"
        tbSoTien.Size = New Size(105, 27)
        tbSoTien.TabIndex = 58
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(327, 18)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 57
        Label3.Text = "Số tiền"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 55
        Label2.Text = "Lý do"
        ' 
        ' lbTongTien
        ' 
        lbTongTien.AutoSize = True
        lbTongTien.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        lbTongTien.ForeColor = Color.Red
        lbTongTien.Location = New Point(107, 125)
        lbTongTien.Name = "lbTongTien"
        lbTongTien.Size = New Size(20, 23)
        lbTongTien.TabIndex = 36
        lbTongTien.Text = "0"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label10.Location = New Point(14, 125)
        Label10.Name = "Label10"
        Label10.Size = New Size(79, 23)
        Label10.TabIndex = 24
        Label10.Text = "Tổng chi"
        ' 
        ' dgvCTPC
        ' 
        dgvCTPC.AllowUserToAddRows = False
        dgvCTPC.AllowUserToDeleteRows = False
        dgvCTPC.AllowUserToResizeColumns = False
        dgvCTPC.AllowUserToResizeRows = False
        dgvCTPC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvCTPC.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCTPC.Location = New Point(9, 34)
        dgvCTPC.Margin = New Padding(3, 4, 3, 4)
        dgvCTPC.Name = "dgvCTPC"
        dgvCTPC.ReadOnly = True
        dgvCTPC.RowHeadersWidth = 51
        dgvCTPC.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvCTPC.Size = New Size(560, 519)
        dgvCTPC.TabIndex = 49
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(Panel3)
        GroupBox3.Controls.Add(dgvCTPC)
        GroupBox3.Location = New Point(839, 240)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(578, 745)
        GroupBox3.TabIndex = 61
        GroupBox3.TabStop = False
        GroupBox3.Text = "Chi tiết phiếu chi"
        ' 
        ' FormQLThuChi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1425, 991)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormQLThuChi"
        Text = "Quản lý phiếu chi"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgvPhieuChi, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(dgvCTPC, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_PhieuChi, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_CTPhieuChi, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents tbTuKhoa As TextBox
    Friend WithEvents dgvPhieuChi As DataGridView
    Friend WithEvents btnTaoPhieuChi As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbNguoiLap As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbGhiChu As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvCTPC As DataGridView
    Friend WithEvents Label10 As Label
    Friend WithEvents lbCode As Label
    Friend WithEvents lbTongTien As Label
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BindingSource_PhieuChi As BindingSource
    Friend WithEvents BindingSource_CTPhieuChi As BindingSource
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbSoTien As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnXoaCTPC As Button
    Friend WithEvents btnCapNhatCTPC As Button
    Friend WithEvents cbXoaCTPC As CheckBox
    Friend WithEvents tbCTPC_GhiChu As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbLyDo As ComboBox
End Class
