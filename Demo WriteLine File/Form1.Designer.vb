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
        Me.tombolCiptakan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tombolCiptakan
        '
        Me.tombolCiptakan.Location = New System.Drawing.Point(12, 88)
        Me.tombolCiptakan.Name = "tombolCiptakan"
        Me.tombolCiptakan.Size = New System.Drawing.Size(108, 35)
        Me.tombolCiptakan.TabIndex = 0
        Me.tombolCiptakan.Text = "Ciptakan File"
        Me.tombolCiptakan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(49, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Klik tombol Ciptakan File untuk memasukkan data dan menyimpannya ke dalam file"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(205, 88)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(108, 35)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 144)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tombolCiptakan)
        Me.Name = "Form1"
        Me.Text = "Demo WriteLine File Dengan Struktur"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tombolCiptakan As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
