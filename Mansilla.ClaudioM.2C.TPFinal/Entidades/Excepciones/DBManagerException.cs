using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class DBManagerException : Exception
    {
        public DBManagerException(string? message) : base(message)
        {
        }

        public DBManagerException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
