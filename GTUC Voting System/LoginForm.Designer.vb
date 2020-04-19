<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.indexText = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'indexText
        '
        Me.indexText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.indexText.Location = New System.Drawing.Point(652, 205)
        Me.indexText.Name = "indexText"
        Me.indexText.Size = New System.Drawing.Size(192, 22)
        Me.indexText.TabIndex = 0
        Me.indexText.Text = "Username/Email"
        Me.indexText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordText
        '
        Me.PasswordText.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordText.Location = New System.Drawing.Point(652, 286)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordText.Size = New System.Drawing.Size(192, 22)
        Me.PasswordText.TabIndex = 1
        Me.PasswordText.Text = "Password"
        Me.PasswordText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(689, 371)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(129, 27)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(928, 497)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.indexText)
        Me.Name = "LoginForm"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents indexText As System.Windows.Forms.TextBox
    Friend WithEvents PasswordText As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button

End Class
