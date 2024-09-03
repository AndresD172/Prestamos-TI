using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace InterfazGráfica
{
    public partial class BuscarSeccion : Form
    {
        private int Id { get; set; }
        private String Nombre { get; set; }
        public BuscarSeccion()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewSeccion.Columns[0].HeaderText = "Id";
            dataGridViewSeccion.Columns[1].HeaderText = "Nombre";
        }

        private void BuscarSeccion_Load(object sender, EventArgs e)
        {
            this.FormatearDataGrid();
            dataGridViewSeccion.DataSource = BLSeccion.ListarSeccion("%");
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewSeccion.CurrentRow.Cells["Id"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Id = Convert.ToInt16(dataGridViewSeccion.CurrentRow.Cells["id"].Value);
            this.Nombre = Convert.ToString(dataGridViewSeccion.CurrentRow.Cells["nombre"].Value);
        }

        private void btnEliminarSeccion_Click(object sender, EventArgs e)
        {
            VerificarEliminar verificarEliminar = new VerificarEliminar();
            verificarEliminar.Show();

            bool eliminarDato = verificarEliminar.Seleccion;

            verificarEliminar.Close();

            if (eliminarDato)
            {
                SeleccionarItemActual();
                Respuesta respuesta = BLSeccion.EliminarSeccion(this.Id);

                do
                {
                    if (respuesta.CódigoEstado != 0)
                    {
                        MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    respuesta = BLSeccion.EliminarSeccion(this.Id);
                } while (respuesta.CódigoEstado != 0);
            }
        }

        private void btnEditarSeccion_Click(object sender, EventArgs e)
        {
            EditarSeccion editarSeccion = new EditarSeccion();
            editarSeccion.Show();
        }

        private void btnBuscarSeccion_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = BLSeccion.ListarSeccion(txtBusqueda.Text);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewSeccion.DataSource = respuesta.Contenido;
            this.FormatearDataGrid();
        }
    }
}