Imports System.ComponentModel

Public Interface IKhuVucView
    Sub SetController(Controller As IKhuVucControllerImpl)
    Sub LoadData()

    Sub BindingToTextBox(Kv As KhuVuc)

    Sub ShowMessageBox(Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingToGridView(list As BindingList(Of KhuVuc))
    ' Sub BindingToGridView(dataTable As DataTable)
End Interface
