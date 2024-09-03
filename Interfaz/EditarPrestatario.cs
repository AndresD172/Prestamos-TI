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
    public partial class EditarPrestatario : Form
    {
        private int IdPrestatario { get; set; }

        public EditarPrestatario(int id)
        {
            InitializeComponent();
            this.IdPrestatario = id;
        }

        private void btnEditarPrestatario_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacionEditar = new VerificacionEditar();
            verificacionEditar.Show();

            bool ejecutarAccion = verificacionEditar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadPrestatario entidadPrestatario = new EntidadPrestatario { 
                IdPrestatario = IdPrestatario, 
                Nombre = txtNombrePrestatario.Text,
                Apellidos = txtApellidosPrestatario.Text,
                CorreoElectrónico = txtCorreoPrestatario.Text,
                NúmeroCarnet = txtNombrePrestatario.Text,
                IdSección = txtBuscarSeccion.TabIndex,
                IdDepartamento = txtBuscarDepartamento.TabIndex,
                IdEspecialidad = txtBuscarEspecialidad.TabIndex,    
            };

            Respuesta respuesta;
            do
            {
                respuesta = BLPrestatario.ActualizarPrestatario(entidadPrestatario);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }
    }
}