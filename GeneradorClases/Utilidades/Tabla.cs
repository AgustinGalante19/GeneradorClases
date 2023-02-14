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
            List<CampoClase> lst_campos = new List<CampoClase>();
            DataGridViewRowCollection rows = dataGrid.Rows;
            for (int i = 0; i < rows.Count - 1; i++)
            {
                CampoClase obj_campoclase = new CampoClase();
                obj_campoclase.nro = (int)rows[i].Cells[0].Value;
                obj_campoclase.descripcion = (string)rows[i].Cells[1].Value;
                obj_campoclase.campo = (string)rows[i].Cells[2].Value;
                obj_campoclase.tipo = (string)rows[i].Cells[3].Value;
                obj_campoclase.longitud = (int)rows[i].Cells[4].Value;
                obj_campoclase.dec = (int)rows[i].Cells[5].Value;
                obj_campoclase.clave = (string)rows[i].Cells[6].Value;
                obj_campoclase.req = (string)rows[i].Cells[7].Value;
                obj_campoclase.default_value = (string)rows[i].Cells[8].Value;

                lst_campos.Add(obj_campoclase);
            }

            return lst_campos;
        }
        public DataGridViewRowCollection CargarResultado(DataGridView dataGrid, string columna, string resultado, int posicion)
        {
            DataGridViewRowCollection rows = dataGrid.Rows;
            switch (columna)
            {
                case "TIPO":
                {
                    rows[posicion].Cells[9].Value = resultado;
                    break;
                }
            }
            return rows;
        }
    }

    
}
