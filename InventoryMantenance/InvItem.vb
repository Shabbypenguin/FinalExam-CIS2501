Public Class InvItem

    Public _itemno As Integer
    Public _description As String
    Public _price As Decimal

    Property ItemNo() As Integer
        Get
            Return _itemno
        End Get
        Set(value As Integer)
            _itemno = ItemNo
        End Set
    End Property

    Property Description() As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = Description
        End Set
    End Property

    Property Price() As Decimal
        Get
            Return _price
        End Get
        Set(value As Decimal)
            _price = Price
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
