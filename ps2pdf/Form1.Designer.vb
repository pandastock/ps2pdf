<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BT_Convert = New Button()
        Label1 = New Label()
        Label2 = New Label()
        FolderBrowserDialog = New FolderBrowserDialog()
        source_file = New TextBox()
        dst_file = New TextBox()
        BT_browse1 = New Button()
        BT_browse2 = New Button()
        OpenFileDialog = New OpenFileDialog()
        SaveFileDialog = New SaveFileDialog()
        SuspendLayout()
        ' 
        ' BT_Convert
        ' 
        BT_Convert.Location = New Point(382, 219)
        BT_Convert.Name = "BT_Convert"
        BT_Convert.Size = New Size(112, 34)
        BT_Convert.TabIndex = 0
        BT_Convert.Text = "convert"
        BT_Convert.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(98, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 24)
        Label1.TabIndex = 1
        Label1.Text = "ps file:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(45, 136)
        Label2.Name = "Label2"
        Label2.Size = New Size(118, 24)
        Label2.TabIndex = 2
        Label2.Text = "output path:"
        ' 
        ' source_file
        ' 
        source_file.Location = New Point(192, 76)
        source_file.Name = "source_file"
        source_file.Size = New Size(327, 30)
        source_file.TabIndex = 3
        ' 
        ' dst_file
        ' 
        dst_file.Location = New Point(192, 130)
        dst_file.Name = "dst_file"
        dst_file.Size = New Size(327, 30)
        dst_file.TabIndex = 4
        ' 
        ' BT_browse1
        ' 
        BT_browse1.Location = New Point(525, 74)
        BT_browse1.Name = "BT_browse1"
        BT_browse1.Size = New Size(67, 34)
        BT_browse1.TabIndex = 5
        BT_browse1.Text = "..."
        BT_browse1.UseVisualStyleBackColor = True
        ' 
        ' BT_browse2
        ' 
        BT_browse2.Location = New Point(525, 126)
        BT_browse2.Name = "BT_browse2"
        BT_browse2.Size = New Size(67, 34)
        BT_browse2.TabIndex = 6
        BT_browse2.Text = "..."
        BT_browse2.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog
        ' 
        OpenFileDialog.FileName = "OpenFileDialog1"
        OpenFileDialog.Filter = """ps file|*.ps|all files|*.*"""
        ' 
        ' SaveFileDialog
        ' 
        SaveFileDialog.Filter = """pdf file|*.pdf|all files|*.*"""
        ' 
        ' form1
        ' 
        AccessibleRole = AccessibleRole.Clock
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(639, 296)
        Controls.Add(BT_browse2)
        Controls.Add(BT_browse1)
        Controls.Add(dst_file)
        Controls.Add(source_file)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BT_Convert)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "form1"
        Text = "ps2pdf"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BT_Convert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents source_file As TextBox
    Friend WithEvents dst_file As TextBox
    Friend WithEvents BT_browse1 As Button
    Friend WithEvents BT_browse2 As Button
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents SaveFileDialog As SaveFileDialog

End Class
