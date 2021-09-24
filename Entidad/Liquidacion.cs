using System;

namespace Entidad
{
    public abstract class Liquidacion
    {
        protected decimal valorIngresos;
        protected decimal valorGastos;


        /*
        public Liquidacion(string identificacionEstablecimiento, string nombreEstablecimiento, string tiempoFuncionando, int tipoResponsabilidad, decimal valorIngresoAnual, decimal valorGastoAnual)
        {
            IdentificacionEstablecimiento = identificacionEstablecimiento;
            NombreEstablecimiento = nombreEstablecimiento;
            TiempoFuncionando = tiempoFuncionando;
            TipoResponsabilidad = tipoResponsabilidad;
            ValorIngresoAnual = valorIngresoAnual;
            ValorGastoAnual = valorGastoAnual;
        }
        public string IdentificacionEstablecimiento { get; set; }
        public string NombreEstablecimiento { get; set; }
        public string TiempoFuncionando { get; set; }
        public int TipoResponsabilidad { get; set; }
        public decimal ValorIngresoAnual { get; set; }
        public decimal ValorGastoAnual { get; set; }
        */

        public decimal ValorImpuesto { get; set; }
        public decimal Ganancia { get; set; }

        

        public abstract decimal CalculoTarifa();

        public void CalculoLiquidacion()
        {
            Ganancia = ValorIngresoAnual - ValorGastoAnual;
            

            if(TipoResponsabilidad == 1)
            {
                ValorImpuesto = Ganancia * 
            }
            else
            {
                ValorImpuesto = Ganancia * CalculoTarifaNoResponsableIva();
            }
            
        }
    }
}
