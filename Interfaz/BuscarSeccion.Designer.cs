
namespace InterfazGráfica
{
    partial class BuscarSeccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarSeccion));
            btnBuscarSeccion = new Button();
            txtBusqueda = new TextBox();
            dataGridViewSeccion = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            btnEditarSeccion = new Button();
            btnEliminarSeccion = new Button();
            btnAtrasLogo = new Button();
            Usuario = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            txtNombreUsuario = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeccion).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarSeccion
            // 
            btnBuscarSeccion.BackColor = Color.FromArgb(255, 192, 255);
            btnBuscarSeccion.ForeColor = Color.FromArgb(251, 246, 255);
            btnBuscarSeccion.Location = new Point(1267, 129);
            btnBuscarSeccion.Name = "btnBuscarSeccion";
            btnBuscarSeccion.Size = new Size(71, 33);
            btnBuscarSeccion.TabIndex = 60;
            btnBuscarSeccion.UseVisualStyleBackColor = false;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(229, 220, 252);
            txtBusqueda.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(350, 126);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(911, 35);
            txtBusqueda.TabIndex = 59;
            // 
            // dataGridViewSeccion
            // 
            dataGridViewSeccion.BackgroundColor = Color.FromArgb(246, 236, 255);
            dataGridViewSeccion.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewSeccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSeccion.Location = new Point(350, 222);
            dataGridViewSeccion.Name = "dataGridViewSeccion";
            dataGridViewSeccion.Size = new Size(998, 501);
            dataGridViewSeccion.TabIndex = 58;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label2.Location = new Point(133, 283);
            label2.Name = "label2";
            label2.Size = new Size(115, 43);
            label2.TabIndex = 57;
            label2.Text = "Editar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label4.Location = new Point(133, 186);
            label4.Name = "label4";
            label4.Size = new Size(155, 43);
            label4.TabIndex = 56;
            label4.Text = "Eliminar";
            // 
            // btnEditarSeccion
            // 
            btnEditarSeccion.BackColor = Color.FromArgb(251, 246, 255);
            btnEditarSeccion.Image = (Image)resources.GetObject("btnEditarSeccion.Image");
            btnEditarSeccion.Location = new Point(12, 256);
            btnEditarSeccion.Name = "btnEditarSeccion";
            btnEditarSeccion.Size = new Size(99, 90);
            btnEditarSeccion.TabIndex = 55;
            btnEditarSeccion.UseVisualStyleBackColor = false;
            btnEditarSeccion.Click += btnEditarSeccion_Click;
            // 
            // btnEliminarSeccion
            // 
            btnEliminarSeccion.BackColor = Color.FromArgb(251, 246, 255);
            btnEliminarSeccion.ForeColor = Color.FromArgb(251, 246, 255);
            btnEliminarSeccion.Image = (Image)resources.GetObject("btnEliminarSeccion.Image");
            btnEliminarSeccion.Location = new Point(12, 160);
            btnEliminarSeccion.Name = "btnEliminarSeccion";
            btnEliminarSeccion.Size = new Size(99, 90);
            btnEliminarSeccion.TabIndex = 54;
            btnEliminarSeccion.UseVisualStyleBackColor = false;
            // 
            // btnAtrasLogo
            // 
            btnAtrasLogo.BackColor = Color.FromArgb(239, 221, 254);
            btnAtrasLogo.Image = (Image)resources.GetObject("btnAtrasLogo.Image");
            btnAtrasLogo.Location = new Point(9, 654);
            btnAtrasLogo.Margin = new Padding(0);
            btnAtrasLogo.Name = "btnAtrasLogo";
            btnAtrasLogo.Size = new Size(137, 69);
            btnAtrasLogo.TabIndex = 52;
            btnAtrasLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtrasLogo.UseVisualStyleBackColor = false;
            btnAtrasLogo.Click += btnAtrasLogo_Click;
            // 
            // Usuario
            // 
            Usuario.Image = (Image)resources.GetObject("Usuario.Image");
            Usuario.Location = new Point(1288, 24);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(50, 43);
            Usuario.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label1.Location = new Point(117, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 43);
            label1.TabIndex = 49;
            label1.Text = "Buscar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(337, 95);
            panel2.Margin = new Padding(0);
            panel2.MinimumSize = new Size(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 623);
            panel2.TabIndex = 48;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-1, 85);
            panel1.Margin = new Padding(0);
            panel1.MinimumSize = new Size(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 10);
            panel1.TabIndex = 47;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(251, 246, 255);
            txtNombreUsuario.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(1084, 36);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(198, 31);
            txtNombreUsuario.TabIndex = 51;
            txtNombreUsuario.Text = "Nombre del usuario";
            txtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(2, 6);
            label3.Name = "label3";
            label3.Size = new Size(141, 89);
            label3.TabIndex = 53;
            label3.Click += label3_Click;
            // 
            // BuscarSeccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(btnBuscarSeccion);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridViewSeccion);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnEditarSeccion);
            Controls.Add(btnEliminarSeccion);
            Controls.Add(btnAtrasLogo);
            Controls.Add(Usuario);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Name = "BuscarSeccion";
            Text = "BuscarSeccion";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSeccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnBuscarSeccion;
        private TextBox txtBusqueda;
        private DataGridView dataGridViewSeccion;
        private Label label2;
        private Label label4;
        private Button btnEditarSeccion;
        private Button btnEliminarSeccion;
        private Button btnAtrasLogo;
        private Label Usuario;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtNombreUsuario;
        private Label label3;
    }
}