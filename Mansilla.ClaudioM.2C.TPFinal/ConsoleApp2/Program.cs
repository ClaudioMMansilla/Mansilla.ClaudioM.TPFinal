using Entidades.DataBase;
using Entidades.Modelos;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Paciente> cola = ADOPacientes.GetQueuePacientes(1);

            Console.WriteLine(cola.Count);

        }
    }
}