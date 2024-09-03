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

    public partial class EditarSeccion : Form
    {
        private int Id { get; set; }

        public EditarSeccion()
        {
            InitializeComponent();
        }

        private void btnEditarSeccion_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacionEditar = new VerificacionEditar();
            verificacionEditar.Show();

            bool ejecutarAccion = verificacionEditar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadSección entidadSeccion = new EntidadSección { IdSección = Id, Nombre = txtDescripcionSeccion.Text };

            Respuesta respuesta;
            do
            {
                respuesta = BLSeccion.ActualizarSeccion(entidadSeccion);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }
    }
}
