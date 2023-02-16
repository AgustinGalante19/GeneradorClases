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

            string lstr_result = ValidarGrid(lst_campos);

            if(lstr_result == "OK")
            {
                for (int i = 0; i < lst_campos.Count - 1; i++)
                {
                    lst_campos[i].Tipo_Resultado = obj_campo.CalcularTipo(lst_campos[i].tipo, Convert.ToInt32(lst_campos[i].dec), Convert.ToInt32(lst_campos[i].longitud));

                    lst_campos[i].Abr_tipo_Resultado = obj_campo.CalcularAbrTipo(lst_campos[i].Tipo_Resultado);
                    lst_campos[i].Abr_sigla_Resultado = obj_campo.CalcularSiglaTipo(lst_campos[i].Tipo_Resultado);
                    lst_campos[i].Variable_Resultado = obj_campo.CalcularVariable("m", lst_campos[i].campo, lst_campos[i].Abr_tipo_Resultado);
                    lst_campos[i].Parametro_Resultado = obj_campo.CalcularVariable("p", lst_campos[i].campo, lst_campos[i].Abr_tipo_Resultado);
                }

                var lst = new BindingList<CampoClase>(lst_campos);

                dg_datos.DataSource = null;
                dg_datos.DataSource = lst;

                for (int i = 0; i < lst_campos.Count - 1; i++)
                {
                    for (int j = 0; j < dg_datos.Rows[i].Cells.Count; j++)
                    {
                        dg_datos.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                }
            }
            else
            {
                MessageBox.Show(lstr_result, "Estado de validación");
            }
        }

        private void btn_revisar_Click(object sender, EventArgs e)
        {
            Tabla obj_tabla = new Tabla();

            List<CampoClase> lst_campos = obj_tabla.LlenarDataGridView(dg_datos);

            string lstr_result = ValidarGrid(lst_campos);
            

            MessageBox.Show(lstr_result,"Estado de validación");
        }


        public string ValidarGrid(List<CampoClase> lst_campos)
        {
            Tabla obj_tabla = new Tabla();

            string lstr_result = "";
            for (int i = 0; i < lst_campos.Count -1; i++)
            {
                lstr_result = obj_tabla.Validar(Convert.ToInt32(lst_campos[i].nro), lst_campos[i].descripcion, lst_campos[i].campo, lst_campos[i].tipo, Convert.ToInt32(lst_campos[i].longitud), Convert.ToInt32(lst_campos[i].dec), lst_campos[i].clave, lst_campos[i].req);
                for (int j = 0; j < dg_datos.Rows[i].Cells.Count; j++)
                {
                    dg_datos.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                }
            }
            return lstr_result;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dg_datos.Rows.Clear();
        }
    }
}
