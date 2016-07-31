using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalSpinedi
{
    public partial class FrmModificarLibro : Form
    {
        public FrmModificarLibro()
        {
            InitializeComponent();
        }

        public static int modSeleccion;

        private void FrmModificarClientecs_Load(object sender, EventArgs e)
        {
            GrillaLibros();
        }

        private void GrillaLibros()
        {
            flexLibro.DataSource = brl.ObtenerLibros();
        }

        private void flexProductos_SelChange(object sender, EventArgs e)
        {
            if (flexLibro.RowSel != -1)
            {
               modSeleccion = (int)flexLibro[flexLibro.RowSel, "id_libro"];


                try
                {
                    DataTable dtCliente = new DataTable();
                    dtCliente = brl.obtenerLibroSeleccionado(modSeleccion);

                    if (dtCliente.Rows.Count > 0)
                    {

                        txtTitulo.Text = dtCliente.Rows[0]["Titulo"].ToString();
                        txtAutor.Text = dtCliente.Rows[0]["Autor"].ToString();
                        dtpFechaEdicion.Text = dtCliente.Rows[0]["fecha_edicion"].ToString();
                        dtpFechaAlta.Text = dtCliente.Rows[0]["fecha_alta"].ToString();
                        txtGenero.Text = dtCliente.Rows[0]["Genero"].ToString();
                        txtEditorial.Text = dtCliente.Rows[0]["Editorial"].ToString();
                        txtISBN.Text = dtCliente.Rows[0]["ISBN"].ToString();
                        cbDonado.Text = dtCliente.Rows[0]["donado"].ToString();
                        txtEstado.Text = dtCliente.Rows[0]["Estado"].ToString();
                        cbActivo.Text = dtCliente.Rows[0]["Activo"].ToString();
                        txtObservacion.Text = dtCliente.Rows[0]["Observacion"].ToString();
                        
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

         private void txtPrecioPublico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea modificar el Libro?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
              
                brl.modificarLibro (modSeleccion,
                                      txtTitulo.Text,
                                      txtAutor.Text,
                                      dtpFechaEdicion.Text,
                                      dtpFechaAlta.Text,
                                      Convert.ToInt32(txtGenero.Text),
                                      txtEditorial.Text,
                                      txtISBN.Text,
                                      Convert.ToInt32(cbDonado.Text),
                                      txtEstado.Text,
                                      Convert.ToInt32(cbActivo.Text),
                                      txtObservacion.Text);

                MessageBox.Show("El Libro se modifico con exito, los cambios se visualizaran en el proximo inicio de sesion");
           
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            //cbProveedor.DataSource = brl.obtenerProveedor();
            ////indicamos el valor de los miembros
            //cbProveedor.ValueMember = "nombre";
            ////se indica el valor a desplegar en el combobox
            //cbProveedor.DisplayMember = "nombre";
        }

        private void txtbuscarCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexLibro.DataSource = brl.buscarProducto(txtbuscarCod.Text);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flexLibro_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscarCod_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
