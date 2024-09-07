using Entidades;
using BL;

namespace InterfazGráfica
{
    public partial class NuevoTipoMulta : Form
    {
        public NuevoTipoMulta()
        {
            InitializeComponent();
        }

        private void btnGuardarTipoMulta_Click(object sender, EventArgs e)
        {
            EntidadTipoMulta nuevoTipoMulta = new EntidadTipoMulta
            {
                Nombre = txtDescripciónTipoMulta.Text
            };

            Respuesta respuesta = BLTipoMulta.RegistrarTipoMulta(nuevoTipoMulta);

            if (respuesta.CódigoEstado != 0)
            {
                MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
