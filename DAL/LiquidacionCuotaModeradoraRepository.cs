using Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LiquidacionCuotaModeradoraRepository
    {
        string ruta = @"LiquidacionCuotas.txt";

        public void Guardar(LiquidacionCuotaModeradora liquidacionCuota)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine($"{liquidacionCuota.NumeroLiquidacion}; {liquidacionCuota.Identificacion}; {liquidacionCuota.Tipo}; " +
                $"{liquidacionCuota.Salario}; {liquidacionCuota.ValorServicio}; {liquidacionCuota.CuotaModeradora}");
            writer.Close();
            file.Close();
        }

        public List<LiquidacionCuotaModeradora> Consultar()
        {
            List<LiquidacionCuotaModeradora> liquidacionCuotas = new List<LiquidacionCuotaModeradora>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = string.Empty;
            while ((line = reader.ReadLine()) != null)
            {
                LiquidacionCuotaModeradora liquidacionCuota = MapearLiquidacionCuotas(line);
                liquidacionCuotas.Add(liquidacionCuota);
            }
            file.Close();
            reader.Close();
            return liquidacionCuotas;
        }

        private static LiquidacionCuotaModeradora MapearLiquidacionCuotas(string line)
        {
            string[] datosLiquidacionCuotas = line.Split(';');
            int NumeroLiquidacion = int.Parse(datosLiquidacionCuotas[0]);
            string Identificacion = datosLiquidacionCuotas[1];
            string Tipo = datosLiquidacionCuotas[2];
            int Salario = (int)Convert.ToDouble(datosLiquidacionCuotas[3]);
            double ValorServicio = double.Parse(datosLiquidacionCuotas[4]);
            double CuotaModeradora = double.Parse(datosLiquidacionCuotas[5]);

            if (datosLiquidacionCuotas[2] == "Contributivo")
            {
                LiquidacionCuotaModeradora liquidacionCuota = new RegimenContributivo(NumeroLiquidacion, Identificacion, Salario, ValorServicio);
                return liquidacionCuota;
            }

            else
            {
                LiquidacionCuotaModeradora liquidacionCuota = new RegimenSubsidiado(NumeroLiquidacion, Identificacion, ValorServicio);
                return liquidacionCuota;
            }
        }

        public void Eliminar(int numeroLiquidacion)
        {
            List<LiquidacionCuotaModeradora> liquidacionCuotas = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in liquidacionCuotas)
            {
                if (item.NumeroLiquidacion.Equals(numeroLiquidacion))
                {
                    Guardar(item);
                }
                
            }
        }

        public LiquidacionCuotaModeradora BuscarPorTipo(string tipo)
        {
            foreach (var item in Consultar())
            {
                if (item.Tipo.Equals(tipo))
                {
                    return item;
                }
            }
            return null;
        }

        public void Modificar(LiquidacionCuotaModeradora liquidacionCuotaNueva, string identificacion)
        {
            List<LiquidacionCuotaModeradora> liquidacionCuotas = Consultar();
            FileStream file = new FileStream(ruta, FileMode.Create);
            file.Close();
            foreach (var item in liquidacionCuotas)
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    Guardar(item);
                }
                else
                {
                    Guardar(liquidacionCuotaNueva); 
                }
            }
        }
    }
}
