using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas
{
	public class Writer
	{
		FileStream fs;
		public Writer(string pathFile) 
		{
			 fs = File.Create(pathFile);								
		}
	
		private void Escribir(string text)
		{
			text += "\n";
			fs.Write(Encoding.ASCII.GetBytes(text),0, Encoding.ASCII.GetBytes(text).Length);
		}

		public void CrearClase(string nombre)
		{
			Escribir("public class " + nombre);
			Escribir("{");				
		}

		public void CrearMetodos(List<string> lst_metodos)
		{
			Escribir("		Metodo1");
			Escribir("		Metodo2");
			Escribir("		Metodo3");
			Escribir("		Metodo4");

			Escribir("-----------");
		}
		
		public void CrearPropiedades()
		{
			Escribir("		Propiedad1");
			Escribir("		Propiedad2");
			Escribir("		Propiedad3");
			Escribir("		Propiedad4");

			Escribir("-----------");
		}

		public void CrearVariables()
		{
			Escribir("		Variable1");
			Escribir("		Variable2");
			Escribir("		Variable3");
			Escribir("		Variable4");

			Escribir("-----------");
		}

		public void Fin() => Escribir("}");

	}
}
