Imports System.Windows.Forms
Imports Windows.Win32.UI
Imports System.Data.SqlClient
Imports System.Data
Imports MySql.Data.MySqlClient


Public Class Form1
    Private menuStrip As New MenuStrip()
    Private conexionBD As ConexionBD

    Sub New()
        Dim cadenaConexion As String = "Data Source=DESKTOP-310UPP6\SQLEXPRESS;Initial Catalog=final;Integrated Security=True"
        ' Inicializa la instancia de ConexionBD
        conexionBD = New ConexionBD(cadenaConexion)
        conexionBD.AbrirConexion()
        ' Agrega elementos al menú
        AgregarElementoMenu("Inicio", Nothing, Nothing)
        AgregarElementoSubMenu("Inicio", "Presentación", AddressOf MostrarFormularioPresentacion)
        AgregarElementoMenu("Mantenimiento", Nothing, Nothing)
        AgregarElementoSubMenu("Mantenimiento", "Estudiante", AddressOf MostrarFormularioEstudiante)
        AgregarElementoSubMenu("Mantenimiento", "Profesor", AddressOf MostrarFormularioProfesor)
        AgregarElementoMenu("Salir", AddressOf Salir)

        ' Configura el menú principal
        Controls.Add(menuStrip)
        MainMenuStrip = menuStrip
        Text = "Programa Principal"
    End Sub

    Private Sub AgregarElementoMenu(texto As String, eventoClick As EventHandler, Optional subMenu As Boolean = False)
        ' Crea un elemento de menú
        Dim menuItem As New ToolStripMenuItem(texto)

        ' Agrega el manejador de eventos si es necesario
        If eventoClick IsNot Nothing Then
            AddHandler menuItem.Click, eventoClick
        End If

        ' Agrega el elemento al menú o submenú
        If Not subMenu Then
            menuStrip.Items.Add(menuItem)
        Else
            ' Encuentra el último menú y agrégale el elemento como submenú
            DirectCast(menuStrip.Items(menuStrip.Items.Count - 1), ToolStripMenuItem).DropDownItems.Add(menuItem)
        End If
    End Sub

    Private Sub AgregarElementoSubMenu(textoMenu As String, textoSubMenu As String, eventoClick As EventHandler)
        ' Encuentra el menú al que se le agregará el submenú
        Dim menuPrincipal As ToolStripMenuItem = Nothing
        For Each menuItem As ToolStripItem In menuStrip.Items
            If menuItem.Text = textoMenu AndAlso TypeOf menuItem Is ToolStripMenuItem Then
                menuPrincipal = DirectCast(menuItem, ToolStripMenuItem)
                Exit For
            End If
        Next

        ' Si se encontró el menú principal, agrega el submenú
        If menuPrincipal IsNot Nothing Then
            AgregarElementoMenu(textoSubMenu, eventoClick, True)
        End If
    End Sub

    Private Sub MostrarFormularioPresentacion(sender As Object, e As EventArgs)
        Dim formularioPresentacion As New formulario1()
        ' Agrega el formulario como un control al área de contenido de FormPrincipal
        formulario1.TopLevel = False
        'formulario1.FormBorderStyle = FormBorderStyle.None
        formulario1.Dock = DockStyle.Fill
        Controls.Add(formulario1)

        formulario3.Hide()
        formulario2.Hide()
        formulario1.Show()

    End Sub

    Private Sub MostrarFormularioEstudiante(sender As Object, e As EventArgs)
        ' Aquí deberías crear una instancia de FormularioEstudiante y mostrarla
        ' Por ejemplo:
        Dim formularioEstudiante As New formulario2()
        formulario2.TopLevel = False
        'formulario2.FormBorderStyle = FormBorderStyle.None
        formulario2.Dock = DockStyle.Fill
        Controls.Add(formulario2)

        formulario1.Hide()
        formulario3.Hide()
        formulario2.Show()
    End Sub

    Private Sub MostrarFormularioProfesor(sender As Object, e As EventArgs)
        ' Aquí deberías crear una instancia de FormularioProfesor y mostrarla
        ' Por ejemplo:
        Dim formularioProfesor As New formulario3()
        formulario3.TopLevel = False
        'formulario3.FormBorderStyle = FormBorderStyle.None
        formulario3.Dock = DockStyle.Fill
        Controls.Add(formulario3)

        formulario1.Hide()
        formulario2.Hide()
        formulario3.Show()
    End Sub

    Private Sub Salir(sender As Object, e As EventArgs)
        ' Salir de la aplicación
        Application.Exit()
    End Sub
End Class
