using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public class AlbumFotos
    {
        public int IdAlbum { get; private set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Foto> Fotos { get; private set; } = new List<Foto>();

        public AlbumFotos(int idAlbum, string titulo, string descripcion)
        {
            IdAlbum = idAlbum;
            Titulo = titulo;
            Descripcion = descripcion;
        }

        public void AgregarFoto(Foto foto)
        {
            Fotos.Add(foto);
        }
    }
}
