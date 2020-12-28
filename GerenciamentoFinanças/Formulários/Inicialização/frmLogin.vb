Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmLogin
    Public Property Retorno As String
    Public oform As Form

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Cor(CType(ssCima, Control), Collor.CinzaEscuro)
        Cor(CType(ssBaixo, Control), Collor.CinzaEscuro)

        CorButton(btnAcessar, Collor.CinzaEscuro, Color.White, Color.DimGray, Color.DimGray)
        CorButton(btnPrimeiroAcesso, Collor.CinzaEscuro, Color.White, Color.DimGray, Color.DimGray)
        CorButton(btnFechar, Collor.CinzaEscuro, Color.Black, Color.DimGray, Color.DarkGray)

        VerificaSeExisteUsuario()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs)
        oform = New frmPrincipal()
        oform.Hide()
        Me.Close()
    End Sub

    Private Sub btnAcessar_Click(sender As Object, e As EventArgs) Handles btnAcessar.Click

        If txtUsuario.Text <> "" Then
            If VerificaSeExisteUsuario() = False Then
                lblUserInfo.Text = "Usuário incorreto!"
            End If
            If txtSenha.Text <> "" Then
                lblSenhaInfo.Text = "Senha incorreta!"
            End If
        Else
            If txtUsuario.Text = "adm" And txtSenha.Text = "adm" Then
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If

            If txtUsuario.Text = "" And txtSenha.Text = "" Then

                S_MsgBox("Insira um Usuário e Senha para acessar.",
                         eBotoes.Ok, "Falha na autenticação",,
                         eImagens.Atencao)
            End If
        End If

    End Sub

    Private Sub txtUsuario_MouseClick(sender As Object, e As MouseEventArgs) Handles txtUsuario.MouseClick
        lblUserInfo.Text = ""
    End Sub

    Private Sub txtSenha_MouseClick(sender As Object, e As MouseEventArgs) Handles txtSenha.MouseClick
        lblSenhaInfo.Text = ""
    End Sub



    Private Sub btnFechar_Click_1(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub



    Private Sub chkNaoMostraLogin_CheckedChanged(sender As Object, e As EventArgs)
        'If chkNaoMostraLogin.Checked Then

        '    Retorno = 2
        '    Me.Retorno.ToString()
        'End If
    End Sub

    Private Function VerificaSeExisteUsuario() As Boolean
        Dim oDataset As SuperDataSet = Nothing
        Try

            oDataset = pUsuario.Verificar()
            If oDataset Is Nothing Then

                btnPrimeiroAcesso.Visible = True
            Else
                If CDec(oDataset("cUsuar")) = 0 Then
                    btnPrimeiroAcesso.Visible = True
                Else
                    btnPrimeiroAcesso.Visible = False

                End If
            End If

            If oDataset IsNot Nothing Then
                If txtUsuario.Text <> "" Then
                    If oDataset("rUsuar").ToString <> "" Then
                        If txtUsuario.Text = oDataset("rUsuar").ToString Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            Return False
        End Try
    End Function

    Private Sub llEsqueceuSenha_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llEsqueceuSenha.LinkClicked
        Dim rs As SuperDataSet
        Dim cUsuar As Decimal
        Try
            If txtUsuario.Text <> "" Then
                rs = pUsuario.Obter(txtUsuario.Text)
                If rs.TotalRegistros = 0 Then
                    S_MsgBox("Usuário não encontrado.",
                         eBotoes.Ok, "Usuário não existe",,
                         eImagens.Cancel)
                Else

                    Retorno = rs("rUsuar").ToString
                    cUsuar = CDec(rs("cUsuar"))
                    oform = New frmRecuperacaoSenha(Retorno, cUsuar)
                    oform.ShowDialog()
                End If

            Else
                S_MsgBox("Por favor, informe o usuário.",
                         eBotoes.Ok, "Nenhum usuário informado",,
                         eImagens.Atencao)

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrimeiroAcesso_Click(sender As Object, e As EventArgs) Handles btnPrimeiroAcesso.Click

    End Sub
End Class