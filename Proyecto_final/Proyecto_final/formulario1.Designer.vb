<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formulario1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(293, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 15)
        Label1.TabIndex = 0
        Label1.Text = "Universidad Tecnologica de Panama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(293, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(208, 15)
        Label2.TabIndex = 1
        Label2.Text = "Licenciatura en Desarrollo de Software"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(321, 167)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 15)
        Label3.TabIndex = 2
        Label3.Text = "Profesor: Ricardo Chan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(321, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(124, 15)
        Label4.TabIndex = 3
        Label4.Text = "Nombre: Jose Vasquez"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(321, 307)
        Label5.Name = "Label5"
        Label5.Size = New Size(108, 15)
        Label5.TabIndex = 4
        Label5.Text = "Cedula: 8-915-1712"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(336, 364)
        Label6.Name = "Label6"
        Label6.Size = New Size(82, 15)
        Label6.TabIndex = 5
        Label6.Text = "Proyecto Final"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(356, 426)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 15)
        Label7.TabIndex = 6
        Label7.Text = "2023"
        ' 
        ' formulario1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1304, 483)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "formulario1"
        Text = "formulario1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

End Class
