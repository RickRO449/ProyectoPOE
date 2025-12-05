using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public class Foto
    {
        public int IdFoto { get; private set; }
        public string RutaArchivo { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public List<Comentario> Comentarios { get; private set; } = new List<Comentario>();

        public Foto(int idFoto, string rutaArchivo, string titulo, string descripcion)
        {
            IdFoto = idFoto;
            RutaArchivo = rutaArchivo;
            Titulo = titulo;
            Descripcion = descripcion;
        }

        public void AgregarComentario(Comentario comentario)
        {
            Comentarios.Add(comentario);
        }
    }
}
