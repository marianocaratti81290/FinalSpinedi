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
    public partial class FrmLstGeneralesSocio : Form
    {
        public FrmLstGeneralesSocio()
        {
            InitializeComponent();
        }

        private void FrmLstGeneralesSocio_Load(object sender, EventArgs e)
        {
            if (flexGrillaSocio.RowSel != -1)
            {
                flexGrillaSocio.DataSource = brl.obtenerSocio();
            }
        }
    }
}
