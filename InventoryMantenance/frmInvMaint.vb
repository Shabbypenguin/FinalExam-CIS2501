Public Class frmInvMaint
    ' Add a statement here that declares the list of items.
    Private Sub frmInvMaint_Load(sender As Object,
    e As EventArgs) Handles MyBase.Load
        ' Add code here that gets the list of items and fills the list box.
    End Sub

    Private Sub FillItemListBox()
        lstItems.Items.Clear()
        ' Add code here that loads the list box with the items in the list.
    End Sub

    Private Sub btnAdd_Click(sender As Object,
    e As EventArgs) Handles btnAdd.Click
        ' Add code here that creates an instance of the New Item form,
        ' displays the form as a dialog box, and gets the new item
        ' entered on that form.
    End Sub

    Private Sub btnDelete_Click(sender As Object,
    e As EventArgs) Handles btnDelete.Click
        Dim i As Integer = lstItems.SelectedIndex
        If i <> -1 Then
            ' Add code here that displays a dialog box to confirm
            ' the deletion and then removes the item from the list,
            ' saves the list of products, and refreshes the list box
            ' if the deletion is confirmed.
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object,
    e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
