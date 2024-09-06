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
    public partial class NuevaEspecialidad : Form
    {

        public NuevaEspecialidad()
        {
            InitializeComponent();
        }

        private void btnGuardarEspecialidad_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos de datos hayan sido ingresados
            if (txtDescripciónEspecialidad.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadEspecialidad especialidad = new EntidadEspecialidad();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron
                especialidad.Nombre = txtDescripciónEspecialidad.Text.Trim();

                respuesta = BLEspecialidad.RegistrarEspecialidad(especialidad);

                //Detección de errores
                if (respuesta.CódigoEstado == 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void txtDescripciónCategoria_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
