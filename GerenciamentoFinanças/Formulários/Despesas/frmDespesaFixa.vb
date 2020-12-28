Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmDespesaFixa
    Public eTipoOperacao As eTipoOperacaoDespesa = Nothing
    Public eTipoAlteracao As eTipoAlteracaoDespesa = Nothing

    Sub New(ByVal _eTipoOperacao As eTipoOperacaoDespesa)

        InitializeComponent()

        eTipoOperacao = _eTipoOperacao

    End Sub
    Private Sub frmDespesaFixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CorButton(btnAlteraDespesaFixa,
                  Collor.Gelo,
                  Color.Black,
                  Color.White,
                  Color.WhiteSmoke)

        CorButton(btnFechar,
                  Collor.Gelo,
                  Color.Black,
                  Color.White,
                  Color.WhiteSmoke)

        TipoOperacao()

    End Sub

    Private Sub TipoOperacao()
        Try
            If eTipoOperacao = eTipoOperacaoDespesa.Deletar Then

                rbSomenteEste.Text = "Deletar somente este registro."
                rbProximos.Text = "Deletar este e os próximos registros."
                rbTodos.Text = "Deletar todos os registros."
                txtInformativo.Visible = False

            ElseIf eTipoOperacao = eTipoOperacaoDespesa.AlterarDespesaParcelada Then

                rbSomenteEste.Text = "Alterar somente esta parcela."
                rbProximos.Text = "Alterar esta e as próximos parcelas."
                rbTodos.Text = "Alterar todas as parcelas."
                txtInformativo.Visible = False

            End If


        Catch ex As Exception
            LogaErro("Erro: " & ex.Message & "Metodo: [TipoOperacao()]")
        End Try
    End Sub

    Private Sub btnAlteraDespesaFixa_Click(sender As Object, e As EventArgs) Handles btnAlteraDespesaFixa.Click
        Try
            If rbProximos.Checked = False And
               rbSomenteEste.Checked = False And
               rbTodos.Checked = False Then

                S_MsgBox("É necessário escolher uma opção para confirmar a alteração do registro.",
                         eBotoes.Ok, ".::Atenção::.",,
                         eImagens.Atencao)
            Else

                If rbSomenteEste.Checked Then

                    eTipoAlteracao = eTipoAlteracaoDespesa.SomenteEsteRegistro

                ElseIf rbProximos.Checked Then

                    eTipoAlteracao = eTipoAlteracaoDespesa.DesteRegistroEmDiante

                Else

                    eTipoAlteracao = eTipoAlteracaoDespesa.Todos

                End If

                Me.eTipoAlteracao.ToString()
                Me.Close()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class