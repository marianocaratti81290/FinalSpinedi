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
         //   cargarProductos_Clientes();

         //   string usr = FrmLogin.UsuarioPermiso;
         //   string frm = "FrmClienteNuevo";
         //   int existe= brl.PermisosPuntualesUsuarios(usr,frm);
         //   if (existe == 1)
         //   {
         //       crearClienteToolStripMenuItem.Enabled = true;
         //   }
         //   else
         //   {
         //       crearClienteToolStripMenuItem.Enabled = false;
         //   }
         //  // --------------------------------------------------------------------- //Cliente
         //     frm = "FrmModificarCliente";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         modificarClienteToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         modificarClienteToolStripMenuItem.Enabled = false;
         //     }
         // //  --------------------------------------------------------------------- //Cliente
         //     frm = "FrmBorrarCliente";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         eliminarClienteToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         eliminarClienteToolStripMenuItem.Enabled = false;
         //     }
         // //  --------------------------------------------------------------------- //Cliente
         //     frm = "FrmProductoNuevo";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         nuevoProductoToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         nuevoProductoToolStripMenuItem.Enabled = false;
         //     }
         //  // --------------------------------------------------------------------- //Producto
         //     frm = "FrmModificarProductos";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         modificarProductoToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         modificarProductoToolStripMenuItem.Enabled = false;
         //     }
         //  // --------------------------------------------------------------------- //Producto
         //     frm = "FrmBorrarProducto";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         eliminarProductoToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         eliminarProductoToolStripMenuItem.Enabled = false;
         //     }
         //  // --------------------------------------------------------------------- //Producto
         //     frm = "FrmProveedorNuevo";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         nuevoProveedorToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         nuevoProveedorToolStripMenuItem.Enabled = false;
         //     }
         //  // --------------------------------------------------------------------- //Proveedor

         //     frm = "FrmModificarProveedor";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         modificarProveedorToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         modificarProveedorToolStripMenuItem.Enabled = false;
         //     }
         //     // --------------------------------------------------------------------- //Proveedor

         //     // --------------------------------------------------------------------- //Proveedor

         //     frm = "FrmBorrarProveedor";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         eliminarProveedorToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         eliminarProveedorToolStripMenuItem.Enabled = false;
         //     }

         //     frm = "FrmNuevoUsuario";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         nuevoUsuarioToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         nuevoUsuarioToolStripMenuItem.Enabled = false;
         //     }
         //  // --------------------------------------------------------------------- //Usuario
         //     frm = "FrmModificarUsuario";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         modificarUsuarioToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         modificarUsuarioToolStripMenuItem.Enabled = false;
         //     }
         //   //--------------------------------------------------------------------- //Usuario
         //     frm = "FrmBorrarUsuario";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         eliminarUsuarioToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         eliminarUsuarioToolStripMenuItem.Enabled = false;
         //     }
         //   //--------------------------------------------------------------------- //Usuario
         //     frm = "FrmInhabilitarUsuarios";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         inhabilitarUsuariosToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         inhabilitarUsuariosToolStripMenuItem.Enabled = false;
         //     }
         //  // --------------------------------------------------------------------- //Usuario
         //     frm = "FrmInhabilitarUsuarios";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         habilitarUsuariosToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         habilitarUsuariosToolStripMenuItem.Enabled = false;
         //     }
         ////   --------------------------------------------------------------------- //Usuario
         //     frm = "FrmPermisoSistemas";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         permisosSistemaToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         permisosSistemaToolStripMenuItem.Enabled = false;
         //     }
         ////   --------------------------------------------------------------------- //PermisoSistemas

         //     frm = "Salir";
         //     existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //     if (existe == 1)
         //     {
         //         salirToolStripMenuItem.Enabled = true;
         //     }
         //     else
         //     {
         //         salirToolStripMenuItem.Enabled = false;
         //     }
         //   //   --------------------------------------------------------------------- //Salir

         //     frm = "FrmhabilitarUsuarios";            
         //   existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //   if (existe == 1)
         //   {
         //       habilitarUsuariosToolStripMenuItem.Enabled = true;
         //   }
         //   else
         //   {
         //       habilitarUsuariosToolStripMenuItem.Enabled = false;
         //   }
         //   //   --------------------------------------------------------------------- //Habilitar Usuarios
         //   frm = "FrmLstProductos";
         //   existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //   if (existe == 1)
         //   {
         //       listadoDeProductosToolStripMenuItem.Enabled = true;
         //   }
         //   else
         //   {
         //       listadoDeProductosToolStripMenuItem.Enabled = false;
         //   }
         //   //   --------------------------------------------------------------------- //lst productos

         //   frm = "FrmLstClientes";
         //   existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //   if (existe == 1)
         //   {
         //       listadoDeClientesToolStripMenuItem.Enabled = true;
         //   }
         //   else
         //   {
         //       listadoDeClientesToolStripMenuItem.Enabled = false;
         //   }
         //   //   --------------------------------------------------------------------- //lst clientes


         //   frm = "FrmLstProveedor";
         //   existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //   if (existe == 1)
         //   {
         //       listadoDeProveedoresToolStripMenuItem.Enabled = true;
         //   }
         //   else
         //   {
         //       listadoDeProveedoresToolStripMenuItem.Enabled = false;
         //   }
         //   //   --------------------------------------------------------------------- //lst proveedor


         //   frm = "FrmLstUsuarios";
         //   existe = brl.PermisosPuntualesUsuarios(usr, frm);
         //   if (existe == 1)
         //   {
         //       listadoDeUsuarioToolStripMenuItem.Enabled = true;
         //   }
         //   else
         //   {
         //       listadoDeUsuarioToolStripMenuItem.Enabled = false;
         //   }
         //   //   --------------------------------------------------------------------- //lst proveedor
             
    }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comun.establecerConexion.Close();
            MessageBox.Show("Gracias por utilizar el sistema");
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAcercaDe().ShowDialog();
        }

        private void cargarProductos_Clientes()
        {
            //try
            //{
            //    flexProductosCod.DataSource= brl.ObtenerProductos();
            //    //flexGrillaProductosPedidos.DataSource = brl.ObtenerProductosPedidos();
            //    flexGrillaClientes.DataSource = brl.obtenerClientes();
            //}
            //catch (Exception)
            //{
                
            //    throw;
            //}
 
        }


        private void crearClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoSocio().ShowDialog();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarSocio().ShowDialog();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarSocio().ShowDialog();
        }

        private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLibroNuevo().ShowDialog();
        }

        private void modificarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarLibro().ShowDialog();
        }

        private void eliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarLibro().ShowDialog();
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
            new FrmNuevoPrestamo().ShowDialog();//
        }

        private void modificarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarProveedor().ShowDialog();
        }

        private void eliminarProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarProveedor().ShowDialog();
        }

        private void permisosSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcion disponible en la version 1.0.1", "AVISO");
           
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F10)
            {
                menuStrip1.Refresh();

            }
        }


        private void filtradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaFiltradaLibro().ShowDialog();
        }

        private void modificacionDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void generalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaGeneralSocio().ShowDialog();
        }

        private void generalesToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            new FrmLstGeneralesSocio().ShowDialog();
        }

        private void filtradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaFiltradaSocio().ShowDialog();
        }

        private void generalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmConsultaGeneralLibro().ShowDialog();
        }

        private void generalesToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            new FrmLstGeneralesLibros().ShowDialog();
        }

        private void altaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoUsuario().ShowDialog();
        }

        private void modificacionUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarUsuario().ShowDialog();
        }

        private void bajaUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmBorrarUsuario().ShowDialog();
        }

        private void inhabilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInhabilitarUsuarios().ShowDialog();
        }

        private void habilitarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmInhabilitarUsuarios().ShowDialog();
        }

        private void filtradasToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new FrmConsultaGeneralesCliente().ShowDialog();
        }

        private void generalesToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            new FrmLstGeneralesCliente().ShowDialog();
        }

        private void generalesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new FrmConsultaGeneralPrestamo().ShowDialog();
        }

        private void ingresoDevolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDevolucion().ShowDialog();
        }
    }
      
}

