Imports GFT.Util.BancoDados
Imports GFT.Util
Public Class pFormaPagamento
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pForma_Pagamento"

    Class pFormaPagamento
        Public Shared cPagamento As Campo = New Campo("cPagamento", DbType.Decimal, 10)
        Public Shared rPagamento As Campo = New Campo("rPagamento", DbType.String, 100)
    End Class

    Shared Function IncluirFormaPagamento(ByVal _rPagamento As String) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pFormaPagamento.rPagamento, _rPagamento)

            bDados.Executar(PROCEDURE)

            If bDados.ObterUltimoErro() = "" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Shared Sub AlterarFormaPagamento(ByVal _cPagamento As Decimal, ByVal _rPagamento As String)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pFormaPagamento.cPagamento, _cPagamento)
            bDados.AdicionaParametro(pFormaPagamento.rPagamento, _rPagamento)

            bDados.Executar(PROCEDURE)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Shared Sub DeletarFormaPagamento(ByVal _cPagamento As Decimal)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pFormaPagamento.cPagamento, _cPagamento)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Shared Function CarregarFormaPagamento() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "GRID")

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet Is Nothing Then
                Return Nothing
            Else
                Return oDataSet
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Shared Function CarregarCombo() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "COMB")

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet IsNot Nothing Then
                Return oDataSet
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Shared Function ObterFormaPagamento(ByVal _cFormaPagamento As Decimal) As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pFormaPagamento.cPagamento, _cFormaPagamento)

            oDataSet = bDados.Obter(PROCEDURE)

            If oDataSet Is Nothing Then
                Return Nothing
            Else
                Return oDataSet
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
End Class
