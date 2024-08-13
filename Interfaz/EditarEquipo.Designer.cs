namespace InterfazGráfica
{
    partial class ModificarEquipo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarEquipo));
            panel1 = new Panel();
            txtDescripciónEquipo = new TextBox();
            txtCategoríaEquipo = new TextBox();
            txtEstadoEquipo = new TextBox();
            txtModeloEquipo = new TextBox();
            txSerieEquipo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnEditarEquipo = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(txtDescripciónEquipo);
            panel1.Controls.Add(txtCategoríaEquipo);
            panel1.Controls.Add(txtEstadoEquipo);
            panel1.Controls.Add(txtModeloEquipo);
            panel1.Controls.Add(txSerieEquipo);
            panel1.Controls.Add(label8);
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
            // txtDescripciónEquipo
            // 
            txtDescripciónEquipo.Font = new Font("Segoe UI", 12F);
            txtDescripciónEquipo.Location = new Point(258, 288);
            txtDescripciónEquipo.Name = "txtDescripciónEquipo";
            txtDescripciónEquipo.Size = new Size(233, 29);
            txtDescripciónEquipo.TabIndex = 10;
            // 
            // txtCategoríaEquipo
            // 
            txtCategoríaEquipo.Font = new Font("Segoe UI", 12F);
            txtCategoríaEquipo.Location = new Point(451, 218);
            txtCategoríaEquipo.Name = "txtCategoríaEquipo";
            txtCategoríaEquipo.Size = new Size(233, 29);
            txtCategoríaEquipo.TabIndex = 9;
            // 
            // txtEstadoEquipo
            // 
            txtEstadoEquipo.Font = new Font("Segoe UI", 12F);
            txtEstadoEquipo.Location = new Point(51, 218);
            txtEstadoEquipo.Name = "txtEstadoEquipo";
            txtEstadoEquipo.Size = new Size(233, 29);
            txtEstadoEquipo.TabIndex = 8;
            // 
            // txtModeloEquipo
            // 
            txtModeloEquipo.Font = new Font("Segoe UI", 12F);
            txtModeloEquipo.Location = new Point(451, 139);
            txtModeloEquipo.Name = "txtModeloEquipo";
            txtModeloEquipo.Size = new Size(233, 29);
            txtModeloEquipo.TabIndex = 7;
            // 
            // txSerieEquipo
            // 
            txSerieEquipo.Font = new Font("Segoe UI", 12F);
            txSerieEquipo.Location = new Point(51, 139);
            txSerieEquipo.Name = "txSerieEquipo";
            txSerieEquipo.Size = new Size(233, 29);
            txSerieEquipo.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(295, 248);
            label8.Name = "label8";
            label8.Size = new Size(153, 28);
            label8.TabIndex = 5;
            label8.Text = "Descripción";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(451, 173);
            label7.Name = "label7";
            label7.Size = new Size(127, 28);
            label7.TabIndex = 4;
            label7.Text = "Categoría";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 173);
            label1.Name = "label1";
            label1.Size = new Size(244, 28);
            label1.TabIndex = 3;
            label1.Text = "Estado de Prestamo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(451, 100);
            label6.Name = "label6";
            label6.Size = new Size(96, 28);
            label6.TabIndex = 2;
            label6.Text = "Modelo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(112, 100);
            label5.Name = "label5";
            label5.Size = new Size(172, 28);
            label5.TabIndex = 1;
            label5.Text = "Número Serie";
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
            panel2.Controls.Add(btnEditarEquipo);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(342, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 234);
            panel2.TabIndex = 7;
            // 
            // btnEditarEquipo
            // 
            btnEditarEquipo.BackColor = Color.FromArgb(242, 225, 255);
            btnEditarEquipo.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarEquipo.Location = new Point(204, 167);
            btnEditarEquipo.Name = "btnEditarEquipo";
            btnEditarEquipo.Size = new Size(265, 48);
            btnEditarEquipo.TabIndex = 11;
            btnEditarEquipo.Text = "Editar Equipo";
            btnEditarEquipo.UseVisualStyleBackColor = false;
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
            // ModificarEquipo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ModificarEquipo";
            Text = "Editar Equipo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDescripciónEquipo;
        private TextBox txtCategoríaEquipo;
        private TextBox txtEstadoEquipo;
        private TextBox txtModeloEquipo;
        private TextBox txSerieEquipo;
        private Label label8;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Button btnEditarEquipo;
        private Label label2;
    }
}