Public Class frm_relatoriomensal
    Private Sub frm_relatoriomensal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'maindbDataSet.tb_caixa'. Você pode movê-la ou removê-la conforme necessário.
        Me.tb_caixaTableAdapter.Fill(Me.maindbDataSet.tb_caixa)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TesteToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.tb_caixaTableAdapter.teste(Me.maindbDataSet.tb_caixa, New System.Nullable(Of Integer)(CType(MesToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub MesToolStripButton_Click(sender As Object, e As EventArgs) Handles MesToolStripButton.Click
        Try
            Me.tb_caixaTableAdapter.mes(Me.maindbDataSet.tb_caixa, New System.Nullable(Of Integer)(CType(MesToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class