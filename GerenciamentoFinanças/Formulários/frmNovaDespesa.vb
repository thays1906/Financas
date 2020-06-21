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
    Public cValor As Decimal
    Public bParcelado As Boolean = False
    Public erro As Decimal
    Public logErro As String
    Public Property cControleParcelamento() As Decimal


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
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnDetalhe, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        btnDetalhe.Visible = False
        CarregarCombo()

        If cDespesa > 0 Then

            btnDetalhe.Visible = True
            rsDespesa = pDespesa.ObterDespesa(cDespesa)

            PreencheCampo()
        Else
            tabDespesa.TabPages(0).Text = "Adicionar Despesa"
            cbParcelamento.Enabled = False
            txtParcela.Visible = False
            lblParcela.Visible = False
            btnSalvar.SetBounds(210, 420, 203, 42)
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
                        S_MsgBox("Despesa adicionada com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.FileOK)
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

            If bParcelado = False Then
                dtRegistro = dtDespesa.Value
                cParcelamento = 0
                cNumeroParcela = 0
                cValor = CDec(txtValorTotal.Text)
            End If

            If pDespesa.InserirDespesa(txtDescricao.Text,
                                       cValor,
                                       CDec(cbConta.ObterChaveCombo()),
                                       CDec(cbCategoria.ObterChaveCombo()),
                                       CDec(cbPagamento.ObterChaveCombo()),
                                       dtRegistro,
                                       CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                       cParcelamento,
                                       cNumeroParcela,
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
                                       CDec(txtValorTotal.Text),
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
        If txtValorTotal.Text = Nothing Then
            Return False
        End If

        Return True
    End Function
    Private Sub PreencheCampo()
        Try
            tabDespesa.TabPages(0).Text = "Alterar Despesa"
            chkParcela.Visible = False
            cbParcelamento.Visible = False
            txtValorParcela.Visible = False
            lblValorParcela.Visible = False
            txtMesReferente.Visible = True
            lblMesReferente.Visible = True
            btnDetalhe.Enabled = False

            If CDec(rsDespesa("cControleParcelamento")) <> 0 Then

                txtParcela.Visible = True
                txtParcela.Enabled = False
                lblParcela.Visible = True
                txtValorParcela.Visible = True
                lblValorParcela.Visible = True
                btnDetalhe.Enabled = True

                cQtdeParcela = CDec(rsDespesa("cNumeroParcela"))
                cNumeroParcela = CDec(rsDespesa("cQtdeParcela"))
                cValor = CDec(rsDespesa("cValor"))

                txtParcela.Text = cQtdeParcela.ToString & "/" & cNumeroParcela.ToString

                txtValorParcela.Text = Convert.ToDouble(cValor).ToString("C")
            End If
            txtMesReferente.Text = CDate(rsDespesa("dtRegistro")).ToString("MMMM").ToUpper
            txtValorTotal.Text = Convert.ToDouble(cNumeroParcela * cValor).ToString("C")
            dtDespesa.Value = CDate(rsDespesa("dtRegistro").ToString)
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
        txtValorTotal.Text = ""
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
        Dim qtde As New Collection
        Dim col As New Collection

        Try
            rsDespesaConta = pContaBancaria.CarregarConta()
            cbConta.PreencheComboDS(rsDespesaConta, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

            rsDespesaCategoria = pCategoriaDespesa.CarregarCombo()
            cbCategoria.PreencheComboDS(rsDespesaCategoria, "rCategoria", "cCategoria", SuperComboBox.PrimeiroValor.Selecione)


            rsDespesaParcelamento = pParcelamento.CarregarCombo()

            cQtdeParcela = CDec(rsDespesaParcelamento("cQtdeParcela"))
            For i = 1 To cQtdeParcela - 1
                qtde.Add(New DuplaCombo(i, i + 1 & "x"))
            Next

            cbParcelamento.PreencheComboColl(qtde, SuperComboBox.PrimeiroValor.Selecione)

            rsDespesaPagamento = pFormaPagamento.CarregarCombo()

            cbPagamento.PreencheComboDS(rsDespesaPagamento,
                                        "rPagamento",
                                        "cFormaPagamento",
                                        SuperComboBox.PrimeiroValor.Selecione)


            col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
            col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
            col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

            cbStatus.PreencheComboColl(col, SuperComboBox.PrimeiroValor.Nada)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValorTotal.Leave
        If IsNumeric(txtValorTotal.Text) Then
            txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("C")
        End If
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub chkParcela_CheckedChanged(sender As Object, e As EventArgs) Handles chkParcela.CheckedChanged
        Try
            If chkParcela.Checked = True Then

                txtValorParcela.Visible = True
                lblValorParcela.Visible = True
                cbParcelamento.Enabled = True

                cbPagamento.PosicionaRegistroCombo(rsDespesaPagamento("cFormaPagamento", 1))

            ElseIf chkParcela.Checked = False Then
                txtValorParcela.Visible = False
                lblValorParcela.Visible = False
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

                If IsNumeric(txtValorTotal.Text) Then
                    If CDec(txtValorTotal.Text) > 0 Then
                        cValor = CDec(txtValorTotal.Text.Replace("R$", "")) / cQtdeParcela

                        txtValorParcela.Text = Convert.ToDouble(cValor).ToString("C")
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtValor_TextChanged(sender As Object, e As EventArgs) Handles txtValorTotal.TextChanged
        Try
            If chkParcela.Checked = True Then

                cQtdeParcela = CDec(cbParcelamento.ObterDescricaoCombo().Replace("x", ""))

                If IsNumeric(txtValorTotal.Text) Then
                    If CDec(txtValorTotal.Text) > 0 Then

                        cValor = CDec(txtValorTotal.Text.Replace("R$", "")) / cQtdeParcela

                        txtValorParcela.Text = cValor.ToString
                    End If
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtValorParcela_Leave(sender As Object, e As EventArgs) Handles txtValorParcela.Leave
        If IsNumeric(txtValorParcela.Text) Then
            txtValorParcela.Text = Convert.ToDouble(txtParcela.Text).ToString("C")
        End If
    End Sub

    Private Sub btnDetalhe_Click(sender As Object, e As EventArgs) Handles btnDetalhe.Click

        Try
            cControleParcelamento = CDec(rsDespesa("cControleParcelamento"))

            If cControleParcelamento <> 0 Then
                Me.cControleParcelamento.ToString()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class