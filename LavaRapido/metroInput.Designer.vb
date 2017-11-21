<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class metroInput
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
        Me.btn_ok = New MetroFramework.Controls.MetroButton()
        Me.txt_input = New MetroFramework.Controls.MetroTextBox()
        Me.btn_cancelar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(255, 54)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 23)
        Me.btn_ok.TabIndex = 0
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseSelectable = True
        '
        'txt_input
        '
        '
        '
        '
        Me.txt_input.CustomButton.Image = Nothing
        Me.txt_input.CustomButton.Location = New System.Drawing.Point(204, 1)
        Me.txt_input.CustomButton.Name = ""
        Me.txt_input.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txt_input.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_input.CustomButton.TabIndex = 1
        Me.txt_input.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_input.CustomButton.UseSelectable = True
        Me.txt_input.CustomButton.Visible = False
        Me.txt_input.Lines = New String(-1) {}
        Me.txt_input.Location = New System.Drawing.Point(23, 54)
        Me.txt_input.MaxLength = 32767
        Me.txt_input.Name = "txt_input"
        Me.txt_input.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_input.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_input.SelectedText = ""
        Me.txt_input.SelectionLength = 0
        Me.txt_input.SelectionStart = 0
        Me.txt_input.ShortcutsEnabled = True
        Me.txt_input.Size = New System.Drawing.Size(226, 23)
        Me.txt_input.TabIndex = 2
        Me.txt_input.UseSelectable = True
        Me.txt_input.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_input.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(255, 83)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(199, 19)
        Me.MetroLabel1.TabIndex = 5
        Me.MetroLabel1.Text = "Digite o código de confirmação:"
        '
        'metroInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 124)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_input)
        Me.DisplayHeader = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "metroInput"
        Me.Padding = New System.Windows.Forms.Padding(20, 30, 20, 20)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Orange
        Me.Text = "metroIput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_ok As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_input As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btn_cancelar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
End Class
