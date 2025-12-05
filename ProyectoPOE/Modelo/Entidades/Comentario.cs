using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public class Comentario
    {
        public int IdComentario { get; private set; }
        public Estudiante Autor { get; private set; }
        public string Texto { get; private set; }
        public DateTime Fecha { get; private set; }

        public Comentario(Estudiante autor, string texto)
        {
            Autor = autor;
            Texto = texto;
            Fecha = DateTime.Now;
        }

        public void EditarComentario(string nuevoTexto)
        {
            Texto = nuevoTexto;
        }

        public string MostrarComentario()
        {
            return $"{Autor.ObtenerNombreCompleto()} ({Fecha}): {Texto}";
        }
    }
}
