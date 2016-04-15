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
    public partial class FrmInhabilitarUsuarios : Form
    {
        public FrmInhabilitarUsuarios()
        {
            InitializeComponent();
        }
        private string modSeleccion;
        private void btnhabilitar_Click(object sender, EventArgs e)
        {

        }

        private void btndesHabilitar_Click(object sender, EventArgs e)
        {

        }

        private void FrmInhabilitarUsuarios_Load(object sender, EventArgs e)
        {
            GrillaClientes();
        }

        private void GrillaClientes()
        {
            flexGrillaCliente.DataSource = brl.obtenerUsuarioxEstado();
        }

        private void flexGrillaCliente_SelChange(object sender, EventArgs e)
        {
            if (flexGrillaCliente.RowSel != -1)
            {
                modSeleccion = flexGrillaCliente[flexGrillaCliente.RowSel, "estado"].ToString();

            }
            if (modSeleccion == "Habilitado")
            {
                btndesHabilitar.Visible = true;
                btnhabilitar.Visible = false;

            }
            else
            {
                btndesHabilitar.Visible = false;
                btnhabilitar.Visible = true;

            }
        }
    }
}
