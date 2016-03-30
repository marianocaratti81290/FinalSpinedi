using C1.Win.C1FlexGrid;
using System;
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
                flexGrillaClientes.DataSource = brl.obtenerClientes();
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

        private void flexProductosCod_SelChange(object sender, EventArgs e)
        {            
                flexProductosCod.DataSource = brl.ObtenerProductos();         
        }

        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmClienteNuevo().ShowDialog();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarCliente().ShowDialog();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarCliente().ShowDialog();
        }

       
    }
}
