using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Validadores
{
    public static class CandidataValidator
    {
        public static bool EsValida(Candidata candidata)
        {
            // Regla: nombre y carrera obligatorios
            return !string.IsNullOrWhiteSpace(candidata.NombreCompleto) &&
                   !string.IsNullOrWhiteSpace(candidata.Carrera);
        }
    }
}
