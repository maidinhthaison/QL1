Public Class FormThongTin
    Implements IThongTinView, IBaseForm

    Private thongTinController As IThongTinControllerImpl
    Public Sub InitViews() Implements IBaseForm.InitViews


    End Sub

    Public Sub LoadData() Implements IThongTinView.LoadData
        thongTinController.XulyLoadChiNhanh()
    End Sub

    Public Sub BindingChiNhanhToListView(list As List(Of ChiNhanh)) Implements IThongTinView.BindingChiNhanhToListView
        ListView1.Items.Clear()

        For Each chinhanh As ChiNhanh In thongTinController.Items
            ' 2. Create the item with the 'Name' (Column 1)
            Dim item As New ListViewItem(chinhanh.Ten)

            ' 3. Add the 'Price' as the first SubItem (Column 2)
            item.SubItems.Add(chinhanh.DiaChi)

            ' 4. Store the original object in the Tag (still recommended)
            item.Tag = chinhanh

            ' 5. Add the item to the ListView
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub FormThongTin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        thongTinController = IThongTinControllerImpl.Instance
        thongTinController.Init(Me)
        InitViews()
        LoadData()
    End Sub

    Private Sub FormThongTin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        thongTinController.Items.Clear()
        thongTinController = Nothing
    End Sub
End Class