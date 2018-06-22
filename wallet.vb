Imports System.Data.SqlClient
Imports System.IO
Imports System.IO.Compression
Imports System.Net
Imports Newtonsoft.Json.Linq


Public Class wallet
    Public accountList As New Dictionary(Of String, AccountType)
    'Private contactList As New Dictionary(Of String, ContactType)
    Private trxList As New Dictionary(Of String, TrxType)

    Friend assetGUID = "00000000-0000-0000-0000-000000000000"
    Friend currentAccount = ""
    Friend currentPassword = ""
    Private sqlId As Integer
    Private pipename As String = ""
    Private Const folderTemp = "temp"
    Private Const folderData = "data"
    Private coreDB = "blockchainv2"
    Private isDBActive = False

    'Private eventHandled As Boolean = False
    Private Sub wallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startNode()

        'reloadData()
        If Not (pipename <> "" And isDBActive) Then
            If MessageBox.Show(Me, "We are about to install and setup localDB. Do you want to continue?", "Install", vbYesNo, vbQuestion) = vbYes Then
                installInstance()
                Dim nodeAddress = My.Settings.wellKnownAddress
                syncLocalScript("exec [dbo].[node_reqTrx] '" & nodeAddress & "'", coreDB, pipename)
            Else
                End
            End If
        End If

        If pipename <> "" And isDBActive Then
            getAccountList()

            Dim c = My.Settings.curAccount
            If c <> "" Then
                'Me.cbAccountList.SelectedValue = currentAccount
                cbAccountList.SelectedIndex = cbAccountList.FindString(c)
                'reloadData()
            End If
        Else
            End
        End If
    End Sub
    Sub startNode()
        Me.Button2.Enabled = True
        Me.Button3.Enabled = False

        If checkInstance("OPERAHOUSE") = "OPERAHOUSE" Then
            startInstance("OPERAHOUSE")
            SetLog("OPERAHOUSE started")

            pipename = getPipeName("OPERAHOUSE")
            SetLog("Pipename: " & pipename)
            If syncLocalScript("use " & coreDB, coreDB, pipename) Then
                Me.Button2.Enabled = False
                Me.Button3.Enabled = True
                isDBActive = True
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bSaveProfile.Click

        'My.Settings.userName = Me.tbMyUserName.Text
        'My.Settings.fullName = Me.tbMyFullName.Text
        'My.Settings.emailAddress = Me.tbMyEmail.Text
        'My.Settings.myQT = Me.tbMyAddress.Text
        'My.Settings.Save()
        Cursor = Cursors.WaitCursor
        saveAccount(Me.tbMyUserName.Text, Me.tbMyFullName.Text, Me.tbMyEmail.Text, "", "")
        Cursor = Cursors.Default
    End Sub

    Private Sub bImportSave_Click(sender As Object, e As EventArgs) Handles bImportSave.Click
        Cursor = Cursors.WaitCursor
        saveAccount("", "", "", Me.tbImportED.Text, Me.tbImportPwd.Text)

        Me.tbImportED.Text = ""
        Me.tbImportPwd.Text = ""

        cbAccountList.SelectedIndex = cbAccountList.FindString(currentAccount)
        Cursor = Cursors.Default
    End Sub
    Sub saveAccount(userName As String, accountName As String, email As String, edt As String, pwd1 As String)
        Dim odbc = "Data Source=(localdb)\operahouse;Initial Catalog=blockchainv2;Integrated Security=True" 'My.Settings.odbc
        If pwd1 <> "" Then
            Dim sqlstr = "exec wallet_login 'live', '" & edt & "', '" & pwd1 & "', @issilent=0"
            Dim d As DataSet = SelectSqlSrvRows(sqlstr, odbc)
            If d.Tables.Count > 0 AndAlso d.Tables(0).Rows.Count > 0 Then
                Dim qt = d.Tables(0).Rows(0).Item("qt")
                'Dim ct = d.Tables(0).Rows(0).Item("ct")
                Dim fn = "Account " & accountList.Count + 1
                accountList.Add(fn, New AccountType With {.UserName = fn, .AccountName = fn, .AccountEDT = edt, .AccountQT = qt})
            End If
        Else
            Dim curAccount = accountList(currentAccount)
            If userName <> "" Then curAccount.UserName = userName
            If accountName <> "" Then curAccount.AccountName = accountName
            If email <> "" Then curAccount.EmailAddress = email
            'If contact <> "" Then
            '    curAccount.contactJSON = contact
            'End If
            'If trx <> "" Then curAccount.trxJSON = trx
            currentAccount = userName
            My.Settings.curAccount = userName
        End If

        Dim json = "{""accountList"":[%item%]}"
        For Each j In accountList
            Dim curAccount = accountList(j.Key.ToString)
            Dim cljson = "[%citem%]"
            Dim curCL = curAccount.contactJSON
            For Each k In curCL
                Dim curContact = curCL(k.Key.ToString)
                Dim kx = "{""contactQT"":""" & curContact.contactQT & """,""contactName"":""" & curContact.ContactName & """,""emailAddress"":""" & curContact.EmailAddress & """}, %citem%"
                cljson = cljson.Replace("%citem%", kx)
            Next
            cljson = cljson.Replace(", %citem%", "")
            cljson = cljson.Replace("%citem%", "")

            Dim jx = "{""userName"":""" & curAccount.UserName & """,""accountName"":""" & curAccount.AccountName & """,""accountEDT"":""" & curAccount.AccountEDT & """,""accountQT"":""" & curAccount.AccountQT & """, contactJSON:" & cljson & "}, %item%"
            json = json.Replace("%item%", jx)
        Next
        json = json.Replace(", %item%", "")
        json = json.Replace("%item%", "")
        My.Settings.accountList = json

        My.Settings.Save()
        'MessageBox.Show("Import Success")


    End Sub
    Private Sub bNewAccountSave_Click(sender As Object, e As EventArgs) Handles bNewAccountSave.Click
        Cursor = Cursors.WaitCursor
        Dim odbc = "Data Source=(localdb)\operahouse;Initial Catalog=blockchainv2;Integrated Security=True" 'My.Settings.odbc
        Dim pwd = Me.tbNewAcountPwd.Text
        If pwd <> "" Then
            'Dim sqlstr = "declare @ed nvarchar(max); exec wallet_createAccount 'live', '" & pwd & "', @ed output; select @ed"
            Dim sqlstr = "declare @ed nvarchar(max), @qt nvarchar(max), @a nvarchar(max); exec wallet_createAccount 'live', '" & pwd & "', @ed output, @qt output, @a output; select @ed, @qt"
            Dim ds As DataSet = SelectSqlSrvRows(sqlstr, odbc)
            If ds.Tables.Count > 0 Then
                Dim ed = ds.Tables(0).Rows(0).Item(0)
                Dim qt = ds.Tables(0).Rows(0).Item(1)
                'My.Settings.myEDT = ed
                'My.Settings.myQT = qt
                'My.Settings.pwd = pwd
                My.Settings.Save()
                reloadData(True)
            End If
            Me.tbNewAcountPwd.Text = ""
        Else
            MessageBox.Show("Please put a password before continue!")
        End If
        Cursor = Cursors.Default
    End Sub
    Sub reloadData(isFull As Boolean)
        'If GetWin32Process("", curAccount.sqlId) <> curAccount.sqlId Then
        Dim curAccount As AccountType = accountList(currentAccount)

        Me.tbMyUserName.Text = curAccount.UserName
        Me.tbMyFullName.Text = curAccount.AccountName
        Me.tbMyEmail.Text = curAccount.EmailAddress
        Me.tbMyAccount.Text = curAccount.AccountQT
        Me.tbMyAddress.Text = curAccount.AccountQT

        'Me.tbMyUserName.Text = My.Settings.userName
        'Me.tbMyFullName.Text = My.Settings.fullName
        'Me.tbMyEmail.Text = My.Settings.emailAddress
        'Me.tbMyAccount.Text = My.Settings.myQT
        'Me.tbMyAddress.Text = My.Settings.myQT

        'getAccountList()

        getContactList()

        getWalletStatus(isFull)
        getWalletHistory(isFull)


    End Sub
    Sub getAccountList()
        Dim ajsonText = My.Settings.accountList
        Dim isexists = False
        Me.cbAccountList.Items.Clear()
        If ajsonText <> "" Then
            Dim ajson As JObject = JObject.Parse(ajsonText)
            Dim al = ajson("accountList")
            For Each x In al
                'Dim ac = x("account").ToString
                Dim fn = x("userName").ToString
                Me.cbAccountList.Items.Add(fn)
                If fn <> "" Then
                    isexists = False
                    For Each c In accountList
                        If c.Key = fn Then
                            isexists = True
                            Exit For
                        End If
                    Next
                    If Not isexists Then
                        accountList.Add(fn, New AccountType With {.UserName = x("userName").ToString, .AccountName = x("accountName").ToString, .EmailAddress = x("emailAddress"), .AccountEDT = x("accountEDT").ToString, .AccountQT = x("accountQT")})
                        Dim cl = x("contactJSON")
                        'Dim clx = cl("contactList")
                        For Each y In cl
                            Dim cn = y("contactName")
                            Me.lbContactList.Items.Add(cn)
                            If cn <> "" Then
                                isexists = False
                                For Each cx In accountList(fn).contactJSON
                                    If cx.Key = cn Then
                                        isexists = True
                                        Exit For
                                    End If
                                Next
                                If Not isexists Then
                                    accountList(fn).contactJSON.Add(cn, New ContactType With {.ContactName = y("contactName").ToString, .contactQT = y("contactQT").ToString, .Note = y("note"), .EmailAddress = y("EmailAddress")})
                                End If
                            End If
                        Next
                        'getContactList()
                    End If
                End If
            Next
        End If
    End Sub
    Sub getContactList()
        'Dim jsonText = My.Settings.contactList
        'Dim jsonText = accountList(currentAccount).contactJSON
        Dim isexists = False
        Me.lbContactList.Items.Clear()
        Me.tbContactAccount.Text = ""
        Me.tbContactEmail.Text = ""
        Me.tbContactName.Text = ""
        'If Not IsNothing(jsonText) Then
        'Dim json As JObject = JObject.Parse(jsonText)
        Dim al = accountList(currentAccount).contactJSON
        'Dim al = json("contactList")
        'If Not IsNothing(al) Then
        For Each x In al
            '    'Dim ac = x("account").ToString
            Dim fn = x.Key.ToString
            Me.lbContactList.Items.Add(fn)

            'If fn <> "" Then
            '    isexists = False
            '    For Each c In al
            '        If c.Key = fn Then
            '            isexists = True
            '            Exit For
            '        End If
            '    Next
            '    If Not isexists Then
            '        'contactList.Add(fn, New ContactType With {.contactQT = x.Value("contactQT").ToString, .ContactName = x.Value("contactName").ToString, .EmailAddress = x.Value("emailAddress").ToString})
            '    End If
            'End If
        Next
        'End If
        'End If
    End Sub
    Sub getWalletStatus(isFull As Boolean)
        Dim trxValue = 0
        Dim odbc = "Data Source=(localdb)\operahouse;Initial Catalog=blockchainv2;Integrated Security=True" 'My.Settings.odbc
        'Dim pwd = My.Settings.pwd
        Dim pwd = currentPassword
        If pwd <> "" Then
            'Dim sqlstr = "declare @ed nvarchar(max); exec wallet_createAccount 'live', '" & pwd & "', @ed output; select @ed"
            'Dim ed = My.Settings.myEDT
            Dim ed = accountList(currentAccount).AccountEDT
            Dim sqlstr = "exec wallet_status null, '" & ed & "', '" & pwd & "', @mode=0, @isfull=" & isFull
            Dim ds As DataSet = SelectSqlSrvRows(sqlstr, odbc)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each x As DataRow In ds.Tables(0).Rows
                    trxValue = IIf(IsDBNull(x.Item("trxValue")), 0, x.Item("trxValue").ToString)
                Next
            End If
        End If
        Me.tbBalance.Text = Format(trxValue, "#,###,##0")
    End Sub
    Sub getWalletHistory(isFull As Boolean)
        Dim odbc = "Data Source=(localdb)\operahouse;Initial Catalog=blockchainv2;Integrated Security=True" 'My.Settings.odbc
        'Dim pwd = My.Settings.pwd
        Dim pwd = currentPassword
        If pwd <> "" Then
            'Dim sqlstr = "declare @ed nvarchar(max); exec wallet_createAccount 'live', '" & pwd & "', @ed output; select @ed"
            'Dim ed = My.Settings.myEDT
            Me.lbTrxList.Items.Clear()
            trxList = New Dictionary(Of String, TrxType)
            Dim ed = accountList(currentAccount).AccountEDT
            Dim sqlstr = "exec wallet_status null, '" & ed & "', '" & pwd & "', @mode=1, @isFull=" & isFull
            Dim ds As DataSet = SelectSqlSrvRows(sqlstr, odbc)
            If ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                For Each x As DataRow In ds.Tables(0).Rows
                    Dim trxValue = x.Item("trxValue").ToString
                    Dim trxDate = x.Item("trxDate").ToString
                    Dim asset = x.Item("assetGUID").ToString
                    Dim rcxKey = x.Item("rcxKey").ToString
                    Dim itemGUID = x.Item("itemGUID").ToString
                    Dim trxType = x.Item("trxType").ToString
                    Dim status = IIf(IsDBNull(x.Item("status")), 0, x.Item("status").ToString)
                    Dim trxkey = trxDate & " type: " & trxType & " value: " & trxValue & " status: " & status
                    Me.lbTrxList.Items.Add(trxkey)
                    If itemGUID <> "" Then
                        Dim isexists = False
                        For Each c In trxList
                            If c.Key = trxkey Then
                                isexists = True
                                Exit For
                            End If
                        Next
                        If Not isexists Then
                            trxList.Add(trxkey, New TrxType With {.ItemGUID = itemGUID, .Account = rcxKey, .Value = trxValue, .trxType = trxType, .Note = rcxKey, .trxDate = trxDate, .assetGUID = assetGUID, .status = status})
                        End If
                    End If
                Next
            End If
        End If

    End Sub
    Sub getNodeSetting()
        Me.tbWellknownServer.Text = My.Settings.wellKnownAddress
        Me.tbODBC.Text = "Data Source=(localdb)\operahouse;Initial Catalog=blockchainv2;Integrated Security=True" 'My.Settings.odbc
        Me.tbNodeEDT.Text = "***********************************"
        Me.tbNodePwd.Text = ""
        Me.CheckBox1.Checked = My.Settings.asFullNode
        Me.CheckBox2.Checked = My.Settings.asProcessNode

    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Cursor = Cursors.WaitCursor
        getWalletHistory(True)
        Cursor = Cursors.Default
    End Sub

    Private Sub bRefresh_Click(sender As Object, e As EventArgs) Handles bRefresh.Click
        Cursor = Cursors.WaitCursor
        reloadData(True)
        Cursor = Cursors.Default
    End Sub

    Private Sub bContactSave_Click(sender As Object, e As EventArgs) Handles bContactSave.Click
        Cursor = Cursors.WaitCursor
        Dim isExists = False
        Dim contactAccount = Me.tbContactAccount.Text
        Dim contactName = Me.tbContactName.Text
        If contactAccount <> "" And contactName <> "" Then

            For Each x In accountList(currentAccount).contactJSON
                If x.Key = contactName Then
                    isExists = True
                    Exit For
                End If
            Next
            Dim cl = accountList(currentAccount).contactJSON
            If Not isExists Then
                Me.lbContactList.Items.Add(contactName)
                cl.Add(contactName, New ContactType With {.contactQT = Me.tbContactAccount.Text, .ContactName = Me.tbContactName.Text, .EmailAddress = Me.tbContactEmail.Text})
            Else
                cl(contactName).EmailAddress = Me.tbContactEmail.Text
                cl(contactName).ContactName = Me.tbContactName.Text
                cl(contactName).contactQT = Me.tbContactAccount.Text
            End If
            'My.Settings.contactList = json
            'accountList(currentAccount).contactJSON = json
            saveAccount("", "", "", "", "")
            'My.Settings.Save()
            Me.tbContactAccount.Text = ""
            Me.tbContactEmail.Text = ""
            Me.tbContactName.Text = ""
        Else
            MessageBox.Show("Please complete all data before saving!")
        End If
        Cursor = Cursors.Default

    End Sub

    Private Sub lbContactList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbContactList.SelectedIndexChanged
        If Not IsNothing(Me.lbContactList.SelectedItem) And currentAccount <> "" Then
            Dim curAccount = accountList(currentAccount).contactJSON(Me.lbContactList.SelectedItem)
            'If GetWin32Process("", curAccount.sqlId) <> curAccount.sqlId Then
            Me.tbContactAccount.Text = curAccount.contactQT
            Me.tbContactName.Text = Me.lbContactList.SelectedItem
            Me.tbContactEmail.Text = curAccount.EmailAddress
        End If
    End Sub

    Private Sub bContactNew_Click(sender As Object, e As EventArgs) Handles bContactNew.Click
        Me.tbContactAccount.Text = ""
        Me.tbContactName.Text = ""
        Me.tbContactEmail.Text = ""
    End Sub

    Private Sub bSend_Click(sender As Object, e As EventArgs) Handles bSend.Click
        If Me.tbSendMessage.Text <> "" Then

            Dim odbc = "Data Source=(localdb)\operahouse;Initial Catalog=blockchainv2;Integrated Security=True" 'My.Settings.odbc
            Dim pwd = Me.currentPassword
            If pwd <> "" Then
                Cursor = Cursors.WaitCursor
                'Dim sqlstr = "declare @ed nvarchar(max); exec createWallet 'live', '" & pwd & "', @ed output; select @ed"
                'Dim ed = My.Settings.myEDT
                Dim ed = accountList(currentAccount).AccountEDT
                Dim sqlstr = "exec wallet_sendAsset null, '" & assetGUID & "', '" & Me.tbContactAccount.Text & "', " & Me.tbSendAmount.Text & ", 2, '" & Me.tbSendMessage.Text & "', 'live', '" & ed & "', '" & pwd & "'"

                Dim r = runSQLwithResult(sqlstr, odbc)
                If r <> "" Then
                    MessageBox.Show(r)
                Else
                    Me.tbSendAmount.Text = Format(0, "#,##0")
                    Me.tbSendMessage.Text = ""
                    getWalletStatus(True)
                    getWalletHistory(True)
                End If
                Cursor = Cursors.Default
            Else
                MessageBox.Show("Please put a password to continue!")
            End If

        Else
            MessageBox.Show("Please put your message to continue!")
        End If
    End Sub

    Private Sub cbAccountList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAccountList.SelectedIndexChanged
        Dim c = Me.cbAccountList.SelectedItem
        If currentAccount <> c Then
            Dim oldPassword = currentPassword
            currentPassword = ""
            My.Forms.login.curEDT = accountList(c).AccountEDT
            If currentPassword = "" Then My.Forms.login.ShowDialog()
            If currentPassword <> "" Then
                If Not IsNothing(Me.cbAccountList.SelectedItem) Then
                    currentAccount = Me.cbAccountList.SelectedItem
                    My.Settings.curAccount = currentAccount
                    My.Settings.Save()
                    'Me.lbContactList.Items.Clear()
                    reloadData(False)
                End If
            Else
                If currentAccount <> "" Then
                    cbAccountList.SelectedIndex = cbAccountList.FindString(currentAccount)
                    currentPassword = oldPassword
                Else
                    Me.Close()
                End If
            End If
        End If
    End Sub

    Private Sub lbTrxList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTrxList.SelectedIndexChanged
        If Not IsNothing(Me.lbTrxList.SelectedItem) Then
            Dim curTrx = trxList(Me.lbTrxList.SelectedItem)
            'If GetWin32Process("", curAccount.sqlId) <> curAccount.sqlId Then
            Me.tbAccount.Text = curTrx.Account
            Me.tbNote.Text = "Trx Date: " & curTrx.trxDate & "Asset: " & curTrx.assetGUID & vbCrLf & "Type: " & curTrx.trxType & vbCrLf & "Ref: " & curTrx.ItemGUID
            Me.tbAmount.Text = curTrx.Value
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'My.Settings.odbc = Me.tbODBC.Text
        'My.Settings.wellKnownAddress = Me.tbWellknownServer.Text
        My.Settings.asFullNode = Me.CheckBox1.Checked
        My.Settings.asProcessNode = Me.CheckBox2.Checked
        My.Settings.Save()

        Dim odbc = Me.tbODBC.Text
        Dim pwd1 = Me.tbNodePwd.Text
        Dim edt = Me.tbNodeEDT.Text
        If pwd1 <> "" Then
            Dim sqlstr = "exec wallet_login 'live', '" & edt & "', '" & pwd1 & "', @issilent=0"
            Dim d As DataSet = SelectSqlSrvRows(sqlstr, odbc)
            If d.Tables.Count > 0 AndAlso d.Tables(0).Rows.Count > 0 Then
                'Dim qt = d.Tables(0).Rows(0).Item("qt")
                My.Settings.NodeEDT = Me.tbNodeEDT.Text
                My.Settings.Save()
            Else
                MessageBox.Show("Your Node Private Key is not correct!")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim odbc = Me.tbODBC.Text
        'Dim instanceName = odbc.Substring(odbc.IndexOf("data source=") + 12, odbc.Length - odbc.IndexOf("data source=") + 12)
        'instanceName = instanceName.Substring(0, instanceName.IndexOf(";"))
        Dim instancename = "OPERAHOUSE"

        startInstance("OPERAHOUSE")
        SetLog("OPERAHOUSE started")

        pipename = getPipeName(instancename)
        If syncLocalScript("use " & coreDB, coreDB, pipename) Then
            Dim mdfFile = Directory.GetCurrentDirectory & "\" & folderData & "\" & coreDB & "_data.mdf"
            Dim ldfFile = Directory.GetCurrentDirectory & "\" & folderData & "\" & coreDB & "_log.ldf"
            syncLocalScript("CREATE DATABASE " & coreDB & " On ( NAME = " & coreDB & "_data, FILENAME = '" & mdfFile & "') Log ON ( NAME = " & coreDB & "_log, FILENAME = '" & ldfFile & "');", "master", pipename)

            Dim pwd1 = Me.tbNodePwd.Text
            Dim edt = Me.tbNodeEDT.Text
            Dim cmdstr = "exec node_run null, 1, '" & edt & "', '" & pwd1 & "'"
            sqlId = asynclocalScript(cmdstr, coreDB, pipename)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Function asynclocalScript(sqlstr, db, pipename) As Integer
        'eventHandled = False

        Dim p As Process = New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True
        p.EnableRaisingEvents = True

        AddHandler p.ErrorDataReceived, AddressOf OutputDataReceivedSQL
        AddHandler p.OutputDataReceived, AddressOf OutputDataReceivedSQL

        p.StartInfo.FileName = "sqlcmd.exe"
        p.StartInfo.Arguments = "-S " & pipename & " -Q """ & sqlstr & """" & IIf(db <> "", " -d " & db, "")
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden


        p.Start()
        Dim sqlId = p.Id

        p.BeginErrorReadLine()
        p.BeginOutputReadLine()
        Return sqlId
    End Function
    Public Sub OutputDataReceivedSQL(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Try
            Dim t = IIf(e.Data = "", "", Now() & " NODE " & e.Data & vbCrLf)
            'lastMessage = lastMessage & t

            If Me.InvokeRequired = True Then
                'Me.Invoke(myDelegate, e.Data)
                Me.Invoke(New Action(Sub() Me.tbLog.AppendText(t)))
            Else
                'UpdateTextBox(e.Data)
                Me.tbLog.AppendText(t)
            End If
            'eventHandled = True

            WriteLog(t)
        Catch ex As Exception

        End Try

    End Sub
    Sub WriteLog(logMessage As String)
        Dim path = Directory.GetCurrentDirectory() & "\log"
        path = path & "\" '& "OPHContent\log\"
        Dim logFilepath = path & DateTime.Now().Year & "\" & Strings.Right("0" & DateTime.Now().Month, 2) & "\" & Strings.Right("0" & DateTime.Now().Day, 2) & ".txt"
        Dim logPath = path & DateTime.Now().Year & "\" & Strings.Right("0" & DateTime.Now().Month, 2) & "\"

        If (Not System.IO.Directory.Exists(logPath)) Then
            System.IO.Directory.CreateDirectory(logPath)
        End If
        Try
            Using w As StreamWriter = File.AppendText(logFilepath)
                w.WriteLine("{0}", logMessage)

            End Using

        Catch ex As Exception
            Debug.Write(ex.Message.ToString)
        End Try
    End Sub
    Function getPipeName(instanceName) As String
        Dim p As Process = New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C sqllocaldb info " & instanceName
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.Start()

        Dim sOutput As String = p.StandardOutput.ReadToEnd()
        p.WaitForExit()
        SetLog(sOutput)

        Dim pipeName As String = ""
        If Not (sOutput Is Nothing Or sOutput.Trim().Length = 0 Or sOutput.Contains("not recognized")) Then
            For Each info In sOutput.Replace(vbCr, "").Split(vbLf)
                If info.Split(":")(0) = "Instance pipe name" And info.Split(":")(1).Trim() <> "" Then
                    pipeName = info.Split(":")(1) & ":" & info.Split(":")(2)
                    Exit For
                End If
            Next
        End If
        Return pipeName
    End Function
    Sub SetLog(txt, Optional title = "")
        Dim t = IIf(txt = "", "", Now() & " " & title & ": " & txt & vbCrLf)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Sub() Me.tbLog.AppendText(t)))
        Else
            Me.tbLog.AppendText(t)

        End If

        WriteLog(t)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cursor = Cursors.WaitCursor
        installInstance()
        Cursor = Cursors.Default
    End Sub
    Sub installInstance()
        'If isLocaldb Then
        If checkInstance("OPERAHOUSE") <> "OPERAHOUSE" Then
            installLocalDB(Directory.GetCurrentDirectory() & "\" & folderTemp, Directory.GetCurrentDirectory() & "\" & folderData)
            SetLog("localDB installed")
            createInstance("OPERAHOUSE")
            SetLog("OPERAHOUSE created")
        End If

        startInstance("OPERAHOUSE")
        SetLog("OPERAHOUSE started")
        pipename = getPipeName("OPERAHOUSE")
        SetLog("Pipename: " & pipename)


        If Not syncLocalScript("use " & coreDB, coreDB, pipename) Then
            Dim ftemp = Directory.GetCurrentDirectory() & "\" & folderTemp
            Dim fdata = Directory.GetCurrentDirectory() & "\" & folderData

            If Not Directory.Exists(ftemp & "") Then
                Directory.CreateDirectory(ftemp & "")
            End If
            If Not Directory.Exists(fdata) Then
                Directory.CreateDirectory(fdata)
            End If

            Dim b As Byte() = My.Resources.Resources.resources
            My.Computer.FileSystem.WriteAllBytes(ftemp & "\resources.rar", b, False)
            unZip(ftemp & "\resources.rar", ftemp)
            File.Delete(ftemp & "\resources.rar")



            Dim mdfFile = Directory.GetCurrentDirectory & "\" & folderData & "\" & coreDB & "_data.mdf"
            Dim ldfFile = Directory.GetCurrentDirectory & "\" & folderData & "\" & coreDB & "_log.ldf"
            syncLocalScript("CREATE DATABASE " & coreDB & " On ( NAME = " & coreDB & "_data, FILENAME = '" & mdfFile & "') Log ON ( NAME = " & coreDB & "_log, FILENAME = '" & ldfFile & "');", "master", pipename)
            syncLocalScript("CREATE SCHEMA [gen]", coreDB, pipename)
            syncLocalScript("EXEC sp_changedbowner 'sa'; ALTER DATABASE " & coreDB & " SET TRUSTWORTHY ON", coreDB, pipename)
            syncLocalScript("sp_configure 'show advanced options', 1;RECONFIGURE", coreDB, pipename)
            syncLocalScript("sp_configure 'clr enabled', 1;RECONFIGURE", coreDB, pipename)

            Dim localFile1 = Directory.GetCurrentDirectory & "\" & folderTemp & "\webRequest.dll"
            Dim localFile2 = Directory.GetCurrentDirectory & "\" & folderTemp & "\crypto.dll"
            Dim localFile3 = Directory.GetCurrentDirectory & "\" & folderTemp & "\cryptoSQL.dll"

            If File.Exists(localFile1) Then
                syncLocalScript("if not exists(select * from sys.assemblies where name='webRequest') create assembly webRequest from '" & localFile1 & "' with PERMISSION_SET = unsafe", coreDB, pipename)

                syncLocalScript("if not exists(select * from sys.objects where name='fn_get_webrequest') begin	declare @sqlstr nvarchar(max)='CREATE FUNCTION [gen].[fn_get_webrequest](@uri [nvarchar](max), @user [nvarchar](255) = N'''', @passwd [nvarchar](255) = N'''') RETURNS [nvarchar](max) WITH EXECUTE AS CALLER AS EXTERNAL NAME [webRequest].[webRequest.Functions].[GET]';	exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='fn_post_webrequest') begin	declare @sqlstr nvarchar(max)='CREATE FUNCTION [gen].[fn_post_webrequest](@uri [nvarchar](max), @postdata [nvarchar](max), @user [nvarchar](255) = N'''', @passwd [nvarchar](255) = N'''', @headers [nvarchar](max)) RETURNS [nvarchar](max) WITH EXECUTE AS CALLER AS EXTERNAL NAME [webRequest].[webRequest.Functions].[POST]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
            End If
            If File.Exists(localFile2) Then
                syncLocalScript("if not exists(select * from sys.assemblies where name='crypto') create assembly crypto from '" & localFile2 & "' with PERMISSION_SET = unsafe", coreDB, pipename)
            End If
            If File.Exists(localFile3) Then
                syncLocalScript("if not exists(select * from sys.assemblies where name='cryptoSQL') create assembly cryptoSQL from '" & localFile3 & "' with PERMISSION_SET = unsafe", coreDB, pipename)

                syncLocalScript("if not exists(select * from sys.objects where name='decrypt2F') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[decrypt2F](@m [nvarchar](max), @p [nvarchar](200), @s [nvarchar](200)) RETURNS [nvarchar](max) WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[decrypt2F]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='decryptAES') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[decryptAES](@m [nvarchar](max), @k [nvarchar](200), @s [nvarchar](200)) RETURNS [nvarchar](max) WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[decryptAES]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='encrypt2F') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[encrypt2F](@m [nvarchar](max), @p [nvarchar](200), @s [nvarchar](200)) RETURNS [nvarchar](max) WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[encrypt2F]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='encryptAES') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[encryptAES](@m [nvarchar](max), @k [nvarchar](200), @s [nvarchar](200)) RETURNS [nvarchar](max) WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[encryptAES]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='generateKeys') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[generateKeys](@key [nvarchar](4), @network [nvarchar](10)) RETURNS [Xml] WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[generateKeys]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='getDerivedKey') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[getDerivedKey](@ss [nvarchar](100)) RETURNS [nvarchar](100) WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[getDerivedKey]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='getSharedSecret') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[getSharedSecret](@key [nvarchar](4), @prv [nvarchar](100), @pub [nvarchar](100)) RETURNS [nvarchar](100) WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[getSharedSecret]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='getSignature') begin	declare @sqlstr nvarchar(max)='CREATE Function [gen].[GetSignature](@key [nvarchar](4), @prv [nvarchar](100), @msg [nvarchar](max)) RETURNS [nvarchar](max) WITH EXECUTE AS CALLER AS EXTERNAL Name [cryptoSQL].[cryptoSQL.functions].[getSignature]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='retrievePublicKey') begin	declare @sqlstr nvarchar(max)='CREATE FUNCTION [gen].[retrievePublicKey](@key [nvarchar](4), @prv [nvarchar](100)) RETURNS [nvarchar](100) WITH EXECUTE AS CALLER AS EXTERNAL NAME [cryptoSQL].[cryptoSQL.functions].[retrievePublicKey]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
                syncLocalScript("if not exists(select * from sys.objects where name='VerifySignature') begin	declare @sqlstr nvarchar(max)='CREATE FUNCTION [gen].[VerifySignature](@key [nvarchar](4), @pub [nvarchar](100), @msg [nvarchar](max), @sig [nvarchar](max)) RETURNS [bit] WITH EXECUTE AS CALLER AS EXTERNAL NAME [cryptoSQL].[cryptoSQL.functions].[verifySignature]'; exec sp_executesql @sqlstr; end", coreDB, pipename)
            End If
            If File.Exists(ftemp & "\script.sql") Then
                runScript("", pipename, ftemp & "\script.sql", coreDB)
            End If
        End If

        startNode()
        'Else
        'pipename = My.Settings.dbInstanceName
        'End If
    End Sub
    Function installLocalDB(ftemp, fdata) As Boolean
        Dim r = True
        'Dim url = "https://go.microsoft.com/fwlink/?linkid=853017"  '2017
        'Dim url = "https://go.microsoft.com/fwlink/?LinkID=799012" '2016
        'Dim url = "http://download.microsoft.com/download/E/A/E/EAE6F7FC-767A-4038-A954-49B8B05D04EB/ExpressAndTools%2032BIT/SQLEXPRWT_x86_ENU.exe" '2014
        'Dim url = "http://download.microsoft.com/download/8/D/D/8DD7BDBA-CEF7-4D8E-8C16-D9F69527F909/ENU/x86/SQLEXPRWT_x86_ENU.exe" '2012
        'Dim url = "http://download.microsoft.com/download/8/D/D/8DD7BDBA-CEF7-4D8E-8C16-D9F69527F909/ENU/x86/SqlLocaLDB.MSI" 'localdb 2012
        Dim url = "http://media.operahouse.systems/sqllocaldb-2017.msi"

        Dim filename = ftemp & "\sqllocaldb.msi"
        If Not Directory.Exists(ftemp & "") Then
            Directory.CreateDirectory(ftemp & "")
        End If
        If Not Directory.Exists(fdata & "") Then
            Directory.CreateDirectory(fdata & "")
        End If
        If Not File.Exists(filename) Then
            If downloadFilename(url, filename) Then
                Dim runfilename = """" & filename & """"
                Dim info As New ProcessStartInfo()
                info.FileName = "c:\windows\system32\msiexec.exe"
                info.Arguments = " /i """ & ftemp & "\SqlLocalDB.msi"" IACCEPTSQLLOCALDBLICENSETERMS=YES /qn"
                Process.Start(info)
            Else
                r = False
            End If
        End If
        Return r
    End Function
    Function checkInstance(instanceName) As String
        Dim p As Process = New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C sqllocaldb info " & instanceName
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.Start()

        Dim sOutput As String = p.StandardOutput.ReadToEnd()
        p.WaitForExit()
        SetLog(sOutput)

        Dim pipeName As String = ""
        If Not (sOutput Is Nothing Or sOutput.Trim().Length = 0 Or sOutput.Contains("not recognized") Or sOutput.Contains("doesn't exist")) Then
            For Each info In sOutput.Split(vbCrLf)
                If info.Split(":")(0) = "Name" Then
                    pipeName = info.Split(":")(1).Trim()
                    Exit For
                End If
            Next
        End If
        Return pipeName
    End Function
    Function syncLocalScript(sqlstr, db, pipename) As Boolean
        Dim p As Process = New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.RedirectStandardError = True

        p.StartInfo.FileName = "sqlcmd.exe"
        p.StartInfo.Arguments = "-S " & pipename & " -Q """ & sqlstr & """" & IIf(db <> "", " -d " & db, "")
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden


        p.Start()

        Dim sOutput As String = p.StandardOutput.ReadToEnd()
        p.WaitForExit()
        SetLog(sOutput)

        If (sOutput Is Nothing Or sOutput.Trim().Length = 0 Or sOutput.Contains("does not exist")) Then
            Return False
        Else
            Return True
        End If
    End Function
    Function downloadFilename(url, localpath) As Boolean
        Dim r = True
        Dim wc As New WebClient()
        Try
            wc.DownloadFile(url, localpath)
        Catch ex As Exception
            SetLog(ex.Message)
            r = False
        End Try
        Return r
    End Function
    Sub startInstance(instanceName)
        Dim p As Process = New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C sqllocaldb start " & instanceName
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.Start()

        Dim sOutput As String = p.StandardOutput.ReadToEnd()
        p.WaitForExit()
        SetLog(sOutput)
    End Sub
    Sub createInstance(instanceName)
        Dim p As Process = New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C sqllocaldb create " & instanceName
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.Start()

        Dim sOutput As String = p.StandardOutput.ReadToEnd()
        p.WaitForExit()
        SetLog(sOutput)
    End Sub

    Sub deleteInstance(instanceName)
        Dim p As Process = New Process()
        p.StartInfo.UseShellExecute = False
        p.StartInfo.RedirectStandardOutput = True
        p.StartInfo.FileName = "cmd.exe"
        p.StartInfo.Arguments = "/C sqllocaldb delete " & instanceName
        p.StartInfo.CreateNoWindow = True
        p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        p.Start()

        Dim sOutput As String = p.StandardOutput.ReadToEnd()
        p.WaitForExit()
        SetLog(sOutput)
    End Sub
    Sub unZip(zipPath, extractPath)
        File.Delete(extractPath & "\crypto.dll")
        File.Delete(extractPath & "\cryptoSQL.dll")
        File.Delete(extractPath & "\webRequest.dll")
        File.Delete(extractPath & "\script.sql")
        ZipFile.ExtractToDirectory(zipPath, extractPath)
    End Sub
    Function runScript(url, pipename, scriptFile, db) As Boolean
        Dim r = True
        If File.Exists(scriptFile) And url <> "" Then
            File.Delete(scriptFile)
            downloadFilename(url, scriptFile)
        End If
        If File.Exists(scriptFile) Then
            Dim p As Process = New Process()
            p.StartInfo.UseShellExecute = False
            p.StartInfo.RedirectStandardOutput = True
            p.StartInfo.FileName = "sqlcmd.exe"
            p.StartInfo.Arguments = "-S " & pipename & " -d " & db & " -i """ & scriptFile & """"
            p.StartInfo.CreateNoWindow = True
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            p.Start()

            Dim sOutput As String = p.StandardOutput.ReadToEnd()
            p.WaitForExit()
            SetLog(sOutput)
        Else
            r = False
        End If
        Return r
    End Function

    Private Sub bReceiveSave_Click(sender As Object, e As EventArgs) Handles bReceiveSave.Click

    End Sub
End Class
