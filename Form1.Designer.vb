<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        MenuStrip1 = New MenuStrip()
        ThongTinMenuItem = New ToolStripMenuItem()
        QuảnLýToolStripMenuItem = New ToolStripMenuItem()
        BanHangMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        NhapHangMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        ThuChiMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        SanPhamMenuItem = New ToolStripMenuItem()
        DSSanPhamMenuItem = New ToolStripMenuItem()
        ToolStripSeparator9 = New ToolStripSeparator()
        NhaCCMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        LoaiSpMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        KhuVucMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        KhachHangMenuItem = New ToolStripMenuItem()
        ToolStripSeparator8 = New ToolStripSeparator()
        NhanVienMenuItem = New ToolStripMenuItem()
        ThongKeMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {ThongTinMenuItem, QuảnLýToolStripMenuItem, ThongKeMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ThongTinMenuItem
        ' 
        ThongTinMenuItem.Name = "ThongTinMenuItem"
        ThongTinMenuItem.Size = New Size(70, 20)
        ThongTinMenuItem.Text = "Thông tin"
        ' 
        ' QuảnLýToolStripMenuItem
        ' 
        QuảnLýToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BanHangMenuItem, ToolStripSeparator1, NhapHangMenuItem, ToolStripSeparator2, ThuChiMenuItem, ToolStripSeparator3, SanPhamMenuItem, ToolStripSeparator7, KhachHangMenuItem, ToolStripSeparator8, NhanVienMenuItem})
        QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        QuảnLýToolStripMenuItem.Size = New Size(60, 20)
        QuảnLýToolStripMenuItem.Text = "Quản lý"
        ' 
        ' BanHangMenuItem
        ' 
        BanHangMenuItem.Name = "BanHangMenuItem"
        BanHangMenuItem.Size = New Size(137, 22)
        BanHangMenuItem.Text = "Bán hàng"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(134, 6)
        ' 
        ' NhapHangMenuItem
        ' 
        NhapHangMenuItem.Name = "NhapHangMenuItem"
        NhapHangMenuItem.Size = New Size(137, 22)
        NhapHangMenuItem.Text = "Nhập hàng"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(134, 6)
        ' 
        ' ThuChiMenuItem
        ' 
        ThuChiMenuItem.Name = "ThuChiMenuItem"
        ThuChiMenuItem.Size = New Size(137, 22)
        ThuChiMenuItem.Text = "Thu chi"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(134, 6)
        ' 
        ' SanPhamMenuItem
        ' 
        SanPhamMenuItem.DropDownItems.AddRange(New ToolStripItem() {DSSanPhamMenuItem, ToolStripSeparator9, NhaCCMenuItem, ToolStripSeparator5, LoaiSpMenuItem, ToolStripSeparator6, KhuVucMenuItem})
        SanPhamMenuItem.Name = "SanPhamMenuItem"
        SanPhamMenuItem.Size = New Size(137, 22)
        SanPhamMenuItem.Text = "Sản phẩm"
        ' 
        ' DSSanPhamMenuItem
        ' 
        DSSanPhamMenuItem.Name = "DSSanPhamMenuItem"
        DSSanPhamMenuItem.Size = New Size(185, 22)
        DSSanPhamMenuItem.Text = "Danh sách Sản phẩm"
        ' 
        ' ToolStripSeparator9
        ' 
        ToolStripSeparator9.Name = "ToolStripSeparator9"
        ToolStripSeparator9.Size = New Size(182, 6)
        ' 
        ' NhaCCMenuItem
        ' 
        NhaCCMenuItem.Name = "NhaCCMenuItem"
        NhaCCMenuItem.Size = New Size(185, 22)
        NhaCCMenuItem.Text = "Nhà cung cấp"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(182, 6)
        ' 
        ' LoaiSpMenuItem
        ' 
        LoaiSpMenuItem.Name = "LoaiSpMenuItem"
        LoaiSpMenuItem.Size = New Size(185, 22)
        LoaiSpMenuItem.Text = "Loại sản phẩm"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(182, 6)
        ' 
        ' KhuVucMenuItem
        ' 
        KhuVucMenuItem.Name = "KhuVucMenuItem"
        KhuVucMenuItem.Size = New Size(185, 22)
        KhuVucMenuItem.Text = "Khu vực"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(134, 6)
        ' 
        ' KhachHangMenuItem
        ' 
        KhachHangMenuItem.Name = "KhachHangMenuItem"
        KhachHangMenuItem.Size = New Size(137, 22)
        KhachHangMenuItem.Text = "Khách hàng"
        ' 
        ' ToolStripSeparator8
        ' 
        ToolStripSeparator8.Name = "ToolStripSeparator8"
        ToolStripSeparator8.Size = New Size(134, 6)
        ' 
        ' NhanVienMenuItem
        ' 
        NhanVienMenuItem.Name = "NhanVienMenuItem"
        NhanVienMenuItem.Size = New Size(137, 22)
        NhanVienMenuItem.Text = "Nhân viên"
        ' 
        ' ThongKeMenuItem
        ' 
        ThongKeMenuItem.Name = "ThongKeMenuItem"
        ThongKeMenuItem.Size = New Size(68, 20)
        ThongKeMenuItem.Text = "Thống kê"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "20810229 Tạp Hoá"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ThongTinMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ThongKeMenuItem As ToolStripMenuItem
    Friend WithEvents BanHangMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents NhapHangMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ThuChiMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SanPhamMenuItem As ToolStripMenuItem
    Friend WithEvents NhaCCMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents LoaiSpMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents KhuVucMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents KhachHangMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents NhanVienMenuItem As ToolStripMenuItem
    Friend WithEvents DSSanPhamMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator

End Class
