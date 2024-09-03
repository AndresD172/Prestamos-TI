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
    public partial class BuscarDepartamento : Form
    {
        private int IdDepartamento { get; set; }
        private String Nombre { get; set; }

        public BuscarDepartamento()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewDepartamento.Columns[0].HeaderText = "Id";
            dataGridViewDepartamento.Columns[1].HeaderText = "Nombre";
        }

        private void BuscarDepartamento_Load(object sender, EventArgs e)
        {
            this.FormatearDataGrid();
            dataGridViewDepartamento.DataSource = BLDepartamento.ListarDepartamento("%");
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewDepartamento.CurrentRow.Cells["Id"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.IdDepartamento = Convert.ToInt16(dataGridViewDepartamento.CurrentRow.Cells["id"].Value);
            this.Nombre = Convert.ToString(dataGridViewDepartamento.CurrentRow.Cells["nombre"].Value);
        }

        private void btnEditarDepartamento_Click(object sender, EventArgs e)
        {
            EditarDepartamento editar = new EditarDepartamento();
            editar.ShowDialog();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminarDepartamento_Click(object sender, EventArgs e)
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
                respuesta = BLDepartamento.EliminarDepartamento(this.IdDepartamento);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);

        }
    }
}
