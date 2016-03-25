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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnacceder_Click(object sender, EventArgs e)
        {

            if (txtusuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario");
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("Ingrese la contraseña");
            }
            if (txtusuario.Text == "" && txtpass.Text == "")
            {
                MessageBox.Show("Ingrese usuario y password");
            }
            else
            {
                int existe = brl.logearUsuario(txtusuario.Text, txtpass.Text);

                if (existe == 1)
                {
                    new FrmPrincipal().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No esta registrado");
                }
            }
        }
    }
}
