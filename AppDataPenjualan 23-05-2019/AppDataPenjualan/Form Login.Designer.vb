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
        Me.bt_login = New System.Windows.Forms.Button()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_close = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bt_login
        '
        Me.bt_login.Location = New System.Drawing.Point(109, 106)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(60, 24)
        Me.bt_login.TabIndex = 10
        Me.bt_login.Text = "Login"
        Me.bt_login.UseVisualStyleBackColor = True
        '
        'tb_password
        '
        Me.tb_password.Location = New System.Drawing.Point(109, 70)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tb_password.Size = New System.Drawing.Size(121, 20)
        Me.tb_password.TabIndex = 9
        '
        'tb_username
        '
        Me.tb_username.Location = New System.Drawing.Point(109, 33)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(121, 20)
        Me.tb_username.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Username"
        '
        'bt_close
        '
        Me.bt_close.Location = New System.Drawing.Point(175, 106)
        Me.bt_close.Name = "bt_close"
        Me.bt_close.Size = New System.Drawing.Size(55, 24)
        Me.bt_close.TabIndex = 12
        Me.bt_close.Text = "Close"
        Me.bt_close.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 155)
        Me.Controls.Add(Me.bt_close)
        Me.Controls.Add(Me.bt_login)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_login As System.Windows.Forms.Button
    Friend WithEvents tb_password As System.Windows.Forms.TextBox
    Friend WithEvents tb_username As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bt_close As System.Windows.Forms.Button

End Class
