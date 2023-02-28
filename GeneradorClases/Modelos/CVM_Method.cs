using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Modelos
{
	public class CVM_Method
	{
		public List<Metodo> Metodos { get; set; }
	}

	public class Metodo
	{
		public string alcance { get; set; }
		public string nombre { get; set; }
		public string tipo { get; set; }
		public List<Parametro> parametros { get; set; }
		public string contenido { get; set; }
	}

	public class Parametro
	{
		public string tipo { get; set; }
		public string nombre { get; set; }
	}
}
