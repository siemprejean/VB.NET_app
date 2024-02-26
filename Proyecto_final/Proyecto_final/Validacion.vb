Imports Microsoft.VisualBasic

Public Class Validacion
    Public Function ValidarTextoAlfabético(texto As String) As Boolean
        Return texto.All(Function(c) Char.IsLetter(c))
    End Function

    ' Método para validar cédula y celular (solo dígitos numéricos)
    Public Function ValidarDigitosNumericos(numero As String) As Boolean
        Return numero.All(Function(c) Char.IsDigit(c))
    End Function

    ' Método para validar correo (debe contener @ y al menos un punto)
    Public Function ValidarCorreo(correo As String) As Boolean
        Return correo.Contains("@") AndAlso correo.Contains(".")
    End Function
End Class
