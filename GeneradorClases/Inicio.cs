using GeneradorClases.Herramientas;
using GeneradorClases.Modelos;
using GeneradorClases.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorClases
{
    public partial class Inicio : Form
    {
		public Inicio()
        {
            InitializeComponent();
        }
		private void Inicio_Load(object sender, EventArgs e)
		{
		}

		private void btn_fbd_Click(object sender, EventArgs e)
        {
            fbd_archivo_path.ShowDialog();
            string lstr_path = fbd_archivo_path.SelectedPath;
            tb_archivo_path.Text = lstr_path;            
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {	
			Tabla obj_tabla = new Tabla();

			Campo obj_campo = new Campo();

			List<CampoClase> lst_campos = obj_tabla.LlenarDataGridView(dg_datos);
					
			for (int i = 0; i < lst_campos.Count - 1; i++)
			{
				lst_campos[i].Tipo_Resultado = obj_campo.CalcularTipo(lst_campos[i].tipo, Convert.ToInt32(lst_campos[i].dec), Convert.ToInt32(lst_campos[i].longitud));

				lst_campos[i].Abr_tipo_Resultado = obj_campo.CalcularAbrTipo(lst_campos[i].Tipo_Resultado);
			}			

			var lst = new BindingList<CampoClase>(lst_campos);

			dg_datos.DataSource = null;
			dg_datos.DataSource = lst;		
		}	
	}
}
