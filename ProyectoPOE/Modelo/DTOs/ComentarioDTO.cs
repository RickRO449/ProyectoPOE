using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.DTOs
{
    public class ComentarioDTO
    {
        public int Id { get; set; }
        public string AutorNombre { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
