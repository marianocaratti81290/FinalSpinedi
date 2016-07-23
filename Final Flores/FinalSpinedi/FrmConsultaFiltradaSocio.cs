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
    public partial class FrmConsultaFiltradaSocio : Form
    {
        public FrmConsultaFiltradaSocio()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaFiltradaSocio_Load(object sender, EventArgs e)
        {
            GrillaSocio();
        }

        private void GrillaSocio()
        {
            if (rbNombre.Checked == true)
            { }

        }
    }
}
