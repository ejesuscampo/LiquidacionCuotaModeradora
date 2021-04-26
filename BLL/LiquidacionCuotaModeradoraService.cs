using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LiquidacionCuotaModeradoraService
    {
        LiquidacionCuotaModeradoraRepository liquidacionCuotaModeradoraRepository = new LiquidacionCuotaModeradoraRepository();
        public string Guardar(LiquidacionCuotaModeradora liquidacionCuota)
        {
            try
            {
                liquidacionCuotaModeradoraRepository.Guardar(liquidacionCuota);
                return "Se guardaron los datos exitosamente";
            }
            catch (Exception e)
            {
                return "Se presento el siguiente error al momento de guardar: " + e.Message;
            }
            
        }
        public ConsultaResponse Consultar()
        {
            try
            {
                return new ConsultaResponse(liquidacionCuotaModeradoraRepository.Consultar());
            }
            catch (Exception e)
            {

                return new ConsultaResponse("Se presentó el siguiente error: " + e.Message);
            }
        }

        /*public string Eliminar(int numeroLiquidacion)
        {
            try
            {
                liquidacionCuotaModeradoraRepository.BuscarPorTipo
            }
            catch (Exception)
            {

                throw;
            }
        }*/
    }

    public class ConsultaResponse
    {
        public List<LiquidacionCuotaModeradora> LiquidacionCuotas { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaResponse(List<LiquidacionCuotaModeradora> liquidacionCuotas)
        {
            LiquidacionCuotas = liquidacionCuotas;
            Error = false;
        }

        public ConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }
    }
}
