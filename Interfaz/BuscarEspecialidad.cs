using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entidades;

namespace InterfazGráfica
{
    public partial class BuscarEspecialidad : Form
    {

        private int Id {  get; set; }
        private String Nombre { get; set; }

        public BuscarEspecialidad()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewEspecialidad.Columns[0].HeaderText = "Id";
            dataGridViewEspecialidad.Columns[1].HeaderText = "Nombre";
        }

        private void BuscarCategoria_Load(object sender, EventArgs e)
        {
            this.FormatearDataGrid();
            dataGridViewEspecialidad.DataSource = BLEspecialidad.ListarEspecialidad("%");
        }


        private void SeleccionarItemActual()
        {
            if (String.IsNullOrEmpty(Convert.ToString(dataGridViewEspecialidad.CurrentRow.Cells["Id"].Value)))
            {
                MessageBox.Show("No hay datos por seleccionar", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Id = Convert.ToInt16(dataGridViewEspecialidad.CurrentRow.Cells["id"].Value);
            this.Nombre = Convert.ToString(dataGridViewEspecialidad.CurrentRow.Cells["nombre"].Value);
        }


        
        private void btnEditarEspecialidad_Click(object sender, EventArgs e)
        {
            this.SeleccionarItemActual();
            EditarEspecialidad editarEspecialidad = new EditarEspecialidad(/*this.Id*/);
            editarEspecialidad.Show();
        }

        private void btnBuscarEspecialidad_Click(Object sender, EventArgs e)
        {
            Respuesta respuesta = BLEspecialidad.ListarEspecialidad(txtBusqueda.Text);
            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridViewEspecialidad.DataSource = respuesta.Contenido;
            this.FormatearDataGrid();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        //private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        //{
        //    VerificarEliminar verificarEliminar = new VerificarEliminar();
        //    verificarEliminar.Show();

        //    bool eliminarDato = verificarEliminar.Seleccion;

        //    verificarEliminar.Close();

        //    if (!eliminarDato)
        //    {
        //        return;
        //    }

        //    SeleccionarItemActual();

        //    Respuesta respuesta;
        //    do
        //    {
        //        respuesta = BLEspecialidad.EliminarEspecialidad(this.Id);

        //        if (respuesta.CódigoEstado != 0)
        //        {
        //            MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    } while (respuesta.CódigoEstado != 0);
        //}
    }
}
