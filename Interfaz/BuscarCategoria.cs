using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGráfica
{
    public partial class BuscarCategoria : Form
    {
        private int _id;
        private string _nombre;

        public BuscarCategoria()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewCategoria.Columns[0].HeaderText = "Id";
            dataGridViewCategoria.Columns[1].HeaderText = "Nombre";
            dataGridViewCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SeleccionarItemActual()
        {
            string idSeleccionado = Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["id"].Value);
            string nombreCategoria = Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["nombre"].Value);

            if (String.IsNullOrEmpty(idSeleccionado))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._id = Convert.ToInt16(idSeleccionado);
            this._nombre = nombreCategoria;
        }

        private void BuscarCategoria_Load(object sender, EventArgs e)
        {
            dataGridViewCategoria.DataSource = BLCategoria.ListarCategoria("%").Contenido;
            this.FormatearDataGrid();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            VerificacionEliminacion ventanaConfirmacion = new VerificacionEliminacion();
            ventanaConfirmacion.ShowDialog();

            if (ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            SeleccionarItemActual();

            Respuesta respuesta = BLCategoria.EliminarCategoria(this._id);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewCategoria.DataSource = BLCategoria.ListarCategoria("%").Contenido;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            SeleccionarItemActual();
            
            EditarCategoria ventanaEdicion = new EditarCategoria(this._id);
            ventanaEdicion.Show();

            dataGridViewCategoria.DataSource = BLCategoria.ListarCategoria("%").Contenido;
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
