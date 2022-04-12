<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMaakondadeStatistika
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSeePaevMaakond = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCasesMaakond = New System.Windows.Forms.Label()
        Me.clndrKuupaev = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnLeiaMaakond = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.cbMaakond = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lblSeePaevMaakond)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.lblTotalCasesMaakond)
        Me.Guna2Panel1.Controls.Add(Me.clndrKuupaev)
        Me.Guna2Panel1.Controls.Add(Me.btnLeiaMaakond)
        Me.Guna2Panel1.Controls.Add(Me.cbMaakond)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1149, 671)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderRadius = 49
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "Maakondade Statistika"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(313, 6)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(543, 100)
        Me.Guna2TextBox1.TabIndex = 45
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(559, 327)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Sellel paeval"
        '
        'lblSeePaevMaakond
        '
        Me.lblSeePaevMaakond.AutoSize = True
        Me.lblSeePaevMaakond.Location = New System.Drawing.Point(639, 327)
        Me.lblSeePaevMaakond.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeePaevMaakond.Name = "lblSeePaevMaakond"
        Me.lblSeePaevMaakond.Size = New System.Drawing.Size(23, 13)
        Me.lblSeePaevMaakond.TabIndex = 35
        Me.lblSeePaevMaakond.Text = "Arv"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(559, 352)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Kokku"
        '
        'lblTotalCasesMaakond
        '
        Me.lblTotalCasesMaakond.AutoSize = True
        Me.lblTotalCasesMaakond.Location = New System.Drawing.Point(639, 352)
        Me.lblTotalCasesMaakond.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalCasesMaakond.Name = "lblTotalCasesMaakond"
        Me.lblTotalCasesMaakond.Size = New System.Drawing.Size(23, 13)
        Me.lblTotalCasesMaakond.TabIndex = 38
        Me.lblTotalCasesMaakond.Text = "Arv"
        '
        'clndrKuupaev
        '
        Me.clndrKuupaev.AutoRoundedCorners = True
        Me.clndrKuupaev.BorderRadius = 17
        Me.clndrKuupaev.Checked = True
        Me.clndrKuupaev.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clndrKuupaev.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.clndrKuupaev.ForeColor = System.Drawing.Color.DarkOrchid
        Me.clndrKuupaev.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.clndrKuupaev.Location = New System.Drawing.Point(493, 209)
        Me.clndrKuupaev.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.clndrKuupaev.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.clndrKuupaev.Name = "clndrKuupaev"
        Me.clndrKuupaev.Size = New System.Drawing.Size(200, 36)
        Me.clndrKuupaev.TabIndex = 34
        Me.clndrKuupaev.Value = New Date(2022, 4, 12, 0, 0, 0, 0)
        '
        'btnLeiaMaakond
        '
        Me.btnLeiaMaakond.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLeiaMaakond.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLeiaMaakond.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeiaMaakond.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeiaMaakond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLeiaMaakond.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnLeiaMaakond.ForeColor = System.Drawing.Color.White
        Me.btnLeiaMaakond.Location = New System.Drawing.Point(421, 263)
        Me.btnLeiaMaakond.Name = "btnLeiaMaakond"
        Me.btnLeiaMaakond.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnLeiaMaakond.Size = New System.Drawing.Size(74, 68)
        Me.btnLeiaMaakond.TabIndex = 33
        Me.btnLeiaMaakond.Text = "Leia"
        '
        'cbMaakond
        '
        Me.cbMaakond.AutoRoundedCorners = True
        Me.cbMaakond.BackColor = System.Drawing.Color.Transparent
        Me.cbMaakond.BorderRadius = 17
        Me.cbMaakond.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbMaakond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMaakond.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbMaakond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbMaakond.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbMaakond.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbMaakond.ItemHeight = 30
        Me.cbMaakond.Items.AddRange(New Object() {"Eesti", "Harju maakond", "Hiiu maakond", "Ida-Viru maakond", "Järva maakond", "Jõgeva maakond", "Lääne maakond", "Lääne-Viru maakond", "Pärnu maakond", "Põlva maakond", "Rapla maakond", "Saare maakond", "Tartu maakond", "Valga maakond", "Viljandi maakond", "Võru maakond"})
        Me.cbMaakond.Location = New System.Drawing.Point(531, 278)
        Me.cbMaakond.Name = "cbMaakond"
        Me.cbMaakond.Size = New System.Drawing.Size(140, 36)
        Me.cbMaakond.TabIndex = 32
        '
        'formMaakondadeStatistika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1173, 695)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formMaakondadeStatistika"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbMaakond As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnLeiaMaakond As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents clndrKuupaev As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSeePaevMaakond As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalCasesMaakond As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
