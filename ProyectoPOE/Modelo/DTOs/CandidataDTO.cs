using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.DTOs
{
    public class CandidataDTO
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Carrera { get; set; }
        public string FotoPrincipal { get; set; }
        public int TotalVotosReina { get; set; }
        public int TotalVotosFotogenia { get; set; }
    }
}
