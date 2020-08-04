Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmConta
    Public NovaConta As frmNovaConta
    Public cConta As Decimal
    Public agencia As Decimal
    Public conta As Decimal
    Public saldo As Decimal
    Public rs As SuperDataSet = Nothing


    Private Sub frmConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.Control)
        Cor(CType(gbBotoes, Control), Collor.CinzaMedio)
        Cor(CType(gbDadosConta, Control), Collor.Claro)


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

        ControleBotoes()
    End Sub
    Private Sub frmConta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.conta_Bancaria)
    End Sub
    Private Sub frmConta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub PesquisarConta()
        Dim rSaldo As String = Nothing
        Dim column As String = Nothing
        Try
            rs = pContaBancaria.PesquisarConta()

            column = "BANK"


            If rs.TotalRegistros > 0 Then

                For i = 0 To rs.TotalRegistros - 1

                    dgConta.AdicionaImageColumn(rs, column, Banco(rs("AS_BANCO#200", i).ToString), False)

                Next
            End If

            dgConta.PreencheDataGrid(rs,,,,, True)

            dgConta.Columns(column).DisplayIndex = 2
            dgConta.Columns(column).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            dgConta.Columns(column).Width = 80

            If dgConta.bCarregado Then
                For i = 0 To dgConta.ObterTotalLinhas - 1

                    If rs("Principal", i).ToString = "SIM" Then

                        lblPrincipalConta.Text =
                                    (IIf(String.IsNullOrEmpty(rs("AGÊNCIA", i).ToString) And
                                    String.IsNullOrEmpty(rs("CONTA", i).ToString),
                                    rs("BANCO", i).ToString & " • " & rs("TIPO DE CONTA", i).ToString,
                                    rs("BANCO", i).ToString & " • " &
                                    rs("AGÊNCIA", i).ToString & " • " &
                                    rs("CONTA", i).ToString)).ToString() & " • " &
                                    rs("TIPO DE CONTA", i).ToString

                        picBank.Image = Banco(rs("BANCO", i).ToString)


                    End If

                    rSaldo = dgConta.Rows(i).Cells("Saldo").Value.ToString

                    If rSaldo.Contains("-") Then
                        dgConta.Rows(i).Cells("Saldo").Style.ForeColor = Color.Red
                    Else
                        dgConta.Rows(i).Cells("Saldo").Style.ForeColor = Color.Green
                    End If
                    dgConta.Rows(i).Cells("Saldo").Style.Font = New Font("Verdana", 12, FontStyle.Bold)
                Next
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnEditar_Click_1(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            cConta = dgConta.ObterChave

            NovaConta = New frmNovaConta(cConta)
            NovaConta.ShowDialog()

            If NovaConta.bAlterado Then
                PesquisarConta()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            cConta = dgConta.ObterChave

            If cConta <> 0 Then

                If Mensagem(eTipoMensagem.Question) = eRet.Sim Then

                    If pContaBancaria.DeletarConta(cConta) Then

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

    Private Sub frmConta_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PesquisarConta()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim oXls As SuperXLS
        Try
            oXls = New SuperXLS("Lista de Contas Báncaria")

            If rs.TotalRegistros > 0 Then

                rs.Tables(0).Columns.Remove("Bank")
                rs.Tables(0).Columns.Remove("Id_cConta")

                oXls.Imprimir(rs, "Lista de Contas Báncaria", True, False, True, False)

            Else
                S_MsgBox("Desculpe, nenhum registrado encontrado para exportar para a planilha.",
                         eBotoes.Ok, "Finances Management",
                         eImagens.Info)
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        Finally
            rs.Dispose()
        End Try
    End Sub
End Class