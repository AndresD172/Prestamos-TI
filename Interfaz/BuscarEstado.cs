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
    public partial class BuscarEstado : Form
    {
        private int _id;
        private string _nombre;
        private string _descripcion;

        public BuscarEstado()
        {
            InitializeComponent();
        }

        private void FormatearDataGrid()
        {
            dataGridViewEstado.Columns[0].HeaderText = "Id";
            dataGridViewEstado.Columns[1].HeaderText = "Nombre";
            dataGridViewEstado.Columns[2].HeaderText = "Descripcion";
        }

        private void btnEditarEstado_Click(object sender, EventArgs e)
        {
            EditarEstado editar = new EditarEstado();
            editar.ShowDialog();
        }

        private void btnAtrasLogo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
