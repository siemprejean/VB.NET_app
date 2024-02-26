Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class formulario2
    Private conexionBD As ConexionBD
    Dim validador As New Validacion
    Private cedula As String
    Private nombre As String
    Private apellido As String

    Private Sub formulario2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadenaConexion As String = "Data Source=DESKTOP-310UPP6\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"
        ' Inicializa la instancia de ConexionBD
        conexionBD = New ConexionBD(cadenaConexion)
        conexionBD.AbrirConexion()
        ' Llenar ComboBox de facultades
        LlenarComboBoxFacultades()

        ' Llenar ComboBox de carreras
        LlenarComboBoxCarreras()
    End Sub
    'Radio buttons
    Private Sub rd_nom_CheckedChanged(sender As Object, e As EventArgs) Handles rd_nom.CheckedChanged
        dgv1.DataSource = Nothing
        Dim datos As DataTable = conexionBD.Ordenarnombre()
        dgv1.DataSource = datos
    End Sub
    Private Sub rd_ape_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ape.CheckedChanged
        dgv1.DataSource = Nothing
        Dim datos As DataTable = conexionBD.Ordenarapellido()
        dgv1.DataSource = datos
    End Sub
    Private Sub rd_ced_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ced.CheckedChanged
        dgv1.DataSource = Nothing
        Dim datos As DataTable = conexionBD.Ordenarcedu()
        dgv1.DataSource = datos
    End Sub

    Private Sub Btn_listar_Click(sender As Object, e As EventArgs) Handles Btn_listar.Click
        ' Llamado a la nueva clase para obtener los datos con el orden seleccionado
        Dim datos As DataTable = conexionBD.ObtenerDatosDesdeProcedimiento()
        ' Asignar los datos al DataGridView
        dgv1.DataSource = datos
    End Sub

    Private Sub Btn_Modif_Click(sender As Object, e As EventArgs) Handles Btn_Modif.Click
        Dim nuevaCedula As String = Txt_cedula.Text.Trim()
        Dim nuevoNombre As String = txt_name.Text.Trim()
        Dim nuevoApellido As String = txt_ape.Text.Trim()
        Dim nuevaDireccion As String = txt_dirr.Text.Trim()
        Dim nuevoCelular As String = txt_celular.Text.Trim()
        Dim nuevoCorreo As String = txt_correo.Text.Trim()
        Dim nuevoIndice As String = txt_indi.Text.Trim()
        Dim nuevoSexo As String = txt_sexo.Text.Trim()
        Dim nuevaFacultad As String = Combo_facu.SelectedItem.ToString()
        Dim nuevaCarrera As String = Combo_Carr.SelectedItem.ToString()

        ' Validar que la cédula no esté vacía
        If String.IsNullOrEmpty(nuevaCedula) Then
            MessageBox.Show("La cédula no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validar que al menos un campo adicional esté completo
        If String.IsNullOrEmpty(nuevoNombre) AndAlso String.IsNullOrEmpty(nuevoApellido) AndAlso String.IsNullOrEmpty(nuevaDireccion) AndAlso
        String.IsNullOrEmpty(nuevoCelular) AndAlso String.IsNullOrEmpty(nuevoCorreo) AndAlso String.IsNullOrEmpty(nuevoIndice) AndAlso
        String.IsNullOrEmpty(nuevoSexo) AndAlso String.IsNullOrEmpty(nuevaFacultad) AndAlso String.IsNullOrEmpty(nuevaCarrera) Then

            MessageBox.Show("Al menos un campo adicional debe estar completo para realizar la modificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If validador.ValidarTextoAlfabético(nuevoNombre) AndAlso
           validador.ValidarTextoAlfabético(nuevoApellido) AndAlso
           validador.ValidarTextoAlfabético(nuevaDireccion) AndAlso
           validador.ValidarDigitosNumericos(nuevaCedula) AndAlso
           validador.ValidarDigitosNumericos(nuevoCelular) AndAlso
           validador.ValidarCorreo(nuevoCorreo) Then
            Console.WriteLine("Los datos son válidos.")
        Else
            Console.WriteLine("Los datos no son válidos.")
        End If
        ' Llamar a la función para modificar los datos del estudiante
        Dim exito As Boolean = conexionBD.ModificarEstudiante(nuevaCedula, nuevoNombre, nuevoApellido, nuevaDireccion, nuevoCelular, nuevoCorreo, nuevoIndice, nuevoSexo, nuevaFacultad, nuevaCarrera)

        If exito Then
            MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al modificar el registro. Verifique los datos e inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn_Elim_Click(sender As Object, e As EventArgs) Handles Btn_Elim.Click
        ' Obtener la cédula desde el TextBox
        conexionBD.AbrirConexion()
        Dim cedula As String = Txt_cedula.Text.Trim()

        ' Validar que la cédula no esté vacía
        If String.IsNullOrEmpty(cedula) Then
            MessageBox.Show("Por favor, ingrese la cédula del estudiante a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Llamar a la función para eliminar estudiante por cédula
        conexionBD.EliminarEstudiantePorCedula(cedula)

        ' Mostrar un mensaje de éxito
        MessageBox.Show("Estudiante eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Btn_busc_Click(sender As Object, e As EventArgs) Handles Btn_busc.Click
        ' Obtén la cédula ingresada por el usuario
        Dim cedula As String = Txt_cedula.Text.Trim()

        ' Verifica si se ingresó una cédula
        If Not String.IsNullOrEmpty(cedula) Then

            ' Llamado al procedimiento almacenado para buscar por cédula
            Dim datos As DataTable = conexionBD.ObtenerDatosPorCedula(cedula)

            ' Verifica si se encontraron datos
            If datos.Rows.Count > 0 Then
                ' Muestra los datos en los TextBox
                txt_name.Text = datos.Rows(0)("nombre").ToString()
                txt_ape.Text = datos.Rows(0)("apellido").ToString()
                txt_dirr.Text = datos.Rows(0)("direccion").ToString()
                txt_celular.Text = datos.Rows(0)("celular").ToString()
                txt_correo.Text = datos.Rows(0)("correo").ToString()
                txt_indi.Text = datos.Rows(0)("indice_academico").ToString()
                txt_sexo.Text = datos.Rows(0)("sexo").ToString()
                Combo_facu.SelectedItem = datos.Rows(0)("Facultad").ToString()
                Combo_Carr.SelectedItem = datos.Rows(0)("Carrera").ToString()
                Btn_add.Enabled = False
                Btn_Elim.Enabled = True
                Btn_Modif.Enabled = True
                Btn_limp.Enabled = True
            Else
                MessageBox.Show("No se encontraron datos para la cédula proporcionada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Btn_Modif.Enabled = False
                Btn_Elim.Enabled = False
                Btn_add.Enabled = True
            End If
            Btn_busc.Enabled = False
            Txt_cedula.Enabled = False
            txt_name.Enabled = True
            txt_ape.Enabled = True
            txt_dirr.Enabled = True
            txt_celular.Enabled = True
            txt_correo.Enabled = True
            txt_indi.Enabled = True
            txt_sexo.Enabled = True
        Else
            MessageBox.Show("Ingrese una cédula antes de buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub LlenarComboBoxFacultades()
        ' Obtener nombres de facultades
        Dim nombresFacultades As DataTable = conexionBD.ObtenerNombresFacultades()

        ' Llenar el ComboBox de facultades con los nombres obtenidos
        For Each row As DataRow In nombresFacultades.Rows
            Combo_facu.Items.Add(row("nombre_facultad").ToString())
        Next
    End Sub

    Private Sub LlenarComboBoxCarreras()
        ' Obtener nombres de carreras
        Dim nombresCarreras As DataTable = conexionBD.ObtenerNombresCarreras()

        ' Llenar el ComboBox de carreras con los nombres obtenidos
        For Each row As DataRow In nombresCarreras.Rows
            Combo_Carr.Items.Add(row("carrera").ToString())
        Next
    End Sub

    Private Sub Btn_add_Click(sender As Object, e As EventArgs) Handles Btn_add.Click
        ' Obtener los valores ingresados por el usuario desde los controles
        Dim cedula As String = Txt_cedula.Text.Trim()
        Dim nombre As String = txt_name.Text.Trim()
        Dim apellido As String = txt_ape.Text.Trim()
        Dim direccion As String = txt_dirr.Text.Trim()
        Dim celular As String = txt_celular.Text.Trim()
        Dim correo As String = txt_correo.Text.Trim()
        Dim Indice As String = txt_indi.Text.Trim()
        Dim Sexo As String = txt_sexo.Text.Trim()
        Dim facultad As String = Combo_facu.SelectedItem.ToString()
        Dim carrera As String = Combo_Carr.SelectedItem.ToString()

        ' Validar que todos los campos estén completos
        If String.IsNullOrEmpty(cedula) OrElse String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(apellido) OrElse String.IsNullOrEmpty(facultad) OrElse String.IsNullOrEmpty(carrera) Then
            MessageBox.Show("Por favor, complete todos los campos antes de agregar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If validador.ValidarTextoAlfabético(nombre) AndAlso
           validador.ValidarTextoAlfabético(apellido) AndAlso
           validador.ValidarTextoAlfabético(direccion) AndAlso
           validador.ValidarDigitosNumericos(cedula) AndAlso
           validador.ValidarDigitosNumericos(celular) AndAlso
           validador.ValidarCorreo(correo) Then
            Console.WriteLine("Los datos son válidos.")
        Else
            Console.WriteLine("Los datos no son válidos.")
        End If
        Dim exito As Boolean = conexionBD.AgregarNuevoEstudiante(cedula, nombre, apellido, direccion, celular, correo, Indice, Sexo, facultad, carrera)
        If exito Then
            MessageBox.Show("Registro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar los controles después de agregar el registro)
        Else
            MessageBox.Show("Error al agregar el registro. Verifique los datos e inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn_limp_Click(sender As Object, e As EventArgs) Handles Btn_limp.Click
        Txt_cedula.Text = String.Empty
        txt_name.Text = String.Empty
        txt_ape.Text = String.Empty
        txt_dirr.Text = String.Empty
        txt_celular.Text = String.Empty
        txt_correo.Text = String.Empty
        txt_indi.Text = String.Empty
        txt_sexo.Text = String.Empty
        Txt_cedula.Enabled = True
        txt_name.Enabled = False
        txt_ape.Enabled = False
        txt_dirr.Enabled = False
        txt_celular.Enabled = False
        txt_correo.Enabled = False
        txt_indi.Enabled = False
        txt_sexo.Enabled = False
        Btn_add.Enabled = False
        Btn_busc.Enabled = True
        Btn_Modif.Enabled = False
        Btn_Elim.Enabled = False
    End Sub
End Class

