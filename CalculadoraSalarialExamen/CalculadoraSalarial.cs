using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSalarialExamen
{
    public class CalculadoraSalarial
    {
        public decimal CalcularSalarioNeto(decimal sBruto, int cantidadHijos, bool tieneEsposa)
        {
            decimal SEM = CalculadoraSalarialExamen.Deducciones.CalculaSEM(sBruto);
            decimal IVM = CalculadoraSalarialExamen.Deducciones.CalculaIVM(sBruto);
            decimal LPT = CalculadoraSalarialExamen.Deducciones.CalculaLPT(sBruto);

            decimal Deducciones = SEM + IVM + LPT;
            decimal impuestoRenta = CalculadoraSalarialExamen.Deducciones.CalculaRenta(sBruto);

            decimal descuentoHijos = cantidadHijos * 1610;
            decimal descuentoEsposa = 0;
            if (tieneEsposa)
            {
                descuentoEsposa = 2430;
            }
            else
            {
                descuentoEsposa = 0;
            }
            decimal descuentosFamiliar = descuentoHijos + descuentoEsposa;

            decimal salarioNeto = sBruto - Deducciones - impuestoRenta + descuentosFamiliar;

            return salarioNeto;
        }

    }
}
