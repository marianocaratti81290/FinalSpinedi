Imports wflSistema
Public Class Form1

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim x As New wflClientes
        Dim dt As New DataTable

        x.obtenerRegistro(txtIdCliente.Text, dt)
        For Each MiDataRow As DataRow In dt.Rows
            Me.txtrazonsocial.Text = MiDataRow(1).ToString
        Next

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.insertarRegistro(txtIdCliente.Text, txtrazonsocial.Text, strmensaje)

        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

        txtIdCliente.Text = ""
        txtrazonsocial.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x As New wflClientes
        Dim strmensaje As String = ""

        x.eliminarRegistro(txtIdCliente.Text, strmensaje)
        MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")
        txtIdCliente.Text = ""
        txtrazonsocial.Text = ""
    End Sub
End Class
