Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmNovaDespesa
    Public cDespesa As Decimal
    Public oDataset As SuperDataSet
    Private Sub frmNovaDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.Preto)

    End Sub


    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim logErro As String
        Try
            If VerificaCampos() = True Then
                If cDespesa = 0 Then
                    logErro = Now & "Inclusão de Despesa."
                    pDespesa.InserirDespesa(txtDescricao.Text,
                                        txtValor.Text,
                                        cbCategoria.ObterChaveCombo(),
                                        cbCategoria.ObterChaveCombo(),
                                        cbPagamento.ObterChaveCombo(),
                                        dtDespesa.Value,
                                        Nothing,
                                        cbStatus.ObterChaveCombo(),
                                        logErro)
                    clsMsgBox.S_MsgBox("Receita adicionada com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)

                Else
                    logErro = Now & "Dados da Despesa alterado."

                    pDespesa.AlterarDespesa(cDespesa,
                                            txtDescricao.Text,
                                            txtValor.Text,
                                            cbConta.ObterChaveCombo(),
                                            cbCategoria.ObterChaveCombo(),
                                            cbPagamento.ObterChaveCombo(),
                                            dtDespesa.Value,
                                            Nothing,
                                            CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                            logErro)
                    clsMsgBox.S_MsgBox("Dados alterados com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)

                End If
                LimpaCampos()
                Me.Close()
                PesquisarDespesa()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function VerificaCampos() As Boolean

        If cbConta.VerificaObrigatorio() = False Then
            Return False
        End If
        If cbCategoria.VerificaObrigatorio() = False Then
            Return False
        End If
        If txtValor.Text = Nothing Then
            Return False
        End If

        Return True
    End Function
    Public Sub PreencheCampo(ByVal rs As SuperDataSet)
        Try
            dtDespesa.Value = rs("dtRegistro").ToString
            txtValor.Text = rs("cValor").ToString()
            cbConta.PosicionaRegistroCombo(rs("cConta"))
            cbCategoria.PosicionaRegistroCombo(rs("cTipo"))
            txtDescricao.Text = rs("rDescricao").ToString

            cDespesa = CDec(rs("cDespesa"))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LimpaCampos()
        dtDespesa.Value = Now.ToString
        txtDescricao.Text = ""
        txtValor.Text = ""
        cbConta.SelectedIndex = 0
        cbCategoria.SelectedIndex = 0
        cbPagamento.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        cbParcelamento.SelectedIndex = 0
    End Sub
    Public Sub PesquisarDespesa()
        Try
            oDataset = pDespesa.PesquisarDespesa()
            If oDataset.TotalRegistros > 0 Then
                frmDespesa.lvConsulta.PreencheGridDS(oDataset, True, True, False, True)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarCombo()
        Dim rsConta As SuperDataSet
        Dim rsCategoria As SuperDataSet
        Dim rsPagamento As SuperDataSet

        Try
            rsConta = pContaBancaria.CarregarConta()
            cbConta.PreencheComboDS(rsConta, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

            'rsCategoria = pContaBancaria.CarregarConta()
            cbCategoria.PreencheComboDS(rsCategoria, "rCategoria", "cCategoria", SuperComboBox.PrimeiroValor.Selecione)

            'rsPagamento = 
            cbPagamento.PreencheComboDS(rsPagamento, "rPagamento", "cFormaPagamento", SuperComboBox.PrimeiroValor.Selecione)


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        If IsNumeric(txtValor.Text) Then
            txtValor.Text = CDec(txtValor.Text).ToString("C")
        End If
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

End Class