namespace InterfazGráfica
{
    partial class BuscarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarUsuario));
            txtNombreUsuario = new TextBox();
            Usuario = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            btnAtrasLogo = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnPrestatariosLogo = new Button();
            btnUsuarioLogo = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.BackColor = Color.FromArgb(251, 246, 255);
            txtNombreUsuario.Font = new Font("Baskerville Old Face", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombreUsuario.Location = new Point(1084, 33);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(198, 31);
            txtNombreUsuario.TabIndex = 22;
            txtNombreUsuario.Text = "Nombre del usuario";
            txtNombreUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // Usuario
            // 
            Usuario.Image = (Image)resources.GetObject("Usuario.Image");
            Usuario.Location = new Point(1288, 21);
            Usuario.Name = "Usuario";
            Usuario.Size = new Size(50, 43);
            Usuario.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label1.Location = new Point(117, 22);
            label1.Name = "label1";
            label1.Size = new Size(126, 43);
            label1.TabIndex = 20;
            label1.Text = "Buscar";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(337, 92);
            panel2.Margin = new Padding(0);
            panel2.MinimumSize = new Size(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 623);
            panel2.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Location = new Point(-1, 82);
            panel1.Margin = new Padding(0);
            panel1.MinimumSize = new Size(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1352, 10);
            panel1.TabIndex = 17;
            // 
            // btnAtrasLogo
            // 
            btnAtrasLogo.BackColor = Color.FromArgb(239, 221, 254);
            btnAtrasLogo.Image = (Image)resources.GetObject("btnAtrasLogo.Image");
            btnAtrasLogo.Location = new Point(9, 651);
            btnAtrasLogo.Margin = new Padding(0);
            btnAtrasLogo.Name = "btnAtrasLogo";
            btnAtrasLogo.Size = new Size(137, 69);
            btnAtrasLogo.TabIndex = 23;
            btnAtrasLogo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAtrasLogo.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(2, 3);
            label3.Name = "label3";
            label3.Size = new Size(141, 89);
            label3.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label2.Location = new Point(133, 280);
            label2.Name = "label2";
            label2.Size = new Size(115, 43);
            label2.TabIndex = 29;
            label2.Text = "Editar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label4.Location = new Point(133, 183);
            label4.Name = "label4";
            label4.Size = new Size(155, 43);
            label4.TabIndex = 28;
            label4.Text = "Eliminar";
            // 
            // btnPrestatariosLogo
            // 
            btnPrestatariosLogo.BackColor = Color.FromArgb(251, 246, 255);
            btnPrestatariosLogo.Image = (Image)resources.GetObject("btnPrestatariosLogo.Image");
            btnPrestatariosLogo.Location = new Point(12, 253);
            btnPrestatariosLogo.Name = "btnPrestatariosLogo";
            btnPrestatariosLogo.Size = new Size(99, 90);
            btnPrestatariosLogo.TabIndex = 27;
            btnPrestatariosLogo.UseVisualStyleBackColor = false;
            // 
            // btnUsuarioLogo
            // 
            btnUsuarioLogo.BackColor = Color.FromArgb(251, 246, 255);
            btnUsuarioLogo.ForeColor = Color.FromArgb(251, 246, 255);
            btnUsuarioLogo.Image = (Image)resources.GetObject("btnUsuarioLogo.Image");
            btnUsuarioLogo.Location = new Point(12, 157);
            btnUsuarioLogo.Name = "btnUsuarioLogo";
            btnUsuarioLogo.Size = new Size(99, 90);
            btnUsuarioLogo.TabIndex = 26;
            btnUsuarioLogo.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(246, 236, 255);
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(350, 219);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(998, 501);
            dataGridView1.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(229, 220, 252);
            textBox1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(392, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(911, 35);
            textBox1.TabIndex = 31;
            // 
            // BuscarUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(btnPrestatariosLogo);
            Controls.Add(btnUsuarioLogo);
            Controls.Add(btnAtrasLogo);
            Controls.Add(Usuario);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Name = "BuscarUsuario";
            Text = "Buscar Usuario";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreUsuario;
        private Label Usuario;
        private Label label1;
        private Panel panel2;
        private Panel panel1;
        private Button btnAtrasLogo;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnPrestatariosLogo;
        private Button btnUsuarioLogo;
        private DataGridView dataGridView1;
        private TextBox textBox1;
    }
}