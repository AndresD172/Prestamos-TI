﻿namespace InterfazGráfica
{
    partial class EditarDepartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarDepartamento));
            panel1 = new Panel();
            txtDescripcionDepartamento = new TextBox();
            label7 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnEditarDepartamento = new Button();
            label2 = new Label();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(txtDescripcionDepartamento);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(311, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 376);
            panel1.TabIndex = 8;
            // 
            // txtDescripcionDepartamento
            // 
            txtDescripcionDepartamento.Font = new Font("Segoe UI", 12F);
            txtDescripcionDepartamento.Location = new Point(257, 201);
            txtDescripcionDepartamento.Name = "txtDescripcionDepartamento";
            txtDescripcionDepartamento.Size = new Size(233, 29);
            txtDescripcionDepartamento.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(294, 156);
            label7.Name = "label7";
            label7.Size = new Size(153, 28);
            label7.TabIndex = 4;
            label7.Text = "Descripcion";
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(306, 9);
            label4.Name = "label4";
            label4.Size = new Size(126, 95);
            label4.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(242, 225, 255);
            panel2.Controls.Add(btnEditarDepartamento);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(342, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 234);
            panel2.TabIndex = 7;
            // 
            // btnEditarDepartamento
            // 
            btnEditarDepartamento.BackColor = Color.FromArgb(242, 225, 255);
            btnEditarDepartamento.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarDepartamento.Location = new Point(144, 167);
            btnEditarDepartamento.Name = "btnEditarDepartamento";
            btnEditarDepartamento.Size = new Size(393, 63);
            btnEditarDepartamento.TabIndex = 11;
            btnEditarDepartamento.Text = "Editar Departamento";
            btnEditarDepartamento.UseVisualStyleBackColor = false;
            btnEditarDepartamento.Click += btnEditarDepartamento_Click;
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
            // EditarDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "EditarDepartamento";
            Text = "EditarDepartamento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDescripcionDepartamento;
        private Label label7;
        private Label label4;
        private Panel panel2;
        private Button btnEditarDepartamento;
        private Label label2;
        private Button btnCancelar;
    }
}