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
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
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
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void verificarDatos()
        {
                                                      
           if (txtUsuario.Text == "")
             {
               MessageBox.Show("Ingrese el usuario");
             }
               else
                 if (txtPass.Text == "")
                   {
                      MessageBox.Show("Ingrese el password");
                   }
                      else
                         {
                           brl.agregarUsuario(txtUsuario.Text,txtPass.Text);
                         }
        }
                      
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
        
        
    }
}
