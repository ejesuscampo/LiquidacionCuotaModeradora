using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegimenContributivo : LiquidacionCuotaModeradora
    {
        public RegimenContributivo(int numeroLiquidacion, string identificacion, int salario, double valorServicio)
        {
            NumeroLiquidacion = numeroLiquidacion;
            Identificacion = identificacion;
            Salario = salario;
            ValorServicio = valorServicio;
        }

        public RegimenContributivo(int numeroLiquidacion, string identificacion, string tipo, int salario, double valorServicio) : 
            base(numeroLiquidacion, identificacion, "Contributivo", salario, valorServicio)
        {

        }

        public double CalcularCuotaContributivo()
        {
            if (Salario == 1)
            {
                CuotaModeradora = ValorServicio * 0.15;

                if (CuotaModeradora > 250000)
                {
                    CuotaModeradora = 250000;
                }

            }
            else if (Salario >= 2 && Salario <= 5)
            {
                CuotaModeradora = ValorServicio * 0.20;

                if (CuotaModeradora > 900000)
                {
                    CuotaModeradora = 900000;
                }

            }
            else
            {
                CuotaModeradora = ValorServicio * 0.25;

                if (CuotaModeradora > 1500000)
                {
                    CuotaModeradora = 1500000;
                }
            }

            return CuotaModeradora;
        }
        public override double CalcularCuota()
        {
            return CalcularCuotaContributivo();
        }
    }
}
