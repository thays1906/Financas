Imports Microsoft.Win32
Imports System.Management

Public Class frmInfoSO

    Private Sub frmInfoSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Infomacao()
    End Sub

    Private Sub Infomacao()

        Try


            Dim s4 As ManagementObjectSearcher = New ManagementObjectSearcher("SELECT Capacity FROM Win32_PhysicalMemory")
            Dim resp As String = ""

            For Each mo As ManagementObject In s4.Get()
                resp = Convert.ToString(mo("Capacity"))
            Next


            Dim memoriaRam As Double = Convert.ToDouble(resp)
            Dim memoriaRamTotal As Double = 0
            memoriaRamTotal = memoriaRam / 1024 / 1024


            txtInfo.AppendText("Nome do Computador: " & Environment.MachineName &
                               vbNewLine & vbNewLine)

            txtInfo.AppendText("User: " & Environment.UserName &
                               vbNewLine & vbNewLine)


            txtInfo.AppendText("Sistema Operacional: " &
                               Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\Setup\MoSetup\Volatile",
                                                 "DownlevelProductName", "Não encontrado").ToString &
                               vbNewLine & vbNewLine)

            txtInfo.AppendText("Processador: " &
                               Registry.GetValue("HKEY_LOCAL_MACHINE\HARDWARE\DESCRIPTION\System\CentralProcessor\0",
                                                 "ProcessorNameString", "").ToString &
                                vbNewLine & vbNewLine)

            txtInfo.AppendText("Arquitetura: " &
                IIf(Environment.Is64BitOperatingSystem, "x64", "x32").ToString &
                vbNewLine & vbNewLine)


            txtInfo.AppendText("Memória RAM: " & memoriaRamTotal.ToString &
                               vbNewLine & vbNewLine)


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Me.Close()
    End Sub
End Class