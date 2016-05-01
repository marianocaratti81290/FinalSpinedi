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
    public partial class FrmLstProveedor : Form
    {
        public FrmLstProveedor()
        {
            InitializeComponent();
        }

        private void FrmLstProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'StockDataSet4.Proveedor' Puede moverla o quitarla según sea necesario.
            this.ProveedorTableAdapter.Fill(this.StockDataSet4.Proveedor);

            this.reportViewer1.RefreshReport();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
