using GeneradorClases.Herramientas;
using GeneradorClases.Herramientas.Writer;
using GeneradorClases.Modelos;
using GeneradorClases.Utilidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
			if (cb_lenguajes.SelectedItem == "C#")
            {
                Tabla obj_tabla = new Tabla();
                Campo obj_campo = new Campo();

                //Lleno la lista con los datos del grid
                List<CampoClase> lst_campos = obj_tabla.LlenarDataGridView(dg_datos);

                //Valido que los datos no sean nulos
                string lstr_result = ValidarGrid(lst_campos);

                if (lstr_result == "OK")
                {
                    //Calculo los tipos y seteo las propiedades
                    lst_campos = CalcularTipos(lst_campos);

                    //Bindeo los datos utilizando BindingList para que herede la interfaz que comprende las celdas
                    dg_datos.DataSource = new BindingList<CampoClase>(lst_campos);

                    //pinto las celdas
                    for (int i = 0; i < lst_campos.Count - 1; i++)
                    {
                        for (int j = 0; j < dg_datos.Rows[i].Cells.Count; j++)
                        {
                            dg_datos.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        }
                    }			                    


					CrearClase(lst_campos.Select(x =>
					 new CampoClase()
					 {
						 Parametro_Resultado = x.Parametro_Resultado,
						 Tipo_Resultado = x.Tipo_Resultado,
						 Variable_Resultado = x.Variable_Resultado,
                         campo = x.campo,
                         default_value= x.default_value,
					 }
					).ToList<CampoClase>());
                }
                else if (lstr_result != "")
                {
                    MessageBox.Show(lstr_result, "Estado de validación");
                }
            }
        }
        private void CrearClase(List<CampoClase> resultados)
        {			
			try
            {
                WriterFile writer = new WriterFile(tb_archivo_path.Text + @"\" + tb_archivo_nombre.Text + ".cs");

                string currentPath = Directory.GetCurrentDirectory();
                currentPath = currentPath.Replace("bin", "");
                currentPath = currentPath.Replace("Debug", "");
                string methodsJsonPath = currentPath + "JsonFiles//Method.json";
                
                CVM_Method _Method = JsonConvert.DeserializeObject<CVM_Method>(File.ReadAllText(methodsJsonPath));
                CVM_Constant _Constant = JsonConvert.DeserializeObject<CVM_Constant>(File.ReadAllText(currentPath + "JsonFiles//Constant.json"));
                CVM_Object _Objects = JsonConvert.DeserializeObject<CVM_Object>(File.ReadAllText(currentPath + "JsonFiles//Objects.json"));

                writer.CrearClase(tb_nombre_clase.Text, _Method.Metodos.First(), _Constant.Constantes, _Objects.objetos);
                writer.CrearVariables(resultados);
				writer.CrearPropiedades(resultados);
				writer.CrearMetodos(_Method.Metodos, new List<string>(resultados.Select(x => x.campo.Trim()).ToList())); 
				writer.Fin();

                MessageBox.Show("El archivo se guardo en: " + tb_archivo_path.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<CampoClase> CalcularTipos(List<CampoClase> lst_campos)
        {
            Campo obj_campo = new Campo();

            for (int i = 0; i < lst_campos.Count - 1; i++)
            {
                lst_campos[i].Tipo_Resultado = obj_campo.CalcularTipo(lst_campos[i].tipo, Convert.ToInt32(lst_campos[i].dec), Convert.ToInt32(lst_campos[i].longitud));

                lst_campos[i].Abr_tipo_Resultado = obj_campo.CalcularAbrTipo(lst_campos[i].Tipo_Resultado);
                lst_campos[i].Abr_sigla_Resultado = obj_campo.CalcularSiglaTipo(lst_campos[i].Tipo_Resultado);
                lst_campos[i].Variable_Resultado = obj_campo.CalcularVariable("m", lst_campos[i].campo, lst_campos[i].Abr_tipo_Resultado);
                lst_campos[i].Parametro_Resultado = obj_campo.CalcularVariable("p", lst_campos[i].campo, lst_campos[i].Abr_tipo_Resultado);
            }

            return lst_campos;
        }
        private void btn_revisar_Click(object sender, EventArgs e)
        {
            Tabla obj_tabla = new Tabla();
            List<CampoClase> lst_campos = obj_tabla.LlenarDataGridView(dg_datos);

            string lstr_result = ValidarGrid(lst_campos);

            MessageBox.Show(lstr_result, "Estado de validación");
        }


        public string ValidarGrid(List<CampoClase> lst_campos)
        {
            Tabla obj_tabla = new Tabla();

            string lstr_result = "";
            for (int i = 0; i < lst_campos.Count; i++)
            {
                if (lst_campos[i].nro != null && lst_campos[i].descripcion != null && lst_campos[i].tipo != null && lst_campos[i].longitud != null && lst_campos[i].dec != null && lst_campos[i].clave != null && lst_campos[i].req != null && lst_campos[i].default_value != null)
                {
                    lstr_result = obj_tabla.Validar(Convert.ToInt32(lst_campos[i].nro), lst_campos[i].descripcion, lst_campos[i].campo, lst_campos[i].tipo, Convert.ToInt32(lst_campos[i].longitud), Convert.ToInt32(lst_campos[i].dec), lst_campos[i].clave, lst_campos[i].req);

                    for (int j = 0; j < dg_datos.Rows[i].Cells.Count; j++)
                    {
                        dg_datos.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                    }
                }


            }
            return lstr_result;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dg_datos.Rows.Clear();
        }

        private void generarClaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TablaText tablaText = new TablaText();

			tablaText.ShowDialog();

			if (tablaText.GetText() != null)
            {
                List<CampoClase> campoClases = tablaText.GetText();
                dg_datos.DataSource = new BindingList<CampoClase>(campoClases);
            }            
		}

	}
}
