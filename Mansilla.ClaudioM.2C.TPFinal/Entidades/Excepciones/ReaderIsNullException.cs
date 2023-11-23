using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excepciones
{
    public class ReaderIsNullException : Exception
    {
        public ReaderIsNullException(string? message) : base(message)
        {
        }

        public ReaderIsNullException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
