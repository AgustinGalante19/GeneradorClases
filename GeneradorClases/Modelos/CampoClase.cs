using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

		public List<CampoClase> GetEmptList()
		{
			List<CampoClase> lst_campo= new List<CampoClase>();

            lst_campo.Add(new CampoClase());
			lst_campo.Add(new CampoClase());
			return lst_campo;
		}
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
