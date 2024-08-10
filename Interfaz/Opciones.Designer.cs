namespace InterfazGráfica
{
    partial class Opciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Opciones));
            panel1 = new Panel();
            btnOpciónNuevo = new Button();
            btnOpciónBuscar = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(229, 229, 229);
            panel1.Location = new Point(2, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 10);
            panel1.TabIndex = 0;
            // 
            // btnOpciónNuevo
            // 
            btnOpciónNuevo.BackColor = Color.FromArgb(244, 229, 255);
            btnOpciónNuevo.Font = new Font("Baskerville Old Face", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpciónNuevo.Image = (Image)resources.GetObject("btnOpciónNuevo.Image");
            btnOpciónNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpciónNuevo.Location = new Point(2, 1);
            btnOpciónNuevo.Name = "btnOpciónNuevo";
            btnOpciónNuevo.Size = new Size(273, 57);
            btnOpciónNuevo.TabIndex = 1;
            btnOpciónNuevo.Text = "Nuevo";
            btnOpciónNuevo.UseVisualStyleBackColor = false;
            // 
            // btnOpciónBuscar
            // 
            btnOpciónBuscar.BackColor = Color.FromArgb(244, 229, 255);
            btnOpciónBuscar.Font = new Font("Baskerville Old Face", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpciónBuscar.Image = (Image)resources.GetObject("btnOpciónBuscar.Image");
            btnOpciónBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpciónBuscar.Location = new Point(2, 64);
            btnOpciónBuscar.Name = "btnOpciónBuscar";
            btnOpciónBuscar.Size = new Size(273, 66);
            btnOpciónBuscar.TabIndex = 2;
            btnOpciónBuscar.Text = "Buscar";
            btnOpciónBuscar.UseVisualStyleBackColor = false;
            // 
            // Opciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 229, 255);
            ClientSize = new Size(277, 131);
            Controls.Add(btnOpciónBuscar);
            Controls.Add(btnOpciónNuevo);
            Controls.Add(panel1);
            Name = "Opciones";
            Text = "Opciones";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOpciónNuevo;
        private Button btnOpciónBuscar;
    }
}