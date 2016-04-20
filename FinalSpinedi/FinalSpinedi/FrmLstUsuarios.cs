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
    public partial class FrmLstUsuarios : Form
    {
        public FrmLstUsuarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLstUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'StockDataSet3.Usuario' Puede moverla o quitarla según sea necesario.
            this.UsuarioTableAdapter.Fill(this.StockDataSet3.Usuario);

            this.reportViewer1.RefreshReport();
        }
    }
}
