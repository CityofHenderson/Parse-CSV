Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1

    Private Sub btnOpenCSV_Click(sender As Object, e As EventArgs) Handles btnOpenCSV.Click
        Dim selectFile As New OpenFileDialog()
        selectFile.ShowDialog()
        If (selectFile.FileName <> "") Then
            txtCSVFilePath.Text = selectFile.FileName
        End If
    End Sub

    Private Sub btnSaveCSV_Click(sender As Object, e As EventArgs) Handles btnSaveCSV.Click
        Dim saveFile As New SaveFileDialog()
        saveFile.Filter = "TXT File|*.txt"
        saveFile.ShowDialog()
        If (saveFile.FileName <> "") Then
            txtSaveFile.Text = saveFile.FileName
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (txtSaveFile.Text <> "" AndAlso txtCSVFilePath.Text <> "") Then
            Try
                Dim results As New StringBuilder
                Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(txtCSVFilePath.Text)
                Dim a As String
                Dim latIndex As Integer = 32
                Dim lonIndex As Integer = 33
                Dim indexOffset As Integer = 0
                Dim roundAmount As Integer = numRound.Value
                Do
                    indexOffset = 0
                    a = reader.ReadLine
                    If (a <> Nothing) Then
                        Dim detectBadFormatting = New Regex(""".*(,\d*)*""")
                        Dim match = detectBadFormatting.Match(a)
                        indexOffset += match.Value.Split(",").Length - 1
                        Dim line = a.Split(",")
                        If (line(latIndex + indexOffset) <> "" AndAlso line(lonIndex + indexOffset) <> "") Then
                            results.AppendLine(line(0).PadRight(40, " ") & Math.Round(Math.Abs(CDbl(line(latIndex + indexOffset))), roundAmount) & " " & Math.Round(Math.Abs(CDbl(line(lonIndex + indexOffset))), roundAmount))
                        End If
                    End If
                Loop Until a Is Nothing

                reader.Close()

                IO.File.WriteAllText(txtSaveFile.Text, results.ToString())
                lblSaved.Visible = True
                Timer1.Start()
            Catch ex As Exception
                MessageBox.Show(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        lblSaved.Visible = False
    End Sub
End Class
