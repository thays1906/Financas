Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Public Class frmNovaCobranca
    Public cCobranca As Decimal
    Public bAlterado As Boolean = False
    Public cLembrete As Decimal = Nothing
    Public dataLembrete As Date = Nothing
    Public cFrequencia As Decimal = Nothing

    Sub New(ByVal _cCobranca As Decimal)

        ' This call is required by the designer.
        InitializeComponent()

        cCobranca = _cCobranca
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmAddCobranca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)
        CorButton(btnSalvar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)

        CarregarCombo()

        If cCobranca > 0 Then
            PreencheCampos()
        End If
    End Sub

    Private Sub PreencheCampos()
        Dim oDataSet As SuperDataSet
        Try
            oDataSet = New SuperDataSet

            oDataSet = pCobrancaPagamento.Obter(cCobranca)

            If oDataSet.TotalRegistros > 0 Then

                dtregistro.Value = CDate(oDataSet("dtRegistro"))
                txtNome.Text = oDataSet("rTitular").ToString

                If CDec(oDataSet("cValor")) <> 0 Then
                    txtValor.Text = Convert.ToDouble(oDataSet("cValor")).ToString("C")
                End If

                cbStatus.PosicionaRegistroCombo(CType(oDataSet("cStatus"), eStatusDespesa))

                cbConta.PosicionaRegistroCombo(oDataSet("cConta"))



            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            If VerificarCampos() Then
                If cCobranca = 0 Then



                    If pCobrancaPagamento.Inserir(dtregistro.Value,
                                           CDec(txtValor.Text),
                                           txtNome.Text, CType(cbStatus.ObterChaveCombo, eStatusDespesa),
                                           CDec(cbConta.ObterChaveCombo),
                                           cLembrete,
                                           dataLembrete,
                                           cFrequencia) Then

                        S_MsgBox("Lançamento efetuado com sucesso!",
                                 eBotoes.Ok,
                                 "Cobrança de empréstimos",,
                                 eImagens.FileOK)
                        bAlterado = True
                    Else
                        S_MsgBox("Desculpe, não foi possível salvar novo lançamento.",
                                 eBotoes.Ok,
                                 "Cobrança de empréstimos",,
                                 eImagens.Cancel)

                    End If

                Else
                    If pCobrancaPagamento.Alterar(cCobranca,
                                               dtregistro.Value,
                                               CDec(txtValor.Text),
                                               txtNome.Text,
                                               CType(cbStatus.ObterChaveCombo, eStatusDespesa),
                                               CDec(cbConta.ObterChaveCombo),
                                               cLembrete,
                                               dataLembrete,
                                               cFrequencia) Then

                        S_MsgBox("Registro alterado com sucesso!",
                                 eBotoes.Ok,
                                 "Cobrança de empréstimos",,
                                 eImagens.FileOK)

                        bAlterado = True
                    Else
                        S_MsgBox("Desculpe, não foi possível alterar o registro.",
                                 eBotoes.Ok,
                                 "Empréstimos e Cobranças",,
                                 eImagens.Cancel)

                    End If
                End If
                LimparCampos()
                Me.bAlterado.ToString()
                Me.Close()
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub LimparCampos()
        Try
            dtregistro.Value = Now
            txtNome.Text = ""
            txtValor.Text = ""
            cbStatus.PosicionaRegistroCombo(0)
            cbConta.PosicionaRegistroCombo(0)
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Function VerificarCampos() As Boolean
        Try
            If txtValor.VerificaObrigatorio = False Then
                lblValorAviso.Text = "Informe um valor."
                lblValorAviso.Visible = True
                Return False
            End If

            If txtNome.VerificaObrigatorio = False Then
                lblDevedorAviso.Text = "Informe um nome do devedor."
                lblDevedorAviso.Visible = True
                Return False
            End If
            If cbStatus.SelectedIndex = 0 Then
                lblStatusAviso.Text = "Por favor, selecione um status."
                lblStatusAviso.Visible = True
                Return False
            End If
            If cbConta.SelectedIndex = 0 Then
                lblContaAviso.Text = "Por favor, selecione a conta báncaria, que foi retirado o dinheiro emprestado"
                lblContaAviso.Visible = True
                Return False
            End If

            Return True
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
            Return False
        End Try
    End Function

    Private Sub CarregarCombo(Optional ByVal todos As Boolean = True)
        Dim col As Collection
        Dim rs As SuperDataSet
        Try
            rs = New SuperDataSet
            col = New Collection
            If todos Then
                col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
                col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
                col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

                cbStatus.PreencheComboColl(col, PrimeiroValor.Selecione)


                rs = pContaBancaria.CarregarConta()

                If rs.TotalRegistros > 0 Then
                    cbConta.PreencheComboDS(rs, "rBanco", "cConta", PrimeiroValor.Selecione)
                End If
            Else
                col.Clear()
                col.Add(New DuplaCombo(eDespesaFixa.Diario, "Diariamente"))
                col.Add(New DuplaCombo(eDespesaFixa.Semanal, "Semanal"))
                col.Add(New DuplaCombo(eDespesaFixa.Quinzenal, "Quinzenal"))
                col.Add(New DuplaCombo(eDespesaFixa.Mensal, "Mensal"))
                col.Add(New DuplaCombo(eDespesaFixa.Bimestral, "Bimestral"))
                col.Add(New DuplaCombo(eDespesaFixa.Trimestral, "Trimestral"))
                col.Add(New DuplaCombo(eDespesaFixa.Semestral, "Semestral"))
                col.Add(New DuplaCombo(eDespesaFixa.Anual, "Anual"))

                cbfrquencia.PreencheComboColl(col, PrimeiroValor.Selecione)

            End If



        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub cbConta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbConta.SelectedIndexChanged
        Try
            If cbConta.SelectedIndex <> 0 Then

                picBanco.Image = Banco(cbConta.ObterDescricaoCombo)
            Else
                picBanco.Image = Nothing
                picBanco.Refresh()
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
            LogaErro(ex.Message & "Evento:cbConta_SelectedIndexChanged - Form: AddCobrança")
        End Try
    End Sub

    Private Sub txtValor_Leave(sender As Object, e As EventArgs) Handles txtValor.Leave
        Try
            txtValor.Text = txtValor.Text.Replace("R$", "")
            If txtValor.Text <> "" Then
                txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C2")
            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
            LogaErro(ex.Message & "Evento:txtValor_KeyUp - Form: AddCobrança")
        End Try
    End Sub

    Private Sub chkLembrete_CheckedChanged(sender As Object, e As EventArgs) Handles chkLembrete.CheckedChanged
        Try
            CarregarCombo(False)

            If chkLembrete.Checked Then
                cLembrete = 1

                gbFrequencia.Visible = True
                gbData.Visible = True


                pnlNovaCobranca.ScrollControlIntoView(dtLembrete)
            Else
                cLembrete = 2
                gbFrequencia.Visible = False
                gbData.Visible = False

                pnlNovaCobranca.ScrollControlIntoView(cbStatus)


            End If
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
            LogaErro(ex.Message & "Evento:chkLembrete_CheckedChanged - Form: AddCobrança")
        End Try
    End Sub

    Private Sub rbFrequente_CheckedChanged(sender As Object, e As EventArgs) Handles rbFrequente.CheckedChanged
        Try
            If rbFrequente.Checked Then
                cFrequencia = CType(cbfrquencia.ObterChaveCombo, eDespesaFixa)
                rbData.Checked = False
                cbfrquencia.Enabled = True
            Else
                cFrequencia = Nothing
                cbfrquencia.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub rbData_CheckedChanged(sender As Object, e As EventArgs) Handles rbData.CheckedChanged
        Try
            If rbData.Checked Then
                dataLembrete = dtLembrete.Value

                rbFrequente.Checked = False
                dtLembrete.Enabled = True
            Else
                dtLembrete.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class