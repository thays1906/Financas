Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmConta
    Public NovaConta As frmNovaConta
    Public codigo As Decimal
    Public agencia As Decimal
    Public conta As Decimal
    Public saldo As Decimal


    Private Sub frmConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaClaro)
        Cor(CType(gbBotoes, Control), Collor.CinzaEscuro)

        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnAddConta, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnEditar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExcluir, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tabCtrlConta)
        centralizarGrupoBotoes(gbDadosConta)
        centralizarGrupoBotoes(gbListConta)
        'ControleBotoes()
        PesquisarConta()
    End Sub
    Private Sub frmConta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.conta_Bancaria)
    End Sub
    Private Sub frmConta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub PesquisarConta()
        Dim rs As SuperDataSet = Nothing
        Try
            rs = pContaBancaria.PesquisarConta()

            If rs.TotalRegistros > 0 Then

                'lvConsulta.PreencheGridDS(rs, True, True, False, True, 0, True)
                dgConta.PreencheDataGrid(rs)
                CorList(lvConsulta)

            End If

            'For i = 0 To lvConsulta.ObterTotalLinhas - 1

            '    If rs("as_Principal", i).ToString = "SIM" Then

            '        txtPrincipalConta.Text =
            '                        (IIf(String.IsNullOrEmpty(rs("as_AGÊNCIA#150", i).ToString) And
            '                        String.IsNullOrEmpty(rs("as_CONTA#250", i).ToString),
            '                        rs("as_BANCO#200", i).ToString,
            '                        rs("as_BANCO#200", i).ToString & " - " &
            '                        rs("as_AGÊNCIA#150", i).ToString & " - " &
            '                        rs("as_CONTA#250", i).ToString)).ToString()

            '        txtPrincipalTipo.Text = rs("as_TIPO_DE_CONTA", i).ToString

            '        picBank.Image = Banco(rs("as_BANCO#200", i).ToString)

            '        If picBank.Image.Width = 71 Then
            '            picBank.Left = 5
            '        Else
            '            picBank.Location = New Point(27, 70)
            '        End If

            '    End If

            '    If lvConsulta.Items(i).SubItems(4).Text.Contains(CChar("-")) Then

            '        lvConsulta.Items(i).SubItems(4).ForeColor = Color.Red
            '    Else
            '        lvConsulta.Items(i).SubItems(4).ForeColor = Color.Green
            '    End If
            '    lvConsulta.Items(i).SubItems(4).Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold)
            'Next
            'lvConsulta.Refresh()
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        Finally
            rs.Dispose()
        End Try
    End Sub
    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim cConta As Decimal
        Try
            'cConta = lvConsulta.ObterChave
            cConta = dgConta.ObterChave

            NovaConta = New frmNovaConta(cConta)
            NovaConta.ShowDialog()

            'Verificar se foi alterado
            If NovaConta.bAlterado Then
                PesquisarConta()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try

            If dgConta.ObterChave <> 0 Then

                If Mensagem(eTipoMensagem.Question) = eRet.Sim Then

                    If pContaBancaria.DeletarConta(dgConta.ObterChave) Then

                        Mensagem(eTipoMensagem.OK)
                        PesquisarConta()

                    Else
                        Mensagem(eTipoMensagem.Erro)
                    End If
                End If

            Else
                S_MsgBox("Nenhum registro selecionado.",
                        eBotoes.Ok, "Exclusão de Conta.",,
                        eImagens.Atencao)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnAddConta_Click(sender As Object, e As EventArgs) Handles btnAddConta.Click
        Try
            Me.Enabled = False
            NovaConta = New frmNovaConta(0)
            NovaConta.ShowDialog()
            Me.Enabled = True

            If NovaConta.bAlterado Then
                PesquisarConta()
            End If

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
    Private Sub ControleBotoes()
        Try
            If dgConta.ObterTodosChecados = 0 Then
                btnEditar.Enabled = False
                btnExcluir.Enabled = False
            Else
                btnEditar.Enabled = True
                btnExcluir.Enabled = True
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub dgConta_SelectionChanged(sender As Object, e As EventArgs) Handles dgConta.SelectionChanged
        Try
            If dgConta.bCarregado Then
                ControleBotoes()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub
End Class