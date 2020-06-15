Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmCadastroCategoria
    Public cCodigo As Decimal
    Public form As eCadastroCategoria
    Private formulario As frmConfiguracao
    Private oDataSet As SuperDataSet

    Sub New(ByVal _cCodigo As Decimal, ByVal _form As eCadastroCategoria)

        InitializeComponent()

        cCodigo = _cCodigo
        form = _form

        If form = eCadastroCategoria.FormaPagamento Then

            lblNovaPag.Text = "Nova Forma de Pagamento"
            oDataSet = pFormaPagamento.ObterFormaPagamento(cCodigo)

        ElseIf form = eCadastroCategoria.CategoriaDespesa Then

            lblNovaPag.Text = "Nova Categoria de Despesa"
            oDataSet = pCategoriaDespesa.ObterCategoria(cCodigo)

        ElseIf form = eCadastroCategoria.CategoriaReceita Then

            lblNovaPag.Text = "Nova categoria de Receita"
            oDataSet = pTipoReceita.ObterTipoReceita(cCodigo)

        End If

        PreencherCampo(oDataSet)

    End Sub


    Private Sub frmFormaPagamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.Preto)
        lblNovaPag.ForeColor = Color.White
    End Sub

    Public Sub PreencherCampo(ByVal oDataSet As SuperDataSet)
        Try

            If form = eCadastroCategoria.FormaPagamento Then

                txtNovaCategoria.Text = oDataSet("rPagamento").ToString

            ElseIf form = eCadastroCategoria.CategoriaDespesa Then

                txtNovaCategoria.Text = oDataSet("rCategoria").ToString

            ElseIf form = eCadastroCategoria.CategoriaReceita Then

                txtNovaCategoria.Text = oDataSet("rTipo").ToString

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            Salvar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Salvar()
        Try
            If txtNovaCategoria.Text <> "" Then

                If form = eCadastroCategoria.FormaPagamento Then
                    If cCodigo = 0 Then

                        pFormaPagamento.IncluirFormaPagamento(txtNovaCategoria.Text)
                        S_MsgBox("Registro incluído com sucesso!", eBotoes.Ok,,, eImagens.Ok)
                    Else

                        pFormaPagamento.AlterarFormaPagamento(cCodigo, txtNovaCategoria.Text)
                        S_MsgBox("Registro alterado com sucesso!", eBotoes.Ok,,, eImagens.Ok)

                    End If
                    Me.Close()
                End If

                If form = eCadastroCategoria.CategoriaDespesa Then
                    If cCodigo = 0 Then

                        pCategoriaDespesa.IncluirCategoria(txtNovaCategoria.Text)
                        S_MsgBox("Registro incluído com sucesso!", eBotoes.Ok,,, eImagens.Ok)

                    Else

                        pCategoriaDespesa.AlterarCategoria(cCodigo, txtNovaCategoria.Text)
                        S_MsgBox("Registro alterado com sucesso!", eBotoes.Ok,,, eImagens.Ok)

                    End If
                    Me.Close()
                End If
                If form = eCadastroCategoria.CategoriaReceita Then

                    If cCodigo = 0 Then

                        pTipoReceita.InserirTipoReceita(txtNovaCategoria.Text)
                        S_MsgBox("Registro incluído com sucesso!", eBotoes.Ok,,, eImagens.Ok)

                    Else
                        pTipoReceita.Alterar(cCodigo, txtNovaCategoria.Text)
                        S_MsgBox("Registro alterado com sucesso!", eBotoes.Ok,,, eImagens.Ok)
                        Me.Close()
                    End If

                End If
            Else
                S_MsgBox("Informe a categoria no campo.", eBotoes.Ok,,, eImagens.Cancel)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class