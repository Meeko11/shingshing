<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main3
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.main2 = New System.Windows.Forms.Button()
        Me.main1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(370, 68)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(533, 364)
        Me.Panel1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(80, 281)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(180, 57)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'main2
        '
        Me.main2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.main2.Location = New System.Drawing.Point(80, 177)
        Me.main2.Name = "main2"
        Me.main2.Size = New System.Drawing.Size(180, 57)
        Me.main2.TabIndex = 5
        Me.main2.Text = "main2"
        Me.main2.UseVisualStyleBackColor = False
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
        'main3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 500)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.main2)
        Me.Controls.Add(Me.main1)
        Me.Name = "main3"
        Me.Text = "main3"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents main2 As Button
    Friend WithEvents main1 As Button
End Class
