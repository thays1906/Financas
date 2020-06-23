Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmDespesaFixa
    Public cDespesaFixa As Decimal
    Sub New(ByVal _codigo As Decimal)

        ' This call is required by the designer.
        InitializeComponent()

        cDespesaFixa = _codigo

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmDespesaFixa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaEscuro)
    End Sub
End Class