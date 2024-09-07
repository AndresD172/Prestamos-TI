using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGráfica
{
    public partial class NuevaMulta : Form
    {
        public NuevaMulta()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevaMulta_Click(object sender, EventArgs e)
        {

        }

        private void txtPrestatarioMulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void btnNuevoPrestatario_Click(object sender, EventArgs e)
        {
            NuevoPrestatario prestatario = new NuevoPrestatario();
            prestatario.Show();
        }

        private void btnNuevoTipoMulta_Click(object sender, EventArgs e)
        {
            NuevoTipoMulta tipoMulta = new NuevoTipoMulta();
            tipoMulta.Show();
        }

        private void btnNuevoTecnico_Click(object sender, EventArgs e)
        {
            NuevoUsuario user = new NuevoUsuario();
            user.Show();
        }
    }
}
