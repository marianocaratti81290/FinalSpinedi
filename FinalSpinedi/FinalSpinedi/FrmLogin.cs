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
        public static string UsuarioPermiso;

        private void btnacceder_Click(object sender, EventArgs e)
        {
            validarUsuario();        
        }          

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
              if (e.KeyCode == Keys.Enter)
              {
                  validarUsuario();
              }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Comun.establecerConexion.Close();
        }


        private void validarUsuario()
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

                    UsuarioPermiso = txtusuario.Text;

                    if (existe == 1)
                    {
                        this.Hide();
                        new FrmPrincipal().ShowDialog();
                       
                    }
                    else
                    {
                        MessageBox.Show("No esta registrado");
                        limpiarLogin();
                        txtusuario.Focus();
                    }
                }
            }

        private void limpiarLogin()
        { 
            txtusuario.Text = "";
            txtpass.Text = "";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            lblExito.Visible= false;
            lblNoExito.Visible = false;

            try
            {
                Comun.establecerConexion.Open();
                lblExito.Visible = true;
                Comun.establecerConexion.Close();
            }
            catch (Exception)
            {

                lblNoExito.Visible = true;
            }

        }
    }
}
