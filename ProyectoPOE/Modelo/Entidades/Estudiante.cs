using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public class Estudiante : Persona
    {
        private string matricula;
        public string Matricula
        {
            get { return matricula; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("La matrícula no puede estar vacía.");
                matricula = value;
            }
        }

        public List<Voto> VotosEmitidos { get; private set; } = new List<Voto>();
        public List<Comentario> Comentarios { get; private set; } = new List<Comentario>();

        public Estudiante(int id, string nombre, string apellido, DateTime fechaNacimiento, string matricula)
            : base(id, nombre, apellido, fechaNacimiento)
        {
            Matricula = matricula;
        }

        public void Votar(Candidata candidata, TipoVoto tipo)
        {
            if (!VotosEmitidos.Any(v => v.Tipo == tipo))
            {
                var voto = new Voto(this, candidata, tipo);
                VotosEmitidos.Add(voto);
                candidata.Votos.Add(voto);
            }
        }

        public void Comentar(Foto foto, string texto)
        {
            var comentario = new Comentario(this, texto);
            foto.AgregarComentario(comentario);
            Comentarios.Add(comentario);
        }
    }
}
