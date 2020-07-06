Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pDespesaFixa
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pDespesa_Fixa"

    Class pDespesaFixa
        Public Shared cDespesaFixa As Campo = New Campo("cDespesaFixa", DbType.Decimal, 10, 0)
        Public Shared cPeriodo As Campo = New Campo("cPeriodo", DbType.Decimal, 4, 0)
        Public Shared rDescricao As Campo = New Campo("rDescricao", DbType.String, 100)
        Public Shared cValor As Campo = New Campo("cValor", DbType.Decimal, 18, 2)
        Public Shared cConta As Campo = New Campo("cConta", DbType.Decimal, 10, 0)
        Public Shared cCategoria As Campo = New Campo("cCategoria", DbType.Decimal, 10, 0)
        Public Shared cPagamento As Campo = New Campo("cPagamento", DbType.Decimal, 10, 0)
        Public Shared dtRegistro As Campo = New Campo("dtRegistro", DbType.DateTime, 10)
        Public Shared dtFim As Campo = New Campo("DATAFIM", DbType.DateTime, 10)

    End Class

    Shared Function Inserir(ByVal _cPeriodo As eDespesaFixa,
                            ByVal _rDescricao As String,
                            ByVal _cValor As Decimal,
                            ByVal _cCategoria As Decimal,
                            ByVal _cPagamento As Decimal,
                            ByVal _cConta As Decimal,
                            ByVal _dtReg As Date) As Decimal
        Dim bDados As BancoDados
        Dim cDespesaFixa As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pDespesaFixa.dtRegistro, _dtReg)
            bDados.AdicionaParametro(pDespesaFixa.cPeriodo, _cPeriodo)
            bDados.AdicionaParametro(pDespesaFixa.rDescricao, _rDescricao)
            bDados.AdicionaParametro(pDespesaFixa.cValor, _cValor)
            bDados.AdicionaParametro(pDespesaFixa.cConta, _cConta)
            bDados.AdicionaParametro(pDespesaFixa.cCategoria, _cCategoria)
            bDados.AdicionaParametro(pDespesaFixa.cPagamento, _cPagamento)


            cDespesaFixa = bDados.Obter(PROCEDURE)

            If cDespesaFixa IsNot Nothing Then
                Return CDec(cDespesaFixa("cDespesaFixa"))
            Else
                Return 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function

    Shared Function Alterar(ByVal _cDespesaFixa As Decimal,
                            ByVal _cPeriodo As eDespesaFixa,
                            ByVal _rDescricao As String,
                            ByVal _cValor As Decimal,
                            ByVal _cCategoria As Decimal,
                            ByVal _cPagamento As Decimal,
                            ByVal _cConta As Decimal,
                            ByVal _dtReg As Date) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pDespesaFixa.cDespesaFixa, _cDespesaFixa)
            bDados.AdicionaParametro(pDespesaFixa.dtRegistro, _dtReg)
            bDados.AdicionaParametro(pDespesaFixa.cPeriodo, _cPeriodo)
            bDados.AdicionaParametro(pDespesaFixa.rDescricao, _rDescricao)
            bDados.AdicionaParametro(pDespesaFixa.cValor, _cValor)
            bDados.AdicionaParametro(pDespesaFixa.cCategoria, _cCategoria)
            bDados.AdicionaParametro(pDespesaFixa.cPagamento, _cPagamento)
            bDados.AdicionaParametro(pDespesaFixa.cConta, _cConta)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Shared Function Deletar(ByVal _cDespesaFixa As Decimal) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pDespesaFixa.cDespesaFixa, _cDespesaFixa)

            If bDados.Executar(PROCEDURE) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Shared Function Pesquisar() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "GRID")

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

    Shared Function Obter(ByVal _cDespesaFixa As Decimal) As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pDespesaFixa.cDespesaFixa, _cDespesaFixa)

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
    Shared Function InserirLancamentoFuturo(ByVal _cDespesaFixa As Decimal) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(pDespesaFixa.cDespesaFixa, _cDespesaFixa)
            bDados.AdicionaParametro(pDespesaFixa.dtFim, Now.AddYears(10))

            If bDados.Executar("pLancamento_Futuro") Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
End Class
