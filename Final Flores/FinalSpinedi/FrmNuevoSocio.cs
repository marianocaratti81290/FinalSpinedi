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
    public partial class FrmNuevoSocio : Form
    {
        public FrmNuevoSocio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea agregar el socio", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                verificarDatos();
                limpiarSocio();
                MessageBox.Show("El cliente se grabó con exito");
            }
                      
        }

        private void limpiarSocio()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtdni.Clear();
            dtpFechaAlta.Text = "";
            dtpfecha_nac.Text= "";
            txttel_fijo.Clear();
            txtDireccion.Clear();
            cbProvincia.Refresh();
            cbLocalidad.Refresh();
            txtcp.Clear();
            txtEmail.Clear();          
            txtObservaciones.Clear();

        }

        private void verificarDatos()
        {
            if (txtnombre.Text =="")
            {
                MessageBox.Show("Ingrese el Nombre del socio");
            }
            else
                if (txtapellido.Text == "")
                {
                    MessageBox.Show("Ingrese el apellido del socio");
                }
                else
                    if (txtdni.Text == "")
                    {
                        MessageBox.Show("Ingrese el dni del socio");
                    }
                    else
                        if (dtpfecha_nac.Text == "")
                        {
                            MessageBox.Show("Ingrese la fecha del socio");
                        }
                        else
                            if (dtpFechaAlta.Text == "")
                            {
                                MessageBox.Show("Ingrese la fecha de alta del socio");
                            }
                            else
                            if (txtDireccion.Text == "")
                            {
                                MessageBox.Show("Ingrese la direccion del socio");
                            }
                            else
                                if (cbProvincia.Text == "")
                                {
                                    MessageBox.Show("ingrese la provincia del socio");
                                }
                                else
                                    if (cbLocalidad.Text == "")
                                    {
                                        MessageBox.Show("Ingrese la localidad del socio");
                                    }
                                    else
                                        if (txtcp.Text == "")
                                        {
                                            MessageBox.Show("Ingrese el codigo postal del socio");
                                        }
                                        else
                                            if (txttel_fijo.Text == "")
                                            {
                                                MessageBox.Show("Ingrese el telefono del socio");
                                            }
                                            else
                                            {
                                                brl.agregarSocio(txtnombre.Text, txtapellido.Text, txtdni.Text, dtpfecha_nac.Text, dtpFechaAlta.Text, txtDireccion.Text, cbProvincia.Text, cbLocalidad.Text, txttel_fijo.Text, txtEmail.Text, cbEstado.Text, txtcp.Text, txtObservaciones.Text);
                                            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txttel_fijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

     
        private void cbProvincia_MouseClick(object sender, MouseEventArgs e)
        {
            
            cbProvincia.DataSource = brl.ObtenerProvincias(); 
            //indicamos el valor de los miembros
            cbProvincia.ValueMember = "provincia";
            //se indica el valor a desplegar en el combobox
            cbProvincia.DisplayMember = "provincia";

          
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.nexo.com.ar/codigosPostales.asp");
            }
            catch { }
        }

        private void FrmNuevoSocio_Load(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 0;
        }



    }
}
