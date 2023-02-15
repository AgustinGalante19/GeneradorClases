using GeneradorClases.Herramientas;
using GeneradorClases.Modelos;
using GeneradorClases.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void btn_fbd_Click(object sender, EventArgs e)
        {
            fbd_archivo_path.ShowDialog();
            string lstr_path = fbd_archivo_path.SelectedPath;
            tb_archivo_path.Text = lstr_path;


            
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            int i = 0;
            Tabla obj_tabla = new Tabla();
            DataGridViewRowCollection newRows;
            List<CampoClase> lst_campos = obj_tabla.LlenarDataGridView(dg_datos);
            Campo obj_campo = new Campo();
            DataTable dataTable = new DataTable();
            lst_campos.ForEach(campo =>
            {
                campo.Tipo_Resultado = obj_campo.CalcularTipo(campo.tipo, Convert.ToInt32(campo.dec), Convert.ToInt32(campo.longitud));
                newRows = obj_tabla.CargarResultado(dg_datos, "TIPO", campo.Tipo_Resultado, i);

                campo.Abr_tipo_Resultado = obj_campo.CalcularAbrTipo(campo.Tipo_Resultado);
                newRows = obj_tabla.CargarResultado(dg_datos, "ABR_TIPO", campo.Abr_tipo_Resultado, i);

                dataTable.Rows.Add(newRows);
                i++;
            });
            dg_datos.DataSource = dataTable;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }
    }
}
