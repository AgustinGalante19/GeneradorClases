using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Modelos
{
	public class Constant 
	{ 
		public string alcance { get; set; }
		public string tipo { get; set; }
		public string nombre { get; set; }
		public string valor { get; set; }
	}
	public class CVM_Constant
	{
		public List<Constant> Constantes { get; set; }
	}
}
