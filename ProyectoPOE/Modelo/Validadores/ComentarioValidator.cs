using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Validadores
{
    public static class ComentarioValidator
    {
        public static bool EsTextoValido(string texto)
        {
            // Regla: no vacío y máximo 200 caracteres
            return !string.IsNullOrWhiteSpace(texto) && texto.Length <= 200;
        }
    }
}
