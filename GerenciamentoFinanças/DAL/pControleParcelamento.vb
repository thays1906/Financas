Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pControleParcelamento
    Public Shared OPERACAO As Campo = New Campo("Operacao", DbType.String, 4)
    Public Const PROCEDURE As String = "pControle_Parcelamento"

    Class pControleParcelamento
        Public Shared cControleParcelamento As Campo = New Campo("cControleParcelamento", DbType.Decimal, 10, 0)
        Public Shared cQtdeParcela As Campo = New Campo("cQtdeParcela", DbType.Decimal, 2, 0)
    End Class

    Shared Function Inserir(ByVal _cQtdeParcela As Decimal) As Decimal
        Dim bDados As BancoDados
        Dim _cControleParcelamento As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pControleParcelamento.cQtdeParcela, _cQtdeParcela)

            _cControleParcelamento = bDados.Obter(PROCEDURE)

            If _cControleParcelamento IsNot Nothing Then
                Return CDec(_cControleParcelamento("cControleParcelamento"))
            Else
                Return 0
            End If


        Catch ex As Exception
            Return 0
            MessageBox.Show(ex.Message)
        End Try
    End Function

    'Shared Function Alterar(ByVal _codigo As Decimal)
    '    Try

    '    Catch ex As Exception

    '    End Try
    'End Function

    Shared Function Obter() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
