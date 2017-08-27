Public Class frmNewItem
    ' Add a statement here that declares a public inventory item.
    Private Sub btnSave_Click(sender As Object,
    e As EventArgs) Handles btnSave.Click
        If IsValidData() Then
            ' Add code here that creates a new item
            ' and closes the form.
        End If
    End Sub

    Private Function IsValidData() As Boolean
        Return Validator.IsPresent(txtItemNo) AndAlso
        Validator.IsInt32(txtItemNo) AndAlso
        Validator.IsPresent(txtDescription) AndAlso
        Validator.IsPresent(txtPrice) AndAlso
        Validator.IsDecimal(txtPrice)
    End Function

    Private Sub btnCancel_Click(sender As Object,
    e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class