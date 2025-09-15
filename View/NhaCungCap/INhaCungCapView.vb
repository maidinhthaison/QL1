Public Interface INhaCungCapView
    Sub SetController(Controller As INhaCungCapControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListToGridView(list As List(Of NhaCungCap))

    Sub BindingToTextBox(khuVuc As NhaCungCap)

    Sub ConfigureGridView()

    Sub ClearFields()


End Interface
