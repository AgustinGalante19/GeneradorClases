using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas.Writer
{
	public class WriterVB : IWriterClass
	{
		private FileStream _Fs;
		public WriterVB(FileStream fileStream) => _Fs = fileStream;
		private void Escribir(string text) => _Fs.Write(Encoding.ASCII.GetBytes(text), 0, Encoding.ASCII.GetBytes(text).Length);
		public void CrearClase(string nombre, Metodo metodo, List<Constant> lst_constantes, List<Modelos.Object> lst_objects)
		{
			Escribir("Public Class " + nombre);

			lst_objects.ForEach(objecto => {
				Escribir("\n\t" + objecto.alcance + " " + objecto.nombre + " As New" + objecto.tipo);
			});

			GenerarConstantes(lst_constantes);
			GenerarContructores(metodo, nombre, lst_objects);

		}

		public void CrearMetodos(List<Metodo> lst_metodos, List<Propertie> CampoClase)
		{
			throw new NotImplementedException();
		}

		public void CrearPropiedades(List<CampoClase> properties)
		{
			throw new NotImplementedException();
		}

		public void CrearVariables(List<CampoClase> resultados)
		{
			throw new NotImplementedException();
		}

		public void Fin()
		{
			Escribir("End Class");
			_Fs.Close();
		}

		public void GenerarConstantes(List<Constant> lst_constantes)
		{
			lst_constantes.ForEach(constante =>
			{
				if (constante.tipo == "String")
				{
					Escribir("\n\t"
					+ constante.alcance
					+ " Const "
					+ constante.nombre
					+ " As"
					+ constante.tipo
					+ " = \""
					+ constante.valor
					+ "\"");
				}
				else
				{
					Escribir("\n\t"
					+ constante.alcance
					+ " Const "
					+ constante.nombre
					+ " "
					+ constante.tipo
					+ " = "
					+ constante.valor);
				}
			});
		}

		public void GenerarContructores(Metodo metodo, string classname, List<Modelos.Object> lst_objects)
		{
			Escribir("\n");
			Escribir("\t" + metodo.alcance + " Sub New");
			Escribir("(");
			if(metodo.parametros.Any())
			{
				for (int i = 0; i <= metodo.parametros.Count - 1; i++)
				{
					if (metodo.parametros.Count - 1 == i)					
						Escribir(metodo.parametros[i].nombre + " " + metodo.parametros[i].tipo);					
					else
						Escribir(metodo.parametros[i].nombre + " " + metodo.parametros[i].tipo + ", ");
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
				+ "\t" +
				"  \n" +
				newContent
			);
			GenerarObjetos(lst_objects);
			Escribir("\n\t End Sub");
		}

		public void GenerarID(string id, string type)
		{
			throw new NotImplementedException();
		}

		public void GenerarObjetos(List<Modelos.Object> lst_obj)
		{
			//Falta configurar para VB
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
	}
}
