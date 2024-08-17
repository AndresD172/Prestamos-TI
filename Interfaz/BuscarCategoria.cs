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
    public partial class BuscarCategoria : Form
    {
        public BuscarCategoria()
        {
            InitializeComponent();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {



        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {

            EditarCategoria editar = new EditarCategoria();
            editar.ShowDialog();

        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
