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
    Public rsDespesaFixa As SuperDataSet
    Public dtRegistro As Date
    Public cParcelamento As Decimal
    Public cQtdeParcela As Decimal
    Public cNumeroParcela As Decimal
    Public cValor As Decimal
    Public bParcelado As Boolean = False
    Public bDespesaFixa As Boolean = False
    Public cDespesaFixa As Decimal
    Public cPeriodo As Decimal
    Public erro As Boolean = False
    Public cErro As Decimal
    Public logErro As String
    Public oForm As frmDespesaFixa
    Public choose As String
    Public data As Date
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

        Cor(Me, Collor.CinzaEscuro)
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnDetalhe, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CarregarCombo()

        If cDespesa > 0 Then

            rsDespesa = pDespesa.ObterDespesa(cDespesa)
            PreencheCampo()
            pnlNovaDespesa.Height = 350
        Else
            tabDespesa.TabPages(0).Text = "Adicionar Despesa"
            cbParcelamento.Enabled = False
            cbDespesaFixa.Enabled = False
            txtParcela.Visible = False
            lblParcela.Visible = False
            btnDetalhe.Visible = False
            pnlNovaDespesa.Height = 366
            btnSalvar.Location = New Point(200, 564)
            btnExcluir.Location = New Point(480, 564)

        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If VerificaCampos() = True Then

                If cDespesa = 0 Then
                    'Nova despesa

                    logErro = Now & " - Inclusão de Despesa."

                    If chkParcela.Checked = True Then

                        'Então é parcelamento
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

                                    cErro = IncluirDespesa()
                                Next
                            Else
                                cErro = +1
                            End If
                        Else
                            cErro = +1
                        End If

                        If cErro = 0 Then
                            S_MsgBox("Despesa adicionada com sucesso", eBotoes.Ok,, eImagens.FileOK)
                        Else
                            S_MsgBox("Não foi possível incluir registro", eBotoes.Ok,, eImagens.Cancel)
                        End If

                    Else

                        If chkDespesaFixa.Checked Then

                            'É Despesa Fixa
                            bDespesaFixa = True

                            If IsNumeric(txtValorTotal.Text) Then
                                cValor = CDec(txtValorTotal.Text)
                            End If

                            dtRegistro = dtDespesa.Value

                        End If
                        cErro = IncluirDespesa()
                    End If

                    If cErro = 0 Then
                        S_MsgBox("Despesa adicionada com sucesso", eBotoes.Ok,, eImagens.FileOK)
                    Else
                        S_MsgBox("Não foi possível adicionar despesa.", eBotoes.Ok,, eImagens.Cancel)
                    End If

                Else
                    '---------------------------------
                    'Então é alteração
                    '---------------------------------
                    'Verificando se é Despesa Fixa ...

                    'No momento: Despesa normal Ñ vira Despesa Fixa nem Parcelada.  
                    'Despesa Fixa não permite alteração da Frequencia que se repete Ex:(diario/mensal/anual)
                    'Despesa Fixa não pode virar Normal.
                    'Alterações em DF: Data (somente dia para despesas Mensais/Bi/Tri/Anual),Valor,Descrição e etc.
                    dtRegistro = dtDespesa.Value
                    cValor = CDec(txtValorTotal.Text)

                    If chkDespesaFixa.Checked Then

                        If cbDespesaFixa.SelectedIndex <> 0 Then

                            If cDespesaFixa <> 0 Then

                                logErro = Now & " - " & "Despesa Fixa modificada. "

                                oForm = New frmDespesaFixa("UPDF") 'UPDF = Update Despesa Fixa
                                oForm.ShowDialog()
                                choose = oForm.retorno

                                If choose <> Nothing Then
                                    erro = AlterarDespesa(choose)
                                End If
                            End If
                        End If

                    ElseIf cControleParcelamento <> 0 Then

                        logErro = Now & " - " & "Despesa Parcelada modificada. "

                        oForm = New frmDespesaFixa("UPDP") 'UPDP = Update Despesa Parcelada
                        oForm.Show()
                        choose = oForm.retorno

                        cValor = CDec(txtValorParcela.Text)

                        If choose <> Nothing Then
                            erro = AlterarDespesa(choose)
                        End If
                    Else
                        erro = AlterarDespesa(choose)
                    End If


                    If erro = True Then
                        S_MsgBox("Dados alterados com sucesso", eBotoes.Ok,, eImagens.FileOK)
                    Else
                        S_MsgBox("Não foi possível salvar as alterações.", eBotoes.Ok,, eImagens.Cancel)
                    End If
                End If
                LimpaCampos()
                Me.Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function IncluirDespesa() As Decimal
        Try

            'Se é Despesa Fixa, insert registro na tDespesa_Fixa e depois...
            If bDespesaFixa = True Then


                'Inserindo registro (modelo) na tabela Despesa Fixa
                cDespesaFixa = pDespesaFixa.Inserir(CType(cbDespesaFixa.ObterChaveCombo(), eDespesaFixa),
                                                    txtDescricao.Text,
                                                    cValor,
                                                    CDec(cbCategoria.ObterChaveCombo()),
                                                    CDec(cbPagamento.ObterChaveCombo()),
                                                    CDec(cbConta.ObterChaveCombo()),
                                                    dtRegistro)

                'Se inseriu bonitinho, gera lançamentos futuros do registro (modelo) na tDespesa
                If cDespesaFixa <> 0 Then
                    pDespesaFixa.InserirLancamentoFuturo(cDespesaFixa)
                    cErro = 0
                Else
                    cErro += 1
                End If
            Else
                'Se não é parcelamento, zera as variaveis de parça e pega data e valor da tela.
                If bParcelado = False Then
                    cParcelamento = 0
                    cNumeroParcela = 0
                    dtRegistro = dtDespesa.Value
                    cValor = CDec(txtValorTotal.Text.Replace("R$", ""))
                End If

                cDespesaFixa = 0

                If pDespesa.InserirDespesa(txtDescricao.Text,
                                           cValor,
                                           CDec(cbConta.ObterChaveCombo()),
                                           CDec(cbCategoria.ObterChaveCombo()),
                                           CDec(cbPagamento.ObterChaveCombo()),
                                           dtRegistro,
                                           CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                           cParcelamento,
                                           cNumeroParcela,
                                           cDespesaFixa,
                                           logErro) = True Then
                    cErro = 0
                Else
                    cErro += 1
                End If
            End If

            Return cErro

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return cErro
        End Try
    End Function
    Public Function AlterarDespesa(Optional ByVal escolha As String = "") As Boolean
        Try
            If escolha <> "" Then

                If escolha = "1*" Then

                    If cDespesaFixa <> 0 Then


                        pDespesa.AlterarDespesaFixa(cDespesaFixa, 1,
                                                    txtDescricao.Text, cValor,
                                                    CDec(cbConta.ObterChaveCombo),
                                                    CDec(cbCategoria.ObterChaveCombo),
                                                    CDec(cbPagamento.ObterChaveCombo),
                                                    dtRegistro,
                                                    CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                                    logErro, data)


                    ElseIf cControleParcelamento <> 0 Then

                        'pDespesa.AlterarDespesa()


                    End If

                ElseIf escolha = "*" Then
                    If cDespesaFixa <> 0 Then

                        pDespesa.AlterarDespesaFixa(cDespesaFixa, 0,
                                                   txtDescricao.Text, cValor,
                                                   CDec(cbConta.ObterChaveCombo),
                                                   CDec(cbCategoria.ObterChaveCombo),
                                                   CDec(cbPagamento.ObterChaveCombo),
                                                   dtRegistro,
                                                   CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                                   logErro, data)


                    ElseIf cControleParcelamento <> 0 Then

                        'pDespesa.AlterarDespesa()

                    End If
                Else
                    If pDespesa.AlterarDespesa(cDespesa,
                           txtDescricao.Text,
                           CDec(txtValorTotal.Text),
                           CDec(cbConta.ObterChaveCombo()),
                           CDec(cbCategoria.ObterChaveCombo()),
                           CDec(cbPagamento.ObterChaveCombo()),
                           dtDespesa.Value,
                           CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                           logErro) Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Else
                logErro = Now & " - " & "Dados da Despesa alterado. "

                If pDespesa.AlterarDespesa(cDespesa,
                                           txtDescricao.Text,
                                           CDec(txtValorTotal.Text),
                                           CDec(cbConta.ObterChaveCombo()),
                                           CDec(cbCategoria.ObterChaveCombo()),
                                           CDec(cbPagamento.ObterChaveCombo()),
                                           dtDespesa.Value,
                                           CType(cbStatus.ObterChaveCombo(), eStatusDespesa),
                                           logErro) Then
                    Return True
                Else
                    Return False
                End If
            End If


            'SE FOR DESPESA FIXA :
            '- ALTERAÇÃO DE 1 REGISTRO: pDespesa.AlterarDespesa
            '-ALTERAÇÃO DESTE EM DIANTE: pDespesa.AlterarDespesaFixa
            '-ALTERAÇÃO TODOS: pDespesa.AlterarDespesaFixa

            'SE FOR DESPESA FIXA OU PARCELADA:
            '--EXIBIR POPUP DE PERGUNTA: SOMENTE ESTE / TODOS / ESTE E PROXIMOS

            Return True

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Private Function VerificaCampos() As Boolean

        If cbConta.VerificaObrigatorio() = False Then
            S_MsgBox("Você não selecionou à conta báncaria.",
                     eBotoes.Ok,
                     "Lançamento de Despesa",,
                     eImagens.Atencao)
            cbConta.Focus()

            Return False
        End If
        If cbStatus.SelectedIndex = 0 Then
            S_MsgBox("Nenhum status está selecionado para sua despesa." & vbNewLine &
                     "Você pode selecionar 'Pendente','Pago',ou 'Atrasado' se preferir.'",
                     eBotoes.Ok,
                     "Lançamento de Despesa",,
                     eImagens.Atencao)
            cbStatus.Focus()

            Return False
        End If
        If txtValorTotal.Text = Nothing Then
            S_MsgBox("Você não informou o valor da sua despesa.",
                     eBotoes.Ok,
                     "Lançamento de Despesa",,
                     eImagens.Atencao)
            txtValorTotal.Focus()

            Return False

        End If

        If chkDespesaFixa.Checked Then

            If cbDespesaFixa.SelectedIndex = 0 Then
                S_MsgBox("Você definiu que essa Despesa, é uma 'Despesa Fixa'. " & vbNewLine &
                     "Por favor,informe a frequência que essa despesa se repete.",
                     eBotoes.Ok, "Lançamento de Despesa",, eImagens.Atencao)
                Return False
            End If

        ElseIf chkParcela.Checked Then

            If cbParcelamento.SelectedIndex = 0 Then
                S_MsgBox("Você marcou essa Despesa como 'Despesa Parcelada'. " & vbNewLine &
                    "Por favor, informe a quantidade de parcelas que essa despesa possui.",
                    eBotoes.Ok, "Lançamento de Despesa",, eImagens.Atencao)
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub PreencheCampo()
        Try

            tabDespesa.TabPages(0).Text = "Alterar Despesa"
            chkParcela.Visible = False
            chkDespesaFixa.Visible = False
            cbParcelamento.Visible = False
            cbParcelamento.Enabled = False
            cbDespesaFixa.Visible = False
            txtParcela.Enabled = False
            txtValorParcela.Visible = False
            lblValorParcela.Visible = False
            txtMesReferente.Visible = True
            lblMesReferente.Visible = True
            btnDetalhe.Enabled = False
            'btnSalvar.Location = New Point(178, 564)
            'btnExcluir.Location = New Point(437, 564)
            cValor = CDec(rsDespesa("cValor"))

            If CDec(rsDespesa("cControleParcelamento")) <> 0 Then

                cControleParcelamento = CDec(rsDespesa("cControleParcelamento"))


                lblValor.SetBounds(8, 35, 102, 18)
                txtValorTotal.SetBounds(8, 61, 151, 27)

                txtParcela.Visible = True
                txtParcela.Enabled = False
                txtParcela.SetBounds(319, 61, 76, 27)
                lblParcela.Visible = True
                lblParcela.SetBounds(316, 35, 74, 18)

                txtValorParcela.Visible = True
                txtValorParcela.SetBounds(161, 61, 151, 27)
                lblValorParcela.Visible = True
                lblValorParcela.SetBounds(161, 35, 147, 18)

                btnDetalhe.Enabled = True

                cQtdeParcela = CDec(rsDespesa("cNumeroParcela"))
                cNumeroParcela = CDec(rsDespesa("cQtdeParcela"))

                txtParcela.Text = cQtdeParcela.ToString & "/" & cNumeroParcela.ToString

                txtValorParcela.Text = Convert.ToDouble(cValor).ToString("C")

                txtValorTotal.Text = Convert.ToDouble(cNumeroParcela * cValor).ToString("C")

                lblFormaPagamento.Location = New Point(415, 35)
                cbPagamento.Location = New Point(415, 62)
            ElseIf CDec(rsDespesa("cDespesaFixa")) <> 0 Then

                cDespesaFixa = CDec(rsDespesa("cDespesaFixa"))
                data = CDate(rsDespesa("dtRegistro"))
                rsDespesaFixa = pDespesaFixa.Obter(cDespesaFixa)

                chkDespesaFixa.Visible = True
                chkDespesaFixa.Checked = True
                chkDespesaFixa.Enabled = False
                chkDespesaFixa.Location = New Point(10, 35)

                cbDespesaFixa.Visible = True
                cbDespesaFixa.Enabled = False
                cbDespesaFixa.Location = New Point(10, 62)
                cbDespesaFixa.PosicionaRegistroCombo(CType(rsDespesaFixa("cPeriodo"), eDespesaFixa))

                lblValor.Location = New Point(212, 35)
                txtValorTotal.Location = New Point(215, 62)

                lblFormaPagamento.Location = New Point(415, 35)
                cbPagamento.Location = New Point(415, 62)


                txtValorTotal.Text = Convert.ToDouble(cValor).ToString("C2")


            Else

                txtValorTotal.Text = Convert.ToDouble(cValor).ToString("C2")
                lblValor.Location = New Point(10, 27)
                txtValorTotal.Location = New Point(10, 52)
            End If

            gbDespesa2.Height = 100
            gbDespesa1.Location = New Point(0, gbDespesa2.Location.Y - gbDespesa1.Height)

            txtMesReferente.Text = CDate(rsDespesa("dtRegistro")).ToString("MMMM").ToUpper
            dtDespesa.Value = CDate(rsDespesa("dtRegistro").ToString)
            cbConta.PosicionaRegistroCombo(rsDespesa("cConta"))
            cbCategoria.PosicionaRegistroCombo(rsDespesa("cCategoria"))
            txtDescricao.Text = rsDespesa("rDescricao").ToString
            cbPagamento.PosicionaRegistroCombo(rsDespesa("cPagamento"))
            cbStatus.PosicionaRegistroCombo(CType(rsDespesa("cStatus"), eStatusDespesa))
            picNewDespesa.Image = Banco(cbConta.ObterDescricaoCombo())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub LimpaCampos()
        cDespesa = 0
        chkParcela.Checked = False
        chkDespesaFixa.Checked = False
        dtDespesa.Value = Now
        txtDescricao.Text = ""
        txtValorTotal.Text = ""
        cbConta.SelectedIndex = 0
        cbCategoria.SelectedIndex = 0
        cbPagamento.SelectedIndex = 0
        cbStatus.SelectedIndex = 0
        cbParcelamento.SelectedIndex = 0
        cbDespesaFixa.SelectedIndex = 0

    End Sub
    Private Sub CarregarCombo()
        Dim qtde As New Collection
        Dim col As New Collection

        Try
            rsDespesaConta = pContaBancaria.CarregarConta()

            cbConta.PreencheComboDS(rsDespesaConta, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

            For i = 0 To rsDespesaConta.TotalRegistros - 1

                If CDec(rsDespesaConta("cPrincipal", i)) = 1 Then
                    cbConta.PosicionaRegistroCombo(rsDespesaConta("cPrincipal"))
                End If
            Next

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

            cbStatus.PreencheComboColl(col, SuperComboBox.PrimeiroValor.Selecione)

            col.Clear()

            col.Add(New DuplaCombo(eDespesaFixa.Diario, "Diariamente"))
            col.Add(New DuplaCombo(eDespesaFixa.Semanal, "Semanal"))
            col.Add(New DuplaCombo(eDespesaFixa.Quinzenal, "Quinzenal"))
            col.Add(New DuplaCombo(eDespesaFixa.Mensal, "Mensal"))
            col.Add(New DuplaCombo(eDespesaFixa.Bimestral, "Bimestral"))
            col.Add(New DuplaCombo(eDespesaFixa.Trimestral, "Trimestral"))
            col.Add(New DuplaCombo(eDespesaFixa.Semestral, "Semestral"))
            col.Add(New DuplaCombo(eDespesaFixa.Anual, "Anual"))

            cbDespesaFixa.PreencheComboColl(col, PrimeiroValor.Selecione)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs)
        Try
            txtValorTotal.Text = txtValorTotal.Text.Replace("R$", "").Trim.ToString
            If IsNumeric(txtValorTotal.Text) Then

                txtValorTotal.Text = Convert.ToDouble(txtValorTotal.Text).ToString("C")

                If chkParcela.Checked = True Then

                    If cbParcelamento.SelectedIndex <> 0 Then

                        cQtdeParcela = CDec(cbParcelamento.ObterDescricaoCombo().Replace("x", ""))

                        If CDec(txtValorTotal.Text) > 0 Then

                            cValor = CDec(txtValorTotal.Text.Replace("R$", "")) / CDec(cQtdeParcela)

                            txtValorParcela.Text = Convert.ToDouble(cValor).ToString("C2")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro inesperado",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        cControleParcelamento = 0
        LimpaCampos()
        Me.Close()
    End Sub

    Private Sub chkParcela_CheckedChanged(sender As Object, e As EventArgs) Handles chkParcela.CheckedChanged
        Try
            If chkParcela.Checked = True Then

                chkDespesaFixa.Checked = False
                cbDespesaFixa.Enabled = False
                txtValorParcela.Visible = True
                lblValorParcela.Visible = True
                cbParcelamento.Enabled = True

                cbPagamento.PosicionaRegistroCombo(rsDespesaPagamento("cFormaPagamento", 1))

            ElseIf chkParcela.Checked = False Then
                cbParcelamento.SelectedIndex = 0
                txtValorParcela.Visible = False
                lblValorParcela.Visible = False

                cbPagamento.PosicionaRegistroCombo(rsDespesaPagamento("cFormaPagamento", 0))
                cbParcelamento.Enabled = False
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro inesperado",, eImagens.Cancel)
        End Try
    End Sub


    '==================================
    'ARRUMAR TXT VALOR E PARCELA
    '==================================
    Private Sub btnDetalhe_Click(sender As Object, e As EventArgs) Handles btnDetalhe.Click

        Try
            cControleParcelamento = CDec(rsDespesa("cControleParcelamento"))

            If cControleParcelamento <> 0 Then
                Me.cControleParcelamento.ToString()
                LimpaCampos()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chkDespesaFixa_CheckedChanged(sender As Object, e As EventArgs) Handles chkDespesaFixa.CheckedChanged
        If chkDespesaFixa.Checked Then
            chkParcela.Checked = False
            cbDespesaFixa.Enabled = True
        Else
            cbDespesaFixa.SelectedIndex = 0
            cbDespesaFixa.Enabled = False
        End If
    End Sub

    Private Sub txtValorTotal_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Back Then
            txtValorParcela.Text = ""
        End If
    End Sub

    Private Sub txtValorTotal_KeyUp(sender As Object, e As KeyEventArgs)
        Try
            If chkParcela.Checked Then
                If cbParcelamento.SelectedIndex <> 0 Then

                    cQtdeParcela = CDec(cbParcelamento.ObterDescricaoCombo().Replace("x", ""))

                    If IsNumeric(txtValorTotal.Text) Then

                        If CDec(txtValorTotal.Text) > 0 Then
                            cValor = CDec(txtValorTotal.Text.Replace("R$", "")) / cQtdeParcela

                            txtValorParcela.Text = Convert.ToDouble(cValor).ToString("C2")

                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro inesperado",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub cbParcelamento_SelectedIndexChanged(sender As Object, e As EventArgs)
        Try
            If chkParcela.Checked Then

                If cbParcelamento.SelectedIndex <> 0 Then

                    cQtdeParcela = CDec(cbParcelamento.ObterDescricaoCombo().Replace("x", ""))

                    If IsNumeric(txtValorTotal.Text) Then

                        If CDec(txtValorTotal.Text) > 0 Then

                            cValor = Truncate(CDec(txtValorTotal.Text.Replace("R$", "")) / CDec(cQtdeParcela), 2)

                            txtValorParcela.Text = Convert.ToDouble(cValor).ToString("C2")
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Function Truncate(ByVal _valor As Decimal, ByVal _intDigits As Integer) As Decimal
        Dim mult As Double
        Dim result As Double
        Try
            mult = Math.Pow(10.0, _intDigits)

            result = Math.Truncate(mult * _valor) / mult

            Return CDec(result)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click

        Try
            oForm = New frmDespesaFixa("Del")

            If CDec(rsDespesa("cDespesaFixa")) <> 0 Then

                cDespesaFixa = CDec(rsDespesa("cDespesaFixa"))
                dtRegistro = CDate(rsDespesa("dtRegistro"))

                Me.Enabled = False

                oForm.ShowDialog()
                Me.Enabled = True

                choose = oForm.retorno

                If choose <> Nothing Then
                    If choose = "1" Then

                        If S_MsgBox("Deseja realmente excluir este registro?",
                                    eBotoes.SimNao,
                                    "Atenção",,
                                    eImagens.Interrogacao) = eRet.Sim Then

                            If pDespesa.DeletarDespesa(cDespesa) Then

                                S_MsgBox("Despesa excluída com sucesso!",
                                         eBotoes.Ok,
                                         "Sucesso",,
                                         eImagens.Ok)
                            Else
                                S_MsgBox("Falha ao excluir registros.",
                                         eBotoes.Ok,
                                         "Houve um erro",,
                                         eImagens.Cancel)
                            End If
                        End If

                    ElseIf choose = "1*" Then

                        If S_MsgBox("Deseja realmente excluir este e os próximos registros?",
                                    eBotoes.SimNao,
                                    "Atenção",,
                                    eImagens.Interrogacao) = eRet.Sim Then

                            If pDespesa.DeletarDespesaFixa(cDespesaFixa, 1, dtRegistro) Then

                                S_MsgBox("Registros excluídos com sucesso!",
                                         eBotoes.Ok,
                                         "Sucesso",,
                                         eImagens.Ok)
                            Else
                                S_MsgBox("Falha ao excluir registros.",
                                         eBotoes.Ok,
                                         "Houve um erro",,
                                         eImagens.Cancel)
                            End If
                        End If

                    Else
                        If S_MsgBox("Deseja realmente excluir todos registros?",
                                    eBotoes.SimNao,
                                    "Atenção",,
                                    eImagens.Interrogacao) = eRet.Sim Then

                            If pDespesa.DeletarDespesaFixa(cDespesaFixa, 0, dtRegistro) Then

                                S_MsgBox("Todos registros excluídos com sucesso!",
                                         eBotoes.Ok,
                                         "Sucesso",,
                                         eImagens.Ok)
                            Else
                                S_MsgBox("Falha ao excluir registros.",
                                         eBotoes.Ok,
                                         "Houve um erro",,
                                         eImagens.Cancel)
                            End If
                        End If
                    End If
                    Me.Close()
                End If

            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub cbConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConta.SelectedIndexChanged
        Try
            picNewDespesa.Image = Banco(cbConta.ObterDescricaoCombo())

            If cbConta.SelectedIndex = 0 Then
                picNewDespesa.Image = Nothing
                picNewDespesa.Refresh()

                'ElseIf picNewDespesa.Image.Width = 71 Then
                '    picNewDespesa.Location = New Point(341, 154)
                'Else
                '    picNewDespesa.Location = New Point(361, 154)
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
            LogaErro(ex.Message & "Evento: cbConta_SelectedIndexChanged - Form: NovaDespesa")
        End Try
    End Sub

    Private Sub cbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.SelectedIndex <> 0 Then
            If cbStatus.SelectedIndex = 1 Then

                picStatus.Image = My.Resources.iconPendente

            ElseIf cbStatus.SelectedIndex = 2 Then

                picStatus.Image = My.Resources.iconPago

            Else
                picStatus.Image = My.Resources.iconStatusAtrasado_Alerta_

            End If
        Else
            picStatus.Image = Nothing
            picStatus.Refresh()
        End If
    End Sub

End Class