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
    Private Sub CarregarCombos()
        Dim conta As SuperDataSet
        Dim tipoReceita As SuperDataSet
        Try
            conta = pContaBancaria.CarregarConta()

            cbConta.PreencheComboDS(conta, "rBanco", "cConta")

            tipoReceita = pTipoReceita.ObterTipoReceita()
            cbTipoReceita.PreencheComboDS(tipoReceita, "rTipo", "cTipoReceita")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub frmNovaReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarCombos()
    End Sub
End Class