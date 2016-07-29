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
            grillaProveedor();
        }

        private void grillaProveedor()
        {
             flexProveedor.DataSource = brl.obtenerProveedor();
        }
        private void flexProveedor_SelChange(object sender, EventArgs e)
        {
            if (flexProveedor.RowSel != -1)
            {
                modSeleccion = (int)flexProveedor[flexProveedor.RowSel, "id_proveedor"];


                try
                {
                    DataTable dtCliente = new DataTable();
                    dtCliente = brl.obtenerLibroSeleccionado(modSeleccion);

                    if (dtCliente.Rows.Count > 0)
                    {


                        txtNombre.Text = dtCliente.Rows[0]["Nombre"].ToString();
                        cbEstado.Text = dtCliente.Rows[0]["estado"].ToString();
                        txtdescrip.Text = dtCliente.Rows[0]["descripcion"].ToString();
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
            if (MessageBox.Show("Estas seguro que desea modificar el proveedor?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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


                brl.modificarProveedor(modSeleccion, txtNombre.Text, estadoProveedor, txtdescrip.Text, txtTelFijo.Text, txtCel.Text, txtReferente.Text, txtEmail.Text);

                MessageBox.Show("El producto se modifico con exito");

                grillaProveedor();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscarNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexProveedor.DataSource = brl.buscarProveedor(txtbuscarNom.Text);
            }
        }
    }
}
