<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menuinicial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_menuinicial))
        Me.Button1 = New MetroFramework.Controls.MetroTile()
        Me.Button2 = New MetroFramework.Controls.MetroTile()
        Me.Button3 = New MetroFramework.Controls.MetroTile()
        Me.Label1 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.ActiveControl = Nothing
        Me.Button1.Location = New System.Drawing.Point(56, 115)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 118)
        Me.Button1.Style = MetroFramework.MetroColorStyle.Green
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cadastre-se!"
        Me.Button1.UseSelectable = True
        '
        'Button2
        '
        Me.Button2.ActiveControl = Nothing
        Me.Button2.Location = New System.Drawing.Point(56, 237)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(447, 118)
        Me.Button2.Style = MetroFramework.MetroColorStyle.Teal
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Entrar como Visitante"
        Me.Button2.UseSelectable = True
        '
        'Button3
        '
        Me.Button3.ActiveControl = Nothing
        Me.Button3.Location = New System.Drawing.Point(281, 115)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(221, 118)
        Me.Button3.Style = MetroFramework.MetroColorStyle.Blue
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Logar"
        Me.Button3.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(134, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(413, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bem vindo ao lava rápido X! Lave seu carro com mais rapidez ainda."
        '
        'frm_menuinicial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 413)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "frm_menuinicial"
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Yellow
        Me.Text = "Menu inicial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As MetroFramework.Controls.MetroTile
    Friend WithEvents Button2 As MetroFramework.Controls.MetroTile
    Friend WithEvents Button3 As MetroFramework.Controls.MetroTile
    Friend WithEvents Label1 As MetroFramework.Controls.MetroLabel
End Class
