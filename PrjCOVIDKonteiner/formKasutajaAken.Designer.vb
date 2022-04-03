<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKasutajaAken
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
        Me.btnLeia = New System.Windows.Forms.Button()
        Me.lblArv = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLeia
        '
        Me.btnLeia.Location = New System.Drawing.Point(161, 168)
        Me.btnLeia.Name = "btnLeia"
        Me.btnLeia.Size = New System.Drawing.Size(103, 47)
        Me.btnLeia.TabIndex = 0
        Me.btnLeia.Text = "Leia"
        Me.btnLeia.UseVisualStyleBackColor = True
        '
        'lblArv
        '
        Me.lblArv.AutoSize = True
        Me.lblArv.Location = New System.Drawing.Point(363, 179)
        Me.lblArv.Name = "lblArv"
        Me.lblArv.Size = New System.Drawing.Size(44, 25)
        Me.lblArv.TabIndex = 1
        Me.lblArv.Text = "Arv"
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblArv)
        Me.Controls.Add(Me.btnLeia)
        Me.Name = "formKasutajaAken"
        Me.Text = "COVID andmed"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeia As Button
    Friend WithEvents lblArv As Label
End Class
