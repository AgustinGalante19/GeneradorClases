using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorClases.Utilidades
{
    internal class Tabla
    {
        public List<CampoClase> LlenarDataGridView(DataGridView dataGrid)
        {
            try
            {
                List<CampoClase> lst_campos = new List<CampoClase>();
                DataGridViewRowCollection rows = dataGrid.Rows;

                for (int i = 0; i < rows.Count; i++)
                {
                    CampoClase obj_campoclase = new CampoClase();
                    obj_campoclase.nro = (string)rows[i].Cells[0].Value;
                    obj_campoclase.descripcion = (string)rows[i].Cells[1].Value;
                    obj_campoclase.campo = (string)rows[i].Cells[2].Value;
                    obj_campoclase.tipo = (string)rows[i].Cells[3].Value;
                    obj_campoclase.longitud = (string)rows[i].Cells[4].Value;
                    obj_campoclase.dec = (string)rows[i].Cells[5].Value;
                    obj_campoclase.clave = (string)rows[i].Cells[6].Value;
                    obj_campoclase.req = (string)rows[i].Cells[7].Value;
                    obj_campoclase.default_value = (string)rows[i].Cells[8].Value;

                    lst_campos.Add(obj_campoclase);
                }

                return lst_campos;
            } 
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataGridViewRowCollection CargarResultado(DataGridView dataGrid, string columna, string resultado, int posicion)
        {
            DataGridViewRowCollection rows = dataGrid.Rows;
            columna= columna.ToUpper();
            switch (columna)
            {
                case "TIPO":
                {
                    rows[posicion].Cells[9].Value = resultado;
                    break;
                }
                case "ABR_TIPO":
                {
                    rows[posicion].Cells[10].Value = resultado;
                    break;
                }   
            }
            return rows;
        }

        public string Validar(int nro, string descripcion, string campo, string tipo, int longitud, int dec, string clave, string req)
        {
            string lstr_result = "OK";
            if(nro == 0 || descripcion == null || campo == null || tipo == null || longitud == 0 || req == null) {
                lstr_result = "* Hay campos sin rellenar.";
            }

            if(longitud < 0)
            {
                lstr_result += "\n * La longitud no puede ser menor a 0";
            }

            if (dec < 0)
            {
                lstr_result += "\n * La cantidad de decimales no puede ser menor a 0";
            }
            return lstr_result;
        }
    }
}
