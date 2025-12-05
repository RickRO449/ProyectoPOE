using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.DTOs
{
    public class AlbumDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<FotoDTO> Fotos { get; set; }
    }
}
