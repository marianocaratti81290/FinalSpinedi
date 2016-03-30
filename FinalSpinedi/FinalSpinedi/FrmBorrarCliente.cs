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
    public partial class FrmBorrarCliente : Form
    {
        public FrmBorrarCliente()
        {
            InitializeComponent();
        }

        private void FrmBorrarCliente_Load(object sender, EventArgs e)
        {
            GrillaClientes();
        }
        private void GrillaClientes()
        {
            flexGrillaCliente.DataSource = brl.obtenerClientes();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (flexGrillaCliente.RowSel != -1)
            {
               int  modSeleccion = (int)flexGrillaCliente[flexGrillaCliente.RowSel, "id_cliente"]; 
            }
        }
       
    }
}
