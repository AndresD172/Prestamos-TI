using Entidades;
using BL;

namespace InterfazGráfica
{
    public partial class BuscarTipoMulta : Form
    {
        private int _id;
        private string _nombre;
        private string _descripcion;

        public BuscarTipoMulta()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewTipoMulta.Columns[0].HeaderText = "Id";
            dataGridViewTipoMulta.Columns[1].HeaderText = "Nombre";
            dataGridViewTipoMulta.Columns[2].HeaderText = "Descripción";
            dataGridViewTipoMulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SeleccionarItemActual()
        {
            string idSeleccionado = Convert.ToString(dataGridViewTipoMulta.CurrentRow.Cells[0].Value);
            string nombreTipoMulta = Convert.ToString(dataGridViewTipoMulta.CurrentRow.Cells[1].Value);
            string descripcionTipoMulta = Convert.ToString(dataGridViewTipoMulta.CurrentRow.Cells[3].Value);

            if (String.IsNullOrEmpty(idSeleccionado))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._id = Convert.ToInt32(idSeleccionado);
            this._nombre = nombreTipoMulta;
            this._descripcion = descripcionTipoMulta;
        }
        private void BuscarTipoMulta_Load(object sender, EventArgs e)
        {
            dataGridViewTipoMulta.DataSource = BLTipoMulta.ListarTipoMulta("%").Contenido;
            this.FormatearDataGrid();
        }

        private void btnEditarTipoMulta_Click(object sender, EventArgs e)
        {
            SeleccionarItemActual();

            EditarTipoMulta editar = new EditarTipoMulta(this._id);
            editar.Show();

            dataGridViewTipoMulta.DataSource = BLTipoMulta.ListarTipoMulta("%").Contenido;
        }

        private void btnEliminarTipoMulta_Click(object sender, EventArgs e)
        {
            VerificacionEliminacion ventanaConfirmacion = new VerificacionEliminacion();
            ventanaConfirmacion.ShowDialog();

            if (ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            SeleccionarItemActual();

            Respuesta respuesta = BLTipoMulta.EliminarMulta(this._id);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewTipoMulta.DataSource = BLTipoMulta.ListarTipoMulta("%").Contenido;
        }

        private void btnBuscarTipoMulta_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = BLTipoMulta.ListarTipoMulta(txtBusqueda.Text).Contenido;
        
            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewTipoMulta.DataSource = respuesta.Contenido;
            FormatearDataGrid();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
