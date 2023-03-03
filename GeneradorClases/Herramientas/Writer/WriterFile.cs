using GeneradorClases.Herramientas.Writer.Interface;
using GeneradorClases.Modelos;
using GeneradorClases.Utilidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas.Writer
{
	public class WriterFile
	{

		FileStream Fs;
		public const string xd = "ASDASD";
		public WriterFile(string pathFile)
		{
			Fs = File.Create(pathFile);
		}

		private void Escribir(string text)
		{
			Fs.Write(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetBytes(text).Length);
		}

		public void CrearClase(string nombre, Metodo metodo, List<Constant> lst_constantes, List<Modelos.Object> lst_objects)
		{
			Escribir("public class " + nombre);
			Escribir("\n");
			Escribir("{");
			Escribir("\n");

			lst_objects.ForEach(objecto => {
				Escribir("\n\t" + objecto.alcance + " " + objecto.tipo + " " + objecto.nombre + ";");
			});
			GenerarConstantes(lst_constantes);
            GenerarContructores(metodo, nombre, lst_objects);
		}

		private void GenerarContructores(Metodo metodo, string classname, List<Modelos.Object> lst_objects)
		{

			Escribir("\n");
			Escribir("\t" + metodo.alcance + " " + metodo.tipo + " " + classname);
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
			for (int i = 0; i < content.Length; i++)
			{
				content[i] = "\t" + content[i];
			}
			string newContent = string.Join("\n", content);
			Escribir(
				 " \n"
				+ "\t{ " +
				"  \n" +
				newContent
			);
			GenerarObjetos(lst_objects);
			Escribir("\n\t}");


        }

		public void GenerarObjetos(List<Modelos.Object> lst_obj)
		{
			lst_obj.ForEach(objeto =>
			{
				if (objeto.tipo == "bool")
				{
                    Escribir("\n\t\t" + objeto.nombre + " = false;");
                }
				else
				{
                    Escribir("\n\t\t" + objeto.nombre + " = new " + objeto.tipo + "();");
                }
			});
		}

        public void GenerarConstantes(List<Constant> lst_constantes)
        {
			lst_constantes.ForEach(constante =>
			{
				if(constante.tipo == "string")
				{
                    Escribir("\n\t"
                    + constante.alcance
                    + " const "
                    + constante.tipo
                    + " "
                    + constante.nombre
                    + " = \""
                    + constante.valor
                    + "\";");
				}
				else
				{
                    Escribir("\n\t"
                    + constante.alcance
                    + " const "
                    + constante.tipo
                    + " "
                    + constante.nombre
                    + " = "
                    + constante.valor
                    + ";");
                }
			});
        }
        public void CrearMetodos(List<Metodo> lst_metodos, List<string> CampoClase)
		{
			lst_metodos.RemoveAt(0);//elimino el constructor
			foreach (var metodo in lst_metodos)
			{
				Escribir("\n");
				Escribir("\t" + metodo.alcance + " " + metodo.tipo + " " + metodo.nombre);
				Escribir("(");		

				//Inserto los parametros
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

				//Modifico los metodos especiales para agregarles las referencias
				switch (metodo.nombre)
				{
					case "CargarDesdeDR":
						if (metodo.parametros.First().nombre == "pReg")
						{
							//cantidad de referencias
							var ContenidoReplace = metodo.contenido;
							for (int i = 0; i < CampoClase.Count; i++)
							{
								metodo.contenido = metodo.contenido.Replace("[NombrePropiedad]", CampoClase[i].ToLower());
								metodo.contenido = metodo.contenido.Replace("[TagPropiedad]", CampoClase[i]);

								if (i != CampoClase.Count - 1)
								{
									metodo.contenido = metodo.contenido + ContenidoReplace;
								}
							}
						}
						break;
				}

				//Agrego tabulaciones
				string[] content = metodo.contenido.Split(Convert.ToChar("\n"));
				for (int i = 0; i < content.Length; i++)
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

			resultados.ForEach(resultado =>
			{
				if (resultado.Tipo_Resultado.ToLower() == "string" && resultado.default_value != null)
				{
					Escribir("\n\tprivate " + resultado.Tipo_Resultado.ToLower() + " " + resultado.Variable_Resultado.ToLower().Trim() + " = " + "\"" + resultado.default_value + "\" ;");
				}
				else
				{
					Escribir("\n\tprivate " + resultado.Tipo_Resultado.ToLower() + " " + resultado.Variable_Resultado.ToLower().Trim() + " = " + resultado.default_value + " ;");
				}
			});
		}
		public void CrearPropiedades(List<CampoClase> properties)
		{

			Escribir("\n");
			properties.ForEach(propertie => Escribir("\n\t" + "public " + propertie.Tipo_Resultado.ToLower() + " " + propertie.campo.ToLower().Trim() + " { get => " + propertie.Variable_Resultado.Trim() + "; set => " + propertie.Variable_Resultado.Trim() + " = value;}"));
			Escribir("\n");
		}
		public void Fin()
		{
			Escribir("\n}");
			Fs.Close();
		}

	}
}
