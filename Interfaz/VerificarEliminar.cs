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
    public partial class VerificarEliminar : Form
    {
        public bool Seleccion { get; set; }

        public VerificarEliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Seleccion = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Seleccion = false;
            this.Close();
        }
    }
}
