Imports GFT.Util

Public Class frmConsulta
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            Dim oDataset As SuperDataSet

            oDataset = pConsulta.Pesquisar(MinHora(dtInicialFiltro.Value),
                                           MaxHora(dtFinalFiltro.Value),
                                           CDec(cbConta.ObterChaveCombo))

            lvConsulta.PreencheGridDS(oDataset, False, True, False, True, 0, True)

            For i = 0 To oDataset.TotalRegistros - 1

                If CStr(oDataset("as_Valor", i)).Contains("-") Then

                    lvConsulta.Items(i).SubItems(1).ForeColor = Color.Red

                Else
                    lvConsulta.Items(i).SubItems(1).ForeColor = Color.Green
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Function MinHora(ByVal _date As Date) As Date
        Dim data As Date
        Try
            data = New Date(_date.Year, _date.Month, _date.Day, 0, 0, 0)

            Return data

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Private Function MaxHora(ByVal _data As Date) As Date
        Dim data As Date
        Try
            data = New Date(_data.Year, _data.Month, _data.Day, 23, 59, 59)
            Return data
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Private Sub btnFechar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)
        CorButton(btnPesquisar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnFechar, Collor.Gelo, Color.Black, Color.White, Color.WhiteSmoke)
        CorButton(btnExportar, Collor.Branco, Color.Black, SystemColors.ControlLightLight, Color.WhiteSmoke)

        centralizarGrupoTab(tbConsulta)
        centralizarGrupoBotoes(gbBotoes)
        CarregaCombo()
    End Sub
    Private Sub frmConsulta_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Consulta)
    End Sub
    Private Sub frmConsulta_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub
    Private Sub CarregaCombo()
        Dim rs As SuperDataSet
        Try
            rs = pContaBancaria.CarregarConta

            cbConta.PreencheComboDS(rs, "rBanco", "cConta", SuperComboBox.PrimeiroValor.Selecione)

        Catch ex As Exception

        End Try
    End Sub
End Class