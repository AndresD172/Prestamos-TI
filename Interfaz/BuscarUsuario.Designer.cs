namespace InterfazGráfica
{
    partial class BuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarUsuario));
            txtNombreUsuario = new TextBox();
            Usuario = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            btnAtrasLogo = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnEditarUsuario = new Button();
            btnEliminarUsuario = new Button();
            dataGridViewUsuarios = new DataGridView();
            txtBusqueda = new TextBox();
            btnBuscarUsuario = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(251, 246, 255);
            txtNombreUsuario.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(1239, 44);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(226, 37);
            txtNombreUsuario.TabIndex = 22;
            txtNombreUsuario.Text = "Nombre del usuario";
            txtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // Usuario
            // 
            Usuario.Image = (Image)resources.GetObject("Usuario.Image");
            Usuario.Location = new Point(1472, 28);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(57, 57);
            Usuario.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            label1.Location = new Point(134, 29);
            label1.Name = "label1";
            label1.Size = new Size(176, 54);
            label1.TabIndex = 20;
            label1.Text = "Buscar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(385, 123);
            panel2.Margin = new Padding(0);
            panel2.MinimumSize = new Size(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 831);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-1, 109);
            panel1.Margin = new Padding(0);
            panel1.MinimumSize = new Size(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1545, 13);
            panel1.TabIndex = 17;
            // 
            // btnAtrasLogo
            // 
            btnAtrasLogo.BackColor = Color.FromArgb(239, 221, 254);
            btnAtrasLogo.Image = (Image)resources.GetObject("btnAtrasLogo.Image");
            btnAtrasLogo.Location = new Point(10, 868);
            btnAtrasLogo.Margin = new Padding(0);
            btnAtrasLogo.Name = "btnAtrasLogo";
            btnAtrasLogo.Size = new Size(157, 92);
            btnAtrasLogo.TabIndex = 23;
            btnAtrasLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtrasLogo.UseVisualStyleBackColor = false;
            btnAtrasLogo.Click += btnAtrasLogo_Click;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(2, 4);
            label3.Name = "label3";
            label3.Size = new Size(161, 119);
            label3.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            label2.Location = new Point(152, 373);
            label2.Name = "label2";
            label2.Size = new Size(151, 54);
            label2.TabIndex = 29;
            label2.Text = "Editar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold);
            label4.Location = new Point(152, 244);
            label4.Name = "label4";
            label4.Size = new Size(199, 54);
            label4.TabIndex = 28;
            label4.Text = "Eliminar";
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.BackColor = Color.FromArgb(251, 246, 255);
            btnEditarUsuario.Image = (Image)resources.GetObject("btnEditarUsuario.Image");
            btnEditarUsuario.Location = new Point(14, 337);
            btnEditarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(113, 120);
            btnEditarUsuario.TabIndex = 27;
            btnEditarUsuario.UseVisualStyleBackColor = false;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnEliminarUsuario
            // 
            btnEliminarUsuario.BackColor = Color.FromArgb(251, 246, 255);
            btnEliminarUsuario.ForeColor = Color.FromArgb(251, 246, 255);
            btnEliminarUsuario.Image = (Image)resources.GetObject("btnEliminarUsuario.Image");
            btnEliminarUsuario.Location = new Point(14, 209);
            btnEliminarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnEliminarUsuario.Name = "btnEliminarUsuario";
            btnEliminarUsuario.Size = new Size(113, 120);
            btnEliminarUsuario.TabIndex = 26;
            btnEliminarUsuario.UseVisualStyleBackColor = false;
            btnEliminarUsuario.Click += btnEliminarUsuario_Click;
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.BackgroundColor = Color.FromArgb(246, 236, 255);
            dataGridViewUsuarios.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(400, 292);
            dataGridViewUsuarios.Margin = new Padding(3, 4, 3, 4);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.RowHeadersWidth = 51;
            dataGridViewUsuarios.Size = new Size(1141, 668);
            dataGridViewUsuarios.TabIndex = 30;
            // 
            // txtBusqueda
            // 
            txtBusqueda.BackColor = Color.FromArgb(229, 220, 252);
            txtBusqueda.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(400, 164);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(1041, 41);
            txtBusqueda.TabIndex = 31;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.FromArgb(255, 192, 255);
            btnBuscarUsuario.ForeColor = Color.FromArgb(251, 246, 255);
            btnBuscarUsuario.Location = new Point(1448, 168);
            btnBuscarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(81, 44);
            btnBuscarUsuario.TabIndex = 46;
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // BuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1543, 972);
            Controls.Add(btnBuscarUsuario);
            Controls.Add(txtBusqueda);
            Controls.Add(dataGridViewUsuarios);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnEditarUsuario);
            Controls.Add(btnEliminarUsuario);
            Controls.Add(btnAtrasLogo);
            Controls.Add(Usuario);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuscarUsuario";
            Text = "Buscar Usuario";
            Load += BuscarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreUsuario;
        private Label Usuario;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button btnAtrasLogo;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnEditarUsuario;
        private Button btnEliminarUsuario;
        private DataGridView dataGridViewUsuarios;
        private TextBox txtBusqueda;
        private Button btnBuscarUsuario;
    }
}