using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;

namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroLiquidacion, salario;
            string identificacion, tipo;
            double valorServicio;

            Console.WriteLine("IPS MAS SALUD Y VIDA");
            Console.WriteLine("");
            Console.Write("Digite el numero de liquidación: ");
            numeroLiquidacion = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Digite la identificacion del paciente: ");
            identificacion = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Seleccione el tipo de afiliacion del paciente: ");
            Console.WriteLine("(S) - Subsidiado           (C) - Contributivo");
            tipo = Console.ReadLine();
            Console.WriteLine("");
            Console.Write("Digite el VALOR del servicio de hospitalizacion prestado: ");
            valorServicio = double.Parse(Console.ReadLine());

            LiquidacionCuotaModeradora liquidacionCuota;

            if (tipo.Equals("s"))
            {
                liquidacionCuota = new RegimenSubsidiado(numeroLiquidacion, identificacion, "Subsidiado", valorServicio);
            }
            else
            {
                Console.WriteLine("");
                Console.Write("Cuantos salarios devenga el paciente: ");
                salario = int.Parse(Console.ReadLine());

                liquidacionCuota = new RegimenContributivo(numeroLiquidacion, identificacion, "Contributivo", salario, valorServicio);
            }

            Console.WriteLine("");
            Console.WriteLine($"El valor de la cuota moderadora a pagar es de: {liquidacionCuota.CalcularCuota()}");

            LiquidacionCuotaModeradoraService liquidacionCuotaModeradoraService = new LiquidacionCuotaModeradoraService();
            Console.WriteLine(liquidacionCuotaModeradoraService.Guardar(liquidacionCuota));


            Console.WriteLine("...::Consultar liquidaciones de cuota moderadora::...");
            ConsultaResponse response = liquidacionCuotaModeradoraService.Consultar();
            if (!response.Error)
            {
                foreach (var item in response.LiquidacionCuotas)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine(response.Mensaje);
            }
            Console.ReadKey();

        }
    }
}
