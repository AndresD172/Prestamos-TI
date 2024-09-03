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
    public partial class ModificarEquipo : Form
    {
        private int IdEquipo { get; set; }

        public ModificarEquipo(int idequipo)
        {
            InitializeComponent();
            this.IdEquipo = idequipo;
        }

        private void btnEditarEquipo_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacionEditar = new VerificacionEditar();
            verificacionEditar.Show();

            bool ejecutarAccion = verificacionEditar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadEquipo entidadEquipo = new EntidadEquipo { 
                IdEquipo = txtBuscarEquipo.TabIndex, 
                IdCategoría = txtBuscarCategoria.TabIndex,
                IdEstadoEquipo = txtEstadoEquipo.TabIndex,  
                Marca = txtMarca.Text, 
                Modelo = txtBuscarModelo.Text,
                NúmeroSerie = txSerieEquipo.Text,
                Descripción = txtDescripciónEquipo.Text
            };

            Respuesta respuesta;
            do
            {
                respuesta = BLEquipo.ActualizarEquipo(entidadEquipo);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }
    }
}
