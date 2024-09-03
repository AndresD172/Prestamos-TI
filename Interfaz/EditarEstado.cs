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
    public partial class EditarEstado : Form
    {
        public EditarEstado()
        {
            InitializeComponent();
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            VerificacionEditar editar = new VerificacionEditar();
            editar.ShowDialog();
        }
    }
}
