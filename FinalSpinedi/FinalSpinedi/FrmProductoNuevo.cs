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
    public partial class FrmProductoNuevo : Form
    {
        public FrmProductoNuevo()
        {
            InitializeComponent();
        }
        public static int estado;

        private void txtPrecioPublico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void cbProveedor_MouseClick(object sender, MouseEventArgs e)
        {
            cbProveedor.DataSource = brl.ObtenerProductos();
            //indicamos el valor de los miembros
            cbProveedor.ValueMember = "proveedor";
            //se indica el valor a desplegar en el combobox
            cbProveedor.DisplayMember = "proveedor";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Estas seguro que desea agregar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                if (cbEstado.SelectedIndex == 0)
                {
                    estado =  1;
                }
                else
                {
                    estado = 0;
                }
               
                verificarDatos();
                limpiarClientes();
                MessageBox.Show("El producto se grabó con exito");
            }
                      
        }

        private void limpiarClientes()
        {
            txtNombre.Clear();
            cbEstado.Text="";
            cbProveedor.Text="";
            txtPrecioPublico.Text = "";
            nudCantidad.Value =0;
            txtPrecioProveedor.Clear();
            txtDescrip.Clear();
            txtbarra.Clear();
           
        }

        private void verificarDatos()
        {
            if (txtNombre.Text =="")
            {
                MessageBox.Show("Ingrese el Nombre del Cliente");
            }
            else
                if (cbEstado.Text == "")
                {
                    MessageBox.Show("Ingrese el apellido del cliente");
                }
                else
                    if (cbProveedor.Text == "")
                    {
                        MessageBox.Show("Ingrese el dni del cliente");
                    }
                    else
                        if (txtPrecioPublico.Text == "")
                        {
                            MessageBox.Show("Ingrese el sexo del cliente");
                        }
                        else
                            if (nudCantidad.Text == "")
                            {
                                MessageBox.Show("Ingrese el domicilio");
                            }
                            else
                                if (txtPrecioProveedor.Text == "")
                                {
                                    MessageBox.Show("ingrese la provincia del cliente");
                                }
                                else
                                    if (txtDescrip.Text == "")
                                    {
                                        MessageBox.Show("Ingrese la localidad del cliente");
                                    }
                                    else
                                        if (dtpfecha_nac.Text == "")
                                        {
                                            MessageBox.Show("Ingrese el codigo postal del cliente");
                                        }
                                        else
                                            if (txtbarra.Text == "")
                                            {
                                                MessageBox.Show("Ingrese la fecha de nacimiento");
                                            }
                                            else
                                            {

                                                brl.agregarProducto(txtNombre.Text, estado, cbProveedor.SelectedIndex, Convert.ToInt32(txtPrecioPublico.Text), Convert.ToInt32(nudCantidad.Text), Convert.ToInt32(txtPrecioProveedor.Text), txtDescrip.Text, dtpfecha_nac.Text, txtbarra.Text);
                                            }
        }

        private void txtPrecioProveedor_KeyPress(object sender, KeyPressEventArgs e)
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
