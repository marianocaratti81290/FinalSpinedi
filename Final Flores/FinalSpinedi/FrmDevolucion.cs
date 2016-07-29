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
    public partial class FrmDevolucion : Form
    {
        public FrmDevolucion()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDevolucion_Load(object sender, EventArgs e)
        {
            flexGrillaPrestamo.DataSource = brl.obtenerPrestamos();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea devolver el libro", "Devolucion de Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (id_prestamo != 0)
                {
                    int aprobado = 0;
                    aprobado = brl.validarDevolucion(id_prestamo);

                    if (aprobado == 1)
                    {
                        MessageBox.Show("El libro se devolvio de forma correcta");
                    }

                    else
                    {
                        MessageBox.Show("La devolucion no ha sido aprobada, controle el estado del libro y del socio");

                    }
                }
            }
        }

        public int id_prestamo;
        private void flexGrillaPrestamo_SelChange(object sender, EventArgs e)
        {
            if (flexGrillaPrestamo.RowSel != -1)
            {
                id_prestamo = (int)flexGrillaPrestamo[flexGrillaPrestamo.RowSel, "id_prestamo"];

            }
        }
    }
}
