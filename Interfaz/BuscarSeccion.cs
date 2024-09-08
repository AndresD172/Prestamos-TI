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
    public partial class BuscarSeccion : Form
    {
        public BuscarSeccion()
        {
            InitializeComponent();
        }

        private void btnEditarSeccion_Click(object sender, EventArgs e)
        {
            EditarSeccion editar = new EditarSeccion();
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
