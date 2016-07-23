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
    public partial class FrmConsultaGeneralSocio : Form
    {
        public FrmConsultaGeneralSocio()
        {
            InitializeComponent();
        }

        private void FrmConsultaGeneralSocio_Load(object sender, EventArgs e)
        {
          
            GrillaSocio();
        
        }

        private void GrillaSocio()
        {
            if (flexGrillaSocio.RowSel != -1)
            {
                flexGrillaSocio.DataSource = brl.obtenerSocio();
            }
               
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
