' Form1.vb
Imports System
Imports System.Windows.Forms

Public Class Form1
    Inherits Form

    Private lblHello As Label
    Private btnClose As Button

    Public Sub New()
        ' Initialize the form and controls
        Me.InitializeComponent()
    End Sub

    Private Sub InitializeComponent()
        lblHello = New Label()
        btnClose = New Button()
        SuspendLayout()
        ' 
        ' lblHello
        ' 
        lblHello.AutoSize = True
        lblHello.Location = New Point(20, 20)
        lblHello.Name = "lblHello"
        lblHello.Size = New Size(242, 20)
        lblHello.TabIndex = 0
        lblHello.Text = "Hello — Form1 is running correctly."
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.Location = New Point(20, 60)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 30)
        btnClose.TabIndex = 1
        btnClose.Text = "Close"
        ' 
        ' Form1
        ' 
        ClientSize = New Size(594, 306)
        Controls.Add(lblHello)
        Controls.Add(btnClose)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
