Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox
Public Class frmAddCobranca
    Public cCobranca As Decimal
    Public bAlterado As Boolean = False

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
                                           CDec(cbConta.ObterChaveCombo)) Then

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
                                               CDec(cbConta.ObterChaveCombo)) Then

                        S_MsgBox("Registro alterado com sucesso!",
                                 eBotoes.Ok,
                                 "Cobrança de empréstimos",,
                                 eImagens.FileOK)
                        bAlterado = True
                    Else
                        S_MsgBox("Desculpe, não foi possível alterar registro.",
                                 eBotoes.Ok,
                                 "Cobrança de empréstimos",,
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
                S_MsgBox("Informe um valor.", eBotoes.Ok, "Lançamento de empréstimos",, eImagens.Atencao)
                Return False
            End If

            If txtNome.Text = "" Then
                S_MsgBox("Informe um nome do devedor.", eBotoes.Ok, "Lançamento de empréstimos",, eImagens.Atencao)
                Return False
            End If
            If cbStatus.SelectedIndex = 0 Then
                S_MsgBox("Por favor, selecione um status. ('Pendente','Pago','Atrasado')",
                         eBotoes.Ok, "Lançamento de empréstimos",,
                         eImagens.Atencao)
                Return False
            End If
            If cbConta.SelectedIndex = 0 Then
                S_MsgBox("Por favor, selecione uma conta báncaria, referente ao dinheiro emprestado",
                         eBotoes.Ok, "Lançamento de empréstimos",,
                         eImagens.Atencao)
                Return False
            End If

            Return True
        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
            Return False
        End Try
    End Function

    Private Sub CarregarCombo()
        Dim col As Collection
        Dim rs As SuperDataSet
        Try
            rs = New SuperDataSet
            col = New Collection

            col.Add(New DuplaCombo(eStatusDespesa.Pendente, "Pendente"))
            col.Add(New DuplaCombo(eStatusDespesa.Pago, "Pago"))
            col.Add(New DuplaCombo(eStatusDespesa.Atrasado, "Atrasado"))

            cbStatus.PreencheComboColl(col, PrimeiroValor.Selecione)

            col.Clear()

            rs = pContaBancaria.CarregarConta()

            If rs.TotalRegistros > 0 Then
                cbConta.PreencheComboDS(rs, "rBanco", "cConta", PrimeiroValor.Selecione)
            End If


        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class