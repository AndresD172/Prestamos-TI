using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entidades;

namespace InterfazGráfica
{
    public partial class BuscarPrestatarios : EntidadPersona
    {
        public int IdPrestatario { get; set; }
        public int? IdSección { get; set; }
        public int? IdDepartamento { get; set; }
        public int IdEspecialidad { get; set; }

        public BuscarPrestatarios()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewPrestatario.Columns[0].HeaderText = "IdPrestatario";
            dataGridViewPrestatario.Columns[1].HeaderText = "Nombre";
            dataGridViewPrestatario.Columns[2].HeaderText = "Apellidos";
            dataGridViewPrestatario.Columns[3].HeaderText = "CorreoElectrónico";
            dataGridViewPrestatario.Columns[4].HeaderText = "NúmeroCarnet";
            dataGridViewPrestatario.Columns[5].HeaderText = "IdSección";
            dataGridViewPrestatario.Columns[6].HeaderText = "IdDepartamento";
            dataGridViewPrestatario.Columns[7].HeaderText = "IdEspecialidad";

        }

        private void BuscarCategoria_Load(object sender, EventArgs e)
        {
            this.FormatearDataGrid();
            dataGridViewPrestatario.DataSource = BLPrestatario.ListarPrestatario("%");
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["IdPrestatario"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.IdPrestatario = Convert.ToInt16(dataGridViewPrestatario.CurrentRow.Cells["IdPrestatario"].Value);
            this.Nombre = dataGridViewPrestatario.CurrentRow.Cells["Nombre"].Value.ToString();
            this.Apellidos = dataGridViewPrestatario.CurrentRow.Cells["Apellidos"].Value.ToString();
            this.CorreoElectrónico = dataGridViewPrestatario.CurrentRow.Cells["CorreoElectrónico"].Value.ToString();
            this.NúmeroCarnet = dataGridViewPrestatario.CurrentRow.Cells["NúmeroCarnet"].Value.ToString();
            this.IdSección = Convert.ToInt16(dataGridViewPrestatario.CurrentRow.Cells["IdSección"].Value);
            this.IdDepartamento = Convert.ToInt16(dataGridViewPrestatario.CurrentRow.Cells["IdDepartamento"].Value);
            this.IdEspecialidad = Convert.ToInt16(dataGridViewPrestatario.CurrentRow.Cells["IdEspecialidad"].Value);

        }

        private void btnEliminarPrestatario_Click(object sender, EventArgs e)
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
                respuesta = BLPrestatario.EliminarPrestatario(this.IdPrestatario);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }

        private void btnEditarPrestatario_Click(object sender, EventArgs e)
        {
            this.SeleccionarItemActual();
            EditarPrestatario editarPrestatario = new EditarPrestatario(this.IdPrestatario);
            editarPrestatario.Show();
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
            this.FormatearDataGrid();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            ;
        }
    }
}
