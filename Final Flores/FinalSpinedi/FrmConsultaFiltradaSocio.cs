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

        public int filtro = 0;
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaFiltradaSocio_Load(object sender, EventArgs e)
        {
           
        }

        private void GrillaSocio()
        {
                        
            if (rbNombre.Checked == true)
            {
                filtro = 0;
            }
            if (rbApellido.Checked == true)
            {
                filtro = 1;
            }
            if (rbTelefono.Checked == true)
            {
                filtro = 2;
            }
            if (rbactivo.Checked == true)
            {
                filtro = 3;
            }
            if (rbSancionado.Checked == true)
            {
                filtro = 4;
            }
        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                GrillaSocio();
                flexGrillaSocio.DataSource = brl.buscarSocioFiltrado(txtBuscar1.Text,filtro);
            }
        }
    }
}
