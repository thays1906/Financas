Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pParcelamento
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pParcelamento"

    Class pParcelamento
        Public Shared cParcelamento As Campo = New Campo("cParcelamento", DbType.Decimal, 10)
        Public Shared cQtdeParcela As Campo = New Campo("cQtdeParcela", DbType.Decimal, 2)
        Public Shared cStatus As Campo = New Campo("cStatus", DbType.Decimal, 1)

    End Class

    Shared Function Inserir(ByVal _cQtdeparcela As Decimal) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pParcelamento.cQtdeParcela, _cQtdeparcela)

            bDados.Executar(PROCEDURE)

            If bDados.ObterUltimoErro = "" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Shared Function Alterar(ByVal _cParcelamento As Decimal, ByVal status As eStatus) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pParcelamento.cParcelamento, _cParcelamento)
            bDados.AdicionaParametro(pParcelamento.cStatus, status)

            bDados.Executar(PROCEDURE)

            If bDados.ObterUltimoErro = "" Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Shared Sub Deletar(ByVal _cParcelamento As Decimal)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pParcelamento.cParcelamento, _cParcelamento)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Shared Function CarregarGrid() As SuperDataSet
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
