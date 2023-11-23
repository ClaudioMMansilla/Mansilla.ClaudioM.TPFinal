using Entidades.Delegados;
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
    public partial class ViewGuardia : Form
    {
        public event DelegadoVoid OnCargarMedicos;
        public event DelegadoVoid OnCargarPacientes;
        public event DelegadoABM OnGuardar;
        public event DelegadoABM OnAtender;

        private CancellationTokenSource cancellation;
        private ColaEspera<Paciente> colaEspera;
        private ColaEspera<Medico> medicos;
        private Medico medico;
        private Paciente pacienteActual;
        private Paciente pacienteProximo;

        public ViewGuardia()
        {
            InitializeComponent();
            this.medico = new Medico();
            this.colaEspera = new ColaEspera<Paciente>();
            this.medicos = new ColaEspera<Medico>();
            this.pacienteActual = new Paciente();
            this.pacienteProximo = new Paciente();
        }

        private void ViewGuardia_Load(object sender, EventArgs e)
        {
            this.OnCargarMedicos += this.medico.GetMedicos;
            this.OnCargarPacientes += this.pacienteActual.GetColaPacientes;
            this.OnAtender += this.medico.Atender;
            this.medico.OnMedicos += InicializarColaMedicos;
            this.pacienteActual.OnColaEspera += InicializarColaPacientes;

            this.OnCargarMedicos.Invoke();
            this.OnCargarPacientes.Invoke();
        }
        private void btnComenzar_Click(object sender, EventArgs e)
        {
            this.Simular();
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.cancellation.Cancel();
        }

        private void InicializarColaMedicos(Queue<Medico> medicos)
        {
            if (medicos is not null) { this.medicos = new ColaEspera<Medico>(medicos); }
        }

        private void InicializarColaPacientes(Queue<Paciente> pacientes)
        {
            if (pacientes.Count > 0)
            { this.colaEspera = new ColaEspera<Paciente>(pacientes); }
        }


        private void ImprimirProxPaciente()
        {
            if (this.InvokeRequired) { this.BeginInvoke(() => this.ImprimirProxPaciente()); }
            else
            {
                this.txtBoxPacienteProx.Text = this.DatosPaciente(this.pacienteProximo);
            }
        }

        private void ImprimirPacienteActual()
        {
            if (this.InvokeRequired) { this.BeginInvoke(() => this.ImprimirPacienteActual()); }
            else
            {
                this.txtBoxPacienteActual.Text = this.DatosPaciente(this.pacienteActual);
            }
        }

        private void ImprimirMedicoActual()
        {
            if (this.InvokeRequired) { this.BeginInvoke(() => this.ImprimirMedicoActual()); }
            else
            {
                this.txtMedico.Text = $"{this.medico.Apellido}, {this.medico.Nombre} - Matricula n° {this.medico.Matricula}";
            }
        }

        private void ImprimirUltimoPaciente()
        {
            if (this.InvokeRequired) { this.BeginInvoke(() => this.ImprimirUltimoPaciente()); }
            else
            {
                this.txtUltimoPaciente.Text = $"{this.DatosPaciente(this.pacienteActual)} - Tratamiento: {this.pacienteActual.Tratamiento}";
            }
        }

        private string DatosPaciente(Paciente p)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{p.Apellido},{p.Nombre} - Herida: {p.CausaHerida}");
            return sb.ToString();
        }


        private void Simular()
        {
            Task.Run(() =>
            {
                this.cancellation = new CancellationTokenSource();

                while (!this.colaEspera.ColaIsEmpty() && !this.cancellation.IsCancellationRequested)
                {
                    this.pacienteProximo = this.colaEspera.VerProximaPersona;
                    this.ImprimirProxPaciente();
                    Thread.Sleep(5000);

                    this.pacienteActual = this.colaEspera.ProximaPersona;
                    this.pacienteProximo = this.colaEspera.VerProximaPersona;
                    this.medico = this.medicos.ProximaPersona;
                    this.medicos.NuevaPersona = this.medico;
                    this.ImprimirProxPaciente();
                    this.ImprimirPacienteActual();
                    this.ImprimirMedicoActual();

                    this.OnAtender.Invoke(this.pacienteActual);
                    this.ImprimirUltimoPaciente();
                    this.colaEspera.DequeuePacienteDB(this.pacienteActual, this.medico);
                }
            });


        }
    }
}
