Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pConsulta

    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pConsulta"

    Class pConsulta
        Public Shared dtInicio As Campo = New Campo("dtInicio", DbType.DateTime, 10)
        Public Shared dtFim As Campo = New Campo("dtFim", DbType.DateTime, 10)
        Public Shared cValor As Campo = New Campo("cValor", DbType.Decimal, 18, 0)
        Public Shared cConta As Campo = New Campo("cConta", DbType.Decimal, 10, 0)
    End Class
    Public Shared Function Pesquisar(ByVal _dtInicio As Date, ByVal _dtFim As Date, ByVal _cConta As Decimal) As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "GRID")
            bDados.AdicionaParametro(pConsulta.dtInicio, _dtInicio)
            bDados.AdicionaParametro(pConsulta.dtFim, _dtFim)
            bDados.AdicionaParametro(pConsulta.cConta, _cConta)

            oDataset = bDados.Obter("pConsulta")

            Return oDataset

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
