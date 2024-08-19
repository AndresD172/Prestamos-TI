namespace InterfazGráfica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuarioLogo_Click(object sender, EventArgs e)
        {
            OpcionesTecnico formOpciones = new OpcionesTecnico();
            formOpciones.StartPosition = FormStartPosition.Manual;
            formOpciones.Left = 125;
            formOpciones.Top = 140;
            formOpciones.ShowDialog();

        }

        private void btnPrestatariosLogo_Click(object sender, EventArgs e)
        {

            //Opciones formOpciones = new Opciones("Prestatario");
            //formOpciones.StartPosition = FormStartPosition.Manual;
            //formOpciones.Left = 125;
            //formOpciones.Top = 230;
            //formOpciones.ShowDialog();

        }

        private void btnEquipoLogo_Click(object sender, EventArgs e)
        {

            //Opciones formOpciones = new Opciones("Equipo");
            //formOpciones.StartPosition = FormStartPosition.Manual;
            //formOpciones.Left = 125;
            //formOpciones.Top = 330;
            //formOpciones.ShowDialog();

        }

        private void btnPrestamosLogo_Click(object sender, EventArgs e)
        {

            //Opciones formOpciones = new Opciones("Prestamos");
            //formOpciones.StartPosition = FormStartPosition.Manual;
            //formOpciones.Left = 125;
            //formOpciones.Top = 422;
            //formOpciones.ShowDialog();

        }

        private void btnMultasLogo_Click(object sender, EventArgs e)
        {

            //Opciones formOpciones = new Opciones("Multas");
            //formOpciones.StartPosition = FormStartPosition.Manual;
            //formOpciones.Left = 125;
            //formOpciones.Top = 520;
            //formOpciones.ShowDialog();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
