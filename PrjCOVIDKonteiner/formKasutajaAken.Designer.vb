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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnLeia = New System.Windows.Forms.Button()
        Me.lblSeePaev = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTotalCases = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl14p = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPerPopulation = New System.Windows.Forms.Label()
        Me.txtKuupaev = New System.Windows.Forms.TextBox()
        Me.cbMaakond = New System.Windows.Forms.ComboBox()
        Me.lblNextDay = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chrtNakatunud = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblEelmine = New System.Windows.Forms.Label()
        CType(Me.chrtNakatunud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLeia
        '
        Me.btnLeia.Location = New System.Drawing.Point(79, 168)
        Me.btnLeia.Name = "btnLeia"
        Me.btnLeia.Size = New System.Drawing.Size(103, 47)
        Me.btnLeia.TabIndex = 0
        Me.btnLeia.Text = "Leia"
        Me.btnLeia.UseVisualStyleBackColor = True
        '
        'lblSeePaev
        '
        Me.lblSeePaev.AutoSize = True
        Me.lblSeePaev.Location = New System.Drawing.Point(432, 86)
        Me.lblSeePaev.Name = "lblSeePaev"
        Me.lblSeePaev.Size = New System.Drawing.Size(44, 25)
        Me.lblSeePaev.TabIndex = 1
        Me.lblSeePaev.Text = "Arv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(272, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Sellel paeval"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(272, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kokku"
        '
        'lblTotalCases
        '
        Me.lblTotalCases.AutoSize = True
        Me.lblTotalCases.Location = New System.Drawing.Point(432, 135)
        Me.lblTotalCases.Name = "lblTotalCases"
        Me.lblTotalCases.Size = New System.Drawing.Size(44, 25)
        Me.lblTotalCases.TabIndex = 4
        Me.lblTotalCases.Text = "Arv"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Viimase 14p jooksul"
        '
        'lbl14p
        '
        Me.lbl14p.AutoSize = True
        Me.lbl14p.Location = New System.Drawing.Point(528, 190)
        Me.lbl14p.Name = "lbl14p"
        Me.lbl14p.Size = New System.Drawing.Size(44, 25)
        Me.lbl14p.TabIndex = 6
        Me.lbl14p.Text = "Arv"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(296, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Per population"
        '
        'lblPerPopulation
        '
        Me.lblPerPopulation.AutoSize = True
        Me.lblPerPopulation.Location = New System.Drawing.Point(528, 241)
        Me.lblPerPopulation.Name = "lblPerPopulation"
        Me.lblPerPopulation.Size = New System.Drawing.Size(44, 25)
        Me.lblPerPopulation.TabIndex = 8
        Me.lblPerPopulation.Text = "Arv"
        '
        'txtKuupaev
        '
        Me.txtKuupaev.Location = New System.Drawing.Point(142, 79)
        Me.txtKuupaev.Name = "txtKuupaev"
        Me.txtKuupaev.Size = New System.Drawing.Size(100, 31)
        Me.txtKuupaev.TabIndex = 9
        '
        'cbMaakond
        '
        Me.cbMaakond.FormattingEnabled = True
        Me.cbMaakond.Items.AddRange(New Object() {"Eesti", "Harju maakond", "Hiiu maakond", "Ida-Viru maakond", "Järva maakond", "Jõgeva maakond", "Lääne maakond", "Lääne-Viru maakond", "Pärnu maakond", "Põlva maakond", "Rapla maakond", "Saare maakond", "Tartu maakond", "Valga maakond", "Viljandi maakond", "Võru maakond"})
        Me.cbMaakond.Location = New System.Drawing.Point(111, 241)
        Me.cbMaakond.Name = "cbMaakond"
        Me.cbMaakond.Size = New System.Drawing.Size(121, 33)
        Me.cbMaakond.TabIndex = 10
        '
        'lblNextDay
        '
        Me.lblNextDay.AutoSize = True
        Me.lblNextDay.Location = New System.Drawing.Point(519, 317)
        Me.lblNextDay.Name = "lblNextDay"
        Me.lblNextDay.Size = New System.Drawing.Size(44, 25)
        Me.lblNextDay.TabIndex = 11
        Me.lblNextDay.Text = "Arv"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(340, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Next Day:"
        '
        'chrtNakatunud
        '
        ChartArea2.Name = "ChartArea1"
        Me.chrtNakatunud.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chrtNakatunud.Legends.Add(Legend2)
        Me.chrtNakatunud.Location = New System.Drawing.Point(643, 24)
        Me.chrtNakatunud.Name = "chrtNakatunud"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Nakatunud"
        Me.chrtNakatunud.Series.Add(Series2)
        Me.chrtNakatunud.Size = New System.Drawing.Size(721, 502)
        Me.chrtNakatunud.TabIndex = 13
        Me.chrtNakatunud.Text = "Chart1"
        '
        'lblEelmine
        '
        Me.lblEelmine.AutoSize = True
        Me.lblEelmine.Location = New System.Drawing.Point(375, 434)
        Me.lblEelmine.Name = "lblEelmine"
        Me.lblEelmine.Size = New System.Drawing.Size(77, 25)
        Me.lblEelmine.TabIndex = 14
        Me.lblEelmine.Text = "Label6"
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1533, 658)
        Me.Controls.Add(Me.lblEelmine)
        Me.Controls.Add(Me.chrtNakatunud)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNextDay)
        Me.Controls.Add(Me.cbMaakond)
        Me.Controls.Add(Me.txtKuupaev)
        Me.Controls.Add(Me.lblPerPopulation)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl14p)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTotalCases)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSeePaev)
        Me.Controls.Add(Me.btnLeia)
        Me.Name = "formKasutajaAken"
        Me.Text = "COVID andmed"
        CType(Me.chrtNakatunud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeia As Button
    Friend WithEvents lblSeePaev As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalCases As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl14p As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPerPopulation As Label
    Friend WithEvents txtKuupaev As TextBox
    Friend WithEvents cbMaakond As ComboBox
    Friend WithEvents lblNextDay As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents chrtNakatunud As DataVisualization.Charting.Chart
    Friend WithEvents lblEelmine As Label
End Class
