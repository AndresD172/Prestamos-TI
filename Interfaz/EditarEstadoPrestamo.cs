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
    public partial class EditarEstadoPrestamo : Form
    {
        private int Id { get; set; }

        public EditarEstadoPrestamo(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacionEditar = new VerificacionEditar();
            verificacionEditar.Show();

            bool ejecutarAccion = verificacionEditar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadEstadoPréstamo entidadEstado = new EntidadEstadoPréstamo { IdEstadosPréstamo = Id, Nombre = txtDescripcionEstado.Text };

            Respuesta respuesta;
            do
            {
                respuesta = BLEstadoPrestamo.ActualizarEstadoPrestamo(entidadEstado);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }
    }
}
