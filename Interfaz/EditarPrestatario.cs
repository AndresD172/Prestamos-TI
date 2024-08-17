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
    public partial class EditarPrestatario : Form
    {
        public EditarPrestatario()
        {
            InitializeComponent();
        }

        private void btnEditarPrestatario_Click(object sender, EventArgs e)
        {

            VerificacionEditar verificar = new VerificacionEditar();
            verificar.ShowDialog();

        }

        private void btnSeccion_Click(object sender, EventArgs e)
        {

        }
    }
}
