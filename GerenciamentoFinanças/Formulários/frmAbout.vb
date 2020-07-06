Public Class frmAbout
    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLei.Text = "Aviso: Este programa de computador é protegido por leis de direitos autorais e tratados internacionais." & vbNewLine &
                      "A reprodução ou distribuição não-autorizada " &
                      "deste programa, ou qualquer parte dele, " &
                      "poderá resultar em severas punições civis e criminais, " &
                      "e os infratores serão punidos dentro do máximo rigor permitido por lei."
    End Sub


    Private Sub frmAbout_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        restaurarMDI()
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click

    End Sub
End Class