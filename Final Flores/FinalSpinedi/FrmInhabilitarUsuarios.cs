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
        private int id_usuarioSeleccionado;
        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea habilitar el usuario", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                brl.cambiarEstadoUsuarios(id_usuarioSeleccionado, modSeleccion);
                GrillaClientes();
            }
        }

        private void btndesHabilitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea deshabilitar el usuario", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                brl.cambiarEstadoUsuarios(id_usuarioSeleccionado, modSeleccion);
                GrillaClientes();
            }
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
                id_usuarioSeleccionado = (int)flexGrillaCliente[flexGrillaCliente.RowSel, "id"];
                modSeleccion = flexGrillaCliente[flexGrillaCliente.RowSel, "estado"].ToString();

            }
            if (modSeleccion == "Habilitado")
            {
                btndesHabilitar.Visible = true;
                btnhabilitar.Visible = false;

            }
            if (modSeleccion == "Deshabilitado")
            {
                btndesHabilitar.Visible = false;
                btnhabilitar.Visible = true;

            }
        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexGrillaCliente.DataSource = brl.buscarUsuarioFiltradoEstado(txtBuscar1.Text);
            }
        }
    }
}
