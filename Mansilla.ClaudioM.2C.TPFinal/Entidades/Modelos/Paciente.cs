using Entidades.DataBase;
using Entidades.Enum;
using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.MetodosExtencion;
using Entidades.Delegados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Paciente : Persona, IAtencion
    {
        public event DelegadoDBCargarPaciente OnPaciente;
        public event DelegadoColaPacientes OnColaEspera;

        private string sangreGrupo;
        private string sangreFactor;
        private string causaHerida;
        private string tratamiento;

        public Paciente() { }
        public Paciente(string nombre, string apellido, int dni, DateTime fechaNac)
            : base (nombre, apellido, dni, fechaNac) { }

        public Paciente(string nombre, string apellido, int dni, DateTime fechaNac, 
            string sangreGrupo, string sangreFactor)
            : this(nombre, apellido, dni, fechaNac)
        {
            SangreGrupo = sangreGrupo;
            SangreFactor = sangreFactor;
        }

        public string SangreGrupo { get => sangreGrupo; set => sangreGrupo = value; }
        public string SangreFactor { get => sangreFactor; set => sangreFactor = value; }
        public string Tratamiento { get => tratamiento; set => tratamiento = value; }
        public string CausaHerida { get => causaHerida; set => causaHerida = value; }

        public void RecibirDni(string dniStr)
        {
            int dni = dniStr.CastearStrToInt();
            this.CargarPaciente(dni);
        }

        private void CargarPaciente(int dni)
        {
            Paciente paciente = new Paciente();
            try
            {
                paciente = ADOPacientes.GetPacienteByDni(dni);
            }
            catch (Exception ex) { }
            
            if(this.OnPaciente is not null)
            {
                this.OnPaciente.Invoke(paciente);
            }
        }

        public Paciente BuscarPacienteDB(string dniStr)
        {
            Paciente paciente = new Paciente();

            try
            {
                paciente = ADOPacientes.GetPacienteByDni(dniStr.CastearStrToInt());
            }
            catch (Exception ex) { }
            return paciente;
        }

        public bool GuardarPaciente(Paciente paciente)
        {
            return ADOPacientes.InsertPaciente(paciente);
        }

        public bool ActualizarPaciente(Paciente paciente)
        {
            return ADOPacientes.UpdatePaciente(paciente);
        }
        public bool EliminarPaciente(Paciente paciente)
        {
            return ADOPacientes.DeletePaciente(paciente);
        }

        public void GetColaPacientes()
        {
            if (this.OnColaEspera is not null)
            {
                try 
                {
                    this.OnColaEspera.Invoke(ADOPacientes.GetQueuePacientes((int)EEstadoAtencion.Pendiente));
                } catch (Exception ex) { }
            }
        }

    }
}
