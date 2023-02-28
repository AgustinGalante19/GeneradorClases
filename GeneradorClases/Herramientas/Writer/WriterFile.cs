using GeneradorClases.Herramientas.Writer.Interface;
using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas.Writer
{
	public class WriterFile
	{
		FileStream fs;
		public WriterFile(string pathFile)
		{
			fs = File.Create(pathFile);
		}

		private void Escribir(string text)
		{
			//text += "\n";
			fs.Write(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetBytes(text).Length);
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
				Escribir(metodo.alcance + " " + metodo.tipo + " " + metodo.nombre);
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

				Escribir(
					 " \n"
					+ "{ " +
					"  \n" +

					metodo.contenido

					+ " \n"
					+ "}"
					);
			}
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

		public void Fin()
		{
			Escribir("}");
			fs.Close();
		}

	}
}
