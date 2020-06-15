Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pCategoriaDespesa
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pCategoria_Despesa"

    Class pCategoria
        Public Shared cCategoria As Campo = New Campo("cCategoria", DbType.Decimal, 10)
        Public Shared rCategoria As Campo = New Campo("rCategoria", DbType.String, 100)
    End Class

    Shared Function IncluirCategoria(ByVal _rCategoria As String) As Boolean
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pCategoria.rCategoria, _rCategoria)

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
    Shared Sub AlterarCategoria(ByVal _cCategoria As Decimal, ByVal _rCategoria As String)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pCategoria.cCategoria, _cCategoria)
            bDados.AdicionaParametro(pCategoria.rCategoria, _rCategoria)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Sub DeletarCategoria(ByVal _cCategoria As Decimal)
        Dim bDados As BancoDados
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pCategoria.cCategoria, _cCategoria)

            bDados.Executar(PROCEDURE)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Shared Function CarregarCategoria() As SuperDataSet
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

    Shared Function ObterCategoria(ByVal _cCategoria As Decimal) As SuperDataSet
        Dim bDados As BancoDados
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pCategoria.cCategoria, _cCategoria)

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
