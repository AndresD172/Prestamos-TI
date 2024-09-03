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
    public partial class BuscarCategoria : Form
    {
        private int Id { get; set; }
        private String Nombre { get; set; }

        public BuscarCategoria()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewCategoria.Columns[0].Width = 80;
            dataGridViewCategoria.Columns[0].HeaderText = "Id";
            dataGridViewCategoria.Columns[1].HeaderText = "Nombre";
        }

        private void BuscarCategoria_Load(object sender, EventArgs e)
        {
            dataGridViewCategoria.DataSource = BLCategoria.ListarCategoria("%").Contenido;
            this.FormatearDataGrid();
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["Id"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Id = Convert.ToInt16(dataGridViewCategoria.CurrentRow.Cells["id"].Value);
            this.Nombre = Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["nombre"].Value);
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            VerificarEliminar verificarEliminar = new VerificarEliminar();
            verificarEliminar.ShowDialog();

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
                respuesta = BLCategoria.EliminarCategoria(this.Id);

                dataGridViewCategoria.DataSource = BLCategoria.ListarCategoria("%").Contenido;

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            this.SeleccionarItemActual();
            EditarCategoria editarCategoria = new EditarCategoria(this.Id);
            editarCategoria.Show();
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            Respuesta respuesta = BLCategoria.ListarCategoria(txtBusqueda.Text);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewCategoria.DataSource = respuesta.Contenido;
            this.FormatearDataGrid();
        }
    }
}
