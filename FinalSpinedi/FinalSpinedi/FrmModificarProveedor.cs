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
    public partial class FrmModificarProveedor : Form
    {
        public FrmModificarProveedor()
        {
            InitializeComponent();
        }
        public static int modSeleccion;

        private void FrmModificarProveedor_Load(object sender, EventArgs e)
        {
            flexProveedor.DataSource = brl.obtenerProveedor();
        }

        private void flexProveedor_SelChange(object sender, EventArgs e)
        {
            if (flexProveedor.RowSel != -1)
            {
                modSeleccion = (int)flexProveedor[flexProveedor.RowSel, "id_producto"];


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
    }
}
