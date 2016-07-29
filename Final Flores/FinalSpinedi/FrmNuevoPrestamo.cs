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
    public partial class FrmNuevoPrestamo : Form
    {
        public FrmNuevoPrestamo()
        {
            InitializeComponent();
        }
        private static int cbEstadoint;

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            validarPrestamo();           
        }

        private void validarPrestamo()
        {
            if (MessageBox.Show("Estas seguro que desea otorgar el prestamo", "Prestamo de Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (id_libro != 0 && id_socio != 0)
                {
                    int aprobado = 0;
                    aprobado = brl.validarPrestamo(id_libro, id_socio);

                    if (aprobado == 1)
                    {
                        MessageBox.Show("El libro se prestó de forma correcta");
                    }

                    else
                    {
                        MessageBox.Show("El prestamo no ha sido aprobado, controle el estado del libro y del socio");

                    }
                }
            }

        }

       
        private void GrillaSocio()
        {
            flexGrillaSocio.DataSource = brl.obtenerSocio();

        }

        private void FrmNuevoPrestamo_Load(object sender, EventArgs e)
        {
            GrillaSocio();
            GrillaLibros();
            RelacionLibroSocio();
        }

        private void GrillaLibros()
        {
            flexLibro.DataSource = brl.ObtenerLibros();

        }

        private void RelacionLibroSocio()
        {


        }

        public int id_socio;

        private void flexGrillaSocio_SelChange(object sender, EventArgs e)
        {
            if (flexGrillaSocio.RowSel != -1)
            {
                id_socio = (int)flexGrillaSocio[flexGrillaSocio.RowSel, "id_socio"];               
                
            }
        }

        public int id_libro;
  
        private void flexLibro_SelChange(object sender, EventArgs e)
        {
            if (flexLibro.RowSel != -1)
            {
                id_libro = (int)flexLibro[flexLibro.RowSel, "id_libro"];
              
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexGrillaSocio.DataSource = brl.buscarCliente(txtbuscarCod.Text);
            }
        }

        private void txtbuscarCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                flexLibro.DataSource = brl.buscarLibro(txtbuscarCod.Text);
            }
        }

        private void flexGrillaSocio_Click(object sender, EventArgs e)
        {

        }
    }

}
