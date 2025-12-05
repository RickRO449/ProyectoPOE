using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo
{
    public enum TipoVoto
    {
        Reina,
        MissFotogenia
    }

    public class Voto
    {
        public int IdVoto { get; private set; }
        public Estudiante Estudiante { get; private set; }
        public Candidata Candidata { get; private set; }
        public TipoVoto Tipo { get; private set; }
        public DateTime Fecha { get; private set; }

        public Voto(Estudiante estudiante, Candidata candidata, TipoVoto tipo)
        {
            Estudiante = estudiante;
            Candidata = candidata;
            Tipo = tipo;
            Fecha = DateTime.Now;
        }

        public string MostrarVoto()
        {
            return $"{Estudiante.ObtenerNombreCompleto()} votó por {Candidata.ObtenerNombreCompleto()} en {Tipo}";
        }
    }
}
