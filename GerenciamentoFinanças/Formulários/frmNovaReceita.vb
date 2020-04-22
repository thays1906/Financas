Imports GFT.Util
Public Class frmNovaReceita
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim logErro As String
        Try
            If VerificaCampos() = True Then

                logErro = Now.ToString & "- Inclusão de receita"

                pReceita.InserirReceita(dtReceita.Value,
                                        txtDescricao.Text, txtValor.Text,
                                        cbConta.ObterChaveCombo,
                                        cbTipoReceita.ObterChaveCombo,
                                        logErro)

                clsMsgBox.S_MsgBox("Receita lançada com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)
            Else
                clsMsgBox.S_MsgBox("Falha o salvar receita.", clsMsgBox.eBotoes.Ok,,, clsMsgBox.eImagens.Cancel)
            End If
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
    Private Function VerificaCampos() As Boolean

        If cbConta.VerificaObrigatorio() = False Then
            Return False
        End If
        If cbTipoReceita.VerificaObrigatorio() = False Then
            Return False
        End If
        If txtValor.Text = Nothing Then
            Return False
        End If

        Return True

    End Function

    Private Sub frmNovaReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarCombos()

    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave

        If IsNumeric(txtValor.Text) Then
            txtValor.Text = CDec(txtValor.Text).ToString("C")
        End If
    End Sub

End Class