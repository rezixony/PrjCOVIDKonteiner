<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEestiStatistika
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLeiaEesti = New Guna.UI2.WinForms.Guna2GradientCircleButton()
        Me.txtPaevadeArv = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblNextDay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblPerPopulation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl14p = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblTotalCases = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDailyCases = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox7 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox6 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox5 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.kjlkj = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.clndrKuupaev = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.btnLeiaEesti)
        Me.Guna2Panel1.Controls.Add(Me.txtPaevadeArv)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox3)
        Me.Guna2Panel1.Controls.Add(Me.lblNextDay)
        Me.Guna2Panel1.Controls.Add(Me.lblPerPopulation)
        Me.Guna2Panel1.Controls.Add(Me.lbl14p)
        Me.Guna2Panel1.Controls.Add(Me.lblTotalCases)
        Me.Guna2Panel1.Controls.Add(Me.lblDailyCases)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox4)
        Me.Guna2Panel1.Controls.Add(Me.kjlkj)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel1.Controls.Add(Me.CartesianChart1)
        Me.Guna2Panel1.Controls.Add(Me.clndrKuupaev)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1149, 671)
        Me.Guna2Panel1.TabIndex = 0
        '
        'btnLeiaEesti
        '
        Me.btnLeiaEesti.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLeiaEesti.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLeiaEesti.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeiaEesti.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLeiaEesti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLeiaEesti.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLeiaEesti.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLeiaEesti.Font = New System.Drawing.Font("Book Antiqua", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeiaEesti.ForeColor = System.Drawing.Color.Blue
        Me.btnLeiaEesti.Location = New System.Drawing.Point(529, 270)
        Me.btnLeiaEesti.Name = "btnLeiaEesti"
        Me.btnLeiaEesti.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnLeiaEesti.Size = New System.Drawing.Size(98, 53)
        Me.btnLeiaEesti.TabIndex = 61
        Me.btnLeiaEesti.Text = "Leia"
        '
        'txtPaevadeArv
        '
        Me.txtPaevadeArv.AutoRoundedCorners = True
        Me.txtPaevadeArv.BorderRadius = 26
        Me.txtPaevadeArv.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPaevadeArv.DefaultText = ""
        Me.txtPaevadeArv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPaevadeArv.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPaevadeArv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPaevadeArv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPaevadeArv.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.txtPaevadeArv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaevadeArv.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.txtPaevadeArv.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.txtPaevadeArv.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPaevadeArv.Location = New System.Drawing.Point(586, 207)
        Me.txtPaevadeArv.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtPaevadeArv.Name = "txtPaevadeArv"
        Me.txtPaevadeArv.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPaevadeArv.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.txtPaevadeArv.PlaceholderText = ""
        Me.txtPaevadeArv.SelectedText = ""
        Me.txtPaevadeArv.Size = New System.Drawing.Size(258, 55)
        Me.txtPaevadeArv.TabIndex = 60
        Me.txtPaevadeArv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.AutoRoundedCorners = True
        Me.Guna2TextBox3.BorderRadius = 26
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = "Mitme eelneva päeva jaoks?"
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(319, 207)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.ReadOnly = True
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(257, 55)
        Me.Guna2TextBox3.TabIndex = 59
        Me.Guna2TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNextDay
        '
        Me.lblNextDay.AutoRoundedCorners = True
        Me.lblNextDay.BorderRadius = 29
        Me.lblNextDay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNextDay.DefaultText = "Arv"
        Me.lblNextDay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblNextDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblNextDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblNextDay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblNextDay.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lblNextDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNextDay.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.lblNextDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblNextDay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNextDay.Location = New System.Drawing.Point(1043, 347)
        Me.lblNextDay.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblNextDay.Name = "lblNextDay"
        Me.lblNextDay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblNextDay.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.lblNextDay.PlaceholderText = ""
        Me.lblNextDay.ReadOnly = True
        Me.lblNextDay.SelectedText = ""
        Me.lblNextDay.Size = New System.Drawing.Size(81, 60)
        Me.lblNextDay.TabIndex = 57
        Me.lblNextDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPerPopulation
        '
        Me.lblPerPopulation.AutoRoundedCorners = True
        Me.lblPerPopulation.BorderRadius = 29
        Me.lblPerPopulation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblPerPopulation.DefaultText = "Arv"
        Me.lblPerPopulation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblPerPopulation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblPerPopulation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPerPopulation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblPerPopulation.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lblPerPopulation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPerPopulation.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.lblPerPopulation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblPerPopulation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPerPopulation.Location = New System.Drawing.Point(1043, 263)
        Me.lblPerPopulation.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblPerPopulation.Name = "lblPerPopulation"
        Me.lblPerPopulation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblPerPopulation.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.lblPerPopulation.PlaceholderText = ""
        Me.lblPerPopulation.ReadOnly = True
        Me.lblPerPopulation.SelectedText = ""
        Me.lblPerPopulation.Size = New System.Drawing.Size(81, 60)
        Me.lblPerPopulation.TabIndex = 56
        Me.lblPerPopulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl14p
        '
        Me.lbl14p.AutoRoundedCorners = True
        Me.lbl14p.BorderRadius = 29
        Me.lbl14p.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lbl14p.DefaultText = "Arv"
        Me.lbl14p.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lbl14p.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lbl14p.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl14p.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lbl14p.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lbl14p.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl14p.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.lbl14p.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lbl14p.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl14p.Location = New System.Drawing.Point(196, 312)
        Me.lbl14p.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lbl14p.Name = "lbl14p"
        Me.lbl14p.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lbl14p.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.lbl14p.PlaceholderText = ""
        Me.lbl14p.ReadOnly = True
        Me.lbl14p.SelectedText = ""
        Me.lbl14p.Size = New System.Drawing.Size(81, 60)
        Me.lbl14p.TabIndex = 55
        Me.lbl14p.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotalCases
        '
        Me.lblTotalCases.AutoRoundedCorners = True
        Me.lblTotalCases.BorderRadius = 29
        Me.lblTotalCases.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblTotalCases.DefaultText = "Arv"
        Me.lblTotalCases.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblTotalCases.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblTotalCases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblTotalCases.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblTotalCases.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lblTotalCases.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalCases.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.lblTotalCases.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblTotalCases.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalCases.Location = New System.Drawing.Point(196, 219)
        Me.lblTotalCases.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblTotalCases.Name = "lblTotalCases"
        Me.lblTotalCases.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblTotalCases.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.lblTotalCases.PlaceholderText = ""
        Me.lblTotalCases.ReadOnly = True
        Me.lblTotalCases.SelectedText = ""
        Me.lblTotalCases.Size = New System.Drawing.Size(81, 60)
        Me.lblTotalCases.TabIndex = 54
        Me.lblTotalCases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDailyCases
        '
        Me.lblDailyCases.AutoRoundedCorners = True
        Me.lblDailyCases.BorderRadius = 29
        Me.lblDailyCases.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblDailyCases.DefaultText = "Arv"
        Me.lblDailyCases.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.lblDailyCases.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.lblDailyCases.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblDailyCases.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lblDailyCases.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.lblDailyCases.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDailyCases.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.lblDailyCases.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.lblDailyCases.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDailyCases.Location = New System.Drawing.Point(196, 132)
        Me.lblDailyCases.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.lblDailyCases.Name = "lblDailyCases"
        Me.lblDailyCases.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lblDailyCases.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.lblDailyCases.PlaceholderText = ""
        Me.lblDailyCases.ReadOnly = True
        Me.lblDailyCases.SelectedText = ""
        Me.lblDailyCases.Size = New System.Drawing.Size(81, 60)
        Me.lblDailyCases.TabIndex = 53
        Me.lblDailyCases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox7
        '
        Me.Guna2TextBox7.AutoRoundedCorners = True
        Me.Guna2TextBox7.BorderRadius = 29
        Me.Guna2TextBox7.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox7.DefaultText = "Järgmine päev:"
        Me.Guna2TextBox7.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox7.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox7.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox7.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox7.Location = New System.Drawing.Point(881, 347)
        Me.Guna2TextBox7.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox7.Name = "Guna2TextBox7"
        Me.Guna2TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox7.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Guna2TextBox7.PlaceholderText = ""
        Me.Guna2TextBox7.ReadOnly = True
        Me.Guna2TextBox7.SelectedText = ""
        Me.Guna2TextBox7.Size = New System.Drawing.Size(152, 60)
        Me.Guna2TextBox7.TabIndex = 52
        Me.Guna2TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox6
        '
        Me.Guna2TextBox6.AutoRoundedCorners = True
        Me.Guna2TextBox6.BorderRadius = 29
        Me.Guna2TextBox6.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox6.DefaultText = "Per population:"
        Me.Guna2TextBox6.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox6.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox6.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox6.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox6.Location = New System.Drawing.Point(881, 263)
        Me.Guna2TextBox6.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox6.Name = "Guna2TextBox6"
        Me.Guna2TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox6.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Guna2TextBox6.PlaceholderText = ""
        Me.Guna2TextBox6.ReadOnly = True
        Me.Guna2TextBox6.SelectedText = ""
        Me.Guna2TextBox6.Size = New System.Drawing.Size(152, 60)
        Me.Guna2TextBox6.TabIndex = 51
        Me.Guna2TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox5
        '
        Me.Guna2TextBox5.AutoRoundedCorners = True
        Me.Guna2TextBox5.BorderRadius = 29
        Me.Guna2TextBox5.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox5.DefaultText = "Viimased 14p:"
        Me.Guna2TextBox5.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox5.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox5.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox5.Location = New System.Drawing.Point(43, 312)
        Me.Guna2TextBox5.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox5.Name = "Guna2TextBox5"
        Me.Guna2TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox5.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Guna2TextBox5.PlaceholderText = ""
        Me.Guna2TextBox5.ReadOnly = True
        Me.Guna2TextBox5.SelectedText = ""
        Me.Guna2TextBox5.Size = New System.Drawing.Size(143, 60)
        Me.Guna2TextBox5.TabIndex = 50
        Me.Guna2TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.AutoRoundedCorners = True
        Me.Guna2TextBox4.BorderRadius = 29
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = "Kokku:"
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(43, 219)
        Me.Guna2TextBox4.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Guna2TextBox4.PlaceholderText = ""
        Me.Guna2TextBox4.ReadOnly = True
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(143, 60)
        Me.Guna2TextBox4.TabIndex = 49
        Me.Guna2TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'kjlkj
        '
        Me.kjlkj.AutoRoundedCorners = True
        Me.kjlkj.BorderRadius = 29
        Me.kjlkj.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kjlkj.DefaultText = "Nakatunud:"
        Me.kjlkj.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.kjlkj.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.kjlkj.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kjlkj.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.kjlkj.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.kjlkj.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kjlkj.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.kjlkj.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.kjlkj.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.kjlkj.Location = New System.Drawing.Point(43, 132)
        Me.kjlkj.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.kjlkj.Name = "kjlkj"
        Me.kjlkj.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.kjlkj.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.kjlkj.PlaceholderText = ""
        Me.kjlkj.ReadOnly = True
        Me.kjlkj.SelectedText = ""
        Me.kjlkj.Size = New System.Drawing.Size(143, 60)
        Me.kjlkj.TabIndex = 48
        Me.kjlkj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.AutoRoundedCorners = True
        Me.Guna2TextBox2.BorderRadius = 29
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = "Valige soovitud kuupäeva:"
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 13.75!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(319, 124)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderForeColor = System.Drawing.Color.Empty
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.ReadOnly = True
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(257, 60)
        Me.Guna2TextBox2.TabIndex = 47
        Me.Guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BorderRadius = 52
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = "Eesti Statistika"
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(319, 6)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(525, 106)
        Me.Guna2TextBox1.TabIndex = 46
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Location = New System.Drawing.Point(319, 347)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(554, 265)
        Me.CartesianChart1.TabIndex = 33
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'clndrKuupaev
        '
        Me.clndrKuupaev.AutoRoundedCorners = True
        Me.clndrKuupaev.BorderRadius = 29
        Me.clndrKuupaev.Checked = True
        Me.clndrKuupaev.FillColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.clndrKuupaev.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.clndrKuupaev.ForeColor = System.Drawing.Color.DarkOrchid
        Me.clndrKuupaev.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.clndrKuupaev.Location = New System.Drawing.Point(584, 124)
        Me.clndrKuupaev.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.clndrKuupaev.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.clndrKuupaev.Name = "clndrKuupaev"
        Me.clndrKuupaev.Size = New System.Drawing.Size(245, 60)
        Me.clndrKuupaev.TabIndex = 30
        Me.clndrKuupaev.Value = New Date(2022, 4, 12, 0, 0, 0, 0)
        '
        'formEestiStatistika
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1173, 695)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formEestiStatistika"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents clndrKuupaev As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents kjlkj As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox7 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox6 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox5 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents lblDailyCases As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblNextDay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblPerPopulation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl14p As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblTotalCases As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPaevadeArv As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents btnLeiaEesti As Guna.UI2.WinForms.Guna2GradientCircleButton
End Class
