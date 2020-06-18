﻿Imports GFT.Util
Imports GFT.Util.SuperComboBox
Imports GFT.Util.clsMsgBox
Public Class frmDespesa
    Public oDataset As SuperDataSet
    Public Despesa As frmNovaDespesa
    Public cDespesa As Decimal
    Public btn As Decimal
    Public erro As Decimal
    Public ok As Decimal
    Public tot As Decimal
    Public cControleParcelamento As Decimal
    Sub New(Optional ByVal _cControle As Decimal = 0)

        InitializeComponent()

        cControleParcelamento = _cControle
        DetalharParcelamento()

    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.Preto)
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tabCtrlDespesa)
        CarregarCombo()
        Pesquisar()
        ControleFormulario()
    End Sub
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
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub CarregarCombo()
        Dim col As Collection
        Dim data As DateTime
        Try
            col = New Collection
            col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
            col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
            col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

            cbStatusFiltro.PreencheComboColl(col, PrimeiroValor.Selecione)

            col.Clear()

            For i = 1 To 12
                col.Add(New DuplaCombo(i, data.AddMonths(i - 1).ToString("MMMM").ToUpperInvariant))
            Next

            cbMes.PreencheComboColl(col, PrimeiroValor.Selecione)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
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
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub ControleFormulario()
        Dim rDespesa As String
        Try
            btnStatusPago.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False

            If lvConsulta.CheckedItems.Count = 1 Then
                btnStatusPago.Enabled = True
                btnEditar.Enabled = True
                btnExcluir.Enabled = True
            End If
            If lvConsulta.CheckedItems.Count > 1 Then
                btnStatusPago.Enabled = True
                btnExcluir.Enabled = True
            End If

            If btn = eAcao.Novo Then
                Despesa = New frmNovaDespesa(cDespesa)
                Despesa.ShowDialog()
                btn = 0
                Pesquisar()
            End If
            If btn = eAcao.Editar Then
                If lvConsulta.CheckedItems.Count = 1 Then

                    cDespesa = lvConsulta.ObterChave()

                    If cDespesa <> 0 Then
                        Despesa = New frmNovaDespesa(cDespesa)
                        Despesa.ShowDialog()
                        Pesquisar()
                    Else
                        S_MsgBox("Erro ao carregar registro.", eBotoes.Ok,,, eImagens.Cancel)
                    End If
                End If
                btn = 0
            End If

            If btn = eAcao.Excluir Then
                If lvConsulta.CheckedItems.Count > 1 Then

                    tot = lvConsulta.ObterTotalChecados

                    If Mensagem(eTipoMensagem.Question) = eRet.Sim Then

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
                            Mensagem(eTipoMensagem.OK)
                            Pesquisar()
                        Else
                            Mensagem(eTipoMensagem.Erro)
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
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Function Mensagem(ByVal tipoMsg As eTipoMensagem) As eRet
        If tipoMsg = eTipoMensagem.Question Then
            If S_MsgBox("Deseja excluir " & tot & " despesas?",
                                eBotoes.SimNao,,,
                                eImagens.Interrogacao) = eRet.Sim Then
                Return eRet.Sim
            Else
                Return eRet.Nao
            End If
        ElseIf tipoMsg = eTipoMensagem.OK Then
            S_MsgBox("Despesa(s) excluída(s) com sucesso!",
                    eBotoes.Ok, "Exclusão de registro.",
                    eImagens.Ok)
        ElseIf tipoMsg = eTipoMensagem.Erro Then
            S_MsgBox("Registro(s) excluído(s): " & ok & vbNewLine &
                    "Registro(s) não excluído(s): " & erro & vbNewLine &
                    "Total de Registros:" & tot,
                    eBotoes.Ok, "Atenção: Alguns registros podem não ter sido excluídos.",
                    eImagens.Atencao)
        End If
        Return Nothing
    End Function
    Private Sub lvConsulta_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lvConsulta.ItemChecked
        ControleFormulario()
    End Sub
    Private Sub DetalharParcelamento()
        Dim rs As SuperDataSet
        Dim txt As TextBox
        Dim text As TextBox
        Dim Qtde As Decimal
        Try
            tabCtrlDespesa.SelectedIndex = 2
            tabCtrlDespesa.SelectedTab = tabDetalhe

            'If cControleParcelamento <> 0 Then
            '    rs = pControleParcelamento.ObterTodas(cControleParcelamento)
            '    If rs.TotalRegistros > 0 Then

            '        tabCtrlDespesa.SelectedTab = tabDetalhe
            '        text = New TextBox
            '        text.Name = "blabla"
            '        text.SetBounds(408, 132, 100, 20)

            '        Me.Controls.Add(text)

            '        Qtde = CDec(rs("cQtdeParcela"))

            '        For i = 0 To Qtde - 1
            '            txt = New TextBox
            '            'Controls.Add(txt)
            '            txt.Name = btn & i
            '            txt.Text = "ESTOU AQUI"
            '            txt.BackColor = Color.Black
            '            txt.ForeColor = Color.White
            '            txt.SetBounds(txtValor1.Location.X, txtValor1.Location.Y + 39, 100, 25)
            '            tabCtrlDespesa.TabPages(2).Controls.Add(txt)

            '            txt.Visible = True
            '            i = 4
            '        Next
            '    End If
            'End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        tabCtrlDespesa.SelectedTab = tabDetalhe
    End Sub
End Class