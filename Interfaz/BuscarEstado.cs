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
    public partial class BuscarEstado : Form
    {
        private int Id { get; set; }
        private String Nombre { get; set; }

        public BuscarEstado()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewEstado.Columns[0].HeaderText = "Id";
            dataGridViewEstado.Columns[1].HeaderText = "Nombre";
        }

        private void BuscarEstado_Load(object sender, EventArgs e)
        {
            this.FormatearDataGrid();
            dataGridViewEstado.DataSource = BLEstadoEquipo.ListarEstadoEquipo("%");
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewEstado.CurrentRow.Cells["Id"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Id = Convert.ToInt16(dataGridViewEstado.CurrentRow.Cells["id"].Value);
            this.Nombre = Convert.ToString(dataGridViewEstado.CurrentRow.Cells["nombre"].Value);
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
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
                respuesta = BLEstadoEquipo.EliminarEstadoEquipo(this.Id);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            this.SeleccionarItemActual();
            EditarEstado editar = new EditarEstado(this.Id);
            editar.Show();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = BLEstadoEquipo.ListarEstadoEquipo(txtBusqueda.Text);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewEstado.DataSource = respuesta.Contenido;
            this.FormatearDataGrid();
        }
    }
}
