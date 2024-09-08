using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entidades;
using Windows.Graphics.Printing.PrintSupport;

namespace InterfazGráfica
{
    public partial class EditarEspecialidad : Form
    {
        private int _id;

        public EditarEspecialidad(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            VerificacionEditar ventanaConfirmacion = new VerificacionEditar();
            ventanaConfirmacion.ShowDialog();

            if (ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            EntidadEspecialidad entidadEspecialidad = new EntidadEspecialidad
            {
                IdEspecialidad = this._id,
                Nombre = txtDescripcionEspecialidad.Text
            };

            Respuesta respuesta = BLEspecialidad.ActualizarEspecialidad(entidadEspecialidad).Contenido;

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
