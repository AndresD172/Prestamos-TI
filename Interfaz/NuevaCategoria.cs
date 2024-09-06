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
    public partial class NuevaCategoria : Form
    {
        public NuevaCategoria()
        {
            InitializeComponent();
        }

        private void btnGuardarCategoria_Click(object sender, EventArgs e)
        {
            EntidadCategoría nuevaCategoria = new EntidadCategoría
            {
                Nombre = txtDescripciónCategoria.Text
            };

            Respuesta respuesta = BLCategoria.RegistrarCategoria(nuevaCategoria);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
