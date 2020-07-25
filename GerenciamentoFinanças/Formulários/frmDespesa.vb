Imports GFT.Util
Imports GFT.Util.SuperComboBox
Imports GFT.Util.clsMsgBox
Imports System.Data.Common

Public Class frmDespesa
    Public oDataset As SuperDataSet
    Public Despesa As frmNovaDespesa
    Public gbParcela As GroupBox
    Public cDespesa As Decimal
    Public btn As Decimal
    Public erro As Integer
    Public ok As Integer
    Public tot As Integer
    Public cControleParcelamento As Decimal
    Sub New(Optional ByVal _cControle As Decimal = 0)

        InitializeComponent()
        cControleParcelamento = _cControle
    End Sub
    Private Sub frmDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.tabCtrlDespesa.TabPages(2).Enabled = False

        Cor(Me, Collor.Branco)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnAddDespesa, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnStatusPago, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CorTab(tabCtrlDespesa, Collor.CinzaAzulado)

        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tabCtrlDespesa)
        centralizarGrupoBotoes(gbDetalhe)
        centralizarGrupoBotoes(gbDadosDetalhe)

        CarregarCombo()
        Pesquisar()
        ControleFormulario()
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click

        If tabCtrlDespesa.SelectedIndex = 0 Then
            Me.Close()

        ElseIf tabCtrlDespesa.SelectedIndex = 1 Then
            tabCtrlDespesa.SelectTab(0)

        Else
            tabCtrlDespesa.SelectTab(0)
            tabCtrlDespesa.TabPages(2).Enabled = False
        End If
    End Sub

    Private Sub frmDespesa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmDespesa_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Despesa)
    End Sub

    Private Sub btnAddDespesa_Click(sender As Object, e As EventArgs) Handles btnAddDespesa.Click
        Try
            cDespesa = 0
            btn = eAcao.Novo
            ControleFormulario()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            btn = eAcao.Editar
            ControleFormulario()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            btn = eAcao.Excluir
            ControleFormulario()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub Pesquisar()
        Dim ano As Decimal
        Try

            If tabCtrlDespesa.SelectedIndex = 1 Then

                oDataset = pDespesaFixa.Pesquisar

                lvlConsultaFixa.Clear()

                If oDataset.TotalRegistros > 0 Then
                    lvlConsultaFixa.PreencheGridDS(oDataset, True, True, False, True, 0, True)
                    txtLetreiroFixa.TextoLetreiro = oDataset.InfoPesquisa.ToString
                End If
            Else
                If CDec(cbAno.ObterChaveCombo) <> 0 Then
                    ano = CDec(cbAno.ObterDescricaoCombo)
                Else
                    ano = 0
                End If
                oDataset = pDespesa.PesquisarDespesa(CType(cbStatusFiltro.ObterChaveCombo(), eStatusDespesa),
                                                 CDec(cbMes.ObterChaveCombo()),
                                                 ano)
                If oDataset.TotalRegistros > 0 Then

                    txtLetreiroDespesa.TextoLetreiro = oDataset.InfoPesquisa.ToString

                    Dim x As String = oDataset("total", 0, 1).ToString

                    txtTotalDespesa.Text = x

                    If CDec(x) <> 0 Then
                        txtTotalDespesa.Text = Convert.ToDouble(txtTotalDespesa.Text).ToString("C")
                    End If


                    dgDespesa.DataSource = oDataset.Tables(0)

                    lvConsulta.PreencheGridDS(oDataset, True, True, False, True, 0, True)

                    CorList(lvConsulta)
                    For i = 0 To oDataset.TotalRegistros - 1

                        If CStr(oDataset("as_Status#100", i)) = "PAGO" Then
                            lvConsulta.Items(i).SubItems(1).ForeColor = Color.Green
                        ElseIf CStr(oDataset("as_Status#100", i)) = "ATRASADO" Then
                            lvConsulta.Items(i).SubItems(1).ForeColor = Color.Red
                        End If

                        lvConsulta.Items(i).SubItems(3).ForeColor = Color.Red
                    Next
                Else
                    lvConsulta.PreencheGridDS(oDataset, True, True, False, True)

                    S_MsgBox("Nenhum registro encontrado.",
                         eBotoes.Ok,
                         "Consulta de Dados", 1,
                         eImagens.Atencao)
                End If

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub


    Private Sub CarregarCombo()
        Dim col As Collection
        Dim data As DateTime
        Dim rs As SuperDataSet
        Try
            col = New Collection
            col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
            col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
            col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

            cbStatusFiltro.PreencheComboColl(col, PrimeiroValor.Todos)

            col.Clear()

            For i = 1 To 12
                col.Add(New DuplaCombo(i, data.AddMonths(i - 1).ToString("MMMM").ToUpperInvariant))
            Next

            cbMes.PreencheComboColl(col, PrimeiroValor.Todos)
            cbMesFixa.PreencheComboColl(col, PrimeiroValor.Todos)

            col.Clear()

            data = Now.AddYears(-3)
            For i = 0 To 6
                col.Add(New DuplaCombo(i, data.AddYears(i).ToString("yyyy")))
            Next

            cbAno.PreencheComboColl(col, PrimeiroValor.Todos)
            cbAno.PosicionaRegistroCombo(3)

            col.Clear()

            col.Add(New DuplaCombo(eDespesaFixa.Diario, "Diariamente"))
            col.Add(New DuplaCombo(eDespesaFixa.Semanal, "Semanal"))
            col.Add(New DuplaCombo(eDespesaFixa.Quinzenal, "Quinzenal"))
            col.Add(New DuplaCombo(eDespesaFixa.Mensal, "Mensal"))
            col.Add(New DuplaCombo(eDespesaFixa.Bimestral, "Bimestral"))
            col.Add(New DuplaCombo(eDespesaFixa.Trimestral, "Trimestral"))
            col.Add(New DuplaCombo(eDespesaFixa.Semestral, "Semestral"))
            col.Add(New DuplaCombo(eDespesaFixa.Anual, "Anual"))

            cbPeriodo.PreencheComboColl(col, PrimeiroValor.Selecione)

            col.Clear()

            rs = pCategoriaDespesa.CarregarCombo
            If rs.TotalRegistros > 0 Then
                cbCategoriaFixa.PreencheComboDS(rs, "rCategoria", "cCategoria", PrimeiroValor.Selecione)
            End If



        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnStatusPago_Click(sender As Object, e As EventArgs) Handles btnStatusPago.Click
        Dim erro As Decimal
        Dim ok As Decimal
        Dim tot As Decimal
        Dim rDecimal As String
        Dim codigo As Decimal
        Dim chk As CheckBox
        Dim lista As List(Of GroupBox)

        Try
            If tabCtrlDespesa.SelectedIndex = 2 Then
                lista = New List(Of GroupBox)
                For Each item As Control In pnlDetalhe.Controls
                    lista.Add(CType(item, GroupBox))
                Next

                If lista.Count > 0 Then

                    chk = New CheckBox

                    For Each item As GroupBox In lista

                        For i = 0 To item.Controls.Count - 1

                            If item.Controls.Item(i).GetType.Name.Contains("CheckBox") Then

                                chk = CType(item.Controls(i), CheckBox)

                                If chk.CheckState = CheckState.Checked Then

                                    codigo = CDec(chk.Name)
                                    tot += 1
                                    If codigo <> 0 Then
                                        If pDespesa.Pagar(codigo) Then
                                            ok += 1
                                        Else
                                            erro += 1
                                        End If
                                    End If
                                End If
                            End If
                        Next
                    Next
                End If

                If erro = 0 Then
                    If ok <> 0 Then
                        S_MsgBox("Status atualizado com sucesso!" & vbNewLine & "Registros atualizados: " & ok,
                                 eBotoes.Ok, "Pagamento de Despesa",, eImagens.Ok)
                        DetalharParcelamento()
                    End If
                Else
                    S_MsgBox("Registros atualizados: " & ok &
                         vbNewLine & "Registros não atualizados: " & erro & vbNewLine &
                         "Total de Registros Selecionados: " & tot, eBotoes.Ok,
                         "Atenção: Alguns registros podem não ter sido alterados.",,
                         eImagens.Atencao)
                End If
            Else
                If lvConsulta.SelectedItems.Count > 0 Then

                    If S_MsgBox("Deseja atualizar o status do(s) Registro(s) selecionado(s)?",
                            eBotoes.SimNao,
                            "Pagamento das Despesas",,
                            eImagens.Interrogacao) = eRet.Sim Then

                        If lvConsulta.ObterTotalChecados > 0 Then

                            rDecimal = lvConsulta.ObterCSVChaves

                            For Each dec In rDecimal.Split(CChar(";"))
                                If pDespesa.Pagar(CDec(dec)) Then
                                    ok += 1
                                Else
                                    erro += 1
                                End If
                            Next

                            tot = lvConsulta.ObterTotalChecados

                            If erro = 0 Then
                                S_MsgBox("Status atualizado com sucesso!", eBotoes.Ok, "Pagamento de Despesa",, eImagens.Ok)
                            Else
                                S_MsgBox("Registros atualizados: " & ok &
                                     vbNewLine & "Registros não atualizados: " & erro & vbNewLine &
                                     "Total de Registros Selecionados: " & tot, eBotoes.Ok,
                                     "Atenção: Alguns registros podem não ter sido alterados.",,
                                     eImagens.Atencao)
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub ControleFormulario()
        Dim rDespesa As String
        Try
            btnStatusPago.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False

            If tabCtrlDespesa.SelectedIndex = 1 Then
                btnFechar.Text = " &Voltar"
                btnPesquisar.Enabled = True
                If lvlConsultaFixa.CheckedItems.Count = 1 Then
                    btnEditar.Enabled = True
                    btnExcluir.Enabled = True

                ElseIf lvConsulta.CheckedItems.Count > 1 Then
                    btnExcluir.Enabled = True
                End If


            ElseIf tabCtrlDespesa.SelectedIndex = 2 Then
                btnFechar.Text = " &Voltar"
                btnPesquisar.Enabled = False
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
                btnStatusPago.Enabled = True

            Else
                tabCtrlDespesa.TabPages(2).Enabled = False
                btnFechar.Text = " &Fechar"
                btnPesquisar.Enabled = True

                If lvConsulta.CheckedItems.Count = 1 Then
                    btnStatusPago.Enabled = True
                    btnEditar.Enabled = True
                    btnExcluir.Enabled = True

                ElseIf lvConsulta.CheckedItems.Count > 1 Then
                    btnStatusPago.Enabled = True
                    btnExcluir.Enabled = True
                End If
            End If

            If btn = eAcao.Editar Then

                btn = 0

                If tabCtrlDespesa.SelectedIndex = 0 Then

                    If lvConsulta.CheckedItems.Count = 1 Then
                        cDespesa = lvConsulta.ObterChave()
                    End If

                ElseIf tabCtrlDespesa.SelectedIndex = 1 Then

                    If lvlConsultaFixa.CheckedItems.Count = 1 Then
                        cDespesa = lvlConsultaFixa.ObterChave()
                    End If

                End If

                If cDespesa <> 0 Then

                    Despesa = New frmNovaDespesa(cDespesa)
                    Despesa.ShowDialog()
                    cDespesa = 0
                    cControleParcelamento = CDec(Despesa.cControleParcelamento)

                    If cControleParcelamento <> 0 Then
                        DetalharParcelamento()
                    Else
                        Pesquisar()
                    End If
                Else
                    S_MsgBox("Erro ao carregar registro.", eBotoes.Ok,,, eImagens.Cancel)
                End If

            End If

            If btn = eAcao.Excluir Then

                If lvConsulta.CheckedItems.Count > 1 Then

                    tot = lvConsulta.ObterTotalChecados

                    If Mensagem(eTipoMensagem.Question, tot) = eRet.Sim Then

                        rDespesa = lvConsulta.ObterCSVChaves()

                        For Each cod In rDespesa.Split(CChar(";"))

                            If CDec(cod) <> 0 Then
                                If pDespesa.DeletarDespesa(CDec(cod)) Then
                                    ok += 1
                                Else
                                    erro += 1
                                End If
                            End If
                        Next

                        If erro = 0 Then
                            Mensagem(eTipoMensagem.OK,, ok)
                            Pesquisar()
                        Else
                            Mensagem(eTipoMensagem.Erro, tot, ok, erro)
                        End If
                    End If
                Else
                    If Mensagem(eTipoMensagem.Question) = eRet.Sim Then
                        cDespesa = lvConsulta.ObterChave
                        If cDespesa <> 0 Then
                            If pDespesa.DeletarDespesa(cDespesa) Then
                                Mensagem(eTipoMensagem.OK)
                                Pesquisar()
                            Else
                                Mensagem(eTipoMensagem.Erro)
                            End If
                        End If
                    End If
                End If
                btn = 0
            End If


            If btn = eAcao.Novo Then
                btn = 0
                Despesa = New frmNovaDespesa(cDespesa)
                Despesa.ShowDialog()
                If Not tabCtrlDespesa.SelectedIndex = 0 Then
                    Pesquisar()
                    tabCtrlDespesa.SelectedIndex = 0
                    Exit Sub
                Else
                    Pesquisar()
                    Exit Sub
                End If
                'btn = 0
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub lvConsulta_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvConsulta.ItemChecked
        ControleFormulario()
    End Sub
    Private Sub DetalharParcelamento()
        Dim rs As SuperDataSet
        Dim txt As TextBox
        Dim chk As CheckBox
        Dim btn As Button
        Dim data As Label
        Dim parcela As Label
        Dim Qtde As Integer
        Dim cStatus As Integer
        Dim cNumParcela As Integer
        Dim yy As Integer
        Dim X As Integer
        Dim xGb As Integer
        Dim Y As Integer
        Dim cTotal As Decimal
        Dim cPago As Decimal
        Dim cNpago As Decimal
        Dim iGb As Integer = 0
        Dim distancia As Integer = 300
        Dim xInicialGb As Integer
        Try
            pnlDetalhe.Controls.Clear()
            tabCtrlDespesa.TabPages(2).Enabled = True
            tabCtrlDespesa.SelectedIndex = 2

            'Status = 1 Pago Status = 2 Pendente - 3 Atrasado

            If cControleParcelamento <> 0 Then

                rs = pControleParcelamento.ObterTodas(cControleParcelamento)

                If rs.TotalRegistros > 0 Then

                    Decimal.TryParse(rs("TOTAL", 0, 1).ToString, cTotal)
                    Decimal.TryParse(rs("PAGO", 0, 1).ToString, cPago)
                    Decimal.TryParse(rs("NPAGO", 0, 1).ToString, cNpago)

                    Qtde = CInt(rs("cQtdeParcela"))

                    txtDescriaoDetalhe.Text = rs("rDescricao").ToString
                    txtTotalDespesaDetalhe.Text = Convert.ToDouble(cTotal).ToString("C")
                    txtPago.Text = Convert.ToDouble(cPago).ToString("C")
                    txtNaoPago.Text = Convert.ToDouble(cNpago).ToString("C")

                    'CRIAR UM IF PARA VER QUANTOS TEXT VAI GERAR DE ACORDOR COMAS PARCELAS

                    gbParcela = New GroupBox

                    For i = 0 To Qtde - 1

                        cStatus = CInt(rs("cStatus", i))
                        cNumParcela = CInt(rs("cNumeroParcela", i))

                        'CRIAÇÃO DOS CONTROLES DAS PARCELAS
                        chk = New CheckBox
                        btn = New Button
                        txt = New TextBox
                        data = New Label
                        parcela = New Label

                        CorButton(btn, Collor.Nenhuma, Color.Transparent,
                                  Color.Transparent, Color.Transparent)



                        'SETANDO OS ICONS DAS PARCELAS (PAGO/PENDENTE/ATRASADO)
                        If cStatus = 1 Then
                            btn.Image = My.Resources.iconPago
                        ElseIf cStatus = 2 Then
                            btn.Image = My.Resources.iconPendente
                        ElseIf cStatus = 3 Then
                            btn.Image = My.Resources.iconStatusAtrasado_Alerta_
                        End If

                        If i < 6 Then
                            'POSIÇÃO DOS GROUPBOX QUE CONTÉM AS PARCELAS
                            xGb = gbDadosDetalhe.Location.X - 3
                            xInicialGb = xGb
                        End If

                        ''CRIA NOVO GROUPBOX (6 PARCELA POR GROUPBOX)
                        If Qtde > 6 Then

                            If i - iGb = 6 Then

                                iGb = i
                                If xInicialGb > 0 Then
                                    xGb = xGb + distancia
                                    distancia = xGb + 300
                                    xInicialGb = 0
                                Else
                                    xGb = distancia
                                    distancia = distancia + 300
                                End If


                                gbParcela = New GroupBox
                                yy = 45

                            End If
                            '    If i > 5 Then
                            '        xGb = gbDadosDetalhe.Location.X + gbParcela.Width + 50
                            '        '368
                            '        'RESETA O Y DOS TEXTBOX 
                            '        If i = 6 Then
                            '            yy = 45
                            '            gbParcela = New GroupBox
                            '        End If
                            '    End If

                            '    If i > 11 Then
                            '        xGb = gbDadosDetalhe.Location.X + (gbParcela.Width * 2) + 100
                            '        '675
                            '        If i = 12 Then
                            '            yy = 45
                            '            gbParcela = New GroupBox
                            '        End If
                            '    End If

                            '    If i > 17 Then
                            '        xGb = gbDadosDetalhe.Location.X + (gbParcela.Width * 3) + 150
                            '        '995
                            '        If i = 18 Then
                            '            yy = 45
                            '            gbParcela = New GroupBox
                            '        End If
                            '    End If
                            '    If i > 23 Then
                            '        xGb = gbDadosDetalhe.Location.X + (gbParcela.Width * 3) + 147
                            '        If i = 24 Then
                            '            yy = 45
                            '            gbParcela = New GroupBox
                            '        End If
                            '    End If
                        Else
                            xGb = CInt((gbDadosDetalhe.Parent.Width / 2)) - 125
                        End If

                        If i > 0 Then
                            Y = yy
                        Else
                            X = 39
                            Y = 45
                        End If

                        'GROUPBOX DOS CONTROLES PARCELAMENTO
                        gbParcela.Name = "gbParcela" & i.ToString
                        gbParcela.SetBounds(xGb, 0, 249, 450)
                        gbParcela.Text = ""
                        gbParcela.BackColor = Color.WhiteSmoke
                        gbParcela.Visible = True

                        'LABEL DATA
                        data.Name = "lblData" & i.ToString
                        data.Text = rs("dtRegistro", i).ToString
                        data.SetBounds(X - 5, Y - 25, 100, 25)
                        data.Visible = True
                        gbParcela.Controls.Add(data)
                        data.BringToFront()

                        'LABEL PARCELA (1/10)
                        parcela.Name = "lblparcela" & cNumParcela.ToString
                        parcela.Text = "(" & cNumParcela.ToString & "/" & Qtde.ToString & ")"
                        parcela.SetBounds(X + 105, Y - 25, 100, 25)
                        parcela.Visible = True
                        gbParcela.Controls.Add(parcela)
                        parcela.BringToFront()

                        'CHK
                        chk.Name = CInt(rs("cDespesa", i)).ToString
                        chk.SetBounds(X - 20, Y + 5, 16, 16)
                        chk.Visible = True
                        gbParcela.Controls.Add(chk)
                        chk.BringToFront()

                        'BOTAO STATUS PAGO (OK)
                        btn.Name = "btn" & i
                        btn.SetBounds(X + 150, Y - 5, 35, 33)
                        btn.Visible = True
                        gbParcela.Controls.Add(btn)
                        btn.BringToFront()

                        'TEXT VALOR
                        txt.Name = "Parcela" & CInt(rs("cNumeroParcela", i)).ToString
                        txt.Text = Convert.ToDouble(rs("cValor", i)).ToString("C")
                        txt.ForeColor = Color.Black
                        txt.TabIndex = CInt(2 + i)
                        txt.SetBounds(X, Y, 150, 25)
                        txt.Visible = True
                        gbParcela.Controls.Add(txt)
                        txt.BringToFront()


                        yy = txt.Location.Y + 70

                        pnlDetalhe.Controls.Add(gbParcela)
                    Next
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs)
        Dim codigo As Decimal
        Dim chk As CheckBox
        For Each item As Control In gbDetalhe.Controls

            If item.GetType().Name.ToUpper = "CHECKBOX" Then
                chk = CType(item, CheckBox)
                If chk.Checked Then
                    codigo = CDec(item.Name)
                    If codigo <> 0 Then
                        pDespesa.Pagar(codigo)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub tabCtrlDespesa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCtrlDespesa.SelectedIndexChanged
        ControleFormulario()
    End Sub

    Private Sub lvlConsultaFixa_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvlConsultaFixa.ItemChecked
        ControleFormulario()
    End Sub

    Private Sub chkList_CheckedChanged(sender As Object, e As EventArgs) Handles chkList.CheckedChanged
        Try
            If chkList.Checked Then
                For i = 0 To lvConsulta.ObterTotalLinhas - 1
                    lvConsulta.Items.Item(i).Checked = True
                Next
            Else
                For i = 0 To lvConsulta.ObterTotalLinhas - 1
                    lvConsulta.Items.Item(i).Checked = False
                Next

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnLancamentoFuturo_Click(sender As Object, e As EventArgs) Handles btnLancamentoFuturo.Click
        Dim cDepesaFixa As Decimal
        Try
            If lvlConsultaFixa.SelectedItems.Count > 0 Then
                cDepesaFixa = lvlConsultaFixa.ObterChave()

                If cDepesaFixa <> 0 Then

                    If pDespesaFixa.InserirLancamentoFuturo(cDepesaFixa) Then
                        S_MsgBox("Lançamentos adicionados com sucesso!", eBotoes.Ok, "Despesa Fixa",, eImagens.FileOK)
                    Else
                        S_MsgBox("não foi possível gerar lançamentos desta despesa fixa.", eBotoes.Ok, "Despesa Fixa",, eImagens.Cancel)
                    End If

                    oDataset = pDespesaFixa.Pesquisar

                    If oDataset.TotalRegistros > 0 Then
                        lvlConsultaFixa.PreencheGridDS(oDataset, True, True, False, True, 0, True)
                        txtLetreiroFixa.TextoLetreiro = oDataset.InfoPesquisa.ToString
                    End If
                End If
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro ::. Despesa Fixa",, eImagens.Cancel)

        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS

        oXls = New SuperXLS("Despesa")

        oXls.Imprimir(oDataset, "Despesas", True)
    End Sub
End Class