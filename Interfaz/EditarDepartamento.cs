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
    public partial class EditarDepartamento : Form
    {
        public EditarDepartamento()
        {
            InitializeComponent();
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            VerificacionEditar editar = new VerificacionEditar();
            editar.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
