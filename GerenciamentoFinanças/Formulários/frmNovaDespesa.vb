Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox

Public Class frmNovaDespesa
    Public cDespesa As Decimal
    Public rsDespesa As SuperDataSet
    Public rsDespesaCategoria As SuperDataSet
    Public rsDespesaPagamento As SuperDataSet
    Public rsDespesaParcelamento As SuperDataSet
    Public rsDespesaConta As SuperDataSet
    Public dtRegistro As Date
    Public cParcelamento As Decimal
    Public cQtdeParcela As Decimal
    Public cNumeroParcela As Decimal
    Public cValorParcela As Decimal
    Public bParcelado As Boolean = False
    Public erro As Decimal
    Public logErro As String


    Sub New(ByVal _cDespesa As Decimal)
        Try
            InitializeComponent()

            cDespesa = _cDespesa

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub frmNovaDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.Preto)

        CarregarCombo()

        If cDespesa > 0 Then

            rsDespesa = pDespesa.ObterDespesa(cDespesa)

            PreencheCampo()
        Else
            cbParcelamento.Enabled = False
            txtParcela.Visible = False
            lblParcela.Visible = False
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If VerificaCampos() = True Then

                If cDespesa = 0 Then
                    'Nova despesa
                    logErro = Now & " - Inclusão de Despesa."

                    If chkParcela.Checked = True Then

                        bParcelado = True

                        cQtdeParcela = CDec(cbParcelamento.ObterDescricaoCombo().
                                    Replace("x", ""))

                        If IsNumeric(cQtdeParcela) And cQtdeParcela > 0 Then

                            cParcelamento = pControleParcelamento.Inserir(cQtdeParcela)

                            If cParcelamento > 0 Then

                                For i = 0 To cQtdeParcela - 1

                                    cNumeroParcela = i + 1

                                    dtRegistro = CDate(dtDespesa.Value)

                                    If i > 0 Then
                                        dtRegistro = dtRegistro.AddMonths(CInt(i))
                                    End If

                                    erro = IncluirDespesa(bParcelado)

                                Next
                            Else
                                erro = +1
                            End If
                        Else
                            erro = +1
                        End If
                    Else
                        erro = IncluirDespesa(bParcelado)
                    End If

                    If erro = 0 Then
                        S_MsgBox("Despesa adicionada com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)
                    Else
                        S_MsgBox("Erro ao lançar despesa.", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Cancel)
                    End If

                Else
                    'Então é alteração

                    erro = AlterarDespesa()

                    If erro = 0 Then
                        clsMsgBox.S_MsgBox("Dados alterados com sucesso",
                                           clsMsgBox.eBotoes.Ok,,
                                           clsMsgBox.eImagens.Ok)
                    Else
                        S_MsgBox("Erro ao alterar despesa.",
                                 clsMsgBox.eBotoes.Ok,,
                                 clsMsgBox.eImagens.Cancel)
                    End If
                End If
            End If

            LimpaCampos()
            Me.Close()
            'PesquisarDespesa()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function IncluirDespesa(ByVal bParcelado As Boolean) As Decimal
        Try
            'Se nao for parcelamento, pegar date da tela

            If bParcelado = True Then
                cValorParcela = CDec(txtValorParcela.Text)

            Else
                dtRegistro = dtDespesa.Value
                cValorParcela = 0
                cParcelamento = 0
                cNumeroParcela = 0
            End If

            If pDespesa.InserirDespesa(txtDescricao.Text,
                                       cValorParcela,
                                       CDec(cbConta.ObterChaveCombo()),
                                       CDec(cbCategoria.ObterChaveCombo()),
                                       CDec(cbPagamento.ObterChaveCombo()),
                                       dtRegistro,
                                       CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                       cParcelamento,
                                       cNumeroParcela,
                                       cValorParcela,
                                       logErro) = True Then
                Return 0
            Else
                erro = +1
                Return erro
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return erro
        End Try
    End Function
    Public Function AlterarDespesa() As Decimal
        Try

            logErro = Now & "Dados da Despesa alterado."

            If pDespesa.AlterarDespesa(cDespesa,
                                       txtDescricao.Text,
                                       CDec(txtValor.Text),
                                       CDec(cbConta.ObterChaveCombo()),
                                       CDec(cbCategoria.ObterChaveCombo()),
                                       CDec(cbPagamento.ObterChaveCombo()),
                                       dtDespesa.Value,
                                       CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                       logErro) = True Then
                Return 0
            Else
                erro = +1
                Return erro
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return erro
        End Try
    End Function
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
    Private Sub PreencheCampo()
        Try
            chkParcela.Visible = False
            cbParcelamento.Visible = False
            txtValorParcela.Visible = False
            lblValorParcela.Visible = False

            If CDec(rsDespesa("cControleParcelamento")) <> 0 Then
                txtParcela.Visible = True
                txtParcela.Enabled = False
                lblParcela.Visible = True
                txtValorParcela.Visible = True
                lblValorParcela.Visible = True

                txtParcela.Text = rsDespesa("cNumeroParcela").ToString &
                                 "/" & rsDespesa("cQtdeParcela").ToString

                txtValorParcela.Text = rsDespesa("cValorParcela").ToString


            End If

            dtDespesa.Value = CDate(rsDespesa("dtRegistro").ToString)
            txtValor.Text = rsDespesa("cValor").ToString()
            cbConta.PosicionaRegistroCombo(rsDespesa("cConta"))
            cbCategoria.PosicionaRegistroCombo(rsDespesa("cCategoria"))
            txtDescricao.Text = rsDespesa("rDescricao").ToString
            cbPagamento.PosicionaRegistroCombo(rsDespesa("cPagamento"))
            cbStatus.PosicionaRegistroCombo(CType(rsDespesa("cStatus"), eStatusDespesa))

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LimpaCampos()
        dtDespesa.Value = Now
        txtDescricao.Text = ""
        txtValor.Text = ""
        cbConta.SelectedIndex = 0
        cbCategoria.SelectedIndex = 0
        cbPagamento.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        'cbParcelamento.SelectedIndex = 0
    End Sub
    'Public Sub PesquisarDespesa()
    '    Try
    '        rsDespesa = pDespesa.PesquisarDespesa(CType(cbStatus.ObterChaveCombo, eStatusDespesa), CDec(cb)
    '        If rsDespesa.TotalRegistros > 0 Then
    '            frmDespesa.lvConsulta.PreencheGridDS(rsDespesa, True, True, False, True)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub
    Private Sub CarregarCombo()
        Dim qtdeParcela As Decimal

        Try
            rsDespesaConta = pContaBancaria.CarregarConta()
            cbConta.PreencheComboDS(rsDespesaConta, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

            rsDespesaCategoria = pCategoriaDespesa.CarregarCombo()
            cbCategoria.PreencheComboDS(rsDespesaCategoria, "rCategoria", "cCategoria", SuperComboBox.PrimeiroValor.Selecione)


            rsDespesaParcelamento = pParcelamento.CarregarCombo()

            qtdeParcela = CDec(rsDespesaParcelamento("cQtdeParcela"))
            Dim qtde As New Collection
            For i = 1 To qtdeParcela - 1

                qtde.Add(New DuplaCombo(i, i + 1 & "x"))

            Next

            cbParcelamento.PreencheComboColl(qtde, SuperComboBox.PrimeiroValor.Selecione)

            rsDespesaPagamento = pFormaPagamento.CarregarCombo()
            cbPagamento.PreencheComboDS(rsDespesaPagamento, "rPagamento", "cFormaPagamento", SuperComboBox.PrimeiroValor.Selecione)

            Dim col As New Collection

            col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
            col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
            col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

            cbStatus.PreencheComboColl(col, SuperComboBox.PrimeiroValor.Nada)




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

    Private Sub chkParcela_CheckedChanged(sender As Object, e As EventArgs) Handles chkParcela.CheckedChanged
        Try
            If chkParcela.Checked = True Then

                cbParcelamento.Enabled = True

                cbPagamento.PosicionaRegistroCombo(rsDespesaPagamento("cFormaPagamento", 1))

            ElseIf chkParcela.Checked = False Then

                cbParcelamento.Enabled = False

                cbPagamento.PosicionaRegistroCombo(rsDespesaPagamento("cFormaPagamento", 0))

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cbParcelamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbParcelamento.SelectedIndexChanged
        Try
            If chkParcela.Checked = True Then

                cQtdeParcela = CDec(cbParcelamento.ObterDescricaoCombo().Replace("x", ""))

                If IsNumeric(txtValor.Text) Then
                    If CDec(txtValor.Text) > 0 Then
                        cValorParcela = CDec(txtValor.Text.Replace("R$", "")) / cQtdeParcela

                        txtValorParcela.Text = cValorParcela.ToString
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValor.TextChanged
        Try
            If chkParcela.Checked = True Then

                cQtdeParcela = CDec(cbParcelamento.ObterDescricaoCombo().Replace("x", ""))

                If IsNumeric(txtValor.Text) Then
                    If CDec(txtValor.Text) > 0 Then

                        cValorParcela = CDec(txtValor.Text.Replace("R$", "")) / cQtdeParcela

                        txtValorParcela.Text = cValorParcela.ToString
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class