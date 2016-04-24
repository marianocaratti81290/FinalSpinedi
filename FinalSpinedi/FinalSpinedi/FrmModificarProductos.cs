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
    public partial class FrmModificarProductos : Form
    {
        public FrmModificarProductos()
        {
            InitializeComponent();
        }

        public static int modSeleccion;

        private void FrmModificarClientecs_Load(object sender, EventArgs e)
        {
            GrillaProductos();
        }

        private void GrillaProductos()
        {
            flexProductos.DataSource = brl.ObtenerProductos();
        }

        private void flexProductos_SelChange(object sender, EventArgs e)
        {
            if (flexProductos.RowSel != -1)
            {
               modSeleccion = (int)flexProductos[flexProductos.RowSel, "id_producto"];


                try
                {
                    DataTable dtCliente = new DataTable();
                    dtCliente = brl.obtenerProductoSeleccionado(modSeleccion);

                    if (dtCliente.Rows.Count > 0)
                    {

                        txtNombre.Text = dtCliente.Rows[0]["Nombre"].ToString();
                        cbEstado.Text = dtCliente.Rows[0]["estado"].ToString();
                        cbProveedor.Text = dtCliente.Rows[0]["Proveedor"].ToString();
                        txtPrecioPublico.Text = dtCliente.Rows[0]["Precio_Publico"].ToString();
                        txtcantidad.Text = dtCliente.Rows[0]["Cantidad"].ToString();
                        txtPrecioProveedor.Text = dtCliente.Rows[0]["Precio_Proveedor"].ToString();
                        txtDescrip.Text = dtCliente.Rows[0]["Descrip"].ToString();
                        dtpfecha_nac.Text = dtCliente.Rows[0]["fecha"].ToString();
                        txtbarra.Text = dtCliente.Rows[0]["codbarra"].ToString();
                        
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
            if (MessageBox.Show("Estas seguro que desea modificar el producto?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int estadoProveedor;

                if (cbEstado.Text == "Activo")
                {
                    estadoProveedor = 1;
                }
                else
                {
                    estadoProveedor = 0;

                }


                brl.modificarProducto(modSeleccion,
                                      txtNombre.Text,
                                      estadoProveedor,
                                      cbProveedor.SelectedIndex,
                                      Convert.ToInt32(txtcantidad.Text),
                                      Convert.ToInt32(txtPrecioPublico.Text),
                                      Convert.ToInt32(txtPrecioProveedor.Text),
                                      txtDescrip.Text,
                                      dtpfecha_nac.Text,
                                      txtbarra.Text);

                MessageBox.Show("El producto se modifico con exito");
                GrillaProductos();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            cbProveedor.DataSource = brl.obtenerProveedor();
            //indicamos el valor de los miembros
            cbProveedor.ValueMember = "nombre";
            //se indica el valor a desplegar en el combobox
            cbProveedor.DisplayMember = "nombre";
        }

    }
}
