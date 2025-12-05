using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Validadores
{
    public static class MatriculaValidator
    {
        public static bool EsValida(string matricula)
        {
            // Regla: no puede estar vacía y debe tener al menos 5 caracteres
            return !string.IsNullOrWhiteSpace(matricula) && matricula.Length >= 5;
        }
    }
}
