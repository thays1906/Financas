Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Public Class frmCobranca
    Public oForm As frmNovaCobranca
    Public cCobranca As Decimal
    Public oDataSet As SuperDataSet
    'Public bDouble As Boolean = False
    Public columnImg As String
    Private Sub frmCobranca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.CinzaBranco)

        'CorTab(tabCtrlCobranca, Collor.CinzaClaro)

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
            For i = 0 To datagridCobranca.Rows.Count - 1
                If CBool(datagridCobranca.Rows(i).Cells(0).Value) = True Then
                    linha += 1
                End If
            Next
            If datagridCobranca.SelectedRows.Count = 0 Then
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
        'Dim ANO As Decimal

        Try
            Pesquisar()

            'If cbAno.ObterDescricaoCombo().Contains("Todos") Then
            '    ANO = Nothing
            'Else
            '    ANO = CDec(cbAno.ObterDescricaoCombo())
            'End If

            'oDataSet = pCobrancaPagamento.Pesquisar(MinHora(dtInicial.Value), MaxHora(dtFinal.Value),
            '                                        CDec(cbMes.ObterChaveCombo),
            '                                        ANO,
            '                                        cbDevedor.ObterDescricaoCombo,
            '                                        CType(cbStatus.ObterChaveCombo, eStatusDespesa), chkPeriodo)
            'SuperDataGridView1.PreencheDataGrid(oDataSet,,, txtLetreiroCobr)
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

            'oDataSet.Tables(0).Columns.Add(columnImg, System.Type.GetType("System.Byte[]"))

            'AdicionaImgColumn(oDataSet, columnImg)

            For i = 0 To oDataSet.TotalRegistros - 1
                datagridCobranca.AdicionaImageColumn(oDataSet, columnImg, Banco(oDataSet("Conta Báncaria", i).ToString), False)
            Next


            'dgCobranca.DataSource = oDataSet.Tables(0)

            datagridCobranca.PreencheDataGrid(oDataSet,,, txtLetreiroCobr)

            'dgCobranca.Columns(" CONTA").DisplayIndex = 6
            'dgCobranca.Columns(" CONTA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            'dgCobranca.Columns("Conta Báncaria").HeaderText = "BÁNCARIA"

            'dgCobranca.Columns(1).Visible = False

            'txtLetreiroCobr.TextoLetreiro = oDataSet.InfoPesquisa
            'dgCobranca.AutoResizeColumns                cellCol.Alignment = DataGridViewContentAlignment.MiddleLeft
            If oDataSet.TotalRegistros > 0 Then

                cellImg.Alignment = DataGridViewContentAlignment.MiddleCenter
                cellCol.Alignment = DataGridViewContentAlignment.MiddleLeft
                For i = 0 To datagridCobranca.Rows.Count - 1

                    datagridCobranca.Rows(i).Cells("CONTA BÁNCARIA").Style = cellCol

                    datagridCobranca.Rows(i).Cells("CONTA").Style = cellImg

                Next

                datagridCobranca.Columns("CONTA").HeaderCell.Style = cellCol
                datagridCobranca.Columns("CONTA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                datagridCobranca.Columns("CONTA").DisplayIndex = datagridCobranca.Columns.Count - 2

                datagridCobranca.Columns("CONTA BÁNCARIA").HeaderCell.Style = cellCol
                datagridCobranca.Columns("CONTA").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                datagridCobranca.Columns("CONTA BÁNCARIA").HeaderText = "BÁNCARIA"

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

        End If
        'Verificar se foi adicionado algum registro, para pesquisar, se nao NOT_Pesquisa

        CarregarCombo(True)
    End Sub
    'Excluindo somente um --Arrumar
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim rCobranca As String = Nothing
        Dim checados As Integer = Nothing
        Dim ok As Integer = Nothing
        Dim erro As Integer = Nothing
        Try
            checados = datagridCobranca.SelectedRows.Count

            checados = CInt(datagridCobranca.ObterTodosChecados)
            rCobranca = datagridCobranca.ObterTodasChaves
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
                Mensagem(eTipoMensagem.OK, checados)
                Pesquisar()
            End If

            'For Each item As DataGridViewRow In dgCobranca.Rows
            '    If CBool(item.Cells(0).Value) = True Then
            '        checados += 1
            '        rCobranca += String.Concat(item.Cells(1).Value.ToString, ";")
            '    End If
            'Next

            ''Se for vários selecionados
            'If checados > 1 Then
            '    If Mensagem(eTipoMensagem.Question, checados) = eRet.Sim Then

            '        For Each codigo In rCobranca.Split(CChar(";"))
            '            If codigo = "" OrElse CDec(codigo) <> 0 Then
            '                If pCobrancaPagamento.Deletar(CDec(codigo)) Then
            '                    ok += 1
            '                Else
            '                    erro += 1
            '                End If
            '            End If
            '        Next
            '        If erro = 0 Then
            '            Mensagem(eTipoMensagem.OK,, ok)
            '        Else
            '            Mensagem(eTipoMensagem.Erro, checados, ok, erro)
            '        End If
            '    End If

            'Else
            '    'Um Selecionado
            '    cCobranca = CDec(dgCobranca.SelectedRows.Item(0).Cells(1).Value)

            '    If cCobranca <> 0 Then

            '        If Mensagem(eTipoMensagem.Question) = eRet.Sim Then

            '            If pCobrancaPagamento.Deletar(cCobranca) Then

            '                Mensagem(eTipoMensagem.OK)

            '                Pesquisar()
            '            End If
            '        Else
            '            Mensagem(eTipoMensagem.Erro)
            '        End If
            '    End If

            '    CarregarCombo(True)
            'End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub CarregarCombo(Optional ByVal _cbDevedor As Boolean = False)
        Dim rs As SuperDataSet
        Dim col As Collection
        Dim dtMes As Date
        Dim dtAno As Date
        Try
            rs = New SuperDataSet
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
    Private Sub dgCobranca_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgCobranca.DataBindingComplete
        Dim cel As New DataGridViewCellStyle()
        Dim cell As New DataGridViewCellStyle()
        Try
            For i = 0 To dgCobranca.Rows.Count - 1

                If dgCobranca.Rows(i).Selected Then

                    dgCobranca.Rows(i).Cells(0).Value = False
                    dgCobranca.ClearSelection()

                End If
            Next

            'For i = 0 To dgCobranca.Columns.Count - 1

            '    If dgCobranca.Columns(i).Index <> dgCobranca.Columns(0).Index Then

            '        dgCobranca.Columns(i).ReadOnly = True
            '    End If
            'Next

            'Alinha imagem a outra coluna
            cel.Alignment = DataGridViewContentAlignment.MiddleRight
            cell.Alignment = DataGridViewContentAlignment.MiddleLeft

            For i = 0 To dgCobranca.Rows.Count - 1

                If CBool(dgCobranca.Columns(7).Index) Then
                    Me.dgCobranca.Columns(7).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Me.dgCobranca.Columns(6).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Me.dgCobranca.Rows(i).Cells(7).Style = cel
                    Me.dgCobranca.Rows(i).Cells(6).Style = cell
                End If
            Next

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgCobranca_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCobranca.CellMouseClick
        Dim rowIndex As Integer = 0
        Try
            'While (i <= 250000)
            '    Application.DoEvents()
            '    i += 1

            'End While

            'If bDouble = False Then
            rowIndex = e.RowIndex

            SelecionarDataGrid(dgCobranca, rowIndex)

            'If CInt(dgCobranca.Rows(e.RowIndex).Index) <> -1 Then

            '    If Control.ModifierKeys = Keys.Control Or Control.ModifierKeys = Keys.None Then

            '        If CBool(dgCobranca.Rows(e.RowIndex).Cells(0).Value) = False Then

            '            dgCobranca.Rows(e.RowIndex).Cells(0).Value = True
            '            'dgCobranca.Rows(e.RowIndex).Selected = True

            '            dgCobranca.Refresh()
            '        ElseIf CBool(dgCobranca.Rows(e.RowIndex).Cells(0).Value) = True Then

            '            dgCobranca.Rows(e.RowIndex).Selected = False
            '            dgCobranca.Rows(e.RowIndex).Cells(0).Value = False
            '            dgCobranca.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.ButtonFace
            '            dgCobranca.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black


            '        End If
            '    End If

            'Desativa edição das células de todas as colunas, exceto a (0) = checkbox.
            'For i = 0 To dgCobranca.Columns.Count - 1

            '    If CInt(dgCobranca.Columns(i).Index) <> dgCobranca.Columns(0).Index Then
            '        dgCobranca.Columns(i).ReadOnly = True
            '    End If
            'Next

            'ControleBotoes()
            DataGridSelecao()
            'End If
            'bDouble = False
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try

    End Sub
    Private Sub dgcobranca_rowleave(sender As Object, e As DataGridViewCellEventArgs) Handles dgCobranca.RowLeave
        Dim row As DataGridViewRow = dgCobranca.Rows(e.RowIndex)
        Try

            If CBool(dgCobranca.Rows(e.RowIndex).Cells(0).Value) = True Then
                dgCobranca.Rows(e.RowIndex).Selected = True
                dgCobranca.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.ControlDarkDark
                dgCobranca.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgCobranca_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCobranca.CellMouseDoubleClick
        Try
            'bDouble = True
            Alterar()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub Alterar()
        Try
            cCobranca = datagridCobranca.ObterChave

            If cCobranca <> 0 Then
                oForm = New frmNovaCobranca(cCobranca)
                oForm.ShowDialog()
                If oForm.bAlterado Then
                    Pesquisar()
                End If
            End If

            datagridCobranca.HabilitarDesabilitarEdicao()
            'If dgCobranca.SelectedRows.Count = 1 Then

            '    cCobranca = CDec(dgCobranca.SelectedRows.Item(0).Cells(1).Value)

            '    If cCobranca <> 0 Then

            '        oForm = New frmAddCobranca(cCobranca)
            '        oForm.ShowDialog()

            '        If oForm.bAlterado = True Then
            '            Pesquisar()
            '        End If
            '    Else
            '        S_MsgBox("Desculpe, não foi possível localizar este registro.",
            '                 eBotoes.Ok, "Houve um erro",,
            '                 eImagens.Cancel)
            '    End If

            'Else
            '    S_MsgBox("Por favor, selecione um registro para realizar alterações.",
            '             eBotoes.Ok, "Nenhum registro selecionado",,
            '             eImagens.Atencao)
            'End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub chkSelecionaTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelecionaTodos.CheckedChanged

        Try
            datagridCobranca.MarcaDesmarcaTodos(chkSelecionaTodos)

            'If dgCobranca.Rows.Count > 0 Then

            '    For i = 0 To dgCobranca.Rows.Count - 1
            '        If chkSelecionaTodos.Checked Then
            '            dgCobranca.Rows(i).Selected = True
            '            dgCobranca.Rows(i).Cells(0).Value = True
            '        Else
            '            dgCobranca.Rows(i).Selected = False
            '            dgCobranca.Rows(i).Cells(0).Value = False
            '            dgCobranca.ClearSelection()
            '        End If
            '    Next
            ControleBotoes()
            'End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub


    Private Sub DataGridSelecao()
        Try


            For i = 0 To dgCobranca.Rows.Count - 1
                If CBool(dgCobranca.Rows(i).Cells(0).Value) = True Then
                    dgCobranca.Rows(i).Selected = True
                Else
                    dgCobranca.Rows(i).Selected = False
                End If
            Next


            Dim ii = dgCobranca.SelectedRows.Count
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub



    Private Sub dgCobranca_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgCobranca.CurrentCellChanged
        DataGridSelecao()
    End Sub

    Private Sub datagridCobranca_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridCobranca.CellMouseDoubleClick
        Alterar()
    End Sub

    Private Sub datagridCobranca_SelectionChanged(sender As Object, e As EventArgs) Handles datagridCobranca.SelectionChanged
        ControleBotoes()
    End Sub
End Class