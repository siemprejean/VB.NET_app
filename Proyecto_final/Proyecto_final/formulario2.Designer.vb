<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formulario2
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
        Btn_limp = New Button()
        Btn_busc = New Button()
        Btn_Modif = New Button()
        Btn_Elim = New Button()
        Btn_listar = New Button()
        Label1 = New Label()
        dgv1 = New DataGridView()
        Combo_facu = New ComboBox()
        Combo_Carr = New ComboBox()
        Txt_cedula = New TextBox()
        txt_name = New TextBox()
        txt_ape = New TextBox()
        txt_dirr = New TextBox()
        rd_nom = New RadioButton()
        rd_ape = New RadioButton()
        rd_ced = New RadioButton()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        txt_celular = New TextBox()
        txt_correo = New TextBox()
        txt_indi = New TextBox()
        txt_sexo = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Btn_add = New Button()
        CType(dgv1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_limp
        ' 
        Btn_limp.Location = New Point(1083, 55)
        Btn_limp.Name = "Btn_limp"
        Btn_limp.Size = New Size(75, 23)
        Btn_limp.TabIndex = 0
        Btn_limp.Text = "Limpiar"
        Btn_limp.UseVisualStyleBackColor = True
        ' 
        ' Btn_busc
        ' 
        Btn_busc.Location = New Point(1083, 96)
        Btn_busc.Name = "Btn_busc"
        Btn_busc.Size = New Size(75, 23)
        Btn_busc.TabIndex = 1
        Btn_busc.Text = "Buscar"
        Btn_busc.UseVisualStyleBackColor = True
        ' 
        ' Btn_Modif
        ' 
        Btn_Modif.Enabled = False
        Btn_Modif.Location = New Point(1185, 97)
        Btn_Modif.Name = "Btn_Modif"
        Btn_Modif.Size = New Size(75, 23)
        Btn_Modif.TabIndex = 3
        Btn_Modif.Text = "Modificar"
        Btn_Modif.UseVisualStyleBackColor = True
        ' 
        ' Btn_Elim
        ' 
        Btn_Elim.Enabled = False
        Btn_Elim.Location = New Point(1276, 56)
        Btn_Elim.Name = "Btn_Elim"
        Btn_Elim.Size = New Size(75, 23)
        Btn_Elim.TabIndex = 4
        Btn_Elim.Text = "Eliminar"
        Btn_Elim.UseVisualStyleBackColor = True
        ' 
        ' Btn_listar
        ' 
        Btn_listar.Location = New Point(1276, 97)
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
        Label1.Location = New Point(579, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 37)
        Label1.TabIndex = 6
        Label1.Text = "Estudiante"
        ' 
        ' dgv1
        ' 
        dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv1.Location = New Point(94, 429)
        dgv1.Name = "dgv1"
        dgv1.Size = New Size(954, 195)
        dgv1.TabIndex = 7
        ' 
        ' Combo_facu
        ' 
        Combo_facu.FormattingEnabled = True
        Combo_facu.Location = New Point(94, 225)
        Combo_facu.Name = "Combo_facu"
        Combo_facu.Size = New Size(199, 23)
        Combo_facu.TabIndex = 8
        ' 
        ' Combo_Carr
        ' 
        Combo_Carr.FormattingEnabled = True
        Combo_Carr.Location = New Point(94, 267)
        Combo_Carr.Name = "Combo_Carr"
        Combo_Carr.Size = New Size(199, 23)
        Combo_Carr.TabIndex = 9
        ' 
        ' Txt_cedula
        ' 
        Txt_cedula.Location = New Point(94, 57)
        Txt_cedula.Name = "Txt_cedula"
        Txt_cedula.Size = New Size(121, 23)
        Txt_cedula.TabIndex = 10
        ' 
        ' txt_name
        ' 
        txt_name.Enabled = False
        txt_name.Location = New Point(94, 98)
        txt_name.Name = "txt_name"
        txt_name.Size = New Size(121, 23)
        txt_name.TabIndex = 11
        ' 
        ' txt_ape
        ' 
        txt_ape.Enabled = False
        txt_ape.Location = New Point(94, 139)
        txt_ape.Name = "txt_ape"
        txt_ape.Size = New Size(121, 23)
        txt_ape.TabIndex = 12
        ' 
        ' txt_dirr
        ' 
        txt_dirr.Enabled = False
        txt_dirr.Location = New Point(94, 180)
        txt_dirr.Name = "txt_dirr"
        txt_dirr.Size = New Size(121, 23)
        txt_dirr.TabIndex = 13
        ' 
        ' rd_nom
        ' 
        rd_nom.AutoSize = True
        rd_nom.Location = New Point(1083, 143)
        rd_nom.Name = "rd_nom"
        rd_nom.Size = New Size(69, 19)
        rd_nom.TabIndex = 14
        rd_nom.TabStop = True
        rd_nom.Text = "Nombre"
        rd_nom.UseVisualStyleBackColor = True
        ' 
        ' rd_ape
        ' 
        rd_ape.AutoSize = True
        rd_ape.Location = New Point(1185, 146)
        rd_ape.Name = "rd_ape"
        rd_ape.Size = New Size(69, 19)
        rd_ape.TabIndex = 15
        rd_ape.TabStop = True
        rd_ape.Text = "Apellido"
        rd_ape.UseVisualStyleBackColor = True
        ' 
        ' rd_ced
        ' 
        rd_ced.AutoSize = True
        rd_ced.Location = New Point(1276, 146)
        rd_ced.Name = "rd_ced"
        rd_ced.Size = New Size(62, 19)
        rd_ced.TabIndex = 16
        rd_ced.TabStop = True
        rd_ced.Text = "Cedula"
        rd_ced.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 15)
        Label2.TabIndex = 17
        Label2.Text = "Cedula"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 15)
        Label3.TabIndex = 18
        Label3.Text = "Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 143)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 15)
        Label4.TabIndex = 19
        Label4.Text = "Apellido"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 183)
        Label5.Name = "Label5"
        Label5.Size = New Size(57, 15)
        Label5.TabIndex = 20
        Label5.Text = "Direccion"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 228)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 15)
        Label6.TabIndex = 21
        Label6.Text = "Facultad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 275)
        Label7.Name = "Label7"
        Label7.Size = New Size(45, 15)
        Label7.TabIndex = 22
        Label7.Text = "Carrera"
        ' 
        ' txt_celular
        ' 
        txt_celular.Enabled = False
        txt_celular.Location = New Point(397, 57)
        txt_celular.Name = "txt_celular"
        txt_celular.Size = New Size(121, 23)
        txt_celular.TabIndex = 23
        ' 
        ' txt_correo
        ' 
        txt_correo.Enabled = False
        txt_correo.Location = New Point(397, 98)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(121, 23)
        txt_correo.TabIndex = 24
        ' 
        ' txt_indi
        ' 
        txt_indi.Enabled = False
        txt_indi.Location = New Point(397, 135)
        txt_indi.Name = "txt_indi"
        txt_indi.Size = New Size(47, 23)
        txt_indi.TabIndex = 25
        ' 
        ' txt_sexo
        ' 
        txt_sexo.Enabled = False
        txt_sexo.Location = New Point(397, 183)
        txt_sexo.Name = "txt_sexo"
        txt_sexo.Size = New Size(47, 23)
        txt_sexo.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(320, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(44, 15)
        Label8.TabIndex = 27
        Label8.Text = "Celular"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(320, 106)
        Label9.Name = "Label9"
        Label9.Size = New Size(43, 15)
        Label9.TabIndex = 28
        Label9.Text = "Correo"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(320, 142)
        Label10.Name = "Label10"
        Label10.Size = New Size(39, 15)
        Label10.TabIndex = 29
        Label10.Text = "Indice"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(320, 186)
        Label11.Name = "Label11"
        Label11.Size = New Size(32, 15)
        Label11.TabIndex = 30
        Label11.Text = "Sexo"
        ' 
        ' Btn_add
        ' 
        Btn_add.Enabled = False
        Btn_add.Location = New Point(1185, 56)
        Btn_add.Name = "Btn_add"
        Btn_add.Size = New Size(75, 23)
        Btn_add.TabIndex = 31
        Btn_add.Text = "Agregar"
        Btn_add.UseVisualStyleBackColor = True
        ' 
        ' formulario2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(1652, 650)
        Controls.Add(Btn_add)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txt_sexo)
        Controls.Add(txt_indi)
        Controls.Add(txt_correo)
        Controls.Add(txt_celular)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(rd_ced)
        Controls.Add(rd_ape)
        Controls.Add(rd_nom)
        Controls.Add(txt_dirr)
        Controls.Add(txt_ape)
        Controls.Add(txt_name)
        Controls.Add(Txt_cedula)
        Controls.Add(Combo_Carr)
        Controls.Add(Combo_facu)
        Controls.Add(dgv1)
        Controls.Add(Label1)
        Controls.Add(Btn_listar)
        Controls.Add(Btn_Elim)
        Controls.Add(Btn_Modif)
        Controls.Add(Btn_busc)
        Controls.Add(Btn_limp)
        Name = "formulario2"
        Text = " "
        CType(dgv1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_limp As Button
    Friend WithEvents Btn_busc As Button
    Friend WithEvents Btn_Modif As Button
    Friend WithEvents Btn_Elim As Button
    Friend WithEvents Btn_listar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rd_nom As RadioButton
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Combo_facu As ComboBox
    Friend WithEvents Combo_Carr As ComboBox
    Friend WithEvents Txt_cedula As TextBox
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_ape As TextBox
    Friend WithEvents txt_dirr As TextBox
    Friend WithEvents rd_ape As RadioButton
    Friend WithEvents rd_ced As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_celular As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents txt_indi As TextBox
    Friend WithEvents txt_sexo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Btn_add As Button

End Class
