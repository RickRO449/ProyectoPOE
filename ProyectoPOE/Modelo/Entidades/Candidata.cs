using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public class Candidata : Persona
    {
        public string Carrera { get; set; }
        public string FotoPrincipal { get; set; }
        public string Pasatiempos { get; set; }
        public string Habilidades { get; set; }
        public string Intereses { get; set; }
        public string Aspiraciones { get; set; }

        public List<AlbumFotos> Albumes { get; private set; } = new List<AlbumFotos>();
        public List<Voto> Votos { get; private set; } = new List<Voto>();

        public Candidata(int id, string nombre, string apellido, DateTime fechaNacimiento, string carrera)
            : base(id, nombre, apellido, fechaNacimiento)
        {
            Carrera = carrera;
        }

        public void AgregarAlbum(AlbumFotos album)
        {
            Albumes.Add(album);
        }

        public int ObtenerTotalVotos(TipoVoto tipo)
        {
            return Votos.Count(v => v.Tipo == tipo);
        }
    }
}
