﻿namespace InterfazGráfica
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            panel1 = new Panel();
            txtContraseñaUsuario = new TextBox();
            txtCarnetUsuario = new TextBox();
            txtCorreoUsuario = new TextBox();
            txtApellidosUsuario = new TextBox();
            txtNombreUsuario = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnGuardarUsuario = new Button();
            label2 = new Label();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(txtContraseñaUsuario);
            panel1.Controls.Add(txtCarnetUsuario);
            panel1.Controls.Add(txtCorreoUsuario);
            panel1.Controls.Add(txtApellidosUsuario);
            panel1.Controls.Add(txtNombreUsuario);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(311, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 376);
            panel1.TabIndex = 4;
            // 
            // txtContraseñaUsuario
            // 
            txtContraseñaUsuario.Font = new Font("Segoe UI", 12F);
            txtContraseñaUsuario.Location = new Point(258, 288);
            txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            txtContraseñaUsuario.Size = new Size(233, 29);
            txtContraseñaUsuario.TabIndex = 10;
            // 
            // txtCarnetUsuario
            // 
            txtCarnetUsuario.Font = new Font("Segoe UI", 12F);
            txtCarnetUsuario.Location = new Point(451, 218);
            txtCarnetUsuario.Name = "txtCarnetUsuario";
            txtCarnetUsuario.Size = new Size(233, 29);
            txtCarnetUsuario.TabIndex = 9;
            // 
            // txtCorreoUsuario
            // 
            txtCorreoUsuario.Font = new Font("Segoe UI", 12F);
            txtCorreoUsuario.Location = new Point(51, 218);
            txtCorreoUsuario.Name = "txtCorreoUsuario";
            txtCorreoUsuario.Size = new Size(233, 29);
            txtCorreoUsuario.TabIndex = 8;
            // 
            // txtApellidosUsuario
            // 
            txtApellidosUsuario.Font = new Font("Segoe UI", 12F);
            txtApellidosUsuario.Location = new Point(451, 139);
            txtApellidosUsuario.Name = "txtApellidosUsuario";
            txtApellidosUsuario.Size = new Size(233, 29);
            txtApellidosUsuario.TabIndex = 7;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Font = new Font("Segoe UI", 12F);
            txtNombreUsuario.Location = new Point(51, 139);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(233, 29);
            txtNombreUsuario.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(295, 248);
            label8.Name = "label8";
            label8.Size = new Size(146, 28);
            label8.TabIndex = 5;
            label8.Text = "Contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(451, 173);
            label7.Name = "label7";
            label7.Size = new Size(224, 28);
            label7.TabIndex = 4;
            label7.Text = "Número de Carnet";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 173);
            label1.Name = "label1";
            label1.Size = new Size(233, 28);
            label1.TabIndex = 3;
            label1.Text = "Correo Electronico";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(451, 100);
            label6.Name = "label6";
            label6.Size = new Size(121, 28);
            label6.TabIndex = 2;
            label6.Text = "Apellidos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(179, 100);
            label5.Name = "label5";
            label5.Size = new Size(105, 28);
            label5.TabIndex = 1;
            label5.Text = "Nombre";
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(305, 3);
            label4.Name = "label4";
            label4.Size = new Size(126, 95);
            label4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 225, 255);
            panel2.Controls.Add(btnGuardarUsuario);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(342, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 234);
            panel2.TabIndex = 3;
            // 
            // btnGuardarUsuario
            // 
            btnGuardarUsuario.BackColor = Color.FromArgb(242, 225, 255);
            btnGuardarUsuario.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarUsuario.Location = new Point(199, 167);
            btnGuardarUsuario.Name = "btnGuardarUsuario";
            btnGuardarUsuario.Size = new Size(278, 63);
            btnGuardarUsuario.TabIndex = 11;
            btnGuardarUsuario.Text = "Nuevo Usuario";
            btnGuardarUsuario.UseVisualStyleBackColor = false;
            btnGuardarUsuario.Click += btnGuardarUsuario_Click;
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
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Thistle;
            btnCancelar.Font = new Font("Baskerville Old Face", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 667);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 50);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // NuevoUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "NuevoUsuario";
            Text = "Nuevo Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private TextBox txtContraseñaUsuario;
        private TextBox txtCarnetUsuario;
        private TextBox txtCorreoUsuario;
        private TextBox txtApellidosUsuario;
        private TextBox txtNombreUsuario;
        private Label label8;
        private Button btnGuardarUsuario;
        private Button btnCancelar;
    }
}