using Entidades.Enum;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IAtencion
    {
        public string SangreGrupo { get; set; }
        public string SangreFactor { get; set; }
        public string Tratamiento { get; set; }
        public string CausaHerida { get; set; }
    }
}
