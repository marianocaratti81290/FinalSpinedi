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
    public partial class FrmModificarCliente : Form
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            GrillaClientes();
            cargarDatos();
        }

        private void GrillaClientes()
        {
            flexGrillaCliente.DataSource = brl.obtenerClientes();
        }
        private void flexGrillaCliente_SelChange(object sender, EventArgs e)
        {
            if (flexGrillaCliente.RowSel != -1)
            {
                int modSeleccion = (int)flexGrillaCliente[flexGrillaCliente.RowSel, "id_cliente"];                
            }
        }

        private void cargarDatos()
        {
            try
            {
                DataTable dtCliente = new DataTable();
                dtCliente = brl.obtenerClientes();

                    if (dtCliente.Rows.Count > 0)
                    {

                        txtNombre.Text = dtCliente.Rows[0]["Nombre"].ToString();
                        txtApellido.Text = dtCliente.Rows[0]["Apellido"].ToString();
                        txtDni.Text = dtCliente.Rows[0]["DNI"].ToString();
                        txtNacimiento.Text = dtCliente.Rows[0]["fecha_nacimiento"].ToString();
                        txtSexo.Text = dtCliente.Rows[0]["sexo"].ToString();
                        txtCel.Text = dtCliente.Rows[0]["cel"].ToString();
                        txtTelefono.Text = dtCliente.Rows[0]["tel"].ToString();                       
                        txtLocalidad.Text = dtCliente.Rows[0]["Localidad"].ToString();
                        txtProvincias.Text = dtCliente.Rows[0]["Provincia"].ToString();
                        txtCp.Text = dtCliente.Rows[0]["cp"].ToString();
                        txtEmail.Text = dtCliente.Rows[0]["Email"].ToString();	
                       
                    }
                   
                
            }
            catch (Exception ex)
            {
           
                MessageBox.Show(ex.Message);
            }
        }
    }
}
