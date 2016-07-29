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
    public partial class FrmConsultaGeneralesCliente : Form
    {
        public FrmConsultaGeneralesCliente()
        {
            InitializeComponent();
        }

        private void FrmConsultaGeneralesCliente_Load(object sender, EventArgs e)
        {
            GrillaCliente();

        }

        private void GrillaCliente()
        {
            if (flexGrillaCliente.RowSel != -1)
            {
                flexGrillaCliente.DataSource = brl.obtenerUsuarios();
            }

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
