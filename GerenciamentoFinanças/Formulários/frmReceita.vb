Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox

Public Class frmReceita
    Public oform As frmNovaReceita
    Public cReceita As Decimal = Nothing
    Public oDataset As SuperDataSet = Nothing
    Public cChecados As Decimal = Nothing

    Private Sub frmReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(Me, Collor.CinzaEscuro)
        Cor(CType(gbBotoes, Control), Collor.CinzaAzulado)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnAddReceita, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExporta, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CarregaCombo()
        Pesquisar()
        ResizeTabCtrl()
    End Sub
    Private Sub frmReceita_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmReceita_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Receita)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try

            cChecados = dgReceita.ObterTodosChecados

            If cChecados > 0 Then

                cReceita = dgReceita.ObterChave

                If cReceita <> 0 Then
                    oform = New frmNovaReceita(cReceita)
                    oform.ShowDialog()

                    If oform.DialogResult = DialogResult.OK Then
                        Pesquisar()
                    End If
                Else
                    S_MsgBox("Desculpe, não foi possível localizar este registro.",
                         eBotoes.Ok,
                         "",,
                         eImagens.Cancel)
                End If
            Else
                S_MsgBox("Nenhum registro selecionado.",
                         eBotoes.Ok,
                         "Selecione um registro.",,
                         eImagens.Info)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[btnEditar_Click]")
        End Try
    End Sub
    Public Sub Pesquisar()
        Dim TOTAL As String
        Dim cAno As Decimal = Nothing
        Try
            oDataset = New SuperDataSet()

            If CDec(cbAno.ObterChaveCombo) <> 0 Then
                cAno = CDec(cbAno.ObterDescricaoCombo)
            Else
                cAno = 0
            End If

            oDataset = pReceita.PesquisarReceita(CDec(cbMes.ObterChaveCombo()),
                                                 cAno,
                                                 CDec(cbContaFiltro.ObterChaveCombo))

            If oDataset IsNot Nothing Then

                TOTAL = oDataset("total", 0, 1).ToString

                txtTotalReceita.Text = TOTAL

                If TOTAL <> "" Then
                    txtTotalReceita.Text = Convert.ToDouble(txtTotalReceita.Text).ToString("C")
                End If

                dgReceita.PreencheDataGrid(oDataset,,, txtLetreiroReceita)

            ElseIf oDataset Is Nothing OrElse oDataset.TotalRegistros = 0 Then
                S_MsgBox("Nenhum registro encontrado.", eBotoes.Ok, "",, eImagens.Info)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[Pesquisar]")
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnAddReceita_Click(sender As Object, e As EventArgs) Handles btnAddReceita.Click
        Try
            oform = New frmNovaReceita(0)
            oform.ShowDialog()

            If oform.DialogResult = DialogResult.OK Then
                Pesquisar()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[btnAddReceita_Click]")
        End Try
    End Sub
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim rReceita As String = Nothing
        Dim cOk As Integer = Nothing
        Dim cErro As Integer = Nothing
        Try
            cChecados = dgReceita.ObterTodosChecados

            If cChecados = 1 Then

                cReceita = dgReceita.ObterChave

                If cReceita <> 0 Then

                    If pReceita.DeletarReceita(cReceita) Then

                        Mensagem(eTipoMensagem.OK)
                        Pesquisar()
                    Else
                        Mensagem(eTipoMensagem.Erro)
                    End If
                End If

            ElseIf cChecados > 1 Then

                rReceita = dgReceita.ObterTodasChaves

                For Each codigo In rReceita.Split(CChar(";"))

                    If pReceita.DeletarReceita(CDec(codigo)) Then
                        cOk += 1
                    Else
                        cErro += 1
                    End If
                Next

                If cErro = 0 And cOk <> 0 Then

                    Mensagem(eTipoMensagem.OK, CInt(cChecados))
                    Pesquisar()

                ElseIf cErro <> 0 Then

                    Mensagem(eTipoMensagem.Erro, CInt(cChecados), cOk, cErro)
                    Pesquisar()
                End If
            Else
                S_MsgBox("Nenhum registro selecionado.",
                         eBotoes.Ok,,,
                         eImagens.Info)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[btnExcluir_Click]")
        End Try
    End Sub
    Private Sub CarregaCombo()
        Dim col As Collection = Nothing
        Dim mes As Date
        Try
            col = New Collection
            oDataset = New SuperDataSet()

            For i = 1 To 12
                col.Add(New DuplaCombo(i, mes.AddMonths(i - 1).ToString("MMMM").ToUpper))
            Next

            cbMes.PreencheComboColl(col, PrimeiroValor.Selecione)

            col.Clear()

            mes = Now.AddYears(-4)

            For i = 1 To 7
                col.Add(New DuplaCombo(i, mes.AddYears(i).ToString("yyyy")))
            Next

            cbAno.PreencheComboColl(col, PrimeiroValor.Todos)
            cbAno.PosicionaRegistroCombo(4)

            oDataset = pContaBancaria.CarregarConta()

            cbContaFiltro.PreencheComboDS(oDataset, "rBanco", "cConta", PrimeiroValor.Selecione)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[CarregaCombo]")
        Finally
            If oDataSet IsNot Nothing Then
                oDataSet.Dispose()
            End If
            col.Clear()
        End Try
    End Sub

    Private Sub ControleBotoes()
        Try
            cChecados = dgReceita.ObterTodosChecados

            If cChecados = 1 Then
                btnEditar.Enabled = True
                btnExcluir.Enabled = True

            ElseIf cChecados > 1 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = True

            Else
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[ControleBotoes]")
        End Try
    End Sub

    Private Sub dgReceita_SelectionChanged(sender As Object, e As EventArgs) Handles dgReceita.SelectionChanged
        Try
            If dgReceita.bCarregado And chkList.Checked = False Then
                ControleBotoes()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[dgReceita_SelectionChanged]")
        End Try
    End Sub

    Private Sub chkList_CheckedChanged(sender As Object, e As EventArgs) Handles chkList.CheckedChanged
        Try

            dgReceita.MarcaDesmarcaTodos(chkList)

            ControleBotoes()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[chkList_CheckedChanged]")
        End Try
    End Sub

    Private Sub btnExporta_Click(sender As Object, e As EventArgs) Handles btnExporta.Click
        Dim oXls As SuperXLS
        Try
            oXls = New SuperXLS("Lista de Receitas")

            If oDataset IsNot Nothing Then
                oXls.Imprimir(oDataset, "", True, True, True, False)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[btnExporta_Click]")
        Finally
            If oDataset IsNot Nothing Then
                oDataset.Dispose()
            End If
        End Try
    End Sub

    Private Sub cbContaFiltro_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbContaFiltro.SelectionChangeCommitted
        Try
            If cbContaFiltro.Items.Count > 0 Then
                Pesquisar()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[cbContaFiltro_SelectionChangeCommitted]")
        End Try
    End Sub

    Private Sub cbMes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbMes.SelectionChangeCommitted
        Try
            If cbMes.Items.Count > 0 Then
                Pesquisar()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[cbMes_SelectionChangeCommitted]")
        End Try
    End Sub

    Private Sub cbAno_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbAno.SelectionChangeCommitted
        Try
            If cbAno.Items.Count > 0 Then
                Pesquisar()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[cbAno_SelectionChangeCommitted]")
        End Try
    End Sub

    Private Sub frmReceita_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ResizeTabCtrl()
    End Sub
    Private Sub ResizeTabCtrl()
        Try
            tbConsulta.ItemSize = New Drawing.Size(tbConsulta.Size.Width, 49)


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmReceita: " & ex.Message & "[ResizeTabCtrl]")
        End Try
    End Sub
End Class