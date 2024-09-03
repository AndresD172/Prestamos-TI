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
    public partial class BuscarDepartamento : Form
    {
        public BuscarDepartamento()
        {
            InitializeComponent();
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            EditarDepartamento editar = new EditarDepartamento();
            editar.ShowDialog();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
