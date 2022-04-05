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
        Me.lblSeePaev = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCases = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl14p = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPerPopulation = New System.Windows.Forms.Label()
        Me.lblNextDay = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.clndrKuupaev = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.cbMaakond = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnLeia = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.bunifuChart = New Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(Me.components)
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSeePaev
        '
        Me.lblSeePaev.AutoSize = True
        Me.lblSeePaev.Location = New System.Drawing.Point(662, 133)
        Me.lblSeePaev.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeePaev.Name = "lblSeePaev"
        Me.lblSeePaev.Size = New System.Drawing.Size(23, 13)
        Me.lblSeePaev.TabIndex = 1
        Me.lblSeePaev.Text = "Arv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(582, 133)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sellel paeval"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(582, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kokku"
        '
        'lblTotalCases
        '
        Me.lblTotalCases.AutoSize = True
        Me.lblTotalCases.Location = New System.Drawing.Point(662, 158)
        Me.lblTotalCases.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalCases.Name = "lblTotalCases"
        Me.lblTotalCases.Size = New System.Drawing.Size(23, 13)
        Me.lblTotalCases.TabIndex = 4
        Me.lblTotalCases.Text = "Arv"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(594, 186)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Viimase 14p jooksul"
        '
        'lbl14p
        '
        Me.lbl14p.AutoSize = True
        Me.lbl14p.Location = New System.Drawing.Point(710, 187)
        Me.lbl14p.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl14p.Name = "lbl14p"
        Me.lbl14p.Size = New System.Drawing.Size(23, 13)
        Me.lbl14p.TabIndex = 6
        Me.lbl14p.Text = "Arv"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(594, 213)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Per population"
        '
        'lblPerPopulation
        '
        Me.lblPerPopulation.AutoSize = True
        Me.lblPerPopulation.Location = New System.Drawing.Point(710, 213)
        Me.lblPerPopulation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPerPopulation.Name = "lblPerPopulation"
        Me.lblPerPopulation.Size = New System.Drawing.Size(23, 13)
        Me.lblPerPopulation.TabIndex = 8
        Me.lblPerPopulation.Text = "Arv"
        '
        'lblNextDay
        '
        Me.lblNextDay.AutoSize = True
        Me.lblNextDay.Location = New System.Drawing.Point(706, 253)
        Me.lblNextDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNextDay.Name = "lblNextDay"
        Me.lblNextDay.Size = New System.Drawing.Size(23, 13)
        Me.lblNextDay.TabIndex = 11
        Me.lblNextDay.Text = "Arv"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(616, 253)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Next Day:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(239, 695)
        Me.Guna2Panel1.TabIndex = 15
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.AutoRoundedCorners = True
        Me.Guna2Button4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button4.BorderRadius = 19
        Me.Guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.Guna2Button4.ForeColor = System.Drawing.Color.White
        Me.Guna2Button4.Location = New System.Drawing.Point(3, 349)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.Size = New System.Drawing.Size(233, 40)
        Me.Guna2Button4.TabIndex = 19
        Me.Guna2Button4.Text = "COVID info"
        '
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.AutoRoundedCorners = True
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 19
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.White
        Me.Guna2Button3.Location = New System.Drawing.Point(3, 294)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(233, 40)
        Me.Guna2Button3.TabIndex = 18
        Me.Guna2Button3.Text = "Maailma statistika"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button2.BorderRadius = 20
        Me.Guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 14.7!)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.Location = New System.Drawing.Point(3, 236)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.Size = New System.Drawing.Size(233, 42)
        Me.Guna2Button2.TabIndex = 17
        Me.Guna2Button2.Text = "Maakondade statistika"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 19
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(3, 178)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(233, 40)
        Me.Guna2Button1.TabIndex = 16
        Me.Guna2Button1.Text = "Eesti statistika"
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
        Me.clndrKuupaev.Location = New System.Drawing.Point(494, 25)
        Me.clndrKuupaev.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.clndrKuupaev.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.clndrKuupaev.Name = "clndrKuupaev"
        Me.clndrKuupaev.Size = New System.Drawing.Size(200, 36)
        Me.clndrKuupaev.TabIndex = 16
        Me.clndrKuupaev.Value = New Date(2022, 4, 5, 14, 44, 14, 746)
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
        Me.cbMaakond.Location = New System.Drawing.Point(545, 89)
        Me.cbMaakond.Name = "cbMaakond"
        Me.cbMaakond.Size = New System.Drawing.Size(140, 36)
        Me.cbMaakond.TabIndex = 17
        '
        'btnLeia
        '
        Me.btnLeia.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLeia.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLeia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeia.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLeia.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.btnLeia.ForeColor = System.Drawing.Color.White
        Me.btnLeia.Location = New System.Drawing.Point(465, 78)
        Me.btnLeia.Name = "btnLeia"
        Me.btnLeia.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnLeia.Size = New System.Drawing.Size(74, 68)
        Me.btnLeia.TabIndex = 18
        Me.btnLeia.Text = "Leia"
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
        'CartesianChart1
        '
        Me.CartesianChart1.Location = New System.Drawing.Point(724, 332)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(350, 251)
        Me.CartesianChart1.TabIndex = 19
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 695)
        Me.Controls.Add(Me.CartesianChart1)
        Me.Controls.Add(Me.btnLeia)
        Me.Controls.Add(Me.cbMaakond)
        Me.Controls.Add(Me.clndrKuupaev)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNextDay)
        Me.Controls.Add(Me.lblPerPopulation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl14p)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalCases)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeePaev)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "formKasutajaAken"
        Me.Text = "COVID andmed"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeePaev As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalCases As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl14p As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPerPopulation As Label
    Friend WithEvents lblNextDay As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clndrKuupaev As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents cbMaakond As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnLeia As Guna.UI2.WinForms.Guna2GradientCircleButton
    Friend WithEvents bunifuChart As Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
End Class
