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
    public partial class BuscarEquipo : Form
    {
        private int _id;

        public BuscarEquipo()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewEquipos.Columns[0].HeaderText = "Id";
            dataGridViewEquipos.Columns[1].HeaderText = "Categoría";
            dataGridViewEquipos.Columns[2].HeaderText = "Marca";
            dataGridViewEquipos.Columns[3].HeaderText = "Modelo";
            dataGridViewEquipos.Columns[4].HeaderText = "Número de serie";
            dataGridViewEquipos.Columns[5].HeaderText = "Descripción";
            dataGridViewEquipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SeleccionarItemActual()
        {
            string idSeleccionado = Convert.ToString(dataGridViewEquipos.CurrentRow.Cells["id"].Value);

            if (String.IsNullOrEmpty(idSeleccionado))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._id = Convert.ToInt32(idSeleccionado);
        }

        private void BuscarEquipo_Load(object sender, EventArgs e)
        {
            dataGridViewEquipos.DataSource = BLEquipo.ListarEquipo("%").Contenido;
            FormatearDataGrid();
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            VerificacionEliminacion verificacion = new VerificacionEliminacion();
            verificacion.ShowDialog();

            if (verificacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            SeleccionarItemActual();

            Respuesta respuesta = BLEquipo.EliminarEquipo(this._id);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewEquipos.DataSource = BLEquipo.ListarEquipo("%").Contenido;
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            SeleccionarItemActual();

            EditarEquipo ventanaEdicion = new EditarEquipo(this._id);
            ventanaEdicion.Show();

            dataGridViewEquipos.DataSource = BLEquipo.ListarEquipo("%").Contenido;
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

    }
}
