namespace InterfazGráfica
{
    partial class NuevoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoPrestamo));
            panel1 = new Panel();
            btnNuevoEstado = new Button();
            btnNuevoPrestatario = new Button();
            btnNuevoPrestamista = new Button();
            btnEstado = new Button();
            btnPrestatario = new Button();
            btnPrestamista = new Button();
            txtEstadoPréstamo = new TextBox();
            label9 = new Label();
            txtPrestamistaPréstamo = new TextBox();
            txtDevolucionPréstamo = new TextBox();
            txtFechaPréstamo = new TextBox();
            txtPrestatarioPréstamo = new TextBox();
            txEquipoPréstamo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            btnNuevoPrestamo = new Button();
            label2 = new Label();
            btnBuscarPrestatario = new Button();
            txtBuscarPrestatario = new TextBox();
            panelPrestatario = new Panel();
            btnCerrarPrestatario = new Button();
            dataGridViewPrestatario = new DataGridView();
            panelPrestamista = new Panel();
            btnBuscarPrestamista = new Button();
            btnCerrarPrestamista = new Button();
            dataGridViewPrestamista = new DataGridView();
            txtBuscarPrestamista = new TextBox();
            panelEstado = new Panel();
            btnBuscarEstado = new Button();
            btnCerrarEstado = new Button();
            dataGridViewEstado = new DataGridView();
            txtBuscarEstado = new TextBox();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelPrestatario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestatario).BeginInit();
            panelPrestamista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamista).BeginInit();
            panelEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstado).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(247, 238, 255);
            panel1.Controls.Add(btnNuevoEstado);
            panel1.Controls.Add(btnNuevoPrestatario);
            panel1.Controls.Add(btnNuevoPrestamista);
            panel1.Controls.Add(btnEstado);
            panel1.Controls.Add(btnPrestatario);
            panel1.Controls.Add(btnPrestamista);
            panel1.Controls.Add(txtEstadoPréstamo);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPrestamistaPréstamo);
            panel1.Controls.Add(txtDevolucionPréstamo);
            panel1.Controls.Add(txtFechaPréstamo);
            panel1.Controls.Add(txtPrestatarioPréstamo);
            panel1.Controls.Add(txEquipoPréstamo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(298, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 376);
            panel1.TabIndex = 6;
            // 
            // btnNuevoEstado
            // 
            btnNuevoEstado.BackgroundImage = (Image)resources.GetObject("btnNuevoEstado.BackgroundImage");
            btnNuevoEstado.BackgroundImageLayout = ImageLayout.Center;
            btnNuevoEstado.Location = new Point(690, 300);
            btnNuevoEstado.Name = "btnNuevoEstado";
            btnNuevoEstado.Size = new Size(32, 28);
            btnNuevoEstado.TabIndex = 33;
            btnNuevoEstado.UseVisualStyleBackColor = true;
            btnNuevoEstado.Click += btnNuevoEstado_Click;
            // 
            // btnNuevoPrestatario
            // 
            btnNuevoPrestatario.BackgroundImage = (Image)resources.GetObject("btnNuevoPrestatario.BackgroundImage");
            btnNuevoPrestatario.BackgroundImageLayout = ImageLayout.Center;
            btnNuevoPrestatario.Location = new Point(690, 143);
            btnNuevoPrestatario.Name = "btnNuevoPrestatario";
            btnNuevoPrestatario.Size = new Size(32, 28);
            btnNuevoPrestatario.TabIndex = 32;
            btnNuevoPrestatario.UseVisualStyleBackColor = true;
            btnNuevoPrestatario.Click += btnNuevoPrestatario_Click;
            // 
            // btnNuevoPrestamista
            // 
            btnNuevoPrestamista.BackgroundImage = (Image)resources.GetObject("btnNuevoPrestamista.BackgroundImage");
            btnNuevoPrestamista.BackgroundImageLayout = ImageLayout.Center;
            btnNuevoPrestamista.Location = new Point(13, 300);
            btnNuevoPrestamista.Name = "btnNuevoPrestamista";
            btnNuevoPrestamista.Size = new Size(32, 28);
            btnNuevoPrestamista.TabIndex = 31;
            btnNuevoPrestamista.UseVisualStyleBackColor = true;
            btnNuevoPrestamista.Click += btnNuevoPrestamista_Click;
            // 
            // btnEstado
            // 
            btnEstado.BackgroundImage = (Image)resources.GetObject("btnEstado.BackgroundImage");
            btnEstado.BackgroundImageLayout = ImageLayout.Center;
            btnEstado.Location = new Point(420, 305);
            btnEstado.Name = "btnEstado";
            btnEstado.Size = new Size(25, 23);
            btnEstado.TabIndex = 15;
            btnEstado.UseVisualStyleBackColor = true;
            btnEstado.Click += btnEstado_Click;
            // 
            // btnPrestatario
            // 
            btnPrestatario.BackgroundImage = (Image)resources.GetObject("btnPrestatario.BackgroundImage");
            btnPrestatario.BackgroundImageLayout = ImageLayout.Center;
            btnPrestatario.Location = new Point(420, 143);
            btnPrestatario.Name = "btnPrestatario";
            btnPrestatario.Size = new Size(25, 23);
            btnPrestatario.TabIndex = 14;
            btnPrestatario.UseVisualStyleBackColor = true;
            btnPrestatario.Click += btnPrestatario_Click;
            // 
            // btnPrestamista
            // 
            btnPrestamista.BackgroundImage = (Image)resources.GetObject("btnPrestamista.BackgroundImage");
            btnPrestamista.BackgroundImageLayout = ImageLayout.Center;
            btnPrestamista.Location = new Point(290, 305);
            btnPrestamista.Name = "btnPrestamista";
            btnPrestamista.Size = new Size(25, 23);
            btnPrestamista.TabIndex = 13;
            btnPrestamista.UseVisualStyleBackColor = true;
            btnPrestamista.Click += btnPrestamista_Click;
            // 
            // txtEstadoPréstamo
            // 
            txtEstadoPréstamo.Font = new Font("Segoe UI", 12F);
            txtEstadoPréstamo.Location = new Point(451, 301);
            txtEstadoPréstamo.Name = "txtEstadoPréstamo";
            txtEstadoPréstamo.Size = new Size(233, 29);
            txtEstadoPréstamo.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(454, 261);
            label9.Name = "label9";
            label9.Size = new Size(92, 28);
            label9.TabIndex = 11;
            label9.Text = "Estado";
            // 
            // txtPrestamistaPréstamo
            // 
            txtPrestamistaPréstamo.Font = new Font("Segoe UI", 12F);
            txtPrestamistaPréstamo.Location = new Point(51, 301);
            txtPrestamistaPréstamo.Name = "txtPrestamistaPréstamo";
            txtPrestamistaPréstamo.Size = new Size(233, 29);
            txtPrestamistaPréstamo.TabIndex = 10;
            // 
            // txtDevolucionPréstamo
            // 
            txtDevolucionPréstamo.Font = new Font("Segoe UI", 12F);
            txtDevolucionPréstamo.Location = new Point(451, 218);
            txtDevolucionPréstamo.Name = "txtDevolucionPréstamo";
            txtDevolucionPréstamo.Size = new Size(233, 29);
            txtDevolucionPréstamo.TabIndex = 9;
            // 
            // txtFechaPréstamo
            // 
            txtFechaPréstamo.Font = new Font("Segoe UI", 12F);
            txtFechaPréstamo.Location = new Point(51, 218);
            txtFechaPréstamo.Name = "txtFechaPréstamo";
            txtFechaPréstamo.Size = new Size(233, 29);
            txtFechaPréstamo.TabIndex = 8;
            // 
            // txtPrestatarioPréstamo
            // 
            txtPrestatarioPréstamo.Font = new Font("Segoe UI", 12F);
            txtPrestatarioPréstamo.Location = new Point(451, 139);
            txtPrestatarioPréstamo.Name = "txtPrestatarioPréstamo";
            txtPrestatarioPréstamo.Size = new Size(233, 29);
            txtPrestatarioPréstamo.TabIndex = 7;
            // 
            // txEquipoPréstamo
            // 
            txEquipoPréstamo.Font = new Font("Segoe UI", 12F);
            txEquipoPréstamo.Location = new Point(51, 139);
            txEquipoPréstamo.Name = "txEquipoPréstamo";
            txEquipoPréstamo.Size = new Size(233, 29);
            txEquipoPréstamo.TabIndex = 6;
            txEquipoPréstamo.TextChanged += txEquipoPréstamo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(54, 261);
            label8.Name = "label8";
            label8.Size = new Size(151, 28);
            label8.TabIndex = 5;
            label8.Text = "Prestamista";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(451, 173);
            label7.Name = "label7";
            label7.Size = new Size(217, 28);
            label7.TabIndex = 4;
            label7.Text = "Fecha Devolución";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 173);
            label1.Name = "label1";
            label1.Size = new Size(199, 28);
            label1.TabIndex = 3;
            label1.Text = "Fecha Prestamo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(451, 100);
            label6.Name = "label6";
            label6.Size = new Size(142, 28);
            label6.TabIndex = 2;
            label6.Text = "Prestatario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(179, 100);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 1;
            label5.Text = "Equipo";
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
            panel2.Controls.Add(btnNuevoPrestamo);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(329, 347);
            panel2.Name = "panel2";
            panel2.Size = new Size(673, 234);
            panel2.TabIndex = 5;
            // 
            // btnNuevoPrestamo
            // 
            btnNuevoPrestamo.BackColor = Color.FromArgb(242, 225, 255);
            btnNuevoPrestamo.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoPrestamo.Location = new Point(191, 167);
            btnNuevoPrestamo.Name = "btnNuevoPrestamo";
            btnNuevoPrestamo.Size = new Size(309, 52);
            btnNuevoPrestamo.TabIndex = 2;
            btnNuevoPrestamo.Text = "Nuevo Prestamo";
            btnNuevoPrestamo.UseVisualStyleBackColor = false;
            btnNuevoPrestamo.Click += btnNuevoPrestamo_Click;
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
            // btnBuscarPrestatario
            // 
            btnBuscarPrestatario.Location = new Point(208, 12);
            btnBuscarPrestatario.Name = "btnBuscarPrestatario";
            btnBuscarPrestatario.Size = new Size(25, 23);
            btnBuscarPrestatario.TabIndex = 17;
            btnBuscarPrestatario.UseVisualStyleBackColor = true;
            btnBuscarPrestatario.Click += btnBuscarPrestatario_Click;
            // 
            // txtBuscarPrestatario
            // 
            txtBuscarPrestatario.Font = new Font("Segoe UI", 12F);
            txtBuscarPrestatario.Location = new Point(3, 8);
            txtBuscarPrestatario.Name = "txtBuscarPrestatario";
            txtBuscarPrestatario.Size = new Size(202, 29);
            txtBuscarPrestatario.TabIndex = 11;
            // 
            // panelPrestatario
            // 
            panelPrestatario.Controls.Add(btnBuscarPrestatario);
            panelPrestatario.Controls.Add(btnCerrarPrestatario);
            panelPrestatario.Controls.Add(dataGridViewPrestatario);
            panelPrestatario.Controls.Add(txtBuscarPrestatario);
            panelPrestatario.Location = new Point(1065, 5);
            panelPrestatario.Name = "panelPrestatario";
            panelPrestatario.Size = new Size(276, 235);
            panelPrestatario.TabIndex = 16;
            panelPrestatario.Visible = false;
            // 
            // btnCerrarPrestatario
            // 
            btnCerrarPrestatario.Location = new Point(237, 12);
            btnCerrarPrestatario.Name = "btnCerrarPrestatario";
            btnCerrarPrestatario.Size = new Size(25, 23);
            btnCerrarPrestatario.TabIndex = 20;
            btnCerrarPrestatario.UseVisualStyleBackColor = true;
            btnCerrarPrestatario.Click += btnCerrarPrestatario_Click;
            // 
            // dataGridViewPrestatario
            // 
            dataGridViewPrestatario.AllowUserToAddRows = false;
            dataGridViewPrestatario.AllowUserToDeleteRows = false;
            dataGridViewPrestatario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrestatario.Location = new Point(0, 60);
            dataGridViewPrestatario.Name = "dataGridViewPrestatario";
            dataGridViewPrestatario.ReadOnly = true;
            dataGridViewPrestatario.Size = new Size(276, 177);
            dataGridViewPrestatario.TabIndex = 16;
            dataGridViewPrestatario.DoubleClick += dataGridViewPrestatario_DoubleClick;
            // 
            // panelPrestamista
            // 
            panelPrestamista.Controls.Add(btnBuscarPrestamista);
            panelPrestamista.Controls.Add(btnCerrarPrestamista);
            panelPrestamista.Controls.Add(dataGridViewPrestamista);
            panelPrestamista.Controls.Add(txtBuscarPrestamista);
            panelPrestamista.Location = new Point(1065, 246);
            panelPrestamista.Name = "panelPrestamista";
            panelPrestamista.Size = new Size(276, 235);
            panelPrestamista.TabIndex = 21;
            panelPrestamista.Visible = false;
            // 
            // btnBuscarPrestamista
            // 
            btnBuscarPrestamista.Location = new Point(208, 12);
            btnBuscarPrestamista.Name = "btnBuscarPrestamista";
            btnBuscarPrestamista.Size = new Size(25, 23);
            btnBuscarPrestamista.TabIndex = 17;
            btnBuscarPrestamista.UseVisualStyleBackColor = true;
            btnBuscarPrestamista.Click += btnBuscarPrestamista_Click;
            // 
            // btnCerrarPrestamista
            // 
            btnCerrarPrestamista.Location = new Point(237, 12);
            btnCerrarPrestamista.Name = "btnCerrarPrestamista";
            btnCerrarPrestamista.Size = new Size(25, 23);
            btnCerrarPrestamista.TabIndex = 20;
            btnCerrarPrestamista.UseVisualStyleBackColor = true;
            btnCerrarPrestamista.Click += btnCerrarPrestamista_Click;
            // 
            // dataGridViewPrestamista
            // 
            dataGridViewPrestamista.AllowUserToAddRows = false;
            dataGridViewPrestamista.AllowUserToDeleteRows = false;
            dataGridViewPrestamista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPrestamista.Location = new Point(0, 60);
            dataGridViewPrestamista.Name = "dataGridViewPrestamista";
            dataGridViewPrestamista.ReadOnly = true;
            dataGridViewPrestamista.Size = new Size(276, 177);
            dataGridViewPrestamista.TabIndex = 16;
            dataGridViewPrestamista.DoubleClick += dataGridViewPrestamista_DoubleClick;
            // 
            // txtBuscarPrestamista
            // 
            txtBuscarPrestamista.Font = new Font("Segoe UI", 12F);
            txtBuscarPrestamista.Location = new Point(3, 8);
            txtBuscarPrestamista.Name = "txtBuscarPrestamista";
            txtBuscarPrestamista.Size = new Size(202, 29);
            txtBuscarPrestamista.TabIndex = 11;
            // 
            // panelEstado
            // 
            panelEstado.Controls.Add(btnBuscarEstado);
            panelEstado.Controls.Add(btnCerrarEstado);
            panelEstado.Controls.Add(dataGridViewEstado);
            panelEstado.Controls.Add(txtBuscarEstado);
            panelEstado.Location = new Point(1065, 489);
            panelEstado.Name = "panelEstado";
            panelEstado.Size = new Size(276, 235);
            panelEstado.TabIndex = 21;
            panelEstado.Visible = false;
            // 
            // btnBuscarEstado
            // 
            btnBuscarEstado.Location = new Point(208, 12);
            btnBuscarEstado.Name = "btnBuscarEstado";
            btnBuscarEstado.Size = new Size(25, 23);
            btnBuscarEstado.TabIndex = 17;
            btnBuscarEstado.UseVisualStyleBackColor = true;
            btnBuscarEstado.Click += btnBuscarEstado_Click;
            // 
            // btnCerrarEstado
            // 
            btnCerrarEstado.Location = new Point(237, 12);
            btnCerrarEstado.Name = "btnCerrarEstado";
            btnCerrarEstado.Size = new Size(25, 23);
            btnCerrarEstado.TabIndex = 20;
            btnCerrarEstado.UseVisualStyleBackColor = true;
            btnCerrarEstado.Click += btnCerrarEstado_Click;
            // 
            // dataGridViewEstado
            // 
            dataGridViewEstado.AllowUserToAddRows = false;
            dataGridViewEstado.AllowUserToDeleteRows = false;
            dataGridViewEstado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEstado.Location = new Point(0, 60);
            dataGridViewEstado.Name = "dataGridViewEstado";
            dataGridViewEstado.ReadOnly = true;
            dataGridViewEstado.Size = new Size(276, 177);
            dataGridViewEstado.TabIndex = 16;
            dataGridViewEstado.DoubleClick += dataGridViewEstado_DoubleClick;
            // 
            // txtBuscarEstado
            // 
            txtBuscarEstado.Font = new Font("Segoe UI", 12F);
            txtBuscarEstado.Location = new Point(3, 8);
            txtBuscarEstado.Name = "txtBuscarEstado";
            txtBuscarEstado.Size = new Size(202, 29);
            txtBuscarEstado.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Thistle;
            btnCancelar.Font = new Font("Baskerville Old Face", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(12, 667);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(172, 50);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Salir";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // NuevoPrestamo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(251, 246, 255);
            ClientSize = new Size(1350, 729);
            Controls.Add(btnCancelar);
            Controls.Add(panelEstado);
            Controls.Add(panelPrestamista);
            Controls.Add(panelPrestatario);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "NuevoPrestamo";
            Text = "NuevoPréstamo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelPrestatario.ResumeLayout(false);
            panelPrestatario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestatario).EndInit();
            panelPrestamista.ResumeLayout(false);
            panelPrestamista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrestamista).EndInit();
            panelEstado.ResumeLayout(false);
            panelEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEstado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDevolucionPréstamo;
        private TextBox txtFechaPréstamo;
        private Label label8;
        private Label label7;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private Label label9;
        private Button btnNuevoPrestamo;
        private TextBox txtEstadoPréstamo;
        private TextBox txtPrestamistaPréstamo;
        private TextBox txtPrestatarioPréstamo;
        private TextBox txEquipoPréstamo;
        private Button btnEstado;
        private Button btnPrestatario;
        private Button btnPrestamista;
        private Button btnBuscarPrestatario;
        private TextBox txtBuscarPrestatario;
        private Panel panelPrestatario;
        private Button btnCerrarPrestatario;
        private DataGridView dataGridViewPrestatario;
        private Panel panelPrestamista;
        private Button btnBuscarPrestamista;
        private Button btnCerrarPrestamista;
        private DataGridView dataGridViewPrestamista;
        private TextBox txtBuscarPrestamista;
        private Panel panelEstado;
        private Button btnBuscarEstado;
        private Button btnCerrarEstado;
        private DataGridView dataGridViewEstado;
        private TextBox txtBuscarEstado;
        private Button btnCancelar;
        private Button btnNuevoEstado;
        private Button btnNuevoPrestatario;
        private Button btnNuevoPrestamista;
    }
}