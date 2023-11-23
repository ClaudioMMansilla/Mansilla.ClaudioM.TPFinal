namespace Entidades.Modelos
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private DateTime fechaNac;

        public Persona() { }

        public Persona (string nombre, string apellido, int dni, DateTime fechaNac)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.FechaNac = fechaNac;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }

        public static bool operator ==(Persona p1, Persona p2)
        {
            return (p1.dni == p2.dni);
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}