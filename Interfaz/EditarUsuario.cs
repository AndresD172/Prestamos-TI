using BL;
using DAL;
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
    public partial class EditarUsuario : Form
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private string _correo_electronico;
        private string _numero_carnet;

        public EditarUsuario(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            VerificacionEditar ventanaConfirmacion = new VerificacionEditar();
            ventanaConfirmacion.ShowDialog();

            if (ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            // Crear una instancia de Prestatario con los valores del formulario
            EntidadTécnico entidadUsuario = new EntidadTécnico
            {
                IdTécnico = this._id,
                Nombre = txnNombreUsurio.Text,
                Apellidos = txtApellidosUsuario.Text,
                CorreoElectrónico = txtCorreoUsuario.Text,
                NúmeroCarnet = txtCarnetUsuario.Text,
            };

            Respuesta respuesta = BLTécnico.ActualizarTécnico(entidadUsuario);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}