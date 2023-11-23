using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Interfaces
{
    public interface IEmergencia<T> where T: class, new() 
    {
        public bool TratarQuemadura(T param); 
        public bool Vendar(T param);
        public bool Suturar(T param);
        public bool Amputar(T param);
    }
}
