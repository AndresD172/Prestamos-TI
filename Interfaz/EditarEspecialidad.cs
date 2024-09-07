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

namespace InterfazGráfica
{
    public partial class EditarEspecialidad : Form
    {

        private int Id {  get; set; }

        public EditarEspecialidad()
        {
            InitializeComponent();
            this.Id = Id;
        }

        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            //VerificacionEditar verificacionEditar = new VerificacionEditar();
            //verificacionEditar.ShowDialog();

            //bool ejecutarAccion = verificacionEditar.Seleccion;

            //if (!ejecutarAccion)
            //{
            //    return;
            //}

            //EntidadEspecialidad entidadEspecialidad = new EntidadEspecialidad { IdEspecialidad = Id, Nombre = txtDescripcionEspecialidad.Text };

            //Respuesta respuesta;
            //do
            //{
            //    respuesta = BLEspecialidad.ActualizarEspecialidad(entidadEspecialidad);

            //    if (respuesta.CódigoEstado != 0)
            //    {
            //        MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //} while (respuesta.CódigoEstado != 0);
        }
        private void txtDescripcionCategoria_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
