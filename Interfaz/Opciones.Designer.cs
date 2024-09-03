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
            btnBuscar = new Button();
            btnNuevo = new Button();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Thistle;
            btnBuscar.Font = new Font("Franklin Gothic Book", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = Color.Black;
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(0, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(264, 78);
            btnBuscar.TabIndex = 55;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.Thistle;
            btnNuevo.Font = new Font("Franklin Gothic Book", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = Color.Black;
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(0, 81);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(264, 78);
            btnNuevo.TabIndex = 56;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // Opciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 158);
            Controls.Add(btnNuevo);
            Controls.Add(btnBuscar);
            Name = "Opciones";
            Text = "Opciones";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscar;
        private Button btnNuevo;
    }
}