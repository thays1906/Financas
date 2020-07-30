Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Public Class frmCobranca
    Public oForm As frmNovaCobranca
    Public cCobranca As Decimal
    Public oDataSet As SuperDataSet
    Public columnImg As String
    Private Sub frmCobranca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.CinzaBranco)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnAdd, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CarregarCombo()

        Pesquisar()

        ControleBotoes()
    End Sub

    Private Sub ControleBotoes()
        Dim linha As Integer = 0
        Try
            linha = CInt(dgCobranca.ObterTodosChecados())
            For i = 0 To dgCobranca.Rows.Count - 1
                If CBool(dgCobranca.Rows(i).Cells(0).Value) = True Then
                    linha += 1
                End If
            Next
            If dgCobranca.SelectedRows.Count = 0 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
            Else
                If linha = 1 Then
                    btnEditar.Enabled = True
                    btnExcluir.Enabled = True
                ElseIf linha > 1 Then
                    btnExcluir.Enabled = True
                    btnEditar.Enabled = False
                Else
                    btnExcluir.Enabled = False
                    btnEditar.Enabled = False
                End If

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub frmCobranca_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.cobranca)
    End Sub

    Private Sub frmCobranca_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            Pesquisar()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Function Pesquisar() As SuperDataSet
        Dim cellImg As New DataGridViewCellStyle()
        Dim cellCol As New DataGridViewCellStyle()
        Dim ANO As Decimal
        Dim columnImg As String

        Try
            oDataSet = New SuperDataSet()


            If cbAno.ObterDescricaoCombo().Contains("Todos") Then
                ANO = Nothing
            Else
                ANO = CDec(cbAno.ObterDescricaoCombo())
            End If

            oDataSet = pCobrancaPagamento.Pesquisar(MinHora(dtInicial.Value), MaxHora(dtFinal.Value),
                                                    CDec(cbMes.ObterChaveCombo),
                                                    ANO,
                                                    cbDevedor.ObterDescricaoCombo,
                                                    CType(cbStatus.ObterChaveCombo, eStatusDespesa), chkPeriodo)

            columnImg = "CONTA"

            'Adicionando uma coluna com Imagens no DataSet.
            For i = 0 To oDataSet.TotalRegistros - 1
                dgCobranca.AdicionaImageColumn(oDataSet, columnImg, Banco(oDataSet("Conta Báncaria", i).ToString), False)
            Next

            dgCobranca.PreencheDataGrid(oDataSet,,, txtLetreiroCobr)

            If oDataSet.TotalRegistros > 0 Then

                cellImg.Alignment = DataGridViewContentAlignment.MiddleCenter
                cellCol.Alignment = DataGridViewContentAlignment.MiddleLeft

                For i = 0 To dgCobranca.Rows.Count - 1

                    dgCobranca.Rows(i).Cells("CONTA BÁNCARIA").Style = cellCol

                    dgCobranca.Rows(i).Cells("CONTA").Style = cellImg

                Next

                dgCobranca.Columns("CONTA").HeaderCell.Style = cellCol
                dgCobranca.Columns("CONTA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgCobranca.Columns("CONTA").DisplayIndex = dgCobranca.Columns.Count - 1

                dgCobranca.Columns("CONTA BÁNCARIA").HeaderCell.Style = cellCol
                dgCobranca.Columns("CONTA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                dgCobranca.Columns("CONTA BÁNCARIA").DisplayIndex = dgCobranca.Columns.Count - 1
                dgCobranca.Columns("CONTA BÁNCARIA").HeaderText = "BÁNCARIA"

            End If

            Return oDataSet

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
            Return Nothing
        Finally
            oDataSet.Dispose()
        End Try

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        oForm = New frmNovaCobranca(0)

        oForm.ShowDialog()

        If oForm.bAlterado Then
            Pesquisar()
            CarregarCombo(True)
        End If
    End Sub
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim rCobranca As String = Nothing
        Dim checados As Integer = Nothing
        Dim ok As Integer = Nothing
        Dim erro As Integer = Nothing
        Try

            checados = CInt(dgCobranca.ObterTodosChecados)
            rCobranca = dgCobranca.ObterTodasChaves

            If checados > 1 Then

                If rCobranca <> "" Then

                    If Mensagem(eTipoMensagem.Question, checados) = eRet.Sim Then

                        For Each codigo In rCobranca.Split(CChar(";"))

                            If pCobrancaPagamento.Deletar(CDec(codigo)) Then
                                ok += 1
                            Else
                                erro += 1
                            End If
                        Next
                    End If
                End If

            ElseIf checados = 1 Then

                If Mensagem(eTipoMensagem.Question) = eRet.Sim Then

                    If pCobrancaPagamento.Deletar(CDec(rCobranca)) Then
                        ok += 1
                    Else
                        erro += 1
                    End If
                End If
            End If

            If erro <> 0 Then
                Mensagem(eTipoMensagem.Erro, checados, ok, erro)
            ElseIf ok <> 0 Then
                Mensagem(eTipoMensagem.OK)
                Pesquisar()
                CarregarCombo(True)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub CarregarCombo(Optional ByVal _cbDevedor As Boolean = False)
        Dim rs As SuperDataSet = Nothing
        Dim col As Collection = Nothing
        Dim dtMes As Date = Nothing
        Dim dtAno As Date = Nothing
        Try
            rs = New SuperDataSet()
            col = New Collection

            If _cbDevedor = True Then

                rs = pCobrancaPagamento.CarregarCombo()

                If rs.TotalRegistros > 0 Then
                    cbDevedor.PreencheComboDS(rs, "rTitular", "cCobrPag", PrimeiroValor.Todos)
                End If
            Else
                rs = pCobrancaPagamento.CarregarCombo()

                If rs.TotalRegistros > 0 Then
                    cbDevedor.PreencheComboDS(rs, "rTitular", "cCobrPag", PrimeiroValor.Todos)
                End If

                col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
                col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
                col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

                cbStatus.PreencheComboColl(col, PrimeiroValor.Todos)

                col.Clear()

                For i = 1 To 12

                    col.Add(New DuplaCombo(i, dtMes.AddMonths(i - 1).ToString("MMMM").ToUpper))

                Next

                cbMes.PreencheComboColl(col, PrimeiroValor.Todos)

                col.Clear()

                dtAno = Now.AddYears(-3)

                For i = 1 To 6
                    col.Add(New DuplaCombo(i, dtAno.AddYears(i).ToString("yyyy")))
                Next
                cbAno.PreencheComboColl(col, PrimeiroValor.Todos)
                cbAno.PosicionaRegistroCombo(3)
            End If
            col.Clear()
            rs.Dispose()
            gbCobrancaFiltro.Refresh()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        Finally
            rs.Dispose()
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            Alterar()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub chkPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles chkPeriodo.CheckedChanged
        If chkPeriodo.Checked Then

            dtInicial.Enabled = True
            dtFinal.Enabled = True

            cbMes.Enabled = False
            cbAno.Enabled = False
        Else
            dtInicial.Enabled = False
            dtFinal.Enabled = False

            cbMes.Enabled = True
            cbAno.Enabled = True

        End If
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS
        Dim col As Integer = 0
        Try
            oDataSet = New SuperDataSet

            oXls = New SuperXLS("Cobrança")

            oDataSet = Pesquisar()

            col = oDataSet.IndiceColuna("CONTA", 0)
            oDataSet.Tables(0).Columns.RemoveAt(col)

            col = oDataSet.IndiceColuna("id_", 0)
            oDataSet.Tables(0).Columns.RemoveAt(col)

            oXls.Imprimir(oDataSet, "Lista de Devedores" & " - " & Now.ToString, True)


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        Finally
            oDataSet.Dispose()
        End Try
    End Sub
    Private Sub Alterar()
        Try
            cCobranca = dgCobranca.ObterChave

            If cCobranca <> 0 Then

                oForm = New frmNovaCobranca(cCobranca)
                oForm.ShowDialog()

                If oForm.bAlterado Then
                    Pesquisar()
                End If
            End If

            dgCobranca.HabilitarDesabilitarEdicao()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub chkSelecionaTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelecionaTodos.CheckedChanged
        Try
            dgCobranca.MarcaDesmarcaTodos(chkSelecionaTodos)

            ControleBotoes()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgCobranca_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs)
        Alterar()
    End Sub

    'Private Sub dgCobranca_SelectionChanged(sender As Object, e As EventArgs) Handles dgCobranca.SelectionChanged
    '    ControleBotoes()
    'End Sub

    'Private Sub dgCobranca_MouseClick(sender As Object, e As MouseEventArgs) Handles dgCobranca.MouseClick
    '    ControleBotoes()
    'End Sub

    Private Sub dgCobranca_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        ControleBotoes()
    End Sub

    'Private Sub dgCobranca_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgCobranca.RowEnter
    '    ControleBotoes()
    'End Sub


End Class