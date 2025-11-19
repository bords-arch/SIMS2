<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cmbRole = New ComboBox()
        btnLogin = New Button()
        lblLoginStatus = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(352, 112)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(360, 27)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(352, 240)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(360, 27)
        txtPassword.TabIndex = 1
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(886, 34)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(135, 28)
        cmbRole.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(443, 340)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(143, 57)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' lblLoginStatus
        ' 
        lblLoginStatus.AutoSize = True
        lblLoginStatus.Location = New Point(499, 42)
        lblLoginStatus.Name = "lblLoginStatus"
        lblLoginStatus.Size = New Size(46, 20)
        lblLoginStatus.TabIndex = 4
        lblLoginStatus.Text = "Login"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(175, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 20)
        Label1.TabIndex = 5
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(175, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 6
        Label2.Text = "Password:"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1093, 594)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblLoginStatus)
        Controls.Add(btnLogin)
        Controls.Add(cmbRole)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "LoginForm"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblLoginStatus As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
