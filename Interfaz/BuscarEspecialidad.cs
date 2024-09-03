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
    public partial class BuscarEspecialidad : Form
    {
        public BuscarEspecialidad()
        {
            InitializeComponent();
        }

        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            EditarEspecialidad editar = new EditarEspecialidad();
            editar.ShowDialog();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
