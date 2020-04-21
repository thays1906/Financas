Imports GFT.Util
Imports GFT.Util.BancoDados

Public Class pReceita
    Public Shared OPERACAO As Campo = New Campo("OPERACAO", DbType.String, 4)
    Public Const PROCEDURE As String = "pReceita"

    Class pConsulta
        Public Shared cConsulta As Campo = New Campo("cConsulta", DbType.Decimal, 10, 0)
        Public Shared dtCriacao As Campo = New Campo("dtCriacao", DbType.DateTime, 10)
        Public Shared rReceita As Campo = New Campo("rReceita", DbType.String, 50)
        Public Shared cValorReceita As Campo = New Campo("cValorReceita", DbType.Decimal, 18, 0)
        Public Shared rDespesa As Campo = New Campo("rDespesa", DbType.String, 50)
        Public Shared cValorDespesa As Campo = New Campo("cValorDespesa", DbType.Decimal, 18, 0)
    End Class

    Public Sub InserirReceita()
        Dim bDados As BancoDados
    End Sub
End Class
