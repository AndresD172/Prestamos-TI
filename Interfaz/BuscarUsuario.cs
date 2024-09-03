using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entidades;

namespace InterfazGráfica
{
    public partial class BuscarUsuario : Form
    {
        private int Id { get; set; }
        private string Nombre { get; set; }
        private string Apellidos { get; set; }
        private string NúmeroCarnet { get; set; }
        private string CorreoElectrónico { get; set; }

        public BuscarUsuario()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewUsuarios.Columns[0].HeaderText = "Id";
            dataGridViewUsuarios.Columns[1].HeaderText = "Nombre";
            dataGridViewUsuarios.Columns[2].HeaderText = "Apellidos";
            dataGridViewUsuarios.Columns[3].HeaderText = "Número de Carnet";
            dataGridViewUsuarios.Columns[4].HeaderText = "Correo Electrónico";
        }

        private void BuscarTécnico_Load(object sender, EventArgs e)
        {
            this.FormatearDataGrid();
            dataGridViewUsuarios.DataSource = BLTécnico.ListarTécnico("%");
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells["Id"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Id = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells["Id"].Value);
            this.Nombre = Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells["Nombre"].Value);
            this.Apellidos = Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells["Apellidos"].Value);
            this.NúmeroCarnet = Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells["NúmeroCarnet"].Value);
            this.CorreoElectrónico = Convert.ToString(dataGridViewUsuarios.CurrentRow.Cells["CorreoElectrónico"].Value);
        }

        private void btnEliminarTécnico_Click(object sender, EventArgs e)
        {
            VerificarEliminar verificarEliminar = new VerificarEliminar();
            verificarEliminar.Show();

            bool eliminarDato = verificarEliminar.Seleccion;

            verificarEliminar.Close();

            if (!eliminarDato)
            {
                return;
            }

            SeleccionarItemActual();

            Respuesta respuesta;
            do
            {
                respuesta = BLTécnico.EliminarTécnico(this.Id);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }

        private void btnEditarTécnico_Click(object sender, EventArgs e)
        {
            this.SeleccionarItemActual();
            EditarUsuario editarTécnico = new EditarUsuario(this.Id);
            editarTécnico.Show();
        }

        private void btnBuscarTécnico_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = BLTécnico.ListarTécnico(txtBusqueda.Text);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewUsuarios.DataSource = respuesta.Contenido;
            this.FormatearDataGrid();
        }
    }
}
