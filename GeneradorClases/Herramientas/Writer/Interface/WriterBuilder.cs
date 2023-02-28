using GeneradorClases.Herramientas.Writer.Interface;
using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas
{
	public class WriterBuilder : IJsonWriterBuilder, IClassName, ISerializeBuilder, ISerializeProperties
	{

		public IClassName AddClassName(string name)
		{
			throw new NotImplementedException();
		}

		public void SerializeConstants(List<CVM_Constant> constants)
		{
			throw new NotImplementedException();
		}

		public ISerializeBuilder SerializeMethods(List<CVM_Method> methods)
		{
			throw new NotImplementedException();
		}

		public ISerializeProperties SerializeProperties(List<CVM_Propertie> properties)
		{
			throw new NotImplementedException();
		}

		string ISerializeProperties.SerializeConstants(List<CVM_Constant> constants)
		{
			throw new NotImplementedException();
		}
	}
}
