Imports GFT.Util.clsMsgBox
Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.Gelo)
        CorButton(btnAcessar, Collor.DimGray, Color.White, Color.Gray, Color.DimGray)
        'CorButton(btnFechar, Collor.CinzaEscuro, Color.Black, Color.White, Color.WhiteSmoke)

    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs)
        Dim oform As frmPrincipal
        oform = New frmPrincipal
        oform.Hide()
        Me.Close()
    End Sub

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click
        If txtUsuario.Text = "" And txtSenha.Text = "" Then
            S_MsgBox("Insira um Usuário e Senha para acessar o sistema.",
                     eBotoes.Ok, "Falha na autenticação",,
                     eImagens.Atencao)
        ElseIf txtUsuario.Text = "adm" And txtSenha.Text = "adm" Then
            Me.Close()
        Else
            If txtUsuario.Text <> "" Then
                If txtUsuario.Text <> "adm" Then
                    lblUserInfo.Text = "Usuário incorreto!"
                End If
            End If
            If txtSenha.Text <> "" Then
                If txtSenha.Text <> "adm" Then
                    lblSenhaInfo.Text = "Senha incorreta!"
                End If
            End If
        End If
    End Sub

    Private Sub txtUsuario_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsuario.MouseClick
        lblUserInfo.Text = ""

    End Sub

    Private Sub txtSenha_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSenha.MouseClick
        lblSenhaInfo.Text = ""
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs)
        Dim oform As frmPrincipal
        oform = New frmPrincipal
        oform.Hide()
        Me.Close()
    End Sub

    Private Sub ToolStripDropDownButton2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnFechar_Click_1(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class