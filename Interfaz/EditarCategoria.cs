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
    public partial class EditarCategoria : Form
    {
        private int Id { get; set; }

        public EditarCategoria(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacionEditar = new VerificacionEditar();
            verificacionEditar.ShowDialog();

            bool ejecutarAccion = verificacionEditar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadCategoría entidadCategoría = new EntidadCategoría { IdCategoría = Id, Nombre = txtDescripcionCategoria.Text };

            Respuesta respuesta;
            do
            {
                respuesta = BLCategoria.ActualizarCategoria(entidadCategoría);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0); 
        }
    }
}
