using GeneradorClases.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorClases
{
	public partial class TablaText : Form
	{
		private string text = "";
		private string separator = "";
		private List<CampoClase> lstCampoClase;
		
		public TablaText()
		{			
			InitializeComponent();
			comboBox1.Text = ",";
		}

		private void btnCargar_Click(object sender, EventArgs e)
		{
			text = textBox1.Text;
			separator = comboBox1.SelectedItem.ToString();
			this.Close();
		}
		public List<CampoClase> GetText()
		{
			if (textBox1.Text == "") 
				return null;

			lstCampoClase = MappingText();
			return lstCampoClase;
		}

		public List<CampoClase> MappingText()
		{
			CampoClase campo;

			List<string> list = text.Split(new char[3] { Convert.ToChar(separator), '\r', '\n' }).ToList();

			lstCampoClase = new List<CampoClase>();

			for (int i = 0; i <= list.Count - 1; i++)
			{
				if (list[i] != "")
				{
					campo = new CampoClase()
					{
						nro = list[i],
						descripcion = list[i + 1],
						campo = list[i + 2],
						tipo = list[i + 3],
						longitud = list[i + 4],
						dec = list[i + 5],
						clave = list[i + 6],
						req = list[i + 7],
						default_value = list[i + 8]
					};

					i += 8;

					lstCampoClase.Add(campo);
				}
			}

			return lstCampoClase;
		}
		
	}
}
