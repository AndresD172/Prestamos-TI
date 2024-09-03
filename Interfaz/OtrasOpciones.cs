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
    public partial class OtrasOpciones : Form
    {
        public OtrasOpciones()
        {
            InitializeComponent();
        }

        private void btnUsuarioLogo_Click(object sender, EventArgs e)
        {

            this.Close();
            NuevoTipoMulta nuevo = new NuevoTipoMulta();
            nuevo.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            NuevaCategoria nuevo = new NuevaCategoria();
            nuevo.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevaEspecialidad nuevo = new NuevaEspecialidad();
            nuevo.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
            NuevoEstado nuevo = new NuevoEstado();
            nuevo.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevaSeccion nuevo = new NuevaSeccion();
            nuevo.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            NuevoDepartamento nuevo = new NuevoDepartamento();
            nuevo.ShowDialog();
        }
    }
}
