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
    public partial class Opciones : Form
    {
        private string opcion;

        public Opciones(string opcion)
        {
            InitializeComponent();
            this.opcion = opcion;

        }

        private void btnOpcionNuevo_Click(object sender, EventArgs e)
        {
 
        }

        private void btnOpcionBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            this.Close();
            if (opcion == "Usuario")
            {

                NuevoUsuario nuevoUsuarioOpcion = new NuevoUsuario();
                nuevoUsuarioOpcion.ShowDialog();

            }
            if (opcion == "Prestatario")
            {

                NuevoPrestatario nuevoPrestatarioOpcion = new NuevoPrestatario();
                nuevoPrestatarioOpcion.ShowDialog();

            }
            if (opcion == "Equipo")
            {

                NuevoEquipo nuevoEquipoOpcion = new NuevoEquipo();
                nuevoEquipoOpcion.ShowDialog();

            }

            if (opcion == "Prestamos")
            {
                //NuevoPrestamo nuevoPrestamoOpcion = new NuevoPrestamo();
                //nuevoPrestamoOpcion.ShowDialog();
            }
            if (opcion == "Multas")
            {
                //NuevaMulta nuevaMultaOpcion = new NuevaMulta();
                //nuevaMultaOpcion.ShowDialog();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (opcion == "Usuario")
            {
                BuscarUsuario BuscarUsuarioOpcion = new BuscarUsuario();
                BuscarUsuarioOpcion.ShowDialog();
            }
            if (opcion == "Prestatario")
            {
                BuscarPrestatarios BuscarPrestatarioOpcion = new BuscarPrestatarios();
                BuscarPrestatarioOpcion.ShowDialog();
            }
            if (opcion == "Equipo")
            {
                BuscarEquipo BuscarEquipoOpcion = new BuscarEquipo();
                BuscarEquipoOpcion.ShowDialog();
            }
            if (opcion == "Prestamos")
            {
                BuscarPrestamos BuscarPrestamoOpcion = new BuscarPrestamos();
                BuscarPrestamoOpcion.ShowDialog();
            }
            if (opcion == "Multas")
            {
                BuscarMultas BuscarMultaOpcion = new BuscarMultas();
                BuscarMultaOpcion.ShowDialog();
            }

        }

        private void btnOpcionBuscar_Click(object sender, EventArgs e)
        {
            /*if (opcion == "Usuario")
            {

                BuscarUsuario BuscarUsuarioOpcion = new BuscarUsuario();
                BuscarUsuarioOpcion.ShowDialog();

            }
            if (opcion == "Prestatario")
            {

                BuscarPrestatario BuscarPrestatarioOpcion = new BuscarPrestatario();
                BuscarPrestatarioOpcion.ShowDialog();

            }
            if (opcion == "Equipo")
            {

                BuscarEquipo BuscarEquipoOpcion = new BuscarEquipo();
                BuscarEquipoOpcion.ShowDialog();

            }
            if (opcion == "Prestamos")
            {

                BuscarPrestamo BuscarPrestamoOpcion = new BuscarPrestamo();
                BuscarPrestamoOpcion.ShowDialog();

            }
            if (opcion == "Multas")
            {

                BuscarMulta BuscarMultaOpcion = new BuscarMulta();
                BuscarMultaOpcion.ShowDialog();

            }*/

        }

    }
}
