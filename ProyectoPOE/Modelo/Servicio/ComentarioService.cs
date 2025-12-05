using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Servicio
{
    public class ComentarioService
    {
        public void AgregarComentario(Estudiante estudiante, Foto foto, string texto)
        {
            var comentario = new Comentario(estudiante, texto);
            foto.AgregarComentario(comentario);
            estudiante.Comentarios.Add(comentario);
        }
    }
}
