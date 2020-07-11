Imports GFT.Util
Imports GFT.Util.BancoDados

Public Class pInicializacao
    Public Const PROCEDURE As String = "pInicializacao"
    Public Shared Operacao As Campo = New Campo("Operacao", DbType.String, 4)
    Public Shared bDados As BancoDados
    Public Shared registro As SuperDataSet

    Shared Function Iniciar() As Boolean

        Try
            bDados = New BancoDados()

            'Verificando se é uma nova instalação
            bDados.LimpaParametros()
            bDados.AdicionaParametro(Operacao, "CHEK")

            registro = bDados.Obter(PROCEDURE)

            If registro.TotalRegistros = Nothing Then
                'Criando registros para instalação

                bDados.LimpaParametros()

                If bDados.Executar(PROCEDURE) Then
                    Return True
                Else
                    Return False
                End If
            End If

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
    End Function


End Class
