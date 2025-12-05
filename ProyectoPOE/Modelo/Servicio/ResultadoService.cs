using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Servicio
{
    public class ResultadoService
    {
        public Candidata ObtenerGanadoraReina(List<Candidata> candidatas)
        {
            return candidatas.OrderByDescending(c => c.ObtenerTotalVotos(TipoVoto.Reina)).FirstOrDefault();
        }

        public Candidata ObtenerGanadoraFotogenia(List<Candidata> candidatas)
        {
            return candidatas.OrderByDescending(c => c.ObtenerTotalVotos(TipoVoto.MissFotogenia)).FirstOrDefault();
        }
    }
}
