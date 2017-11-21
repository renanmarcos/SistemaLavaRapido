<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_fornecadastro
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
        Me.GroupBox2 = New MetroFramework.Controls.MetroPanel()
        Me.Label2 = New MetroFramework.Controls.MetroLabel()
        Me.txt_repetir = New System.Windows.Forms.MaskedTextBox()
        Me.txt_usuario = New MetroFramework.Controls.MetroTextBox()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New MetroFramework.Controls.MetroLabel()
        Me.Button1 = New MetroFramework.Controls.MetroButton()
        Me.txt_email = New MetroFramework.Controls.MetroTextBox()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.Label4 = New MetroFramework.Controls.MetroLabel()
        Me.Label6 = New MetroFramework.Controls.MetroLabel()
        Me.dtp_dia = New MetroFramework.Controls.MetroDateTime()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtp_dia)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_repetir)
        Me.GroupBox2.Controls.Add(Me.txt_usuario)
        Me.GroupBox2.Controls.Add(Me.txt_senha)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.HorizontalScrollbarBarColor = True
        Me.GroupBox2.HorizontalScrollbarHighlightOnWheel = False
        Me.GroupBox2.HorizontalScrollbarSize = 10
        Me.GroupBox2.Location = New System.Drawing.Point(14, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 287)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.VerticalScrollbarBarColor = True
        Me.GroupBox2.VerticalScrollbarHighlightOnWheel = False
        Me.GroupBox2.VerticalScrollbarSize = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nome do Fornecedor"
        '
        'txt_repetir
        '
        Me.txt_repetir.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_repetir.Location = New System.Drawing.Point(253, 169)
        Me.txt_repetir.Name = "txt_repetir"
        Me.txt_repetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repetir.Size = New System.Drawing.Size(217, 32)
        Me.txt_repetir.TabIndex = 31
        '
        'txt_usuario
        '
        '
        '
        '
        Me.txt_usuario.CustomButton.Image = Nothing
        Me.txt_usuario.CustomButton.Location = New System.Drawing.Point(685, 2)
        Me.txt_usuario.CustomButton.Name = ""
        Me.txt_usuario.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_usuario.CustomButton.TabIndex = 1
        Me.txt_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_usuario.CustomButton.UseSelectable = True
        Me.txt_usuario.CustomButton.Visible = False
        Me.txt_usuario.Lines = New String(-1) {}
        Me.txt_usuario.Location = New System.Drawing.Point(24, 39)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.MaxLength = 32767
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_usuario.SelectedText = ""
        Me.txt_usuario.SelectionLength = 0
        Me.txt_usuario.SelectionStart = 0
        Me.txt_usuario.ShortcutsEnabled = True
        Me.txt_usuario.Size = New System.Drawing.Size(715, 32)
        Me.txt_usuario.TabIndex = 15
        Me.txt_usuario.UseSelectable = True
        Me.txt_usuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_usuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_senha.Location = New System.Drawing.Point(24, 169)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(217, 32)
        Me.txt_senha.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Nome do Produto"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(606, 224)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 50)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Criar"
        Me.Button1.UseSelectable = True
        '
        'txt_email
        '
        '
        '
        '
        Me.txt_email.CustomButton.Image = Nothing
        Me.txt_email.CustomButton.Location = New System.Drawing.Point(685, 2)
        Me.txt_email.CustomButton.Name = ""
        Me.txt_email.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txt_email.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt_email.CustomButton.TabIndex = 1
        Me.txt_email.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt_email.CustomButton.UseSelectable = True
        Me.txt_email.CustomButton.Visible = False
        Me.txt_email.Lines = New String(-1) {}
        Me.txt_email.Location = New System.Drawing.Point(24, 104)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.MaxLength = 32767
        Me.txt_email.Name = "txt_email"
        Me.txt_email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_email.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_email.SelectedText = ""
        Me.txt_email.SelectionLength = 0
        Me.txt_email.SelectionStart = 0
        Me.txt_email.ShortcutsEnabled = True
        Me.txt_email.Size = New System.Drawing.Size(715, 32)
        Me.txt_email.TabIndex = 17
        Me.txt_email.UseSelectable = True
        Me.txt_email.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt_email.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Quantidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(248, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Preço de cada"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(475, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Data de Compra"
        '
        'dtp_dia
        '
        Me.dtp_dia.Location = New System.Drawing.Point(481, 172)
        Me.dtp_dia.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtp_dia.Name = "dtp_dia"
        Me.dtp_dia.Size = New System.Drawing.Size(258, 29)
        Me.dtp_dia.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtp_dia.TabIndex = 32
        '
        'frm_fornecadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 361)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frm_fornecadastro"
        Me.Text = "Cadastro de Fornecedor"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txt_repetir As MaskedTextBox
    Friend WithEvents txt_usuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents Label3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Button1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txt_email As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Label6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtp_dia As MetroFramework.Controls.MetroDateTime
End Class
