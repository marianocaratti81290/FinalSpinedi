Imports System.Data.SqlClient
Public Class dtlClientes

    Private Property oConn As SqlConnection



    Public Sub obtenerRegistro(ByRef idcliente As Integer, ByRef clientes As DataTable)

        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")

        If oConn.State = 1 Then oConn.Close()
        oConn.Open()

        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()

        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión

        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.CommandText = "Clientes_obtenerRegistro"

        Adp.SelectCommand.Parameters.Add("@idlegajo", SqlDbType.Int, 0)
        Adp.SelectCommand.Parameters("@idlegajo").Value = idcliente

        Adp.Fill(table)

        clientes = table

        oConn.Close()

    End Sub

    Public Sub obtenerRegistroDni(ByRef dni As String, ByRef clientes As DataTable)

        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")

        If oConn.State = 1 Then oConn.Close()
        oConn.Open()

        Dim table As New DataTable
        Dim Adp As New SqlDataAdapter()

        Adp.SelectCommand = New SqlCommand() ' Creando una Instancia de SqlCommand
        Adp.SelectCommand.Connection = oConn 'Conexión

        Adp.SelectCommand.CommandType = CommandType.StoredProcedure
        Adp.SelectCommand.CommandText = "clientes_obtenerRegistroPorDni"

        Adp.SelectCommand.Parameters.Add("@dni", SqlDbType.Char, 11)
        Adp.SelectCommand.Parameters("@dni").Value = dni

        Adp.Fill(table)

        clientes = table

        oConn.Close()

    End Sub

    Public Sub insertarRegistro(ByRef id_legajo As Integer, ByRef dni As String, ByRef apellido As String, nombre As String, carrera As String, anio As String, situacion As String)
        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(6) As SqlParameter

        param(0) = New SqlParameter("@idlegajo", id_legajo)
        param(1) = New SqlParameter("@dni", dni)
        param(2) = New SqlParameter("@apellido", apellido)
        param(3) = New SqlParameter("@nombre", nombre)
        param(4) = New SqlParameter("@carrera", carrera)
        param(5) = New SqlParameter("@anio", anio)
        param(6) = New SqlParameter("@situacion", situacion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "clientes_insertarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

    Public Sub eliminarRegistro(ByRef idlegajo As Integer)
        'oConn = New SqlConnection("Server=USUARIO-PC\SQLEXPRESS;Database=optisys;User Id=sa;Password=;")
        oConn = New SqlConnection("Server=.\SQLEXPRESS;Database=Segpool;Trusted_Connection=True;")
        If oConn.State = 1 Then oConn.Close()
        oConn.Open()
        Dim cmd As New SqlCommand
        Dim param(0) As SqlParameter

        param(0) = New SqlParameter("@idlegajo", idlegajo)


        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "clientes_eliminarRegistro"
        cmd.Connection = oConn
        cmd.Parameters.AddRange(param)


        cmd.ExecuteNonQuery()



    End Sub

  
End Class
