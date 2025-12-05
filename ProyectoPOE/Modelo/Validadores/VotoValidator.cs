using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Validadores
{
    public static class VotoValidator
    {
        public static bool PuedeVotar(Estudiante estudiante, TipoVoto tipo)
        {
            // Regla: un estudiante no puede votar dos veces en la misma categoría
            return !estudiante.VotosEmitidos.Any(v => v.Tipo == tipo);
        }
    }
}
