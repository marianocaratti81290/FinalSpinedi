Imports brlSistema
Public Class wflClientes
    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)

        Dim x As New brlClientes
        'MsgBox("WFL-busca ID", vbInformation + vbOKOnly, "Aviso al operador")
        x.obtenerRegistro(idcliente, clientes)

    End Sub
    Public Sub obtenerRegistroDni(ByVal dni As String, ByRef clientes As DataTable)

        Dim x As New brlClientes

        x.obtenerRegistroDni(dni, clientes)

    End Sub
    Public Sub insertarRegistro(ByRef strmensaje As String,
                                ByVal id_legajo As Integer,
                                ByVal dni As String,
                                ByVal apellido As String,
                                ByVal nombre As String,
                                ByVal carrera As String,
                                ByVal situacion As String,
                                ByVal anio As String
                                )
        Dim x As New brlClientes
        Dim clientes As New DataTable
        Dim id As Integer

        If Not x.ExisteCliente(id_legajo) Then

            If Not x.ExisteDni(dni) Then
                x.insertarRegistro(id_legajo, dni, apellido, nombre, carrera, situacion, anio)
                strmensaje = "El alumno se agrego con exito"
            Else
                x.obtenerRegistroDni(dni, clientes)
                If clientes.Rows.Count > 0 Then
                    id = clientes.Rows(0)("idcliente")
                    strmensaje = "El dni ya fue ingresado para el IdAlumno: " & id.ToString()
                End If
            End If
        Else
            strmensaje = "El alumno Nº: " & id_legajo & " ya existe en la base"
        End If

    End Sub

    Public Sub eliminarRegistro(ByVal idlegajo As Integer, ByRef strmensaje As String)
        Dim x As New brlClientes
        If x.ExisteCliente(idlegajo) Then
            x.eliminarRegistro(idlegajo)
            strmensaje = "El alumno se elimino con exito"
        Else
            strmensaje = "El alumno no existe en la base"
        End If
    End Sub
    'En las wFL generalmente van procesos complejos que invlucran
    ' llamados a las otras capas. 
    ' Ejemplo Procesar Consumos Cliente
    ' En ese caso debere tener en la dtl un una dtl de facturas
    ' Una brl de facturas
    ' y aca traerlas y trabajarlas.

    Sub insertarRegistro(strmensaje As String, p2 As String, p3 As String, p4 As String, p5 As String, p6 As String, p7 As String, p8 As String, p9 As String, p10 As String, p11 As String)
        Throw New NotImplementedException
    End Sub

End Class
