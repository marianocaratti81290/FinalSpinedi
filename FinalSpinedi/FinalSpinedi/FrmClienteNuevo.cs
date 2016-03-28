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
            txtprovincia.Clear();
            txtlocalidad.Clear();
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
                                if (txtprovincia.Text == "")
                                {
                                    MessageBox.Show("ingrese la provincia del cliente");
                                }
                                else
                                    if (txtlocalidad.Text == "")
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
                                                brl.agregarCliente(txtnombre.Text,txtapellido.Text,txtdni.Text,dtpfecha_nac.Text,cbsexo.Text,txtcel.Text,txttel_fijo.Text,txtdomicilio.Text,txtprovincia.Text,txtlocalidad.Text,txtcp.Text,txtEmail.Text)
                                            }
        }
    }
}
