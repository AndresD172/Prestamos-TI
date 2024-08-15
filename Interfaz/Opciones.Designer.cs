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
            btnOpcionNuevo = new Button();
            btnOpcionBuscar = new Button();
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
            // btnOpcionNuevo
            // 
            btnOpcionNuevo.BackColor = Color.FromArgb(244, 229, 255);
            btnOpcionNuevo.Font = new Font("Baskerville Old Face", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpcionNuevo.Image = (Image)resources.GetObject("btnOpcionNuevo.Image");
            btnOpcionNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpcionNuevo.Location = new Point(2, 1);
            btnOpcionNuevo.Name = "btnOpcionNuevo";
            btnOpcionNuevo.Size = new Size(215, 57);
            btnOpcionNuevo.TabIndex = 1;
            btnOpcionNuevo.Text = "Nuevo";
            btnOpcionNuevo.UseVisualStyleBackColor = false;
            btnOpcionNuevo.Click += btnOpcionNuevo_Click;
            // 
            // btnOpcionBuscar
            // 
            btnOpcionBuscar.BackColor = Color.FromArgb(244, 229, 255);
            btnOpcionBuscar.Font = new Font("Baskerville Old Face", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpcionBuscar.Image = (Image)resources.GetObject("btnOpcionBuscar.Image");
            btnOpcionBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnOpcionBuscar.Location = new Point(2, 64);
            btnOpcionBuscar.Name = "btnOpcionBuscar";
            btnOpcionBuscar.Size = new Size(215, 55);
            btnOpcionBuscar.TabIndex = 2;
            btnOpcionBuscar.Text = "Buscar";
            btnOpcionBuscar.UseVisualStyleBackColor = false;
            btnOpcionBuscar.Click += btnOpcionBuscar_Click;
            // 
            // Opciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 229, 255);
            ClientSize = new Size(220, 124);
            Controls.Add(btnOpcionBuscar);
            Controls.Add(btnOpcionNuevo);
            Controls.Add(panel1);
            Name = "Opciones";
            Text = "Opciones";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnOpcionNuevo;
        private Button btnOpcionBuscar;
    }
}