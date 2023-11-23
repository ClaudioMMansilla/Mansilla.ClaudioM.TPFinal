using Entidades.Archivos;
using Entidades.DataBase;
using Entidades.Enum;
using Entidades.Excepciones;
using Entidades.MetodosExtencion;
using Entidades.Modelos;
using Entidades.Delegados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{
    public partial class ViewPaciente : Form
    {
        public event DelegadoPacienteDni OnIngresoDni;
        public event DelegadoABM OnCrear;
        public event DelegadoABM OnActualizar;
        public event DelegadoABM OnEliminar;

        private Paciente paciente;
        public ViewPaciente()
        {
            InitializeComponent();
            this.InicializarComboBoxes();
            this.paciente = new Paciente();
        }


        private void ViewPaciente_Load(object sender, EventArgs e)
        {
            this.rdbtnCrear.Checked = false;
            this.rdbtnActualizar.Checked = false;
            this.rdbtnEliminar.Checked = false;
            this.paciente.OnPaciente += CargarCamposView;
            this.OnIngresoDni += this.paciente.RecibirDni;
            this.OnCrear += this.paciente.GuardarPaciente;
            this.OnActualizar += this.paciente.ActualizarPaciente;
            this.OnEliminar += this.paciente.EliminarPaciente;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (this.OnIngresoDni is not null)
            {
                this.OnIngresoDni.Invoke(this.txtDni.Text);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
            try
            {
                this.paciente = FileManager<Paciente>.ImportarArchivo();
                this.CargarCamposView(this.paciente);
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                MessageBox.Show(msg, "Error al leer archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.LeerCampos();
            if (this.rdbtnCrear.Checked == true)
            {
                try
                {
                    if (this.OnCrear is not null && this.OnCrear.Invoke(this.paciente)) 
                    { MessageBox.Show("Paciente guardado correctamente", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            if (this.rdbtnActualizar.Checked == true)
            {
                try
                {
                    if (this.OnActualizar is not null && this.OnActualizar.Invoke(this.paciente))
                    { MessageBox.Show("Paciente actualizado correctamente", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            if (this.rdbtnEliminar.Checked == true)
            {
                try
                {
                    if (this.OnEliminar is not null && this.OnEliminar.Invoke(this.paciente)) 
                    { MessageBox.Show("Paciente eliminado correctamente", "Proceso Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            this.LimpiarCampos();
        }


        private void InicializarComboBoxes()
        {
            foreach (var item in Enum.GetValues(typeof(ESangreGrupo)))
            {
                this.cmbGSangre.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(ESangreFactor)))
            {
                this.cmbGFactor.Items.Add(item);
            }
        }


        private void CargarCamposView(Paciente p)
        {
            this.cmbGSangre.Items.Clear();
            this.cmbGFactor.Items.Clear();
            this.txtNombre.Text = p.Nombre;
            this.txtApellido.Text = p.Apellido;
            this.txtDni.Text = p.Dni.ToString();
            if (p.SangreGrupo is not null && p.SangreFactor is not null)
            {
                this.cmbGSangre.Items.Add(p.SangreGrupo);
                this.cmbGSangre.SelectedIndex = 0;
                this.cmbGFactor.Items.Add(p.SangreFactor);
                this.cmbGFactor.SelectedIndex = 0;
                this.dtPicker.Value = p.FechaNac;
            }
        }


        private void LimpiarCampos()
        {
            this.paciente = new Paciente();
            this.cmbGSangre.Items.Clear();
            this.cmbGFactor.Items.Clear();
            InicializarComboBoxes();
            this.txtNombre.Text = String.Empty;
            this.txtApellido.Text = String.Empty;
            this.txtDni.Text = String.Empty;
            this.rdbtnCrear.Checked = false;
            this.rdbtnActualizar.Checked = false;
            this.rdbtnEliminar.Checked = false;
        }

        private void LeerCampos()
        {
            if (!string.IsNullOrWhiteSpace(this.txtDni.Text)
                && !string.IsNullOrWhiteSpace(this.txtNombre.Text)
                && !string.IsNullOrWhiteSpace(this.txtApellido.Text)
                && !string.IsNullOrWhiteSpace(this.cmbGSangre.Text)
                && !string.IsNullOrWhiteSpace(this.cmbGFactor.Text)
                )
            {
                this.paciente = new Paciente(
                    this.txtNombre.Text,
                    this.txtApellido.Text,
                    this.txtDni.Text.CastearStrToInt(),
                    this.dtPicker.Value,
                    this.cmbGSangre.Text,
                    this.cmbGFactor.Text
                    );
            }
            else { MessageBox.Show("Verique campos, no pueden ingresarse campos vacíos", "Validación de formulario", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }

    }
}
