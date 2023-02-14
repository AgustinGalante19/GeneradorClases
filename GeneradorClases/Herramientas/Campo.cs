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
    }
}
