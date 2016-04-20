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
                        txtDescrip.Text = dtCliente.Rows[0]["descripcion"].ToString();
                        txtTelFijo.Text = dtCliente.Rows[0]["tel_fijo"].ToString();
                        txtCel.Text = dtCliente.Rows[0]["cel"].ToString();
                        txtReferente.Text = dtCliente.Rows[0]["nombre_contacto"].ToString();
                        txtEmail.Text = dtCliente.Rows[0]["email"].ToString();
                        
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
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
                    estadoProveedor=0;

                }


                brl.modificarProducto(modSeleccion, txtNombre.Text, estadoProveedor, txtDescrip.Text, txtTelFijo.Text, txtCel.Text, txtDescrip.Text, txtEmail.Text);
                
                MessageBox.Show("El producto se modifico con exito");
                GrillaProductos();
            }
        }

        private void cbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            cbProveedor.DataSource = brl.obtenerProveedor();
            //indicamos el valor de los miembros
            cbProveedor.ValueMember = "Nombre";
            //se indica el valor a desplegar en el combobox
            cbProveedor.DisplayMember = "Nombre";

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
       
        

    }
}
