using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOE.Modelo.Servicio
{
    public class VotacionService
    {
        public void RegistrarVoto(Estudiante estudiante, Candidata candidata, TipoVoto tipo)
        {
            if (!estudiante.VotosEmitidos.Any(v => v.Tipo == tipo))
            {
                var voto = new Voto(estudiante, candidata, tipo);
                estudiante.VotosEmitidos.Add(voto);
                candidata.Votos.Add(voto);
            }
            else
            {
                throw new InvalidOperationException("El estudiante ya votó en esta categoría.");
            }
        }
    }
}
