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
               int modSeleccion = (int)flexProductos[flexProductos.RowSel, "id_producto"];


                try
                {
                    DataTable dtCliente = new DataTable();
                    dtCliente = brl.obtenerClienteSeleccionado(modSeleccion);

                    if (dtCliente.Rows.Count > 0)
                    {

                        txtNombre.Text = dtCliente.Rows[0]["Nombre"].ToString();
                        cbEstado.Text = dtCliente.Rows[0]["Estado"].ToString();
                        cbProveedor.Text = dtCliente.Rows[0]["Proveedor"].ToString();
                        txtPrecioPublico.Text = dtCliente.Rows[0]["Precio_Publico"].ToString();
                        nudCantidad.Text = dtCliente.Rows[0]["Cantidad"].ToString();
                        txtPrecioProveedor.Text = dtCliente.Rows[0]["Precio_Proveedor"].ToString();
                        txtDescrip.Text = dtCliente.Rows[0]["Descrip"].ToString();
                     
                    }


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
       
        

    }
}
