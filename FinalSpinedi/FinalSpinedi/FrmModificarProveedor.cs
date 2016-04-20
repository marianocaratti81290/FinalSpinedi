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
    public partial class FrmModificarProveedor : Form
    {
        public FrmModificarProveedor()
        {
            InitializeComponent();
        }

        private void FrmModificarProveedor_Load(object sender, EventArgs e)
        {
            flexProveedor.DataSource = brl.obtenerProveedor();
        }
    }
}
