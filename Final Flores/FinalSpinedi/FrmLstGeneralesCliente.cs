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
    public partial class FrmLstGeneralesCliente : Form
    {
        public FrmLstGeneralesCliente()
        {
            InitializeComponent();
        }

        private void FrmLstGeneralesCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet1.Login' Puede moverla o quitarla según sea necesario.
            this.LoginTableAdapter.Fill(this.BibliotecaDataSet1.Login);
            // TODO: esta línea de código carga datos en la tabla 'BibliotecaDataSet.Socio' Puede moverla o quitarla según sea necesario.
           // this.SocioTableAdapter.Fill(this.BibliotecaDataSet.Socio);

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
