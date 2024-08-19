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
    public partial class NuevoEquipo : Form
    {
        public NuevoEquipo()
        {
            InitializeComponent();
        }

        #region Variables
        int IdEstado = 0;
        int IdCategoria = 0;

        #endregion

        #region Metodos
        //Metodos para el formato de los data grid view
        private void FormatoEstado()
        {
            dataGridViewEstadoEquipo.Columns[0].Width = 215;
            dataGridViewEstadoEquipo.Columns[0].HeaderText = "Estado";
            dataGridViewEstadoEquipo.Columns[1].Visible = false;
        }
        private void FormatoCategoria()
        {
            dataGridViewCategoria.Columns[0].Width = 215;
            dataGridViewCategoria.Columns[0].HeaderText = "Categoria";
            dataGridViewCategoria.Columns[1].Visible = false;
        }

        //Metodos para cargar los listados en los data grid view 

        private void ListadoEstado(string cTexto)
        {
            try
            {
                dataGridViewEstadoEquipo.DataSource = BLEstadoEquipo.ListarEstadoEquipo(cTexto);
                this.FormatoEstado();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLEstadoEquipo.ListarEstadoEquipo(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoCategoria(string cTexto)
        {
            try
            {
                dataGridViewCategoria.DataSource = BLCategoria.ListarCategoria(cTexto);
                this.FormatoCategoria();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLCategoria.ListarCategoria(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodos para seleccionar un dato

        private void SeleccionarEstado()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewEstadoEquipo.CurrentRow.Cells["IdEstadoEquipo"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdEstado = Convert.ToInt32(dataGridViewEstadoEquipo.CurrentRow.Cells["IdEstadoEquipo"].Value);
                txtEstadoEquipo.Text = Convert.ToString(dataGridViewEstadoEquipo.CurrentRow.Cells["Nombre"].Value);

            }
        }

        private void SeleccionarCategoria()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["IdCategoría"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdCategoria = Convert.ToInt32(dataGridViewCategoria.CurrentRow.Cells["IdCategoría"].Value);
                txtCategoríaEquipo.Text = Convert.ToString(dataGridViewCategoria.CurrentRow.Cells["Nombre"].Value);

            }
        }
        #endregion

        //Cargar los listados
        private void NuevoEquipo_Load(object sender, EventArgs e)
        {
            this.ListadoEstado("%");
            this.ListadoCategoria("%");

        }

        //Botones para abrir los panel
        private void btnEstadoEquipo_Click(object sender, EventArgs e)
        {
            this.panelEstadoEquipo.Location = btnEstadoEquipo.Location;
            this.panelEstadoEquipo.Visible = true;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            this.panelCategoria.Location = btnCategoria.Location;
            this.panelCategoria.Visible = true;
        }

        //Botones para cerrar los panel
        private void btnCerrarEstadoEquipo_Click(object sender, EventArgs e)
        {
            this.panelEstadoEquipo.Visible = false;
        }

        private void btnCerrarCategoria_Click(object sender, EventArgs e)
        {
            this.panelCategoria.Visible = false;
        }

        //Botones para buscar en los data grid view
        private void btnBuscarEstadoEquipo_Click(object sender, EventArgs e)
        {
            this.ListadoEstado(txtBuscarEstadoEquipo.Text.Trim());
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            this.ListadoCategoria(txtBuscarCategoria.Text.Trim());
        }

        //Seleccionar un dato en el data grid
        private void dataGridViewEstadoEquipo_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarEstado();
            panelEstadoEquipo.Visible = false;
        }

        private void dataGridViewCategoria_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarCategoria();
            panelCategoria.Visible = false;
        }

        //Guardar Equipo
        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos de datos hayan sido ingresados
            if (txSerieEquipo.Text == String.Empty || txtModeloEquipo.Text == String.Empty || txtEstadoEquipo.Text == String.Empty ||
            txtCategoríaEquipo.Text == String.Empty || txtDescripciónEquipo.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadEquipo equipo = new EntidadEquipo();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron
                //Marca¿?
                equipo.Modelo = txtModeloEquipo.Text.Trim();
                equipo.NúmeroSerie = txSerieEquipo.Text.Trim();
                equipo.Descripción = txtDescripciónEquipo.Text.Trim();
                equipo.IdEstadoEquipo = this.IdEstado;
                equipo.IdCategoría = this.IdCategoria;


                respuesta = BLEquipo.RegistrarEquipo(equipo);

                //Detección de errores
                if (respuesta.CódigoEstado == 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
