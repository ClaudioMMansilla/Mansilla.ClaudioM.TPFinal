namespace View
{
    partial class ViewPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPaciente));
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblCalendar = new Label();
            cmbGSangre = new ComboBox();
            cmbGFactor = new ComboBox();
            lblGSangre = new Label();
            lblGFactor = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            pcbIcon = new PictureBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCargar = new Button();
            grpBox = new GroupBox();
            rdbtnEliminar = new RadioButton();
            rdbtnActualizar = new RadioButton();
            rdbtnCrear = new RadioButton();
            btnImport = new Button();
            dtPicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pcbIcon).BeginInit();
            grpBox.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(36, 139);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre/s:";
            lblNombre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(36, 174);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(100, 23);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido:";
            lblApellido.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDni
            // 
            lblDni.Location = new Point(36, 208);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(100, 23);
            lblDni.TabIndex = 2;
            lblDni.Text = "D.N.I. :";
            lblDni.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCalendar
            // 
            lblCalendar.Location = new Point(22, 313);
            lblCalendar.Name = "lblCalendar";
            lblCalendar.Size = new Size(127, 23);
            lblCalendar.TabIndex = 3;
            lblCalendar.Text = "Fecha Nacimiento:";
            lblCalendar.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbGSangre
            // 
            cmbGSangre.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGSangre.FormattingEnabled = true;
            cmbGSangre.Location = new Point(155, 243);
            cmbGSangre.Name = "cmbGSangre";
            cmbGSangre.Size = new Size(246, 23);
            cmbGSangre.TabIndex = 4;
            // 
            // cmbGFactor
            // 
            cmbGFactor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGFactor.FormattingEnabled = true;
            cmbGFactor.Location = new Point(155, 278);
            cmbGFactor.Name = "cmbGFactor";
            cmbGFactor.Size = new Size(246, 23);
            cmbGFactor.TabIndex = 5;
            // 
            // lblGSangre
            // 
            lblGSangre.Location = new Point(13, 243);
            lblGSangre.Name = "lblGSangre";
            lblGSangre.Size = new Size(123, 23);
            lblGSangre.TabIndex = 6;
            lblGSangre.Text = "Grupo Sanguíneo:";
            lblGSangre.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblGFactor
            // 
            lblGFactor.Location = new Point(36, 278);
            lblGFactor.Name = "lblGFactor";
            lblGFactor.Size = new Size(100, 23);
            lblGFactor.TabIndex = 7;
            lblGFactor.Text = " Sangre Factor:";
            lblGFactor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(155, 139);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(246, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(155, 174);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(246, 23);
            txtApellido.TabIndex = 9;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(155, 208);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "Campo obligatorio";
            txtDni.Size = new Size(246, 23);
            txtDni.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(326, 481);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(103, 481);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(22, 481);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(75, 23);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // pcbIcon
            // 
            pcbIcon.Image = (Image)resources.GetObject("pcbIcon.Image");
            pcbIcon.InitialImage = null;
            pcbIcon.Location = new Point(321, 12);
            pcbIcon.Name = "pcbIcon";
            pcbIcon.Size = new Size(80, 103);
            pcbIcon.TabIndex = 16;
            pcbIcon.TabStop = false;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(287, 355);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(114, 23);
            btnCargar.TabIndex = 18;
            btnCargar.Text = "Buscar Paciente";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // grpBox
            // 
            grpBox.Controls.Add(rdbtnEliminar);
            grpBox.Controls.Add(rdbtnActualizar);
            grpBox.Controls.Add(rdbtnCrear);
            grpBox.Location = new Point(36, 15);
            grpBox.Name = "grpBox";
            grpBox.Size = new Size(181, 100);
            grpBox.TabIndex = 19;
            grpBox.TabStop = false;
            grpBox.Text = "Seleccionar Acción";
            // 
            // rdbtnEliminar
            // 
            rdbtnEliminar.AutoSize = true;
            rdbtnEliminar.Location = new Point(6, 72);
            rdbtnEliminar.Name = "rdbtnEliminar";
            rdbtnEliminar.Size = new Size(68, 19);
            rdbtnEliminar.TabIndex = 2;
            rdbtnEliminar.TabStop = true;
            rdbtnEliminar.Text = "Eliminar";
            rdbtnEliminar.UseVisualStyleBackColor = true;
            // 
            // rdbtnActualizar
            // 
            rdbtnActualizar.AutoSize = true;
            rdbtnActualizar.Location = new Point(6, 47);
            rdbtnActualizar.Name = "rdbtnActualizar";
            rdbtnActualizar.Size = new Size(77, 19);
            rdbtnActualizar.TabIndex = 1;
            rdbtnActualizar.TabStop = true;
            rdbtnActualizar.Text = "Actualizar";
            rdbtnActualizar.UseVisualStyleBackColor = true;
            // 
            // rdbtnCrear
            // 
            rdbtnCrear.AutoSize = true;
            rdbtnCrear.Location = new Point(6, 22);
            rdbtnCrear.Name = "rdbtnCrear";
            rdbtnCrear.Size = new Size(98, 19);
            rdbtnCrear.TabIndex = 0;
            rdbtnCrear.TabStop = true;
            rdbtnCrear.Text = "Alta/Creación";
            rdbtnCrear.UseVisualStyleBackColor = true;
            // 
            // btnImport
            // 
            btnImport.Location = new Point(22, 355);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(156, 23);
            btnImport.TabIndex = 20;
            btnImport.Text = "Importar desde archivo";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // dtPicker
            // 
            dtPicker.Location = new Point(155, 313);
            dtPicker.Name = "dtPicker";
            dtPicker.Size = new Size(246, 23);
            dtPicker.TabIndex = 21;
            // 
            // ViewPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 564);
            Controls.Add(dtPicker);
            Controls.Add(btnImport);
            Controls.Add(grpBox);
            Controls.Add(btnCargar);
            Controls.Add(pcbIcon);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblGFactor);
            Controls.Add(lblGSangre);
            Controls.Add(cmbGFactor);
            Controls.Add(cmbGSangre);
            Controls.Add(lblCalendar);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Name = "ViewPaciente";
            Text = "Información: PACIENTES";
            Load += ViewPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)pcbIcon).EndInit();
            grpBox.ResumeLayout(false);
            grpBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblCalendar;
        private ComboBox cmbGSangre;
        private ComboBox cmbGFactor;
        private Label lblGSangre;
        private Label lblGFactor;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnVolver;
        private PictureBox pcbIcon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnCargar;
        private GroupBox grpBox;
        private RadioButton rdbtnEliminar;
        private RadioButton rdbtnActualizar;
        private RadioButton rdbtnCrear;
        private Button btnImport;
        private DateTimePicker dtPicker;
    }
}