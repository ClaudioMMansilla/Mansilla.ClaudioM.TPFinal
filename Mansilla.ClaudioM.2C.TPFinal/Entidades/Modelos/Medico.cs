using Entidades.DataBase;
using Entidades.Delegados;
using Entidades.Enum;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Medico : Persona, IEmergencia<Paciente>
    {
        public event DelegadoColaMedicos OnMedicos;
        private int matricula;

        public Medico() { }
        public Medico(string nombre, string apellido, int dni, DateTime fechaNac)
            : base(nombre, apellido, dni, fechaNac) { }

        public int Matricula { get => matricula; set => matricula = value; }

        public bool Amputar(Paciente param)
        {
            if(param is not null)
            { 
                param.Tratamiento = "Miembro Amputado";
                return true;
            }
            return false;
        }

        public bool Suturar(Paciente param)
        {
            if (param is not null)
            {
                param.Tratamiento = "Herida Suturada";
                return true;
            }
            return false;
        }

        public bool TratarQuemadura(Paciente param)
        {
            if (param is not null)
            {
                param.Tratamiento = "Quemadura curada";
                return true;
            }
            return false;
        }

        public bool Vendar(Paciente param)
        {
            if (param is not null)
            {
                param.Tratamiento = "Herida vendada";
                return true;
            }
            return false;
        }

        public void GetMedicos()
        {
            if (this.OnMedicos is not null)
            {
                this.OnMedicos.Invoke(ADOMedicos.GetMedicos());
            }
        }

        public bool Atender(Paciente paciente)
        {
            Random rd = new Random();
            switch(rd.Next(1,5))
            {
                case 1:
                    return this.Amputar(paciente); 
                    break;
                case 2:
                    return this.Suturar(paciente);
                    break;
                case 3:
                    return this.TratarQuemadura(paciente);
                    break;
                case 4:
                    return this.Vendar(paciente);
                    break;
                default: return false;
            }

        }
    }
}
