using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas
{
	public interface IManualWriterBuilder
	{
		IManualWriterBuilder AddClase(string nombre);
		IManualWriterBuilder AddMethod (List<string> lst_metodos);
		IManualWriterBuilder AddProperties();
		IManualWriterBuilder AddVariables();
	}
}
