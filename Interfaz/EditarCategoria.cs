using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using BL;


namespace InterfazGráfica
{
    public partial class EditarCategoria : Form
    {
        private int _id;

        public EditarCategoria(int id)
        {
            InitializeComponent();
            _id = id;
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            VerificacionEditar ventanaConfirmacion = new VerificacionEditar();
            ventanaConfirmacion.ShowDialog();

            if(ventanaConfirmacion.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            EntidadCategoría entidadCategoría = new EntidadCategoría
            {
                IdCategoría = _id,
                Nombre = txtDescripcionCategoria.Text
            };

            Respuesta respuesta = BLCategoria.ActualizarCategoria(entidadCategoría);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
        }
    }
}
