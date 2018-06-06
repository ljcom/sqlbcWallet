Imports System.Data.SqlClient
Imports Newtonsoft.Json.Linq
Imports sqlbcWallet.functions

Public Class login

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Friend curEDT As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim pwd = Me.tbPwd.Text
        Dim edt = curEDT
        Dim odbc = My.Settings.odbc

        If pwd <> "" Then
            Dim sqlstr = "exec wallet_login 'live', '" & edt & "', '" & pwd & "', @issilent=0"
            Dim d As DataSet = SelectSqlSrvRows(sqlstr, Odbc)
            If d.Tables.Count > 0 AndAlso d.Tables(0).Rows.Count > 0 Then
                Dim qt = d.Tables(0).Rows(0).Item("qt")
                'Dim ct = d.Tables(0).Rows(0).Item("ct")
                'Dim fn = "Account " & accountList.Count + 1
                'accountList.Add(fn, New AccountType With {.UserName = fn, .AccountName = fn, .AccountEDT = edt, .AccountQT = qt})
                If qt <> "" Then
                    My.Forms.wallet.currentPassword = Me.tbPwd.Text
                    If Not Me.CheckBox1.Checked Then Me.tbPwd.Text = ""
                    Me.Close()
                Else
                    MessageBox.Show("Wrong Password. Try again!")
                End If
            Else
                MessageBox.Show("Wrong Password. Try again!")
            End If
        Else
            MessageBox.Show("Please type your password before continue.")
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.tbPwd.Text = ""
        Me.Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub
End Class
