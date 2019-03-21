<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtCSVFilePath = New System.Windows.Forms.TextBox()
        Me.btnOpenCSV = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveCSV = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSaveFile = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numRound = New System.Windows.Forms.NumericUpDown()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.numRound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCSVFilePath
        '
        Me.txtCSVFilePath.Location = New System.Drawing.Point(138, 26)
        Me.txtCSVFilePath.Name = "txtCSVFilePath"
        Me.txtCSVFilePath.ReadOnly = True
        Me.txtCSVFilePath.Size = New System.Drawing.Size(223, 20)
        Me.txtCSVFilePath.TabIndex = 0
        '
        'btnOpenCSV
        '
        Me.btnOpenCSV.Location = New System.Drawing.Point(388, 24)
        Me.btnOpenCSV.Name = "btnOpenCSV"
        Me.btnOpenCSV.Size = New System.Drawing.Size(35, 23)
        Me.btnOpenCSV.TabIndex = 1
        Me.btnOpenCSV.Text = "..."
        Me.btnOpenCSV.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CSV file:"
        '
        'btnSaveCSV
        '
        Me.btnSaveCSV.Location = New System.Drawing.Point(388, 69)
        Me.btnSaveCSV.Name = "btnSaveCSV"
        Me.btnSaveCSV.Size = New System.Drawing.Size(35, 23)
        Me.btnSaveCSV.TabIndex = 3
        Me.btnSaveCSV.Text = "..."
        Me.btnSaveCSV.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Output file:"
        '
        'txtSaveFile
        '
        Me.txtSaveFile.Location = New System.Drawing.Point(138, 71)
        Me.txtSaveFile.Name = "txtSaveFile"
        Me.txtSaveFile.ReadOnly = True
        Me.txtSaveFile.Size = New System.Drawing.Size(223, 20)
        Me.txtSaveFile.TabIndex = 5
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(205, 167)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 6
        Me.btnStart.Text = "Do it"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Round amount:"
        '
        'numRound
        '
        Me.numRound.Location = New System.Drawing.Point(160, 117)
        Me.numRound.Name = "numRound"
        Me.numRound.Size = New System.Drawing.Size(49, 20)
        Me.numRound.TabIndex = 8
        Me.numRound.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.ForeColor = System.Drawing.Color.Lime
        Me.lblSaved.Location = New System.Drawing.Point(192, 202)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(104, 24)
        Me.lblSaved.TabIndex = 9
        Me.lblSaved.Text = "File Saved!"
        Me.lblSaved.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1500
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 235)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.numRound)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtSaveFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSaveCSV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOpenCSV)
        Me.Controls.Add(Me.txtCSVFilePath)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.numRound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCSVFilePath As System.Windows.Forms.TextBox
    Friend WithEvents btnOpenCSV As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSaveCSV As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSaveFile As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numRound As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
