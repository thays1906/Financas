Imports GFT.Util


Public Class pRelatorio

    Public Const PROCEDURE = "pRelatorio"

    Shared Function BuscarDados() As SuperDataSet
        Try
            Dim bDados = New BancoDados()
            Dim oDataSet = New SuperDataSet()

            bDados.LimpaParametros()

            oDataSet = bDados.Obter(PROCEDURE)

            Return oDataSet

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function


End Class
