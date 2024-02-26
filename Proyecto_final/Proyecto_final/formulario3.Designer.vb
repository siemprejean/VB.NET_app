<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formulario3
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
        Btn_cle = New Button()
        Btn_busc = New Button()
        Btn_agre = New Button()
        Btn_modif = New Button()
        Btn_eli = New Button()
        Btn_listar = New Button()
        Label1 = New Label()
        dgv2 = New DataGridView()
        Txt_codigo = New TextBox()
        Txt_nom = New TextBox()
        txt_ape = New TextBox()
        txt_dirr = New TextBox()
        txt_cel = New TextBox()
        txt_corr = New TextBox()
        Combo_provi = New ComboBox()
        Combo_dist = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        txt_salar = New TextBox()
        txt_cedu = New TextBox()
        Label12 = New Label()
        rd_nom = New RadioButton()
        rd_ape = New RadioButton()
        rd_ced = New RadioButton()
        CType(dgv2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_cle
        ' 
        Btn_cle.Location = New Point(902, 37)
        Btn_cle.Name = "Btn_cle"
        Btn_cle.Size = New Size(75, 23)
        Btn_cle.TabIndex = 0
        Btn_cle.Text = "Limpiar"
        Btn_cle.UseVisualStyleBackColor = True
        ' 
        ' Btn_busc
        ' 
        Btn_busc.Location = New Point(995, 37)
        Btn_busc.Name = "Btn_busc"
        Btn_busc.Size = New Size(75, 23)
        Btn_busc.TabIndex = 1
        Btn_busc.Text = "Buscar"
        Btn_busc.UseVisualStyleBackColor = True
        ' 
        ' Btn_agre
        ' 
        Btn_agre.Enabled = False
        Btn_agre.Location = New Point(1083, 37)
        Btn_agre.Name = "Btn_agre"
        Btn_agre.Size = New Size(75, 23)
        Btn_agre.TabIndex = 2
        Btn_agre.Text = "Adicionar"
        Btn_agre.UseVisualStyleBackColor = True
        ' 
        ' Btn_modif
        ' 
        Btn_modif.Enabled = False
        Btn_modif.Location = New Point(902, 77)
        Btn_modif.Name = "Btn_modif"
        Btn_modif.Size = New Size(75, 23)
        Btn_modif.TabIndex = 3
        Btn_modif.Text = "Modificar"
        Btn_modif.UseVisualStyleBackColor = True
        ' 
        ' Btn_eli
        ' 
        Btn_eli.Enabled = False
        Btn_eli.Location = New Point(995, 77)
        Btn_eli.Name = "Btn_eli"
        Btn_eli.Size = New Size(75, 23)
        Btn_eli.TabIndex = 4
        Btn_eli.Text = "Eliminar"
        Btn_eli.UseVisualStyleBackColor = True
        ' 
        ' Btn_listar
        ' 
        Btn_listar.Location = New Point(1083, 77)
        Btn_listar.Name = "Btn_listar"
        Btn_listar.Size = New Size(75, 23)
        Btn_listar.TabIndex = 5
        Btn_listar.Text = "Listar"
        Btn_listar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(542, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 37)
        Label1.TabIndex = 7
        Label1.Text = "Profesor"
        ' 
        ' dgv2
        ' 
        dgv2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv2.Location = New Point(80, 269)
        dgv2.Name = "dgv2"
        dgv2.Size = New Size(954, 195)
        dgv2.TabIndex = 8
        ' 
        ' Txt_codigo
        ' 
        Txt_codigo.Location = New Point(96, 38)
        Txt_codigo.Name = "Txt_codigo"
        Txt_codigo.Size = New Size(121, 23)
        Txt_codigo.TabIndex = 11
        ' 
        ' Txt_nom
        ' 
        Txt_nom.Enabled = False
        Txt_nom.Location = New Point(96, 67)
        Txt_nom.Name = "Txt_nom"
        Txt_nom.Size = New Size(121, 23)
        Txt_nom.TabIndex = 12
        ' 
        ' txt_ape
        ' 
        txt_ape.Enabled = False
        txt_ape.Location = New Point(96, 96)
        txt_ape.Name = "txt_ape"
        txt_ape.Size = New Size(121, 23)
        txt_ape.TabIndex = 13
        ' 
        ' txt_dirr
        ' 
        txt_dirr.Enabled = False
        txt_dirr.Location = New Point(96, 125)
        txt_dirr.Name = "txt_dirr"
        txt_dirr.Size = New Size(121, 23)
        txt_dirr.TabIndex = 14
        ' 
        ' txt_cel
        ' 
        txt_cel.Enabled = False
        txt_cel.Location = New Point(96, 154)
        txt_cel.Name = "txt_cel"
        txt_cel.Size = New Size(121, 23)
        txt_cel.TabIndex = 15
        ' 
        ' txt_corr
        ' 
        txt_corr.Enabled = False
        txt_corr.Location = New Point(96, 183)
        txt_corr.Name = "txt_corr"
        txt_corr.Size = New Size(121, 23)
        txt_corr.TabIndex = 16
        ' 
        ' Combo_provi
        ' 
        Combo_provi.FormattingEnabled = True
        Combo_provi.Location = New Point(243, 96)
        Combo_provi.Name = "Combo_provi"
        Combo_provi.Size = New Size(199, 23)
        Combo_provi.TabIndex = 18
        ' 
        ' Combo_dist
        ' 
        Combo_dist.FormattingEnabled = True
        Combo_dist.Location = New Point(243, 125)
        Combo_dist.Name = "Combo_dist"
        Combo_dist.Size = New Size(199, 23)
        Combo_dist.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 15)
        Label2.TabIndex = 21
        Label2.Text = "Codigo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 22
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 99)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 23
        Label4.Text = "Apellido"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(23, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 24
        Label5.Text = "Direccion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(466, 99)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 15)
        Label6.TabIndex = 25
        Label6.Text = "Provincia"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(466, 128)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 15)
        Label7.TabIndex = 26
        Label7.Text = "Distrito"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(467, 157)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 15)
        Label8.TabIndex = 27
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(25, 157)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 15)
        Label9.TabIndex = 28
        Label9.Text = "Celular"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(23, 186)
        Label10.Name = "Label10"
        Label10.Size = New Size(43, 15)
        Label10.TabIndex = 29
        Label10.Text = "Correo"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(23, 219)
        Label11.Name = "Label11"
        Label11.Size = New Size(69, 15)
        Label11.TabIndex = 30
        Label11.Text = "Salario base"
        ' 
        ' txt_salar
        ' 
        txt_salar.Enabled = False
        txt_salar.Location = New Point(96, 219)
        txt_salar.Name = "txt_salar"
        txt_salar.Size = New Size(121, 23)
        txt_salar.TabIndex = 31
        ' 
        ' txt_cedu
        ' 
        txt_cedu.Enabled = False
        txt_cedu.Location = New Point(293, 37)
        txt_cedu.Name = "txt_cedu"
        txt_cedu.Size = New Size(149, 23)
        txt_cedu.TabIndex = 32
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(243, 41)
        Label12.Name = "Label12"
        Label12.Size = New Size(44, 15)
        Label12.TabIndex = 33
        Label12.Text = "Cedula"
        ' 
        ' rd_nom
        ' 
        rd_nom.AutoSize = True
        rd_nom.BackColor = SystemColors.Highlight
        rd_nom.Location = New Point(902, 124)
        rd_nom.Name = "rd_nom"
        rd_nom.Size = New Size(69, 19)
        rd_nom.TabIndex = 34
        rd_nom.TabStop = True
        rd_nom.Text = "Nombre"
        rd_nom.UseVisualStyleBackColor = False
        ' 
        ' rd_ape
        ' 
        rd_ape.AutoSize = True
        rd_ape.Location = New Point(995, 124)
        rd_ape.Name = "rd_ape"
        rd_ape.Size = New Size(69, 19)
        rd_ape.TabIndex = 35
        rd_ape.TabStop = True
        rd_ape.Text = "Apellido"
        rd_ape.UseVisualStyleBackColor = True
        ' 
        ' rd_ced
        ' 
        rd_ced.AutoSize = True
        rd_ced.Location = New Point(1083, 125)
        rd_ced.Name = "rd_ced"
        rd_ced.Size = New Size(62, 19)
        rd_ced.TabIndex = 36
        rd_ced.TabStop = True
        rd_ced.Text = "Cedula"
        rd_ced.UseVisualStyleBackColor = True
        ' 
        ' formulario3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(1304, 483)
        Controls.Add(rd_ced)
        Controls.Add(rd_ape)
        Controls.Add(rd_nom)
        Controls.Add(Label12)
        Controls.Add(txt_cedu)
        Controls.Add(txt_salar)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Combo_dist)
        Controls.Add(Combo_provi)
        Controls.Add(txt_corr)
        Controls.Add(txt_cel)
        Controls.Add(txt_dirr)
        Controls.Add(txt_ape)
        Controls.Add(Txt_nom)
        Controls.Add(Txt_codigo)
        Controls.Add(dgv2)
        Controls.Add(Label1)
        Controls.Add(Btn_listar)
        Controls.Add(Btn_eli)
        Controls.Add(Btn_modif)
        Controls.Add(Btn_agre)
        Controls.Add(Btn_busc)
        Controls.Add(Btn_cle)
        Name = "formulario3"
        Text = "formulario3"
        CType(dgv2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_cle As Button
    Friend WithEvents Btn_busc As Button
    Friend WithEvents Btn_agre As Button
    Friend WithEvents Btn_modif As Button
    Friend WithEvents Btn_eli As Button
    Friend WithEvents Btn_listar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents Txt_codigo As TextBox
    Friend WithEvents Txt_nom As TextBox
    Friend WithEvents txt_ape As TextBox
    Friend WithEvents txt_dirr As TextBox
    Friend WithEvents txt_cel As TextBox
    Friend WithEvents txt_corr As TextBox
    Friend WithEvents Combo_provi As ComboBox
    Friend WithEvents Combo_dist As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_salar As TextBox
    Friend WithEvents txt_cedu As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents rd_nom As RadioButton
    Friend WithEvents rd_ape As RadioButton
    Friend WithEvents rd_ced As RadioButton

End Class
