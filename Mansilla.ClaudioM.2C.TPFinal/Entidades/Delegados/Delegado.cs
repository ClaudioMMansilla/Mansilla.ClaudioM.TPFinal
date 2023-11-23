using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Delegados
{
    public delegate void DelegadoVoid();
    public delegate void DelegadoDBCargarPaciente(Paciente p);
    public delegate void DelegadoPacienteDni(string dniStr);
    public delegate bool DelegadoABM(Paciente p);
    public delegate void DelegadoColaPacientes(Queue<Paciente> cola);
    public delegate void DelegadoColaMedicos(Queue<Medico> cola);
}
