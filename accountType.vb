Public Class AccountType
    Property UserName As String
    Property AccountName As String
    Property EmailAddress As String
    Property AccountEDT As String
    Property AccountQT As String
    Property contactJSON As New Dictionary(Of String, ContactType)
    'Property trxJSON As New Dictionary(Of String, TrxType)

    Public Sub New()
    End Sub

End Class

Public Class ContactType
    Property ContactName As String
    Property contactQT As String
    Property EmailAddress As String
    Property Note As String


    Public Sub New()
    End Sub

End Class

Public Class TrxType
    Property ItemGUID As String
    Property trxType As String
    Property Value As String
    Property Account As String
    Property Note As String
    Property trxDate As DateTime
    Property assetGUID As String
    Property status As String

    Public Sub New()
    End Sub
End Class

Public Class AccountTypeJSON
    Property AccountList As ContactType
End Class
Public Class TrxTypeJSON
    Property TrxList As TrxType
End Class

Public Class ContactTypeJSON
    Property ContactList As ContactType
End Class
