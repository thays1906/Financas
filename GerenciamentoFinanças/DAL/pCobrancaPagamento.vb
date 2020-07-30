Imports GFT.Util.BancoDados
Imports GFT.Util

Public Class pCobrancaPagamento
    Public Const PROCEDURE As String = "pCobranca_Pagamento"
    Public Shared OPERACAO As Campo = New Campo("Operacao", DbType.String, 4)
    Public Shared bDados As BancoDados

    Class pCobrancaPagamento
        Public Shared cCobranca As Campo = New Campo("cCobrPag", DbType.Decimal, 10, 0)
        Public Shared dtRegistro As Campo = New Campo("dtRegistro", DbType.Date, 10, 0)
        Public Shared cValor As Campo = New Campo("cValor", DbType.Decimal, 18, 2)
        Public Shared rTitular As Campo = New Campo("rTitular", DbType.String, 100)
        Public Shared cStatus As Campo = New Campo("cStatus", DbType.Decimal, 2, 0)
        Public Shared cConta As Campo = New Campo("cConta", DbType.Decimal, 10, 0)
        Public Shared dtFim As Campo = New Campo("dtFim", DbType.Date, 10, 0)
        Public Shared cMes As Campo = New Campo("cMes", DbType.Decimal, 2, 0)
        Public Shared cAno As Campo = New Campo("cAno", DbType.Decimal, 4, 0)
        Public Shared cLembrete As Campo = New Campo("cLembrete", DbType.Decimal, 1, 0)
        Public Shared dtEspecifica As Campo = New Campo("dtEspecifica", DbType.Date, 10, 0)
        Public Shared cFrequencia As Campo = New Campo("cFrequencia", DbType.Decimal, 4, 0)

    End Class

    Shared Function Inserir(ByVal _dtReg As Date,
                            ByVal _cValor As Decimal,
                            ByVal _rNome As String,
                            ByVal _cStatus As eStatusDespesa,
                            ByVal _cConta As Decimal,
                            ByVal _cLembrete As Decimal,
                            ByVal _dtFixa As Date,
                            ByVal _cFrequencia As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "INSE")
            bDados.AdicionaParametro(pCobrancaPagamento.dtRegistro, _dtReg)
            bDados.AdicionaParametro(pCobrancaPagamento.cValor, _cValor)
            bDados.AdicionaParametro(pCobrancaPagamento.rTitular, _rNome)
            bDados.AdicionaParametro(pCobrancaPagamento.cStatus, _cStatus)
            bDados.AdicionaParametro(pCobrancaPagamento.cConta, _cConta)
            bDados.AdicionaParametro(pCobrancaPagamento.cLembrete, _cLembrete)

            If _cLembrete = 1 Then
                If _cFrequencia <> 0 Then
                    bDados.AdicionaParametro(pCobrancaPagamento.dtEspecifica, Nothing)
                Else
                    bDados.AdicionaParametro(pCobrancaPagamento.dtEspecifica, _dtFixa)
                End If
            Else
                bDados.AdicionaParametro(pCobrancaPagamento.dtEspecifica, Nothing)
            End If

            bDados.AdicionaParametro(pCobrancaPagamento.cFrequencia, _cFrequencia)

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
    Shared Function Alterar(ByVal _cCobrPag As Decimal,
                            ByVal _dtReg As Date,
                            ByVal _cValor As Decimal,
                            ByVal _rNome As String,
                            ByVal _cStatus As eStatusDespesa,
                            ByVal _cConta As Decimal,
                            ByVal _cLembrete As Decimal,
                            ByVal _dtFixa As Date,
                            ByVal _cFrequencia As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "ALTE")
            bDados.AdicionaParametro(pCobrancaPagamento.cCobranca, _cCobrPag)
            bDados.AdicionaParametro(pCobrancaPagamento.dtRegistro, _dtReg)
            bDados.AdicionaParametro(pCobrancaPagamento.cValor, _cValor)
            bDados.AdicionaParametro(pCobrancaPagamento.rTitular, _rNome)
            bDados.AdicionaParametro(pCobrancaPagamento.cStatus, _cStatus)
            bDados.AdicionaParametro(pCobrancaPagamento.cConta, _cConta)
            bDados.AdicionaParametro(pCobrancaPagamento.cLembrete, _cLembrete)
            bDados.AdicionaParametro(pCobrancaPagamento.dtEspecifica, _dtFixa)
            bDados.AdicionaParametro(pCobrancaPagamento.cFrequencia, _cFrequencia)


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
    Shared Function Deletar(ByVal _cCobrPag As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "DELE")
            bDados.AdicionaParametro(pCobrancaPagamento.cCobranca, _cCobrPag)

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

    Shared Function Obter(ByVal _cCobrPag As Decimal) As SuperDataSet
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "OBTE")
            bDados.AdicionaParametro(pCobrancaPagamento.cCobranca, _cCobrPag)

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
    Shared Function Pesquisar(ByVal _dtInicio As Date,
                               ByVal _dtFim As Date,
                               ByVal _cMes As Decimal,
                               ByVal _cAno As Decimal,
                               ByVal _rNome As String,
                               ByVal _cStatus As eStatusDespesa,
                               ByRef CHK As CheckBox) As SuperDataSet

        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "GRID")

            If CHK.Checked Then
                bDados.AdicionaParametro(pCobrancaPagamento.dtRegistro, _dtInicio)
                bDados.AdicionaParametro(pCobrancaPagamento.dtFim, _dtFim)
            Else
                bDados.AdicionaParametro(pCobrancaPagamento.cMes, _cMes)
                bDados.AdicionaParametro(pCobrancaPagamento.cAno, _cAno)
            End If

            If _rNome.Contains("Todos") Then
                _rNome = Nothing
            End If
            bDados.AdicionaParametro(pCobrancaPagamento.rTitular, _rNome)
            bDados.AdicionaParametro(pCobrancaPagamento.cStatus, _cStatus)



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
    Shared Function CarregarCombo() As SuperDataSet
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
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Shared Function BuscarLembrete() As SuperDataSet
        Dim oDataSet As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(OPERACAO, "LEMB")


            oDataSet = bDados.Obter(PROCEDURE)

            If Not oDataSet Is Nothing Then
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
