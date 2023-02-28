using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas.Writer.Interface
{
	public interface IClientBuilder
	{
		 IJsonWriterBuilder CreateFromJson();
		 IManualWriterBuilder CreateFromManualInterface();
	}
}
