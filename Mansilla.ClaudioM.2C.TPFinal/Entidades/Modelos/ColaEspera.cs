using Entidades.DataBase;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class ColaEspera<T> where T : class, new()
    {
        private Queue<T> personasEnCola;
        public ColaEspera()
        {
            this.personasEnCola = new Queue<T>();
        }

        public ColaEspera(Queue<T> cola)
        {
            this.personasEnCola = new Queue<T>(cola);
        }

        public T VerProximaPersona
        {
            get 
            {
                if (this.personasEnCola.Count > 0) { return this.personasEnCola.Peek(); }
                else { return new T(); }
            }
        }

        public bool ColaIsEmpty()
        {
            if (this.personasEnCola.Count == 0) { return true; };
            return false;
        }

        public T ProximaPersona
        {

            get 
            {
                if (this.personasEnCola.Count > 0) { return this.personasEnCola.Dequeue(); }
                else { return new T(); }
            }
        }

        public T NuevaPersona
        {
            set 
            {
                if(!this.personasEnCola.Contains(value)) 
                { 
                    this.personasEnCola.Enqueue(value);
                }
            }
        }


        public bool EnqueuePacienteDB(Paciente paciente)
        {
            try 
            {
                return ADOColaEspera.EnqueuePaciente(paciente);
            } catch(Exception ex) { return false; }

        }

        public bool DequeuePacienteDB(Paciente paciente, Medico medico)
        {
            try
            {
                return ADOColaEspera.DequeuePaciente(paciente, medico);
            }
            catch (Exception ex) { return false; }
        }
    }
}
