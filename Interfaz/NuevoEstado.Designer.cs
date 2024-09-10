namespace InterfazGráfica
{
    partial class NuevoEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoEstado));
            panel1 = new Panel();
            txtDescripciónEstado = new TextBox();
            label7 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnGuardarEstado = new Button();
            label2 = new Label();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(txtDescripciónEstado);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(355, 187);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(832, 501);
            panel1.TabIndex = 10;
            // 
            // txtDescripciónEstado
            // 
            txtDescripciónEstado.Font = new Font("Segoe UI", 12F);
            txtDescripciónEstado.Location = new Point(295, 257);
            txtDescripciónEstado.Margin = new Padding(3, 4, 3, 4);
            txtDescripciónEstado.Name = "txtDescripciónEstado";
            txtDescripciónEstado.Size = new Size(266, 34);
            txtDescripciónEstado.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(338, 201);
            label7.Name = "label7";
            label7.Size = new Size(172, 36);
            label7.TabIndex = 4;
            label7.Text = "Descripción";
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(349, 4);
            label4.Name = "label4";
            label4.Size = new Size(144, 127);
            label4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 225, 255);
            panel2.Controls.Add(btnGuardarEstado);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(391, 473);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(769, 312);
            panel2.TabIndex = 9;
            // 
            // btnGuardarEstado
            // 
            btnGuardarEstado.BackColor = Color.FromArgb(242, 225, 255);
            btnGuardarEstado.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarEstado.Location = new Point(187, 223);
            btnGuardarEstado.Margin = new Padding(3, 4, 3, 4);
            btnGuardarEstado.Name = "btnGuardarEstado";
            btnGuardarEstado.Size = new Size(437, 63);
            btnGuardarEstado.TabIndex = 7;
            btnGuardarEstado.Text = "Nuevo Estado";
            btnGuardarEstado.UseVisualStyleBackColor = false;
            btnGuardarEstado.Click += btnGuardarEstado_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(314, 127);
            label2.Name = "label2";
            label2.Size = new Size(158, 52);
            label2.TabIndex = 1;
            label2.Text = "LOGIN";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Thistle;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(14, 889);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(197, 67);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NuevoEstado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1543, 972);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NuevoEstado";
            Text = "NuevoEstado";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDescripciónEstado;
        private Label label7;
        private Label label4;
        private Panel panel2;
        private Button btnGuardarEstado;
        private Label label2;
        private Button btnCancelar;
    }
}