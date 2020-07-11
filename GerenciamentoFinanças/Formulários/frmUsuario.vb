Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmUsuario
    Public cUsuar As Decimal
    Public cActiveLogin As eStatus
    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaBranco)
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        'Pesquisar()
        Verifica()
    End Sub

    Private Sub frmUsuario_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmUsuario_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Usuario)
    End Sub

    Private Sub tabCadastro_Click(sender As Object, e As EventArgs) Handles tabCadastro.Click

    End Sub

    Private Sub chkAlteraSenha_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlteraSenha.CheckedChanged
        If chkAlteraSenha.Checked Then
            gbAlterarSenha.Enabled = True
            btnSalvar.Enabled = True
        Else
            gbAlterarSenha.Enabled = False
            btnSalvar.Enabled = False
            gbAlterarSenha.Text = "Cadastrar senha"
        End If
    End Sub

    Private Sub txtSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If Validar() Then
                If cUsuar = 0 Then
                    If pUsuario.Inserir(txtUsuario.Text, txtSenha.Text, CType(cActiveLogin, eStatus)) Then

                        S_MsgBox("Usuário registrado com sucesso!", eBotoes.Ok, "Usuário cadastrado",, eImagens.FileOK)
                    Else
                        S_MsgBox("Desculpe, não possível cadastrar usuário", eBotoes.Ok, "Falha ao salvar",, eImagens.Cancel)

                    End If
                Else
                    If pUsuario.Alterar(cUsuar, txtSenha.Text) Then
                        S_MsgBox("Senha alterado com sucesso", eBotoes.Ok, "Usuário alterado",, eImagens.FileOK)
                    Else
                        S_MsgBox("Desculpe, não possível realizar alteração.", eBotoes.Ok, "Falha na operação",, eImagens.Cancel)

                    End If
                End If

            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub Pesquisar()
        Dim oDataSet As SuperDataSet
        Try
            oDataSet = pUsuario.Verificar()
            If oDataSet IsNot Nothing Then


                If oDataSet("rUsuar").ToString <> "" Then
                    txtUsuario.Text = oDataSet("rUsuar").ToString
                End If
                If CDec(oDataSet("cUsuar")) <> 0 Then
                    cUsuar = CDec(oDataSet("cUsuar"))
                End If
                If CDec(oDataSet("cActiveLogin")) <> 0 Then
                    cActiveLogin = CType(oDataSet("cActiveLogin"), eStatus)
                End If

            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)

        End Try
    End Sub
    'Validação dos campos para salvar/alterar usuario
    Private Function Validar() As Boolean
        Try
            If txtSenha.VerificaObrigatorio Then
                If txtSenha.TextLength >= 8 Then
                    If txtSenha.Text = txtConfirmSenha.Text Then
                        Return False
                    Else
                        S_MsgBox("As senhas não coincidem!", eBotoes.Ok, "As senhas devem ser iguais.",, eImagens.Atencao)
                    End If
                Else
                    S_MsgBox("Para sua segurança, a senha dever conter no mínimo 8 caracteres", eBotoes.Ok, "Senha fraca",, eImagens.Atencao)
                End If
            Else
                S_MsgBox("Por favor informe um nova senha.", eBotoes.Ok, "Campo vazio",, eImagens.Atencao)

            End If
            If txtConfirmSenha.VerificaObrigatorio Then
                Return False
            End If


            Return True
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
            Return False
        End Try
    End Function

    'CHECHBOX DE DESATIVAR LOGIN
    Private Sub chkLogin_CheckedChanged(sender As Object, e As EventArgs) Handles chkLogin.CheckedChanged
        'Se não tem usuario cadastrado, por escolher usar App sem autenticação
        If cUsuar = 0 Then
            If chkLogin.Checked Then

                gbDados.Enabled = True
                gbAlterarSenha.Enabled = True

                btnSalvar.Enabled = True
            Else
                gbDados.Enabled = False
            End If
            'Se tem usuario, mas desativou o login
        ElseIf cUsuar <> 0 Then
            If cActiveLogin = 2 Then
                If chkLogin.Checked = False Then
                    gbDados.Enabled = True
                    btnSalvar.Enabled = True
                End If
            End If

        End If

    End Sub
    'BOTÃO PARA EFETIVAR A DESATIVAÇÃO DO LOGIN
    Private Sub btnDesabilitar_Click(sender As Object, e As EventArgs) 
        Try

            If S_MsgBox("Deseja desativar autenticação por login da aplicação?" & vbNewLine &
                        "Lembre-se: Você poderá continuar utilizando normalmente a aplicação.",
                        eBotoes.SimNao, "Desativar Login",,
                        eImagens.Interrogacao) = eRet.Sim Then

                    If pUsuario.DesativarUsuario(cUsuar, CType(cActiveLogin, eStatus)) Then

                        S_MsgBox("Usuário desabilitado com sucesso!",
                             eBotoes.Ok, "Login desativado",,
                             eImagens.FileOK)
                    Else
                        S_MsgBox("Não possível desabilitar o login deste usuário.",
                             eBotoes.Ok, "Falha em desativar Login",,
                             eImagens.Cancel)
                End If
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub
    Private Sub Verifica()
        Try
            If cUsuar = 0 Then
                chkLogin.Text = "Habilitar Login"
                chkAlteraSenha.Visible = False
                gbAlterarSenha.Text = "Cadastrar senha"
                chkLogin.Checked = False
                gbDados.Enabled = False
                btnSalvar.Enabled = False
            ElseIf cUsuar <> 0 Then
                If cActiveLogin = eStatus.Inativo Then
                    chkLogin.Text = "Login desativado"
                    chkLogin.Checked = True
                    gbDados.Enabled = False
                    btnSalvar.Enabled = False
                End If
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

End Class