<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFazerLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bem vindo(a)."
        '
        'btnFazerLogin
        '
        Me.btnFazerLogin.BackColor = System.Drawing.SystemColors.Control
        Me.btnFazerLogin.ForeColor = System.Drawing.Color.Transparent
        Me.btnFazerLogin.Image = Global.WindowsAppLoginDB.My.Resources.Resources.login_icon_3060
        Me.btnFazerLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnFazerLogin.Location = New System.Drawing.Point(234, 3)
        Me.btnFazerLogin.Name = "btnFazerLogin"
        Me.btnFazerLogin.Size = New System.Drawing.Size(270, 280)
        Me.btnFazerLogin.TabIndex = 3
        Me.btnFazerLogin.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 262)
        Me.Controls.Add(Me.btnFazerLogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Minha Aplicação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnFazerLogin As Button
End Class
