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
    public partial class BuscarPrestatarios : Form
    {
        public BuscarPrestatarios()
        {
            InitializeComponent();
        }

        private void btnEditarPrestatario_Click(object sender, EventArgs e)
        {
            EditarPrestatario editar = new EditarPrestatario();
            editar.ShowDialog();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
