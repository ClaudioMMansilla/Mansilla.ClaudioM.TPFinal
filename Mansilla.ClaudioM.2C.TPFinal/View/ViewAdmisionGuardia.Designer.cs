namespace View
{
    partial class ViewAdmisionGuardia
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
            txtDni = new TextBox();
            txtInfoPaciente = new TextBox();
            btnBuscar = new Button();
            btnAgregar = new Button();
            lstbxColaPaciente = new ListBox();
            lblCola = new Label();
            cmboxPirotecnia = new ComboBox();
            SuspendLayout();
            // 
            // txtDni
            // 
            txtDni.Location = new Point(26, 12);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Ingrese DNI";
            txtDni.Size = new Size(122, 23);
            txtDni.TabIndex = 0;
            // 
            // txtInfoPaciente
            // 
            txtInfoPaciente.Enabled = false;
            txtInfoPaciente.Location = new Point(26, 41);
            txtInfoPaciente.Name = "txtInfoPaciente";
            txtInfoPaciente.Size = new Size(366, 23);
            txtInfoPaciente.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(154, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar Paciente";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(527, 41);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lstbxColaPaciente
            // 
            lstbxColaPaciente.FormattingEnabled = true;
            lstbxColaPaciente.ItemHeight = 15;
            lstbxColaPaciente.Location = new Point(26, 104);
            lstbxColaPaciente.Name = "lstbxColaPaciente";
            lstbxColaPaciente.Size = new Size(576, 334);
            lstbxColaPaciente.TabIndex = 4;
            // 
            // lblCola
            // 
            lblCola.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCola.Location = new Point(187, 77);
            lblCola.Name = "lblCola";
            lblCola.Size = new Size(263, 24);
            lblCola.TabIndex = 5;
            lblCola.Text = "Pacientes en cola de espera";
            // 
            // cmboxPirotecnia
            // 
            cmboxPirotecnia.FormattingEnabled = true;
            cmboxPirotecnia.Location = new Point(398, 41);
            cmboxPirotecnia.Name = "cmboxPirotecnia";
            cmboxPirotecnia.Size = new Size(123, 23);
            cmboxPirotecnia.TabIndex = 6;
            // 
            // ViewAdmisionGuardia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 450);
            Controls.Add(cmboxPirotecnia);
            Controls.Add(lblCola);
            Controls.Add(lstbxColaPaciente);
            Controls.Add(btnAgregar);
            Controls.Add(btnBuscar);
            Controls.Add(txtInfoPaciente);
            Controls.Add(txtDni);
            Name = "ViewAdmisionGuardia";
            Text = "ViewAdmisionGuardia";
            Load += ViewAdmisionGuardia_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDni;
        private TextBox txtInfoPaciente;
        private Button btnBuscar;
        private Button btnAgregar;
        private ListBox lstbxColaPaciente;
        private Label lblCola;
        private ComboBox cmboxPirotecnia;
    }
}