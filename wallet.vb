Imports System.Data.SqlClient
Imports Newtonsoft.Json.Linq


Public Class wallet
    Private contactList As New Dictionary(Of String, contactType)
    Private trxList As New Dictionary(Of String, trxType)
    Private assetGUID = "61FA8DF0-CB6E-4E5C-A1A0-68918026276D"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bSaveProfile.Click
        My.Settings.userName = Me.tbMyUserName.Text
        My.Settings.fullName = Me.tbMyFullName.Text
        My.Settings.emailAddress = Me.tbMyEmail.Text
        'My.Settings.myQT = Me.tbMyAddress.Text
        My.Settings.Save()
    End Sub

    Private Sub bImportSave_Click(sender As Object, e As EventArgs) Handles bImportSave.Click
        Dim odbc = My.Settings.odbc
        Dim sqlstr = "exec wallet_login 'live', '" & Me.tbImportED.Text & "', '" & Me.tbImportPwd.Text & "', @issilent=0"
        Dim d As DataSet = SelectSqlSrvRows(sqlstr, odbc)
        If d.Tables.Count > 0 AndAlso d.Tables(0).Rows.Count > 0 Then
            Dim qt = d.Tables(0).Rows(0).Item("qt")
            'Dim ct = d.Tables(0).Rows(0).Item("ct")
            My.Settings.myED = Me.tbImportED.Text
            My.Settings.myQT = qt
            My.Settings.Save()
            Me.tbImportED.Text = ""
            Me.tbImportPwd.Text = ""
            MessageBox.Show("Import Success")
            reloadData()
        End If
    End Sub

    Private Sub wallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadData()
    End Sub
    Private Sub bNewAccountSave_Click(sender As Object, e As EventArgs) Handles bNewAccountSave.Click
        Dim odbc = My.Settings.odbc
        Dim pwd = Me.tbNewAcountPwd.Text
        If pwd <> "" Then
            'Dim sqlstr = "declare @ed nvarchar(max); exec wallet_createAccount 'live', '" & pwd & "', @ed output; select @ed"
            Dim sqlstr = "declare @ed nvarchar(max), @qt nvarchar(max), @a nvarchar(max); exec wallet_createAccount 'live', '" & pwd & "', @ed output, @qt output, @a output; select @ed, @qt"
            Dim ds As DataSet = SelectSqlSrvRows(sqlstr, odbc)
            If ds.Tables.Count > 0 Then
                Dim ed = ds.Tables(0).Rows(0).Item(0)
                Dim qt = ds.Tables(0).Rows(0).Item(1)
                My.Settings.myED = ed
                My.Settings.myQT = qt
                My.Settings.pwd = pwd
                My.Settings.Save()
                reloadData()
            End If
            Me.tbNewAcountPwd.Text = ""
        Else
            MessageBox.Show("Please put a password before continue!")
        End If

    End Sub
    Sub reloadData()
        Me.tbMyUserName.Text = My.Settings.userName
        Me.tbMyFullName.Text = My.Settings.fullName
        Me.tbMyEmail.Text = My.Settings.emailAddress
        Me.tbMyAccount.Text = My.Settings.myQT
        Me.tbMyAddress.Text = My.Settings.myQT

        getContactList()

        getWalletStatus()

    End Sub
    Sub getContactList()
        Dim jsonText = My.Settings.contactList
        Dim isexists = False
        Me.lbContactList.Items.Clear()
        Dim json As JObject = JObject.Parse(jsonText)
        Dim al = json("contactList")
        For Each x In al
            Dim ac = x("account").ToString
            Dim fn = x("fullName").ToString
            Me.lbContactList.Items.Add(fn)
            If fn <> "" Then
                isexists = False
                For Each c In contactList
                    If c.Key = fn Then
                        isexists = True
                        Exit For
                    End If
                Next
                If Not isexists Then
                    contactList.Add(fn, New contactType With {.account = x("account").ToString, .fullName = x("fullName").ToString, .emailAddress = x("emailAddress").ToString})
                End If
            End If
        Next
    End Sub
    Sub getWalletStatus()
        Dim trxValue = 0
        Dim odbc = My.Settings.odbc
        Dim pwd = My.Settings.pwd
        If pwd <> "" Then
            'Dim sqlstr = "declare @ed nvarchar(max); exec wallet_createAccount 'live', '" & pwd & "', @ed output; select @ed"
            Dim ed = My.Settings.myED
            Dim sqlstr = "exec wallet_status null, '" & ed & "', '" & pwd & "'"
            Dim ds As DataSet = SelectSqlSrvRows(sqlstr, odbc)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each x As DataRow In ds.Tables(0).Rows
                    trxValue = x.Item("trxValue").ToString
                Next
            End If
        End If
        Me.tbBalance.Text = Format(trxValue, "#,###,##0")
    End Sub
    Function runSQLwithResult(ByVal sqlstr As String, Optional ByVal sqlconstr As String = "") As String
        Dim result As String, contentofError As String

        ' If the connection string is null, usse a default.
        Dim myConnectionString As String = sqlconstr
        'If sqlconstr = "" Then myConnectionString = contentOfdbODBC
        If myConnectionString = "" And sqlconstr = "" Then
            'SignOff()
            Return ""
            Exit Function
        End If

        Dim myConnection As New SqlConnection(myConnectionString)
        Dim myInsertQuery As String = sqlstr
        Dim myCommand As New SqlCommand(myInsertQuery)
        Try
            Dim Reader As SqlClient.SqlDataReader

            myCommand.Connection = myConnection
            myConnection.Open()

            Reader = myCommand.ExecuteReader()

            Reader.Read()
            If Reader.HasRows Then
                result = Reader.GetValue(0).ToString
            Else
                result = ""
            End If

        Catch ex As SqlException
            contentofError = ex.Message & "<br>"
            Return ""
        Catch ex As Exception

            contentofError = ex.Message & "<br>"
            Return ""
        Finally
            myCommand.Connection.Close()
            myConnection.Close()
        End Try
        Return result
    End Function



    Public Function SelectSqlSrvRows(ByVal query As String, ByVal Optional sqlconstr As String = "") As DataSet

        Dim myConnectionString As String = sqlconstr, contentofError = ""
        'If sqlconstr = "" Then myConnectionString = contentOfdbODBC

        Dim conn As New SqlConnection(myConnectionString)
        Dim adapter As New SqlDataAdapter
        Dim dataSet As New DataSet
        Try
            adapter.SelectCommand = New SqlCommand(query, conn)
            adapter.SelectCommand.CommandTimeout = 0
            adapter.Fill(dataSet)

        Catch ex As SqlException
            contentofError = query & ex.Message & "<br>"
        Catch ex As Exception
            contentofError = query & ex.Message & "<br>"
        Finally
            conn.Close()

        End Try
        adapter = Nothing
        Return dataSet

    End Function

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub bRefresh_Click(sender As Object, e As EventArgs) Handles bRefresh.Click
        reloadData()
    End Sub

    Private Sub bContactSave_Click(sender As Object, e As EventArgs) Handles bContactSave.Click
        Dim isExists = False
        Dim contactAccount = Me.tbContactAccount.Text
        Dim contactName = Me.tbContactName.Text
        If contactAccount <> "" And contactName <> "" Then

            For Each x In contactList
                If x.Key = contactName Then
                    isExists = True
                    Exit For
                End If
            Next
            If Not isExists Then
                Me.lbContactList.Items.Add(contactName)
                contactList.Add(contactName, New contactType With {.account = Me.tbContactAccount.Text, .fullName = Me.tbContactName.Text, .emailAddress = Me.tbContactEmail.Text})
            Else
                contactList(contactName).emailAddress = Me.tbContactEmail.Text
                contactList(contactName).fullName = Me.tbContactName.Text
                contactList(contactName).account = Me.tbContactAccount.Text
            End If
            Dim json = "{""contactList"":[%item%]}"
            For Each j In contactList
                Dim curAccount = contactList(j.Key.ToString)
                Dim jx = "{""account"":""" & curAccount.account & """,""fullName"":""" & curAccount.fullName & """,""emailAddress"":""" & curAccount.emailAddress & """}, %item%"
                json = json.Replace("%item%", jx)
            Next
            json = json.Replace(", %item%", "")
            json = json.Replace("%item%", "")
            My.Settings.contactList = json
            My.Settings.Save()
        Else
            MessageBox.Show("Please complete all data before saving!")
        End If


    End Sub

    Private Sub lbContactList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbContactList.SelectedIndexChanged
        If Not IsNothing(Me.lbContactList.SelectedItem) Then
            Dim curAccount = contactList(Me.lbContactList.SelectedItem)
            'If GetWin32Process("", curAccount.sqlId) <> curAccount.sqlId Then
            Me.tbContactAccount.Text = curAccount.account
            Me.tbContactName.Text = Me.lbContactList.SelectedItem
            Me.tbContactEmail.Text = curAccount.emailAddress
        End If
    End Sub

    Private Sub bContactNew_Click(sender As Object, e As EventArgs) Handles bContactNew.Click
        Me.tbContactAccount.Text = ""
        Me.tbContactName.Text = ""
        Me.tbContactEmail.Text = ""
    End Sub

    Private Sub bSend_Click(sender As Object, e As EventArgs) Handles bSend.Click
        Dim odbc = My.Settings.odbc
        Dim pwd = My.Settings.pwd
        If pwd <> "" Then
            'Dim sqlstr = "declare @ed nvarchar(max); exec createWallet 'live', '" & pwd & "', @ed output; select @ed"
            Dim ed = My.Settings.myED
            Dim sqlstr = "exec wallet_sendAsset null, '" & assetGUID & "', '" & Me.tbContactAccount.Text & "', " & Me.tbSendAmount.Text & ", 2, '" & Me.tbSendMessage.Text & "', '" & ed & "', '" & pwd & "'"

            Dim r = runSQLwithResult(sqlstr, odbc)
            If r <> "" Then
                MessageBox.Show(r)
            Else
                Me.tbSendAmount.Text = Format(0, "#,##0")
                getWalletStatus()
            End If
        Else
            MessageBox.Show("Please put a password before continue!")
        End If
    End Sub
End Class
