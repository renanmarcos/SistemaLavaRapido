Public Class frm_fila
    Private Sub frm_fila_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        rg = "111111111"
        Dim cont As Integer

        With dgv_fila
            .Rows.Clear()
            sql = "SELECT * FROM tb_fila WHERE rg='" & rg & "' ORDER BY dia, hora"
            rs = db.Execute(sql)
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields("rg").Value, rs.Fields("dia").Value, rs.Fields("hora").Value, rs.Fields("carro").Value, rs.Fields("placa").Value)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub
End Class