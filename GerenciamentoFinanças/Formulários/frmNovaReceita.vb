Imports GFT.Util
Public Class frmNovaReceita
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            clsMsgBox.S_MsgBox("Receita lançada com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class