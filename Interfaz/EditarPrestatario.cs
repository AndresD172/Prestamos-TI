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
    public partial class EditarPrestatario : Form
    {
        private int _id;
        private int _idSeccion;
        private int _idDepartamento;
        private int _idEspecialidad;

        #region Variables

        int IdSeccion = 0;
        int IdDepartamento = 0;
        int IdEspecialidad = 0;
        #endregion

        #region Métodos

        //Metodos para el formato de los data grid view
        private void FormatoSeccion()
        {
            dataGridViewSeccion.Columns[1].HeaderText = "Sección";
            dataGridViewSeccion.Columns[0].Visible = false;
            dataGridViewSeccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void FormatoDepartamento()
        {
            dataGridViewDepartamento.Columns[1].HeaderText = "Departamento";
            dataGridViewDepartamento.Columns[0].Visible = false;
            dataGridViewSeccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatoEspecialidad()
        {
            dataGridViewEspecialidad.Columns[1].HeaderText = "Especialidad";
            dataGridViewEspecialidad.Columns[0].Visible = false;
            dataGridViewSeccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        //Metodos para cargar los listados en los data grid view 

        private void ListadoSeccion(string cTexto)
        {
            Respuesta respuesta = BLSeccion.ListarSeccion(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewSeccion.DataSource = respuesta.Contenido;
            this.FormatoSeccion();
        }

        private void ListadoDepartamento(string cTexto)
        {
            Respuesta respuesta = BLDepartamento.ListarDepartamento(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewDepartamento.DataSource = respuesta.Contenido;
            this.FormatoDepartamento();
        }

        private void ListadoEspecialidad(string cTexto)
        {
            Respuesta respuesta = BLEspecialidad.ListarEspecialidad(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewEspecialidad.DataSource = respuesta.Contenido;
            this.FormatoEspecialidad();
        }

        //Metodos para seleccionar un dato

        private void SeleccionarSeccion()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewSeccion.CurrentRow.Cells["id"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this._idSeccion = Convert.ToInt32(dataGridViewSeccion.CurrentRow.Cells["id"].Value);
                txtSecciónPrestatario.Text = Convert.ToString(dataGridViewSeccion.CurrentRow.Cells["nombre"].Value);

            }
        }

        private void SeleccionarDepartamento()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewDepartamento.CurrentRow.Cells["id"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdDepartamento = Convert.ToInt32(dataGridViewDepartamento.CurrentRow.Cells["id"].Value);
                txtDepartamentoPrestatario.Text = Convert.ToString(dataGridViewDepartamento.CurrentRow.Cells["nombre"].Value);

            }
        }

        private void SeleccionarEspecialidad()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewEspecialidad.CurrentRow.Cells["id"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdEspecialidad = Convert.ToInt32(dataGridViewEspecialidad.CurrentRow.Cells["id"].Value);
                txtEspecialidadPrestatario.Text = Convert.ToString(dataGridViewEspecialidad.CurrentRow.Cells["nombre"].Value);

            }
        }

        #endregion

        public EditarPrestatario(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void btnEditarPrestatario_Click(object sender, EventArgs e)
        {
            VerificacionEditar ventanaConfirmacion = new VerificacionEditar();
            ventanaConfirmacion.ShowDialog();

            if (ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            // Crear una instancia de Prestatario con los valores del formulario
            EntidadPrestatario entidadPrestatario = new EntidadPrestatario
            {
                IdPrestatario = this._id,
                Nombre = txtNombrePrestatario.Text,
                Apellidos = txtApellidosPrestatario.Text,
                CorreoElectrónico = txtCorreoPrestatario.Text,
                NúmeroCarnet = txtCarnetPrestatario.Text,
                IdSección = _idSeccion,
                IdDepartamento = _idSeccion,
                IdEspecialidad = _idEspecialidad
            };

            Respuesta respuesta = BLPrestatario.ActualizarPrestatario(entidadPrestatario);

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

        private void NuevoPrestatario_Load(object sender, EventArgs e)
        {
            this.ListadoSeccion("%");
            this.ListadoDepartamento("%");
            this.ListadoEspecialidad("%");

        }
        //Botones para abrir los panel
        private void btnSeccion_Click(object sender, EventArgs e)
        {
            this.panelSeccion.Location = btnSeccion.Location;
            this.panelSeccion.Visible = true;
            ListadoSeccion("%");
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            this.panelDepartamento.Location = btnDepartamento.Location;
            this.panelDepartamento.Visible = true;
            ListadoDepartamento("%");
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            this.panelEspecialidad.Location = btnEspecialidad.Location;
            this.panelEspecialidad.Visible = true;
            ListadoEspecialidad("%");
        }

        //Botones para cerrar los panel
        private void btnCerrarSeccion_Click(object sender, EventArgs e)
        {
            this.panelSeccion.Visible = false;
        }

        private void btnCerrarDepartamento_Click(object sender, EventArgs e)
        {
            this.panelDepartamento.Visible = false;
        }

        private void btnCerrarEspecialidad_Click(object sender, EventArgs e)
        {
            this.panelEspecialidad.Visible = false;
        }

        //Botones para buscar en los data grid view
        private void btnBuscarSeccion_Click(object sender, EventArgs e)
        {
            this.ListadoSeccion(txtBuscarSeccion.Text.Trim());
        }

        private void btnBuscarDepartamento_Click(object sender, EventArgs e)
        {
            this.ListadoDepartamento(txtBuscarDepartamento.Text.Trim());
        }

        private void btnBuscarEspecialidad_Click(object sender, EventArgs e)
        {
            this.ListadoEspecialidad(txtBuscarEspecialidad.Text.Trim());
        }

        //Seleccionar un dato en el data grid
        private void dataGridViewSeccion_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarSeccion();
            panelSeccion.Visible = false;
        }

        private void dataGridViewDepartamento_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarDepartamento();
            panelDepartamento.Visible = false;
        }

        private void dataGridViewEspecialidad_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarEspecialidad();
            panelEspecialidad.Visible = false;
        }
    }
}