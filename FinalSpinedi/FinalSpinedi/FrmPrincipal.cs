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
            validarPermisosxUsuario();            
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

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmProductoNuevo().ShowDialog();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarProductos().ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarProducto().ShowDialog();
        }

        private void modificarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarUsuario().ShowDialog();
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoUsuario().ShowDialog();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarUsuario().ShowDialog();
        }

        private void inhabilitarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInhabilitarUsuarios().ShowDialog();
        }
            
        private void habilitarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInhabilitarUsuarios().ShowDialog();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }
    }
        private void validarPermisosxUsuario()
        {
            string usr = FrmLogin.UsuarioPermiso;
            string frm = "FrmBorrarCliente";
            int existe= brl.PermisosPuntualesUsuarios(usr,frm);   
              if (existe == 1)
                 {
                     crearClienteToolStripMenuItem.Visible = true;
                 }
            --------------------------------------------------------------------- //Cliente
              frm = "FrmModificarCliente";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  modificarClienteToolStripMenuItem.Visible = true;
              }
            --------------------------------------------------------------------- //Cliente
              frm = "FrmBorrarCliente";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  eliminarClienteToolStripMenuItem.Visible = true;
              }
            --------------------------------------------------------------------- //Cliente
              frm = "FrmProductoNuevo";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  nuevoProductoToolStripMenuItem.Visible = true;
              }
            --------------------------------------------------------------------- //Producto
              frm = "FrmModificarProductos";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  modificarProductoToolStripMenuItem.Visible = true;
              }
            --------------------------------------------------------------------- //Producto
              frm = "FrmBorrarProducto";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  eliminarProductoToolStripMenuItem.Visible = true;
              }
            --------------------------------------------------------------------- //Producto
              frm = "FrmProveedorNuevo";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  nuevoProveedorToolStripMenuItem.Visible = true;
              }
            --------------------------------------------------------------------- //Proveedor
              frm = "FrmProveedorNuevo";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  modificarProveedorToolStripMenuItem.Visible = true;
              }
            --------------------------------------------------------------------- //Proveedor
    }
}
