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
    public partial class BuscarPrestamos : Form
    {
        public BuscarPrestamos()
        {
            InitializeComponent();
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            ModificarPrestamo editar = new ModificarPrestamo();
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
