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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InterfazGráfica
{
    public partial class EditarUsuario : Form
    {
        private int Id { get; set; }

        public EditarUsuario(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacionEditar = new VerificacionEditar();
            verificacionEditar.Show();

            bool ejecutarAccion = verificacionEditar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadTécnico entidadTécnico = new EntidadTécnico { IdTécnico = Id, Nombre = txnNombreUsurio.Text, Apellidos= txtApellidosUsuario.Text, NúmeroCarnet = txtCarnetUsuario.Text, CorreoElectrónico = txtCorreoUsuario.Text };

            Respuesta respuesta;
            do
            {
                respuesta = BLTécnico.ActualizarTécnico(entidadTécnico);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }
    }
}
