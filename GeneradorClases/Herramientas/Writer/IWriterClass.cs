using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas.Writer
{
	public interface IWriterClass
	{
		void CrearClase(string nombre, Metodo metodo, List<Constant> lst_constantes, List<Modelos.Object> lst_objects);

		void GenerarContructores(Metodo metodo, string classname, List<Modelos.Object> lst_objects);

		void GenerarObjetos(List<Modelos.Object> lst_obj);

		void GenerarConstantes(List<Constant> lst_constantes);

		void CrearMetodos(List<Metodo> lst_metodos, List<Propertie> CampoClase);

		void CrearVariables(List<CampoClase> resultados);

		void CrearPropiedades(List<CampoClase> properties);

	    void GenerarID(string id, string type);

		void Fin();
	
	}
}
