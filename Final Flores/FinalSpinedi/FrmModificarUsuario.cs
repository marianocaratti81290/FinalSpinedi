using C1.Win.C1FlexGrid;
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
    public partial class FrmModificarUsuario : Form
    {
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        public static int modSeleccion;

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea modificar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                brl.modificarUsuario(modSeleccion, txtusr.Text, txtpass.Text);

                MessageBox.Show("El cliente se modifico con exito, los datos se van a actualizar en el proximo inicio de sesion");

            }
        }
     
        
        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            GrillaClientes();            
        }

         private void GrillaClientes()
        {
            flexGrillaCliente.DataSource = brl.obtenerUsuarios();
        }
       
         private void flexGrillaCliente_SelChange_1(object sender, EventArgs e)
         {
             if (flexGrillaCliente.RowSel != -1)
             {
                 modSeleccion = (int)flexGrillaCliente[flexGrillaCliente.RowSel, "id"];


                 try
                 {
                     DataTable dtCliente = new DataTable();
                     dtCliente = brl.obtenerUsuarioSeleccionado(modSeleccion);

                     if (dtCliente.Rows.Count > 0)
                     {

                         txtusr.Text = dtCliente.Rows[0]["usuario"].ToString();
                         txtpass.Text = dtCliente.Rows[0]["password"].ToString();

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
                
         private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (e.KeyChar == 13)
             {
                 flexGrillaCliente.DataSource= brl.buscarUsuario(txtBuscar1.Text);
             }
         }

         private void flexGrillaCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             flexGrillaCliente.DataSource = brl.obtenerSocio();
         }
    }
}
