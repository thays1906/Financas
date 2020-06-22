Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pContaBancaria
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pConta_Bancaria"

    Class pContaBancaria
        Public Shared cConta As Campo = New Campo("cConta", DbType.Decimal, 10, 0)
        Public Shared rBanco As Campo = New Campo("rBanco", DbType.String, 60, 0)
        Public Shared cAgencia As Campo = New Campo("cAgencia", DbType.Decimal, 6, 0)
        Public Shared cCta As Campo = New Campo("cCta", DbType.Decimal, 11, 0)
        Public Shared cSaldo As Campo = New Campo("cSaldo", DbType.Decimal, 18, 2)
        Public Shared cTipo As Campo = New Campo("cTipo", DbType.Decimal, 1, 0)
        Public Shared cPrincipal As Campo = New Campo("cPrincipal", DbType.Decimal, 1, 0)

    End Class

    Shared Function InserirConta(ByVal _rBanco As String,
                                 ByVal _cAgencia As Decimal,
                                 ByVal _cCta As Decimal,
                                 ByVal _cSaldo As Decimal,
                                 ByVal _cTipo As Decimal,
                                 ByVal _cPrincipal As Decimal) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pContaBancaria.rBanco, _rBanco)
            bDados.AdicionaParametro(pContaBancaria.cAgencia, _cAgencia)
            bDados.AdicionaParametro(pContaBancaria.cCta, _cCta)
            bDados.AdicionaParametro(pContaBancaria.cSaldo, _cSaldo)
            bDados.AdicionaParametro(pContaBancaria.cTipo, _cTipo)
            bDados.AdicionaParametro(pContaBancaria.cPrincipal, _cPrincipal)


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
    Shared Function AlterarConta(ByVal _cConta As Decimal,
                                ByVal _rBanco As String,
                                ByVal _cAgencia As Decimal,
                                ByVal _cCta As Decimal,
                                ByVal _cSaldo As Decimal,
                                ByVal _cTipo As Decimal,
                                ByVal _cPrincipal As Decimal) As Boolean

        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pContaBancaria.cConta, _cConta)
            bDados.AdicionaParametro(pContaBancaria.rBanco, _rBanco)
            bDados.AdicionaParametro(pContaBancaria.cAgencia, _cAgencia)
            bDados.AdicionaParametro(pContaBancaria.cCta, _cCta)
            bDados.AdicionaParametro(pContaBancaria.cSaldo, _cSaldo)
            bDados.AdicionaParametro(pContaBancaria.cTipo, _cTipo)
            bDados.AdicionaParametro(pContaBancaria.cPrincipal, _cPrincipal)


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
    Shared Function DeletarConta(ByVal _cConta As Decimal) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pContaBancaria.cConta, _cConta)

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
    Shared Function PesquisarConta() As SuperDataSet
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
    Shared Function ObterConta(ByVal _cConta As Decimal) As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pContaBancaria.cConta, _cConta)

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
    Shared Function CarregarConta() As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "COMB")

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
