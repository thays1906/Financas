Imports GFT.Util
Imports GFT.Util.BancoDados

Public Class pReceita
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pReceita"

    Class pReceita
        Public Shared cReceita As Campo = New Campo("cReceita", DbType.Decimal, 10, 0)
        Public Shared dtRec As Campo = New Campo("dtRec", DbType.DateTime, 10)
        Public Shared rDescricao As Campo = New Campo("rDescricao", DbType.String, 100)
        Public Shared cValor As Campo = New Campo("cValor", DbType.Decimal, 18, 2)
        Public Shared cConta As Campo = New Campo("cConta", DbType.Decimal, 10, 0)
        Public Shared cTipo As Campo = New Campo("cTipo", DbType.Decimal, 10, 0)
        Public Shared rLog As Campo = New Campo("rLog", DbType.String, -1)
    End Class

    Public Function InserirReceita(ByVal _dtRec As Date,
                                   ByVal _rDescricao As String,
                                   ByVal _cValor As Decimal,
                                   ByVal _cConta As Decimal,
                                   ByVal _cTipo As Decimal,
                                   ByVal _rLog As String) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pReceita.dtRec, _dtRec)
            bDados.AdicionaParametro(pReceita.rDescricao, _rDescricao)
            bDados.AdicionaParametro(pReceita.cValor, _cValor)
            bDados.AdicionaParametro(pReceita.cConta, _cConta)
            bDados.AdicionaParametro(pReceita.cTipo, _cTipo)
            bDados.AdicionaParametro(pReceita.rLog, _rLog)

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
    Public Sub AlterarReceita(ByVal _cReceita As Decimal,
                              ByVal _rDescricao As String,
                              ByVal _cValor As Decimal,
                              ByVal _cConta As Decimal,
                              ByVal _cTipo As Decimal,
                              ByVal _rLog As String)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pReceita.cReceita, _cReceita)
            bDados.AdicionaParametro(pReceita.rDescricao, _rDescricao)
            bDados.AdicionaParametro(pReceita.cValor, _cValor)
            bDados.AdicionaParametro(pReceita.cConta, _cConta)
            bDados.AdicionaParametro(pReceita.cTipo, _cTipo)
            bDados.AdicionaParametro(pReceita.rLog, _rLog)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub DeletarReceita(ByVal _cReceita As Decimal)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pReceita.cReceita, _cReceita)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function PesquisarReceita() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "GRID")

            oDataset = bDados.ObterQuery(PROCEDURE)
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
    Public Function ObterReceita(ByVal _cReceita As Decimal) As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet

        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pReceita.cReceita, _cReceita)

            oDataset = bDados.ObterQuery(PROCEDURE)
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
