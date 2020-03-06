Public Class frmConsulta
    Private Sub btnPesquisar_Click(sender As Object, e As EventArgs) Handles btnPesquisar.Click
        Try
            Dim oDataset

            oDataset = pConsulta.Pesquisar()

            lvConsulta.PreencheGridDS(oDataset, False)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class