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
    public partial class FrmLstProductos : Form
    {
        public FrmLstProductos()
        {
            InitializeComponent();
        }

        private void FrmLstProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'StockDataSet2.Productos' Puede moverla o quitarla según sea necesario.
            this.ProductosTableAdapter.Fill(this.StockDataSet2.Productos);

            this.reportViewer1.RefreshReport();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
