Imports GFT.Util.clsMsgBox
Public Class frmRecuperacaoSenha
    Public rUsuario As String
    Public cUsuar As Decimal
    Sub New(ByVal _usuario As String, ByVal _cUser As Decimal)

        ' This call is required by the designer.
        InitializeComponent()
        rUsuario = _usuario
        cUsuar = _cUser
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmRecuperacaoSenha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaBranco)
        CorButton(btnFechar, Collor.CinzaEscuro, Color.White, Color.DimGray, Color.Gray)
        Cor(CType(ssCima, Control), Collor.CinzaEscuro)
        Cor(CType(ssBaixo, Control), Collor.CinzaEscuro)

        If rUsuario <> "" Then
            txtUsuario.Text = rUsuario
        End If

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Try
            If Validar() Then
                If pUsuario.Alterar(cUsuar, txtSenha.Text) Then

                    S_MsgBox("Senha alterada com sucesso.",
                             eBotoes.Ok,
                             "Recuperação de senha",,
                             eImagens.FileOK)
                Else
                    S_MsgBox("Não foi possível trocar a senha.",
                            eBotoes.Ok,
                            "Recuperação de senha",,
                            eImagens.Cancel)
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)

        End Try
    End Sub
    Private Function Validar() As Boolean
        Try
            If dtpNasc.Value.Date <> Now.Date Then
                If dtpNasc.Value > Now.Date Then
                    lblDataInfo.Visible = True
                    lblDataInfo.Text = "Informe uma data de nascimento válida."
                    Return False
                End If
            Else
                lblDataInfo.Visible = True
                lblDataInfo.Text = "Informe uma data de nascimento válida."
                Return False
            End If

            If txtSenha.Text <> "" Then
                If txtSenha.Text.Length < 8 Then
                    lblSenhaInfo.Visible = True
                    lblSenhaInfo.Text = "Para sua segurança, sua senha deve conter no mínimo 8 caracteres."
                    Return False
                End If
            Else
                lblSenhaInfo.Visible = True
                lblSenhaInfo.Text = "Informe sua nova senha."
                Return False
            End If
            If txtSenha.Text <> txtSenhaConfirm.Text Then
                LetreiroRecupera.Visible = True
                LetreiroRecupera.TextoLetreiro = "A senha deve ser igual nos campos."
                Return False
            End If
            Return True
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            Return Nothing
        End Try
    End Function

    Private Sub dtpNasc_MouseDown(sender As Object, e As MouseEventArgs) Handles dtpNasc.MouseDown
        Try
            lblDataInfo.Visible = False
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub txtSenha_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSenha.MouseClick
        lblSenhaInfo.Visible = False
        LetreiroRecupera.Visible = False
    End Sub

    Private Sub txtSenhaConfirm_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSenhaConfirm.MouseClick
        lblConfirmInfo.Visible = False
        LetreiroRecupera.Visible = False

    End Sub
End Class