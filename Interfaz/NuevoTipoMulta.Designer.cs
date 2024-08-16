namespace InterfazGráfica
{
    partial class NuevoTipoMulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoTipoMulta));
            panel1 = new Panel();
            txtDescripciónTipoMulta = new TextBox();
            label7 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnGuardarTipoMulta = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(txtDescripciónTipoMulta);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(311, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 376);
            panel1.TabIndex = 10;
            // 
            // txtDescripciónTipoMulta
            // 
            txtDescripciónTipoMulta.Font = new Font("Segoe UI", 12F);
            txtDescripciónTipoMulta.Location = new Point(258, 193);
            txtDescripciónTipoMulta.Name = "txtDescripciónTipoMulta";
            txtDescripciónTipoMulta.Size = new Size(233, 29);
            txtDescripciónTipoMulta.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(296, 151);
            label7.Name = "label7";
            label7.Size = new Size(153, 28);
            label7.TabIndex = 4;
            label7.Text = "Descripción";
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
            panel2.Controls.Add(btnGuardarTipoMulta);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(342, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 234);
            panel2.TabIndex = 9;
            // 
            // btnGuardarTipoMulta
            // 
            btnGuardarTipoMulta.BackColor = Color.FromArgb(242, 225, 255);
            btnGuardarTipoMulta.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarTipoMulta.Location = new Point(164, 167);
            btnGuardarTipoMulta.Name = "btnGuardarTipoMulta";
            btnGuardarTipoMulta.Size = new Size(382, 47);
            btnGuardarTipoMulta.TabIndex = 7;
            btnGuardarTipoMulta.Text = "Nuevo Tipo Multa";
            btnGuardarTipoMulta.UseVisualStyleBackColor = false;
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
            // NuevoTipoMulta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "NuevoTipoMulta";
            Text = "NuevoTipoMulta";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDescripciónTipoMulta;
        private Label label7;
        private Label label4;
        private Panel panel2;
        private Button btnGuardarTipoMulta;
        private Label label2;
    }
}