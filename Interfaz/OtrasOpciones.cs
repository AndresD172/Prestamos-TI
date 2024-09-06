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
            Opciones opciones = new Opciones("TipoMulta");
            opciones.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();
            Opciones opciones = new Opciones("Categoria");
            opciones.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Opciones opciones = new Opciones("Especialidad");
            opciones.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Close();
            Opciones opciones = new Opciones("Estado");
            opciones.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Opciones opciones = new Opciones("Seccion");
            opciones.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Opciones opciones = new Opciones("Departamento");
            opciones.Show();
        }
    }
}
