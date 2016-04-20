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
            if (chkNuevoCliente.Checked == true)
            {
            ModificarPermisoUsuarioI(usr, "FrmClienteNuevo");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmClienteNuevo");
            }
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

        private void chkModificarCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModificarCliente.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmModificarCliente");
            }

            else
            {
                ModificarPermisoUsuarioD(usr, "FrmModificarCliente");
            }
        }
        private void chkBorrarCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBorrarCliente.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmBorrarCliente");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmBorrarCliente");
            }
        }

        private void chkNuevoProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevoProducto.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmProductoNuevo");
            }  
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmProductoNuevo");
            }
        }

        private void chkModificarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModificarProducto.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmModificarProductos");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmModificarProductos");
            }
        }
        private void chkBorrarProducto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBorrarProducto.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmBorrarUsuario");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmBorrarUsuario");
            }
        }
        private void chkNuevoUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNuevoUsuario.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmNuevoUsuario");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmNuevoUsuario");
            }
        }
        private void chkModificarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkModificarUsuario.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmModificarUsuario");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmModificarUsuario");
            }
        }
        private void chkBorrarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBorrarUsuario.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmBorrarUsuario");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmBorrarUsuario");
            }
        }
        private void chkPermisosSistema_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPermisosSistema.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmPermisoSistemas");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmPermisoSistemas");
            }
        }
        private void chkAcercaDe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAcercaDe.Checked == false)
            {
                ModificarPermisoUsuarioI(usr, "FrmAcercaDe");
            }
            else
            {
                ModificarPermisoUsuarioD(usr, "FrmAcercaDe");
            }
        }
        private void chkSalir_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void obtenerPermisosxUsuario (string usr)
        {
            //DataTable dtTable = brl.PermisosxUsuario(usr);

            //foreach (DataRow row in dtTable.Rows)
            //{
            //    Console.WriteLine(row);
            //}
            

        }
    }
}
