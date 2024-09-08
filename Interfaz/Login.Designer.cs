namespace InterfazGráfica
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel2 = new Panel();
            btnLogin = new Button();
            label2 = new Label();
            panel1 = new Panel();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            mostradorContraseña = new Label();
            mostardorUser = new Label();
            label4 = new Label();
            label7 = new Label();
            btnAtrasLogo = new Button();
            btnSalir = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 225, 255);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnSalir);
            panel2.Controls.Add(btnAtrasLogo);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(308, 336);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 234);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(242, 225, 255);
            btnLogin.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(263, 167);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(167, 52);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(275, 95);
            label2.Name = "label2";
            label2.Size = new Size(122, 44);
            label2.TabIndex = 1;
            label2.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(mostradorContraseña);
            panel1.Controls.Add(mostardorUser);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(277, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 376);
            panel1.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.None;
            txtContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(181, 272);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(380, 35);
            txtContraseña.TabIndex = 4;
            txtContraseña.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.None;
            txtUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(181, 156);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(380, 35);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // mostradorContraseña
            // 
            mostradorContraseña.AutoSize = true;
            mostradorContraseña.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            mostradorContraseña.Location = new Point(303, 215);
            mostradorContraseña.Name = "mostradorContraseña";
            mostradorContraseña.Size = new Size(146, 28);
            mostradorContraseña.TabIndex = 2;
            mostradorContraseña.Text = "Contraseña";
            // 
            // mostardorUser
            // 
            mostardorUser.AutoSize = true;
            mostardorUser.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            mostardorUser.Location = new Point(248, 116);
            mostardorUser.Name = "mostardorUser";
            mostardorUser.Size = new Size(233, 28);
            mostardorUser.TabIndex = 1;
            mostardorUser.Text = "Nombre de usuario";
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(305, 3);
            label4.Name = "label4";
            label4.Size = new Size(126, 95);
            label4.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label7.Location = new Point(357, 98);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(90, 43);
            label7.TabIndex = 19;
            label7.Text = "Salir";
            // 
            // btnAtrasLogo
            // 
            btnAtrasLogo.BackColor = Color.FromArgb(239, 221, 254);
            btnAtrasLogo.Image = (Image)resources.GetObject("btnAtrasLogo.Image");
            btnAtrasLogo.Location = new Point(225, 85);
            btnAtrasLogo.Margin = new Padding(0);
            btnAtrasLogo.Name = "btnAtrasLogo";
            btnAtrasLogo.Size = new Size(120, 65);
            btnAtrasLogo.TabIndex = 18;
            btnAtrasLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtrasLogo.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(239, 221, 254);
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(11, 164);
            btnSalir.Margin = new Padding(0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(120, 65);
            btnSalir.TabIndex = 18;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Login";
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Label label2;
        private Label label4;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Label mostradorContraseña;
        private Label mostardorUser;
        private Button btnLogin;
        private Label label7;
        private Button btnSalir;
        private Button btnAtrasLogo;
    }
}