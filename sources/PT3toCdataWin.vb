﻿Imports System.IO
Imports System.Xml
Imports System.Windows.Forms

''' <summary>
''' PT3toCdata Converter Tool
''' Copyright 2022 mvac7 (aka aorante) 
''' 
''' Vortex PT3 to C data Converter Tool for PT3 Player MSX SDCC Library (fR3eL Project) 
''' or other libraries (that use the same generated data format).
''' 
''' Vortex Tracker And Vortex PT3 Player are developed by Sergey Bulba.
'''
''' License:
''' This program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License 
''' as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.
''' 
''' This program is distributed in the hope that it will be useful, 
''' but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
''' See the GNU General Public License for more details.
''' 
''' You should have received a copy of the GNU General Public License along with this program.    
''' If not, see http://www.gnu.org/licenses/
''' 
''' </summary>
Public Class PT3toCdataWin

    Private _txtPath As String

    Private PT3_FileData As Byte()

    Private TrackerName As String

    Private SongName As String
    Private SongAuthor As String
    Private SongNoteTable As Integer


    Private PT3_Path As String



    Private Sub PT3toCdataWin_Load(sender As Object, e As EventArgs) Handles Me.Load

        About()

        SetTitle("")

    End Sub



    Private Sub SetTitle(ByVal filename As String)

        Dim debuging As String = ""

        If Not filename = "" Then
            filename = " · [" + filename + "]"
        End If

        'If Me.TEST_MODE Then
        '    debuging = " > DEBUG MODE <"
        'End If

        Me.Text = My.Application.Info.Title + " v" + My.Application.Info.Version.ToString + filename
    End Sub



    ''' <summary>
    ''' Load binary file.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function LoadBinary(ByVal filePath As String) As Byte()

        Dim aStream As FileStream
        Dim aFile As New FileInfo(filePath)

        Dim aFileData As Byte()

        Dim conta As Integer = 7

        Dim filesize As Long = aFile.Length - 1

        If filesize > 65536 Then
            Return Nothing
        End If

        aStream = New System.IO.FileStream(filePath, FileMode.Open)

        ReDim aFileData(filesize)

        aStream.Read(aFileData, 0, filesize)
        aStream.Close()

        Return aFileData

    End Function



    Private Sub InitFileData()

        Dim trackerNameASCII(21) As Byte
        Dim songNameASCII(31) As Byte
        Dim songAuthorASCII(31) As Byte

        Array.Copy(Me.PT3_FileData, 0, trackerNameASCII, 0, 22)
        Array.Copy(Me.PT3_FileData, 30, songNameASCII, 0, 32)
        Array.Copy(Me.PT3_FileData, 66, songAuthorASCII, 0, 32)

        Me.TrackerName = System.Text.Encoding.ASCII.GetString(trackerNameASCII)
        Me.SongName = System.Text.Encoding.ASCII.GetString(songNameASCII)
        Me.SongAuthor = System.Text.Encoding.ASCII.GetString(songAuthorASCII)

        Me.SongNoteTable = CInt(Me.PT3_FileData(99))

        Me.SongName = Me.SongName.Trim()
        Me.SongAuthor = Me.SongAuthor.Trim()

        Me.Name_TextBox.Text = Me.SongName
        Me.Author_TextBox.Text = Me.SongAuthor
        Me.NoteTableTextBox.Text = CStr(Me.SongNoteTable)

        GenerateData()

    End Sub



    Private Sub GenerateData()

        Dim aDataFormat As New DataFormat

        Dim labelName As String = Me.LabelTextBox.Text

        Dim comments As New ArrayList

        Dim outputData() As Byte

        Dim fileOutputSize As Integer
        Dim initValue As Integer = 0


        If Me.PT3_FileData Is Nothing Then
            Exit Sub
        End If


        If Me.HeaderCheckBox.Checked Then
            initValue = 100
        End If

        fileOutputSize = (Me.PT3_FileData.Length - initValue)

        ReDim outputData(fileOutputSize - 1)

        Array.Copy(Me.PT3_FileData, initValue, outputData, 0, fileOutputSize)

        OutputText.Text = "// " + Me.TrackerName + vbNewLine
        OutputText.Text += "// Song name: " + Me.SongName + vbNewLine
        OutputText.Text += "// Song author: " + Me.SongAuthor + vbNewLine
        OutputText.Text += "// Note Table: " + CStr(Me.SongNoteTable) + vbNewLine + vbNewLine

        If SongInfo_CheckBox.Checked Then
            OutputText.Text += "const char " + labelName + "_name[] = " + Chr(34) + Me.SongName + Chr(34) + ";" + vbNewLine
            OutputText.Text += "const char " + labelName + "_author[] = " + Chr(34) + Me.SongAuthor + Chr(34) + ";" + vbNewLine + vbNewLine
        End If

        comments.Add(Path.GetFileName(Me.PT3_Path))
        comments.Add("Length: " + CStr(outputData.Length))
        If Me.HeaderCheckBox.Checked Then
            comments.Add("Not contain the 100 Byte header")
        End If

        OutputText.Text += aDataFormat.GetCcode(outputData, 16, DataFormat.DataType.HEXADECIMAL_0xnn, labelName, comments, "const char")

    End Sub


    ''' <summary>
    ''' Copy output to clipboard
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CopyAll()
        If Me.OutputText.Text = "" Then
            MsgBox("Nothing to copy for you...", MsgBoxStyle.Exclamation, "Alert")
        Else
            My.Computer.Clipboard.SetText(Me.OutputText.Text)
        End If
    End Sub




    Private Sub Load_Dialog()
        'If Me.binaryFilePath = "" Then
        Me.OpenFileDialog1.FileName = ""
        '    Me.OpenFileDialog1.InitialDirectory = Me.AppConfig.PathItemBinary.Path
        'Else
        '    Me.OpenFileDialog1.FileName = Path.GetFileName(Me.filePath)
        '    Me.OpenFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.filePath)
        'End If

        'Me.OpenFileDialog1.DefaultExt = "prj"
        Me.OpenFileDialog1.Filter = "Vortex Tracker files|*.pt3"

        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LoadPT3(OpenFileDialog1.FileName)
        End If

    End Sub


    Private Sub LoadPT3(ByVal filePath As String)

        Me.PT3_Path = filePath

        Me.PT3_FileData = LoadBinary(filePath)
        SetTitle(Path.GetFileName(filePath))
        InitFileData()

    End Sub




    Private Sub SaveAs()

        If Me.OutputText.Text = "" Then
            MsgBox("Nothing to save for you...", MsgBoxStyle.Exclamation, "Alert")
        Else

            Me.SaveFileDialog1.Filter = "C Header file|*.h"

            If Not Me.PT3_Path = "" Then
                Me.SaveFileDialog1.InitialDirectory = Path.GetDirectoryName(Me.PT3_Path)
                Me.SaveFileDialog1.FileName = Path.GetFileNameWithoutExtension(Me.PT3_Path) + "_PT3"
            End If

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

                Me.saveCode(SaveFileDialog1.FileName)

            End If

        End If

    End Sub



    ''' <summary>
    ''' Save source output.
    ''' </summary>
    ''' <param name="filePath"></param>
    ''' <remarks></remarks>
    Private Sub saveCode(ByVal filePath As String)
        Dim aStreamWriterFile As New System.IO.StreamWriter(filePath)
        aStreamWriterFile.WriteLine(Me.OutputText.Text)
        aStreamWriterFile.Close()
    End Sub



    Private Sub CopyAllButton_Click(sender As Object, e As EventArgs) Handles CopyAllButton.Click
        CopyAll()
    End Sub

    Private Sub SaveAsButton_Click(sender As Object, e As EventArgs) Handles SaveAsButton.Click
        SaveAs()
    End Sub

    Private Sub Load_Button_Click(sender As Object, e As EventArgs) Handles Load_Button.Click
        Load_Dialog()
    End Sub



    Private Sub HeaderCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles HeaderCheckBox.CheckedChanged
        GenerateData()
    End Sub



    Private Sub SongInfo_CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SongInfo_CheckBox.CheckedChanged
        GenerateData()
    End Sub



    Private Sub LabelTextBox_TextChanged(sender As Object, e As EventArgs) Handles LabelTextBox.TextChanged
        GenerateData()
    End Sub



    Private Sub PT3toCdataWin_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub



    Private Sub PT3toCdataWin_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim tmpstr() As String = e.Data.GetData("FileDrop", False)
        Dim filePath As String = tmpstr(0)

        Me.BringToFront()
        Me.Activate()

        If Path.GetExtension(filePath).ToUpper = ".PT3" Then
            LoadPT3(filePath)
        End If

    End Sub



    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        About()
    End Sub


    Private Sub About()
        Dim aboutWin As New AboutForm()
        aboutWin.ShowDialog(Me)
    End Sub



End Class
