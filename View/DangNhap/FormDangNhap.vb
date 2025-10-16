Public Class FormDangNhap
    Implements IDangNhapView, IBaseForm

    Private listForms As List(Of Form)

    Private dangNhapController As IDangNhapControllerImpl

    Public Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String) Implements IDangNhapView.ShowMessageBox
        Select Case MessageBoxType
            Case EnumMessageBox.Infomation
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case EnumMessageBox.Errors
                MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub


    Public Sub SetController(Controller As IDangNhapControllerImpl) Implements IDangNhapView.SetController
        dangNhapController = Controller
    End Sub

    Public Sub ClearFields() Implements IDangNhapView.ClearFields
        tbTenDangNhap.Text = ""
        tbMatKhau.Text = ""
    End Sub

    Public Sub GotoMainScreen(user As NhanVien) Implements IDangNhapView.GotoMainScreen
        Dim frm As Form = TimForm(GetType(Form1), listForms)
        If frm IsNot Nothing Then
            frm.Activate()
            Return
        End If

        Dim formMain As New Form1(user)

        formMain.MdiParent = Me.MdiParent
        formMain.WindowState = FormWindowState.Maximized
        formMain.Show()
        listForms.Add(formMain)

    End Sub

    Public Sub InitViews() Implements IBaseForm.InitViews
        AddHandler btnDangNhap.Click, AddressOf OnButtonClick
        AddHandler btnXoa.Click, AddressOf OnButtonClick
        listForms = New List(Of Form)


        Me.Hide()
        Dim frm As Form = New FormDangNhap()
        Dim dr As DialogResult = frm.ShowDialog()
        If dr = DialogResult.OK Then
            Me.Show()
        Else
            Me.MdiParent.Close()
        End If
    End Sub

    Private Sub OnButtonClick(sender As Object, e As EventArgs)
        Dim button As Button = CType(sender, Button)
        Select Case button.Name
            Case "btnDangNhap"

                If tbTenDangNhap.Text = "" Or tbMatKhau.Text = "" Then
                    ShowMessageBox(EnumMessageBox.Errors, "Lỗi", "Vui lòng nhập đầy đủ thông tin!")
                    Return
                End If
                dangNhapController.XuLyDangNhap(tbTenDangNhap.Text, tbMatKhau.Text)
            Case "btnXoa"
                ClearFields()

        End Select
    End Sub

    Private Sub FormDangNhap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dangNhapController = IDangNhapControllerImpl.Instance
        dangNhapController.Init(Me)
        InitViews()

    End Sub
End Class