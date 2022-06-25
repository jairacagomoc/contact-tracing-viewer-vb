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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.open_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 52)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(580, 404)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'open_btn
        '
        Me.open_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.open_btn.Location = New System.Drawing.Point(6, 8)
        Me.open_btn.Name = "open_btn"
        Me.open_btn.Size = New System.Drawing.Size(112, 28)
        Me.open_btn.TabIndex = 1
        Me.open_btn.Text = "OPEN FILE"
        Me.open_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(329, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CONTACT TRACING VIEWER "
        '
        'exit_btn
        '
        Me.exit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exit_btn.Location = New System.Drawing.Point(7, 11)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(112, 28)
        Me.exit_btn.TabIndex = 3
        Me.exit_btn.Text = "EXIT"
        Me.exit_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(6, 43)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(112, 28)
        Me.clear_btn.TabIndex = 4
        Me.clear_btn.Text = "CLEAR "
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(90, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(384, 41)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.clear_btn)
        Me.Panel2.Controls.Add(Me.open_btn)
        Me.Panel2.Location = New System.Drawing.Point(612, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(129, 80)
        Me.Panel2.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.exit_btn)
        Me.Panel3.Location = New System.Drawing.Point(612, 149)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 54)
        Me.Panel3.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(753, 468)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Form1"
        Me.Text = "CONTACT TRADING VIEWER "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents open_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents exit_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
