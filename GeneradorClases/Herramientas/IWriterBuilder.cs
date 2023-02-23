using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas
{
	internal interface IWriterBuilder
	{
		void AddClase(string nombre);
		void AddMethod (List<string> lst_metodos);
		void AddProperties();
		void AddVariables();
		void Build();
	}
}
