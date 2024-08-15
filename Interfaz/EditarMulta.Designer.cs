namespace InterfazGráfica
{
    partial class EditarMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarMulta));
            panel1 = new Panel();
            txtDescripciónMulta = new TextBox();
            txtTipoMulta = new TextBox();
            txtTécnicoMulta = new TextBox();
            txtPrestatarioMulta = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnEditarMulta = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(txtDescripciónMulta);
            panel1.Controls.Add(txtTipoMulta);
            panel1.Controls.Add(txtTécnicoMulta);
            panel1.Controls.Add(txtPrestatarioMulta);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(311, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 376);
            panel1.TabIndex = 8;
            // 
            // txtDescripciónMulta
            // 
            txtDescripciónMulta.Font = new Font("Segoe UI", 12F);
            txtDescripciónMulta.Location = new Point(452, 266);
            txtDescripciónMulta.Name = "txtDescripciónMulta";
            txtDescripciónMulta.Size = new Size(233, 29);
            txtDescripciónMulta.TabIndex = 9;
            // 
            // txtTipoMulta
            // 
            txtTipoMulta.Font = new Font("Segoe UI", 12F);
            txtTipoMulta.Location = new Point(52, 266);
            txtTipoMulta.Name = "txtTipoMulta";
            txtTipoMulta.Size = new Size(233, 29);
            txtTipoMulta.TabIndex = 8;
            // 
            // txtTécnicoMulta
            // 
            txtTécnicoMulta.Font = new Font("Segoe UI", 12F);
            txtTécnicoMulta.Location = new Point(452, 157);
            txtTécnicoMulta.Name = "txtTécnicoMulta";
            txtTécnicoMulta.Size = new Size(233, 29);
            txtTécnicoMulta.TabIndex = 7;
            // 
            // txtPrestatarioMulta
            // 
            txtPrestatarioMulta.Font = new Font("Segoe UI", 12F);
            txtPrestatarioMulta.Location = new Point(52, 157);
            txtPrestatarioMulta.Name = "txtPrestatarioMulta";
            txtPrestatarioMulta.Size = new Size(233, 29);
            txtPrestatarioMulta.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(452, 221);
            label7.Name = "label7";
            label7.Size = new Size(153, 28);
            label7.TabIndex = 4;
            label7.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 221);
            label1.Name = "label1";
            label1.Size = new Size(167, 28);
            label1.TabIndex = 3;
            label1.Text = "Tipo de Multa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(452, 118);
            label6.Name = "label6";
            label6.Size = new Size(104, 28);
            label6.TabIndex = 2;
            label6.Text = "Técnico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 118);
            label5.Name = "label5";
            label5.Size = new Size(142, 28);
            label5.TabIndex = 1;
            label5.Text = "Prestatario";
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
            panel2.Controls.Add(btnEditarMulta);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(342, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 234);
            panel2.TabIndex = 7;
            // 
            // btnEditarMulta
            // 
            btnEditarMulta.BackColor = Color.FromArgb(242, 225, 255);
            btnEditarMulta.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarMulta.Location = new Point(209, 167);
            btnEditarMulta.Name = "btnEditarMulta";
            btnEditarMulta.Size = new Size(251, 47);
            btnEditarMulta.TabIndex = 7;
            btnEditarMulta.Text = "Editar Multa";
            btnEditarMulta.UseVisualStyleBackColor = false;
            btnEditarMulta.Click += btnEditarMulta_Click;
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
            // EditarMulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "EditarMulta";
            Text = "Editar Multa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDescripciónMulta;
        private TextBox txtTipoMulta;
        private TextBox txtTécnicoMulta;
        private TextBox txtPrestatarioMulta;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Button btnEditarMulta;
        private Label label2;
    }
}