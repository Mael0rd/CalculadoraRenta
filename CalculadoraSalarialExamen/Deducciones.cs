using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSalarialExamen
{
    public  class Deducciones
    {
        
        public static decimal CalculaRenta(decimal sBruto)
        {
            decimal impuestoRenta = 0;

            impuestoRenta += (sBruto > 4445000) ? (sBruto - 4445000) * 0.25m : 0;
            sBruto = (sBruto > 4445000) ? 4445000 : sBruto;

            impuestoRenta += (sBruto > 2223000) ? (sBruto - 2223000) * 0.20m : 0;
            sBruto = (sBruto > 2223000) ? 2223000 : sBruto;

            impuestoRenta += (sBruto > 1267000) ? (sBruto - 1267000) * 0.15m : 0;
            sBruto = (sBruto > 1267000) ? 1267000 : sBruto;

            impuestoRenta += (sBruto > 863000) ? (sBruto - 863000) * 0.10m : 0;

            return impuestoRenta;
        }

        public static decimal CalculaSEM(decimal sBruto)
        {
            return sBruto * 0.055m;
        }
        public static decimal CalculaIVM(decimal sBruto)
        {
            return sBruto * 0.0417m;
        }
        public static decimal CalculaLPT(decimal sBruto)
        {
            return sBruto * 0.01m;
        }
    }
}
