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
    public partial class FrmConsultaGeneralPrestamo : Form
    {
        public FrmConsultaGeneralPrestamo()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaGeneralPrestamo_Load(object sender, EventArgs e)
        {
            grillaPrestamo();
        }

        private void grillaPrestamo()
        {
            flexGrillaPrestamo.DataSource = brl.obtenerPrestamos();

        }
    }
}
