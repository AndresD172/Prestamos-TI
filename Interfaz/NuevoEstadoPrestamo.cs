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
    public partial class NuevoEstadoPrestamo : Form
    {
        public NuevoEstadoPrestamo()
        {
            InitializeComponent();
        }

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos de datos hayan sido ingresados
            if (txtDescripciónEstado.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadEstadoPréstamo estado = new EntidadEstadoPréstamo();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron
                estado.Nombre = txtDescripciónEstado.Text.Trim();

                respuesta = BLEstadoPrestamo.RegistrarEstadoPrestamo(estado);

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
    }
}
