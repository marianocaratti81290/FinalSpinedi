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
    public partial class FrmConsultaFiltradaLibro : Form
    {
        public FrmConsultaFiltradaLibro()
        {
            InitializeComponent();
        }

        public int filtro;

        private void FrmConsultaFiltradaLibro_Load(object sender, EventArgs e)
        {

        }

        private void GrillaLibros()
        {

            if (rbTitulo.Checked == true)
            {
                filtro = 0;
            }
            if (rbAutor.Checked == true)
            {
                filtro = 1;
            }
            if (rbGenero.Checked == true)
            {
                filtro = 2;
            }
            if (rbISBN.Checked == true)
            {
                filtro = 3;
            }
            if (rbEstado.Checked == true)
            {
                filtro = 4;
            }
        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                GrillaLibros();
                flexGrillaLibros.DataSource = brl.buscarLibrosFiltrado(txtBuscar1.Text, filtro);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
