<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormThongTin
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
        Panel1 = New Panel()
        ListView1 = New ListView()
        chinhanh = New ColumnHeader()
        diachi = New ColumnHeader()
        Label2 = New Label()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(ListView1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(890, 576)
        Panel1.TabIndex = 0
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {chinhanh, diachi})
        ListView1.Location = New Point(183, 146)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(500, 250)
        ListView1.TabIndex = 2
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' chinhanh
        ' 
        chinhanh.Text = "Chi Nhánh"
        chinhanh.Width = 150
        ' 
        ' diachi
        ' 
        diachi.Text = "Địa chỉ"
        diachi.Width = 250
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label2.Location = New Point(365, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 37)
        Label2.TabIndex = 1
        Label2.Text = "Cửa hàng"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold)
        Label1.ForeColor = Color.Green
        Label1.Location = New Point(260, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(375, 67)
        Label1.TabIndex = 0
        Label1.Text = "Bách Hóa Sạch"
        ' 
        ' FormThongTin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 600)
        Controls.Add(Panel1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "FormThongTin"
        Text = "Thông tin ứng dụng"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chinhanh As ColumnHeader
    Friend WithEvents diachi As ColumnHeader
End Class
