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
    public partial class BuscarPrestamos : Form
    {
        private int _id;

        public BuscarPrestamos()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewPrestamo.Columns[0].HeaderText = "Id";
            dataGridViewPrestamo.Columns[1].HeaderText = "Nombre del prestatario";
            dataGridViewPrestamo.Columns[2].HeaderText = "Número de carné";
            dataGridViewPrestamo.Columns[3].HeaderText = "Nombre del prestamista";
            dataGridViewPrestamo.Columns[4].HeaderText = "Número de carné";
            dataGridViewPrestamo.Columns[5].HeaderText = "Id del equipo";
            dataGridViewPrestamo.Columns[6].HeaderText = "Marca";
            dataGridViewPrestamo.Columns[7].HeaderText = "Modelo";
            dataGridViewPrestamo.Columns[8].HeaderText = "Número de serie";
            dataGridViewPrestamo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewPrestamo.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._id = Convert.ToInt32(Convert.ToString(dataGridViewPrestamo.CurrentRow.Cells["id"].Value));
        }

        private void BuscarPrestamos_Load(object sender, EventArgs e)
        {
            Respuesta respuesta = BLPrestamo.ListarPrestamo("%");

            
            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewPrestamo.DataSource = respuesta.Contenido;
            FormatearDataGrid();
        }

        private void btnEliminarPrestamo_Click(object sender, EventArgs e)
        {
            VerificacionEliminacion verificacion = new VerificacionEliminacion();
            verificacion.ShowDialog();

            if (verificacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            SeleccionarItemActual();

            Respuesta respuesta = BLPrestamo.EliminarPrestamo(this._id);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewPrestamo.DataSource = respuesta.Contenido;
            FormatearDataGrid();
        }

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            SeleccionarItemActual();

            EditarPrestamo ventanaEdicion = new EditarPrestamo(this._id);
            ventanaEdicion.Show();

            dataGridViewPrestamo.DataSource = BLPrestamo.ListarPrestamo("%").Contenido;
            FormatearDataGrid();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

    }
}
