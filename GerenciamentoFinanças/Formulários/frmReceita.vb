Imports GFT.Util
Imports GFT.Util.clsMsgBox
Imports GFT.Util.SuperComboBox

Public Class frmReceita
    Dim oform As frmNovaReceita = New frmNovaReceita
    Public Shared cReceita As Decimal
    Public Shared oDataset As SuperDataSet

    Private Sub frmReceita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)
        centralizarGrupoBotoes(gbBotoes)
        centralizarGrupoTab(tbConsulta)
        CarregaCombo()
        Pesquisar()

    End Sub
    Private Sub frmReceita_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmReceita_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Receita)
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim novaRec As frmNovaReceita
        Try
            novaRec = New frmNovaReceita


            If lvConsulta.Items.Count > 0 Then

                novaRec.Show()

                oDataset = pReceita.ObterReceita(lvConsulta.ObterChave())

                If oDataset.TotalRegistros > 0 Then
                    novaRec.PreencheCampo(oDataset)
                Else
                    S_MsgBox("Não foram encontrado dados.", clsMsgBox.eBotoes.Ok,,, clsMsgBox.eImagens.Info)
                End If
            Else
                S_MsgBox("Selecione o registro que deseja alterar.", clsMsgBox.eBotoes.Ok,,, clsMsgBox.eImagens.Info)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Pesquisar()
        Try

            oDataset = pReceita.PesquisarReceita(CDec(cbMes.ObterChaveCombo()))

            Dim TOTAL As String = oDataset("total", 0, 1).ToString

            txtTotalReceita.Text = TOTAL

            txtTotalReceita.Text = Convert.ToDouble(txtTotalReceita.Text).ToString("C")


            lvConsulta.PreencheGridDS(oDataset, True, True, False, True, 0, True)
            For i = 0 To oDataset.TotalRegistros - 1

                lvConsulta.Items(i).SubItems(2).ForeColor = Color.Green


            Next


            lvConsulta.GridLines = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Pesquisar()
    End Sub
    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnAddReceita_Click(sender As Object, e As EventArgs) Handles btnAddReceita.Click
        oform = New frmNovaReceita
        oform.Show()

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            If lvConsulta.SelectedItems.Count > 0 Then

                cReceita = lvConsulta.ObterChave()

                If cReceita <> 0 Then
                    pReceita.DeletarReceita(cReceita)
                    S_MsgBox("Registro excluído com sucesso.", eBotoes.Ok,,, eImagens.Ok)
                    Pesquisar()
                End If
            Else
                S_MsgBox("Selecione o registro que deseja excluir.", clsMsgBox.eBotoes.Ok,,, clsMsgBox.eImagens.Info)

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CarregaCombo()
        Dim col As Collection
        Dim mes As Date
        Dim oDataSet As SuperDataSet
        Try
            col = New Collection

            For i = 1 To 12
                col.Add(New DuplaCombo(i, mes.AddMonths(i - 1).ToString("MMMM").ToUpper))
            Next
            cbMes.PreencheComboColl(col, PrimeiroValor.Selecione)

            col.Clear()

            oDataSet = pContaBancaria.CarregarConta()

            cbContaFiltro.PreencheComboDS(oDataSet, "rBanco", "cConta", PrimeiroValor.Selecione)
        Catch ex As Exception

        End Try
    End Sub
End Class