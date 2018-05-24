<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wallet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpBalance = New System.Windows.Forms.TabPage()
        Me.tbMyAddress = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.bRefresh = New System.Windows.Forms.Button()
        Me.tbBalance = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tpSend = New System.Windows.Forms.TabPage()
        Me.bCancelSend = New System.Windows.Forms.Button()
        Me.bContactSave = New System.Windows.Forms.Button()
        Me.bContactNew = New System.Windows.Forms.Button()
        Me.bSend = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbSendAmount = New System.Windows.Forms.TextBox()
        Me.tbSendMessage = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbContactEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbContactAccount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbContactName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbContactList = New System.Windows.Forms.ListBox()
        Me.tpTrxList = New System.Windows.Forms.TabPage()
        Me.bReceiveSave = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbTrxList = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tpSettings = New System.Windows.Forms.TabPage()
        Me.bNewAccountSave = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.tbNewAcountPwd = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.bImportSave = New System.Windows.Forms.Button()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbImportED = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.bSaveProfile = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tbMyAccount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.tbMyEmail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbMyFullName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbMyUserName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelPwd = New System.Windows.Forms.Label()
        Me.tbImportPwd = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tpBalance.SuspendLayout()
        Me.tpSend.SuspendLayout()
        Me.tpTrxList.SuspendLayout()
        Me.tpSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpBalance)
        Me.TabControl1.Controls.Add(Me.tpSend)
        Me.TabControl1.Controls.Add(Me.tpTrxList)
        Me.TabControl1.Controls.Add(Me.tpSettings)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(556, 353)
        Me.TabControl1.TabIndex = 0
        '
        'tpBalance
        '
        Me.tpBalance.Controls.Add(Me.tbMyAddress)
        Me.tpBalance.Controls.Add(Me.Label16)
        Me.tpBalance.Controls.Add(Me.bRefresh)
        Me.tpBalance.Controls.Add(Me.tbBalance)
        Me.tpBalance.Controls.Add(Me.Label15)
        Me.tpBalance.Location = New System.Drawing.Point(4, 22)
        Me.tpBalance.Name = "tpBalance"
        Me.tpBalance.Size = New System.Drawing.Size(548, 327)
        Me.tpBalance.TabIndex = 2
        Me.tpBalance.Text = "Balance"
        Me.tpBalance.UseVisualStyleBackColor = True
        '
        'tbMyAddress
        '
        Me.tbMyAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMyAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMyAddress.Location = New System.Drawing.Point(28, 42)
        Me.tbMyAddress.Name = "tbMyAddress"
        Me.tbMyAddress.ReadOnly = True
        Me.tbMyAddress.Size = New System.Drawing.Size(492, 17)
        Me.tbMyAddress.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "My Account"
        '
        'bRefresh
        '
        Me.bRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bRefresh.Location = New System.Drawing.Point(445, 149)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(75, 23)
        Me.bRefresh.TabIndex = 2
        Me.bRefresh.Text = "Refresh"
        Me.bRefresh.UseVisualStyleBackColor = True
        '
        'tbBalance
        '
        Me.tbBalance.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBalance.Location = New System.Drawing.Point(28, 105)
        Me.tbBalance.Name = "tbBalance"
        Me.tbBalance.ReadOnly = True
        Me.tbBalance.Size = New System.Drawing.Size(492, 38)
        Me.tbBalance.TabIndex = 1
        Me.tbBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 71)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 31)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Balance"
        '
        'tpSend
        '
        Me.tpSend.Controls.Add(Me.bCancelSend)
        Me.tpSend.Controls.Add(Me.bContactSave)
        Me.tpSend.Controls.Add(Me.bContactNew)
        Me.tpSend.Controls.Add(Me.bSend)
        Me.tpSend.Controls.Add(Me.Label8)
        Me.tpSend.Controls.Add(Me.tbSendAmount)
        Me.tpSend.Controls.Add(Me.tbSendMessage)
        Me.tpSend.Controls.Add(Me.Label7)
        Me.tpSend.Controls.Add(Me.Label5)
        Me.tpSend.Controls.Add(Me.tbContactEmail)
        Me.tpSend.Controls.Add(Me.Label4)
        Me.tpSend.Controls.Add(Me.tbContactAccount)
        Me.tpSend.Controls.Add(Me.Label3)
        Me.tpSend.Controls.Add(Me.tbContactName)
        Me.tpSend.Controls.Add(Me.Label2)
        Me.tpSend.Controls.Add(Me.Label1)
        Me.tpSend.Controls.Add(Me.lbContactList)
        Me.tpSend.Location = New System.Drawing.Point(4, 22)
        Me.tpSend.Name = "tpSend"
        Me.tpSend.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSend.Size = New System.Drawing.Size(548, 327)
        Me.tpSend.TabIndex = 0
        Me.tpSend.Text = "Send"
        Me.tpSend.UseVisualStyleBackColor = True
        '
        'bCancelSend
        '
        Me.bCancelSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bCancelSend.Location = New System.Drawing.Point(386, 294)
        Me.bCancelSend.Name = "bCancelSend"
        Me.bCancelSend.Size = New System.Drawing.Size(75, 23)
        Me.bCancelSend.TabIndex = 9
        Me.bCancelSend.Text = "Cancel Trx"
        Me.bCancelSend.UseVisualStyleBackColor = True
        '
        'bContactSave
        '
        Me.bContactSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bContactSave.Location = New System.Drawing.Point(467, 187)
        Me.bContactSave.Name = "bContactSave"
        Me.bContactSave.Size = New System.Drawing.Size(75, 23)
        Me.bContactSave.TabIndex = 5
        Me.bContactSave.Text = "Save"
        Me.bContactSave.UseVisualStyleBackColor = True
        '
        'bContactNew
        '
        Me.bContactNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bContactNew.Location = New System.Drawing.Point(386, 187)
        Me.bContactNew.Name = "bContactNew"
        Me.bContactNew.Size = New System.Drawing.Size(75, 23)
        Me.bContactNew.TabIndex = 4
        Me.bContactNew.Text = "New"
        Me.bContactNew.UseVisualStyleBackColor = True
        '
        'bSend
        '
        Me.bSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSend.Location = New System.Drawing.Point(467, 294)
        Me.bSend.Name = "bSend"
        Me.bSend.Size = New System.Drawing.Size(75, 23)
        Me.bSend.TabIndex = 8
        Me.bSend.Text = "Send Now"
        Me.bSend.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Amount"
        '
        'tbSendAmount
        '
        Me.tbSendAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSendAmount.Location = New System.Drawing.Point(86, 268)
        Me.tbSendAmount.Name = "tbSendAmount"
        Me.tbSendAmount.Size = New System.Drawing.Size(456, 20)
        Me.tbSendAmount.TabIndex = 7
        '
        'tbSendMessage
        '
        Me.tbSendMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSendMessage.Location = New System.Drawing.Point(86, 216)
        Me.tbSendMessage.Multiline = True
        Me.tbSendMessage.Name = "tbSendMessage"
        Me.tbSendMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbSendMessage.Size = New System.Drawing.Size(456, 46)
        Me.tbSendMessage.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Message"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email Address"
        '
        'tbContactEmail
        '
        Me.tbContactEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContactEmail.Location = New System.Drawing.Point(86, 161)
        Me.tbContactEmail.Name = "tbContactEmail"
        Me.tbContactEmail.Size = New System.Drawing.Size(456, 20)
        Me.tbContactEmail.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Account"
        '
        'tbContactAccount
        '
        Me.tbContactAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContactAccount.Location = New System.Drawing.Point(86, 135)
        Me.tbContactAccount.Name = "tbContactAccount"
        Me.tbContactAccount.Size = New System.Drawing.Size(456, 20)
        Me.tbContactAccount.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'tbContactName
        '
        Me.tbContactName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbContactName.Location = New System.Drawing.Point(86, 109)
        Me.tbContactName.Name = "tbContactName"
        Me.tbContactName.Size = New System.Drawing.Size(456, 20)
        Me.tbContactName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contact Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contact List"
        '
        'lbContactList
        '
        Me.lbContactList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbContactList.FormattingEnabled = True
        Me.lbContactList.Location = New System.Drawing.Point(6, 21)
        Me.lbContactList.Name = "lbContactList"
        Me.lbContactList.Size = New System.Drawing.Size(536, 69)
        Me.lbContactList.TabIndex = 0
        '
        'tpTrxList
        '
        Me.tpTrxList.Controls.Add(Me.Button1)
        Me.tpTrxList.Controls.Add(Me.bReceiveSave)
        Me.tpTrxList.Controls.Add(Me.Label13)
        Me.tpTrxList.Controls.Add(Me.TextBox9)
        Me.tpTrxList.Controls.Add(Me.TextBox10)
        Me.tpTrxList.Controls.Add(Me.Label14)
        Me.tpTrxList.Controls.Add(Me.Label10)
        Me.tpTrxList.Controls.Add(Me.TextBox7)
        Me.tpTrxList.Controls.Add(Me.Label12)
        Me.tpTrxList.Controls.Add(Me.lbTrxList)
        Me.tpTrxList.Controls.Add(Me.Label6)
        Me.tpTrxList.Location = New System.Drawing.Point(4, 22)
        Me.tpTrxList.Name = "tpTrxList"
        Me.tpTrxList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTrxList.Size = New System.Drawing.Size(548, 327)
        Me.tpTrxList.TabIndex = 1
        Me.tpTrxList.Text = "Transaction"
        Me.tpTrxList.UseVisualStyleBackColor = True
        '
        'bReceiveSave
        '
        Me.bReceiveSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bReceiveSave.Location = New System.Drawing.Point(467, 294)
        Me.bReceiveSave.Name = "bReceiveSave"
        Me.bReceiveSave.Size = New System.Drawing.Size(75, 23)
        Me.bReceiveSave.TabIndex = 7
        Me.bReceiveSave.Text = "Save"
        Me.bReceiveSave.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 271)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Amount"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Location = New System.Drawing.Point(85, 268)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(457, 20)
        Me.TextBox9.TabIndex = 6
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.Location = New System.Drawing.Point(85, 216)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox10.Size = New System.Drawing.Size(457, 46)
        Me.TextBox10.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 216)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Note"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Account"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(85, 190)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(456, 20)
        Me.TextBox7.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Trx Detail"
        '
        'lbTrxList
        '
        Me.lbTrxList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTrxList.FormattingEnabled = True
        Me.lbTrxList.Items.AddRange(New Object() {"account - 10000"})
        Me.lbTrxList.Location = New System.Drawing.Point(6, 21)
        Me.lbTrxList.Name = "lbTrxList"
        Me.lbTrxList.Size = New System.Drawing.Size(536, 134)
        Me.lbTrxList.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Trx List"
        '
        'tpSettings
        '
        Me.tpSettings.Controls.Add(Me.LabelPwd)
        Me.tpSettings.Controls.Add(Me.tbImportPwd)
        Me.tpSettings.Controls.Add(Me.bNewAccountSave)
        Me.tpSettings.Controls.Add(Me.Label24)
        Me.tpSettings.Controls.Add(Me.tbNewAcountPwd)
        Me.tpSettings.Controls.Add(Me.Label25)
        Me.tpSettings.Controls.Add(Me.bImportSave)
        Me.tpSettings.Controls.Add(Me.Label23)
        Me.tpSettings.Controls.Add(Me.tbImportED)
        Me.tpSettings.Controls.Add(Me.Label22)
        Me.tpSettings.Controls.Add(Me.bSaveProfile)
        Me.tpSettings.Controls.Add(Me.Label21)
        Me.tpSettings.Controls.Add(Me.tbMyAccount)
        Me.tpSettings.Controls.Add(Me.Label20)
        Me.tpSettings.Controls.Add(Me.tbMyEmail)
        Me.tpSettings.Controls.Add(Me.Label19)
        Me.tpSettings.Controls.Add(Me.tbMyFullName)
        Me.tpSettings.Controls.Add(Me.Label18)
        Me.tpSettings.Controls.Add(Me.tbMyUserName)
        Me.tpSettings.Controls.Add(Me.Label17)
        Me.tpSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpSettings.Name = "tpSettings"
        Me.tpSettings.Size = New System.Drawing.Size(548, 327)
        Me.tpSettings.TabIndex = 3
        Me.tpSettings.Text = "Settings"
        Me.tpSettings.UseVisualStyleBackColor = True
        '
        'bNewAccountSave
        '
        Me.bNewAccountSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bNewAccountSave.Location = New System.Drawing.Point(461, 284)
        Me.bNewAccountSave.Name = "bNewAccountSave"
        Me.bNewAccountSave.Size = New System.Drawing.Size(75, 23)
        Me.bNewAccountSave.TabIndex = 17
        Me.bNewAccountSave.Text = "Save"
        Me.bNewAccountSave.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 261)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Password"
        '
        'tbNewAcountPwd
        '
        Me.tbNewAcountPwd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNewAcountPwd.Location = New System.Drawing.Point(86, 258)
        Me.tbNewAcountPwd.Name = "tbNewAcountPwd"
        Me.tbNewAcountPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNewAcountPwd.Size = New System.Drawing.Size(450, 20)
        Me.tbNewAcountPwd.TabIndex = 16
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 242)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(83, 13)
        Me.Label25.TabIndex = 15
        Me.Label25.Text = "New Account"
        '
        'bImportSave
        '
        Me.bImportSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bImportSave.Location = New System.Drawing.Point(461, 218)
        Me.bImportSave.Name = "bImportSave"
        Me.bImportSave.Size = New System.Drawing.Size(75, 23)
        Me.bImportSave.TabIndex = 15
        Me.bImportSave.Text = "Save"
        Me.bImportSave.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 169)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 12
        Me.Label23.Text = "Private Key"
        '
        'tbImportED
        '
        Me.tbImportED.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbImportED.Location = New System.Drawing.Point(86, 166)
        Me.tbImportED.Name = "tbImportED"
        Me.tbImportED.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbImportED.Size = New System.Drawing.Size(450, 20)
        Me.tbImportED.TabIndex = 13
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(93, 13)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "Import Account"
        '
        'bSaveProfile
        '
        Me.bSaveProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bSaveProfile.Location = New System.Drawing.Point(461, 125)
        Me.bSaveProfile.Name = "bSaveProfile"
        Me.bSaveProfile.Size = New System.Drawing.Size(75, 23)
        Me.bSaveProfile.TabIndex = 9
        Me.bSaveProfile.Text = "Save"
        Me.bSaveProfile.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(47, 13)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Account"
        '
        'tbMyAccount
        '
        Me.tbMyAccount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMyAccount.Location = New System.Drawing.Point(86, 99)
        Me.tbMyAccount.Name = "tbMyAccount"
        Me.tbMyAccount.ReadOnly = True
        Me.tbMyAccount.Size = New System.Drawing.Size(450, 20)
        Me.tbMyAccount.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 76)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(73, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Email Address"
        '
        'tbMyEmail
        '
        Me.tbMyEmail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMyEmail.Location = New System.Drawing.Point(86, 73)
        Me.tbMyEmail.Name = "tbMyEmail"
        Me.tbMyEmail.Size = New System.Drawing.Size(450, 20)
        Me.tbMyEmail.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 50)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(54, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Full Name"
        '
        'tbMyFullName
        '
        Me.tbMyFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMyFullName.Location = New System.Drawing.Point(86, 47)
        Me.tbMyFullName.Name = "tbMyFullName"
        Me.tbMyFullName.Size = New System.Drawing.Size(450, 20)
        Me.tbMyFullName.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "User Name"
        '
        'tbMyUserName
        '
        Me.tbMyUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMyUserName.Location = New System.Drawing.Point(86, 21)
        Me.tbMyUserName.Name = "tbMyUserName"
        Me.tbMyUserName.Size = New System.Drawing.Size(450, 20)
        Me.tbMyUserName.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(6, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "My Profile"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(466, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelPwd
        '
        Me.LabelPwd.AutoSize = True
        Me.LabelPwd.Location = New System.Drawing.Point(6, 195)
        Me.LabelPwd.Name = "LabelPwd"
        Me.LabelPwd.Size = New System.Drawing.Size(53, 13)
        Me.LabelPwd.TabIndex = 19
        Me.LabelPwd.Text = "Password"
        '
        'tbImportPwd
        '
        Me.tbImportPwd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbImportPwd.Location = New System.Drawing.Point(86, 192)
        Me.tbImportPwd.Name = "tbImportPwd"
        Me.tbImportPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbImportPwd.Size = New System.Drawing.Size(450, 20)
        Me.tbImportPwd.TabIndex = 14
        '
        'wallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 377)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "wallet"
        Me.Text = "Wallet"
        Me.TabControl1.ResumeLayout(False)
        Me.tpBalance.ResumeLayout(False)
        Me.tpBalance.PerformLayout()
        Me.tpSend.ResumeLayout(False)
        Me.tpSend.PerformLayout()
        Me.tpTrxList.ResumeLayout(False)
        Me.tpTrxList.PerformLayout()
        Me.tpSettings.ResumeLayout(False)
        Me.tpSettings.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpSend As TabPage
    Friend WithEvents bContactSave As Button
    Friend WithEvents bContactNew As Button
    Friend WithEvents bSend As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbSendAmount As TextBox
    Friend WithEvents tbSendMessage As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tbContactEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbContactAccount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbContactName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbContactList As ListBox
    Friend WithEvents tpTrxList As TabPage
    Friend WithEvents tpBalance As TabPage
    Friend WithEvents tpSettings As TabPage
    Friend WithEvents bCancelSend As Button
    Friend WithEvents bReceiveSave As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbTrxList As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bRefresh As Button
    Friend WithEvents tbBalance As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbMyAddress As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tbMyEmail As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents tbMyFullName As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents tbMyUserName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents bSaveProfile As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents tbMyAccount As TextBox
    Friend WithEvents bImportSave As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents tbImportED As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents bNewAccountSave As Button
    Friend WithEvents Label24 As Label
    Friend WithEvents tbNewAcountPwd As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelPwd As Label
    Friend WithEvents tbImportPwd As TextBox
End Class
