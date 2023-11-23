using System;
using Entidades.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Entidades.MetodosExtencion
{
    public static class PersonaExtension
    {
        /// <summary>
        /// Calcula la edad de la Persona, restando dos objetos DateTime
        /// </summary>
        /// <param name="persona"> Persona con atributo DateTime </param>
        /// <returns> La edad actual de la persona </returns>
        public static int CalcularEdad(this Persona persona)
        {
            int hoy = DateTime.UtcNow.Year;
            int nac = persona.FechaNac.Year;
            int edad = hoy - nac;
            return edad; 
        }

        public static int CastearStrToInt(this string dniStr)
        {
            if (!string.IsNullOrWhiteSpace(dniStr))
            {
                int dni = 0;
                int.TryParse(dniStr, out dni);
                return dni;
            }
            return 0;
        }

        public static DateTime CastearFechaNac(this string fechaNacStr)
        {
            DateTime fecha = DateTime.MinValue;

            if (DateTime.TryParseExact(fechaNacStr, "MM-dd-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
            {
                return fecha;
            }
            else
            {
                return fecha;
            }
        }

    }
}
