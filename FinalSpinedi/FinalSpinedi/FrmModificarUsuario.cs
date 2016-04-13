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

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea modificar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                brl.modificarCliente(modSeleccion, txtNombre.Text, txtApellido.Text, txtDni.Text, dtpfecha_nac.Text, cbSexo.Text, txtCel.Text, txtTelefono.Text, txtDomicilio.Text, cbProvincia.Text, cbLocalidad.Text, txtCp.Text, txtEmail.Text);

                MessageBox.Show("El cliente se modifico con exito");
                GrillaClientes();
            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProvincia_MouseClick(object sender, MouseEventArgs e)
        {
            obtenerProvincia();
        }

        private void cbLocalidad_MouseClick(object sender, MouseEventArgs e)
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

        private void obtenerProvincia()
        {
            cbProvincia.DataSource = brl.ObtenerProvincias();
            //indicamos el valor de los miembros
            cbProvincia.ValueMember = "provincia";
            //se indica el valor a desplegar en el combobox
            cbProvincia.DisplayMember = "provincia";

        }

        private void flexGrillaCliente_Click(object sender, EventArgs e)
        {

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

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

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
    }
}
