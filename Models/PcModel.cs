using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KevinPass.Models
{
    public class PcModel
    {

        public double Numero { get; set; }
        public string? PriMon { get; set; }
        public string? SecMon { get; set; }
        
        
        public double Operar()
        {
            double resultado = 0;
            switch (PriMon)
            {
                case "Dolar americano":
                    if (SecMon == "Real brasileño")
                    {
                        resultado = Convert.ToDouble(Numero) * 5.76; 
                    }
                    else if (SecMon == "Sol Peru")
                    {
                        resultado = Convert.ToDouble(Numero) * 3.65; 
                    }
                    break;
                case "Real brasileño":
                    if (SecMon == "Dolar americano")
                    {
                        resultado = Convert.ToDouble(Numero) * 0.17; 
                    }
                    else if (SecMon == "Sol Peru")
                    {
                        resultado = Convert.ToDouble(Numero) * 0.62; 
                    }
                    break;
                case "Sol Peru":
                    if (SecMon == "Dolar americano")
                    {
                        resultado = Convert.ToDouble(Numero) / 0.28; 
                    }
                    else if (SecMon == "Real brasileño")
                    {
                        resultado = Convert.ToDouble(Numero) / 1.57; 
                    }
                    break;
            }
            return resultado;
        }
        
    }
}