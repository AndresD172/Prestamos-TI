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
    public partial class NuevoDepartamento : Form
    {
        public NuevoDepartamento()
        {
            InitializeComponent();
        }

        private void txtDescripciónMulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarDepartamento_Click(object sender, EventArgs e)
        {
            if (txtDescripcionDepartamento.Text == String.Empty)
            {
                MessageBox.Show("Ingrese todos los datos requeridos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EntidadDepartamento departamento = new EntidadDepartamento();
                Respuesta respuesta;
                //Asigna los datos que se ingresaron
                departamento.Nombre = txtDescripcionDepartamento.Text.Trim();

                respuesta = BLDepartamento.RegistrarDepartamento(departamento);

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
}
