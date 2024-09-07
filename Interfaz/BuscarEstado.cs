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
    public partial class BuscarEstado : Form
    {
        public BuscarEstado()
        {
            InitializeComponent();
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            EditarEstado editar = new EditarEstado();
            editar.ShowDialog();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
