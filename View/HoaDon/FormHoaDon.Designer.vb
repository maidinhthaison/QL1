<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHoaDon
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
        btnTimKiem = New Button()
        lbChiNhanh = New Label()
        dtPicker = New DateTimePicker()
        Label4 = New Label()
        Panel1 = New Panel()
        lbNguoiXuatHoaDon = New Label()
        lvSanPham = New ListView()
        sp = New ColumnHeader()
        sl = New ColumnHeader()
        dongia = New ColumnHeader()
        tongtien = New ColumnHeader()
        KM = New ColumnHeader()
        thanhtien = New ColumnHeader()
        lbTongHoaDon = New Label()
        lbNgayXuatHoaDon = New Label()
        lbDienThoai = New Label()
        lbKhachHang = New Label()
        dgvHoaDon = New DataGridView()
        BindingSource_donhang = New BindingSource(components)
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(dgvHoaDon, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource_donhang, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnTimKiem)
        GroupBox1.Controls.Add(lbChiNhanh)
        GroupBox1.Controls.Add(dtPicker)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Controls.Add(dgvHoaDon)
        GroupBox1.Location = New Point(12, 13)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(1401, 661)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Danh Sách Hóa Đơn"
        ' 
        ' btnTimKiem
        ' 
        btnTimKiem.Location = New Point(383, 31)
        btnTimKiem.Name = "btnTimKiem"
        btnTimKiem.Size = New Size(94, 29)
        btnTimKiem.TabIndex = 6
        btnTimKiem.Text = "Tìm kiếm"
        btnTimKiem.UseVisualStyleBackColor = True
        ' 
        ' lbChiNhanh
        ' 
        lbChiNhanh.AutoSize = True
        lbChiNhanh.ForeColor = Color.Blue
        lbChiNhanh.Location = New Point(718, 36)
        lbChiNhanh.Name = "lbChiNhanh"
        lbChiNhanh.Size = New Size(74, 20)
        lbChiNhanh.TabIndex = 5
        lbChiNhanh.Text = "Chi nhánh"
        ' 
        ' dtPicker
        ' 
        dtPicker.Location = New Point(105, 31)
        dtPicker.Name = "dtPicker"
        dtPicker.Size = New Size(250, 27)
        dtPicker.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 3
        Label4.Text = "Ngày tháng"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbNguoiXuatHoaDon)
        Panel1.Controls.Add(lvSanPham)
        Panel1.Controls.Add(lbTongHoaDon)
        Panel1.Controls.Add(lbNgayXuatHoaDon)
        Panel1.Controls.Add(lbDienThoai)
        Panel1.Controls.Add(lbKhachHang)
        Panel1.Location = New Point(705, 79)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(690, 574)
        Panel1.TabIndex = 2
        ' 
        ' lbNguoiXuatHoaDon
        ' 
        lbNguoiXuatHoaDon.AutoSize = True
        lbNguoiXuatHoaDon.Location = New Point(334, 12)
        lbNguoiXuatHoaDon.Name = "lbNguoiXuatHoaDon"
        lbNguoiXuatHoaDon.Size = New Size(142, 20)
        lbNguoiXuatHoaDon.TabIndex = 13
        lbNguoiXuatHoaDon.Text = "Người xuất hóa đơn"
        ' 
        ' lvSanPham
        ' 
        lvSanPham.Columns.AddRange(New ColumnHeader() {sp, sl, dongia, tongtien, KM, thanhtien})
        lvSanPham.Location = New Point(0, 208)
        lvSanPham.Name = "lvSanPham"
        lvSanPham.Size = New Size(687, 363)
        lvSanPham.TabIndex = 12
        lvSanPham.UseCompatibleStateImageBehavior = False
        lvSanPham.View = View.Details
        ' 
        ' sp
        ' 
        sp.Text = "SP"
        sp.Width = 200
        ' 
        ' sl
        ' 
        sl.Text = "Số lượng"
        sl.Width = 50
        ' 
        ' dongia
        ' 
        dongia.Text = "Đơn Giá"
        dongia.Width = 75
        ' 
        ' tongtien
        ' 
        tongtien.Text = "Tổng tiền"
        tongtien.Width = 100
        ' 
        ' KM
        ' 
        KM.Text = "Khuyến mãi"
        KM.Width = 75
        ' 
        ' thanhtien
        ' 
        thanhtien.Text = "Thành tiền"
        thanhtien.Width = 100
        ' 
        ' lbTongHoaDon
        ' 
        lbTongHoaDon.AutoSize = True
        lbTongHoaDon.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        lbTongHoaDon.ForeColor = Color.Red
        lbTongHoaDon.Location = New Point(13, 156)
        lbTongHoaDon.Name = "lbTongHoaDon"
        lbTongHoaDon.Size = New Size(106, 20)
        lbTongHoaDon.TabIndex = 6
        lbTongHoaDon.Text = "Tổng hóa đơn"
        ' 
        ' lbNgayXuatHoaDon
        ' 
        lbNgayXuatHoaDon.AutoSize = True
        lbNgayXuatHoaDon.Location = New Point(13, 12)
        lbNgayXuatHoaDon.Name = "lbNgayXuatHoaDon"
        lbNgayXuatHoaDon.Size = New Size(135, 20)
        lbNgayXuatHoaDon.TabIndex = 11
        lbNgayXuatHoaDon.Text = "Ngày xuất hóa đơn"
        ' 
        ' lbDienThoai
        ' 
        lbDienThoai.AutoSize = True
        lbDienThoai.Location = New Point(13, 110)
        lbDienThoai.Name = "lbDienThoai"
        lbDienThoai.Size = New Size(78, 20)
        lbDienThoai.TabIndex = 5
        lbDienThoai.Text = "Điện thoại"
        ' 
        ' lbKhachHang
        ' 
        lbKhachHang.AutoSize = True
        lbKhachHang.Location = New Point(13, 60)
        lbKhachHang.Name = "lbKhachHang"
        lbKhachHang.Size = New Size(89, 20)
        lbKhachHang.TabIndex = 0
        lbKhachHang.Text = "Khách Hàng"
        ' 
        ' dgvHoaDon
        ' 
        dgvHoaDon.AllowUserToAddRows = False
        dgvHoaDon.AllowUserToDeleteRows = False
        dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvHoaDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHoaDon.Location = New Point(7, 79)
        dgvHoaDon.Margin = New Padding(3, 4, 3, 4)
        dgvHoaDon.Name = "dgvHoaDon"
        dgvHoaDon.ReadOnly = True
        dgvHoaDon.RowHeadersWidth = 51
        dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvHoaDon.Size = New Size(692, 574)
        dgvHoaDon.TabIndex = 1
        ' 
        ' FormHoaDon
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1425, 687)
        Controls.Add(GroupBox1)
        Name = "FormHoaDon"
        Text = "Danh sách hóa đơn"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgvHoaDon, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource_donhang, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbDienThoai As Label
    Friend WithEvents lbKhachHang As Label
    Friend WithEvents dgvHoaDon As DataGridView
    Friend WithEvents lbChiNhanh As Label
    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTongHoaDon As Label
    Friend WithEvents lbNgayXuatHoaDon As Label
    Friend WithEvents lvSanPham As ListView
    Friend WithEvents sp As ColumnHeader
    Friend WithEvents sl As ColumnHeader
    Friend WithEvents dongia As ColumnHeader
    Friend WithEvents tongtien As ColumnHeader
    Friend WithEvents KM As ColumnHeader
    Friend WithEvents thanhtien As ColumnHeader
    Friend WithEvents lbNguoiXuatHoaDon As Label
    Friend WithEvents btnTimKiem As Button
    Friend WithEvents BindingSource_donhang As BindingSource
End Class
