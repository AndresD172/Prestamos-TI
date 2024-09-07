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
    public partial class EditarTipoMulta : Form
    {
        private int _id;

        public EditarTipoMulta(int id)
        {
            InitializeComponent();
            this._id = id;
        }

        private void btnEditarTipoMulta_Click(object sender, EventArgs e)
        {
            VerificacionEditar ventanaConfirmacion = new VerificacionEditar();
            ventanaConfirmacion.ShowDialog();

            if (ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            EntidadTipoMulta entidadTipoMulta = new EntidadTipoMulta
            {
                IdTipoMulta = this._id,
                Nombre = txtDescripcionTipoMulta.Text
            };

            Respuesta respuesta = BLTipoMulta.ActualizarMulta(entidadTipoMulta);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
