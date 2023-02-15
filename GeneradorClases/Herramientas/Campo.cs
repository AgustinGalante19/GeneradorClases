using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorClases.Herramientas
{
    internal class Campo
    {
        public string CalcularTipo(string tipo, int dec, int longValue)
        {
            string lstr_res = "";
            tipo = tipo.ToUpper();
            switch (tipo)
            {
                case "NUMERIC":
                    {
                        //lstr_res = Interaction.IIf(pint_dec == 0, "Long", "Double");
                        if(dec == 0)
                        {
                            lstr_res = "Long";
                        }
                        else
                        {
                            lstr_res = "Double";
                        }

                        if (dec == 0)
                        {
                            if (longValue == 1)
                                lstr_res = "Boolean";
                            else if (longValue <= 3)
                                lstr_res = "Integer";
                            else
                                lstr_res = "Long";
                        }
                        else
                            lstr_res = "Double";
                        break;
                    }
                case "INT":
                    {
                        lstr_res = "Integer";
                        break;
                    }

                case "BIT":
                    {
                        lstr_res = "Boolean";
                        break;
                    }

                case "CHAR":
                case "VARCHAR":
                case "VARCHAR2":
                case "DATE":
                case "DATETIME":
                case "SMALLDATETIME":
                    {
                        lstr_res = "String";
                        break;
                    }
                default:
                    {
                        lstr_res = "???";
                        break;
                    }
            }
            return lstr_res;
        }
        public string CalcularAbrTipo(string tipo)
        {
            string lstr_result = "";
            tipo = tipo.ToUpper();
            switch (tipo)
            {
                case "LONG":
                    lstr_result = "lng";
                    break;
                case "DOUBLE":
                    lstr_result = "dbl";
                    break;
                case "INTEGER":
                    lstr_result = "int";
                    break;
                case "BOOLEAN":
                    lstr_result = "bln";
                    break;
                case "STRING":
                    lstr_result = "str";
                    break;
            }
            return lstr_result;
        }
        public string CalcularSiglaTipo(string tipo)
        {
            string lstr_result = "";
            tipo = tipo.ToUpper();
            switch (tipo)
            {
                case "LONG":
                case "INTEGER":
                case "DOUBLE":
                    lstr_result = "N";
                    break;
                case "BOOLEAN":
                    lstr_result = "B";
                    break;
                case "DATE":
                case "DATETIME":
                case "SMALLDATETIME":
                    lstr_result = "F";
                    break;
                case "STRING":
                    lstr_result = "T";
                    break;
            }

            return lstr_result;
        }

        public string CalcularVariable(string uso, string campo, string abr_tipo)
        {
            string lstr_result = "";
            campo = campo.ToLower();
            if (uso == "p" || uso == "m")
            {
                lstr_result = uso + abr_tipo + "_" + campo;
            }

            return lstr_result;
        }
    }
}
