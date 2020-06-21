Imports GFT.Util
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
        'DetalharParcelamento()
    End Sub
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDespesa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tabCtrlDespesa)
        CarregarCombo()
        Pesquisar()
        ControleFormulario()
        CorButton(btnPagar, Collor.Gelo, Color.Black, Color.WhiteSmoke, Color.LightGray)
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
                        cControleParcelamento = CDec(Despesa.cControleParcelamento)
                        DetalharParcelamento()
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
        Dim gbParcela As GroupBox
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
        Try
            'Status = 1 Pago Status = 2 Pendente - 3 Atrasado

            tabCtrlDespesa.SelectedIndex = 2

            If cControleParcelamento <> 0 Then

                rs = pControleParcelamento.ObterTodas(cControleParcelamento)

                If rs.TotalRegistros > 0 Then

                    txtTitulo.Text = rs("rDescricao").ToString
                    dtDespesaDetalhe.Value = CDate(rs("dtRegistro"))

                    Qtde = CInt(rs("cQtdeParcela"))

                    'CRIAR UM IF PARA VER QUANTOS TEXT VAI GERAR DE ACORDOR COMAS PARCELAS

                    gbParcela = New GroupBox

                    For i = 0 To Qtde - 1
                        chk = New CheckBox
                        btn = New Button
                        txt = New TextBox
                        data = New Label
                        parcela = New Label




                        CorButton(btn, Collor.Nenhuma, Color.Transparent,
                                  Color.Transparent, Color.Transparent)

                        cStatus = CInt(rs("cStatus", i))
                        cNumParcela = CInt(rs("cNumeroParcela", i))

                        If cStatus = 1 Then
                            btn.Image = My.Resources.iconPago
                        ElseIf cStatus = 2 Then
                            btn.Image = My.Resources.iconPendente
                        ElseIf cStatus = 3 Then
                            btn.Image = My.Resources.iconAtrasado
                        End If

                        If i > 0 Then
                            Y = yy
                        Else
                            X = 30
                            Y = 41
                        End If

                        If Qtde > 6 Then

                            gbDetalhe.Height = 600

                            If i > 5 Then
                                X = 317
                            End If

                            If i > 11 Then
                                X = 572
                            End If

                            If i > 17 Then
                                X = 816
                            End If
                        End If

                        'GROUPBOX
                        gbParcela.Name = "gbParcela" & i.ToString
                        gbParcela.SetBounds(57, 139, 210, 200)
                        gbParcela.Text = ""
                        gbParcela.BackColor = Color.WhiteSmoke
                        gbParcela.Visible = True

                        'LABEL DATA

                        data.Name = "lblData" & i.ToString
                        data.Text = rs("dtRegistro", i).ToString
                        data.Font = New Font(Font.FontFamily, FontStyle.Bold)
                        data.SetBounds(X - 10, Y - 20, 100, 25)
                        data.Visible = True
                        gbParcela.Controls.Add(data)
                        data.BringToFront()

                        'LABEL PARCELA
                        parcela.Name = "lblparcela" & cNumParcela.ToString
                        parcela.Text = "(" & cNumParcela.ToString & "/" & Qtde.ToString & ")"
                        parcela.Font = New Font(Font.FontFamily, FontStyle.Bold)
                        parcela.SetBounds(X + 30, Y - 20, 100, 25)
                        parcela.Visible = True
                        gbParcela.Controls.Add(parcela)
                        parcela.BringToFront()

                        'CHK
                        chk.Name = CInt(rs("cDespesa", i)).ToString
                        chk.SetBounds(X - 10, Y + 5, 16, 16)
                        chk.Visible = True
                        gbParcela.Controls.Add(chk)
                        chk.BringToFront()


                        'BOTAO STATUS PAGO (OK)
                        btn.Name = "btn" & i
                        btn.SetBounds(X + 90, Y - 5, 35, 33)
                        btn.Visible = True
                        gbParcela.Controls.Add(btn)
                        btn.BringToFront()


                        'TEXT PARCELA
                        txt.Name = "Parcela" & CInt(rs("cNumeroParcela", i)).ToString
                        txt.Text = Convert.ToDouble(rs("cValor", i)).ToString("C")
                        txt.ForeColor = Color.Black
                        txt.TabIndex = CInt(2 + i)
                        txt.SetBounds(X, Y, 100, 25)
                        txt.Visible = True
                        gbParcela.Controls.Add(txt)
                        txt.BringToFront()




                        If i = 5 Then
                            yy = 139 + 55
                            gbParcela = New GroupBox
                        ElseIf i = 11 Then
                            yy = 139 + 55
                            gbParcela = New GroupBox
                        ElseIf i = 17 Then
                            yy = 139 + 55
                            gbParcela = New GroupBox
                        Else
                            yy = txt.Location.Y + 55
                        End If
                        gbDetalhe.Controls.Add(gbParcela)
                    Next
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
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
End Class