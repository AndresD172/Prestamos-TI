namespace InterfazGráfica
{
    partial class BuscarPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPrestamos));
            btnBuscarPrestamo = new Button();
            txtBusqueda = new TextBox();
            dataGridViewPrestamo = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            btnEditarPrestamo = new Button();
            btnEliminarPrestamo = new Button();
            btnAtrasLogo = new Button();
            Usuario = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            txtNombreUsuario = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).BeginInit();
            SuspendLayout();
            // 
            // btnBuscarPrestamo
            // 
            btnBuscarPrestamo.BackColor = Color.FromArgb(255, 192, 255);
            btnBuscarPrestamo.ForeColor = Color.FromArgb(251, 246, 255);
            btnBuscarPrestamo.Location = new Point(1267, 129);
            btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            btnBuscarPrestamo.Size = new Size(71, 33);
            btnBuscarPrestamo.TabIndex = 60;
            btnBuscarPrestamo.UseVisualStyleBackColor = false;
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
            // dataGridViewPrestamo
            // 
            dataGridViewPrestamo.BackgroundColor = Color.FromArgb(246, 236, 255);
            dataGridViewPrestamo.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewPrestamo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrestamo.Location = new Point(350, 222);
            dataGridViewPrestamo.Name = "dataGridViewPrestamo";
            dataGridViewPrestamo.Size = new Size(998, 501);
            dataGridViewPrestamo.TabIndex = 58;
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
            // btnEditarPrestamo
            // 
            btnEditarPrestamo.BackColor = Color.FromArgb(251, 246, 255);
            btnEditarPrestamo.Image = (Image)resources.GetObject("btnEditarPrestamo.Image");
            btnEditarPrestamo.Location = new Point(12, 256);
            btnEditarPrestamo.Name = "btnEditarPrestamo";
            btnEditarPrestamo.Size = new Size(99, 90);
            btnEditarPrestamo.TabIndex = 55;
            btnEditarPrestamo.UseVisualStyleBackColor = false;
            btnEditarPrestamo.Click += btnEditarPrestamo_Click;
            // 
            // btnEliminarPrestamo
            // 
            btnEliminarPrestamo.BackColor = Color.FromArgb(251, 246, 255);
            btnEliminarPrestamo.ForeColor = Color.FromArgb(251, 246, 255);
            btnEliminarPrestamo.Image = (Image)resources.GetObject("btnEliminarPrestamo.Image");
            btnEliminarPrestamo.Location = new Point(12, 160);
            btnEliminarPrestamo.Name = "btnEliminarPrestamo";
            btnEliminarPrestamo.Size = new Size(99, 90);
            btnEliminarPrestamo.TabIndex = 54;
            btnEliminarPrestamo.UseVisualStyleBackColor = false;
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
            // 
            // BuscarPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(btnBuscarPrestamo);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridViewPrestamo);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnEditarPrestamo);
            Controls.Add(btnEliminarPrestamo);
            Controls.Add(btnAtrasLogo);
            Controls.Add(Usuario);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Name = "BuscarPrestamos";
            Text = "BuscarPrestamos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscarPrestamo;
        private TextBox txtBusqueda;
        private DataGridView dataGridViewPrestamo;
        private Label label2;
        private Label label4;
        private Button btnEditarPrestamo;
        private Button btnEliminarPrestamo;
        private Button btnAtrasLogo;
        private Label Usuario;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtNombreUsuario;
        private Label label3;
    }
}