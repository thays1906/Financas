Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pTipoReceita

    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pTipo_Receita"

    Class pTipoReceita
        Public Shared cTipoReceita As Campo = New Campo("cTiporeceita", DbType.Decimal, 10, 0)
        Public Shared rTipo As Campo = New Campo("rTipo", DbType.String, 100)
    End Class

    Shared Function InserirTipoReceita(ByVal _rTipo As String) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pTipoReceita.rTipo, _rTipo)

            If bDados.Executar(PROCEDURE) = True Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Shared Function ObterTipoReceita() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")

            oDataset = bDados.Obter(PROCEDURE)
            If oDataset IsNot Nothing Then
                Return oDataset
            Else
                Return Nothing
            End If
        Catch ex As Exception
            LogaErro(ex.Message, True)
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
