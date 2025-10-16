Public Interface IDangNhapView
    Sub SetController(Controller As IDangNhapControllerImpl)

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ClearFields()

    Sub GotoMainScreen(user As NhanVien)
End Interface
