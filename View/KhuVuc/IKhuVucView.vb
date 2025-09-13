Imports System.ComponentModel

Public Interface IKhuVucView
    Sub SetController(Controller As IKhuVucControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingListToGridView(list As List(Of KhuVuc))

    Sub BindingToTextBox(khuVuc As KhuVuc)

    Sub ConfigureGridView()

    Sub ClearFields()


End Interface
