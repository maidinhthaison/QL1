Imports System.ComponentModel

Public Interface IKhuVucView
    Sub SetController(Controller As IKhuVucControllerImpl)
    Sub LoadData()

    Sub ShowMessageBox(Title As String, Message As String)

    Sub ShowConfirmMessageBox(Title As String, Message As String, Action As String)

    Sub BindingToGridView(dataTable As DataTable)


    Sub ClearFields()


End Interface
