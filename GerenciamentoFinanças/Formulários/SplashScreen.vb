Imports GFT.Util.clsMsgBox
Imports GFT.Util
Public NotInheritable Class SplashScreen
    Public porcentagem As String
    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).
    Public cLogin As Integer

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        'If My.Application.Info.Title <> "" Then
        '    ApplicationTitle.Text = My.Application.Info.Title
        'Else
        '    'If the application title is missing, use the application name, without the extension
        '    ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        'End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright & ". Todos os direitos reservados."
    End Sub
    Private Sub Verifica()
        Dim oDataset As SuperDataSet
        Try
            oDataset = New SuperDataSet

            oDataset = pUsuario.Verificar()


            If oDataset Is Nothing OrElse CType(oDataset("cActiveLogin"), eStatus) = eStatus.Ativo Then
                Me.DialogResult = DialogResult.Yes
            ElseIf CType(oDataset("cActiveLogin"), eStatus) = eStatus.Inativo Then
                Me.DialogResult = DialogResult.No
            End If

        Catch ex As Exception
            S_MsgBox(ex.Message, eBotoes.Ok, "Houve um erro.",, eImagens.Cancel)
        End Try
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        ProgressBar.Increment(1)

        If ProgressBar.Value = 100 Then
            Timer.Stop()

            Verifica()
            Me.Close()
        End If

    End Sub
End Class
