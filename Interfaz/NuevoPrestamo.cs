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
    public partial class FormNuevoPréstamo : Form
    {
        public FormNuevoPréstamo()
        {
            InitializeComponent();
        }

        #region Variables
        int IdPrestatario = 0;
        int IdPrestamista = 0;
        int IdEstado = 0;
        #endregion

        #region Metodos
        //Metodos para el formato de los data grid view
        private void FormatoPrestatario()
        {
            dataGridViewPrestatario.Columns[0].Width = 215;
            dataGridViewPrestatario.Columns[0].HeaderText = "Prestatario";
            dataGridViewPrestatario.Columns[1].Visible = false;
        }

        private void FormatoPrestamista()
        {
            dataGridViewPrestamista.Columns[0].Width = 215;
            dataGridViewPrestamista.Columns[0].HeaderText = "Prestamista";
            dataGridViewPrestamista.Columns[1].Visible = false;
        }

        private void FormatoEstado()
        {
            dataGridViewEstado.Columns[0].Width = 215;
            dataGridViewEstado.Columns[0].HeaderText = "Estado";
            dataGridViewEstado.Columns[1].Visible = false;
        }

        //Metodos para cargar los listados en los data grid view 

        private void ListadoPrestatario(string cTexto)
        {
            try
            {
                dataGridViewPrestatario.DataSource = BLPrestatario.ListarPrestatario(cTexto);
                this.FormatoPrestatario();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLPrestatario.ListarPrestatario(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoPrestamista(string cTexto)
        {
            try
            {
                dataGridViewPrestamista.DataSource = BLTécnico.ListarTécnico(cTexto);
                this.FormatoPrestamista();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLTécnico.ListarTécnico(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListadoEstado(string cTexto)
        {
            try
            {
                dataGridViewEstado.DataSource = BLEstadoPrestamo.ListarEstadoPrestamo(cTexto);
                this.FormatoEstado();

            }
            catch (Exception ex)
            {
                Respuesta respuesta;
                respuesta = BLEstadoPrestamo.ListarEstadoPrestamo(cTexto);
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodos para seleccionar un dato

        private void SeleccionarPrestatario()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["IdPrestatario"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdPrestatario = Convert.ToInt32(dataGridViewPrestatario.CurrentRow.Cells["IdPrestatario"].Value);
                txtPrestatarioPréstamo.Text = Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["Nombre"].Value);

            }
        }

        private void SeleccionarPrestamista()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewPrestamista.CurrentRow.Cells["IdTecnico"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdPrestamista = Convert.ToInt32(dataGridViewPrestamista.CurrentRow.Cells["IdTecnico"].Value);
                txtPrestamistaPréstamo.Text = Convert.ToString(dataGridViewPrestamista.CurrentRow.Cells["Nombre"].Value);

            }
        }

        private void SeleccionarEstado()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewEstado.CurrentRow.Cells["IdEstadosPréstamo"].Value)))
            {

                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                this.IdEstado = Convert.ToInt32(dataGridViewEstado.CurrentRow.Cells["IdEstadosPréstamo"].Value);
                txtEstadoPréstamo.Text = Convert.ToString(dataGridViewEstado.CurrentRow.Cells["Nombre"].Value);

            }
        }
        #endregion

        //Cargar los listados
        private void NuevoPrestamo_Load(object sender, EventArgs e)
        {
            this.ListadoPrestatario("%");
            this.ListadoPrestamista("%");
            this.ListadoEstado("%");

        }
        //Botones para abrir los panel
        private void btnPrestatario_Click(object sender, EventArgs e)
        {
            this.panelPrestatario.Location = btnPrestatario.Location;
            this.panelPrestatario.Visible = true;
        }

        private void btnPrestamista_Click(object sender, EventArgs e)
        {
            this.panelPrestamista.Location = btnPrestamista.Location;
            this.panelPrestamista.Visible = true;
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            this.panelEstado.Location = btnEstado.Location;
            this.panelEstado.Visible = true;
        }

        //Botones para cerrar los panel
        private void btnCerrarPrestatario_Click(object sender, EventArgs e)
        {
            this.panelPrestatario.Visible = false;
        }

        private void btnCerrarPrestamista_Click(object sender, EventArgs e)
        {
            this.panelPrestamista.Visible = false;
        }

        private void btnCerrarEstado_Click(object sender, EventArgs e)
        {
            this.panelEstado.Visible = false;
        }

        //Botones para buscar en los data grid view
        private void btnBuscarPrestatario_Click(object sender, EventArgs e)
        {
            this.ListadoPrestatario(txtBuscarPrestatario.Text.Trim());
        }

        private void btnBuscarPrestamista_Click(object sender, EventArgs e)
        {
            this.ListadoPrestamista(txtBuscarPrestamista.Text.Trim());
        }

        private void btnBuscarEstado_Click(object sender, EventArgs e)
        {
            this.ListadoEstado(txtBuscarEstado.Text.Trim());
        }

        //Seleccionar un dato en el data grid
        private void dataGridViewPrestatario_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarPrestatario();
            panelPrestatario.Visible = false;
        }

        private void dataGridViewPrestamista_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarPrestamista();
            panelPrestamista.Visible = false;
        }

        private void dataGridViewEstado_DoubleClick(object sender, EventArgs e)
        {
            this.SeleccionarEstado();
            panelEstado.Visible = false;
        }

        //Guardar Prestamo
        private void btnNuevoPrestamo_Click(object sender, EventArgs e)
        {
            //Comprueba que todos los campos de datos hayan sido ingresados
            if (txEquipoPréstamo.Text == String.Empty || txtPrestatarioPréstamo.Text == String.Empty || txtFechaPréstamo.Text == String.Empty ||
            txtDevolucionPréstamo.Text == String.Empty || txtPrestamistaPréstamo.Text == String.Empty || txtEstadoPréstamo.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadPréstamo prestamo = new EntidadPréstamo();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron

                //Equipo¿?
                prestamo.FechaCreación = Convert.ToDateTime(txtFechaPréstamo);
                prestamo.FechaDevolución = Convert.ToDateTime(txtDevolucionPréstamo);
                prestamo.IdPrestatario = this.IdPrestatario;
                prestamo.IdTécnico = this.IdPrestamista;
                prestamo.IdEstadoCreación = this.IdEstado;

                respuesta = BLPrestamo.RegistrarPrestamo(prestamo);

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

        private void txEquipoPréstamo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
