<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Fullname = New System.Windows.Forms.TextBox()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.IndexNO = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Session = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Fullname
        '
        Me.Fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fullname.Location = New System.Drawing.Point(640, 231)
        Me.Fullname.Name = "Fullname"
        Me.Fullname.Size = New System.Drawing.Size(252, 21)
        Me.Fullname.TabIndex = 0
        Me.Fullname.Tag = "                    "
        Me.Fullname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(640, 172)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(252, 21)
        Me.Email.TabIndex = 0
        Me.Email.Tag = "                    "
        Me.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IndexNO
        '
        Me.IndexNO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IndexNO.Location = New System.Drawing.Point(640, 291)
        Me.IndexNO.Name = "IndexNO"
        Me.IndexNO.Size = New System.Drawing.Size(252, 21)
        Me.IndexNO.TabIndex = 1
        Me.IndexNO.Tag = "                    "
        Me.IndexNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(640, 348)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(252, 21)
        Me.Password.TabIndex = 2
        Me.Password.Tag = "                    "
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(722, 462)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Session
        '
        Me.Session.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Session.FormattingEnabled = True
        Me.Session.Items.AddRange(New Object() {"Morning", "Evening"})
        Me.Session.Location = New System.Drawing.Point(640, 414)
        Me.Session.Name = "Session"
        Me.Session.Size = New System.Drawing.Size(252, 23)
        Me.Session.TabIndex = 5
        Me.Session.Tag = "                    "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(741, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(741, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(741, 264)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "IndexNO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(741, 332)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(741, 385)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Session"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(945, 504)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Session)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IndexNO)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Fullname)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Register"
        Me.Tag = "                    "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Fullname As System.Windows.Forms.TextBox
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents IndexNO As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Session As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
