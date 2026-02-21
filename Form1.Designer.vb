<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblScore = New Label()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        txtScore = New TextBox()
        btnGrade = New Button()
        lblResult = New Label()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblScore
        ' 
        lblScore.AutoSize = True
        lblScore.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblScore.Location = New Point(147, 115)
        lblScore.Name = "lblScore"
        lblScore.Size = New Size(92, 20)
        lblScore.TabIndex = 0
        lblScore.Text = "Enter Score:"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' txtScore
        ' 
        txtScore.Location = New Point(272, 115)
        txtScore.Name = "txtScore"
        txtScore.Size = New Size(59, 23)
        txtScore.TabIndex = 1
        ' 
        ' btnGrade
        ' 
        btnGrade.Font = New Font("Arial Narrow", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGrade.Location = New Point(147, 239)
        btnGrade.Name = "btnGrade"
        btnGrade.Size = New Size(92, 26)
        btnGrade.TabIndex = 2
        btnGrade.Text = "Get Grade"
        btnGrade.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.BorderStyle = BorderStyle.FixedSingle
        lblResult.Location = New Point(292, 245)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(39, 17)
        lblResult.TabIndex = 3
        lblResult.Text = "          "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveBorder
        ClientSize = New Size(800, 450)
        Controls.Add(lblResult)
        Controls.Add(btnGrade)
        Controls.Add(txtScore)
        Controls.Add(lblScore)
        Name = "Form1"
        Text = "Form1"
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblScore As Label
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents btnGrade As Button
    Friend WithEvents txtScore As TextBox
    Friend WithEvents lblResult As Label

End Class
