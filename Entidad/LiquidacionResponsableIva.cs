using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class LiquidacionResponsableIva: Liquidacion
    {
        public LiquidacionResponsableIva(decimal _valorIngresos, decimal _valorGastos)
        {
            ValorIngresos = _valorIngresos;
            ValorGastos = _valorGastos;
        }
        public decimal ValorIngresos { get; set; }
        public decimal ValorGastos { get; set; }
        public override decimal CalculoTarifa()
        {
            decimal ganancias = ValorIngresos - ValorGastos;

            decimal uvt = (ganancias * 1) / 30000;

            if (uvt < 0)
            {
                return 0;
            }else if(uvt < 100)
            {
                return 5/100;
            }else if(uvt >=100 && uvt < 500)
            {
                return 10 / 100;
            }else if(uvt >= 500)
            {
                return 15 / 100;
            }
            else
            {
                return 0;
            }
           
        }
    }
}
