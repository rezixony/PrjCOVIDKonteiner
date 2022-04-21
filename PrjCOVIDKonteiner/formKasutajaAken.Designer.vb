<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formKasutajaAken
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formKasutajaAken))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCOVIDInfo = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaailmaStatistika = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMaakondadeStatistika = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEestiStatistika = New Guna.UI2.WinForms.Guna2Button()
        Me.bunifuChart = New Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.btnExit)
        Me.Guna2Panel1.Controls.Add(Me.btnCOVIDInfo)
        Me.Guna2Panel1.Controls.Add(Me.btnMaailmaStatistika)
        Me.Guna2Panel1.Controls.Add(Me.btnMaakondadeStatistika)
        Me.Guna2Panel1.Controls.Add(Me.btnEestiStatistika)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(239, 702)
        Me.Guna2Panel1.TabIndex = 15
        '
        'btnExit
        '
        Me.btnExit.Animated = True
        Me.btnExit.AutoRoundedCorners = True
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BorderRadius = 19
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(0, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(233, 40)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        '
        'btnCOVIDInfo
        '
        Me.btnCOVIDInfo.Animated = True
        Me.btnCOVIDInfo.AutoRoundedCorners = True
        Me.btnCOVIDInfo.BackColor = System.Drawing.Color.Transparent
        Me.btnCOVIDInfo.BorderRadius = 19
        Me.btnCOVIDInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCOVIDInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCOVIDInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCOVIDInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCOVIDInfo.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnCOVIDInfo.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.btnCOVIDInfo.ForeColor = System.Drawing.Color.White
        Me.btnCOVIDInfo.Location = New System.Drawing.Point(3, 349)
        Me.btnCOVIDInfo.Name = "btnCOVIDInfo"
        Me.btnCOVIDInfo.Size = New System.Drawing.Size(233, 40)
        Me.btnCOVIDInfo.TabIndex = 19
        Me.btnCOVIDInfo.Text = "COVID info"
        '
        'btnMaailmaStatistika
        '
        Me.btnMaailmaStatistika.Animated = True
        Me.btnMaailmaStatistika.AutoRoundedCorners = True
        Me.btnMaailmaStatistika.BackColor = System.Drawing.Color.Transparent
        Me.btnMaailmaStatistika.BorderRadius = 19
        Me.btnMaailmaStatistika.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaailmaStatistika.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaailmaStatistika.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaailmaStatistika.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMaailmaStatistika.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnMaailmaStatistika.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.btnMaailmaStatistika.ForeColor = System.Drawing.Color.White
        Me.btnMaailmaStatistika.Location = New System.Drawing.Point(3, 294)
        Me.btnMaailmaStatistika.Name = "btnMaailmaStatistika"
        Me.btnMaailmaStatistika.Size = New System.Drawing.Size(233, 40)
        Me.btnMaailmaStatistika.TabIndex = 18
        Me.btnMaailmaStatistika.Text = "Maailma statistika"
        '
        'btnMaakondadeStatistika
        '
        Me.btnMaakondadeStatistika.Animated = True
        Me.btnMaakondadeStatistika.AutoRoundedCorners = True
        Me.btnMaakondadeStatistika.BackColor = System.Drawing.Color.Transparent
        Me.btnMaakondadeStatistika.BorderRadius = 20
        Me.btnMaakondadeStatistika.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnMaakondadeStatistika.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnMaakondadeStatistika.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnMaakondadeStatistika.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnMaakondadeStatistika.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnMaakondadeStatistika.Font = New System.Drawing.Font("Segoe UI", 14.7!)
        Me.btnMaakondadeStatistika.ForeColor = System.Drawing.Color.White
        Me.btnMaakondadeStatistika.Location = New System.Drawing.Point(3, 236)
        Me.btnMaakondadeStatistika.Name = "btnMaakondadeStatistika"
        Me.btnMaakondadeStatistika.Size = New System.Drawing.Size(233, 42)
        Me.btnMaakondadeStatistika.TabIndex = 17
        Me.btnMaakondadeStatistika.Text = "Maakondade statistika"
        '
        'btnEestiStatistika
        '
        Me.btnEestiStatistika.Animated = True
        Me.btnEestiStatistika.AutoRoundedCorners = True
        Me.btnEestiStatistika.BackColor = System.Drawing.Color.Transparent
        Me.btnEestiStatistika.BorderRadius = 19
        Me.btnEestiStatistika.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEestiStatistika.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEestiStatistika.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEestiStatistika.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEestiStatistika.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btnEestiStatistika.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.btnEestiStatistika.ForeColor = System.Drawing.Color.White
        Me.btnEestiStatistika.Location = New System.Drawing.Point(3, 178)
        Me.btnEestiStatistika.Name = "btnEestiStatistika"
        Me.btnEestiStatistika.Size = New System.Drawing.Size(233, 40)
        Me.btnEestiStatistika.TabIndex = 16
        Me.btnEestiStatistika.Text = "Eesti statistika"
        '
        'bunifuChart
        '
        Me.bunifuChart.BackgroundColor = CType(resources.GetObject("bunifuChart.BackgroundColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.bunifuChart.BorderColor = CType(resources.GetObject("bunifuChart.BorderColor"), System.Collections.Generic.List(Of System.Drawing.Color))
        Me.bunifuChart.BorderSkipped = Nothing
        Me.bunifuChart.BorderWidth = 0
        Me.bunifuChart.Data = CType(resources.GetObject("bunifuChart.Data"), System.Collections.Generic.List(Of Double))
        Me.bunifuChart.HoverBackgroundColor = System.Drawing.Color.Empty
        Me.bunifuChart.HoverBorderColor = System.Drawing.Color.Empty
        Me.bunifuChart.HoverBorderWidth = 0
        Me.bunifuChart.Label = "Label here"
        Me.bunifuChart.TargetCanvas = Nothing
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel2.Location = New System.Drawing.Point(239, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1173, 695)
        Me.Guna2Panel2.TabIndex = 20
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderRadius = 57
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "Tere tulemasti Eesti Statistika Dashboardi!"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(198, 236)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(8, 8, 8, 8)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(717, 116)
        Me.Guna2TextBox1.TabIndex = 47
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 702)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "formKasutajaAken"
        Me.Text = "COVID andmed"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnEestiStatistika As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCOVIDInfo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaailmaStatistika As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaakondadeStatistika As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents bunifuChart As Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
