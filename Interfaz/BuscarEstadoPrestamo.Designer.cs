namespace InterfazGráfica
{
    partial class BuscarEstadoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarEstadoPrestamo));
            txtBusqueda = new TextBox();
            dataGridViewEstado = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            btnEditarEstado = new Button();
            btnEliminarEstado = new Button();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label3 = new Label();
            Usuario = new Label();
            txtNombreUsuario = new TextBox();
            btnBuscarEstado = new Button();
            btnAtrasLogo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstado).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(229, 220, 252);
            txtBusqueda.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(350, 126);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(911, 35);
            txtBusqueda.TabIndex = 69;
            // 
            // dataGridViewEstado
            // 
            dataGridViewEstado.BackgroundColor = Color.FromArgb(246, 236, 255);
            dataGridViewEstado.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstado.Location = new Point(350, 222);
            dataGridViewEstado.Name = "dataGridViewEstado";
            dataGridViewEstado.Size = new Size(998, 501);
            dataGridViewEstado.TabIndex = 68;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label2.Location = new Point(133, 283);
            label2.Name = "label2";
            label2.Size = new Size(115, 43);
            label2.TabIndex = 67;
            label2.Text = "Editar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label4.Location = new Point(133, 186);
            label4.Name = "label4";
            label4.Size = new Size(155, 43);
            label4.TabIndex = 66;
            label4.Text = "Eliminar";
            // 
            // btnEditarEstado
            // 
            btnEditarEstado.BackColor = Color.FromArgb(251, 246, 255);
            btnEditarEstado.Image = (Image)resources.GetObject("btnEditarEstado.Image");
            btnEditarEstado.Location = new Point(12, 256);
            btnEditarEstado.Name = "btnEditarEstado";
            btnEditarEstado.Size = new Size(99, 90);
            btnEditarEstado.TabIndex = 65;
            btnEditarEstado.UseVisualStyleBackColor = false;
            // 
            // btnEliminarEstado
            // 
            btnEliminarEstado.BackColor = Color.FromArgb(251, 246, 255);
            btnEliminarEstado.ForeColor = Color.FromArgb(251, 246, 255);
            btnEliminarEstado.Image = (Image)resources.GetObject("btnEliminarEstado.Image");
            btnEliminarEstado.Location = new Point(12, 160);
            btnEliminarEstado.Name = "btnEliminarEstado";
            btnEliminarEstado.Size = new Size(99, 90);
            btnEliminarEstado.TabIndex = 64;
            btnEliminarEstado.UseVisualStyleBackColor = false;
            btnEliminarEstado.Click += btnEliminarEstado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label1.Location = new Point(117, 25);
            label1.Name = "label1";
            label1.Size = new Size(126, 43);
            label1.TabIndex = 62;
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
            panel2.TabIndex = 61;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-1, 85);
            panel1.Margin = new Padding(0);
            panel1.MinimumSize = new Size(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 10);
            panel1.TabIndex = 60;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(2, 6);
            label3.Name = "label3";
            label3.Size = new Size(141, 89);
            label3.TabIndex = 63;
            // 
            // Usuario
            // 
            Usuario.Image = (Image)resources.GetObject("Usuario.Image");
            Usuario.Location = new Point(1290, 39);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(50, 43);
            Usuario.TabIndex = 70;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(251, 246, 255);
            txtNombreUsuario.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(1086, 51);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(198, 31);
            txtNombreUsuario.TabIndex = 71;
            txtNombreUsuario.Text = "Nombre del usuario";
            txtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBuscarEstado
            // 
            btnBuscarEstado.BackColor = Color.FromArgb(255, 192, 255);
            btnBuscarEstado.ForeColor = Color.FromArgb(251, 246, 255);
            btnBuscarEstado.Location = new Point(1269, 129);
            btnBuscarEstado.Name = "btnBuscarEstado";
            btnBuscarEstado.Size = new Size(71, 33);
            btnBuscarEstado.TabIndex = 72;
            btnBuscarEstado.UseVisualStyleBackColor = false;
            btnBuscarEstado.Click += btnBuscarEstado_Click;
            // 
            // btnAtrasLogo
            // 
            btnAtrasLogo.BackColor = Color.FromArgb(239, 221, 254);
            btnAtrasLogo.Image = (Image)resources.GetObject("btnAtrasLogo.Image");
            btnAtrasLogo.Location = new Point(12, 649);
            btnAtrasLogo.Margin = new Padding(0);
            btnAtrasLogo.Name = "btnAtrasLogo";
            btnAtrasLogo.Size = new Size(137, 69);
            btnAtrasLogo.TabIndex = 73;
            btnAtrasLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtrasLogo.UseVisualStyleBackColor = false;
            // 
            // BuscarEstadoPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(btnAtrasLogo);
            Controls.Add(btnBuscarEstado);
            Controls.Add(Usuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridViewEstado);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnEditarEstado);
            Controls.Add(btnEliminarEstado);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Name = "BuscarEstadoPrestamo";
            Text = "BuscarEstadoPrestamo";
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private DataGridView dataGridViewEstado;
        private Label label2;
        private Label label4;
        private Button btnEditarEstado;
        private Button btnEliminarEstado;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Label Usuario;
        private TextBox txtNombreUsuario;
        private Button btnBuscarEstado;
        private Button btnAtrasLogo;
    }
}