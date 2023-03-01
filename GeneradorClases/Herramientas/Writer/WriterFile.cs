using GeneradorClases.Herramientas.Writer.Interface;
using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas.Writer
{
	public class WriterFile
	{
		FileStream Fs;

		public WriterFile(string pathFile)
		{
			Fs = File.Create(pathFile);
		}

		private void Escribir(string text)
		{
			//text += "\n";
			Fs.Write(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetBytes(text).Length);
		}

		public void CrearClase(string nombre, Metodo metodo)
		{
			Escribir("public class " + nombre);
			Escribir("\n");
			Escribir("{");
			Escribir("\n");

			GenerarContructores(metodo, nombre);
		}

		private void GenerarContructores(Metodo metodo, string classname)
		{

			Escribir("\n");
			Escribir(metodo.alcance + " " + metodo.tipo + " " + classname);
			Escribir("(");
			for (int i = 0; i <= metodo.parametros.Count -1; i++)
			{
				if (metodo.parametros.Count -1 == i)
				{
					Escribir(metodo.parametros[i].tipo + " " + metodo.parametros[i].nombre);
				}
				else
				{
					Escribir(metodo.parametros[i].tipo + " " + metodo.parametros[i].nombre + ", ");
				}										
			}
			Escribir(")");

			Escribir(
				 " \n"
				+ "{ " +
				"  \n" +

				metodo.contenido

				+ " \n"
				+ "}"
				);
			
		}

		public void CrearMetodos(List<Metodo> lst_metodos)
		{
			lst_metodos.RemoveAt(0);//elimino el constructor
			foreach (var metodo in lst_metodos)
			{
				Escribir("\n");
				Escribir("\t"+metodo.alcance + " " + metodo.tipo + " " + metodo.nombre);
				Escribir("(");
				for (int i = 0; i <= metodo.parametros.Count - 1; i++)
				{
					if (metodo.parametros.Count - 1 == i)
					{
						Escribir(metodo.parametros[i].tipo + " " + metodo.parametros[i].nombre);
					}
					else
					{
						Escribir(metodo.parametros[i].tipo + " " + metodo.parametros[i].nombre + ", ");
					}
				}
				Escribir(")");
				string[] content = metodo.contenido.Split(Convert.ToChar("\n"));
				for(int i = 0; i < content.Length; i++)
				{
					content[i] = "\t" + content[i];
				}

				string newContent = string.Join("\n", content);

                Escribir(
					 " \n"
					+ "\t{" +
					"  \n" +
					newContent
					+ " \n"
					+ "\t}"
					);
			}
		}

		public void CrearVariables(List<CampoClase> resultados)
		{
			resultados.RemoveAt(resultados.Count - 1);

			foreach(var resultado in resultados)
			{
				if(resultado.Tipo_Resultado.ToLower() == "string")
				{
					resultado.default_value.ToString();
				}
			}

			resultados.ForEach(resultado => Escribir("\n\tprivate " + resultado.Tipo_Resultado.ToLower() + " " + resultado.Variable_Resultado.ToLower() + " = " + resultado.default_value  + " ;"));
		}
		public void CrearPropiedades(List<CampoClase> properties)
		{
			
			Escribir("\n");
			properties.ForEach(propertie => Escribir("\n\t" + "public " + propertie.Tipo_Resultado.ToLower() + " " + propertie.campo.ToLower() + " { get => " +propertie.Variable_Resultado+ "; set => " + propertie.Variable_Resultado + " = value;}"));
			Escribir("\n");
		}
		
		public void Fin()
		{
			Escribir("\n}");
			Fs.Close();
		}

	}
}
