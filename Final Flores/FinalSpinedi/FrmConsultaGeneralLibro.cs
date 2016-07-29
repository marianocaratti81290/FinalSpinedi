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
    public partial class FrmConsultaGeneralLibro : Form
    {
        public FrmConsultaGeneralLibro()
        {
            InitializeComponent();
        }

        private void FrmConsultaGeneralLibro_Load(object sender, EventArgs e)
        {
               GrillaLibros();
        
        }

        private void GrillaLibros()
        {
            if (flexGrillaLibros.RowSel != -1)
            {
                flexGrillaLibros.DataSource = brl.obtenerLibro();
            }
               
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
