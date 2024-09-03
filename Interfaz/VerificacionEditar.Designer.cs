namespace InterfazGráfica
{
    partial class VerificacionEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerificacionEditar));
            label1 = new Label();
            label2 = new Label();
            btnEditar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(157, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 109);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 118);
            label2.Name = "label2";
            label2.Size = new Size(399, 86);
            label2.TabIndex = 1;
            label2.Text = "¿Esta seguro de realizar \r\nla edición?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(180, 154, 248);
            btnEditar.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(61, 255);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 51);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(180, 154, 248);
            btnCancelar.Font = new Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(245, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 51);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // VerificacionEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 203, 255);
            ClientSize = new Size(476, 364);
            Controls.Add(btnCancelar);
            Controls.Add(btnEditar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "VerificacionEditar";
            Text = "Verificar Edición";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEditar;
        private Button btnCancelar;
    }
}