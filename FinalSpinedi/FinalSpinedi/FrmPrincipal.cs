﻿using C1.Win.C1FlexGrid;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            cargarProductos_Clientes();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void cargarProductos_Clientes()
        {
            try
            {
                flexProductosCod.DataSource= brl.ObtenerProductos();
                flexGrillaProductosPedidos.DataSource = brl.ObtenerProductosPedidos();
            }
            catch (Exception)
            {
                
                throw;
            }
 
        }

        private void flexProductosCod_KeyPress(object sender, KeyPressEventArgs e)
        {
          if (flexProductosCod.RowSel != -1)
             {
                flexProductosCod.DataSource = brl.ObtenerProductos();
             }
        }

        private void txtbuscarCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexProductosCod.ClearFilter();
                var filter = new ConditionFilter();

                if (txtbuscarCod.Text != "")
                {
                    filter.Condition1.Operator = ConditionOperator.Contains;
                    filter.Condition1.Parameter = txtbuscarCod.Text;
                    flexProductosCod.Cols["id_cliente"].Filter = filter;
                }
            }
        }
    }
}
