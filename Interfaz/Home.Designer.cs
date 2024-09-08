namespace InterfazGráfica
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btnHome = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnUsuarioLogo = new Button();
            btnPrestatariosLogo = new Button();
            btnPrestamosLogo = new Button();
            btnEquipoLogo = new Button();
            btnAtrasLogo = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Usuario = new Label();
            txtNombreUsuario = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(251, 246, 255);
            btnHome.ForeColor = Color.FromArgb(251, 246, 255);
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.Location = new Point(12, 12);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(99, 88);
            btnHome.TabIndex = 0;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-1, 106);
            panel1.Margin = new Padding(0);
            panel1.MinimumSize = new Size(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 10);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(374, 114);
            panel2.Margin = new Padding(0);
            panel2.MinimumSize = new Size(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 623);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // btnUsuarioLogo
            // 
            btnUsuarioLogo.BackColor = Color.FromArgb(251, 246, 255);
            btnUsuarioLogo.ForeColor = Color.FromArgb(251, 246, 255);
            btnUsuarioLogo.Image = (Image)resources.GetObject("btnUsuarioLogo.Image");
            btnUsuarioLogo.Location = new Point(12, 146);
            btnUsuarioLogo.Name = "btnUsuarioLogo";
            btnUsuarioLogo.Size = new Size(99, 90);
            btnUsuarioLogo.TabIndex = 3;
            btnUsuarioLogo.UseVisualStyleBackColor = false;
            btnUsuarioLogo.Click += btnUsuarioLogo_Click;
            // 
            // btnPrestatariosLogo
            // 
            btnPrestatariosLogo.BackColor = Color.FromArgb(251, 246, 255);
            btnPrestatariosLogo.Image = (Image)resources.GetObject("btnPrestatariosLogo.Image");
            btnPrestatariosLogo.Location = new Point(12, 242);
            btnPrestatariosLogo.Name = "btnPrestatariosLogo";
            btnPrestatariosLogo.Size = new Size(99, 90);
            btnPrestatariosLogo.TabIndex = 4;
            btnPrestatariosLogo.UseVisualStyleBackColor = false;
            btnPrestatariosLogo.Click += btnPrestatariosLogo_Click;
            // 
            // btnPrestamosLogo
            // 
            btnPrestamosLogo.BackColor = Color.FromArgb(251, 246, 255);
            btnPrestamosLogo.Image = (Image)resources.GetObject("btnPrestamosLogo.Image");
            btnPrestamosLogo.Location = new Point(12, 434);
            btnPrestamosLogo.Name = "btnPrestamosLogo";
            btnPrestamosLogo.Size = new Size(99, 90);
            btnPrestamosLogo.TabIndex = 6;
            btnPrestamosLogo.UseVisualStyleBackColor = false;
            btnPrestamosLogo.Click += btnPrestamosLogo_Click;
            // 
            // btnEquipoLogo
            // 
            btnEquipoLogo.BackColor = Color.FromArgb(251, 246, 255);
            btnEquipoLogo.Image = (Image)resources.GetObject("btnEquipoLogo.Image");
            btnEquipoLogo.Location = new Point(12, 338);
            btnEquipoLogo.Name = "btnEquipoLogo";
            btnEquipoLogo.Size = new Size(99, 90);
            btnEquipoLogo.TabIndex = 5;
            btnEquipoLogo.UseVisualStyleBackColor = false;
            btnEquipoLogo.Click += btnEquipoLogo_Click;
            // 
            // btnAtrasLogo
            // 
            btnAtrasLogo.BackColor = Color.FromArgb(239, 221, 254);
            btnAtrasLogo.Image = (Image)resources.GetObject("btnAtrasLogo.Image");
            btnAtrasLogo.Location = new Point(12, 655);
            btnAtrasLogo.Margin = new Padding(0);
            btnAtrasLogo.Name = "btnAtrasLogo";
            btnAtrasLogo.Size = new Size(120, 65);
            btnAtrasLogo.TabIndex = 8;
            btnAtrasLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtrasLogo.UseVisualStyleBackColor = false;
            btnAtrasLogo.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium Cond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 30);
            label1.Name = "label1";
            label1.Size = new Size(130, 61);
            label1.TabIndex = 9;
            label1.Text = "Home";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 174);
            label2.Name = "label2";
            label2.Size = new Size(138, 43);
            label2.TabIndex = 10;
            label2.Text = "Usuarios";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 266);
            label3.Name = "label3";
            label3.Size = new Size(182, 43);
            label3.TabIndex = 11;
            label3.Text = "Prestatarios";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 364);
            label4.Name = "label4";
            label4.Size = new Size(129, 43);
            label4.TabIndex = 12;
            label4.Text = "Equipos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(133, 458);
            label5.Name = "label5";
            label5.Size = new Size(163, 43);
            label5.TabIndex = 13;
            label5.Text = "Prestamos";
            // 
            // Usuario
            // 
            Usuario.Image = (Image)resources.GetObject("Usuario.Image");
            Usuario.Location = new Point(647, 184);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(574, 383);
            Usuario.TabIndex = 15;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(251, 246, 255);
            txtNombreUsuario.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(732, 530);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(413, 31);
            txtNombreUsuario.TabIndex = 16;
            txtNombreUsuario.Text = "Nombre del usuario";
            txtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label7.Location = new Point(144, 668);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(90, 43);
            label7.TabIndex = 17;
            label7.Text = "Salir";
            label7.Click += label7_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(label7);
            Controls.Add(txtNombreUsuario);
            Controls.Add(Usuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAtrasLogo);
            Controls.Add(btnPrestamosLogo);
            Controls.Add(btnEquipoLogo);
            Controls.Add(btnPrestatariosLogo);
            Controls.Add(btnUsuarioLogo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnHome);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "FormHome";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHome;
        private Panel panel1;
        private Panel panel2;
        private Button btnUsuarioLogo;
        private Button btnPrestatariosLogo;
        private Button btnPrestamosLogo;
        private Button btnEquipoLogo;
        private Button btnAtrasLogo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Usuario;
        private TextBox txtNombreUsuario;
        private Label label7;
    }
}
