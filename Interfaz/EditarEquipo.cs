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
    public partial class EditarEquipo : Form
    {
        private int _idCategoria;
        private int _id;

        public EditarEquipo(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void FormatoCategoria()
        {
            dataGridViewCategoria.Columns[0].Visible = false;
            dataGridViewCategoria.Columns[1].HeaderText = "Categoria";
            dataGridViewCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListadoCategoria(string cTexto)
        {
            Respuesta respuesta = BLCategoria.ListarCategoria(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewCategoria.DataSource = respuesta.Contenido;
            this.FormatoCategoria();
        }

        private void SeleccionarCategoria()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._idCategoria = Convert.ToInt32(dataGridViewCategoria.CurrentRow.Cells["id"].Value);
            txtCategoríaEquipo.Text = Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["nombre"].Value);
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacion = new VerificacionEditar();
            verificacion.ShowDialog();

            if (verificacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            EntidadEquipo entidadEquipo = new EntidadEquipo
            {
                IdEquipo = _id,
                IdCategoría = this._idCategoria,
                Marca = txtMarca.Text,
                Modelo = txtModeloEquipo.Text,
                NúmeroSerie = txSerieEquipo.Text,
                Descripción = txtDescripciónEquipo.Text,
            };

            Respuesta respuesta = BLEquipo.ActualizarEquipo(entidadEquipo);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.panelCategoria.Location = btnCategoria.Location;
            this.panelCategoria.Visible = true;
            this.ListadoCategoria("%");
        }

        private void dataGridViewCategoria_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarCategoria();
            panelCategoria.Visible = false;
        }
    }
}
