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
    public partial class FrmPermisoSistemas : Form
    {
        public FrmPermisoSistemas()
        {
            InitializeComponent();
        }

        public static string usr;
        
        private void FrmPermisoSistemas_Load(object sender, EventArgs e)
        {
           flexGrillaCliente.DataSource=  brl.obtenerUsuarios();
        }

        private void ModificarPermisoUsuarioI(string usr,string formulario)
        {
            brl.ModificarPermisosUsuarioI(usr, formulario);
        }

        private void ModificarPermisoUsuarioD(string usr, string formulario)
        {
            brl.ModificarPermisosUsuarioD(usr, formulario);
        }

        private void chkNuevoCliente_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void flexGrillaCliente_Click(object sender, EventArgs e)
        {

        }

        private void flexGrillaCliente_SelChange(object sender, EventArgs e)
        {
            if (flexGrillaCliente.RowSel != -1)
            {
                usr = flexGrillaCliente[flexGrillaCliente.RowSel, "usr"].ToString();
                obtenerPermisosxUsuario(usr);
            }


        }

        private void obtenerPermisosxUsuario (string usr)
        {
            DataTable dtTable = brl.PermisosxUsuario(usr);
            for (int i = 0; i < dtTable.Rows.Count; i++)
            {
                string mostrar = dtTable.Rows[i]["Formulario"].ToString();
                
                    if (mostrar == "FrmAcercaDe")
                    {
                        chkAcercaDe.Checked = true;
                    }
                    if (mostrar == "FrmBorrarCliente")
                    {
                        chkBorrarCliente.Checked = true;                    
                    }
                    if (mostrar == "FrmBorrarProducto")
                    {
                        chkBorrarProducto.Checked = true;
                    }
                    if (mostrar == "FrmBorrarProveedor")
                    {
                        chkBorrarProveedor.Checked = true;
                    }
                    if (mostrar == "FrmBorrarUsuario")
                    {
                        chkBorrarUsuario.Checked = true;
                    }
                    if (mostrar == "FrmClienteNuevo")
                    {
                        chkNuevoCliente.Checked = true;
                    }
                    if (mostrar == "FrmInhabilitarUsuarios")
                    {
                        chkInUsuario.Checked = true;
                    }
                    if (mostrar == "FrmLstClientes")
                    {
                        chkLstCliente.Checked = true;
                    }
                    if (mostrar == "FrmLstProductos")
                    {
                        chkLstProducto.Checked = true;
                    }
                    if (mostrar == "FrmLstProveedor")
                    {
                        chkLstProveedor.Checked = true;
                    }
                    if (mostrar == "FrmLstUsuarios")
                    {
                        chkLstUsuarios.Checked = true;
                    }
                    if (mostrar == "FrmModificarCliente")
                    {
                        chkModificarCliente.Checked = true;
                    }
                    if (mostrar == "FrmModificarProductos")
                    {
                        chkModificarProducto.Checked = true;
                    }
                    if (mostrar == "FrmModificarProveedor")
                    {
                        chkModificarProveedor.Checked = true;
                    }
                    if (mostrar == "FrmModificarUsuario")
                    {
                        chkModificarUsuario.Checked = true;
                    }
                    if (mostrar == "FrmNuevoUsuario")
                    {
                        chkNuevoUsuario.Checked = true;
                    }
                    if (mostrar == "FrmPermisoSistemas")
                    {
                        chkPermisosSistema.Checked = true;
                    }
                    if (mostrar == "FrmProductoNuevo")
                    {
                        chkNuevoProducto.Checked = true;
                    }
                    if (mostrar == "FrmProveedorNuevo")
                    {
                        chkNuevoProveedor.Checked = true;
                    }
            }
            

        }

        private void chkNuevoCliente_Click(object sender, EventArgs e)
        {
            if (chkNuevoCliente.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmClienteNuevo");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmClienteNuevo");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkModificarCliente_Click(object sender, EventArgs e)
        {
            if (chkModificarCliente.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmModificarCliente");
                MessageBox.Show("Permiso Insertado con exito");
            }

            else
            {
                ModificarPermisoUsuarioD(usr, "FrmModificarCliente");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkBorrarCliente_Click(object sender, EventArgs e)
        {
            if (chkBorrarCliente.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmBorrarCliente");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmBorrarCliente");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkNuevoProducto_Click(object sender, EventArgs e)
        {
            if (chkNuevoProducto.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmProductoNuevo");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmProductoNuevo");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkModificarProducto_Click(object sender, EventArgs e)
        {
            if (chkModificarProducto.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmModificarProductos");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmModificarProductos");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkBorrarProducto_Click(object sender, EventArgs e)
        {
            if (chkBorrarProducto.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmBorrarProducto");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmBorrarProducto");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (chkNuevoUsuario.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmNuevoUsuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmNuevoUsuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkModificarUsuario_Click(object sender, EventArgs e)
        {
            if (chkModificarUsuario.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmModificarUsuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmModificarUsuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkBorrarUsuario_Click(object sender, EventArgs e)
        {
            if (chkBorrarUsuario.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmBorrarUsuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmBorrarUsuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkPermisosSistema_Click(object sender, EventArgs e)
        {
            if (chkPermisosSistema.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmPermisoSistemas");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmPermisoSistemas");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkAcercaDe_Click(object sender, EventArgs e)
        {
            if (chkAcercaDe.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmAcercaDe");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmAcercaDe");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Presione F10 para refrezcar los permisos de usuario. Muchas Gracias");
        }

        private void chkInUsuario_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chkLstProducto_Click(object sender, EventArgs e)
        {
            if (chkLstProducto.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmLstProductos");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmLstProductos");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkLstCliente_Click(object sender, EventArgs e)
        {
            if (chkLstCliente.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmLstClientes");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmLstClientes");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkLstProveedor_Click(object sender, EventArgs e)
        {
            if (chkLstProveedor.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmLstProveedor");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmLstProveedor");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkSalir_Click(object sender, EventArgs e)
        {
            if (chkSalir.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "Salir");                
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "Salir");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkInUsuario_Click(object sender, EventArgs e)
        {
            if (chkInUsuario.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmInhabilitarUsuarios");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmInhabilitarUsuarios");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkHabUsuario_Click(object sender, EventArgs e)
        {
            if (chkHabUsuario.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmhabilitarUsuarios");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmhabilitarUsuarios");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkLstUsuarios_Click(object sender, EventArgs e)
        {
            if (chkLstUsuarios.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmLstUsuarios");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmLstUsuarios");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkModificarProveedor_Click(object sender, EventArgs e)
        {
            if (chkModificarProveedor.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmModificarProveedor");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmModificarProveedor");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkNuevoProveedor_Click(object sender, EventArgs e)
        {
            if (chkNuevoProveedor.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmProveedorNuevo");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmProveedorNuevo");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void chkBorrarProveedor_Click(object sender, EventArgs e)
        {
            if (chkBorrarProveedor.Checked == true)
            {
                ModificarPermisoUsuarioI(usr, "FrmBorrarProveedor");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmBorrarProveedor");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }
    }
}
