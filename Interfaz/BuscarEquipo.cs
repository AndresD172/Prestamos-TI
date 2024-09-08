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
    public partial class BuscarEquipo : Form
    {
        public BuscarEquipo()
        {
            InitializeComponent();
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            ModificarEquipo editar = new ModificarEquipo();
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
