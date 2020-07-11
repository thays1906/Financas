Imports GFT.Util
Imports GFT.Util.BancoDados
Public Class pUsuario
    Public Const Procedure As String = "pUsuario"
    Public Shared Operacao As Campo = New Campo("Operacao", DbType.String, 4)
    Public Shared bDados As BancoDados
    Class pUsuario
        Public Shared cUsuario As Campo = New Campo("cUsuar", DbType.Decimal, 10, 0)
        Public Shared rUsuario As Campo = New Campo("rUsuar", DbType.String, 100)
        Public Shared rSenha As Campo = New Campo("rSenha", DbType.String, 16)
        Public Shared cActiveLogin As Campo = New Campo("cActiveLogin", DbType.Decimal, 1, 0)

    End Class

    Shared Function Inserir(ByVal _usuario As String,
                            ByVal _senha As String,
                            ByVal _cActiveLogin As eStatus) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "INSE")
            bDados.AdicionaParametro(pUsuario.rUsuario, _usuario)
            bDados.AdicionaParametro(pUsuario.rSenha, _senha)
            bDados.AdicionaParametro(pUsuario.cActiveLogin, _cActiveLogin)


            If bDados.Executar(Procedure) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Shared Function Alterar(ByVal _cUsuar As Decimal, ByVal _senha As String) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "ALTE")
            bDados.AdicionaParametro(pUsuario.cUsuario, _cUsuar)
            bDados.AdicionaParametro(pUsuario.rSenha, _senha)

            If bDados.Executar(Procedure) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    Shared Function Verificar() As SuperDataSet
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "CHEK")
            'bDados.AdicionaParametro(pUsuario.cUsuario, _cUsuar)
            'bDados.AdicionaParametro(pUsuario.rUsuario, _usuario)

            oDataset = bDados.Obter(Procedure)
            If oDataset.TotalRegistros > 0 Then
                Return oDataset
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function
    Shared Function SemUsuario(ByVal _cActiveLogin As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "NULL")
            bDados.AdicionaParametro(pUsuario.cActiveLogin, _cActiveLogin)



            If bDados.Executar(Procedure) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function

    'Caso escolha 
    Shared Function DesativarUsuario(ByVal _cUsuar As Decimal,
                               ByVal _cActiveLogin As Decimal) As Boolean
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "OFF")
            bDados.AdicionaParametro(pUsuario.cUsuario, _cUsuar)
            bDados.AdicionaParametro(pUsuario.cActiveLogin, _cActiveLogin)



            If bDados.Executar(Procedure) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function
    Shared Function Obter(ByVal _rUsuar As String) As SuperDataSet
        Dim oDataset As SuperDataSet
        Try
            bDados = New BancoDados()

            bDados.LimpaParametros()

            bDados.AdicionaParametro(Operacao, "OBTE")
            bDados.AdicionaParametro(pUsuario.rUsuario, _rUsuar)


            oDataset = bDados.Obter(Procedure)
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
