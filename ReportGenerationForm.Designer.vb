<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportGenerationForm
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
        Textreport = New TextBox()
        btnGenerateReport = New Button()
        btnClearReport = New Button()
        SuspendLayout()
        ' 
        ' Textreport
        ' 
        Textreport.Location = New Point(94, 41)
        Textreport.Name = "Textreport"
        Textreport.Size = New Size(288, 27)
        Textreport.TabIndex = 0
        ' 
        ' btnGenerateReport
        ' 
        btnGenerateReport.Location = New Point(134, 108)
        btnGenerateReport.Name = "btnGenerateReport"
        btnGenerateReport.Size = New Size(192, 61)
        btnGenerateReport.TabIndex = 1
        btnGenerateReport.Text = "Button1"
        btnGenerateReport.UseVisualStyleBackColor = True
        ' 
        ' btnClearReport
        ' 
        btnClearReport.Location = New Point(134, 228)
        btnClearReport.Name = "btnClearReport"
        btnClearReport.Size = New Size(192, 65)
        btnClearReport.TabIndex = 2
        btnClearReport.Text = "Button1"
        btnClearReport.UseVisualStyleBackColor = True
        ' 
        ' ReportGenerationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClearReport)
        Controls.Add(btnGenerateReport)
        Controls.Add(Textreport)
        Name = "ReportGenerationForm"
        Text = "ReportGenerationForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Textreport As TextBox
    Friend WithEvents btnGenerateReport As Button
    Friend WithEvents btnClearReport As Button
End Class
