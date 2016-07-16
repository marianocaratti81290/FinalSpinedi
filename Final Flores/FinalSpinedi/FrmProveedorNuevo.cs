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
    public partial class FrmProveedorNuevo : Form
    {
        public FrmProveedorNuevo()
        {
            InitializeComponent();
        }
        private static int cbEstadoint;

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea agregar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                verificarDatos();
                limpiarClientes();
                MessageBox.Show("El cliente se grabó con exito");
            }
        }

        private void verificarDatos()
        {
            if (txtnombre.Text == "")
            {
                MessageBox.Show("Ingrese el Nombre del Proveedor");
            }
            else
                if (cbEstado.Text == "")
                {
                    MessageBox.Show("Ingrese el estado del Proveedor");
                }
                else
                    if (txtdescrip.Text == "")
                    {
                        MessageBox.Show("Ingrese una descripcion del Proveedor");
                    }
                    else
                   
                       {

                          brl.agregarProveedor(txtnombre.Text, cbEstadoint, txtdescrip.Text, txtcel.Text, txttel_fijo.Text, txtContacto.Text, txtEmail.Text);
                       }
        }

        private void ConsultarEstado()
        {
            
            if (cbEstado.Text == "Activo")
            {
                cbEstadoint = 1;
            }
            else
            {
                cbEstadoint = 0;
            }

        }
            

        private void limpiarClientes()
        {
            txtnombre.Clear();
            cbEstado.Text = "";
            txtdescrip.Clear();
            txttel_fijo.Clear();
            txtcel.Clear();
            txtContacto.Clear();
            txtEmail.Clear();

        }

        private void txttel_fijo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProveedorNuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
