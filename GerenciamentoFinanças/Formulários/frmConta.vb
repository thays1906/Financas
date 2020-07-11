Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmConta
    Public codigo As Decimal
    Public agencia As Decimal
    Public conta As Decimal
    Public saldo As Decimal


    Private Sub frmConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaClaro)
        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnAddConta, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        Cor(CType(gbBotoes, Control), Collor.CinzaEscuro)
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tabCtrlConta)
        centralizarGrupoBotoes(gbDadosConta)
        centralizarGrupoBotoes(gbListConta)
        PesquisarConta()
    End Sub
    Private Sub frmConta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.conta_Bancaria)
    End Sub
    Private Sub frmConta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub PesquisarConta()
        Dim rs As SuperDataSet
        Try
            rs = pContaBancaria.PesquisarConta()

            If rs.TotalRegistros > 0 Then

                lvConsulta.PreencheGridDS(rs, True, True, False, True, 0, True)

                CorList(lvConsulta)

            End If

            For i = 0 To lvConsulta.ObterTotalLinhas - 1

                If rs("as_Principal", i).ToString = "SIM" Then

                    txtPrincipalConta.Text =
                                    (IIf(String.IsNullOrEmpty(rs("as_AGÊNCIA#150", i).ToString) And
                                    String.IsNullOrEmpty(rs("as_CONTA#250", i).ToString),
                                    rs("as_BANCO#200", i).ToString,
                                    rs("as_BANCO#200", i).ToString & " - " &
                                    rs("as_AGÊNCIA#150", i).ToString & " - " &
                                    rs("as_CONTA#250", i).ToString)).ToString()

                    txtPrincipalTipo.Text = rs("as_TIPO_DE_CONTA", i).ToString

                    If rs("as_BANCO#200", i).ToString = "Nubank" Then

                        picBank.Image = My.Resources.iconNubank_fw

                    ElseIf rs("as_BANCO#200", i).ToString = "Bradesco" Then

                        picBank.Image = My.Resources.iconBradesco

                    ElseIf rs("as_BANCO#200", i).ToString = "Itau" Then

                        picBank.Image = My.Resources.iconItau_fw

                    ElseIf rs("as_BANCO#200", i).ToString = "Santander" Then

                        picBank.Image = My.Resources.iconSantander

                    ElseIf rs("as_BANCO#200", i).ToString = "Pic Pay" Then

                        picBank.Image = My.Resources.iconPicPay

                    ElseIf rs("as_BANCO#200", i).ToString = "MercadoPago" Then

                        picBank.Image = My.Resources.iconMercadoPago_fw
                    Else
                        picBank.Image = My.Resources.iconBank
                    End If
                End If
                If lvConsulta.Items(i).SubItems(4).Text.Contains(CChar("-")) Then

                    lvConsulta.Items(i).SubItems(4).ForeColor = Color.Red
                Else
                    lvConsulta.Items(i).SubItems(4).ForeColor = Color.Green
                End If
                lvConsulta.Items(i).SubItems(4).Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold)
            Next
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim conta As frmNovaConta
        Dim cConta As Decimal
        Try
            cConta = lvConsulta.ObterChave

            conta = New frmNovaConta(cConta)
            conta.ShowDialog()

            PesquisarConta()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If lvConsulta.SelectedItems.Count > 0 Then

                codigo = lvConsulta.ObterChave

                If codigo <> 0 Then

                    If S_MsgBox("Deseja realmente excluir sua Conta Báncaria?" & vbNewLine &
                            "Ao deletar esta conta, o saldo também será perdido.",
                            eBotoes.SimNao, "Exclusão de Conta.",,
                            eImagens.Ok) = eRet.Sim Then

                        If pContaBancaria.DeletarConta(codigo) Then
                            S_MsgBox("Conta Báncaria excluída com sucesso!",
                                 eBotoes.Ok, "Exclusão de Conta.",, eImagens.Ok)
                        End If
                    End If
                Else
                    S_MsgBox("Falha ao excluir conta báncaria.",
                            eBotoes.Ok, "Exclusão de Conta.",, eImagens.Cancel)
                End If
            Else
                S_MsgBox("Selecione um registro.",
                        eBotoes.Ok, "Exclusão de Conta.",, eImagens.Atencao)

            End If

            PesquisarConta()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnAddConta_Click(sender As Object, e As EventArgs) Handles btnAddConta.Click
        Dim conta As frmNovaConta
        Try
            'Dim teste = New Form1
            'teste.Show()
            Me.Enabled = False
            conta = New frmNovaConta(0)
            conta.ShowDialog()
            Me.Enabled = True

            PesquisarConta()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        PesquisarConta()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class