<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_recuperar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_recuperar))
        Me.txt_usuario = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.txt_resposta = New MetroFramework.Controls.MetroTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.cmb_perguntas = New MetroFramework.Controls.MetroComboBox()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.LinkLabel1 = New MetroFramework.Controls.MetroLink()
        Me.SuspendLayout()
        '
        'txt_usuario
        '
        '
        '
        '
        Me.txt_usuario.CustomButton.Image = Nothing
        Me.txt_usuario.CustomButton.Location = New System.Drawing.Point(1347, 2)
        Me.txt_usuario.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_usuario.CustomButton.Name = ""
        Me.txt_usuario.CustomButton.Size = New System.Drawing.Size(44, 45)
        Me.txt_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_usuario.CustomButton.TabIndex = 1
        Me.txt_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_usuario.CustomButton.UseSelectable = True
        Me.txt_usuario.CustomButton.Visible = False
        Me.txt_usuario.Lines = New String(-1) {}
        Me.txt_usuario.Location = New System.Drawing.Point(38, 134)
        Me.txt_usuario.MaxLength = 32767
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.SelectionLength = 0
        Me.txt_usuario.SelectionStart = 0
        Me.txt_usuario.ShortcutsEnabled = True
        Me.txt_usuario.Size = New System.Drawing.Size(928, 31)
        Me.txt_usuario.TabIndex = 17
        Me.txt_usuario.UseSelectable = True
        Me.txt_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_usuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Digite o usuário ou E-mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Pergunta secreta"
        '
        'txt_resposta
        '
        '
        '
        '
        Me.txt_resposta.CustomButton.Image = Nothing
        Me.txt_resposta.CustomButton.Location = New System.Drawing.Point(1347, 2)
        Me.txt_resposta.CustomButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txt_resposta.CustomButton.Name = ""
        Me.txt_resposta.CustomButton.Size = New System.Drawing.Size(44, 45)
        Me.txt_resposta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_resposta.CustomButton.TabIndex = 1
        Me.txt_resposta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_resposta.CustomButton.UseSelectable = True
        Me.txt_resposta.CustomButton.Visible = False
        Me.txt_resposta.Lines = New String(-1) {}
        Me.txt_resposta.Location = New System.Drawing.Point(38, 338)
        Me.txt_resposta.MaxLength = 32767
        Me.txt_resposta.Name = "txt_resposta"
        Me.txt_resposta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_resposta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_resposta.SelectedText = ""
        Me.txt_resposta.SelectionLength = 0
        Me.txt_resposta.SelectionStart = 0
        Me.txt_resposta.ShortcutsEnabled = True
        Me.txt_resposta.Size = New System.Drawing.Size(928, 31)
        Me.txt_resposta.TabIndex = 21
        Me.txt_resposta.UseSelectable = True
        Me.txt_resposta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_resposta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Resposta secreta"
        '
        'cmb_perguntas
        '
        Me.cmb_perguntas.FormattingEnabled = True
        Me.cmb_perguntas.ItemHeight = 23
        Me.cmb_perguntas.Location = New System.Drawing.Point(38, 237)
        Me.cmb_perguntas.Name = "cmb_perguntas"
        Me.cmb_perguntas.Size = New System.Drawing.Size(926, 29)
        Me.cmb_perguntas.TabIndex = 25
        Me.cmb_perguntas.UseSelectable = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 77)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseSelectable = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(33, 395)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(650, 35)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.Text = "Clique aqui se você for Administrador/Funcionário tentando recuperar senha"
        Me.LinkLabel1.UseSelectable = True
        '
        'frm_recuperar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 535)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmb_perguntas)
        Me.Controls.Add(Me.txt_resposta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1076, 554)
        Me.Name = "frm_recuperar"
        Me.Padding = New System.Windows.Forms.Padding(30, 92, 30, 31)
        Me.Text = "Recuperar senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_usuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_resposta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cmb_perguntas As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents LinkLabel1 As MetroFramework.Controls.MetroLink
End Class
