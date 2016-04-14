﻿using System;
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
    public partial class FrmBorrarUsuario : Form
    {
        public FrmBorrarUsuario()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (flexGrillaCliente.RowSel != -1)
                {
                    int modSeleccion = (int)flexGrillaCliente[flexGrillaCliente.RowSel, "id_cliente"];
                    brl.borrarCliente(modSeleccion);
                    MessageBox.Show("El cliente se borro con exito");
                }
            }
        }

        private void FrmBorrarUsuario_Load(object sender, EventArgs e)
        {
            GrillaClientes();
        }

        private void GrillaClientes()
        {
            flexGrillaCliente.DataSource = brl.obtenerClientes();
        }
    }
}
