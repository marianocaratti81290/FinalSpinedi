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
    public partial class FrmInhabilitarUsuarios : Form
    {
        public FrmInhabilitarUsuarios()
        {
            InitializeComponent();
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btndesHabilitar_Click(object sender, EventArgs e)
        {

        }

        private void FrmInhabilitarUsuarios_Load(object sender, EventArgs e)
        {
            GrillaClientes();
        }

        private void GrillaClientes()
        {
            flexGrillaCliente.DataSource = brl.obtenerUsuarios();
        }
    }
}
