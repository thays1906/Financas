Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Public Class frmCobranca
    Public oForm As frmAddCobranca
    Public cCobranca As Decimal



    Private Sub frmCobranca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaBranco)
        CorTab(tabCtrlCobranca, Collor.CinzaClaro)
        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnAdd, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)


        CarregarCombo()
        Pesquisar()

        dgCobranca.ClearSelection()
        ControleBotoes()



    End Sub

    Private Sub ControleBotoes()
        Try
            If dgCobranca.SelectedRows.Count > 1 Then
                btnExcluir.Enabled = True
                btnEditar.Enabled = False
            ElseIf dgCobranca.SelectedRows.Count = 1 Then
                btnEditar.Enabled = True
                btnExcluir.Enabled = True
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
    Private Sub Pesquisar()
        Dim oDataSet As SuperDataSet
        Dim ANO As Decimal
        Try
            If cbAno.ObterDescricaoCombo().Contains("Todos") Then
                ANO = Nothing
            Else
                ANO = CDec(cbAno.ObterDescricaoCombo())
            End If
            oDataSet = New SuperDataSet()
            oDataSet = pCobrancaPagamento.Pesquisar(MinHora(dtInicial.Value), MaxHora(dtFinal.Value),
                                                    CDec(cbMes.ObterChaveCombo),
                                                    ANO,
                                                    cbDevedor.ObterDescricaoCombo,
                                                    CType(cbStatus.ObterChaveCombo, eStatusDespesa), chkPeriodo)

            dgCobranca.DataSource = oDataSet.Tables(0)
            dgCobranca.Columns(1).Visible = False
            txtLetreiroCobr.TextoLetreiro = oDataSet.InfoPesquisa
            'For i = 0 To dgCobranca.Rows.Count - 1
            '    If dgCobranca.Rows(i).Selected Then
            '        dgCobranca.Rows(i).Selected = False
            '    End If
            'Next

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        oForm = New frmAddCobranca(0)
        oForm.ShowDialog()

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




        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            If dgCobranca.SelectedRows.Count = 1 Then

                cCobranca = CDec(dgCobranca.SelectedRows.Item(0).Cells(1).Value)

                If cCobranca <> 0 Then

                    oForm = New frmAddCobranca(cCobranca)
                    oForm.ShowDialog()
                    Pesquisar()
                Else
                    S_MsgBox("Desculpe, não foi possível localizar este registro.", eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
                End If

            Else
                S_MsgBox("Por favor, selecione um registro para realizar alterações.", eBotoes.Ok, "Nenhum registro selecionado",, eImagens.Atencao)
            End If
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

        'For i = 0 To dgCobranca.SelectedRows.Count
        '    checados += dgCobranca.SelectedRows.Count
        'Next


    End Sub

    Private Sub dgCobranca_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgCobranca.CellValueChanged

        'If dgCobranca.Rows.Count > 0 Then
        '    If dgCobranca.Columns(e.ColumnIndex).Name = "chkDataGrid" Then

        '        For i = 0 To dgCobranca.Rows.Count - 1

        '            If CBool(dgCobranca.Rows(i).Cells("chkDataGrid").Value) Then
        '                checados += 1
        '            End If
        '        Next
        '        MessageBox.Show("Total selecionados: " & checados)
        '    End If
        'End If

    End Sub


    Private Sub dgCobranca_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles dgCobranca.DataBindingComplete
        For i = 0 To dgCobranca.Rows.Count - 1
            If dgCobranca.Rows(i).Selected Then
                dgCobranca.ClearSelection()
            End If
        Next
    End Sub

    Private Sub dgCobranca_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCobranca.CellMouseClick
        Dim checa As Integer
        If dgCobranca.SelectedRows.Count > 0 Then

            If Control.ModifierKeys = Keys.Control Then

                For i = 0 To dgCobranca.Rows.Count - 1

                    If dgCobranca.Rows(i).Selected Then
                        checa += 1
                    End If
                Next
            Else
                For i = 0 To dgCobranca.Rows.Count - 1

                    If dgCobranca.Rows(i).Selected Then
                        'Seleção com tecla Ctrl pressionada



                        'Sem tecla Ctrl

                        If CBool(dgCobranca.Rows(i).Cells(0).Value) = False Then
                            dgCobranca.Rows(i).Cells(0).Value = True
                        Else
                            dgCobranca.Rows(i).Cells(0).Value = False
                        End If

                    End If
                Next

                For i = 0 To dgCobranca.Columns.Count - 1

                    If CInt(dgCobranca.Columns(i).Index) <> dgCobranca.Columns(0).Index Then
                        dgCobranca.Columns(i).ReadOnly = True
                    End If
                Next
            End If
        End If
        If checa <> 0 Then
            For i = 0 To checa - 1
                dgCobranca.Rows(i).Cells(0).Value = True
            Next
        End If
        ControleBotoes()
    End Sub

    Private Sub dgCobranca_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCobranca.CellContentDoubleClick


        'For i = 0 To dgCobranca.Rows.Count - 1
        '        If dgCobranca.Rows(i).Selected Then
        '            If CBool(dgCobranca.Rows(i).Cells(0).Value) = True Then
        '                dgCobranca.Rows(i).Cells(0).Value = False
        '            End If
        '        End If
        '    Next

    End Sub


End Class