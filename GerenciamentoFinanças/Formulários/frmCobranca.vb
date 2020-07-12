Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Public Class frmCobranca
    Public oForm As frmAddCobranca
    Public cCobranca As Decimal
    Public oDataSet As SuperDataSet
    Public bDouble As Boolean = False
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
            For i = 0 To dgCobranca.Rows.Count - 1
                If CBool(dgCobranca.Rows(i).Cells(0).Value) = True Then
                    linha += 1
                End If
            Next

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

            columnImg = "Conta"

            oDataSet.Tables(0).Columns.Add(columnImg, System.Type.GetType("System.Byte[]"))

            AdicionaImgColumn(oDataSet, columnImg)

            dgCobranca.DataSource = oDataSet.Tables(0)
            dgCobranca.Columns("Conta").HeaderText = ""
            dgCobranca.Columns(1).Visible = False

            txtLetreiroCobr.TextoLetreiro = oDataSet.InfoPesquisa

            Return oDataSet

            dgCobranca.Refresh()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
            Return Nothing
        Finally
            oDataSet.Dispose()
        End Try

    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        oForm = New frmAddCobranca(0)

        oForm.ShowDialog()

        'Verificar se foi adicionado algum registro, para pesquisar, se nao NOT_Pesquisa

        Pesquisar()
        CarregarCombo(True)
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If dgCobranca.SelectedRows.Count > 0 Then

                cCobranca = CDec(dgCobranca.SelectedRows.Item(0).Cells(1).Value)

                If cCobranca <> 0 Then

                    If S_MsgBox("Deseja realmente deletar este registro?",
                                 eBotoes.SimNao, "Exclusão de registro",,
                                 eImagens.Interrogacao) = eRet.Sim Then

                        If pCobrancaPagamento.Deletar(cCobranca) Then

                            S_MsgBox("Registro excluído com sucesso!.",
                                     eBotoes.Ok, "Exclusão de registro",,
                                     eImagens.Ok)

                            Pesquisar()
                        End If


                    Else
                        S_MsgBox("Desculpe, não foi possível deletar este registro.",
                                 eBotoes.Ok, "Houve um erro",,
                                 eImagens.Cancel)

                    End If
                    CarregarCombo(True)
                End If
            End If
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
        Try
            oDataSet = New SuperDataSet

            oXls = New SuperXLS("Cobrança")

            oDataSet = Pesquisar()

            oXls.Imprimir(oDataSet, "Lista de Devedores" & " - " & Now.ToString, True)

            oDataSet.Dispose()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub dgCobranca_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgCobranca.DataBindingComplete
        Try
            For i = 0 To dgCobranca.Rows.Count - 1
                If dgCobranca.Rows(i).Selected Then
                    dgCobranca.Rows(i).Cells(0).Value = False
                    dgCobranca.ClearSelection()
                End If
            Next

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgCobranca_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCobranca.CellMouseClick
        Try
            'While (i <= 250000)
            '    Application.DoEvents()
            '    i += 1

            'End While

            If bDouble = False Then

                If CInt(dgCobranca.Rows(e.RowIndex).Index) <> -1 Then

                    If Control.ModifierKeys = Keys.Control Or Control.ModifierKeys = Keys.None Then

                        If CBool(dgCobranca.Rows(e.RowIndex).Cells(0).Value) = False Then

                            dgCobranca.Rows(e.RowIndex).Cells(0).Value = True
                            'dgCobranca.Rows(e.RowIndex).Selected = True

                            dgCobranca.Refresh()
                        ElseIf CBool(dgCobranca.Rows(e.RowIndex).Cells(0).Value) = True Then

                            dgCobranca.Rows(e.RowIndex).Selected = False
                            dgCobranca.Rows(e.RowIndex).Cells(0).Value = False
                            dgCobranca.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.ButtonFace
                            dgCobranca.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black


                        End If
                    End If

                    'Desativa edição das células de todas as colunas, exceto a (0) = checkbox.
                    For i = 0 To dgCobranca.Columns.Count - 1

                        If CInt(dgCobranca.Columns(i).Index) <> dgCobranca.Columns(0).Index Then
                            dgCobranca.Columns(i).ReadOnly = True
                        End If
                    Next

                    ControleBotoes()
                End If
            End If
            bDouble = False
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try

    End Sub
    Private Sub dgcobranca_rowleave(sender As Object, e As DataGridViewCellEventArgs) Handles dgCobranca.RowLeave
        Try
            If CBool(dgCobranca.Rows(e.RowIndex).Cells(0).Value) = True Then

                dgCobranca.Rows(e.RowIndex).DefaultCellStyle.BackColor = SystemColors.ControlDarkDark
                dgCobranca.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgCobranca_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCobranca.CellMouseDoubleClick
        Try
            bDouble = True
            Alterar()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub Alterar()
        Try
            If dgCobranca.SelectedRows.Count = 1 Then

                cCobranca = CDec(dgCobranca.SelectedRows.Item(0).Cells(1).Value)

                If cCobranca <> 0 Then

                    oForm = New frmAddCobranca(cCobranca)
                    oForm.ShowDialog()

                    If oForm.bAlterado = True Then
                        Pesquisar()
                    End If
                Else
                    S_MsgBox("Desculpe, não foi possível localizar este registro.",
                             eBotoes.Ok, "Houve um erro",,
                             eImagens.Cancel)
                End If

            Else
                S_MsgBox("Por favor, selecione um registro para realizar alterações.",
                         eBotoes.Ok, "Nenhum registro selecionado",,
                         eImagens.Atencao)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub chkSelecionaTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelecionaTodos.CheckedChanged
        Try
            If dgCobranca.Rows.Count > 0 Then

                For i = 0 To dgCobranca.Rows.Count - 1
                    If chkSelecionaTodos.Checked Then
                        dgCobranca.Rows(i).Selected = True
                        dgCobranca.Rows(i).Cells(0).Value = True
                    Else
                        dgCobranca.Rows(i).Selected = False
                        dgCobranca.Rows(i).Cells(0).Value = False
                        dgCobranca.ClearSelection()
                    End If
                Next
                ControleBotoes()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)

        End Try
    End Sub
End Class