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
    public partial class EditarDepartamento : Form
    {

        private int IdDepartamento { get; set; }

        public EditarDepartamento()
        {
            InitializeComponent();
            this.IdDepartamento = IdDepartamento;
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            VerificacionEditar editar = new VerificacionEditar();
            editar.ShowDialog();

            bool ejecutarAccion = editar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadDepartamento entidadDepartamento = new EntidadDepartamento { IdDepartamento = IdDepartamento, Nombre = txtDescripcionDepartamento.Text };

            Respuesta respuesta;
            do
            {
                respuesta = BLDepartamento.ActualizarDepartamento(entidadDepartamento);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);

        }
    }
}
