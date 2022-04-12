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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CartesianChart1 = New LiveCharts.WinForms.CartesianChart()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clndrKuupaev = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblNextDay = New System.Windows.Forms.Label()
        Me.lblPerPopulation = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSeePaev = New System.Windows.Forms.Label()
        Me.lbl14p = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalCases = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel1.Controls.Add(Me.CartesianChart1)
        Me.Guna2Panel1.Controls.Add(Me.Label5)
        Me.Guna2Panel1.Controls.Add(Me.clndrKuupaev)
        Me.Guna2Panel1.Controls.Add(Me.lblNextDay)
        Me.Guna2Panel1.Controls.Add(Me.lblPerPopulation)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.lblSeePaev)
        Me.Guna2Panel1.Controls.Add(Me.lbl14p)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.lblTotalCases)
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1149, 671)
        Me.Guna2Panel1.TabIndex = 0
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
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(525, 106)
        Me.Guna2TextBox1.TabIndex = 46
        Me.Guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CartesianChart1
        '
        Me.CartesianChart1.Location = New System.Drawing.Point(360, 317)
        Me.CartesianChart1.Name = "CartesianChart1"
        Me.CartesianChart1.Size = New System.Drawing.Size(227, 170)
        Me.CartesianChart1.TabIndex = 33
        Me.CartesianChart1.Text = "CartesianChart1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(605, 355)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Next Day:"
        '
        'clndrKuupaev
        '
        Me.clndrKuupaev.AutoRoundedCorners = True
        Me.clndrKuupaev.BorderRadius = 23
        Me.clndrKuupaev.Checked = True
        Me.clndrKuupaev.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.clndrKuupaev.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(186, Byte))
        Me.clndrKuupaev.ForeColor = System.Drawing.Color.DarkOrchid
        Me.clndrKuupaev.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.clndrKuupaev.Location = New System.Drawing.Point(473, 166)
        Me.clndrKuupaev.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.clndrKuupaev.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.clndrKuupaev.Name = "clndrKuupaev"
        Me.clndrKuupaev.Size = New System.Drawing.Size(245, 48)
        Me.clndrKuupaev.TabIndex = 30
        Me.clndrKuupaev.Value = New Date(2022, 4, 12, 0, 0, 0, 0)
        '
        'lblNextDay
        '
        Me.lblNextDay.AutoSize = True
        Me.lblNextDay.Location = New System.Drawing.Point(695, 355)
        Me.lblNextDay.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNextDay.Name = "lblNextDay"
        Me.lblNextDay.Size = New System.Drawing.Size(23, 13)
        Me.lblNextDay.TabIndex = 28
        Me.lblNextDay.Text = "Arv"
        '
        'lblPerPopulation
        '
        Me.lblPerPopulation.AutoSize = True
        Me.lblPerPopulation.Location = New System.Drawing.Point(699, 315)
        Me.lblPerPopulation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPerPopulation.Name = "lblPerPopulation"
        Me.lblPerPopulation.Size = New System.Drawing.Size(23, 13)
        Me.lblPerPopulation.TabIndex = 27
        Me.lblPerPopulation.Text = "Arv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(571, 235)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Sellel paeval"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(583, 315)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Per population"
        '
        'lblSeePaev
        '
        Me.lblSeePaev.AutoSize = True
        Me.lblSeePaev.Location = New System.Drawing.Point(651, 235)
        Me.lblSeePaev.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSeePaev.Name = "lblSeePaev"
        Me.lblSeePaev.Size = New System.Drawing.Size(23, 13)
        Me.lblSeePaev.TabIndex = 20
        Me.lblSeePaev.Text = "Arv"
        '
        'lbl14p
        '
        Me.lbl14p.AutoSize = True
        Me.lbl14p.Location = New System.Drawing.Point(699, 289)
        Me.lbl14p.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl14p.Name = "lbl14p"
        Me.lbl14p.Size = New System.Drawing.Size(23, 13)
        Me.lbl14p.TabIndex = 25
        Me.lbl14p.Text = "Arv"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(571, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Kokku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(583, 288)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Viimase 14p jooksul"
        '
        'lblTotalCases
        '
        Me.lblTotalCases.AutoSize = True
        Me.lblTotalCases.Location = New System.Drawing.Point(651, 260)
        Me.lblTotalCases.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalCases.Name = "lblTotalCases"
        Me.lblTotalCases.Size = New System.Drawing.Size(23, 13)
        Me.lblTotalCases.TabIndex = 23
        Me.lblTotalCases.Text = "Arv"
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
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CartesianChart1 As LiveCharts.WinForms.CartesianChart
    Friend WithEvents Label5 As Label
    Friend WithEvents clndrKuupaev As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblNextDay As Label
    Friend WithEvents lblPerPopulation As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblSeePaev As Label
    Friend WithEvents lbl14p As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalCases As Label
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
End Class
