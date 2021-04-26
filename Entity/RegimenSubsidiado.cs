using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenSubsidiado : LiquidacionCuotaModeradora
    {
        public RegimenSubsidiado(int numeroLiquidacion, string identificacion, double valorServicio)
        {
            NumeroLiquidacion = numeroLiquidacion;
            Identificacion = identificacion;
            ValorServicio = valorServicio;
        }

        public RegimenSubsidiado(int numeroLiquidacion, string identificacion, string tipo, double valorServicio) : 
            base(numeroLiquidacion, identificacion, "Subsidiado", 0, valorServicio)
        {

        }

        public double CalcularCuotaSubsidiado()
        {
            CuotaModeradora = ValorServicio * 0.5;

            if (CuotaModeradora > 200000)
            {
                CuotaModeradora = 200000;
            }
            return CuotaModeradora;
        }

        public override double CalcularCuota()
        { 
            return CalcularCuotaSubsidiado();
        }
    }
}
