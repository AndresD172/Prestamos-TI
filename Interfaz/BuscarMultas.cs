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
    public partial class BuscarMultas : Form
    {
        public BuscarMultas()
        {
            InitializeComponent();
        }

        private void btnEditarMulta_Click(object sender, EventArgs e)
        {
            EditarMulta editar = new EditarMulta();
            editar.ShowDialog();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
