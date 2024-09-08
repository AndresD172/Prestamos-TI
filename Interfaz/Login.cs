using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BL;

namespace InterfazGráfica
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            Home home = new Home();
 
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // Remueve el botón de cerrar (X)
            this.ControlBox = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos de datos hayan sido ingresados
            if (txtUsuario.Text == String.Empty || txtContraseña.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadLogin login = new EntidadLogin();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron
                login.Usuario = txtUsuario.Text.Trim();
                login.Contraseña = txtContraseña.Text.Trim();

                respuesta = BLLogin.VerificarLogin(login);

                //verificación
                if (respuesta != null)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
