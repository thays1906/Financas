Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox

Public Class frmNovaReceita
    Public cReceita As Decimal = Nothing

    Sub New(ByVal _cReceita As Decimal)

        InitializeComponent()

        cReceita = _cReceita

    End Sub

    Private Sub frmNovaReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaCombo()
        Cor(Me, Collor.CinzaEscuro)
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        If cReceita <> 0 Then
            PreencheCampo()
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim logErro As String
        Try
            If VerificaCampos() = True Then

                If cReceita = 0 Then

                    logErro = Now.ToString & "- Inclusão de receita"

                    If pReceita.InserirReceita(dtReceita.Value,
                                            txtDescricao.Text,
                                            CDec(txtValor.Text),
                                            CDec(cbConta.ObterChaveCombo),
                                            CDec(cbTipoReceita.ObterChaveCombo),
                                            logErro) Then

                        S_MsgBox("Receita adicionada com sucesso", eBotoes.Ok,, eImagens.Ok)
                        DialogResult = DialogResult.OK

                    Else

                        S_MsgBox("Desculpe, não possível salvar este registro.",
                                 eBotoes.Ok,,
                                 eImagens.Cancel)

                        DialogResult = DialogResult.Cancel
                    End If
                Else

                    logErro = Now.ToString & "Dados da Receita alterada."

                    If pReceita.AlterarReceita(cReceita,
                                            txtDescricao.Text,
                                            CDec(txtValor.Text),
                                            CDec(cbConta.ObterChaveCombo()),
                                            CDec(cbTipoReceita.ObterChaveCombo()),
                                            logErro) Then

                        S_MsgBox("Dados alterado com sucesso", eBotoes.Ok,, eImagens.Ok)
                        DialogResult = DialogResult.OK
                    Else

                        S_MsgBox("Desculpe, não foi possível alterar este registro.",
                                 eBotoes.Ok,,
                                 eImagens.Cancel)

                        DialogResult = DialogResult.Cancel

                    End If
                End If

                LimpaCampos()
                Me.DialogResult.ToString()
                Me.Close()


            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmNovaReceita: " & ex.Message & "[btnSalvar_Click]")
        End Try
    End Sub
    Private Sub CarregaCombo()
        Dim conta As SuperDataSet = Nothing
        Dim col As New Collection
        Dim tipoReceita As SuperDataSet = Nothing
        Try
            col = New Collection()
            conta = New SuperDataSet()
            tipoReceita = New SuperDataSet()

            conta = pContaBancaria.CarregarConta()
            cbConta.PreencheComboDS(conta, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

            tipoReceita = pTipoReceita.CarregarCombo()
            cbTipoReceita.PreencheComboDS(tipoReceita, "rTipo", "cTipoReceita", SuperComboBox.PrimeiroValor.Selecione)

            col.Add(New DuplaCombo(eTipoConta.Corrente, "Corrente"))
            col.Add(New DuplaCombo(eTipoConta.Poupanca, "Poupança"))

            cbTipoConta.PreencheComboColl(col, PrimeiroValor.Nada)

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmNovaReceita: " & ex.Message & "[CarregaCombo]")
        End Try
    End Sub
    Private Function VerificaCampos() As Boolean
        Try
            If cbConta.VerificaObrigatorio() = False Then
                Return False
            End If
            If cbTipoReceita.VerificaObrigatorio() = False Then
                Return False
            End If
            If txtValor.Text = Nothing Then
                Return False
            End If

            Return True

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmNovaReceita: " & ex.Message & "[VerificaCampos]")
            Return False
        End Try
    End Function

    Public Sub PreencheCampo()
        Dim rs As SuperDataSet = Nothing
        Dim CValor As Decimal = Nothing
        Try
            rs = pReceita.ObterReceita(cReceita)

            If rs IsNot Nothing Then
                dtReceita.Value = CDate(rs("dtRec").ToString)

                CValor = CDec(rs("cValor"))
                txtValor.Text = Convert.ToDouble(CValor).ToString("C2")

                cbConta.PosicionaRegistroCombo(rs("cConta"))
                cbTipoReceita.PosicionaRegistroCombo(rs("cTipo"))
                txtDescricao.Text = rs("rDescricao").ToString

            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmNovaReceita: " & ex.Message & "[PreencheCampo]")
        Finally
            If rs IsNot Nothing Then
                rs.Dispose()
            End If
        End Try
    End Sub
    Private Sub LimpaCampos()
        Try
            dtReceita.Value = Now
            txtDescricao.Text = ""
            txtValor.Text = "R$ 0,00"

            If cbConta.Items.Count > 0 Then
                cbConta.SelectedIndex = 0
            End If

            If cbTipoReceita.Items.Count > 0 Then
                cbTipoReceita.SelectedIndex = 0
            End If

            If cbTipoConta.Items.Count > 0 Then
                cbTipoConta.SelectedIndex = 0
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmNovaReceita: " & ex.Message & "[LimpaCampos]")
        End Try
    End Sub
    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        Try
            If IsNumeric(txtValor.Text) Then
                txtValor.Text = CDec(txtValor.Text).ToString("C")
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve uma falha.",, eImagens.Cancel)
            LogaErro("Erro em frmNovaReceita: " & ex.Message & "[txtValor_Leave]")
        End Try
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        DialogResult = DialogResult.Cancel
        Me.DialogResult.ToString()
        Me.Close()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub txtValor_MouseDown(sender As Object, e As MouseEventArgs) Handles txtValor.MouseDown
        If cReceita = 0 Then
            txtValor.Text = ""
        End If
    End Sub
End Class