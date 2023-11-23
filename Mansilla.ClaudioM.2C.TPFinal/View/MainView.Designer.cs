namespace View
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            lblBienvenida = new Label();
            btnPacienteABM = new Button();
            pictureBox1 = new PictureBox();
            btnExportar = new Button();
            btnAdmGuardia = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            btnAtencionGuardia = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(40, 5);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(107, 23);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Administración";
            // 
            // btnPacienteABM
            // 
            btnPacienteABM.Location = new Point(8, 37);
            btnPacienteABM.Name = "btnPacienteABM";
            btnPacienteABM.Size = new Size(164, 23);
            btnPacienteABM.TabIndex = 1;
            btnPacienteABM.Text = "ABM Paciente";
            btnPacienteABM.UseVisualStyleBackColor = true;
            btnPacienteABM.Click += btnPacienteABM_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(114, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 78);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(8, 66);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(164, 23);
            btnExportar.TabIndex = 5;
            btnExportar.Text = "Exportar Paciente";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // btnAdmGuardia
            // 
            btnAdmGuardia.Location = new Point(8, 3);
            btnAdmGuardia.Name = "btnAdmGuardia";
            btnAdmGuardia.Size = new Size(164, 23);
            btnAdmGuardia.TabIndex = 6;
            btnAdmGuardia.Text = "Admisión Guardia";
            btnAdmGuardia.UseVisualStyleBackColor = true;
            btnAdmGuardia.Click += btnAdmGuardia_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 294);
            label1.Name = "label1";
            label1.Size = new Size(103, 37);
            label1.TabIndex = 10;
            label1.Text = "GUARDIA";
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.IBeam;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(77, 281);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(54, 50);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnAtencionGuardia
            // 
            btnAtencionGuardia.Location = new Point(8, 32);
            btnAtencionGuardia.Name = "btnAtencionGuardia";
            btnAtencionGuardia.Size = new Size(164, 23);
            btnAtencionGuardia.TabIndex = 12;
            btnAtencionGuardia.Text = "Atención de Pacientes";
            btnAtencionGuardia.UseVisualStyleBackColor = true;
            btnAtencionGuardia.Click += btnAtencionGuardia_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Controls.Add(btnPacienteABM);
            panel1.Controls.Add(lblBienvenida);
            panel1.Controls.Add(btnExportar);
            panel1.Location = new Point(61, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(179, 99);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnAdmGuardia);
            panel2.Controls.Add(btnAtencionGuardia);
            panel2.Location = new Point(61, 337);
            panel2.Name = "panel2";
            panel2.Size = new Size(179, 61);
            panel2.TabIndex = 14;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 475);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "MainView";
            Text = "Hospital del Quemado";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblBienvenida;
        private Button btnPacienteABM;
        private PictureBox pictureBox1;
        private Button btnExportar;
        private Button btnAdmGuardia;
        private Label label1;
        private PictureBox pictureBox2;
        private Button btnAtencionGuardia;
        private Panel panel1;
        private Panel panel2;
    }
}