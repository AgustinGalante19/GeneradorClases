using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorClases.Herramientas.Writer.Interface
{
	public interface IJsonWriterBuilder
	{
		IClassName AddClassName(string name);		
	}
	public interface IClassName
	{
		ISerializeBuilder SerializeMethods(List<CVM_Method> methods);
	}
	public interface ISerializeBuilder
	{
		ISerializeProperties SerializeProperties(List<CVM_Propertie> properties);
	}
	public interface ISerializeProperties
	{
		string SerializeConstants(List<CVM_Constant> constants);
	}

}
