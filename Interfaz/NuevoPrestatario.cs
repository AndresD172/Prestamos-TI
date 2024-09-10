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
using DAL;
using Entidades;

namespace InterfazGráfica
{
    public partial class NuevoPrestatario : Form
    {
        public NuevoPrestatario()
        {
            InitializeComponent();
        }

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
            dataGridViewDepartamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatoEspecialidad()
        {
            dataGridViewEspecialidad.Columns[1].HeaderText = "Especialidad";
            dataGridViewEspecialidad.Columns[0].Visible = false;
            dataGridViewEspecialidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

                this.IdSeccion = Convert.ToInt32(dataGridViewSeccion.CurrentRow.Cells["id"].Value);
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

        //Cargar los listados
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
            this.ListadoSeccion("%");
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            this.panelDepartamento.Location = btnDepartamento.Location;
            this.panelDepartamento.Visible = true;
            this.ListadoDepartamento("%");
        }

        private void btnEspecialidad_Click(object sender, EventArgs e)
        {
            this.panelEspecialidad.Location = btnEspecialidad.Location;
            this.panelEspecialidad.Visible = true;
            this.ListadoEspecialidad("%");
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

        //Guardar Prestatario
        private void btnGuardarPrestatario_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos de datos hayan sido ingresados
            if (txtNombrePrestatario.Text == String.Empty || txtApellidosPrestatario.Text == String.Empty || txtCorreoPrestatario.Text == String.Empty ||
            txtCarnetPrestatario.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadPrestatario prestatario = new EntidadPrestatario();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron
                prestatario.Nombre = txtNombrePrestatario.Text.Trim();
                prestatario.Apellidos = txtApellidosPrestatario.Text.Trim();
                prestatario.CorreoElectrónico = txtCorreoPrestatario.Text.Trim();
                prestatario.NúmeroCarnet = txtCarnetPrestatario.Text.Trim();
                prestatario.IdSección = this.IdSeccion;
                prestatario.IdDepartamento = this.IdDepartamento;
                prestatario.IdEspecialidad = this.IdEspecialidad;

                respuesta = BLPrestatario.RegistrarPrestatario(prestatario);

                //Detección de errores
                if (respuesta.CódigoEstado == 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void btnNuevaSeccion_Click(object sender, EventArgs e)
        {
            NuevaSeccion seccion = new NuevaSeccion();
            seccion.Show();
        }

        private void btnNuevaEspecialidad_Click(object sender, EventArgs e)
        {
            NuevaEspecialidad especialidad = new NuevaEspecialidad();
            especialidad.Show();
        }

        private void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            NuevoDepartamento departamento = new NuevoDepartamento();
            departamento.Show();
        }
    }
}
