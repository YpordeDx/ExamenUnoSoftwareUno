using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParaPruebaIngSoftware
{
    public class Operation
    {
        public float promedioNotas(float nota1, float nota2, float nota3) {
            return (nota1+nota2+nota3)/3;
        }

        public string pasaMateria(float nota) {
            string res = "s";
            
            if (nota >= 14 && nota <= 20)
            {
               res = "G";
            }
            else {
                if (nota >= 12 && nota < 14)
                {
                    res = "S";
                }
                else {
                    if (nota >= 0 && nota < 12)
                    {
                        res = "P";
                    }
                    else {
                        if (nota == float.Parse(null))
                        {
                            res = "V";
                        }
                        else {
                            res = "N";
                        }

                    }
                }
                    
           }

            return res;
        }

        public string pasaSemestre(string a, string b, string c) {
            return "pierde";
        }
    }
}
