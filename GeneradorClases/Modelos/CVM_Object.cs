using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Modelos
{
    public class Object {
        public string alcance { get; set; }
        public string tipo { get; set; }
        public string nombre { get; set; }
        public string valor { get; set;}
    }

    public class CVM_Object
    {
        public List<Object> objetos { get; set; }   
    }
}
