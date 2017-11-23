Public Class frm_relatoriototal
    Private Sub frm_relatoriototal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'maindbDataSet.tb_caixa'. Você pode movê-la ou removê-la conforme necessário.
        Me.tb_caixaTableAdapter.Fill(Me.maindbDataSet.tb_caixa)

        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub frm_relatoriototal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ultimoForm.Show()
    End Sub
End Class