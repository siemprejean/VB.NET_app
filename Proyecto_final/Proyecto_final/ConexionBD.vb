Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data.MySqlClient


Public Class ConexionBD
    Private cadenaConexion As String = "Data Source=DESKTOP-310UPP6\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"
    Private conexion As SqlConnection

    Public Sub New(connectionString As String)
        cadenaConexion = connectionString
    End Sub

    Public Sub AbrirConexion()
        Try
            If conexion Is Nothing Then
                conexion = New SqlConnection(cadenaConexion)
            End If

            If conexion.State <> ConnectionState.Open Then
                conexion.Open()
                ' Verificar la conexión
                If conexion.State = ConnectionState.Open Then
                    Console.WriteLine("Conexión exitosa.")
                Else
                    Console.WriteLine("La conexión no se ha establecido correctamente.")
                End If
            End If
        Catch ex As Exception
            Console.WriteLine("Error al abrir la conexión: " & ex.Message)
        End Try
    End Sub

    Public Sub CerrarConexion()
        Try
            If Not conexion Is Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        Catch ex As Exception
            Throw New Exception("Error al cerrar la conexión a la base de datos.", ex)
        End Try
    End Sub
    Function ObtenerDatosDesdeProcedimiento() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_estudiante_Listar", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function ObtenerDatosPorCedula(cedula As String) As DataTable
        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand("dbo.sp_estudiante_Buscar", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Añadir parámetro para la cédula
                command.Parameters.Add("@cedula", SqlDbType.Char, 15).Value = cedula

                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function ObtenerNombresFacultades() As DataTable
        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand("dbo.sp_Facultad_Listar", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function

    Function ObtenerNombresCarreras() As DataTable
        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand("dbo.sp_Carrera_Listar", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function AgregarNuevoEstudiante(cedula As String, nombre As String, apellido As String, direccion As String, celular As String, correo As String, indice As String, sexo As String, facultad As String, carrera As String) As Boolean
        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                Using command As New SqlCommand("dbo.sp_AgregarEstudiante", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@cedula", cedula)
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellido", apellido)
                    command.Parameters.AddWithValue("@direccion", direccion)
                    command.Parameters.AddWithValue("@celular", celular)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@indice_academico", Convert.ToDecimal(indice))
                    command.Parameters.AddWithValue("@sexo", sexo)
                    command.Parameters.AddWithValue("@carrera", carrera)
                    command.Parameters.AddWithValue("@facultad", facultad)

                    command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As SqlException
            ' Manejar la excepción según tus necesidades
            Console.WriteLine("Error de SQL al agregar estudiante: " & ex.Message)
            Return False
        End Try
    End Function

    Function EliminarEstudiantePorCedula(cedula As String)
        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                Using command As New SqlCommand("sp_EliminarEstudiantePorCedula", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Agregar el parámetro @cedula
                    command.Parameters.AddWithValue("@cedula", cedula)

                    ' Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery()
                End Using
            End Using ' Al salir de este bloque, la conexión se cerrará automáticamente
        Catch ex As SqlException
            ' Manejar la excepción según tus necesidades
            Console.WriteLine("Error de SQL al eliminar estudiante: " & ex.Message)
        End Try
    End Function

    Function ModificarEstudiante(cedula As String, nombre As String, apellido As String, direccion As String, celular As String, correo As String, indice As String, sexo As String, facultad As String, carrera As String) As Boolean
        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                Using command As New SqlCommand("dbo.sp_ActualizarEstudiante", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@cedula", cedula)
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellido", apellido)
                    command.Parameters.AddWithValue("@direccion", direccion)
                    command.Parameters.AddWithValue("@celular", celular)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@indice_academico", Convert.ToDecimal(indice))
                    command.Parameters.AddWithValue("@sexo", sexo)
                    command.Parameters.AddWithValue("@carrera", carrera)
                    command.Parameters.AddWithValue("@facultad", facultad)

                    command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As SqlException
            ' Manejar la excepción según tus necesidades
            Console.WriteLine("Error de SQL al agregar estudiante: " & ex.Message)
            Return False
        End Try
    End Function
    Function ObtenerDatosprofesor() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_profesor_Listar", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function ObtenerNombresProvincias() As DataTable
        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand("dbo.sp_Provincia_Listar", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function

    Function ObtenerNombresDistritos() As DataTable
        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand("dbo.sp_Distritos_Listar", connection)
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function ObtenerDatosPorCodigo(codigo As String) As DataTable
        Using connection As New SqlConnection(cadenaConexion)
            Using command As New SqlCommand("dbo.sp_profesor_Buscar", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Añadir parámetro para la cédula
                command.Parameters.Add("@codigo", SqlDbType.Char, 15).Value = codigo

                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function Eliminarprofesorporcodigo(codigo As String)
        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                Using command As New SqlCommand("sp_Eliminarprofesorporcodigo", connection)
                    command.CommandType = CommandType.StoredProcedure

                    ' Agregar el parámetro @cedula
                    command.Parameters.AddWithValue("@codigo", codigo)

                    ' Ejecutar el procedimiento almacenado
                    command.ExecuteNonQuery()
                End Using
            End Using ' Al salir de este bloque, la conexión se cerrará automáticamente
        Catch ex As SqlException
            ' Manejar la excepción según tus necesidades
            Console.WriteLine("Error de SQL al eliminar profesor: " & ex.Message)
        End Try
    End Function

    Function AgregarNuevoprofesor(codigo As String, cedula As String, nombre As String, apellido As String, direccion As String, celular As String, correo As String, salario As String, Provincia As String, Distrito As String) As Boolean
        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()
                Console.WriteLine(salario)
                Using command As New SqlCommand("dbo.sp_Agregarprofesor", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@codigo", codigo)
                    command.Parameters.AddWithValue("@cedula", cedula)
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellido", apellido)
                    command.Parameters.AddWithValue("@direccion", direccion)
                    command.Parameters.AddWithValue("@celular", celular)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@salario", Convert.ToDecimal(salario))
                    command.Parameters.AddWithValue("@Provincia", Provincia)
                    command.Parameters.AddWithValue("@Distrito", Distrito)

                    command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As SqlException
            ' Manejar la excepción según tus necesidades
            Console.WriteLine("Error de SQL al agregar estudiante: " & ex.Message)
            Return False
        End Try
    End Function
    Function Modificarprofesor(codigo As String, cedula As String, nombre As String, apellido As String, direccion As String, celular As String, correo As String, salario As String, Provincia As String, Distrito As String) As Boolean
        Try
            Using connection As New SqlConnection(cadenaConexion)
                connection.Open()

                Using command As New SqlCommand("dbo.sp_Actualizarprofesor", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@codigo", codigo)
                    command.Parameters.AddWithValue("@cedula", cedula)
                    command.Parameters.AddWithValue("@nombre", nombre)
                    command.Parameters.AddWithValue("@apellido", apellido)
                    command.Parameters.AddWithValue("@direccion", direccion)
                    command.Parameters.AddWithValue("@celular", celular)
                    command.Parameters.AddWithValue("@correo", correo)
                    command.Parameters.AddWithValue("@salario", Convert.ToDecimal(salario))
                    command.Parameters.AddWithValue("@Provincia", Provincia)
                    command.Parameters.AddWithValue("@Distrito", Distrito)

                    command.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        Catch ex As SqlException
            ' Manejar la excepción según tus necesidades
            Console.WriteLine("Error de SQL al modificar profesor: " & ex.Message)
            Return False
        End Try
    End Function
    Function Ordenarnombreprof() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_ordenarnombreprof", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function Ordenarapellidoprof() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_ordenarapelprof", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function Ordenarceduprof() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_ordenarceduprof", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function Ordenarnombre() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_ordenarnombre", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function Ordenarapellido() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_ordenarapel", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Function Ordenarcedu() As DataTable
        Using connection As New SqlConnection(cadenaConexion)

            ' Crear un comando SQL con el nombre del procedimiento almacenado
            Using command As New SqlCommand("dbo.sp_ordenarcedu", connection)
                command.CommandType = CommandType.StoredProcedure

                ' Crear un adaptador de datos para llenar un DataTable
                Using adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
End Class

