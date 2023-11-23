using Entidades.DataBase;
using Entidades.Delegados;
using Entidades.Enum;
using Entidades.MetodosExtencion;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ViewAdmisionGuardia : Form
    {
        public event DelegadoPacienteDni OnIngresoDni;
        public event DelegadoVoid OnCargar;
        public event DelegadoABM OnGuardar;

        private ColaEspera<Paciente> colaEspera;
        private Paciente paciente;

        public ViewAdmisionGuardia()
        {
            InitializeComponent();
            this.paciente = new Paciente();
            this.colaEspera = new ColaEspera<Paciente>();
        }


        private void ViewAdmisionGuardia_Load(object sender, EventArgs e)
        {
            this.InitializeComboBox();

            this.OnIngresoDni += this.paciente.RecibirDni;
            this.OnGuardar += this.colaEspera.EnqueuePacienteDB;
            this.paciente.OnPaciente += this.NuevoPaciente;
            this.paciente.OnPaciente += this.ImprimirDatos;
            this.paciente.OnColaEspera += this.CargarListBoxColaPacientes;
            this.OnCargar += this.paciente.GetColaPacientes;
            this.OnCargar.Invoke();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.OnIngresoDni is not null)
            {
                this.OnIngresoDni.Invoke(this.txtDni.Text);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.AgregarPaciente();
        }

        private void CargarListBoxColaPacientes(Queue<Paciente> cola)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(() => this.CargarListBoxColaPacientes(cola));
            }
            else
            {
                if (cola.Count > 0) { this.colaEspera = new ColaEspera<Paciente>(cola); }
                foreach (Paciente p in cola)
                {
                    this.lstbxColaPaciente.Items.Add(this.DatosPaciente(p));
                }
            }
        }

        private void CargarPacienteEnListBox(Paciente p)
        {
            this.lstbxColaPaciente.Items.Add(this.DatosPaciente(p));
        }

        private void InitializeComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(EPirotecnia)))
            {
                this.cmboxPirotecnia.Items.Add(item);
            }
        }

        private string DatosPaciente(Paciente p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{p.Apellido},{p.Nombre} - Edad: {p.CalcularEdad()} - Sangre:{p.SangreGrupo} {p.SangreFactor} - Herida: {p.CausaHerida}");
            return sb.ToString();
        }

        private void ImprimirDatos(Paciente p)
        {
            this.txtInfoPaciente.Text = this.DatosPaciente(p);
        }

        private void LimpiarCampos()
        {
            this.txtDni.Text = string.Empty;
            this.txtInfoPaciente.Text = string.Empty;
            this.paciente = new Paciente();
            this.cmboxPirotecnia.SelectedItem = string.Empty;
        }

        private void NuevoPaciente(Paciente p)
        {
            if (p is not null)
            {
                this.paciente = p;
            }
        }

        private void AgregarPaciente()
        {
            if (this.paciente is not null && this.paciente.Dni > 0)
            {
                this.paciente.CausaHerida = this.cmboxPirotecnia.Text;
                this.colaEspera.NuevaPersona = this.paciente;
                this.CargarPacienteEnListBox(this.paciente);
                this.OnGuardar.Invoke(this.paciente);
                this.LimpiarCampos();
            }
        }

    }
}
