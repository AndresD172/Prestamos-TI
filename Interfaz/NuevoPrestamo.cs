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
    public partial class NuevoPrestamo : Form
    {
        private int _idEquipo;
        private int _idPrestamista;
        private int _idPrestatario;
        private int _idEstado;

        public NuevoPrestamo()
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
            dataGridViewPrestatario.Columns[0].Visible = false;
            dataGridViewPrestatario.Columns[1].HeaderText = "Nombre";
            dataGridViewPrestatario.Columns[2].HeaderText = "Apellidos";
            dataGridViewPrestatario.Columns[3].Visible = false;
            dataGridViewPrestatario.Columns[4].Visible = false;
            dataGridViewPrestatario.Columns[5].Visible = false;
            dataGridViewPrestatario.Columns[6].Visible = false;
            dataGridViewPrestatario.Columns[7].Visible = false;
            dataGridViewPrestatario.Columns[8].Visible = false;
            dataGridViewPrestatario.Columns[9].Visible = false;
            dataGridViewPrestatario.Columns[10].Visible = false;
            dataGridViewPrestatario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListadoPrestatario(string cTexto)
        {
            Respuesta respuesta = BLPrestatario.ListarPrestatario(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewPrestatario.DataSource = respuesta.Contenido;
            this.FormatoPrestatario();
        }

        private void FormatoPrestamista()
        {
            dataGridViewPrestamista.Columns[0].Visible = false;
            dataGridViewPrestamista.Columns[1].HeaderText = "Nombre";
            dataGridViewPrestamista.Columns[2].HeaderText = "Apellidos";
            dataGridViewPrestamista.Columns[3].Visible = false;
            dataGridViewPrestamista.Columns[4].Visible = false;
            dataGridViewPrestamista.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListadoPrestamista(string cTexto)
        {
            Respuesta respuesta = BLTécnico.ListarTécnico(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewPrestamista.DataSource = respuesta.Contenido;
            this.FormatoPrestamista();
        }

        private void FormatoEstado()
        {
            dataGridViewEstado.Columns[0].Visible = false;
            dataGridViewEstado.Columns[1].HeaderText = "Estado";
            dataGridViewEstado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListadoEstado(string cTexto)
        {
            Respuesta respuesta = BLEstadoPrestamo.ListarEstadoPrestamo(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewEstado.DataSource = respuesta.Contenido;
            this.FormatoEstado();
        }



        //Metodos para seleccionar un dato
        private void SeleccionarPrestamista()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewPrestamista.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._idPrestamista = Convert.ToInt32(dataGridViewPrestamista.CurrentRow.Cells["id"].Value);
            txtPrestamistaPréstamo.Text = $"{Convert.ToString(dataGridViewPrestamista.CurrentRow.Cells["nombre"].Value)} + {Convert.ToString(dataGridViewPrestamista.CurrentRow.Cells["apellidos"].Value)}";
        }

        private void SeleccionarPrestatario()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["id_prestatario"].Value)))
            {
                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._idPrestatario = Convert.ToInt32(dataGridViewPrestatario.CurrentRow.Cells["id_prestatario"].Value);
            txtPrestatarioPréstamo.Text = $"{Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["nombre"].Value)} {Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["apellidos"].Value)}";
        }

        private void SeleccionarEstado()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewEstado.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._idEstado = Convert.ToInt32(dataGridViewEstado.CurrentRow.Cells["id"].Value);
            txtEstadoPréstamo.Text = Convert.ToString(dataGridViewEstado.CurrentRow.Cells["nombre"].Value);
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
            this.ListadoPrestatario("%");
        }

        private void btnPrestamista_Click(object sender, EventArgs e)
        {
            this.panelPrestamista.Location = btnPrestamista.Location;
            this.panelPrestamista.Visible = true;
            this.ListadoPrestamista("%");
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            this.panelEstado.Location = btnEstado.Location;
            this.panelEstado.Visible = true;
            this.ListadoEstado("%");
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
                prestamo.IdEquipo = Convert.ToInt32(txEquipoPréstamo.Text);
                prestamo.FechaCreación = Convert.ToDateTime(txtFechaPréstamo.Text);
                prestamo.FechaDevolución = Convert.ToDateTime(txtDevolucionPréstamo.Text);
                prestamo.IdPrestatario = this._idPrestatario;
                prestamo.IdTécnico = this._idPrestamista;
                prestamo.IdEstadoCreación = this._idEstado;

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void btnNuevoPrestamista_Click(object sender, EventArgs e)
        {
            NuevoUsuario user = new NuevoUsuario();
            user.Show();
        }

        private void btnNuevoEstado_Click(object sender, EventArgs e)
        {
            NuevoEstado estado = new NuevoEstado();
            estado.Show();
        }

        private void btnNuevoPrestatario_Click(object sender, EventArgs e)
        {
            NuevoPrestatario prestatario = new NuevoPrestatario();
            prestatario.Show();
        }
    }
}
