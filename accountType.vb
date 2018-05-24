Public Class contactType
    Property account As String
    Property fullName As String
    Property emailAddress As String
    Property note As String

    Public Sub New()
    End Sub

End Class

Public Class trxType
    Property itemGUID As String
    Property mode As String
    Property value As String
    Property account As String
    Property message As String
    Property note As String

    Public Sub New()
    End Sub
End Class

Public Class trxTypeJSON
    Property trxList As trxType
End Class

Public Class contactTypeJSON
    Property contactList As contactType
End Class