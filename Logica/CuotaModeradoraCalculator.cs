using System;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CuotaModeradoraCalculator
    {
        private LiquidacionCuotaModeradoraRepository repository = new LiquidacionCuotaModeradoraRepository();

        public void RegistrarLiquidacion(LiquidacionCuotaModeradora liquidacion)
        {
            // Lógica para registrar una liquidación
        }

        public List<LiquidacionCuotaModeradora> ListarLiquidaciones()
        {
            // Lógica para listar liquidaciones

        }

        public List<LiquidacionCuotaModeradora> ConsultarPorTipoAfiliacion(string tipoAfiliacion)
        {
            // Lógica para consultar por tipo de afiliación
        }

        public decimal ConsultarTotalCuotasModeradoras()
        {
            // Lógica para consultar el total de cuotas moderadoras
        }

        public List<LiquidacionCuotaModeradora> ConsultarPorMesYAnio(int mes, int anio)
        {
            // Lógica para consultar por mes y año
        }

        public List<LiquidacionCuotaModeradora> ConsultarPorNombre(string nombre)
        {
            // Lógica para consultar por nombre
        }

        public void EliminarLiquidacion(int numeroLiquidacion)
        {
            // Lógica para eliminar una liquidación
        }

        public void ModificarValorServicio(int numeroLiquidacion, decimal nuevoValorServicio)
        {
            // Lógica para modificar el valor de servicio y recalcular la cuota moderadora
        }
    }
}