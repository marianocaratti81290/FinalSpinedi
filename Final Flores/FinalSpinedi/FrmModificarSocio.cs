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
    public partial class FrmModificarSocio : Form
    {
        public FrmModificarSocio()
        {
            InitializeComponent();
        }

        public static int modSeleccion=1;

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            GrillaSocio();
            obtenerProvincia();
        }

        private void GrillaSocio()
        {
            if (flexGrillaSocio.RowSel != -1)
            {
                flexGrillaSocio.DataSource = brl.obtenerSocio();
            }
               
        }
   
        private void flexGrillaCliente_SelChange(object sender, EventArgs e)
        {
            if (flexGrillaSocio.RowSel != -1)
            {
                modSeleccion= (int)flexGrillaSocio[flexGrillaSocio.RowSel, "id_socio"];


                try
                {
                    DataTable dtSocio = new DataTable();
                    dtSocio = brl.obtenerSocioSeleccionado(modSeleccion);

                    if (dtSocio.Rows.Count > 0)
                    {

                        txtApellid.Text = dtSocio.Rows[0]["apellido"].ToString();
                        txtNombre.Text = dtSocio.Rows[0]["nombre"].ToString();
                        txtDni.Text = dtSocio.Rows[0]["dni"].ToString();
                        dtpfecha_nac.Text = dtSocio.Rows[0]["fecha_nacimiento"].ToString();
                        dtpfecha_alta.Text = dtSocio.Rows[0]["fecha_alta"].ToString();
                        txtDireccion.Text = dtSocio.Rows[0]["direccion"].ToString();
                        cbLocalidad.Text = dtSocio.Rows[0]["localidad"].ToString();
                        cbProvincia.Text = dtSocio.Rows[0]["provincia"].ToString();
                        txtTelefono.Text = dtSocio.Rows[0]["telefono"].ToString();
                        txtEmail.Text = dtSocio.Rows[0]["email"].ToString();
                        cbSancionado.Text = dtSocio.Rows[0]["sancionado"].ToString();
                        dtpfcha_sancion.Text = dtSocio.Rows[0]["fecha_fin_sancion"].ToString();
                        cbEstado.Text = dtSocio.Rows[0]["activo"].ToString();
                        //txtobservacion.Text = dtSocio.Rows[0]["obsevacion"].ToString();


                        if (cbEstado.Text == "1")
                        {
                            cbEstado.Text = "Activo";

                        }
                        else
                            cbEstado.Text = "Inactivo";
                    }

                    if (cbSancionado.Text == "1")
                    {
                        cbSancionado.Text = "Si";

                    }
                    else
                    {
                        cbSancionado.Text = "No";
                    }
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea modificar el socio", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                brl.modificarSocio(modSeleccion, txtApellid.Text, txtNombre.Text, txtDni.Text, dtpfecha_nac.Text, dtpfecha_alta.Text, txtDireccion.Text, cbLocalidad.Text, cbProvincia.Text, txtTelefono.Text, txtEmail.Text, cbSancionado.Text, dtpfcha_sancion.Text, cbEstado.Text, txtobservacion.Text);
                                        
                MessageBox.Show("El socio se modifico con exito lo cambios se van a reflejar en el proximo inicio de sesion");

               // GrillaSocio();
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

        private void FrmModificarCliente_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexGrillaSocio.DataSource = brl.buscarUsuario(txtBuscar1.Text);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtBuscar1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
