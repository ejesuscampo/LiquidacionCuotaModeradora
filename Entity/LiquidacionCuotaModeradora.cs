using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public LiquidacionCuotaModeradora()
        {

        }

        public LiquidacionCuotaModeradora(int numeroLiquidacion, string identificacion, string tipo, int salario, double valorServicio)
        {
            NumeroLiquidacion = numeroLiquidacion;
            Identificacion = identificacion;
            Tipo = tipo;
            Salario = salario;
            ValorServicio = valorServicio;
            CuotaModeradora = CuotaModeradora;
        }

        public int NumeroLiquidacion { get; set; }
        public string Identificacion { get; set; }
        public string Tipo { get; set; }
        public int Salario { get; set; }
        public double ValorServicio { get; set; }
        public double CuotaModeradora { get; set; }

        public abstract double CalcularCuota();

        public override string ToString()
        {
            return $"Numero Liquidacion:{NumeroLiquidacion} Identificacion:{Identificacion} Tipo:{Tipo} Salario:{Salario} Valor Servicio:{ValorServicio} Cuota Moderadora:{CuotaModeradora} ";
        }
    }
}
