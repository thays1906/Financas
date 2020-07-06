Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmDespesaFixa
    Public Property retorno() As String

    Sub New(ByVal btn As String)

        ' This call is required by the designer.
        InitializeComponent()
        retorno = btn
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDespesaFixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CorButton(btnAlteraDespesaFixa, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        If retorno = "Del" Then
            rbSomenteEste.Text = "Deletar somente este registro."
            rbProximos.Text = "Deletar este e os próximos registros."
            rbTodos.Text = "Deletar todos os registros."
            txtInformativo.Visible = False
        ElseIf retorno = "UPDP" Then
            rbSomenteEste.Text = "Alterar somente esta parcela."
            rbProximos.Text = "Alterar esta e as próximos parcelas."
            rbTodos.Text = "Alterar todas as parcelas."
            txtInformativo.Visible = False
        End If
        retorno = ""

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

                    retorno = "1"

                ElseIf rbProximos.Checked Then

                    retorno = "1*"
                Else

                    retorno = "*"
                End If

                Me.retorno.ToString()
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