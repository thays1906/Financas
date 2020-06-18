Imports GFT.Util
Imports GFT.Util.SuperComboBox

Public Class frmNovaReceita
    Public cod As Decimal
    Private Sub frmNovaReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaCombo()
        Cor(Me, Collor.CinzaEscuro)
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
    End Sub



    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim logErro As String
        Try
            If VerificaCampos() = True Then

                If cod = 0 Then

                    logErro = Now.ToString & "- Inclusão de receita"

                    pReceita.InserirReceita(dtReceita.Value,
                                            txtDescricao.Text,
                                            CDec(txtValor.Text),
                                            CDec(cbConta.ObterChaveCombo),
                                            CDec(cbTipoReceita.ObterChaveCombo),
                                            logErro)

                    clsMsgBox.S_MsgBox("Receita adicionada com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)

                Else

                    logErro = Now.ToString & "Dados da Receita alterada."

                    pReceita.AlterarReceita(cod,
                                            txtDescricao.Text,
                                            CDec(txtValor.Text),
                                            CDec(cbConta.ObterChaveCombo()),
                                            CDec(cbTipoReceita.ObterChaveCombo()),
                                            logErro)
                    clsMsgBox.S_MsgBox("Dados alterado com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)

                End If
                LimpaCampos()
                frmReceita.Pesquisar()
                Me.Close()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregaCombo()
        Dim conta As SuperDataSet
        Dim tipoReceita As SuperDataSet
        Try
            conta = pContaBancaria.CarregarConta()
            cbConta.PreencheComboDS(conta, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

            tipoReceita = pTipoReceita.CarregarCombo()
            cbTipoReceita.PreencheComboDS(tipoReceita, "rTipo", "cTipoReceita", SuperComboBox.PrimeiroValor.Selecione)

            Dim col As New Collection
            col.Add(New DuplaCombo(eTipoConta.Corrente, "Corrente"))
            col.Add(New DuplaCombo(eTipoConta.Poupanca, "Poupança"))

            cbTipoConta.PreencheComboColl(col, PrimeiroValor.Nada)

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

    Public Sub PreencheCampo(ByVal rs As SuperDataSet)
        Try
            dtReceita.Value = CDate(rs("dtRec").ToString)
            txtValor.Text = rs("cValor").ToString()
            cbConta.PosicionaRegistroCombo(rs("cConta"))
            cbTipoReceita.PosicionaRegistroCombo(rs("cTipo"))
            txtDescricao.Text = rs("rDescricao").ToString

            cod = CDec(rs("cReceita"))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LimpaCampos()
        dtReceita.Value = Now
        txtDescricao.Text = ""
        txtValor.Text = ""
        cbConta.SelectedIndex = 0
        cbTipoReceita.SelectedIndex = 0
    End Sub
    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave

        If IsNumeric(txtValor.Text) Then
            txtValor.Text = CDec(txtValor.Text).ToString("C")
        End If
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class