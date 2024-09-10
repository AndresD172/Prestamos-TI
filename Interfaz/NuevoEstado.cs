using BL;
using Entidades;
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
    public partial class NuevoEstado : Form
    {
        public NuevoEstado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            EntidadEstadoPréstamo nuevoEstado = new EntidadEstadoPréstamo
            {
                Nombre = txtDescripciónEstado.Text
            };

            Respuesta respuesta = BLEstadoPrestamo.RegistrarEstadoPrestamo(nuevoEstado);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
