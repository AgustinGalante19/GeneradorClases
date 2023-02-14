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
            Tabla obj_tabla = new Tabla();
            List<CampoClase> lst_campos = obj_tabla.LlenarDataGridView(dg_datos);
            Campo obj_campo = new Campo();
            CampoClase elemento = lst_campos.First();
            string resultado = obj_campo.CalcularTipo(elemento.tipo, elemento.dec, elemento.longitud);
            DataGridViewRowCollection newRows = obj_tabla.CargarResultado(dg_datos, "TIPO", resultado, 0);
            dg_datos.Rows.Add(newRows[0]);
            
            MessageBox.Show(resultado);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
        }

        private void campoClaseBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }
    }
}
