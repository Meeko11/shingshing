<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main2
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.main3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.main1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Location = New System.Drawing.Point(370, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 364)
        Me.Panel1.TabIndex = 7
        '
        'main3
        '
        Me.main3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.main3.Location = New System.Drawing.Point(80, 281)
        Me.main3.Name = "main3"
        Me.main3.Size = New System.Drawing.Size(180, 57)
        Me.main3.TabIndex = 6
        Me.main3.Text = "main3"
        Me.main3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(80, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 57)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'main1
        '
        Me.main1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.main1.Location = New System.Drawing.Point(80, 68)
        Me.main1.Name = "main1"
        Me.main1.Size = New System.Drawing.Size(180, 57)
        Me.main1.TabIndex = 4
        Me.main1.Text = "main1"
        Me.main1.UseVisualStyleBackColor = False
        '
        'main2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.main3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.main1)
        Me.Name = "main2"
        Me.Text = "main2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents main3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents main1 As Button
End Class
