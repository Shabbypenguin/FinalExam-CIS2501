Public Class InvItem

    Public _itemno As Integer
    Public _description As String
    Public _price As Decimal

    Property ItemNo() As Integer
        Get

        End Get
        Set(value As Integer)

        End Set
    End Property

    Property Description() As String
        Get

        End Get
        Set(value As String)

        End Set
    End Property

    Property Price() As Decimal
        Get

        End Get
        Set(value As Decimal)

        End Set
    End Property

    Function GetDisplayText(ByVal Output As String)
        Output = _itemno.ToString + " " + _description + "(" + _price.ToString + ")."
        Return Output
    End Function

    Sub New()

    End Sub

    Sub New(itemno, description, price)

    End Sub

End Class
