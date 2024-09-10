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
    public partial class BuscarUsuario : Form
    {
        private int _id;

        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewUsuarios.Columns[0].HeaderText = "Id";
            dataGridViewUsuarios.Columns[1].HeaderText = "Nombre";
            dataGridViewUsuarios.Columns[2].HeaderText = "Apellidos";
            dataGridViewUsuarios.Columns[3].HeaderText = "Correo Electrónico";
            dataGridViewUsuarios.Columns[4].HeaderText = "Número de Carnet";
            dataGridViewUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SeleccionarItemActual()
        {
            string idSeleccionado = Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells["id"].Value);

            if (String.IsNullOrEmpty(idSeleccionado))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._id = Convert.ToInt32(idSeleccionado);
        }

        private void BuscarUsuario_Load(object sender, EventArgs e)
        {
            dataGridViewUsuarios.DataSource = BLTécnico.ListarTécnico("%").Contenido;
            FormatearDataGrid();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            VerificacionEliminacion verificacion = new VerificacionEliminacion();
            verificacion.ShowDialog();

            if (verificacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            SeleccionarItemActual();

            Respuesta respuesta = BLTécnico.EliminarTécnico(this._id);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewUsuarios.DataSource = BLTécnico.ListarTécnico("%").Contenido;
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            SeleccionarItemActual();

            EditarUsuario ventanaEdicion = new EditarUsuario(this._id);
            ventanaEdicion.Show();

            dataGridViewUsuarios.DataSource = BLTécnico.ListarTécnico("%").Contenido;
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

    }
}
