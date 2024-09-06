namespace InterfazGráfica
{
    partial class VerificacionEliminacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificacionEliminacion));
            btnCancelar = new Button();
            btnEliminar = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(180, 154, 248);
            btnCancelar.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(240, 280);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 51);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(180, 154, 248);
            btnEliminar.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(56, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(155, 51);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 143);
            label2.Name = "label2";
            label2.Size = new Size(399, 86);
            label2.TabIndex = 5;
            label2.Text = "¿Esta seguro de realizar \r\nla eliminación?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(152, 34);
            label1.Name = "label1";
            label1.Size = new Size(152, 109);
            label1.TabIndex = 4;
            // 
            // VerificarEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 203, 255);
            ClientSize = new Size(472, 364);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(label2);
            Controls.Add(label1);
            Location = new Point(50, 5);
            Name = "VerificarEliminar";
            Text = "VerificarEliminar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnEliminar;
        private Label label2;
        private Label label1;
    }
}