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
    public partial class FrmBorrarSocio : Form
    {
        public FrmBorrarSocio()
        {
            InitializeComponent();
        }

        private void FrmBorrarCliente_Load(object sender, EventArgs e)
        {
            GrillaSocio();
        }
        private void GrillaSocio()
        {
            flexGrillaSocio.DataSource = brl.obtenerSocio();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el socio", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (flexGrillaSocio.RowSel != -1)
                {
                    int modSeleccion = (int)flexGrillaSocio[flexGrillaSocio.RowSel, "id_socio"];
                    brl.borrarSocio(modSeleccion);
                    MessageBox.Show("El cliente se borro con exito");
                    GrillaSocio();
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexGrillaSocio.DataSource = brl.buscarCliente(txtBuscar1.Text);
            }
        }
       
    }
}
