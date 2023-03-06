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
		private IWriterClass _writer;
		private FileStream Fs;

		public WriterFile(string pathFile,string lenguaje)
		{
			Fs = File.Create(pathFile);
			if (lenguaje == "VB.net")
				_writer = new WriterVB(Fs);
			else
				_writer = new WriterCsharp(Fs);
			
		}

		public void CrearClase(string nombre, Metodo metodo, List<Constant> lst_constantes, List<Modelos.Object> lst_objects) => _writer.CrearClase(nombre, metodo, lst_constantes, lst_objects);
		private void GenerarContructores(Metodo metodo, string classname, List<Modelos.Object> lst_objects) => _writer.GenerarContructores(metodo, classname, lst_objects);
		public void GenerarObjetos(List<Modelos.Object> lst_obj) => _writer.GenerarObjetos(lst_obj);
		public void GenerarConstantes(List<Constant> lst_constantes) => _writer.GenerarConstantes(lst_constantes);
		public void CrearMetodos(List<Metodo> lst_metodos, List<Propertie> CampoClase) => _writer.CrearMetodos(lst_metodos, CampoClase);
		public void CrearVariables(List<CampoClase> resultados) => _writer.CrearVariables(resultados);
		public void CrearPropiedades(List<CampoClase> properties) => _writer.CrearPropiedades(properties);
		public void GenerarID(string id, string type) => _writer.GenerarID(id,type);
		public void Fin() => _writer.Fin();
	}
}
