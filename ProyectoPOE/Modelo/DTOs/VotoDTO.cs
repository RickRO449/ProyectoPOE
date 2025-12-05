using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.DTOs
{
    public class VotoDTO
    {
        public int Id { get; set; }
        public string EstudianteNombre { get; set; }
        public string CandidataNombre { get; set; }
        public TipoVoto Tipo { get; set; }
        public DateTime Fecha { get; set; }
    }
}
