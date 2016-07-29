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
    public partial class FrmBorrarLibro : Form
    {
        public FrmBorrarLibro()
        {
            InitializeComponent();
        }

        private void FrmBorrarProducto_Load(object sender, EventArgs e)
        {
            grillaProductos();
        }

        private void grillaProductos()
        {
            flexGridLibros.DataSource = brl.ObtenerLibros();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el producto", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (flexGridLibros.RowSel != -1)
                {
                    int modSeleccion = (int)flexGridLibros[flexGridLibros.RowSel, "id_producto"];
                    brl.borrarProducto(modSeleccion);
                    MessageBox.Show("El cliente se borro con exito");
                    flexGridLibros.Refresh();
                        
                }
            }
        }

        private void txtbuscarCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexGridLibros.DataSource = brl.buscarProducto(txtbuscarCod.Text);
            }
        }
    }
}
