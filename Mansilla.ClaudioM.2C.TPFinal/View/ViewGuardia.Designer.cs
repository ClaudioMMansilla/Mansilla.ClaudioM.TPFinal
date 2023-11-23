namespace View
{
    partial class ViewGuardia
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
            btnComenzar = new Button();
            btnDetener = new Button();
            txtBoxPacienteProx = new TextBox();
            lblProxPaciente = new Label();
            lblPacienteActual = new Label();
            txtBoxPacienteActual = new TextBox();
            LblTratamiento = new Label();
            lblMedicoActual = new Label();
            txtMedico = new TextBox();
            txtUltimoPaciente = new TextBox();
            SuspendLayout();
            // 
            // btnComenzar
            // 
            btnComenzar.Location = new Point(12, 2);
            btnComenzar.Name = "btnComenzar";
            btnComenzar.Size = new Size(90, 23);
            btnComenzar.TabIndex = 0;
            btnComenzar.Text = "Simular";
            btnComenzar.UseVisualStyleBackColor = true;
            btnComenzar.Click += btnComenzar_Click;
            // 
            // btnDetener
            // 
            btnDetener.Location = new Point(108, 2);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(90, 23);
            btnDetener.TabIndex = 1;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = true;
            btnDetener.Click += btnDetener_Click;
            // 
            // txtBoxPacienteProx
            // 
            txtBoxPacienteProx.Location = new Point(12, 82);
            txtBoxPacienteProx.Name = "txtBoxPacienteProx";
            txtBoxPacienteProx.Size = new Size(570, 23);
            txtBoxPacienteProx.TabIndex = 2;
            // 
            // lblProxPaciente
            // 
            lblProxPaciente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblProxPaciente.Location = new Point(12, 61);
            lblProxPaciente.Name = "lblProxPaciente";
            lblProxPaciente.Size = new Size(124, 18);
            lblProxPaciente.TabIndex = 4;
            lblProxPaciente.Text = "Próximo Paciente:";
            // 
            // lblPacienteActual
            // 
            lblPacienteActual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPacienteActual.ForeColor = SystemColors.MenuHighlight;
            lblPacienteActual.Location = new Point(12, 122);
            lblPacienteActual.Name = "lblPacienteActual";
            lblPacienteActual.Size = new Size(124, 18);
            lblPacienteActual.TabIndex = 6;
            lblPacienteActual.Text = "Paciente Actual:";
            // 
            // txtBoxPacienteActual
            // 
            txtBoxPacienteActual.Location = new Point(12, 143);
            txtBoxPacienteActual.Name = "txtBoxPacienteActual";
            txtBoxPacienteActual.Size = new Size(570, 23);
            txtBoxPacienteActual.TabIndex = 7;
            // 
            // LblTratamiento
            // 
            LblTratamiento.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            LblTratamiento.ForeColor = Color.FromArgb(192, 0, 0);
            LblTratamiento.Location = new Point(108, 273);
            LblTratamiento.Name = "LblTratamiento";
            LblTratamiento.Size = new Size(319, 32);
            LblTratamiento.TabIndex = 8;
            LblTratamiento.Text = "Ultimo Paciente Atendido";
            // 
            // lblMedicoActual
            // 
            lblMedicoActual.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMedicoActual.Location = new Point(12, 181);
            lblMedicoActual.Name = "lblMedicoActual";
            lblMedicoActual.Size = new Size(124, 18);
            lblMedicoActual.TabIndex = 10;
            lblMedicoActual.Text = "Atendido por:";
            // 
            // txtMedico
            // 
            txtMedico.Location = new Point(12, 202);
            txtMedico.Name = "txtMedico";
            txtMedico.Size = new Size(570, 23);
            txtMedico.TabIndex = 11;
            // 
            // txtUltimoPaciente
            // 
            txtUltimoPaciente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUltimoPaciente.ForeColor = Color.FromArgb(192, 0, 0);
            txtUltimoPaciente.Location = new Point(12, 308);
            txtUltimoPaciente.Name = "txtUltimoPaciente";
            txtUltimoPaciente.Size = new Size(570, 25);
            txtUltimoPaciente.TabIndex = 12;
            // 
            // ViewGuardia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 416);
            Controls.Add(txtUltimoPaciente);
            Controls.Add(txtMedico);
            Controls.Add(lblMedicoActual);
            Controls.Add(LblTratamiento);
            Controls.Add(txtBoxPacienteActual);
            Controls.Add(lblPacienteActual);
            Controls.Add(lblProxPaciente);
            Controls.Add(txtBoxPacienteProx);
            Controls.Add(btnDetener);
            Controls.Add(btnComenzar);
            Name = "ViewGuardia";
            Text = "ViewGuardia";
            Load += ViewGuardia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComenzar;
        private Button btnDetener;
        private TextBox txtBoxPacienteProx;
        private Label lblProxPaciente;
        private Label lblPacienteActual;
        private TextBox txtBoxPacienteActual;
        private Label LblTratamiento;
        private Label lblMedicoActual;
        private TextBox txtMedico;
        private TextBox txtUltimoPaciente;
    }
}