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
                brl.modificarUsuario(modSeleccion, txtNombre.Text, txtApellido.Text, txtDni.Text, dtpfecha_nac.Text, cbSexo.Text, txtCel.Text, txtTelefono.Text, txtDomicilio.Text, cbProvincia.Text, cbLocalidad.Text, txtCp.Text, txtEmail.Text);

                MessageBox.Show("El cliente se modifico con exito");

            }
        }
     
        private void cbProvincia_MouseClick(object sender, MouseEventArgs e)
        {
            obtenerProvincia();
        }
      
        private void obtenerProvincia()
        {
            cbProvincia.DataSource = brl.ObtenerProvincias();
            //indicamos el valor de los miembros
            cbProvincia.ValueMember = "provincia";
            //se indica el valor a desplegar en el combobox
            cbProvincia.DisplayMember = "provincia";

        }

      
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

      
        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            GrillaClientes();
            obtenerProvincia();
        }

         private void GrillaClientes()
        {
            flexGrillaCliente.DataSource = brl.obtenerUsuarios();
        }
       
         private void flexGrillaCliente_SelChange_1(object sender, EventArgs e)
         {
             if (flexGrillaCliente.RowSel != -1)
             {
                 modSeleccion = (int)flexGrillaCliente[flexGrillaCliente.RowSel, "id_usuario"];


                 try
                 {
                     DataTable dtCliente = new DataTable();
                     dtCliente = brl.obtenerUsuarioSeleccionado(modSeleccion);

                     if (dtCliente.Rows.Count > 0)
                     {

                         txtNombre.Text = dtCliente.Rows[0]["Nombre"].ToString();
                         txtApellido.Text = dtCliente.Rows[0]["Apellido"].ToString();
                         txtDni.Text = dtCliente.Rows[0]["DNI"].ToString();
                         dtpfecha_nac.Text = dtCliente.Rows[0]["fecha_nacimiento"].ToString();
                         cbSexo.Text = dtCliente.Rows[0]["sexo"].ToString();
                         txtCel.Text = dtCliente.Rows[0]["cel"].ToString();
                         txtTelefono.Text = dtCliente.Rows[0]["tel"].ToString();
                         cbLocalidad.Text = dtCliente.Rows[0]["Localidad"].ToString();
                         cbProvincia.Text = dtCliente.Rows[0]["Provincia"].ToString();
                         txtDomicilio.Text = dtCliente.Rows[0]["domicilio"].ToString();
                         txtCp.Text = dtCliente.Rows[0]["cp"].ToString();
                         txtEmail.Text = dtCliente.Rows[0]["Email"].ToString();
                         txtusr.Text = dtCliente.Rows[0]["usr"].ToString();
                         txtpass.Text = dtCliente.Rows[0]["pass"].ToString();

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

         private void cbLocalidad_MouseClick_1(object sender, MouseEventArgs e)
         {
             if (cbProvincia.Text != "")
             {
                 string valor = ((System.Data.DataRowView)cbProvincia.SelectedItem).Row.ItemArray[0].ToString();

                 cbLocalidad.DataSource = brl.obtenerLocalidadCorrespondiente(valor);
                 //indicamos el valor de los miembros
                 cbLocalidad.ValueMember = "localidad";
                 //se indica el valor a desplegar en el combobox
                 cbLocalidad.DisplayMember = "localidad";
             }
         }

         private void txtCel_KeyPress_1(object sender, KeyPressEventArgs e)
         {
             if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
             {
                 MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 e.Handled = true;
                 return;
             }
         }

         private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
         {         
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
             flexGrillaCliente.DataSource = brl.obtenerClientes();
         }
    }
}
