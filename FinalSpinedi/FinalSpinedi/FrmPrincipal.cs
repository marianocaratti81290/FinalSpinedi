﻿using C1.Win.C1FlexGrid;
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

            string usr = FrmLogin.UsuarioPermiso;
            string frm = "FrmClienteNuevo";
            int existe= brl.PermisosPuntualesUsuarios(usr,frm);
            if (existe == 1)
            {
                crearClienteToolStripMenuItem.Enabled = true;
            }
            else
            {
                crearClienteToolStripMenuItem.Enabled = false;
            }
           // --------------------------------------------------------------------- //Cliente
              frm = "FrmModificarCliente";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  modificarClienteToolStripMenuItem.Enabled = true;
              }
              else
              {
                  modificarClienteToolStripMenuItem.Enabled = false;
              }
          //  --------------------------------------------------------------------- //Cliente
              frm = "FrmBorrarCliente";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  eliminarClienteToolStripMenuItem.Enabled = true;
              }
              else
              {
                  eliminarClienteToolStripMenuItem.Enabled = false;
              }
          //  --------------------------------------------------------------------- //Cliente
              frm = "FrmProductoNuevo";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  nuevoProductoToolStripMenuItem.Enabled = true;
              }
              else
              {
                  nuevoProductoToolStripMenuItem.Enabled = false;
              }
           // --------------------------------------------------------------------- //Producto
              frm = "FrmModificarProductos";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  modificarProductoToolStripMenuItem.Enabled = true;
              }
              else
              {
                  modificarProductoToolStripMenuItem.Enabled = false;
              }
           // --------------------------------------------------------------------- //Producto
              frm = "FrmBorrarProducto";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  eliminarProductoToolStripMenuItem.Enabled = true;
              }
              else
              {
                  eliminarProductoToolStripMenuItem.Enabled = false;
              }
           // --------------------------------------------------------------------- //Producto
              frm = "FrmProveedorNuevo";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  nuevoProveedorToolStripMenuItem.Enabled = true;
              }
              else
              {
                  nuevoProveedorToolStripMenuItem.Enabled = false;
              }
           // --------------------------------------------------------------------- //Proveedor

              frm = "FrmModificarProveedor";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  modificarProveedorToolStripMenuItem.Enabled = true;
              }
              else
              {
                  modificarProveedorToolStripMenuItem.Enabled = false;
              }
              // --------------------------------------------------------------------- //Proveedor

              // --------------------------------------------------------------------- //Proveedor

              frm = "FrmBorrarProveedor";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  eliminarProveedorToolStripMenuItem.Enabled = true;
              }
              else
              {
                  eliminarProveedorToolStripMenuItem.Enabled = false;
              }

              frm = "FrmNuevoUsuario";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  nuevoUsuarioToolStripMenuItem.Enabled = true;
              }
              else
              {
                  nuevoUsuarioToolStripMenuItem.Enabled = false;
              }
           // --------------------------------------------------------------------- //Usuario
              frm = "FrmModificarUsuario";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  modificarUsuarioToolStripMenuItem.Enabled = true;
              }
              else
              {
                  modificarUsuarioToolStripMenuItem.Enabled = false;
              }
            //--------------------------------------------------------------------- //Usuario
              frm = "FrmBorrarUsuario";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  eliminarUsuarioToolStripMenuItem.Enabled = true;
              }
              else
              {
                  eliminarUsuarioToolStripMenuItem.Enabled = false;
              }
            //--------------------------------------------------------------------- //Usuario
              frm = "FrmInhabilitarUsuarios";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  inhabilitarUsuariosToolStripMenuItem.Enabled = true;
              }
              else
              {
                  inhabilitarUsuariosToolStripMenuItem.Enabled = false;
              }
           // --------------------------------------------------------------------- //Usuario
              frm = "FrmInhabilitarUsuarios";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  habilitarUsuariosToolStripMenuItem.Enabled = true;
              }
              else
              {
                  habilitarUsuariosToolStripMenuItem.Enabled = false;
              }
         //   --------------------------------------------------------------------- //Usuario
              frm = "FrmPermisoSistemas";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  permisosSistemaToolStripMenuItem.Enabled = true;
              }
              else
              {
                  permisosSistemaToolStripMenuItem.Enabled = false;
              }
         //   --------------------------------------------------------------------- //PermisoSistemas

              frm = "Salir";
              existe = brl.PermisosPuntualesUsuarios(usr, frm);
              if (existe == 1)
              {
                  salirToolStripMenuItem.Enabled = true;
              }
              else
              {
                  salirToolStripMenuItem.Enabled = false;
              }
            //   --------------------------------------------------------------------- //Salir

              frm = "FrmhabilitarUsuarios";            
            existe = brl.PermisosPuntualesUsuarios(usr, frm);
            if (existe == 1)
            {
                habilitarUsuariosToolStripMenuItem.Enabled = true;
            }
            else
            {
                habilitarUsuariosToolStripMenuItem.Enabled = false;
            }
            //   --------------------------------------------------------------------- //Habilitar Usuarios
            frm = "FrmLstProductos";
            existe = brl.PermisosPuntualesUsuarios(usr, frm);
            if (existe == 1)
            {
                listadoDeProductosToolStripMenuItem.Enabled = true;
            }
            else
            {
                listadoDeProductosToolStripMenuItem.Enabled = false;
            }
            //   --------------------------------------------------------------------- //lst productos

            frm = "FrmLstClientes";
            existe = brl.PermisosPuntualesUsuarios(usr, frm);
            if (existe == 1)
            {
                listadoDeClientesToolStripMenuItem.Enabled = true;
            }
            else
            {
                listadoDeClientesToolStripMenuItem.Enabled = false;
            }
            //   --------------------------------------------------------------------- //lst clientes


            frm = "FrmLstProveedor";
            existe = brl.PermisosPuntualesUsuarios(usr, frm);
            if (existe == 1)
            {
                listadoDeProveedoresToolStripMenuItem.Enabled = true;
            }
            else
            {
                listadoDeProveedoresToolStripMenuItem.Enabled = false;
            }
            //   --------------------------------------------------------------------- //lst proveedor


            frm = "FrmLstUsuarios";
            existe = brl.PermisosPuntualesUsuarios(usr, frm);
            if (existe == 1)
            {
                listadoDeUsuarioToolStripMenuItem.Enabled = true;
            }
            else
            {
                listadoDeUsuarioToolStripMenuItem.Enabled = false;
            }
            //   --------------------------------------------------------------------- //lst proveedor
             
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
            new AboutBox1().ShowDialog();
        }

        private void cargarProductos_Clientes()
        {
            try
            {
                flexProductosCod.DataSource= brl.ObtenerProductos();
                //flexGrillaProductosPedidos.DataSource = brl.ObtenerProductosPedidos();
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
            new FrmProveedorNuevo().ShowDialog();
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
            new FrmPermisoSistemas().ShowDialog();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLstClientes().ShowDialog();
        }

        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLstProductos().ShowDialog();
        }

        private void listadoDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLstUsuarios().ShowDialog();
        }

        private void listadoDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLstProveedor().ShowDialog();
        }

        private void FrmPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F10)
            {
                menuStrip1.Refresh();

            }
        }

        private void txtbuscarCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexProductosCod.DataSource = brl.buscarProducto(txtbuscarCod.Text);
            }
        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexGrillaClientes.DataSource = brl.buscarCliente(txtBuscar1.Text);
            }
        }
    }
      
}

