Imports GFT.Util
Imports GFT.Util.SuperComboBox
Imports GFT.Util.clsMsgBox
Public Class frmConsulta
    Public cTipo As Decimal = Nothing
    Public oDataset As SuperDataSet = Nothing

    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.Control)
        Cor(CType(gbBotoes, Control), Collor.CinzaMedio)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Branco, Color.Black, SystemColors.ControlLightLight, Color.WhiteSmoke)

        'CorTab(tbConsulta, Collor.Claro)

        centralizarGrupoTab(tabCtrlConsulta)
        centralizarGrupoBotoes(gbBotoes)

        CarregaCombo()
        ResizeTab()
    End Sub
    Private Sub frmConsulta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Consulta)
    End Sub
    Private Sub frmConsulta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CarregaCombo()
        Dim rs As SuperDataSet = Nothing
        Dim col As Collection = Nothing
        Try
            col = New Collection()
            rs = pContaBancaria.CarregarConta

            cbConta.PreencheComboDS(rs, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

            col.Add(New DuplaCombo(1, "Receitas"),)
            col.Add(New DuplaCombo(2, "Despesas"))

            cbTipoFiltro.PreencheComboColl(col, PrimeiroValor.Todos)

            dtInicialFiltro.Value = New Date(Year(Now.Date), Month(Now.Date), 1)

            dtFinalFiltro.Value = New Date(Year(Now.Date),
                                           Month(Now.Date),
                                           DateTime.DaysInMonth(Year(Now.Date), Month(Now.Date)))
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        Finally
            rs.Dispose()
            col.Clear()
        End Try
    End Sub

    Private Sub Pesquisar()
        Try
            oDataset = New SuperDataSet()

            cTipo = CDec(cbTipoFiltro.ObterChaveCombo)

            oDataset = pConsulta.Pesquisar(MinHora(dtInicialFiltro.Value),
                                           MaxHora(dtFinalFiltro.Value),
                                           CDec(cbConta.ObterChaveCombo),
                                           cTipo)

            If oDataset.TotalRegistros > 0 Then
                For i = 0 To oDataset.TotalRegistros - 1
                    dgExtrato.AdicionaImageColumn(oDataset, "Conta", Banco(oDataset("as_Banco", i).ToString), False)
                Next

            End If


            dgExtrato.PreencheDataGrid(oDataset,,, txtLetreiro)
            dgExtrato.Columns("rTipo").Visible = False


            If oDataset.TotalRegistros > 0 Then

                If cTipo = 1 Then
                    For i = 0 To oDataset.TotalRegistros - 1
                        dgExtrato.Rows(i).Cells("Valor").Style.ForeColor = Color.Green
                    Next

                ElseIf cTipo = 2 Then
                    For i = 0 To oDataset.TotalRegistros - 1
                        dgExtrato.Rows(i).Cells("Valor").Style.ForeColor = Color.Red
                    Next

                Else
                    For i = 0 To oDataset.TotalRegistros - 1

                        If dgExtrato.Rows(i).Cells("rTipo").Value.ToString = "Despesa" Then
                            dgExtrato.Rows(i).Cells("Valor").Style.ForeColor = Color.Red
                        Else
                            dgExtrato.Rows(i).Cells("Valor").Style.ForeColor = Color.Green
                        End If
                    Next
                End If

                dgExtrato.Columns("Banco").Visible = False
                dgExtrato.Columns("Conta").Width = 150
                dgExtrato.Columns("Conta").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub frmConsulta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Try
            Pesquisar()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS
        Try
            oXls = New SuperXLS("Extrato")

            If oDataset IsNot Nothing Then
                oDataset.Tables(0).Columns.Remove("rTipo")

                oXls.Imprimir(oDataset, "Extrato Báncario", True, True, True, False)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        Finally
            If oDataset IsNot Nothing Then
                oDataset.Dispose()
            End If
        End Try
    End Sub

    Private Sub btnFechar_Click_1(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub frmConsulta_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeTab
    End Sub

    Private Sub ResizeTab()
        Try
            tabCtrlConsulta.ItemSize = New Drawing.Size(tabCtrlConsulta.Size.Width, 57)
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmConta: " & ex.Message & "[frmConta_Resize]")
        End Try
    End Sub
End Class