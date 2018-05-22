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
        Me.tpSend = New System.Windows.Forms.TabPage()
        Me.bContactSave = New System.Windows.Forms.Button()
        Me.bContactNew = New System.Windows.Forms.Button()
        Me.bSend = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.tpReception = New System.Windows.Forms.TabPage()
        Me.tpBalance = New System.Windows.Forms.TabPage()
        Me.tpSettings = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbReception = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bReceiveSave = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.bCancelSend = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.bRefresh = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.tbMyAddress = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.tpSend.SuspendLayout()
        Me.tpReception.SuspendLayout()
        Me.tpBalance.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tpBalance)
        Me.TabControl1.Controls.Add(Me.tpSend)
        Me.TabControl1.Controls.Add(Me.tpReception)
        Me.TabControl1.Controls.Add(Me.tpSettings)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(556, 353)
        Me.TabControl1.TabIndex = 0
        '
        'tpSend
        '
        Me.tpSend.Controls.Add(Me.bCancelSend)
        Me.tpSend.Controls.Add(Me.bContactSave)
        Me.tpSend.Controls.Add(Me.bContactNew)
        Me.tpSend.Controls.Add(Me.bSend)
        Me.tpSend.Controls.Add(Me.Label8)
        Me.tpSend.Controls.Add(Me.TextBox6)
        Me.tpSend.Controls.Add(Me.TextBox5)
        Me.tpSend.Controls.Add(Me.Label7)
        Me.tpSend.Controls.Add(Me.Label5)
        Me.tpSend.Controls.Add(Me.TextBox3)
        Me.tpSend.Controls.Add(Me.Label4)
        Me.tpSend.Controls.Add(Me.TextBox2)
        Me.tpSend.Controls.Add(Me.Label3)
        Me.tpSend.Controls.Add(Me.TextBox1)
        Me.tpSend.Controls.Add(Me.Label2)
        Me.tpSend.Controls.Add(Me.Label1)
        Me.tpSend.Controls.Add(Me.ListBox1)
        Me.tpSend.Location = New System.Drawing.Point(4, 22)
        Me.tpSend.Name = "tpSend"
        Me.tpSend.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSend.Size = New System.Drawing.Size(548, 327)
        Me.tpSend.TabIndex = 0
        Me.tpSend.Text = "Send"
        Me.tpSend.UseVisualStyleBackColor = True
        '
        'bContactSave
        '
        Me.bContactSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bContactSave.Location = New System.Drawing.Point(166, 298)
        Me.bContactSave.Name = "bContactSave"
        Me.bContactSave.Size = New System.Drawing.Size(75, 23)
        Me.bContactSave.TabIndex = 5
        Me.bContactSave.Text = "Save"
        Me.bContactSave.UseVisualStyleBackColor = True
        '
        'bContactNew
        '
        Me.bContactNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bContactNew.Location = New System.Drawing.Point(85, 298)
        Me.bContactNew.Name = "bContactNew"
        Me.bContactNew.Size = New System.Drawing.Size(75, 23)
        Me.bContactNew.TabIndex = 4
        Me.bContactNew.Text = "New"
        Me.bContactNew.UseVisualStyleBackColor = True
        '
        'bSend
        '
        Me.bSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bSend.Location = New System.Drawing.Point(467, 298)
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
        Me.Label8.Location = New System.Drawing.Point(296, 275)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Amount"
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(355, 272)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(187, 20)
        Me.TextBox6.TabIndex = 7
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(299, 220)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox5.Size = New System.Drawing.Size(243, 46)
        Me.TextBox5.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(296, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Message"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email Address"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(85, 272)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(187, 20)
        Me.TextBox3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Address"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(86, 246)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(186, 20)
        Me.TextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(86, 220)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(186, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contact Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Contact List"
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(536, 173)
        Me.ListBox1.TabIndex = 0
        '
        'tpReception
        '
        Me.tpReception.Controls.Add(Me.bReceiveSave)
        Me.tpReception.Controls.Add(Me.Label13)
        Me.tpReception.Controls.Add(Me.TextBox9)
        Me.tpReception.Controls.Add(Me.TextBox10)
        Me.tpReception.Controls.Add(Me.Label14)
        Me.tpReception.Controls.Add(Me.Label9)
        Me.tpReception.Controls.Add(Me.TextBox4)
        Me.tpReception.Controls.Add(Me.Label10)
        Me.tpReception.Controls.Add(Me.TextBox7)
        Me.tpReception.Controls.Add(Me.Label11)
        Me.tpReception.Controls.Add(Me.TextBox8)
        Me.tpReception.Controls.Add(Me.Label12)
        Me.tpReception.Controls.Add(Me.lbReception)
        Me.tpReception.Controls.Add(Me.Label6)
        Me.tpReception.Location = New System.Drawing.Point(4, 22)
        Me.tpReception.Name = "tpReception"
        Me.tpReception.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReception.Size = New System.Drawing.Size(548, 327)
        Me.tpReception.TabIndex = 1
        Me.tpReception.Text = "Receive"
        Me.tpReception.UseVisualStyleBackColor = True
        '
        'tpBalance
        '
        Me.tpBalance.Controls.Add(Me.tbMyAddress)
        Me.tpBalance.Controls.Add(Me.Label16)
        Me.tpBalance.Controls.Add(Me.bRefresh)
        Me.tpBalance.Controls.Add(Me.TextBox11)
        Me.tpBalance.Controls.Add(Me.Label15)
        Me.tpBalance.Location = New System.Drawing.Point(4, 22)
        Me.tpBalance.Name = "tpBalance"
        Me.tpBalance.Size = New System.Drawing.Size(548, 327)
        Me.tpBalance.TabIndex = 2
        Me.tpBalance.Text = "Balance"
        Me.tpBalance.UseVisualStyleBackColor = True
        '
        'tpSettings
        '
        Me.tpSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpSettings.Name = "tpSettings"
        Me.tpSettings.Size = New System.Drawing.Size(548, 327)
        Me.tpSettings.TabIndex = 3
        Me.tpSettings.Text = "Settings"
        Me.tpSettings.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Reception List"
        '
        'lbReception
        '
        Me.lbReception.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbReception.FormattingEnabled = True
        Me.lbReception.Location = New System.Drawing.Point(6, 19)
        Me.lbReception.Name = "lbReception"
        Me.lbReception.Size = New System.Drawing.Size(536, 173)
        Me.lbReception.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 275)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Email Address"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(85, 272)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(187, 20)
        Me.TextBox4.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Address"
        '
        'TextBox7
        '
        Me.TextBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox7.Location = New System.Drawing.Point(86, 246)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(186, 20)
        Me.TextBox7.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Name"
        '
        'TextBox8
        '
        Me.TextBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox8.Location = New System.Drawing.Point(86, 220)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(186, 20)
        Me.TextBox8.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(86, 13)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Reception Detail"
        '
        'bReceiveSave
        '
        Me.bReceiveSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bReceiveSave.Location = New System.Drawing.Point(467, 298)
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
        Me.Label13.Location = New System.Drawing.Point(296, 275)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Amount"
        '
        'TextBox9
        '
        Me.TextBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox9.Location = New System.Drawing.Point(355, 272)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(187, 20)
        Me.TextBox9.TabIndex = 6
        '
        'TextBox10
        '
        Me.TextBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox10.Location = New System.Drawing.Point(299, 220)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox10.Size = New System.Drawing.Size(243, 46)
        Me.TextBox10.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(296, 204)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Message"
        '
        'bCancelSend
        '
        Me.bCancelSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bCancelSend.Location = New System.Drawing.Point(386, 298)
        Me.bCancelSend.Name = "bCancelSend"
        Me.bCancelSend.Size = New System.Drawing.Size(75, 23)
        Me.bCancelSend.TabIndex = 9
        Me.bCancelSend.Text = "Cancel"
        Me.bCancelSend.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(22, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 31)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Balance"
        '
        'TextBox11
        '
        Me.TextBox11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(28, 136)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(492, 38)
        Me.TextBox11.TabIndex = 1
        '
        'bRefresh
        '
        Me.bRefresh.Location = New System.Drawing.Point(445, 180)
        Me.bRefresh.Name = "bRefresh"
        Me.bRefresh.Size = New System.Drawing.Size(75, 23)
        Me.bRefresh.TabIndex = 2
        Me.bRefresh.Text = "Refresh"
        Me.bRefresh.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(25, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "My Address"
        '
        'tbMyAddress
        '
        Me.tbMyAddress.Location = New System.Drawing.Point(28, 73)
        Me.tbMyAddress.Name = "tbMyAddress"
        Me.tbMyAddress.ReadOnly = True
        Me.tbMyAddress.Size = New System.Drawing.Size(492, 20)
        Me.tbMyAddress.TabIndex = 4
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
        Me.tpSend.ResumeLayout(False)
        Me.tpSend.PerformLayout()
        Me.tpReception.ResumeLayout(False)
        Me.tpReception.PerformLayout()
        Me.tpBalance.ResumeLayout(False)
        Me.tpBalance.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpSend As TabPage
    Friend WithEvents bContactSave As Button
    Friend WithEvents bContactNew As Button
    Friend WithEvents bSend As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents tpReception As TabPage
    Friend WithEvents tpBalance As TabPage
    Friend WithEvents tpSettings As TabPage
    Friend WithEvents bCancelSend As Button
    Friend WithEvents bReceiveSave As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents lbReception As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents bRefresh As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents tbMyAddress As TextBox
    Friend WithEvents Label16 As Label
End Class
