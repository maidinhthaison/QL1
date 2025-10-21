Public Interface IDangNhapView
    Sub SetController(Controller As IDangNhapControllerImpl)

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub DisplayLabelMessage(Message As String)

    Sub ClearFields()

    Sub DisableButton()

    Sub PhanQuyen(tkMa As Integer, isChuQuan As Boolean)

End Interface
