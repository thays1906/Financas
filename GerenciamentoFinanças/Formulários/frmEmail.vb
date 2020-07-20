Imports GFT.Util
Imports GFT.Util.clsMsgBox
Public Class frmEmail
    Public oDataSet As SuperDataSet
    Private Sub frmEmail_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        alterarCaptionFormPrincipal(eTela.Email)
    End Sub

    Private Sub frmEmail_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        restaurarMDI()
    End Sub
    Private Sub Pesquisar()
        Dim rs As SuperDataSet
        Try
            oDataSet = New SuperDataSet()

            oDataSet = pContaBancaria.PesquisarConta
            dgConsulta.PreencheDataGrid(oDataSet, 0, 7)

            rs = pContaBancaria.PesquisarConta
            dgNormal.DataSource = rs.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cor(Me, Collor.CinzaBranco)
        Pesquisar()
    End Sub

    Private Sub dgNormal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgNormal.CellClick

    End Sub

    Private Sub chkEMail_CheckedChanged(sender As Object, e As EventArgs) Handles chkEMail.CheckedChanged
        dgConsulta.SelecionaTodos(chkEMail)
    End Sub

    Private Sub btnObter_Click(sender As Object, e As EventArgs) Handles btnObter.Click
        txtObter.Text = dgConsulta.ObterTodosChecados().ToString
    End Sub
End Class