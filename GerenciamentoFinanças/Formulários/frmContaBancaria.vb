Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmContaBancaria
    Public agencia As Decimal
    Public conta As Decimal
    Public saldo As Decimal

    Private Sub frmContaBancaria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tbConsulta)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnAddConta_Click(sender As Object, e As EventArgs) Handles btnAddConta.Click

        Try

            If DadosConta() = True Then
                pContaBancaria.InserirConta(txtBanco.Text, agencia, conta, saldo)
                S_MsgBox("Conta cadastrada com sucesso.", eBotoes.Ok, "",, eImagens.Ok)
            End If



        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Function DadosConta() As Boolean

        If IsNumeric(txtAgencia.Text) Then
            agencia = CDec(txtAgencia.Text)
        Else
            clsMsgBox.S_MsgBox("Verifique se o campo 'Agência' está correto.'", eBotoes.Ok,,, eImagens.Atencao)
            Return False
        End If
        If IsNumeric(txtConta.Text) Then
            conta = CDec(txtConta.Text)
        Else
            clsMsgBox.S_MsgBox("Verifique se o campo 'Conta' está correto.'", eBotoes.Ok,,, eImagens.Atencao)
            Return False

        End If
        If IsNumeric(txtSaldo.Text) Then
            saldo = CDec(txtSaldo.Text)
        Else
            clsMsgBox.S_MsgBox("Verifique se o campo 'Conta' está correto.'", eBotoes.Ok,,, eImagens.Atencao)
            Return False
        End If
        Return True
    End Function

    Private Sub txtSaldo_Leave(sender As Object, e As EventArgs) Handles txtSaldo.Leave
        If IsNumeric(txtSaldo.Text) Then
            txtSaldo.Text = CDec(txtSaldo.Text).ToString("C")
        End If
    End Sub
End Class