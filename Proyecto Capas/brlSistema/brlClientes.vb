Imports dtlSistema
Public Class brlClientes

    Public Sub obtenerRegistro(ByVal idcliente As Integer, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        'MsgBox("BRL-busca ID", vbInformation + vbOKOnly, "Aviso al operador")

        x.obtenerRegistro(idcliente, clientes)
    End Sub
    Public Sub obtenerRegistroDni(ByVal dni As String, ByRef clientes As DataTable)
        Dim x As New dtlClientes
        x.obtenerRegistroDni(dni, clientes)
    End Sub

    Public Sub insertarRegistro(ByVal id_legajo As Integer, ByVal dni As String, ByVal apellido As String, nombre As String, carrera As String, situacion As String, anio As String)
        Dim x As New dtlClientes
        x.insertarRegistro(id_legajo, dni, apellido, nombre, carrera, anio, situacion)
    End Sub

    Public Function ExisteCliente(ByVal idlegajo As Integer) As Boolean
        Dim x As New dtlClientes
        Dim clientes As New DataTable

        x.obtenerRegistro(idlegajo, clientes)

        If clientes.Rows.Count > 0 Then
            ExisteCliente = True
        Else
            ExisteCliente = False
        End If
    End Function

    Public Function ExisteDni(ByVal dni As String) As Boolean
        Dim x As New dtlClientes
        Dim clientes As New DataTable
        'Dim idcliente As Integer

        x.obtenerRegistroDni(dni, clientes)

        If clientes.Rows.Count > 0 Then
            'idcliente = clientes.Rows(0)("idcliente")
            ExisteDni = True
        Else
            ExisteDni = False
        End If
    End Function

    ''' <summary>
    ''' Este es un metodo que elimina un cliente dado su id
    ''' </summary>
    ''' <param name="idcliente"></param>
    ''' <remarks></remarks>
    Public Sub eliminarRegistro(ByVal idlegajo As Integer)
        Dim x As New dtlClientes
        x.eliminarRegistro(idlegajo)
    End Sub
End Class
