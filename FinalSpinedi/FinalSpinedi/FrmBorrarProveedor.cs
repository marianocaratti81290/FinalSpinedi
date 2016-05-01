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
    public partial class FrmBorrarProveedor : Form
    {
        public FrmBorrarProveedor()
        {
            InitializeComponent();
        }

        private void FrmBorrarProveedor_Load(object sender, EventArgs e)
        {
            flexGrillaProveedor.DataSource = brl.obtenerProveedor();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el proveedor", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (flexGrillaProveedor.RowSel != -1)
                {
                    int modSeleccion = (int)flexGrillaProveedor[flexGrillaProveedor.RowSel, "id_proveedor"];
                    brl.borrarProveedor(modSeleccion);
                    MessageBox.Show("El proveedor se borro con exito");
                    GrillaProveedor();
                }
            }
        }
            private void GrillaProveedor()
            {
                flexGrillaProveedor.DataSource = brl.obtenerProveedor();

            }
        }
    }

