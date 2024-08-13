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
            texContraseña = new TextBox();
            txtUsuario = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 225, 255);
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
            panel1.Controls.Add(texContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(277, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 376);
            panel1.TabIndex = 2;
            // 
            // texContraseña
            // 
            texContraseña.Anchor = AnchorStyles.None;
            texContraseña.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texContraseña.Location = new Point(181, 272);
            texContraseña.Name = "texContraseña";
            texContraseña.Size = new Size(380, 35);
            texContraseña.TabIndex = 4;
            texContraseña.TextAlign = HorizontalAlignment.Center;
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(303, 215);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 2;
            label6.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(248, 116);
            label5.Name = "label5";
            label5.Size = new Size(233, 28);
            label5.TabIndex = 1;
            label5.Text = "Nombre de usuario";
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(305, 3);
            label4.Name = "label4";
            label4.Size = new Size(126, 95);
            label4.TabIndex = 0;
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
            Load += Form2_Load;
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
        private TextBox texContraseña;
        private TextBox txtUsuario;
        private Label label6;
        private Label label5;
        private Button btnLogin;
    }
}