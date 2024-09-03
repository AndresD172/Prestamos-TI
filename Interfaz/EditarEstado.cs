﻿using BL;
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
    public partial class EditarEstado : Form

    {
        private int Id { get; set; }

        public EditarEstado(int id)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            VerificacionEditar verificacionEditar = new VerificacionEditar();
            verificacionEditar.Show();

            bool ejecutarAccion = verificacionEditar.Seleccion;

            if (!ejecutarAccion)
            {
                return;
            }

            EntidadEstadoEquipo entidadEstado = new EntidadEstadoEquipo { IdEstadoEquipo = Id, Nombre = txtDescripcionEstado.Text };

            Respuesta respuesta;
            do
            {
                respuesta = BLEstadoEquipo.ActualizarEstadoEquipo(entidadEstado);

                if (respuesta.CódigoEstado != 0)
                {
                    MessageBox.Show(respuesta.Contenido, "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (respuesta.CódigoEstado != 0);
        }
    }
}
