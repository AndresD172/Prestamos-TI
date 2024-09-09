using BL;
using Entidades;
using System;
using System.Windows.Forms;

namespace InterfazGráfica
{
    public partial class BuscarPrestatarios : Form
    {
        private int _id;
        private string _nombre;
        private string _apellidos;
        private string _correo_electronico;
        private string _numero_carnet;
        private int _id_seccion;
        private int _id_departamento;
        private int _id_especialidad;

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
            if (dataGridViewPrestatario.CurrentRow == null)
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string idSeleccionado = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Id"].Value);
            string nombrePrestatario = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Nombre"].Value);
            string apellidosPrestatario = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Apellidos"].Value);
            string correoElectronico = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Correo Electrónico"].Value);
            string numeroCarnet = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Número de Carnet"].Value);
            string seccion = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Sección"].Value);
            string departamento = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Departamento"].Value);
            string especialidad = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Especialidad"].Value);

            this._id = Convert.ToInt32(idSeleccionado);
            this._nombre = nombrePrestatario;
            this._apellidos = apellidosPrestatario;
            this._correo_electronico = correoElectronico;
            this._numero_carnet = numeroCarnet;
            this._id_seccion = Convert.ToInt32(seccion);
            this._id_departamento = Convert.ToInt32(departamento);
            this._id_especialidad = Convert.ToInt32(especialidad);
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
