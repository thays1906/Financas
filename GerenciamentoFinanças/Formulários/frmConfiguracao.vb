
Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmConfiguracao
    Public form As frmCadastroCategoria
    Public codigo As Decimal
    Public agencia As Decimal
    Public conta As Decimal
    Public saldo As Decimal

    Private Sub frmConfiguracao_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmConfiguracao_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Configuracao)
    End Sub

    Private Sub frmConfiguracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaBranco)
        CorButton(btnFecharConfig, Collor.CinzaClaro, Color.Black, Color.Gainsboro, Color.LightGray)
        centralizarGrupoTab(tabCtrlConfig)
        centralizarGrupoBotoes(gbCadastroDespesa)
        centralizarGrupoBotoes(gbTodasDespesa)
        centralizarGrupoBotoes(gbBotoes)

        CarregarList()
        CarregarListParcelas()
        PesquisarConta()
    End Sub

    Public Sub CarregarCategoria()
        Dim rsCategoria As SuperDataSet
        Try
            rsCategoria = pCategoriaDespesa.CarregarCategoria()

            If rsCategoria.TotalRegistros > 0 Then

                lvCategoriaDespesa.PreencheGridDS(rsCategoria, True, True, False, True)

                CorList(lvCategoriaDespesa)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Public Sub CarregarFormaPagamento()
        Dim rsFormaPagamento As SuperDataSet

        Try
            rsFormaPagamento = pFormaPagamento.CarregarFormaPagamento()

            If rsFormaPagamento.TotalRegistros > 0 Then
                lvFormaPagamento.PreencheGridDS(rsFormaPagamento, True, True, False, True)
            End If

            CorList(lvFormaPagamento)


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Public Sub CarregarList(Optional ByVal list As String = "")
        Try
            CarregarCategoria()
            CarregarFormaPagamento()
            CarregarCategoriaReceita()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If VerificaCampos(txtNovaCategoriaDespesa) Then

                pCategoriaDespesa.IncluirCategoria(txtNovaCategoriaDespesa.Text)

                S_MsgBox("Categoria de Despesa incluída com sucesso!", eBotoes.Ok,
                         "",, eImagens.Ok)
                txtNovaCategoriaDespesa.Text = ""
            End If
            CarregarList()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Function VerificaCampos(ByRef txt As SuperTextBox) As Boolean
        Try
            If txt.VerificaObrigatorio = False Then
                clsMsgBox.S_MsgBox("Favor informar no campo a categoria que deseja cadastrar!",
                clsMsgBox.eBotoes.Ok, "",, clsMsgBox.eImagens.Atencao)
                Return False
            End If
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Private Sub btnEditarPag_Click(sender As Object, e As EventArgs) Handles btnEditarPag.Click
        Try

            codigo = lvFormaPagamento.ObterChave()

            If codigo = 0 Then
                S_MsgBox("Não foi possível localizar registro.", eBotoes.Ok,,, eImagens.Cancel)
            Else

                form = New frmCadastroCategoria(codigo, eCadastroCategoria.FormaPagamento)

                form.ShowDialog()
                CarregarFormaPagamento()

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnEditarDespesa_Click(sender As Object, e As EventArgs) Handles btnEditarDespesa.Click
        Try

            codigo = lvCategoriaDespesa.ObterChave()

            form = New frmCadastroCategoria(codigo, eCadastroCategoria.CategoriaDespesa)

            form.ShowDialog()
            CarregarCategoria()

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluirDespesa_Click(sender As Object, e As EventArgs) Handles btnExcluirDespesa.Click
        Try

            If lvCategoriaDespesa.SelectedItems.Count > 0 Then

                codigo = lvCategoriaDespesa.ObterChave()

                If codigo = 0 Then
                    S_MsgBox("Erro ao prosseguir com aoperação. Tente novamente.", eBotoes.Ok,,, eImagens.Cancel)
                Else
                    If S_MsgBox("Deseja realmente excluir categoria?", eBotoes.SimNao,,, eImagens.Interrogacao) = eRet.Sim Then

                        pCategoriaDespesa.DeletarCategoria(codigo)

                        S_MsgBox("Registro excluído com sucesso!", eBotoes.Ok,,, eImagens.Ok)

                        CarregarCategoria()
                    End If
                End If
            Else
                S_MsgBox("Selecione o registro que deseja excluir.", eBotoes.Ok,,, eImagens.Atencao)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluirPag_Click(sender As Object, e As EventArgs) Handles btnExcluirPag.Click
        Try

            If lvFormaPagamento.SelectedItems.Count > 0 Then

                codigo = lvFormaPagamento.ObterChave

                If codigo = 0 Then
                    S_MsgBox("Erro ao prosseguir com aoperação. Tente novamente.", eBotoes.Ok,,, eImagens.Cancel)

                Else

                    If S_MsgBox("Deseja realmente excluir forma de pagamento?",
                                eBotoes.SimNao,,, eImagens.Interrogacao) = eRet.Sim Then

                        pFormaPagamento.DeletarFormaPagamento(codigo)

                        S_MsgBox("Registro excluído com sucesso!", eBotoes.Ok,,, eImagens.Ok)

                        CarregarFormaPagamento()

                    End If
                End If
            Else
                S_MsgBox("Selecione o registro que deseja excluir.", eBotoes.Ok,,, eImagens.Atencao)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnAddPag_Click(sender As Object, e As EventArgs) Handles btnAddPag.Click
        Try
            If txtNovaFormaPag.Text <> "" Then

                If pFormaPagamento.IncluirFormaPagamento(txtNovaFormaPag.Text) = True Then
                    S_MsgBox("Registro incluído com sucesso", eBotoes.Ok,,, eImagens.Ok)
                    CarregarFormaPagamento()
                    txtNovaFormaPag.Text = ""
                Else
                    S_MsgBox("Erro ao cadastrar registro.", eBotoes.Ok,,, eImagens.Cancel)
                End If

            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub


    '----------------------------------------------
    'Tab Conta Bancaria
    '----------------------------------------------
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
    Private Sub PesquisarConta()
        Dim rs As SuperDataSet
        Try
            rs = pContaBancaria.PesquisarConta()

            If rs.TotalRegistros > 0 Then

                lvConsulta.PreencheGridDS(rs, True, True, False, True, 0, True)

                CorList(lvConsulta)
                lvConsulta.Alignment = ListViewAlignment.Top
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    '---------------------------------------------
    'TAB Parcelamento
    '---------------------------------------------
    Private Sub CarregarListParcelas()
        Dim rsParcelas As SuperDataSet
        Try
            rsParcelas = pParcelamento.CarregarGrid()

            If rsParcelas.TotalRegistros > 0 Then
                lvParcela.PreencheGridDS(rsParcelas, True, True, False, True)
                CorList(lvParcela)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub btnCadastrarParc_Click(sender As Object, e As EventArgs) Handles btnCadastrarParc.Click
        Try
            If IsNumeric(txtQtdeParcela.Text) Then

                If pParcelamento.Inserir(CDec(txtQtdeParcela.Text)) = True Then
                    S_MsgBox("Cadastrado com sucesso.", eBotoes.Ok,,, eImagens.Ok)
                    txtQtdeParcela.Text = ""
                    CarregarListParcelas()
                Else
                    S_MsgBox("Não foi possível cadastrar novo parâmetro. Tente Novamente..", eBotoes.Ok,,, eImagens.Cancel)

                End If

            Else
                S_MsgBox("Insira um número válido para a quantidade de parcelas.", eBotoes.Ok,,, eImagens.Atencao)
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnSalvarParcela_Click(sender As Object, e As EventArgs) Handles btnSalvarParcela.Click
        Dim cParcelamento As Decimal
        Try
            cParcelamento = lvParcela.ObterChave()

            If cParcelamento <> 0 Then
                If pParcelamento.Alterar(cParcelamento, eStatus.Ativo) = True Then
                    S_MsgBox("Parametrização alterada com sucesso.", eBotoes.Ok,,, eImagens.Ok)
                    CarregarListParcelas()
                Else
                    S_MsgBox("Falha ao modificar parametrização", eBotoes.Ok,,, eImagens.Cancel)
                End If
            Else
                S_MsgBox("Falha ao modificar parametrização", eBotoes.Ok,,, eImagens.Cancel)

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluirParcela_Click(sender As Object, e As EventArgs) Handles btnExcluirParcela.Click
        Dim cParcelamento As Decimal
        Try
            cParcelamento = lvParcela.ObterChave

            pParcelamento.Deletar(cParcelamento)
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    '-----------------------------------------------
    'TAB CATEGORIA DE RECEITA
    '-----------------------------------------------
    Private Sub btnAdicionarReceita_Click(sender As Object, e As EventArgs) Handles btnAdicionarReceita.Click
        Try
            If VerificaCampos(txtNovaReceita) Then

                If pTipoReceita.InserirTipoReceita(txtNovaReceita.Text) Then
                    S_MsgBox("Categoria adicionada com sucesso!", eBotoes.Ok,
                             "Categoria de Receita",, eImagens.Ok)
                    CarregarCategoriaReceita()
                Else
                    S_MsgBox("Erro ao adicionar categoria.", eBotoes.Ok,
                             "Categoria de Receita",, eImagens.Cancel)

                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub CarregarCategoriaReceita()
        Dim rsReceita As SuperDataSet
        Try
            rsReceita = pTipoReceita.CarregaGrid()

            If rsReceita.TotalRegistros > 0 Then
                lvReceita.PreencheGridDS(rsReceita, True, True, False, True)
                CorList(lvReceita)
            Else
                S_MsgBox("Nenhum registro encontrado.", eBotoes.Ok,,, eImagens.Info)
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnEditarReceita_Click(sender As Object, e As EventArgs) Handles btnEditarReceita.Click

        Try
            If lvReceita.SelectedItems.Count > 0 Then
                codigo = lvReceita.ObterChave

                If codigo <> 0 Then
                    form = New frmCadastroCategoria(codigo, eCadastroCategoria.CategoriaReceita)
                    form.ShowDialog()
                    CarregarCategoriaReceita()
                Else
                    S_MsgBox("Erro ao localizar registro.", eBotoes.Ok,,, eImagens.Cancel)
                End If
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnExcluirReceita_Click(sender As Object, e As EventArgs) Handles btnExcluirReceita.Click
        Try

            If lvReceita.SelectedItems.Count > 0 Then
                codigo = lvReceita.ObterChave
                If S_MsgBox("Deseja excluir este registro?", eBotoes.SimNao,,, eImagens.Interrogacao) = eRet.Sim Then
                    If pTipoReceita.Deletar(codigo) = True Then
                        S_MsgBox("Categoria excluída com sucesso!", eBotoes.Ok,,, eImagens.Ok)
                        CarregarCategoriaReceita()
                    Else
                        S_MsgBox("Erro ao excluir registro.", eBotoes.Ok,,, eImagens.Cancel)
                    End If
                End If
            End If
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

    Private Sub btnFecharConfig_Click(sender As Object, e As EventArgs) Handles btnFecharConfig.Click
        Me.Close()
    End Sub

    Private Sub tabCtrlConfig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabCtrlConfig.SelectedIndexChanged
        Dim tab As Integer
        tab = tabCtrlConfig.SelectedIndex
        If tab <> 0 Then
            btnFecharConfig.Visible = True
        Else
            btnFecharConfig.Visible = False
        End If
    End Sub

    Private Sub frmConfiguracao_HandleDestroyed(sender As Object, e As EventArgs) Handles Me.HandleDestroyed

    End Sub
End Class