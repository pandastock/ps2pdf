Imports System.ComponentModel.DataAnnotations

Public Class form1

    Dim exepath As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            exepath = My.Computer.FileSystem.ReadAllText("./config.ini")
            ' RichTextBox1.Text = fileText
        Catch ex As System.IO.FileNotFoundException
            MsgBox("File not found: " & ex.Message)
        Catch ex As Exception
            MsgBox("Error reading file: " & ex.Message)
        End Try
    End Sub

    Private Sub BT_browse1_Click(sender As Object, e As EventArgs) Handles BT_browse1.Click
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            source_file.Text = OpenFileDialog.FileName
        End If
    End Sub

    Private Sub BT_browse2_Click(sender As Object, e As EventArgs) Handles BT_browse2.Click
        'If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
        '    dst_file.Text = FolderBrowserDialog.SelectedPath
        'End If
        If SaveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = SaveFileDialog.FileName
            dst_file.Text = filePath
        End If
    End Sub

    Private Sub BT_Convert_Click(sender As Object, e As EventArgs) Handles BT_Convert.Click
        Dim output As String
        Dim length As Integer
        Dim cmdStr

        If source_file.Text = "" Or Len(source_file.Text) < 2 Then
            MessageBox.Show("You must select a ps file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        If dst_file.Text = "" Then
            output = source_file.Text
            length = Len(output)
            output = Microsoft.VisualBasic.Left(output, length - 2)
            output = output + "pdf"
            dst_file.Text = output
        End If

        cmdStr = exepath + " " + source_file.Text + " " + dst_file.Text

        Try
            Shell(cmdStr,, True)
        Catch ex As Exception
            MessageBox.Show("File ps2pdf or ps file not found!", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub source_file_TextChanged(sender As Object, e As EventArgs) Handles source_file.TextChanged

    End Sub
End Class
