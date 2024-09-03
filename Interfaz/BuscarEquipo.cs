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
    public partial class BuscarEquipo : Form
    {
        public int IdEquipo { get; set; }
        public int IdCategoría { get; set; }
        public int IdEstadoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string NúmeroSerie { get; set; }
        public string Descripción { get; set; }

        public BuscarEquipo()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewEquipos.Columns[0].HeaderText = "IdEquipo";
            dataGridViewEquipos.Columns[1].HeaderText = "IdCategoría";
            dataGridViewEquipos.Columns[2].HeaderText = "IdEstadoEquipo";
            dataGridViewEquipos.Columns[3].HeaderText = "Marca";
            dataGridViewEquipos.Columns[4].HeaderText = "Modelo";
            dataGridViewEquipos.Columns[5].HeaderText = "NúmeroSerie";
            dataGridViewEquipos.Columns[6].HeaderText = "Descripción";

        }

        private void BuscarEquipos_Load(object sender, EventArgs e)
        {
            this.FormatearDataGrid();
            dataGridViewEquipos.DataSource = BLEquipo.ListarEquipo("%");
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewEquipos.CurrentRow.Cells["IdEquipo"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.IdEquipo = Convert.ToInt16(dataGridViewEquipos.CurrentRow.Cells["IdEquipo"].Value);
            this.IdEquipo = Convert.ToInt16(dataGridViewEquipos.CurrentRow.Cells["IdEquipo"].Value);
            this.IdCategoría = Convert.ToInt16(dataGridViewEquipos.CurrentRow.Cells["IdCategoría"].Value);
            this.IdEstadoEquipo = Convert.ToInt16(dataGridViewEquipos.CurrentRow.Cells["IdEstadoEquipo"].Value);
            this.Marca = dataGridViewEquipos.CurrentRow.Cells["Marca"].Value.ToString();
            this.Modelo = dataGridViewEquipos.CurrentRow.Cells["Modelo"].Value.ToString();
            this.NúmeroSerie = dataGridViewEquipos.CurrentRow.Cells["NúmeroSerie"].Value.ToString();
            this.Descripción = dataGridViewEquipos.CurrentRow.Cells["Descripción"].Value.ToString();
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
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
                respuesta = BLEquipo.EliminarEquipo(this.IdEquipo);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            this.SeleccionarItemActual();
            ModificarEquipo editarEquipo = new ModificarEquipo(this.IdEquipo);
            editarEquipo.Show();
        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = BLEquipo.ListarEquipo(txtBusqueda.Text);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewEquipos.DataSource = respuesta.Contenido;
            this.FormatearDataGrid();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}