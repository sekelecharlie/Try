<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnPress = New Button()
        Imput = New Label()
        txtImput = New TextBox()
        SuspendLayout()
        ' 
        ' btnPress
        ' 
        btnPress.Location = New Point(285, 160)
        btnPress.Name = "btnPress"
        btnPress.Size = New Size(129, 50)
        btnPress.TabIndex = 0
        btnPress.Text = "Press"
        btnPress.UseVisualStyleBackColor = True
        ' 
        ' Imput
        ' 
        Imput.AutoSize = True
        Imput.Location = New Point(181, 107)
        Imput.Name = "Imput"
        Imput.Size = New Size(60, 25)
        Imput.TabIndex = 1
        Imput.Text = "Imput"
        ' 
        ' txtImput
        ' 
        txtImput.Location = New Point(285, 107)
        txtImput.Name = "txtImput"
        txtImput.Size = New Size(150, 31)
        txtImput.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtImput)
        Controls.Add(Imput)
        Controls.Add(btnPress)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPress As Button
    Friend WithEvents Imput As Label
    Friend WithEvents txtImput As TextBox
End Class
