Imports GFT.Util
Imports GFT.Util.SuperComboBox
Imports GFT.Util.clsMsgBox
Public Class frmDespesa
    Public oDataset As SuperDataSet
    Dim addDespesa As frmNovaDespesa
    Dim cDespesa As Decimal
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frmDespesa_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmDespesa_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Despesa)
    End Sub

    Private Sub btnAddDespesa_Click(sender As Object, e As EventArgs) Handles btnAddDespesa.Click
        Try
            addDespesa = New frmNovaDespesa(cDespesa)
            addDespesa.ShowDialog()
            Pesquisar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tbConsulta)
        CarregarCombo()
        Pesquisar()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cDespesa As Decimal
        Try

            If lvConsulta.SelectedItems.Count > 0 Then

                cDespesa = lvConsulta.ObterChave()

                If cDespesa > 0 Then
                    addDespesa = New frmNovaDespesa(cDespesa)
                    addDespesa.ShowDialog()
                Else
                    S_MsgBox("Erro ao carregar registro.", eBotoes.Ok,,, eImagens.Cancel)
                End If

            End If
            Pesquisar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim rDespesa As String
        Dim erro As Decimal
        Dim ok As Decimal
        Dim tot As Decimal
        Try
            If lvConsulta.SelectedItems.Count > 0 Then

                If S_MsgBox("Deseja realmente excluir despesa(s)?",
                            eBotoes.SimNao,,, eImagens.Interrogacao) = eRet.Sim Then

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

                    tot = lvConsulta.ObterTotalChecados

                    If erro = 0 Then
                        S_MsgBox("Despesa(s) excluída(s) com sucesso", clsMsgBox.eBotoes.Ok,, clsMsgBox.eImagens.Ok)
                    Else
                        S_MsgBox("Registro(s) excluído(s): " & ok & vbNewLine &
                                 "Registro(s) não excluído(s): " & erro & vbNewLine &
                                 "Total de Registros:" & tot,
                                 eBotoes.Ok, "Atenção: Alguns registros podem não ter sido excluídos.",
                                 eImagens.Atencao)

                    End If
                    Pesquisar()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Pesquisar()
        Try
            oDataset = pDespesa.PesquisarDespesa(CType(cbStatusFiltro.ObterChaveCombo(), eStatusDespesa),
                                                 CDec(cbMes.ObterChaveCombo()))
            If oDataset.TotalRegistros > 0 Then

                Dim x As String = oDataset("total", 0, 1).ToString

                txtTotalDespesa.Text = x
                txtTotalDespesa.Text = Convert.ToDouble(txtTotalDespesa.Text).ToString("C")

                lvConsulta.PreencheGridDS(oDataset, True, True, False, True, 0, True)

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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregarCombo()
        Try
            Dim col As Collection
            col = New Collection
            col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
            col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
            col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

            cbStatusFiltro.PreencheComboColl(col, PrimeiroValor.Selecione)



            col.Clear()

            Dim data As DateTime

            For i = 1 To 12


                col.Add(New DuplaCombo(i, data.AddMonths(i - 1).ToString("MMMM").ToUpperInvariant))
            Next
            cbMes.PreencheComboColl(col, PrimeiroValor.Selecione)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnStatusPago_Click(sender As Object, e As EventArgs) Handles btnStatusPago.Click
        Dim erro As Decimal
        Dim ok As Decimal
        Dim tot As Decimal
        Dim rDecimal As String
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class