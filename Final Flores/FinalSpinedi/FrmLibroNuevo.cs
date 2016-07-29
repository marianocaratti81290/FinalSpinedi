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
    public partial class FrmLibroNuevo : Form
    {
        public FrmLibroNuevo()
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
            //cbGenero.DataSource = brl.ObtenerLibros();
            ////indicamos el valor de los miembros
            //cbGenero.ValueMember = "proveedor";
            ////se indica el valor a desplegar en el combobox
            //cbGenero.DisplayMember = "proveedor";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Estas seguro que desea agregar el Libro", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {                                   
                verificarDatos();
                limpiarClientes();             
            }
                      
        }

        private void limpiarClientes()
        {
            txtTitulo.Clear();
            txtAutor.Text="";
            dtpfechaEdicion.Text = "";
            dtpFechaAlta.Text = "";
            cbGenero.Text="";
            txtEditorial.Text = "";
            txtISBN.Text = "";
            cbDonado.Text = "";
            txtEstado.Clear();
            cbActivo.Text = "";
            txtObservacion.Clear();
            
           
        }

        private void verificarDatos()
        {
            if (txtTitulo.Text =="")
            {
                MessageBox.Show("Ingrese el Nombre del Libro");
            }
            else
                if (txtAutor.Text == "")
                {
                    MessageBox.Show("Ingrese el autor del Libro");
                }
                else
                    if (cbGenero.Text == "")
                    {
                        MessageBox.Show("Ingrese el género del Libro");
                    }
                    else
                        if (txtISBN.Text == "")
                        {
                            MessageBox.Show("ingrese el ISBN del Libro");
                                }
                         
                            else
                        
                                    if (txtObservacion.Text == "")
                                    {
                                        MessageBox.Show("Ingrese una observación del Libro");
                                    }
                                    else
                                        if (dtpFechaAlta.Text == "")
                                        {
                                            MessageBox.Show("Ingrese la fecha de Alta del Libro");
                                        }
                                        else
                                            if (dtpfechaEdicion.Text == "")
                                        {
                                           MessageBox.Show("Ingrese la fecha de Edición del Libro");
                                         
                                          }  
                                            else
                        
                                            if (txtEstado.Text == "")
                                            {
                                                MessageBox.Show("Ingrese el estado del Libro");
                                            }
                                            else
                                            {

                                                brl.agregarLibro(txtTitulo.Text, txtAutor.Text, dtpfechaEdicion.Text, dtpFechaAlta.Text, cbGenero.SelectedIndex, txtEditorial.Text, txtISBN.Text, cbDonado.SelectedIndex, txtEstado.Text, cbActivo.SelectedIndex, txtObservacion.Text);
                                                MessageBox.Show("El libro se grabó con exito");
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLibroNuevo_Load(object sender, EventArgs e)
        {
            cbActivo.SelectedIndex = 1;
            cbDonado.SelectedIndex = 0;
        }

      
}

}
