Option Explicit On
Option Strict On

Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Public Class SuperDataGridView
    Inherits DataGridView

    Private btnEditar As Boolean = False
    Private btnExcluir As Boolean = False

    Private bgCorSelecionado As Color = SystemColors.ControlDarkDark
    Private ColorTextSelecionado As Color = Color.White
    Private bgCorNaoSelecionado As Color = SystemColors.ButtonFace
    Private ColorTextNaoSelecionado As Color = Color.Black

    Private checkbox As DataGridViewCheckBoxColumn

    'BackgroundColor DataGrid
    Private bgColor As Color = Color.White

    'Cabeçalho
    Private bgColorHeader As Color = Color.LightSlateGray
    Private fontText As Font = New Font("Verdana", 12)
    Private colorText As Color = Color.White
    Public Property CorDoFundoCabeçalho As Color
        Get
            Return bgColorHeader
        End Get
        Set(value As Color)
            bgColorHeader = value
        End Set
    End Property

    Public Property CorTextoCabeçalho As Color
        Get
            Return colorText
        End Get
        Set(value As Color)
            colorText = value
        End Set
    End Property

    Sub New()
        Me.MultiSelect = True
        Me.ReadOnly = True
        Me.EnableHeadersVisualStyles = False
        Me.Anchor = (AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom)

        'Define a distribuição das colunas no DataGrid
        Me.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill     'Redimensiona as colunas para ocupar todo o DatGrid
        Me.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells 'Redimensiona as rows
        Me.SelectionMode = DataGridViewSelectionMode.FullRowSelect        'Select row inteira

        'Define a borda/grade das colunas
        Me.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        Me.BackgroundColor = bgColor

        'Style Columns
        Me.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.ColumnHeadersDefaultCellStyle.BackColor = bgColorHeader
        Me.ColumnHeadersDefaultCellStyle.Font = fontText
        Me.ColumnHeadersDefaultCellStyle.ForeColor = colorText
        Me.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue
        Me.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText

        'Style Rows
        Me.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        Me.CellBorderStyle = DataGridViewCellBorderStyle.SunkenHorizontal
        Me.DefaultCellStyle.BackColor = SystemColors.ButtonFace
        Me.DefaultCellStyle.ForeColor = Color.Black
        Me.DefaultCellStyle.SelectionBackColor = SystemColors.ControlDarkDark
        Me.DefaultCellStyle.SelectionForeColor = Color.White
        Me.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.RowHeadersVisible = False

    End Sub


    'Public Property SelecionarVarios As Boolean
    '    Get
    '        Return multSelect
    '    End Get

    '    Set(ByVal value As Boolean)
    '        multSelect = value
    '        Me.Invalidate()
    '    End Set
    'End Property
    Public Sub AdicionaCheckBoxColumn()
        Try
            checkbox = New DataGridViewCheckBoxColumn()
            checkbox.Name = "chkDataGrid"
            checkbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            checkbox.HeaderText = ""
            checkbox.DisplayIndex = 0
            Me.Columns.Add(checkbox)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub PreencheDataGrid(ByVal oDataSet As SuperDataSet,
                                Optional ByVal nTable As Integer = 0,
                                Optional ByVal posicaoId As Integer = Nothing,
                                Optional ByRef letreiro As SuperLetreiro = Nothing)
        Dim column As String = Nothing
        Dim ID As String = Nothing
        Try
            If oDataSet.TotalRegistros <> Nothing Then

                For i = 0 To oDataSet.TotalColunas - 1

                    column = oDataSet.NomeColuna(i, nTable)

                    If column.Substring(0, 3) = "as_" Or
                       column.Substring(0, 3) = "me_" Or
                       column.Substring(0, 3) = "nu_" Then

                        column = column.Substring(3)
                        If column.Contains("#") Then
                            column = column.Substring(0, column.IndexOf("#"))
                        End If
                        If column.Contains("_") Then
                            column = column.Replace("_", " ")
                        End If

                    ElseIf column.Substring(0, 3) = "id_" Then
                        ID = column.Substring(0, 3)
                    End If
                Next
                Me.DataSource = oDataSet.Tables(nTable)

                If posicaoId <> Nothing Then
                    Me.Columns(posicaoId).Visible = False
                End If
                Me.AutoResizeColumns()
                Me.Refresh()
            Else
                Me.Dispose()
                LogaErro("SuperLV::PreencheDataGrid [" & Me.Name & "] - ATENÇÃO: RecordSet=Nothing, por favor, verifique.")
                Exit Sub
            End If
            If Not letreiro Is Nothing Then
                letreiro.TextoLetreiro = oDataSet.InfoPesquisa
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::PreencheDataGrid: " & ex.ToString())
        End Try
    End Sub
    Public Function ObterChavesCheckBox(Optional ByVal columnId As Integer = 0) As String
        Dim rChave As String = Nothing
        Try
            If columnId = 0 Then
                columnId = 1
            End If
            For Each item As DataGridViewRow In Me.Rows
                If CBool(item.Cells(0).Value) = True Then
                    rChave += String.Concat(item.Cells(columnId).Value.ToString, ";")
                End If
            Next

            Return rChave

        Catch ex As Exception
            LogaErro("Erro em Util::ObterChavesCheckBox: " & ex.ToString())
            Return Nothing
        End Try

    End Function
    Public Function ObterTodasChaves(Optional ByVal columnId As Integer = 0) As String
        Dim rChave As String = Nothing
        Try

            If columnId = 0 Then
                    columnId = 1
                End If


                For Each item As DataGridViewRow In Me.Rows
                    If CBool(item.Selected) = True Then
                        rChave += String.Concat(item.Cells(columnId).Value.ToString, ";")
                    End If
                Next

                Return rChave

            Catch ex As Exception
                LogaErro("Erro em Util::ObterTodasChaves: " & ex.ToString())
            Return Nothing
        End Try

    End Function
    Public Function ObterChave(Optional columnId As Integer = 0) As Decimal
        Dim cChave As Decimal = Nothing
        Try



            For Each item As DataGridViewRow In Me.Rows
                    If CBool(item.Selected) = True Then
                    cChave = CDec(item.Cells(columnId).Value)
                    Exit For
                    End If
                Next

                Return cChave

            Catch ex As Exception
                LogaErro("Erro em Util::ObterChave: " & ex.ToString())
            Return Nothing
        End Try

    End Function
    Public Sub SelecionarCheckBoxDataGrid(sender As Object, e As DataGridViewCellEventArgs,
                                          Optional ByVal _bgColorNaoSelecionado As Color = Nothing,
                                          Optional ByVal colorTxtNaoSelecionado As Color = Nothing)

        'Seleciona a linha, chekbox, e mudar a cor da linha no DataGrid.
        Try
            If _bgColorNaoSelecionado <> Nothing Then
                bgCorNaoSelecionado = _bgColorNaoSelecionado
            End If

            If colorTxtNaoSelecionado <> Nothing Then
                ColorTextNaoSelecionado = colorTxtNaoSelecionado
            End If

            If Me.Rows(e.RowIndex).Index <> -1 Then

                'Se o click for com Ctrl pressionado ou sem.

                If Control.ModifierKeys = Keys.Control Or Control.ModifierKeys = Keys.None Then

                    If CBool(Me.Rows(e.RowIndex).Cells(0).Value) = False Then

                        Me.Rows(e.RowIndex).Cells(0).Value = True

                        Me.Rows(e.RowIndex).Selected = True
                        Me.Refresh()

                    ElseIf CBool(Me.Rows(e.RowIndex).Cells(0).Value) = True Then

                        Me.Rows(e.RowIndex).Selected = False
                        Me.Rows(e.RowIndex).Cells(0).Value = False
                        Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorNaoSelecionado
                        Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextNaoSelecionado

                    End If
                End If
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SelecionarCheckBoxDataGrid: " & ex.ToString())
        End Try
    End Sub
    Public Sub AdicionaImgColumn(ByRef oDataset As SuperDataSet,
                                 ByVal column As String,
                                 ByVal img As Bitmap)

        Dim image As ImageConverter
        Try
            image = New ImageConverter()

            For Each linha As DataRow In oDataset.Tables(0).Rows

                'Adiciona uma coluna do tipo ImageColumn no DataSet antes de carregar o DataGrid 
                'Seta a Imagem na coluna.

                linha(column) = image.ConvertTo(img, System.Type.GetType("System.Byte[]"))

            Next

        Catch ex As Exception
            LogaErro("Erro em Util::AdicionaImgColumn: " & ex.ToString())
        End Try
    End Sub
    Public Sub SelectRowsCheckBox()
        Try
            'Se o DataGrid tem checkBBox, verifica se o checkbox = checked, e seleciona a linha.

            For i = 0 To Me.Rows.Count - 1
                If CBool(Me.Rows(i).Cells(0).Value) = True Then
                    Me.Rows(i).Selected = True
                Else
                    Me.Rows(i).Selected = False
                End If
            Next


        Catch ex As Exception
            LogaErro("Erro em Util::SelectRowsCheckBox: " & ex.ToString())
        End Try
    End Sub
    Public Sub SelectRows()
        Try
            'Seleciona a linha do DataGrid

            For i = 0 To Me.Rows.Count - 1
                If CBool(Me.Rows(i).Selected) = True Then
                    Me.Rows(i).Selected = True
                Else
                    Me.Rows(i).Selected = False
                End If
            Next

        Catch ex As Exception
            LogaErro("Erro em Util::SelectRows: " & ex.ToString())
        End Try
    End Sub
    Public Sub SelecionaTodosCheck(ByRef chkTodos As CheckBox)
        Try
            'Seleciona/ Desmarca todos os CheckBox do DataGRid
            If Me.Rows.Count > 0 Then

                For i = 0 To Me.Rows.Count - 1
                    If chkTodos.Checked Then
                        Me.Rows(i).Selected = True
                        Me.Rows(i).Cells(0).Value = True
                    Else
                        Me.Rows(i).Selected = False
                        Me.Rows(i).Cells(0).Value = False
                        Me.ClearSelection()
                    End If
                Next
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SelecionaTodosCheck: " & ex.ToString())
        End Try
    End Sub
    Public Sub SelecionaTodosRows(ByRef chkTodos As CheckBox)
        Try
            If Me.Rows.Count > 0 Then

                For i = 0 To Me.Rows.Count - 1
                    If chkTodos.Checked Then
                        Me.Rows(i).Selected = True
                    Else
                        Me.Rows(i).Selected = False
                        Me.ClearSelection()
                    End If
                Next
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SelecionaTodosRows: " & ex.ToString())
        End Try
    End Sub
    Public Sub SelectRowLeave_CheckBox(sender As Object, e As DataGridViewCellEventArgs,
                                       Optional _bgColorSelecionado As Color = Nothing,
                                       Optional _textColorSelecionado As Color = Nothing) Handles Me.RowLeave

        Try
            If _bgColorSelecionado <> Nothing Then
                bgCorSelecionado = _bgColorSelecionado
            End If

            If _textColorSelecionado <> Nothing Then
                ColorTextSelecionado = _textColorSelecionado
            End If

            If CBool(Me.Rows(e.RowIndex).Cells(0).Value) = True Then

                Me.Rows(e.RowIndex).Selected = True
                Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorSelecionado
                Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextSelecionado
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SelectRowLeave_CheckBox: " & ex.ToString())
        End Try
    End Sub
    Public Sub SelectRowLeave(sender As Object, e As DataGridViewCellEventArgs,
                             Optional _bgColorSelecionado As Color = Nothing,
                             Optional _textColorSelecionado As Color = Nothing) Handles Me.RowLeave
        Try
            If _bgColorSelecionado <> Nothing Then
                bgCorSelecionado = _bgColorSelecionado
            End If

            If _textColorSelecionado <> Nothing Then
                ColorTextSelecionado = _textColorSelecionado
            End If

            If CBool(Me.Rows(e.RowIndex).Selected) = True Then

                Me.Rows(e.RowIndex).Selected = True
                Me.Rows(e.RowIndex).DefaultCellStyle.BackColor = bgCorSelecionado
                Me.Rows(e.RowIndex).DefaultCellStyle.ForeColor = ColorTextSelecionado
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::SelectRowLeave: " & ex.ToString())
        End Try
    End Sub
    Public Function ObterTodosChecados() As Decimal
        Dim total As Decimal = 0
        Try
            For Each row As DataGridViewRow In Me.Rows
                If row.Selected = True Then
                    total += 1
                End If
            Next

            Return total
        Catch ex As Exception
            LogaErro("Erro em Util::ObterTodosChecados: " & ex.ToString())
            Return Nothing
        End Try
    End Function
    Public Function ObterTodosCheckBoxChecados() As Decimal
        Dim total As Decimal = 0
        Try
            For Each row As DataGridViewRow In Me.Rows
                If CBool(row.Cells(0).Value) = True Then
                    total += 1
                End If
            Next

            Return total

        Catch ex As Exception
            LogaErro("Erro em Util::ObterTodosCheckBoxChecados: " & ex.ToString())
            Return Nothing
        End Try
    End Function
    Public Sub HabilitarDesabilitarEdicao(Optional ByRef SuperEditar As SuperButton = Nothing,
                                          Optional ByRef btnEditar As Button = Nothing)
        Try
            If SuperEditar Is Nothing And btnEditar Is Nothing Then

                LogaErro("SuperDataGridView::HabilitarDesabilitarEditar [" & Me.Name & "] - ATENÇÃO: Nenhum botao informado no parâmetro, por favor, informe.")

            Else
                If SuperEditar IsNot Nothing Then

                    If Me.SelectedRows.Count = 1 Then

                        SuperEditar.Enabled = True
                    Else
                        SuperEditar.Enabled = False

                    End If

                ElseIf btnEditar IsNot Nothing Then

                    If Me.SelectedRows.Count = 1 Then

                        btnEditar.Enabled = True
                    Else
                        btnEditar.Enabled = False

                    End If
                End If
            End If

        Catch ex As Exception
            LogaErro("Erro em Util::HabilitarDesabilitarEdicao: " & ex.ToString())
        End Try
    End Sub
    Public Sub HabilitarDesabilitarExclusao(Optional ByRef SuperExcluir As SuperButton = Nothing,
                                            Optional ByRef btnExcluir As Button = Nothing)
        Try
            If SuperExcluir Is Nothing And btnExcluir Is Nothing Then

                LogaErro("SuperDataGridView::HabilitarDesabilitarExclusao [" & Me.Name & "] - ATENÇÃO: Nenhum botao informado no parâmetro, por favor, informe.")
            Else
                If SuperExcluir IsNot Nothing Then

                    If Me.MultiSelect = True Then
                        If Me.SelectedRows.Count >= 1 Then
                            SuperExcluir.Enabled = True
                        Else
                            SuperExcluir.Enabled = False
                        End If

                    Else
                        If Me.SelectedRows.Count = 1 Then
                            SuperExcluir.Enabled = True
                        Else
                            SuperExcluir.Enabled = False
                        End If

                    End If

                ElseIf btnExcluir IsNot Nothing Then

                    If Me.MultiSelect = True Then

                        If Me.SelectedRows.Count >= 1 Then
                            btnExcluir.Enabled = True
                        Else
                            btnExcluir.Enabled = False
                        End If

                    Else
                        If Me.SelectedRows.Count = 1 Then
                            btnExcluir.Enabled = True
                        Else
                            btnExcluir.Enabled = False
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            LogaErro("Erro em Util::HabilitarDesabilitarExclusao: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles Me.DataBindingComplete
        Try
            For i = 0 To Me.Rows.Count - 1

                If Me.Rows(i).Selected Then

                    Me.Rows(i).Cells(0).Value = False
                    Me.ClearSelection()

                End If
            Next

            For i = 0 To Me.Columns.Count - 1

                If Me.Columns(i).Index <> Me.Columns(0).Index Then

                    Me.Columns(i).ReadOnly = True
                End If
            Next
        Catch ex As Exception
            LogaErro("Erro em Util::SuperDataGridView_DataBindingComplete: " & ex.ToString())
        End Try
    End Sub

    Private Sub SuperDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles Me.CurrentCellChanged
        Try


            For i = 0 To Me.Rows.Count - 1
                If CBool(Me.Rows(i).Cells(0).Value) = True Then
                    Me.Rows(i).Selected = True
                Else
                    Me.Rows(i).Selected = False
                End If
            Next


        Catch ex As Exception
            LogaErro("Erro em Util::SuperDataGridView_CurrentCellChanged: " & ex.ToString())
        End Try
    End Sub
End Class
