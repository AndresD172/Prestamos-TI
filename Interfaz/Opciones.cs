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

        Home home = new Home();
        private Home homeWindow;
        private string opcion;

        public Opciones(string opcion)
        {
            InitializeComponent();
            this.homeWindow = home;
            this.opcion = opcion;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            homeWindow.Close();
            homeWindow.Hide();
            this.Close();
            

            switch (opcion)
            {
                case "Usuario":
                    NuevoUsuario nuevoUsuarioOpcion = new NuevoUsuario();
                    nuevoUsuarioOpcion.Show();
                    break;

                case "Prestatario":
                    NuevoPrestatario nuevoPrestatarioOpcion = new NuevoPrestatario();
                    nuevoPrestatarioOpcion.Show();
                    break;

                case "Equipo":
                    NuevoEquipo nuevoEquipoOpcion = new NuevoEquipo();
                    nuevoEquipoOpcion.Show();
                    break;

                case "Prestamos":
                    NuevoPrestamo nuevoPrestamoOpcion = new NuevoPrestamo();
                    nuevoPrestamoOpcion.Show();
                    break;

                case "Multas":
                    NuevaMulta nuevaMulta = new NuevaMulta();
                    nuevaMulta.Show();
                    break;

                case "TipoMulta":
                    NuevoTipoMulta nuevoTipoMulta = new NuevoTipoMulta();
                    nuevoTipoMulta.Show();
                    break;

                case "Categoria":
                    NuevaCategoria nuevaCategoria = new NuevaCategoria();
                    nuevaCategoria.Show();
                    break;

                case "Especialidad":
                    NuevaEspecialidad nuevaEspecialidad = new NuevaEspecialidad();
                    nuevaEspecialidad.Show();
                    break;

                case "Estado":
                    NuevoEstado nuevoEstado = new NuevoEstado();
                    nuevoEstado.Show();
                    break;

                case "Seccion":
                    NuevaSeccion nuevaSeccion = new NuevaSeccion();
                    nuevaSeccion.Show();
                    break;

                case "Departamento":
                    NuevoDepartamento nuevoDepartamento = new NuevoDepartamento();
                    nuevoDepartamento.Show();
                    break;

                default:
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Close();
            switch (opcion)
            {
                case "Usuario":
                    BuscarUsuario buscarUsuario = new BuscarUsuario();
                    buscarUsuario.Show();
                    break;

                case "Prestatario":
                    BuscarPrestatarios buscarPrestatarios = new BuscarPrestatarios();
                    buscarPrestatarios.Show();
                    break;

                case "Equipo":
                    BuscarEquipo buscarEquipo = new BuscarEquipo();
                    buscarEquipo.Show();
                    break;

                case "Prestamos":
                    BuscarPrestamos buscarPrestamo = new BuscarPrestamos();
                    buscarPrestamo.Show();
                    break;

                case "Multas":
                    BuscarMultas buscarMulta = new BuscarMultas();
                    buscarMulta.Show();
                    break;

                case "TipoMulta":
                    BuscarTipoMulta buscarTipoMulta = new BuscarTipoMulta();
                    buscarTipoMulta.Show();
                    break;

                case "Categoria":
                    BuscarCategoria buscarCategoria = new BuscarCategoria();
                    buscarCategoria.Show();
                    break;

                case "Especialidad":
                    BuscarEspecialidad buscarEspecialidad = new BuscarEspecialidad();
                    buscarEspecialidad.Show();
                    break;

                case "Estado":
                    BuscarEstado buscarEstado = new BuscarEstado();
                    buscarEstado.Show();
                    break;

                case "Seccion":
                    BuscarSeccion buscarSeccion = new BuscarSeccion();
                    buscarSeccion.Show();
                    break;

                case "Departamento":
                    BuscarDepartamento buscarDepartamento = new BuscarDepartamento();
                    buscarDepartamento.Show();
                    break;

                default:
                    break;
            }
        }
    }
}
