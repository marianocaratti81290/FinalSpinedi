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
    public partial class FrmClienteNuevo : Form
    {
        public FrmClienteNuevo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea agregar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                verificarDatos();
                limpiarClientes();
                MessageBox.Show("El cliente se grabó con exito");
            }
                      
        }

        private void limpiarClientes()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtdni.Clear();
            cbsexo.Text = "";
            txtcel.Clear();
            txttel_fijo.Clear();
            txtdomicilio.Clear();
            cbProvincia.Text="";
            cbLocalidad.Text="";
            txtcp.Clear();
            txtEmail.Clear();
            dtpfecha_nac.Text = "";
        }

        private void verificarDatos()
        {
            if (txtnombre.Text =="")
            {
                MessageBox.Show("Ingrese el Nombre del Cliente");
            }
            else
                if (txtapellido.Text == "")
                {
                    MessageBox.Show("Ingrese el apellido del cliente");
                }
                else
                    if (txtdni.Text == "")
                    {
                        MessageBox.Show("Ingrese el dni del cliente");
                    }
                    else
                        if (cbsexo.Text == "")
                        {
                            MessageBox.Show("Ingrese el sexo del cliente");
                        }
                        else
                            if (txtdomicilio.Text == "")
                            {
                                MessageBox.Show("Ingrese el domicilio");
                            }
                            else
                                if (cbProvincia.Text == "")
                                {
                                    MessageBox.Show("ingrese la provincia del cliente");
                                }
                                else
                                    if (cbLocalidad.Text == "")
                                    {
                                        MessageBox.Show("Ingrese la localidad del cliente");
                                    }
                                    else
                                        if (txtcp.Text == "")
                                        {
                                            MessageBox.Show("Ingrese el codigo postal del cliente");
                                        }
                                        else
                                            if (dtpfecha_nac.Text == "")
                                            {
                                                MessageBox.Show("Ingrese la fecha de nacimiento");
                                            }
                                            else
                                            {
                                                brl.agregarCliente(txtnombre.Text, txtapellido.Text, txtdni.Text, dtpfecha_nac.Text, cbsexo.Text, txtcel.Text, txttel_fijo.Text, txtdomicilio.Text, cbProvincia.Text, cbLocalidad.Text, txtcp.Text, txtEmail.Text);
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

    }
}
