using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Modelos
{
    public class CampoClase: Resultados
    {
        public string nro { get; set; }
        public string descripcion { get; set; }
        public string campo { get; set; }
        public string tipo { get; set; }
        public string longitud { get; set; }
        public string dec { get; set; }
        public string clave { get; set; }
        public string req { get; set; }
        public string default_value { get; set; }
        
    }
    public class Resultados
    {
        public string Tipo_Resultado { get; set; }
        public string Abr_tipo_Resultado { get; set; }
        public string Abr_sigla_Resultado { get; set; }
        public string Variable_Resultado { get; set; }
        public string Parametro_Resultado { get; set; }
    }
}
