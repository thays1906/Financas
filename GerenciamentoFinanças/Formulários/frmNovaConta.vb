Imports GFT.Util
Imports GFT.Util.SuperComboBox
Imports GFT.Util.clsMsgBox

Public Class frmNovaConta
    Public cCodigo As Decimal
    Public agencia As Decimal
    Public conta As Decimal
    Public saldo As Decimal
    Public cPrincipal As Decimal
    Public Property bAlterado As Boolean
    Private Sub frmNovaConta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CarregarCombo()

        If cCodigo <> 0 Then
            PreencheCampo()
        End If
    End Sub

    Sub New(ByVal _cConta As Decimal)

        ' This call is required by the designer.
        InitializeComponent()

        cCodigo = _cConta
    End Sub
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If DadosConta() = True Then

                If chkPrincipalConta.Checked Then

                    cPrincipal = 1
                Else
                    cPrincipal = 2
                End If
                If txtAgencia.Text <> "" Then
                    agencia = CDec(txtAgencia.Text)
                End If

                If txtConta.Text <> "" Then
                    conta = CDec(txtConta.Text)
                End If
                If cCodigo = 0 Then

                    If pContaBancaria.InserirConta(txtBanco.Text,
                                                   agencia,
                                                   conta,
                                                   saldo,
                                                   CDec(cbTipoConta.ObterChaveCombo()),
                                                   cPrincipal) Then

                        S_MsgBox("Conta Bancária cadastrada com sucesso.", eBotoes.Ok, "",, eImagens.Ok)

                        bAlterado = True
                    End If
                Else
                    If pContaBancaria.AlterarConta(cCodigo,
                                                   txtBanco.Text,
                                                   agencia,
                                                   conta,
                                                   saldo,
                                                   CDec(cbTipoConta.ObterChaveCombo()),
                                                   cPrincipal) Then

                        S_MsgBox("Dados da Conta Bancária alterados com sucesso.",
                                 eBotoes.Ok, "",,
                                 eImagens.Ok)

                        bAlterado = True
                    End If
                End If
                Me.bAlterado.ToString()
                Me.Close()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
    Private Function DadosConta() As Boolean

        'Removi pois acho que nao deve ser obrigatorio agencia e conta
        'If IsNumeric(txtAgencia.Text) Then
        '    agencia = CDec(txtAgencia.Text)
        'Else
        '    S_MsgBox("Verifique se o campo 'Agência' está correto.'", eBotoes.Ok,,, eImagens.Atencao)
        '    Return False
        'End If
        'If IsNumeric(txtConta.Text) Then
        '    conta = CDec(txtConta.Text)
        'Else
        '    clsMsgBox.S_MsgBox("Verifique se o campo 'Conta' está correto.'", eBotoes.Ok,,, eImagens.Atencao)
        '    Return False

        'End If
        If txtSaldo.VerificaObrigatorio = False Then
            Return False
        Else
            saldo = CDec(txtSaldo.Text)
        End If
        If cbTipoConta.VerificaObrigatorio = False Then
            Return False
        End If
        If txtBanco.VerificaObrigatorio = False Then
            Return False
        End If
        Return True
    End Function
    Private Sub txtSaldo_Leave(sender As Object, e As EventArgs) Handles txtSaldo.Leave
        If IsNumeric(txtSaldo.Text) Then
            txtSaldo.Text = CDec(txtSaldo.Text).ToString("C")
        End If
    End Sub
    Private Sub PreencheCampo()
        Dim oDataSet As SuperDataSet
        Try
            oDataSet = pContaBancaria.ObterConta(cCodigo)

            If oDataSet IsNot Nothing Then

                txtSaldo.Text = oDataSet("cSaldo").ToString
                txtSaldo.Text = Convert.ToDouble(txtSaldo.Text).ToString("C")

                txtBanco.Text = oDataSet("rBanco").ToString

                If CDec(oDataSet("cAgencia")) <> 0 Then
                    txtAgencia.Text = oDataSet("cAgencia").ToString
                End If

                If CDec(oDataSet("cCta")) <> 0 Then
                    txtConta.Text = oDataSet("cCta").ToString
                End If

                cbTipoConta.PosicionaRegistroCombo(CType(oDataSet("cTipo"), eTipoConta))
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
    Private Sub CarregarCombo()
        Dim col As Collection
        Try
            col = New Collection

            col.Add(New DuplaCombo(eTipoConta.Corrente, "Corrente"))
            col.Add(New DuplaCombo(eTipoConta.Poupanca, "Poupança"))
            col.Add(New DuplaCombo(eTipoConta.Digital, "Cateira Digital"))

            cbTipoConta.PreencheComboColl(col, PrimeiroValor.Selecione)
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Aviso",, eImagens.Cancel)
        End Try
    End Sub
End Class