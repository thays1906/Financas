Imports GFT.Util

Public Class frmRelatorio
    Private Sub btnExibir_Click(sender As Object, e As EventArgs) Handles btnExibir.Click
        Dim oDataset As SuperDataSet = Nothing
        Dim strArr As Object() = Nothing
        Dim dtRow As DataRow

        Try
            oDataset = pRelatorio.BuscarDados()

            'strArr = New String(oDataset.TotalRegistros, 2) {}

            For i = 1 To oDataset.TotalColunas

                dtRow = oDataset.ObterDataRow(i)

                'strArr(l) = oDataset.ValorCampo(l, i, 0)

                For l = 1 To oDataset.TotalRegistros
                    strArr(l) = oDataset.ValorCampo(l, i, 0)
                Next
            Next



        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmRelatorio_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub frmRelatorio_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        alterarCaptionFormPrincipal(eTela.Relatorio)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class