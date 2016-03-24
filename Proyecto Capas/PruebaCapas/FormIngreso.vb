Imports wflSistema
Public Class FormIngreso

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If txtdni.Text = "" Then
            MessageBox.Show("Debe ingresar un dni en el campo dni")
        Else


            Dim x As New wflClientes

            Dim dt As New DataTable

            If txtlegajo.Text = Nothing Then
                x.obtenerRegistroDni(txtdni.Text, dt)
            Else

                x.obtenerRegistro(txtlegajo.Text, dt)
                'MsgBox("BUSQUEDA POR CLIENTE", vbInformation + vbOKOnly, "Aviso al operador")

            End If

            If dt.Rows.Count > 0 Then
                For Each MiDataRow As DataRow In dt.Rows
                    Me.txtlegajo.Text = MiDataRow(0).ToString()
                    Me.txtdni.Text = MiDataRow(1).ToString()
                    Me.txtapellido.Text = MiDataRow(2).ToString()
                    Me.txtnombre.Text = MiDataRow(3).ToString()
                    Me.txtcarrera.Text = MiDataRow(4).ToString()
                    Me.txtanio.Text = MiDataRow(5).ToString()
                    Me.txtsituacion.Text = MiDataRow(6).ToString()
                    txtlegajo.Enabled = False
                    txtapellido.Enabled = False
                    txtnombre.Enabled = False
                    txtcarrera.Enabled = False
                    txtanio.Enabled = False
                    txtsituacion.Enabled = False
                    btnInsertar.Visible = False
                    btnEliminar.Visible = False
                Next
            Else
                MsgBox("El cliente no existe en la base de datos", vbInformation + vbOKOnly, "Aviso al operador")
            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        If txtlegajo.Text = "" Then
            MessageBox.Show("El campo legajo es un campo obligatorio")
        Else
            If txtdni.Text = "" Then
                MessageBox.Show("El campo dni es un campo obligatorio")
            Else
                If txtapellido.Text = "" Then
                    MessageBox.Show("El campo apellido es un campo obligatorio")
                Else
                    If txtnombre.Text = "" Then
                        MessageBox.Show("El campo nombre es un campo obligatorio")
                    Else
                        If txtcarrera.Text = "" Then
                            MessageBox.Show("El campo carrera es un campo obligatorio")
                        Else
                            If txtsituacion.Text = "" Then
                                MessageBox.Show("El campo situacion es un campo obligatorio ")
                            Else
                                If txtanio.Text = "" Then
                                    MessageBox.Show("El campo año es un campo obligatorio")
                                Else


                                End If
                                Dim x As New wflClientes
                                Dim strmensaje As String = ""

                                x.insertarRegistro(strmensaje, txtlegajo.Text, txtdni.Text, txtapellido.Text, txtnombre.Text, txtcarrera.Text, txtanio.Text, txtsituacion.Text)

                                MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

                                Me.LimpiaPantalla()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If txtlegajo.Text = "" Then
            MessageBox.Show("El campo legajo no puede estar vacio")
        Else


            Dim x As New wflClientes
            Dim strmensaje As String = ""

            x.eliminarRegistro(txtlegajo.Text, strmensaje)
            MsgBox(strmensaje, MsgBoxStyle.OkOnly, "Mensaje al operador")

            Me.LimpiaPantalla()
        End If
    End Sub
    Public Sub LimpiaPantalla()
        txtlegajo.Text = ""
        txtnombre.Text = ""
        txtdni.Text = ""
        txtapellido.Clear()
        txtcarrera.Clear()
        txtanio.Clear()
        txtsituacion.Clear()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtcalle_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCUIL_TextChanged(sender As Object, e As EventArgs) Handles txtdni.TextChanged

    End Sub

    Private Sub txtLocalidad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles txtlegajo.TextChanged
       
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtdni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdni.KeyPress

        'solo se permite el ingreso de nros
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub AlumnoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnoToolStripMenuItem.Click
        btnInsertar.Visible = True
        txtlegajo.Enabled = True
        txtapellido.Enabled = True
        txtnombre.Enabled = True
        txtcarrera.Enabled = True
        txtanio.Enabled = True
        txtsituacion.Enabled = True
        txtlegajo.Clear()
        txtapellido.Clear()
        txtnombre.Clear()
        txtcarrera.Clear()
        txtanio.Clear()
        txtsituacion.Clear()
        txtdni.Clear()


    End Sub

    Private Sub txtanio_TextChanged(sender As Object, e As EventArgs) Handles txtanio.TextChanged
     
    End Sub

    Private Sub txtlegajo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtlegajo.KeyPress
        'solo se permite el ingreso de nros
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtanio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtanio.KeyPress
        'solo se permite el ingreso de nros
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AlumnoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlumnoToolStripMenuItem1.Click
        btnEliminar.Visible = True
        btnInsertar.Visible = True
        txtlegajo.Enabled = True
        txtapellido.Enabled = True
        txtnombre.Enabled = True
        txtcarrera.Enabled = True
        txtanio.Enabled = True
        txtsituacion.Enabled = True
        txtlegajo.Clear()
        txtapellido.Clear()
        txtnombre.Clear()
        txtcarrera.Clear()
        txtanio.Clear()
        txtsituacion.Clear()
        txtdni.Clear()
    End Sub
End Class
