

Public Interface IKhuVucView

    Sub LoadData()

    Sub ShowMessageBox(MessageBoxType As EnumMessageBox, Title As String, Message As String)
    Sub BindingListToGridView(list As List(Of KhuVuc))

    Sub BindingToTextBox(khuVuc As KhuVuc)

    Sub ConfigureGridView()

End Interface
