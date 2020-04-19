<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vote
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.C1 = New System.Windows.Forms.RadioButton()
        Me.C2 = New System.Windows.Forms.RadioButton()
        Me.C3 = New System.Windows.Forms.RadioButton()
        Me.C4 = New System.Windows.Forms.RadioButton()
        Me.C5 = New System.Windows.Forms.RadioButton()
        Me.C6 = New System.Windows.Forms.RadioButton()
        Me.C7 = New System.Windows.Forms.RadioButton()
        Me.C8 = New System.Windows.Forms.RadioButton()
        Me.C9 = New System.Windows.Forms.RadioButton()
        Me.indexNo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(306, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "President Candidate"
        '
        'nextBtn
        '
        Me.nextBtn.Location = New System.Drawing.Point(352, 523)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(137, 32)
        Me.nextBtn.TabIndex = 20
        Me.nextBtn.Text = "Next"
        Me.nextBtn.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(40, 115)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(14, 13)
        Me.C1.TabIndex = 21
        Me.C1.TabStop = True
        Me.C1.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Location = New System.Drawing.Point(405, 115)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(14, 13)
        Me.C2.TabIndex = 22
        Me.C2.TabStop = True
        Me.C2.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Location = New System.Drawing.Point(754, 115)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(14, 13)
        Me.C3.TabIndex = 23
        Me.C3.TabStop = True
        Me.C3.UseVisualStyleBackColor = True
        '
        'C4
        '
        Me.C4.AutoSize = True
        Me.C4.Location = New System.Drawing.Point(754, 282)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(14, 13)
        Me.C4.TabIndex = 26
        Me.C4.TabStop = True
        Me.C4.UseVisualStyleBackColor = True
        '
        'C5
        '
        Me.C5.AutoSize = True
        Me.C5.Location = New System.Drawing.Point(405, 282)
        Me.C5.Name = "C5"
        Me.C5.Size = New System.Drawing.Size(14, 13)
        Me.C5.TabIndex = 25
        Me.C5.TabStop = True
        Me.C5.UseVisualStyleBackColor = True
        '
        'C6
        '
        Me.C6.AutoSize = True
        Me.C6.Location = New System.Drawing.Point(40, 282)
        Me.C6.Name = "C6"
        Me.C6.Size = New System.Drawing.Size(14, 13)
        Me.C6.TabIndex = 24
        Me.C6.TabStop = True
        Me.C6.UseVisualStyleBackColor = True
        '
        'C7
        '
        Me.C7.AutoSize = True
        Me.C7.Location = New System.Drawing.Point(754, 443)
        Me.C7.Name = "C7"
        Me.C7.Size = New System.Drawing.Size(14, 13)
        Me.C7.TabIndex = 29
        Me.C7.TabStop = True
        Me.C7.UseVisualStyleBackColor = True
        '
        'C8
        '
        Me.C8.AutoSize = True
        Me.C8.Location = New System.Drawing.Point(405, 443)
        Me.C8.Name = "C8"
        Me.C8.Size = New System.Drawing.Size(14, 13)
        Me.C8.TabIndex = 28
        Me.C8.TabStop = True
        Me.C8.UseVisualStyleBackColor = True
        '
        'C9
        '
        Me.C9.AutoSize = True
        Me.C9.Location = New System.Drawing.Point(40, 443)
        Me.C9.Name = "C9"
        Me.C9.Size = New System.Drawing.Size(14, 13)
        Me.C9.TabIndex = 27
        Me.C9.TabStop = True
        Me.C9.UseVisualStyleBackColor = True
        '
        'indexNo
        '
        Me.indexNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indexNo.Location = New System.Drawing.Point(40, 13)
        Me.indexNo.Name = "indexNo"
        Me.indexNo.Size = New System.Drawing.Size(192, 22)
        Me.indexNo.TabIndex = 30
        Me.indexNo.Text = "Index Number"
        Me.indexNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Vote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 567)
        Me.Controls.Add(Me.indexNo)
        Me.Controls.Add(Me.C7)
        Me.Controls.Add(Me.C8)
        Me.Controls.Add(Me.C9)
        Me.Controls.Add(Me.C4)
        Me.Controls.Add(Me.C5)
        Me.Controls.Add(Me.C6)
        Me.Controls.Add(Me.C3)
        Me.Controls.Add(Me.C2)
        Me.Controls.Add(Me.C1)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Vote"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nextBtn As System.Windows.Forms.Button
    Friend WithEvents C1 As System.Windows.Forms.RadioButton
    Friend WithEvents C2 As System.Windows.Forms.RadioButton
    Friend WithEvents C3 As System.Windows.Forms.RadioButton
    Friend WithEvents C4 As System.Windows.Forms.RadioButton
    Friend WithEvents C5 As System.Windows.Forms.RadioButton
    Friend WithEvents C6 As System.Windows.Forms.RadioButton
    Friend WithEvents C7 As System.Windows.Forms.RadioButton
    Friend WithEvents C8 As System.Windows.Forms.RadioButton
    Friend WithEvents C9 As System.Windows.Forms.RadioButton
    Friend WithEvents indexNo As System.Windows.Forms.TextBox
End Class
