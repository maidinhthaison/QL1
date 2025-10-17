Public Interface IDangNhapView
    Sub SetController(Controller As IDangNhapControllerImpl)

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ClearFields()

    Sub GotoMainScreen(tkMa As Integer)
End Interface
