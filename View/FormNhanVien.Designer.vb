<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNhanVien
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
        ToolStripSeparator3 = New ToolStripSeparator()
        SanPhamMenuItem = New ToolStripMenuItem()
        DSSanPhamMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        KhachHangMenuItem = New ToolStripMenuItem()
        ThongKeMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ThongTinMenuItem, QuảnLýToolStripMenuItem, ThongKeMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(7, 3, 0, 3)
        MenuStrip1.Size = New Size(914, 30)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ThongTinMenuItem
        ' 
        ThongTinMenuItem.Name = "ThongTinMenuItem"
        ThongTinMenuItem.Size = New Size(86, 24)
        ThongTinMenuItem.Text = "Thông tin"
        ' 
        ' QuảnLýToolStripMenuItem
        ' 
        QuảnLýToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BanHangMenuItem, ToolStripSeparator3, SanPhamMenuItem, ToolStripSeparator7, KhachHangMenuItem})
        QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        QuảnLýToolStripMenuItem.Size = New Size(73, 24)
        QuảnLýToolStripMenuItem.Text = "Quản lý"
        ' 
        ' BanHangMenuItem
        ' 
        BanHangMenuItem.Name = "BanHangMenuItem"
        BanHangMenuItem.Size = New Size(224, 26)
        BanHangMenuItem.Text = "Bán hàng"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(221, 6)
        ' 
        ' SanPhamMenuItem
        ' 
        SanPhamMenuItem.DropDownItems.AddRange(New ToolStripItem() {DSSanPhamMenuItem})
        SanPhamMenuItem.Name = "SanPhamMenuItem"
        SanPhamMenuItem.Size = New Size(224, 26)
        SanPhamMenuItem.Text = "Sản phẩm"
        ' 
        ' DSSanPhamMenuItem
        ' 
        DSSanPhamMenuItem.Name = "DSSanPhamMenuItem"
        DSSanPhamMenuItem.Size = New Size(230, 26)
        DSSanPhamMenuItem.Text = "Danh sách Sản phẩm"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(221, 6)
        ' 
        ' KhachHangMenuItem
        ' 
        KhachHangMenuItem.Name = "KhachHangMenuItem"
        KhachHangMenuItem.Size = New Size(224, 26)
        KhachHangMenuItem.Text = "Khách hàng"
        ' 
        ' ThongKeMenuItem
        ' 
        ThongKeMenuItem.Name = "ThongKeMenuItem"
        ThongKeMenuItem.Size = New Size(84, 24)
        ThongKeMenuItem.Text = "Thống kê"
        ' 
        ' FormNhanVien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormNhanVien"
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
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents SanPhamMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents KhachHangMenuItem As ToolStripMenuItem
    Friend WithEvents DSSanPhamMenuItem As ToolStripMenuItem

End Class
