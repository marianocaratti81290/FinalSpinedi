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
               if (txtusuario.Text == "" && txtpass.Text == "")
                {
                    MessageBox.Show("Ingrese usuario y password");
                }
               else
                if (txtusuario.Text == "")
                {
                    MessageBox.Show("Ingrese un usuario");
                }
                else
                if (txtpass.Text == "")
                {
                    MessageBox.Show("Ingrese la contraseña");
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
                        MessageBox.Show("Sus datos no se encuentra en la base de datos. Consulte con su administrador");
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
