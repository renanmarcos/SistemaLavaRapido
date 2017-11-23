<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recuperaradm
    Inherits MetroFramework.Forms.MetroForm

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recuperaradm))
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.txt_email = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(286, 192)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 50)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseSelectable = True
        '
        'txt_email
        '
        '
        '
        '
        Me.txt_email.CustomButton.Image = Nothing
        Me.txt_email.CustomButton.Location = New System.Drawing.Point(401, 1)
        Me.txt_email.CustomButton.Name = ""
        Me.txt_email.CustomButton.Size = New System.Drawing.Size(10, 10)
        Me.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_email.CustomButton.TabIndex = 1
        Me.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_email.CustomButton.UseSelectable = True
        Me.txt_email.CustomButton.Visible = False
        Me.txt_email.Lines = New String(-1) {}
        Me.txt_email.Location = New System.Drawing.Point(60, 132)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_email.MaxLength = 32767
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_email.SelectedText = ""
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.ShortcutsEnabled = True
        Me.txt_email.Size = New System.Drawing.Size(619, 20)
        Me.txt_email.TabIndex = 33
        Me.txt_email.UseSelectable = True
        Me.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Digite o E-mail"
        '
        'frm_recuperaradm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 312)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_recuperaradm"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "Recuperar senha de Administrador ou Funcionário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
End Class
