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
        private string _nombre;
        private string _apellidos;
        private string _correo_electronico;
        private string _numero_carnet;
        private int _id_seccion;
        private int _id_departamento;
        private int _id_especialidad;

        #region Variables

        int IdSeccion = 0;
        int IdDepartamento = 0;
        int IdEspecialidad = 0;
        #endregion

        #region Métodos

        //Metodos para el formato de los data grid view
        private void FormatoSeccion()
        {
            dataGridViewSeccion.Columns[0].Width = 215;
            dataGridViewSeccion.Columns[0].HeaderText = "Sección";
            dataGridViewSeccion.Columns[1].Visible = false;
        }

        private void FormatoDepartamento()
        {
            dataGridViewDepartamento.Columns[0].Width = 215;
            dataGridViewDepartamento.Columns[0].HeaderText = "Departamento";
            dataGridViewDepartamento.Columns[1].Visible = false;
        }

        private void FormatoEspecialidad()
        {
            dataGridViewEspecialidad.Columns[0].Width = 215;
            dataGridViewEspecialidad.Columns[0].HeaderText = "Especialidad";
            dataGridViewEspecialidad.Columns[1].Visible = false;
        }

        //Metodos para cargar los listados en los data grid view 

        private void ListadoSeccion(string cTexto)
        {
            try
            {
                dataGridViewSeccion.DataSource = BLSeccion.ListarSeccion(cTexto);
                this.FormatoSeccion();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLSeccion.ListarSeccion(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoDepartamento(string cTexto)
        {
            try
            {
                dataGridViewDepartamento.DataSource = BLDepartamento.ListarDepartamento(cTexto);
                this.FormatoDepartamento();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLDepartamento.ListarDepartamento(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoEspecialidad(string cTexto)
        {
            try
            {
                dataGridViewEspecialidad.DataSource = BLEspecialidad.ListarEspecialidad(cTexto);
                this.FormatoEspecialidad();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLEspecialidad.ListarEspecialidad(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodos para seleccionar un dato

        private void SeleccionarSeccion()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewSeccion.CurrentRow.Cells["IdSeccion"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdSeccion = Convert.ToInt32(dataGridViewSeccion.CurrentRow.Cells["IdSeccion"].Value);
                txtSecciónPrestatario.Text = Convert.ToString(dataGridViewSeccion.CurrentRow.Cells["Nombre"].Value);

            }
        }

        private void SeleccionarDepartamento()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewDepartamento.CurrentRow.Cells["IdDepartamento"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdDepartamento = Convert.ToInt32(dataGridViewDepartamento.CurrentRow.Cells["IdDepartamento"].Value);
                txtDepartamentoPrestatario.Text = Convert.ToString(dataGridViewDepartamento.CurrentRow.Cells["Nombre"].Value);

            }
        }

        private void SeleccionarEspecialidad()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewEspecialidad.CurrentRow.Cells["IdEspecialidad"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdEspecialidad = Convert.ToInt32(dataGridViewEspecialidad.CurrentRow.Cells["IdEspecialidad"].Value);
                txtEspecialidadPrestatario.Text = Convert.ToString(dataGridViewEspecialidad.CurrentRow.Cells["Nombre"].Value);

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
                IdSección = Convert.ToInt32(txtSecciónPrestatario.Text),
                IdDepartamento = Convert.ToInt32(txtDepartamentoPrestatario.Text),
                IdEspecialidad = Convert.ToInt32(txtEspecialidadPrestatario.Text)
            };

            Respuesta respuesta = BLPrestatario.ActualizarPrestatario(entidadPrestatario).Contenido;

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
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            this.panelDepartamento.Location = btnDepartamento.Location;
            this.panelDepartamento.Visible = true;
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            this.panelEspecialidad.Location = btnEspecialidad.Location;
            this.panelEspecialidad.Visible = true;
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