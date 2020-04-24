Imports GFT.Util.BancoDados
Imports GFT.Util
Public Class pDespesa
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pDespesa"

    Class pDespesa
        Public Shared cDespesa As Campo = New Campo("cDespesa", DbType.Decimal, 10, 0)
        Public Shared rDescricao As Campo = New Campo("rDescricao", DbType.String, 100)
        Public Shared cValor As Campo = New Campo("cValor", DbType.Decimal, 18, 2)
        Public Shared cConta As Campo = New Campo("cConta", DbType.Decimal, 10, 0)
        Public Shared cCategoria As Campo = New Campo("cCategoria", DbType.Decimal, 10, 0)
        Public Shared cPagamento As Campo = New Campo("cPagamento", DbType.Decimal, 10, 0)
        Public Shared dtRegistro As Campo = New Campo("dtRegistro", DbType.DateTime, 10)
        Public Shared dtUltAtua As Campo = New Campo("dtUltAtua", DbType.DateTime, 10)
        Public Shared cStatus As Campo = New Campo("cStatus", DbType.Decimal, 2, 0)
        Public Shared rLog As Campo = New Campo("rLog", DbType.String, -1)
    End Class

    Shared Function InserirDespesa(ByVal _rDescricao As String,
                                   ByVal _cValor As Decimal,
                                   ByVal _cConta As Decimal,
                                   ByVal _cCategoria As Decimal,
                                   ByVal _cPagamento As Decimal,
                                   ByVal _dtRegistro As Date,
                                   ByVal _dtUltAtua As Date,
                                   ByVal _cStatus As eStatusDespesa,
                                   ByVal _rLog As String) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pDespesa.rDescricao, _rDescricao)
            bDados.AdicionaParametro(pDespesa.cValor, _cValor)
            bDados.AdicionaParametro(pDespesa.cConta, _cConta)
            bDados.AdicionaParametro(pDespesa.cCategoria, _cCategoria)
            bDados.AdicionaParametro(pDespesa.cPagamento, _cPagamento)
            bDados.AdicionaParametro(pDespesa.dtRegistro, _dtRegistro)
            bDados.AdicionaParametro(pDespesa.dtUltAtua, _dtUltAtua)
            bDados.AdicionaParametro(pDespesa.cStatus, _cStatus)
            bDados.AdicionaParametro(pDespesa.rLog, _rLog)

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
    Shared Sub AlterarDespesa(ByVal _cDespesa As Decimal,
                              ByVal _rDescricao As String,
                              ByVal _cValor As Decimal,
                              ByVal _cConta As Decimal,
                              ByVal _cCategoria As Decimal,
                              ByVal _cPagamento As Decimal,
                              ByVal _dtRegistro As Date,
                              ByVal _dtUltAtua As Date,
                              ByVal _cStatus As eStatusDespesa,
                              ByVal _rLog As String)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pDespesa.cDespesa, _cDespesa)
            bDados.AdicionaParametro(pDespesa.rDescricao, _rDescricao)
            bDados.AdicionaParametro(pDespesa.cValor, _cValor)
            bDados.AdicionaParametro(pDespesa.cConta, _cConta)
            bDados.AdicionaParametro(pDespesa.cCategoria, _cCategoria)
            bDados.AdicionaParametro(pDespesa.cPagamento, _cPagamento)
            bDados.AdicionaParametro(pDespesa.dtRegistro, _dtRegistro)
            bDados.AdicionaParametro(pDespesa.dtUltAtua, _dtUltAtua)
            bDados.AdicionaParametro(pDespesa.cStatus, _cStatus)
            bDados.AdicionaParametro(pDespesa.rLog, _rLog)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Shared Sub DeletarDespesa(ByVal _cDespesa As Decimal)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pDespesa.cDespesa, _cDespesa)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Shared Function PesquisarDespesa() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "GRID")

            oDataset = bDados.Obter(PROCEDURE)

            If oDataset IsNot Nothing Then
                Return oDataset
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Shared Function ObterDespesa(ByVal _cDespesa As Decimal) As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet

        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pDespesa.cDespesa, _cDespesa)

            oDataset = bDados.Obter(PROCEDURE)
            If oDataset IsNot Nothing Then
                Return oDataset
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

End Class
