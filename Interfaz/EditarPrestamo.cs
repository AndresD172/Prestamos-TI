using BL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGráfica
{
    public partial class EditarPrestamo : Form
    {
        private int _id;
        private int _idEquipo;
        private int _idPrestamista;
        private int _idPrestatario;
        private int _idEstado;

        public EditarPrestamo(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void FormatoEquipo()
        {
            dataGridViewEquipo.Columns[0].Visible = false;
            dataGridViewEquipo.Columns[1].Visible = false;
            dataGridViewEquipo.Columns[2].Visible = false;
            dataGridViewEquipo.Columns[3].HeaderText = "Modelo";
            dataGridViewEquipo.Columns[4].Visible = false;
            dataGridViewEquipo.Columns[5].Visible = false;
            dataGridViewEquipo.Columns[6].Visible = false;
            dataGridViewEquipo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListadoEquipo(string cTexto)
        {
            Respuesta respuesta = BLEquipo.ListarEquipo(cTexto);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dataGridViewEquipo.DataSource = respuesta.Contenido;
            this.FormatoEquipo();
        }

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

        private void SeleccionarEquipo()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewEquipo.CurrentRow.Cells["id_equipo"].Value)))
            {
                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._idEquipo = Convert.ToInt32(dataGridViewEquipo.CurrentRow.Cells["id_equipo"].Value);
            txEquipoPréstamo.Text = Convert.ToString(dataGridViewEquipo.CurrentRow.Cells["modelo"].Value);
        }

        private void SeleccionarPrestamista()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewPrestamista.CurrentRow.Cells["id"].Value)))
            {
                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._idPrestamista = Convert.ToInt32(dataGridViewPrestamista.CurrentRow.Cells["id"].Value);
            txtContraseñaUsuario.Text = $"{Convert.ToString(dataGridViewPrestamista.CurrentRow.Cells["nombre"].Value)}";
        }

        private void SeleccionarPrestatario()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["id_prestatario"].Value)))
            {
                MessageBox.Show("No hay datos para mostrar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this._idPrestatario = Convert.ToInt32(dataGridViewPrestatario.CurrentRow.Cells["id_prestatario"].Value);
            txtPrestatarioPréstamo.Text = $"{Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["nombre"].Value)} + {Convert.ToString(dataGridViewPrestatario.CurrentRow.Cells["apellidos"].Value)}";
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

        private void btnEditarPrestamo_Click(object sender, EventArgs e)
        {
            DateTime fechaPrestamo = SqlDateTime.MinValue.Value;
            DateTime fechaEntrega = SqlDateTime.MinValue.Value;

            VerificacionEditar verificacion = new VerificacionEditar();
            verificacion.ShowDialog();

            if (verificacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (this.txtFechaPréstamo.Text != "")
            {
                try
                {
                    fechaPrestamo = Convert.ToDateTime(txtFechaPréstamo.Text);
                }
                catch (Exception)
                {
                    fechaPrestamo = SqlDateTime.MinValue.Value;
                }
            }

            if (this.txtDevolucionPréstamo.Text != "")
            {
                try
                {
                    fechaEntrega = Convert.ToDateTime(txtDevolucionPréstamo.Text);
                }
                catch (Exception)
                {
                    fechaEntrega = SqlDateTime.MinValue.Value;
                }
            }

            EntidadPréstamo entidadPrestamo = new EntidadPréstamo
            {
                IdPréstamo = this._id,
                IdPrestatario = this._idPrestatario,
                IdTécnico = this._idPrestamista,
                IdEstadoCreación = this._idEstado,
                FechaCreación = fechaPrestamo,
                FechaDevolución = fechaEntrega,
                IdEquipo = this._idEquipo,
            };

            Respuesta respuesta = BLPrestamo.ActualizarPrestamo(entidadPrestamo);

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

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            this.panelEquipo.Location = btnEquipo.Location;
            this.panelEquipo.Visible = true;
            this.ListadoEquipo("%");
        }

        private void btnPrestatario_Click(object sender, EventArgs e)
        {
            this.panelPrestatario.Location = btnEquipo.Location;
            this.panelPrestatario.Visible = true;
            this.ListadoPrestatario("%");

        }

        private void btnPrestamista_Click(object sender, EventArgs e)
        {
            this.panelPrestamista.Location = btnEquipo.Location;
            this.panelPrestamista.Visible = true;
            this.ListadoPrestamista("%");
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            this.panelEstado.Location = btnEquipo.Location;
            this.panelEstado.Visible = true;
            this.ListadoEstado("%");
        }

        private void dataGridViewEquipo_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarEquipo();
            panelEquipo.Visible = false;
        }

        private void dataGridViewPrestatario_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarPrestatario();
            panelPrestatario.Visible = false;
        }

        private void dataGridViewPrestamista_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarPrestamista();
            panelPrestamista.Visible = false;
        }

        private void dataGridViewEstado_DoubleClick(object sender, EventArgs e)
        {
            SeleccionarEstado();
            panelEstado.Visible = false;
        }
    }
}
