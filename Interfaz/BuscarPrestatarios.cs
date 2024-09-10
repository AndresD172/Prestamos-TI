using BL;
using Entidades;
using System;
using System.Windows.Forms;

namespace InterfazGráfica
{
    public partial class BuscarPrestatarios : Form
    {
        private int _id;

        public BuscarPrestatarios()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewPrestatario.Columns[0].HeaderText = "Id";
            dataGridViewPrestatario.Columns[1].HeaderText = "Nombre";
            dataGridViewPrestatario.Columns[2].HeaderText = "Apellidos";
            dataGridViewPrestatario.Columns[3].HeaderText = "Correo Electrónico";
            dataGridViewPrestatario.Columns[4].HeaderText = "Número Carnet";
            dataGridViewPrestatario.Columns[5].HeaderText = "Id Sección";
            dataGridViewPrestatario.Columns[6].HeaderText = "Id Departamento";
            dataGridViewPrestatario.Columns[7].HeaderText = "Id Especialidad";
            dataGridViewPrestatario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SeleccionarItemActual()
        {
            string idSeleccionado = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["id"].Value);

            if (dataGridViewPrestatario.CurrentRow == null)
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._id = Convert.ToInt32(idSeleccionado);
        }

        private void BuscarPrestatario_Load(object sender, EventArgs e)
        {
            dataGridViewPrestatario.DataSource = BLPrestatario.ListarPrestatario("%").Contenido;
            this.FormatearDataGrid();
        }

        private void btnEliminarPrestatario_Click(object sender, EventArgs e)
        {
            VerificacionEliminacion ventanaConfirmacion = new VerificacionEliminacion();
            ventanaConfirmacion.ShowDialog();

            if (ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            SeleccionarItemActual();

            Respuesta respuesta = BLPrestatario.EliminarPrestatario(this._id);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewPrestatario.DataSource = BLPrestatario.ListarPrestatario("%").Contenido;
        }

        private void btnEditarPrestatario_Click(object sender, EventArgs e)
        {
            SeleccionarItemActual();

            EditarPrestatario ventanaEdicion = new EditarPrestatario(this._id);
            ventanaEdicion.Show();

            dataGridViewPrestatario.DataSource = BLPrestatario.ListarPrestatario("%").Contenido;
        }

        private void btnBuscarPrestatario_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = BLPrestatario.ListarPrestatario(txtBusqueda.Text);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewPrestatario.DataSource = respuesta.Contenido;
            FormatearDataGrid();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
