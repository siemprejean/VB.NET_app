Imports System.ComponentModel.DataAnnotations
Imports Microsoft.VisualBasic

Public Class formulario3
    Private conexionBD As ConexionBD
    Dim validador As New Validacion
    Private cedula As String
    Private nombre As String
    Private apellido As String
    Private Sub formulario3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cadenaConexion As String = "Data Source=DESKTOP-310UPP6\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"
        ' Inicializa la instancia de ConexionBD
        conexionBD = New ConexionBD(cadenaConexion)
        conexionBD.AbrirConexion()
        ' Llenar ComboBox de facultades
        LlenarComboBoxProvincias()

        ' Llenar ComboBox de carreras
        LlenarComboBoxDistritos()
    End Sub

    Private Sub rd_nom_CheckedChanged(sender As Object, e As EventArgs) Handles rd_nom.CheckedChanged
        dgv2.DataSource = Nothing
        Dim datos As DataTable = conexionBD.Ordenarnombreprof()
        dgv2.DataSource = datos
    End Sub
    Private Sub rd_ape_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ape.CheckedChanged
        dgv2.DataSource = Nothing
        Dim datos As DataTable = conexionBD.Ordenarapellidoprof()
        dgv2.DataSource = datos
    End Sub
    Private Sub rd_ced_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ced.CheckedChanged
        dgv2.DataSource = Nothing
        Dim datos As DataTable = conexionBD.Ordenarceduprof()
        dgv2.DataSource = datos
    End Sub

    Private Sub Btn_listar_Click(sender As Object, e As EventArgs) Handles Btn_listar.Click
        ' Llamado a la nueva clase para obtener los datos con el orden seleccionado
        Dim datos As DataTable = conexionBD.ObtenerDatosprofesor()
        ' Asignar los datos al DataGridView
        dgv2.DataSource = datos
    End Sub

    Private Sub Btn_busc_Click(sender As Object, e As EventArgs) Handles Btn_busc.Click
        ' Obtén el codigo ingresada por el usuario
        Dim codigo As String = Txt_codigo.Text.Trim()

        ' Verifica si se ingresó un codigo
        If Not String.IsNullOrEmpty(codigo) Then

            ' Llamado al procedimiento almacenado para buscar por codigo
            Dim datos As DataTable = conexionBD.ObtenerDatosPorCodigo(codigo)

            ' Verifica si se encontraron datos
            If datos.Rows.Count > 0 Then
                ' Muestra los datos en los TextBox
                txt_cedu.Text = datos.Rows(0)("cedula").ToString()
                Txt_nom.Text = datos.Rows(0)("nombre").ToString()
                txt_ape.Text = datos.Rows(0)("apellido").ToString()
                txt_dirr.Text = datos.Rows(0)("direccion").ToString()
                txt_cel.Text = datos.Rows(0)("celular").ToString()
                txt_corr.Text = datos.Rows(0)("correo").ToString()
                txt_salar.Text = datos.Rows(0)("salario_base").ToString()
                Combo_provi.SelectedItem = datos.Rows(0)("Provincia").ToString()
                Combo_dist.SelectedItem = datos.Rows(0)("Distrito").ToString()
                Btn_agre.Enabled = False
                Btn_eli.Enabled = True
                Btn_modif.Enabled = True
                Btn_cle.Enabled = True
            Else
                MessageBox.Show("No se encontraron datos para el codigo proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Btn_modif.Enabled = False
                Btn_eli.Enabled = True
                Btn_agre.Enabled = True

            End If
            Btn_busc.Enabled = False
            Txt_nom.Enabled = True
            txt_ape.Enabled = True
            txt_dirr.Enabled = True
            txt_cel.Enabled = True
            txt_corr.Enabled = True
            txt_salar.Enabled = True
            txt_cedu.Enabled = True
            Txt_codigo.Enabled = False
        Else
            MessageBox.Show("Ingrese un codigo antes de buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub LlenarComboBoxProvincias()
        ' Obtener nombres de facultades
        Dim nombresFacultades As DataTable = conexionBD.ObtenerNombresProvincias()

        ' Llenar el ComboBox de facultades con los nombres obtenidos
        For Each row As DataRow In nombresFacultades.Rows
            Combo_provi.Items.Add(row("nombre_provincia").ToString())
        Next
    End Sub

    Private Sub LlenarComboBoxDistritos()
        ' Obtener nombres de carreras
        Dim nombresCarreras As DataTable = conexionBD.ObtenerNombresDistritos()

        ' Llenar el ComboBox de carreras con los nombres obtenidos
        For Each row As DataRow In nombresCarreras.Rows
            Combo_dist.Items.Add(row("distrito").ToString())
        Next
    End Sub

    Private Sub Btn_cle_Click(sender As Object, e As EventArgs) Handles Btn_cle.Click
        Txt_codigo.Text = String.Empty
        Txt_nom.Text = String.Empty
        txt_cedu.Text = String.Empty
        txt_ape.Text = String.Empty
        txt_dirr.Text = String.Empty
        txt_cel.Text = String.Empty
        txt_corr.Text = String.Empty
        txt_salar.Text = String.Empty
        Txt_codigo.Enabled = True
        Txt_nom.Enabled = False
        txt_ape.Enabled = False
        txt_dirr.Enabled = False
        txt_cel.Enabled = False
        txt_corr.Enabled = False
        txt_salar.Enabled = False
        Btn_agre.Enabled = False
        Btn_busc.Enabled = True
        Btn_modif.Enabled = False
        Btn_eli.Enabled = False
    End Sub

    Private Sub Btn_eli_Click(sender As Object, e As EventArgs) Handles Btn_eli.Click
        ' Obtener la cédula desde el TextBox
        conexionBD.AbrirConexion()
        Dim codigo As String = Txt_codigo.Text.Trim()

        ' Validar que el codigo no esté vacía
        If String.IsNullOrEmpty(codigo) Then
            MessageBox.Show("Por favor, ingrese el codigo del profesor a eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Llamar a la función para eliminar estudiante por cédula
        conexionBD.Eliminarprofesorporcodigo(codigo)

        ' Mostrar un mensaje de éxito
        MessageBox.Show("Profesor eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Btn_agre_Click(sender As Object, e As EventArgs) Handles Btn_agre.Click
        ' Obtener los valores ingresados por el usuario desde los controles
        Dim codigo As String = Txt_codigo.Text.Trim()
        Dim cedula As String = txt_cedu.Text.Trim()
        Dim nombre As String = Txt_nom.Text.Trim()
        Dim apellido As String = txt_ape.Text.Trim()
        Dim direccion As String = txt_dirr.Text.Trim()
        Dim celular As String = txt_cel.Text.Trim()
        Dim correo As String = txt_corr.Text.Trim()
        Dim salario As String = txt_salar.Text.Trim()
        Dim Provincia As String = Combo_provi.SelectedItem.ToString()
        Dim Distrito As String = Combo_dist.SelectedItem.ToString()

        ' Validar que todos los campos estén completos
        If String.IsNullOrEmpty(cedula) OrElse String.IsNullOrEmpty(nombre) OrElse String.IsNullOrEmpty(apellido) OrElse String.IsNullOrEmpty(Provincia) OrElse String.IsNullOrEmpty(Distrito) Then
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
        Dim exito As Boolean = conexionBD.AgregarNuevoprofesor(codigo, cedula, nombre, apellido, direccion, celular, correo, salario, Provincia, Distrito)
        If exito Then
            MessageBox.Show("Registro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar los controles después de agregar el registro)
        Else
            MessageBox.Show("Error al agregar el registro. Verifique los datos e inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Btn_modif_Click(sender As Object, e As EventArgs) Handles Btn_modif.Click
        Dim nuevocodigo As String = Txt_codigo.Text.Trim()
        Dim nuevaCedula As String = txt_cedu.Text.Trim()
        Dim nuevoNombre As String = Txt_nom.Text.Trim()
        Dim nuevoApellido As String = txt_ape.Text.Trim()
        Dim nuevaDireccion As String = txt_dirr.Text.Trim()
        Dim nuevoCelular As String = txt_cel.Text.Trim()
        Dim nuevoCorreo As String = txt_corr.Text.Trim()
        Dim nuevoSalario As String = txt_salar.Text.Trim()
        Dim nuevaProvincia As String = Combo_provi.SelectedItem.ToString()
        Dim nuevaDistrito As String = Combo_dist.SelectedItem.ToString()

        ' Validar que la cédula no esté vacía
        If String.IsNullOrEmpty(nuevocodigo) Then
            MessageBox.Show("El codigo no puede estar vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validar que al menos un campo adicional esté completo
        If String.IsNullOrEmpty(nuevoNombre) AndAlso String.IsNullOrEmpty(nuevoApellido) AndAlso String.IsNullOrEmpty(nuevaDireccion) AndAlso
        String.IsNullOrEmpty(nuevoCelular) AndAlso String.IsNullOrEmpty(nuevoCorreo) AndAlso String.IsNullOrEmpty(nuevoSalario) AndAlso String.IsNullOrEmpty(nuevaProvincia) AndAlso String.IsNullOrEmpty(nuevaDistrito) Then

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
        Dim exito As Boolean = conexionBD.Modificarprofesor(nuevocodigo, nuevaCedula, nuevoNombre, nuevoApellido, nuevaDireccion, nuevoCelular, nuevoCorreo, nuevoSalario, nuevaProvincia, nuevaDistrito)

        If exito Then
            MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al modificar el registro. Verifique los datos e inténtelo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
