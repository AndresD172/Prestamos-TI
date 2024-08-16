using Entidades;
using BL;
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
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos de datos hayan sido ingresados
            if (txtNombreUsuario.Text == String.Empty || txtApellidosUsuario.Text == String.Empty || txtCorreoUsuario.Text == String.Empty ||
            txtCarnetUsuario.Text == String.Empty || txtContraseñaUsuario.Text == String.Empty) {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadTécnico tecnico = new EntidadTécnico();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron
                tecnico.Nombre = txtNombreUsuario.Text.Trim();
                tecnico.Apellidos = txtApellidosUsuario.Text.Trim();
                tecnico.CorreoElectrónico = txtCorreoUsuario.Text.Trim();
                tecnico.NúmeroCarnet = txtCarnetUsuario.Text.Trim();
                tecnico.Contraseña = txtContraseñaUsuario.Text.Trim();

                respuesta=BLTécnico.RegistrarTécnico(tecnico);

                //Detección de errores
                if (respuesta.CódigoEstado==0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
